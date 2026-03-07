using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Coffee
{
    public partial class OrderDetails : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["CoffeeDB"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }

            if (Request.QueryString["orderId"] == null)
            {
                Response.Redirect("MyOrders.aspx");
                return;
            }

            if (!IsPostBack)
            {
                int orderId = int.Parse(Request.QueryString["orderId"]);
                lblOrderId.Text = "Mã đơn hàng: " + orderId;
                LoadOrderDetails(orderId);
            }
        }

        void LoadOrderDetails(int orderId)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"
                SELECT 
                    p.Name AS ProductName,
                    od.Price,
                    od.Quantity,
                    (od.Price * od.Quantity) AS Total
                FROM OrderDetails od
                JOIN Products p ON od.ProductId = p.Id
                JOIN Orders o ON od.OrderId = o.Id
                WHERE od.OrderId = @oid
                  AND o.Username = @u";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@oid", orderId);
                cmd.Parameters.AddWithValue("@u", Session["username"]);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gvDetails.DataSource = dt;
                gvDetails.DataBind();
            }
        }
    }
}
