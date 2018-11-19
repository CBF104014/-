using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Button bt = (Button)sender;
        string btid = bt.CommandName.ToString();
        try
        {
            //SqlDataSource1.UpdateCommand = "UPDATE login SET pass = 'AAA' WHERE Id = '"+btid+"'";

            SqlDataSource1.UpdateCommand = String.Format("UPDATE login SET pass='{0}' WHERE Id='{1}'", "123", btid);
            SqlDataSource1.Update();
            GridView1.DataBind();
            Response.Write(btid);
        }
        catch (Exception ee)
        {
            Response.Write(ee.Message);
            throw;
        }
    }
}