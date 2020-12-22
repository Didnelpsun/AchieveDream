using System;
using System.Web;
using AchieveDream.Models;
//using System.Timers;

namespace AchieveDream.Pages.LogIn
{
    public partial class LogIn : System.Web.UI.Page
    {
        //private Timer timer = new Timer(1000);
        protected void Page_Init(object sender, EventArgs e)
        {
            //timer.AutoReset = true;
            //timer.Enabled = true;
            //timer.Elapsed += new ElapsedEventHandler(Time_Elapesd);
            //ViewState["time"] = 0;
            HttpCookie register = Request.Cookies["register"];
            if(register!= null)
            {
                if(register["username"] != null)
                {
                    Response.Redirect("../Home/Home.aspx");
                }
            }
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

        protected void Clear_Text(object sender, EventArgs e)
        {
            TextBox1.Text = "";
        }

        protected void TextMode_Change(object sender, EventArgs e)
        {
            bool textMode = !Convert.ToBoolean(ViewState["textMode"]);
            ViewState["textMode"] = textMode;
            if (textMode)
            {
                ChangeMode.ImageUrl = "/Resource/image/eye-close.png";
                TextBox2.TextMode = System.Web.UI.WebControls.TextBoxMode.Password;
            }
            else
            {
                ChangeMode.ImageUrl = "/Resource/image/eye-open.png";
                TextBox2.TextMode = System.Web.UI.WebControls.TextBoxMode.SingleLine;
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
            TextBox1.Text = "";
            TextBox2.Text = "";
            bool loginPattern = !Convert.ToBoolean(ViewState["loginPattern"]);
            ViewState["loginPattern"] = loginPattern;
            if (loginPattern)
            {
                PatternButton.Text = "账户登录 →";
                LIcon1.ImageUrl = "/Resource/image/phone.png";
                LIcon2.ImageUrl = "/Resource/image/message.png";
                TextBox2.TextMode = System.Web.UI.WebControls.TextBoxMode.SingleLine;
                ChangeMode.Visible = false;
                SendMsgBox.Visible = true;
                Forget.Visible = false;
                ChangePhone.Visible = true;
            }
            else
            {
                PatternButton.Text = "手机号登录 →";
                LIcon1.ImageUrl = "/Resource/image/user.png";
                LIcon2.ImageUrl = "/Resource/image/password.png";
                TextBox2.TextMode = System.Web.UI.WebControls.TextBoxMode.Password;
                ChangeMode.Visible = true;
                SendMsgBox.Visible = false;
                Forget.Visible = true;
                ChangePhone.Visible = false;
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string s1 = TextBox1.Text.ToString().Trim();
            string s2 = TextBox2.Text.ToString().Trim();
            if (s1 == "" || s2 == "")
            {
                AlertBoard.Visible = true;
                AlertText.Text = "输入值不应为空！";
                return;
            }
            bool mode = Convert.ToBoolean(ViewState["loginPattern"]);
            GetLogInReturn login = new GetLogInReturn(s1, s2, mode);
            if (login.data)
            {
                Response.Write("<script>alert('登录成功！')</script>");
                HttpCookie register = new HttpCookie("register");
                register["username"] = s1;
                register.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(register);
                Response.Redirect("../Home/Home.aspx");
            }
            else
            {
                AlertBoard.Visible = true;
                AlertText.Text = login.message;
            }
        }

        protected void Alert_Confirm(object sender, EventArgs e)
        {
            AlertBoard.Visible = false;
        }

        protected void Logon_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('dfdfd')</script>");
        }

        protected void Forget_Click(object sender, EventArgs e)
        {

        }
    }
}