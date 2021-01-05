using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AchieveDream.Pages.Mine
{
    public partial class Mine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Page_Turn(object sender, EventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            string url = button.ImageUrl;
            switch (url){
                case "../../Resource/image/mine/个人资料.png":
                    Response.Redirect("../PersonalData/PersonalData.aspx");
                    break;
                case "../../Resource/image/mine/发布.png":
                    Response.Redirect("../Release/Release.aspx");
                    break;
                case "../../Resource/image/mine/好友.png":
                    Response.Redirect("../Friends/Friends.aspx");
                    break;
                case "../../Resource/image/mine/消息.png":
                    Response.Redirect("../Message/Message.aspx");
                    break;
                case "../../Resource/image/mine/账号安全.png":
                    Response.Redirect("../Safety/Safety.aspx");
                    break;
                case "../../Resource/image/mine/收藏.png":
                    Response.Redirect("../Collection/Collection.aspx");
                    break;
                case "../../Resource/image/mine/设置.png":
                    Response.Redirect("../Settings/Settings.aspx");
                    break;
            }
        }
    }
}