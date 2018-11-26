using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text;

public partial class _Default : System.Web.UI.Page
{
    string cn_str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Downloads\\WebSite1\\App_Data\\data.mdf;Integrated Security=True";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            Session["id"] = null;
        }        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Literal1.Text = "";
        string id = TextBox1.Text;
        string pass = TextBox2.Text;
        using (SqlConnection cn = new SqlConnection(cn_str))
        {
            bool b = false;
            cn.Open();
            string com_str = "Select *  From login";
            SqlCommand command = new SqlCommand(com_str, cn);            
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                if (reader["id"].Equals(id) && reader["pass"].Equals(pass))
                {
                    //Response.Output.Write("<script>alert('welcome {0}!!')</script>", id);
                    Session["id"] = id;                    
                    Send_mail();
                    b = true;
                    break;
                }
            }

            if (b == false) { Literal1.Text = "<div class='alert alert-light' role='alert'><strong>Incorrect username or password !</strong><button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>&times;</span></button></div>"; }
        }
    }

    private void Send_mail()
    {
        Random r = new Random();
        string ver = "";
        for (int i = 0; i < 5; i++)
        {
            int r1 = r.Next(65, 123);
            while (!((r1 > 64 && r1 < 91) || (r1 > 96 && r1 < 123))) {
                r1 = r.Next(65, 123);
            }
            ver += (char)r1+"";
        }
        MailMessage mail = new MailMessage();

        mail.From = new MailAddress("qwwewe567@gmail.com", "Mine");         //設定寄件者
        mail.To.Add(new MailAddress("qwwewe56793@gmail.com"));              //設定收件者
        mail.Priority = MailPriority.Normal;                                //優先等級
        mail.Subject = "Mine-登入驗證碼";                                   //主旨
        mail.Body = Server.HtmlEncode("你的驗證碼為：" + ver);              //Email 內容
        mail.SubjectEncoding = Encoding.UTF8;
        mail.BodyEncoding = Encoding.GetEncoding("utf-8");                  //設定編碼為 utf-8
        mail.IsBodyHtml = true;                                             //設定Email 內容為HTML格式

        SmtpClient smtpServer = new SmtpClient();                           //SMTP Server
        smtpServer.Credentials = new System.Net.NetworkCredential("qwwewe567@gmail.com", "asdsdf567");  //帳號及密碼認證
        smtpServer.Port = 587;                                              //ref http://mail.google.com/support/bin/answer.py?hl=en&answer=13287
        smtpServer.Host = "smtp.gmail.com";                                 //指定寄信 SMTP 伺服器
        smtpServer.EnableSsl = true;                                        //啟用 SSL
        try {
            smtpServer.Send(mail);                                          //寄出郵件
            Session["ver"] = ver;
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "document.getElementById('open').click();", true);
            //Response.Output.Write("<script>alert('{0}')</script>", "傳送成功");
        } catch (Exception) {
            Response.Output.Write("<script>alert('{0}')</script>", "傳送失敗");
        }
    }

    protected void Button2_Click1(object sender, EventArgs e)
    {
        if (Session["ver"] != null) {
            if (Session["ver"].ToString() == ver_text.Value)
            {
                Response.Redirect("index.aspx");
            }
            else {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "document.getElementById('open').click();", true);
                Label1.Text = "驗證碼錯誤!";
            }
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Send_mail();
        Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "document.getElementById('open').click();", true);
        Label1.Text = "";
    }
}