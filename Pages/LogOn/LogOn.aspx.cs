using System;
using System.Web;
using AchieveDream.Models;

namespace AchieveDream.Pages.LogOn
{
    public partial class LogOn : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            GetJobSet getJobSet = new GetJobSet();
            if(getJobSet.data != null)
            {
                Job.DataSource = getJobSet.data;
                Job.SelectedIndex = -1;
                Job.DataValueField = "ID";
                Job.DataTextField = "Name";
                Job.DataBind();
            }
            else
            {
                Alert("注册程序出错", "Job数据库为空！");
                System.Threading.Thread.Sleep(3);
                Response.Redirect("../LogIn/LogIn.aspx");
            }
        }

        private void Alert(string title, string text)
        {
            AlertBoard.Visible = true;
            AlertTitle.Text = title;
            AlertText.Text = text;
        }

        private void Alert(string text)
        {
            AlertBoard.Visible = true;
            AlertTitle.Text = "注册失败";
            AlertText.Text = text;
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string userName = UserName.Text.ToString().Trim();
            string passWord = PassWord.Text.ToString().Trim();
            string conmfirmWord = ConfirmWord.Text.ToString().Trim();
            int job = Convert.ToInt16(Job.SelectedValue);
            string idCode = IDCode.Text.ToString().Trim();
            string telephone = Telephone.Text.ToString().Trim();
            if (userName == "")
            {
                Alert("请输入用户名");
            }
            if (passWord != conmfirmWord)
            {
                AlertBoard.Visible = true;
                Alert("密码不一致！");
                return;
            }
            Models.LogOn logOn = new Models.LogOn(userName, passWord, conmfirmWord, job, idCode, telephone);
        }

        protected void Alert_Confirm(object sender, EventArgs e)
        {
            AlertBoard.Visible = false;
        }
    }
}