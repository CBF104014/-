using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    Random r = new Random();

    string eng = "name, open, cat, dog, sky, water, computer, book, cellphone";
    string chi = "姓名, 打開, 貓咪 ,狗 ,天空, 水, 電腦, 書, 手機";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack){

            string[] eng_val = eng.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] chi_val = chi.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < eng_val.Length; i++)
            {
                DropDownList1.Items.Add(new ListItem(eng_val[i], chi_val[i]));
            }
            Session["eng_val"] = eng_val;
            Session["chi_val"] = chi_val;
            Session["r1"] = 0;

        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Literal1.Text += String.Format("{0} -> {1}<br />", DropDownList1.SelectedItem.Text, DropDownList1.SelectedValue);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {        
        init();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string[] eng_val = (string[])Session["eng_val"];
        string[] chi_val = (string[])Session["chi_val"];
        int r1 = (int)Session["r1"];
        if (TextBox1.Text.Equals(eng_val[r1])) { Literal3.Text += "correct! <br />"; }
        else { Literal3.Text += "wrong! <br />"; }
        init();
    }


    private void init()
    {
        string[] eng_val = (string[])Session["eng_val"];
        string[] chi_val = (string[])Session["chi_val"];
        int r1 = r.Next(0, chi_val.Length);
        Session["r1"] = r1;
        Literal2.Text = chi_val[r1];
        string s = eng_val[r1][0].ToString();
        for (int i = 0; i < eng_val[r1].Length - 2; i++)
        {
            s += "_";
        }
        s += eng_val[r1][s.Length].ToString();
        TextBox1.Text = s;
        TextBox1.Focus();
        TextBox1.Attributes["onfocus"] = "this.select();";
    }
}