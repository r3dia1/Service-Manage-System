using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Data.OleDb;
using System.Collections.Specialized;

namespace Database_Lab
{
    public partial class login_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrorMsg.Visible = false;
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MS_connect_uesrTbl"].ConnectionString;
            
            try
            {
                OleDbConnection conn = new OleDbConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                String query1 = "SELECT cate FROM UserTbl WHERE UserName=@username";
                OleDbCommand cmd1 = new OleDbCommand(query1, conn);
                cmd1.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
                int cate = Convert.ToInt32(cmd1.ExecuteScalar());
                Session["cate"] = cate;

                String query = "SELECT COUNT(1) FROM UserTbl WHERE UserName=@username AND Password=@password";
                OleDbCommand sqlcmd = new OleDbCommand(query, conn);
                sqlcmd.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                int count = Convert.ToInt32(sqlcmd.ExecuteScalar());
                if(count == 1)
                {
                    Session["UserName"] = txtUserName.Text.Trim();
                    Response.Redirect("Service Manage System.aspx");
                }
                else
                {
                    lblErrorMsg.Visible = true;
                }

                
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}