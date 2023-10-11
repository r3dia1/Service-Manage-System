using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database_Lab
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bg_create_btn_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MS_connect_uesrTbl"].ConnectionString;
            try
            {
                OleDbConnection conn = new OleDbConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string user_cate = string.Empty;
                if (cate_tb.Text.Trim() == "student")
                    user_cate = "2";
                else if(cate_tb.Text.Trim() == "teacher")
                    user_cate = "1";
                else if(cate_tb.Text.Trim() == "svcagent")
                    user_cate = "0";

                String query = "INSERT INTO UserTbl (UserName, Passward, cate) VALUES (@username, @password, @cate)";
                OleDbCommand sqlcmd = new OleDbCommand(query, conn);
                sqlcmd.Parameters.AddWithValue("@username", userName_tb.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@password", ps_tb.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@cate", user_cate);
                sqlcmd.ExecuteNonQuery();

                if (cate_tb.Text.Trim() == "student")
                {
                    String query1 = "INSERT INTO student (studentID, studentName) VALUES (@st_ID, @st_name)";
                    OleDbCommand sqlcmd1 = new OleDbCommand(query1, conn);
                    sqlcmd1.Parameters.AddWithValue("@st_ID", ID_tb.Text.Trim());
                    sqlcmd1.Parameters.AddWithValue("@st_name", userName_tb.Text.Trim());
                    sqlcmd1.ExecuteNonQuery();
                }
                else if (cate_tb.Text.Trim() == "teacher")
                {
                    String query1 = "INSERT INTO teacher (teacherID, teacherName) VALUES (@t_ID, @t_name)";
                    OleDbCommand sqlcmd1 = new OleDbCommand(query1, conn);
                    sqlcmd1.Parameters.AddWithValue("@t_ID", ID_tb.Text.Trim());
                    sqlcmd1.Parameters.AddWithValue("@t_name", userName_tb.Text.Trim());
                    sqlcmd1.ExecuteNonQuery();
                }
                else if (cate_tb.Text.Trim() == "svcagent")
                {
                    String query1 = "INSERT INTO svcAgent (agentID, agentName) VALUES (@sa_ID, @sa_name)";
                    OleDbCommand sqlcmd1 = new OleDbCommand(query1, conn);
                    sqlcmd1.Parameters.AddWithValue("@sa_ID", ID_tb.Text.Trim());
                    sqlcmd1.Parameters.AddWithValue("@sa_name", userName_tb.Text.Trim());
                    sqlcmd1.ExecuteNonQuery();
                }

                conn.Close();
                Response.Redirect("login page.aspx");
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void go_loginpage_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("login page.aspx");
        }
    }
}