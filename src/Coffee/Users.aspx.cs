using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Coffee
{
    public partial class Users : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["CoffeeDB"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }
            lblUser.Text = Session["username"].ToString();
            if (Session["role"].ToString() != "Admin")
            {
                Response.Redirect("Login.aspx");
                return;
            }
            lblUser.Text = Session["username"].ToString();

            if (!IsPostBack)
            {
                LoadUsers();
                if (Session["role"].ToString() != "Admin")
                {
                    pnlAddUser.Visible = false;
                    gvUsers.Columns[3].Visible = false; // cột Edit/Delete
                }
            }
        }

        void LoadUsers()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvUsers.DataSource = dt;
                gvUsers.DataBind();
            }
        }

        // ADD
        protected void btnAdd_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "INSERT INTO Users(Username, Password) VALUES(@u,@p)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                cmd.Parameters.AddWithValue("@p", txtPassword.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadUsers();
        }
        // LOGOUT
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();      // xóa session
            Session.Abandon();    // hủy phiên đăng nhập
            Response.Redirect("Login.aspx");
        }

        // EDIT
        protected void gvUsers_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            gvUsers.EditIndex = e.NewEditIndex;
            LoadUsers();
        }

        protected void gvUsers_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            gvUsers.EditIndex = -1;
            LoadUsers();
        }

        protected void gvUsers_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            int id = (int)gvUsers.DataKeys[e.RowIndex].Value;
            string username = ((System.Web.UI.WebControls.TextBox)gvUsers.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string password = ((System.Web.UI.WebControls.TextBox)gvUsers.Rows[e.RowIndex].Cells[2].Controls[0]).Text;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "UPDATE Users SET Username=@u, Password=@p WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            gvUsers.EditIndex = -1;
            LoadUsers();
        }

        // DELETE
        protected void gvUsers_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            int id = (int)gvUsers.DataKeys[e.RowIndex].Value;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "DELETE FROM Users WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadUsers();
        }
    }
}
