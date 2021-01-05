using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AchieveDream.Pages.Message
{
    public partial class Message : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SwitchHandle();
        }

        protected void SwitchHandle()
        {
            HttpCookie work = Request.Cookies["work"];
            if (work["messageSwitchIndex"] != null)
            {
                if (work["messageSwitchIndex"].ToString() == "0")
                {
                    MessageComment.CssClass = "messageSwitch";
                    MessageReply.CssClass = "messageSwitch notSelected";
                }
                else if (work["messageSwitchIndex"].ToString() == "1")
                {
                    MessageComment.CssClass = "messageSwitch notSelected";
                    MessageReply.CssClass = "messageSwitch";
                }
                else
                {
                    MessageComment.CssClass = "messageSwitch";
                    MessageReply.CssClass = "messageSwitch notSelected";
                }
            }
            else
            {
                work["messageSwitchIndex"] = "0";
                Response.Cookies.Add(work);
            }
        }

        protected void Switch(object sender, EventArgs e)
        {
            string text = ((Button)sender).Text.ToString().Trim();
            if (text == "论坛评论")
            {
                HttpCookie work = Request.Cookies["work"];
                work["messageSwitchIndex"] = "0";
                Response.Cookies.Add(work);
            }
            else if (text == "聊天回复")
            {
                HttpCookie work = Request.Cookies["work"];
                work["messageSwitchIndex"] = "1";
                Response.Cookies.Add(work);
            }
            SwitchHandle();
        }
    }
}