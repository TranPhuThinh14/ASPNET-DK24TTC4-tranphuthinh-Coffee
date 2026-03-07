using System;
using System.Data.SqlClient;
using System.Configuration;

namespace Coffee
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["CoffeeDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"SELECT ISNULL(Role,'User') FROM Users WHERE Username=@u AND Password=@p";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                cmd.Parameters.AddWithValue("@p", txtPassword.Text);

                conn.Open();
                object role = cmd.ExecuteScalar();

                if (role != null)
                {
                    Session["username"] = txtUsername.Text;
                    Session["role"] = role.ToString();

                    if (role.ToString() == "Admin")
                        Response.Redirect("Users.aspx");

                    Response.Redirect("Home.aspx");
                    Response.Redirect("Users.aspx");
                }
                else
                {
                    lblMessage.Text = "Sai username hoặc password";
                }
            }
        }

    }
}
