using System;
using System.Web;

namespace AchieveDream.Pages.Home
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie register = Request.Cookies["register"];
            if (register == null)
            {
                Response.Redirect("../LogIn/LogIn.aspx");
                
            }
            else
            {
                if (register["username"] == null)
                {
                    Response.Redirect("../LogIn/LogIn.aspx");
                }
            }
        }
    }
}