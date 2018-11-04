using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    Random r = new Random();
    string[] arr = { "+", "-", "*", "/" };
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            init();
            Session["cnt"]=0;
        }        
    }

    private void init()
    {
        int m = r.Next(1, 100);
        int n = r.Next(1, 100);
        int o = r.Next(0,4);
        Literal1.Text = m + "";
        Literal2.Text = n + "";        
        string op = arr[o];
        double ans = 0;
        if (op == "+") { ans = m + n; } else if (op == "-") { ans = m - n; } else if (op == "*") { ans = m * n; } else {  ans = (float)m / n;  ans = Math.Round(ans, 2); }
        Literal3.Text = String.Format("{0}",ans);
        Session["op"] = op;
        DropDownList1.SelectedIndex = 0;
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex != 0) {

            //----------------------寫法1---------------------------
            //if (Session["op"].ToString() == DropDownList1.SelectedValue) { Response.Write("correct!!"); init(); }
            //else { Response.Write("wrong!!"); }


            //----------------------寫法2---------------------------
            string op = DropDownList1.SelectedValue;
            bool b = false;
            int m = int.Parse(Literal1.Text);
            int n = int.Parse(Literal2.Text);
            float ans = float.Parse(Literal3.Text);
            if (op == "+") { if (m + n == ans) { b = true; } }
            if (op == "-") { if (m - n == ans) { b = true; } }
            if (op == "*") { if (m * n == ans) { b = true; } }
            if (op == "/") { string s = Math.Round((float)m / n, 2).ToString(); if (s.Equals(ans.ToString())) { b = true; } }
            if (b) { Session["cnt"] = (int)Session["cnt"] + 1;   Literal4.Text+= String.Format("correct!! 目前答對{0}題<br />", Session["cnt"]);     init(); }
            else { Literal4.Text += String.Format("wrong!!!!!!!!! 目前答對{0}題<br />", Session["cnt"]); }
        }
        
    }
}