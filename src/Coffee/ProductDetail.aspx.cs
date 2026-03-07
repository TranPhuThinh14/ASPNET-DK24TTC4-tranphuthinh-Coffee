using System;
using System.Data.SqlClient;
using System.Configuration;

namespace Coffee
{
    public partial class ProductDetail : System.Web.UI.Page
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
                LoadProduct();
            }
        }

        void LoadProduct()
        {
            string id = Request.QueryString["id"];
            if (id == null) return;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT * FROM Products WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    lblName.Text = rd["Name"].ToString();
                    lblPrice.Text = rd["Price"].ToString() + " VNĐ";
                    lblDesc.Text = rd["Description"].ToString();

                    Session["productId"] = id;
                }
            }
        }

        protected void btnAddCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cart.aspx");
        }
    }
}
