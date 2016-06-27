using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*if (Session["UserID"] != null)
        {
            Response.Write("<script>alert('Bạn đã đăng nhập');location='./Default.aspx';</script>");
            Response.End();
        }*/
    }
    protected void btnDangnhap_Click(object sender, EventArgs e)
    {
        /*String connectionString = "server=.;uid=sa;database=SQLINJECTION_DEMO";*/

        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nguye\Dropbox\Documents\Edu\ATBMDL\SQL_INJECTION\App_Data\SQLJNJECTION_DEMO.mdf;Integrated Security=True";
        SqlConnection sqlInjectionDemo = new SqlConnection(connectionString);
        
        try
        {
            sqlInjectionDemo.Open();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string strSql = "SELECT PK_iUserID,sUsername,sPassword FROM tblUsers WHERE sUsername='" + username + "' AND sPassword='" + password + "'";
            //using (SqlCommand cmd = new SqlCommand("tblUser_getByUserNamePass", sqlInjectionDemo))
            using (SqlCommand cmd = new SqlCommand(strSql, sqlInjectionDemo))
            {
                /*cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@sUsername", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@sPassword", SqlDbType.NVarChar));
                cmd.Parameters[0].Value = username;
                cmd.Parameters[1].Value = password;
                */
                DataSet dset = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dset);
                if (dset.Tables[0].Rows.Count <= 0)
                {
                    Response.Write("<script>alert('Đăng nhập không thành công');location='./Default.aspx';</script>");
                    //lblSQL.Text = strSql;
                }
                else
                {
                    Session["UserID"] = dset.Tables[0].Rows[0]["PK_iUserID"];
                    Session["Username"] = dset.Tables[0].Rows[0]["sUsername"];
                    //Response.Write("<script>alert('Đăng nhập thành công');location='./MainPage.aspx';</script>");
                    Response.Write("<script>alert('Đăng nhập thành công')</script>");
                }
                //Response.Write("<script>alert('"+strSql+"');</script>");
                //lblSQL.Text = strSql;
            }
                
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('"+ex.Message+"')</script>");
        }
        finally { sqlInjectionDemo.Close(); }
    }
}
