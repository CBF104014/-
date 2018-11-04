using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(! IsPostBack)
            Calendar1.SelectedDate = DateTime.Today;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Pre
        //Calendar1.SelectedDate = Calendar1.SelectedDate.AddDays(-7);
        //Literal1.Text = Calendar1.SelectedDate.ToShortDateString();
        fun(-1,"上");  
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //Next
        //Calendar1.SelectedDate = Calendar1.SelectedDate.AddDays(7);
        //Literal1.Text = Calendar1.SelectedDate.ToShortDateString();
        fun(1,"下");
    }


    private void fun(int add_day,string s)
    {
        DateTime d = DateTime.Today;
        int dayofweek = int.Parse(DropDownList1.SelectedValue);
        for (int i = 0; i < 7; i++)
        {
            d = d.AddDays(add_day);
            if ((int)d.DayOfWeek == dayofweek)
            {
                Literal1.Text = String.Format("距離今天最近的{0}{1}  >>  {2:d}",s, DropDownList1.SelectedItem.Text, d);
                Calendar1.SelectedDate = d;
                break;
            }
        }
    }
}