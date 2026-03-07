using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Coffee
{
    public partial class AdminStatistics : System.Web.UI.Page
    {
        string connStr = ConfigurationManager
    .ConnectionStrings["CoffeeDB"]
    .ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            



        }

        protected void btnStat_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"
        SELECT o.Id, o.OrderDate,
               SUM(od.Quantity * od.Price) AS Total
        FROM Orders o
        JOIN OrderDetails od ON o.Id = od.OrderId
        WHERE o.OrderDate BETWEEN @from AND @to
        GROUP BY o.Id, o.OrderDate";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@from", txtFrom.Text);
                cmd.Parameters.AddWithValue("@to", txtTo.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gvRevenue.DataSource = dt;
                gvRevenue.DataBind();

                decimal sum = 0;
                foreach (DataRow row in dt.Rows)
                    sum += Convert.ToDecimal(row["Total"]);

                lblTotal.Text = "Tổng doanh thu: " + sum.ToString("N0") + " VNĐ";

                string sql2 = @"
SELECT p.Name,
       SUM(od.Quantity) AS TotalSold
FROM OrderDetails od
JOIN Products p ON od.ProductId = p.Id
GROUP BY p.Name
ORDER BY TotalSold DESC";

                SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);

                gvTopProducts.DataSource = dt2;
                gvTopProducts.DataBind();

            }

        }


    }
}