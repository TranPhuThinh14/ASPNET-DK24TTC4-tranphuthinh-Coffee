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
        protected void btnSearchUser_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchUser.Text.Trim();
            BindMenu(keyword);
        }

        void BindMenu(string search = "")
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                // Câu lệnh SQL tìm kiếm tương đối theo yêu cầu số 7
                string sql = "SELECT * FROM Products";
                if (!string.IsNullOrEmpty(search))
                {
                    sql += " WHERE Name LIKE @name";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                if (!string.IsNullOrEmpty(search))
                {
                    cmd.Parameters.AddWithValue("@name", "%" + search + "%");
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Đổ dữ liệu vào control hiển thị (DataList hoặc GridView của Thịnh)
                dlProducts.DataSource = dt;
                dlProducts.DataBind();

                // Nếu không tìm thấy món nào, có thể thông báo cho khách
                if (dt.Rows.Count == 0)
                {
                    // Hiển thị thông báo: "Rất tiếc, quán chưa có món này!"
                }
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
