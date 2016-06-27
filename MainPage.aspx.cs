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

public partial class MainPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
            if (Session["UserID"] == null)
                Response.Write("<script>alert('Bạn chưa đăng nhập!');location='./Default.aspx';</script>");
            else
            {
                divWelcom.InnerHtml = "<span style='color:red'>Chào mừng bạn " + Session["Username"] + "</span>";
            }
    }
}
