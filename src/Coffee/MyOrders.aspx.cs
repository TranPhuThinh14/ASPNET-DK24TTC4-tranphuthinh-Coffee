using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Coffee
{
    public partial class MyOrders : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["CoffeeDB"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }

            if (!IsPostBack)
            {
                LoadOrders();
            }
        }

        void LoadOrders()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"
                    SELECT Id, Total, CreatedAt
                    FROM Orders
                    WHERE Username = @u
                    ORDER BY CreatedAt DESC";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", Session["username"]);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gvOrders.DataSource = dt;
                gvOrders.DataBind();
            }
        }
    }
}
