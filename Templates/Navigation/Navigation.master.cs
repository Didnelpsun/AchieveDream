using System;
using System.Web;
using System.Web.UI.WebControls;

namespace AchieveDream.Templates.Navigation
{
    public partial class Navigation : System.Web.UI.MasterPage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            SwitchHandle();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            SwitchHandle();
        }

        protected void SwitchHandle()
        {
            HttpCookie work = Request.Cookies["work"];
            if (work != null)
            {
                if (work["switchIndex"] != null)
                {
                    if (work["switchIndex"].ToString() == "0")
                    {
                        SwitchHome.CssClass = "switchButton switchChoose cc";
                        SwitchForum.CssClass = "switchButton cc";
                        SwitchCustom.CssClass = "switchButton cc";
                        SwitchMine.CssClass = "switchButton cc";
                    }
                    else if (work["switchIndex"].ToString() == "1")
                    {
                        SwitchHome.CssClass = "switchButton cc";
                        SwitchForum.CssClass = "switchButton switchChoose cc";
                        SwitchCustom.CssClass = "switchButton cc";
                        SwitchMine.CssClass = "switchButton cc";
                    }
                    else if (work["switchIndex"].ToString() == "2")
                    {
                        SwitchHome.CssClass = "switchButton cc";
                        SwitchForum.CssClass = "switchButton cc";
                        SwitchCustom.CssClass = "switchButton switchChoose cc";
                        SwitchMine.CssClass = "switchButton cc";
                    }
                    else if (work["switchIndex"].ToString() == "3")
                    {
                        SwitchHome.CssClass = "switchButton cc";
                        SwitchForum.CssClass = "switchButton cc";
                        SwitchCustom.CssClass = "switchButton cc";
                        SwitchMine.CssClass = "switchButton switchChoose cc";
                    }
                    else
                    {
                        SwitchHome.CssClass = "switchButton switchChoose cc";
                        SwitchForum.CssClass = "switchButton cc";
                        SwitchCustom.CssClass = "switchButton cc";
                        SwitchMine.CssClass = "switchButton cc";
                    }
                }
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
                HttpCookie work = Request.Cookies["work"];
                work["switchIndex"] = "0";
                Response.Cookies.Add(work);
                Response.Redirect("../../Pages/Home/Home.aspx");
            }
            else if(text == "论坛")
            {
                HttpCookie work = Request.Cookies["work"];
                work["switchIndex"] = "1";
                Response.Cookies.Add(work);
                Response.Redirect("../../Pages/Forum/Forum.aspx");
            }
            else if(text == "定制")
            {
                HttpCookie work = Request.Cookies["work"];
                work["switchIndex"] = "2";
                Response.Cookies.Add(work);
                Response.Redirect("../../Pages/Custom/Custom.aspx");
            }
            else if(text == "我的")
            {
                HttpCookie work = Request.Cookies["work"];
                work["switchIndex"] = "3";
                Response.Cookies.Add(work);
                Response.Redirect("../../Pages/Mine/Mine.aspx");
            }
        }
    }
}