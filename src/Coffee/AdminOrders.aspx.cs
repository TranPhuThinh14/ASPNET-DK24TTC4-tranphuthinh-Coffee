using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Coffee
{
    public partial class AdminOrders : System.Web.UI.Page
    {
        string connStr = ConfigurationManager
            .ConnectionStrings["CoffeeDB"]
            .ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null || Session["role"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }

            if (Session["role"].ToString() != "Admin")
            {
                Response.Redirect("Home.aspx");
                return;
            }

            if (!IsPostBack)
            {
                LoadOrders();
                LoadRevenue();
            }
            void LoadOrders()
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string sql = @"
        SELECT Id, Username, Total, CreatedAt
        FROM Orders
        ORDER BY CreatedAt DESC";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    gvOrders.DataSource = dt;
                    gvOrders.DataBind();
                }
            }
            void LoadRevenue()
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string sql = "SELECT ISNULL(SUM(Total),0) FROM Orders";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();

                    decimal revenue = Convert.ToDecimal(cmd.ExecuteScalar());
                    lblRevenue.Text = "Tổng doanh thu: " + revenue.ToString("N0") + " VNĐ";
                }
            }


        }

    }
}