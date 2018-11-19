using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Product : System.Web.UI.Page
{
    string cn_str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\CAT\\Desktop\\WebSite1\\WebSite1\\App_Data\\data.mdf;Integrated Security=True";
    protected void Page_Load(object sender, EventArgs e)
    {
        using (SqlConnection cn = new SqlConnection(cn_str)) {
            cn.Open();
            string com_str = "Select *  From product";
            SqlCommand command = new SqlCommand(com_str, cn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Literal1.Text += String.Format("<tr> <td><img src='{0}' class='img_1' /></td > <td>{1}</td> <td>{2}</td > <td><input id='{3}' name'{3}' type='button' onclick='btn_click(this.id)' class='btn_1' value='more' /></td></tr>", reader["pro_img"], reader["pro_name"], reader["pro_price"], reader["pro_id"]);
            }
        }
            
    }

    
}