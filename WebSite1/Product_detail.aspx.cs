using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Product_detail : System.Web.UI.Page
{
    string cn_str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\CAT\\Desktop\\WebSite1\\WebSite1\\App_Data\\data.mdf;Integrated Security=True";
    protected void Page_Load(object sender, EventArgs e)
    {
        string pro_id = Request["pro_id"];

        using (SqlConnection cn = new SqlConnection(cn_str))
        {
            cn.Open();
            string com_str = "Select *  From product Where pro_id ='"+pro_id+"'";
            SqlCommand command = new SqlCommand(com_str, cn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Literal1.Text += String.Format("<img src='{0}' class='img_1' /><br />{1}<br />{2}<br />{3}<br /> ", reader["pro_img"], reader["pro_name"], reader["pro_price"], reader["pro_content"]);
                
            }
        }
    }
}