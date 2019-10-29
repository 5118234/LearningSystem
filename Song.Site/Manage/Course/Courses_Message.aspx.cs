using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


using WeiSha.Common;

using Song.ServiceInterfaces;
using Song.Entities;
using WeiSha.WebControl;

namespace Song.Site.Manage.Course
{
    public partial class Courses_Message : Extend.CustomPage
    {
        //�γ�id
        protected int couid = WeiSha.Common.Request.QueryString["couid"].Int32 ?? 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            //����ȷ����ť
            EnterButton btnEnter = (EnterButton)Master.FindControl("btnEnter");
            btnEnter.Visible = false;          
           
        }

    }
}
