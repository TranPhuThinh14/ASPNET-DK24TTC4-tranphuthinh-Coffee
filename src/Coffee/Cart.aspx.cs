using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Coffee
{
    public partial class Cart : System.Web.UI.Page
    {
        string connStr = ConfigurationManager
            .ConnectionStrings["CoffeeDB"]
            .ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }

            if (!IsPostBack)
            {
                AddToCart();
                BindCart();
            }
        }

        void AddToCart()
        {
            if (Session["productId"] == null) return;

            DataTable cart;

            if (Session["cart"] == null)
            {
                cart = new DataTable();
                cart.Columns.Add("ProductId");
                cart.Columns.Add("Name");
                cart.Columns.Add("Price", typeof(decimal));
                cart.Columns.Add("Quantity", typeof(int));
            }
            else
            {
                cart = (DataTable)Session["cart"];
            }

            string productId = Session["productId"].ToString();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT Name, Price FROM Products WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", productId);

                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    DataRow[] rows = cart.Select("ProductId=" + productId);
                    if (rows.Length > 0)
                    {
                        rows[0]["Quantity"] = (int)rows[0]["Quantity"] + 1;
                    }
                    else
                    {
                        DataRow r = cart.NewRow();
                        r["ProductId"] = productId;
                        r["Name"] = rd["Name"].ToString();
                        r["Price"] = rd["Price"];
                        r["Quantity"] = 1;
                        cart.Rows.Add(r);
                    }
                }
            }

            Session["cart"] = cart;
        }

        void BindCart()
        {
            if (Session["cart"] == null) return;

            DataTable cart = (DataTable)Session["cart"];
            gvCart.DataSource = cart;
            gvCart.DataBind();

            decimal total = 0;
            foreach (DataRow r in cart.Rows)
            {
                total += (decimal)r["Price"] * (int)r["Quantity"];
            }

            lblTotal.Text = "Tổng tiền: " + total.ToString("N0") + " VNĐ";
        }
        protected void gvCart_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            if (e.CommandName == "updateQty")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                DataTable cart = (DataTable)Session["cart"];
                GridViewRow row = gvCart.Rows[index];

                TextBox txtQty = (TextBox)row.FindControl("txtQty");
                int qty = int.Parse(txtQty.Text);

                if (qty <= 0)
                {
                    cart.Rows.RemoveAt(index); // xóa nếu qty <= 0
                }
                else
                {
                    cart.Rows[index]["Quantity"] = qty;
                }

                Session["cart"] = cart;
                BindCart();
            }
        }
        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }

            DataTable cart = Session["cart"] as DataTable;
            if (cart == null || cart.Rows.Count == 0)
            {
                lblResult.Text = "Giỏ hàng trống!";
                return;
            }

            decimal total = 0;
            foreach (DataRow row in cart.Rows)
            {
                total += Convert.ToDecimal(row["Price"]) * Convert.ToInt32(row["Quantity"]);
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // 1. Lưu Order
                string sqlOrder = @"
            INSERT INTO Orders (Username, Total)
            OUTPUT INSERTED.Id
            VALUES (@u, @t)";
                SqlCommand cmdOrder = new SqlCommand(sqlOrder, conn);
                cmdOrder.Parameters.AddWithValue("@u", Session["username"]);
                cmdOrder.Parameters.AddWithValue("@t", total);

                int orderId = (int)cmdOrder.ExecuteScalar();

                // 2. Lưu OrderDetails

                foreach (DataColumn col in cart.Columns)
                {
                    System.Diagnostics.Debug.WriteLine(col.ColumnName);
                }

                foreach (DataRow row in cart.Rows)
                {

                    string sqlDetail = @"
                INSERT INTO OrderDetails
                (OrderId, ProductId, Price, Quantity)
                VALUES (@oid,@pid,  @p, @q)";
                    SqlCommand cmdDetail = new SqlCommand(sqlDetail, conn);
                    cmdDetail.Parameters.AddWithValue("@oid", orderId);
                    cmdDetail.Parameters.AddWithValue("@pid", row["ProductId"]);
                    cmdDetail.Parameters.AddWithValue("@p", row["Price"]);
                    cmdDetail.Parameters.AddWithValue("@q", row["Quantity"]);
                    cmdDetail.ExecuteNonQuery();
                }
            }

            // 3. Xóa giỏ hàng
            Session["cart"] = null;
            lblResult.Text = "Đặt hàng thành công!";
        }


    }
}
