using System;
using System.Collections;

namespace AchieveDream.Pages.LogOn
{
    public partial class LogOn : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            Hashtable result = DAO.GetJobList();
            if(result.ContainsKey("data"))
            {
                Job.DataSource = result["data"];
                Job.SelectedIndex = -1;
                Job.DataValueField = "ID";
                Job.DataTextField = "Name";
                Job.DataBind();
            }
            else
            {
                Alert("注册程序出错", "Job数据库为空，\n三秒跳回登录界面！");
                Response.Write("<meta http-equiv='refresh' content='3;URL=../LogIn/LogIn.aspx'>");
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
                Alert("请输入用户名！");
                return;
            }
            if (passWord == "")
            {
                Alert("请输入密码！");
                return;
            }
            if(conmfirmWord == "")
            {
                Alert("请输入确认密码！");
                return;
            }
            if (passWord != conmfirmWord)
            {
                AlertBoard.Visible = true;
                Alert("密码不一致！");
                return;
            }
            if (Job.SelectedIndex == -1)
            {
                Alert("请选择工作或身份！");
                return;
            }
            if (idCode == "")
            {
                Alert("请输入身份证号！");
                return;
            }
            if (idCode.ToString().Trim().Length != 18)
            {
                Alert("身份证号长度出错！");
                return;
            }
            if (telephone == "")
            {
                Alert("请输入电话号码！");
                return;
            }
            if (telephone.ToString().Trim().Length != 11)
            {
                Alert("电话号码长度出错！");
                return;
            }
            Hashtable result = DAO.LogOn(userName, passWord, telephone, job, idCode);
            if (result.ContainsKey("data"))
            {
                Alert("注册成功", "请三秒后登入系统！");
                System.Threading.Thread.Sleep(3);
                Response.Write("<meta http-equiv='refresh' content='3;URL=../LogIn/LogIn.aspx'>");
            }
            else
            {
                Alert(result["message"].ToString().Trim());
            }
        }

        protected void Alert_Confirm(object sender, EventArgs e)
        {
            AlertBoard.Visible = false;
        }
    }
}