using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LineBot_Sample
{
    public partial class _default : System.Web.UI.Page
    {
        const string channelAccessToken = "paQGMYJqzB/lGDt/dzWrnOK/NCkmgHeVW+r1ioprpaHKrQyjuOyP7aBnRPDeul25emoAwba3GNBdOuLo79HUWVT8o0dKHdyBTBJKEAPdsJ5yrqD47XybtUl3S3UpgGC2R320CwBvhyUezFbWGnC6RgdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId= "U2f9cd39233942d8a2fd2aab5bb977f7a";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, $"測試 {DateTime.Now.ToString()} ! ");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, 1,2);
        }
    }
}