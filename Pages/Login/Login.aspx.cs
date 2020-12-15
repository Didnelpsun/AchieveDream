using System;
using System.Web;
using AchieveDream.Objects;

namespace AchieveDream.Pages.LogIn
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie login = new HttpCookie("login");
            login["loginPattern"] = "false";
            login["textMode"] = "true";
            Response.Cookies.Add(login);
        }

        protected void TextMode_Change(object sender, EventArgs e)
        {
            HttpCookie login = Request.Cookies["login"];
            bool textMode = !Convert.ToBoolean(login["textMode"]);
            login["textMode"] = (textMode).ToString();
            Response.Cookies.Add(login);
            if (textMode)
            {
                rIcon.ImageUrl = "/Resource/image/eye-close.png";
                password.TextMode = System.Web.UI.WebControls.TextBoxMode.Password;
            }
            else
            {
                rIcon.ImageUrl = "/Resource/image/eye-open.png";
                password.TextMode = System.Web.UI.WebControls.TextBoxMode.SingleLine;
            }
        }

        protected void Pattern_Change(object sender, EventArgs e)
        {
            HttpCookie login = Request.Cookies["login"];
            bool loginPattern = !Convert.ToBoolean(login["loginPattern"]);
            login["loginPattern"] = (loginPattern).ToString();
            Response.Cookies.Add(login);
            if (loginPattern)
            {
                patternButton.Text = "账户登录 →";
                lIcon1.ImageUrl = "/Resource/image/phone.png";
                lIcon2.ImageUrl = "/Resource/image/message.png";
                rIcon.Visible = false;
                forget.Visible = false;
                changePhone.Visible = true;
            }
            else
            {
                patternButton.Text = "手机号登录 →";
                lIcon1.ImageUrl = "/Resource/image/user.png";
                lIcon2.ImageUrl = "/Resource/image/password.png";
                rIcon.Visible = true;
                forget.Visible = true;
                changePhone.Visible = false;
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            User user = new User(username.Text.ToString().Trim(), password.Text.ToString().Trim());
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