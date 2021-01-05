using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AchieveDream.Pages.PersonalData
{
    public partial class PersonalData : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            bool status = false;
            HttpCookie work = Request.Cookies["work"];
            if (work["personalDataStatus"] == null)
            {
                work["personalDataStatus"] = status.ToString();
                Response.Cookies.Add(work);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Change_Status(bool status)
        {
            NickName.Enabled = status;
            Description.Enabled = status;
            Sex.Enabled = status;
            Birthday.Enabled = status;
            Location.Enabled = status;
            NowSchool.Enabled = status;
            DreamSchool.Enabled = status;
            if (status)
            {
                Submit.Text = "完成";
            }
            else
            {
                Submit.Text = "编辑";
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            HttpCookie work = Request.Cookies["work"];
            bool status = Convert.ToBoolean(work["personalDataStatus"]);
            work["personalDataStatus"] = (!status).ToString();
            Change_Status(!status);
            if (status)
            {

            }
            Response.Cookies.Add(work);
        }
    }
}