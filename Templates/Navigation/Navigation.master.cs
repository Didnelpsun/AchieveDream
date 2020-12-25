using System;
using System.Web;
using System.Web.UI.WebControls;

namespace AchieveDream.Templates.Navigation
{
    public partial class Navigation : System.Web.UI.MasterPage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            HttpCookie work = Request.Cookies["work"];
            if(work != null)
            {

            }
            else
            {
                work = new HttpCookie("work");
                work["switchIndex"] = "0";
                Response.Cookies.Add(work);
                Response.Redirect("../../Pages/Home/Home.aspx");
            }
        }

        protected void Switch(object sender, EventArgs e)
        {
            string text = ((Button)sender).Text.ToString().Trim();
            if(text == "首页")
            {
                ViewState["index"] = 0;
                SwitchHome.CssClass = "switchButton switchChoose cc";
                SwitchForum.CssClass = "switchButton cc";
                SwitchCustom.CssClass = "switchButton cc";
                SwitchMine.CssClass = "switchButton cc";
                Response.Redirect("../../Pages/Home/Home.aspx");
            }
            else if(text == "论坛")
            {
                ViewState["index"] = 1;
                SwitchHome.CssClass = "switchButton cc";
                SwitchForum.CssClass = "switchButton switchChoose cc";
                SwitchCustom.CssClass = "switchButton cc";
                SwitchMine.CssClass = "switchButton cc";
                Response.Redirect("../../Pages/Forum/Forum.aspx");
            }
            else if(text == "定制")
            {
                ViewState["index"] = 2;
                SwitchHome.CssClass = "switchButton cc";
                SwitchForum.CssClass = "switchButton cc";
                SwitchCustom.CssClass = "switchButton switchChoose cc";
                SwitchMine.CssClass = "switchButton cc";
                Response.Redirect("../../Pages/Custom/Custom.aspx");
            }
            else if(text == "我的")
            {
                ViewState["index"] = 3;
                SwitchHome.CssClass = "switchButton cc";
                SwitchForum.CssClass = "switchButton cc";
                SwitchCustom.CssClass = "switchButton cc";
                SwitchMine.CssClass = "switchButton switchChoose cc";
                Response.Redirect("../../Pages/Mine/Mine.aspx");
            }
        }
    }
}