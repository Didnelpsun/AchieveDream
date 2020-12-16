using System;
//using System.Timers;

namespace AchieveDream.Pages.LogIn
{
    public partial class LogIn : System.Web.UI.Page
    {
        //private Timer timer = new Timer(1000);
        protected void Page_Init(object sender, EventArgs e)
        {
            //HttpCookie login = new HttpCookie("login");
            //if (login["loginPattern"] == null)
            //{
            //    login["loginPattern"] = "false";
            //    Response.Cookies.Add(login);
            //}
            //if(login["textMode"] == null)
            //{
            //    login["textMode"] = "true";
            //    Response.Cookies.Add(login);
            //}
            //timer.AutoReset = true;
            //timer.Enabled = true;
            //timer.Elapsed += new ElapsedEventHandler(Time_Elapesd);
            //ViewState["time"] = 0;
            if (ViewState["loginPattern"] == null)
            {
                // 账户登录
                ViewState["loginPattern"] = false;
            }
            if (ViewState["textMode"] == null)
            {
                ViewState["textMode"] = true;
            }
        }

        protected void TextMode_Change(object sender, EventArgs e)
        {
            bool textMode = !Convert.ToBoolean(ViewState["textMode"]);
            ViewState["textMode"] = textMode;
            if (textMode)
            {
                rIcon.ImageUrl = "/Resource/image/eye-close.png";
                textBox2.TextMode = System.Web.UI.WebControls.TextBoxMode.Password;
            }
            else
            {
                rIcon.ImageUrl = "/Resource/image/eye-open.png";
                textBox2.TextMode = System.Web.UI.WebControls.TextBoxMode.SingleLine;
            }
        }

        //protected void Send_Message(object sender, EventArgs e)
        //{
        //    if (Convert.ToInt16(ViewState["time"]) == 0)
        //    {
        //        ViewState["time"] = 60;
        //        timer.Start();
        //    }
        //}

        //private void Time_Elapesd(object sender, ElapsedEventArgs e)
        //{
        //    int time = Convert.ToInt16(ViewState["time"]);
        //    if (time <= 0)
        //    {
        //        timer.Stop();
        //        sendMsgBox.Text = "获取验证码";
        //    }
        //    else
        //    {
        //        time--;
        //        ViewState["time"] = time;
        //        sendMsgBox.Text = time + "S后重获";
        //    }
        //}

        protected void Pattern_Change(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            bool loginPattern = !Convert.ToBoolean(ViewState["loginPattern"]);
            ViewState["loginPattern"] = loginPattern;
            //Response.Write("<script>alert('" + loginPattern + "')</script>");
            if (loginPattern)
            {
                patternButton.Text = "账户登录 →";
                lIcon1.ImageUrl = "/Resource/image/phone.png";
                lIcon2.ImageUrl = "/Resource/image/message.png";
                textBox2.TextMode = System.Web.UI.WebControls.TextBoxMode.SingleLine;
                rIcon.Visible = false;
                sendMsgBox.Visible = true;
                forget.Visible = false;
                changePhone.Visible = true;
            }
            else
            {
                patternButton.Text = "手机号登录 →";
                lIcon1.ImageUrl = "/Resource/image/user.png";
                lIcon2.ImageUrl = "/Resource/image/password.png";
                textBox2.TextMode = System.Web.UI.WebControls.TextBoxMode.Password;
                rIcon.Visible = true;
                sendMsgBox.Visible = false;
                forget.Visible = true;
                changePhone.Visible = false;
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {

        }

        protected void Forget_Click(object sender, EventArgs e)
        {

        }

        protected void Logon_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('dfdfd')</script>");
        }
    }
}