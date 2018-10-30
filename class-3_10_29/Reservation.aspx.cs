using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    string chi = "單人房, 雙人房, 三人房, 四人房";
    string eng = "single, double, triple, quad";
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {            
            string[] chi_text = eng.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] eng_value = chi.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < chi_text.Length; i++)
            {
                DropDownList1.Items.Add(new ListItem(eng_value[i], chi_text[i]));
            }
        }
    }


    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Calendar1.Visible = !Calendar1.Visible;
    }    

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Calendar2.Visible = !Calendar2.Visible;
    }    

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox1.Text = Calendar1.SelectedDate.ToString("d");
        Calendar1.Visible = false;
    }

    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {        
        if (Calendar2.SelectedDate.Subtract(Calendar1.SelectedDate).TotalDays >= 0) { TextBox2.Text = Calendar2.SelectedDate.ToString("d"); Calendar2.Visible = false; }
        else { Response.Output.Write("<script>alert('{0}')</script>", "退房日期須大於等於訂房日期！"); }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text != "" && TextBox2.Text != "") {
            Literal1.Text = String.Format("訂房日期：{0}<br />退房日期：{1}<br />房型：{2}<br />共{3}晚<br />",TextBox1.Text,TextBox2.Text,DropDownList1.SelectedValue, Calendar2.SelectedDate.Subtract(Calendar1.SelectedDate).TotalDays);
        }        
    }
}