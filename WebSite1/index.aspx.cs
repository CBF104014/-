using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Response.Output.Write("<script>alert('welcome {0}!!')</script>", Session["id"]);
        if (Session["id"] == null)
        {
            Response.Redirect("login.aspx");
        }
        else
        {
            Response.Output.Write("<script>alert('welcome {0}!!')</script>", Session["id"]);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Product.aspx");
    }
}