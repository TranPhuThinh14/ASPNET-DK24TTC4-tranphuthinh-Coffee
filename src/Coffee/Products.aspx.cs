using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Coffee
{
    public partial class Products : System.Web.UI.Page
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
                LoadProducts();
            }
        }

        void LoadProducts()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT Id, Name, Price, Description FROM Products";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gvProducts.DataSource = dt;
                gvProducts.DataBind();
            }
        }
    }
}
