using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Coffee
{
    public partial class TestDB : System.Web.UI.Page
    {
        protected void btnTest_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["CoffeeDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    lblResult.Text = "✅ KẾT NỐI DATABASE THÀNH CÔNG";
                }
                catch (Exception ex)
                {
                    lblResult.Text = "❌ LỖI KẾT NỐI: " + ex.Message;
                }
            }
        }
    }
}
