using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlTypes;

namespace Database_Lab
{
    public partial class BGcheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            datagridview.Visible = false;
            go_homepage_btn.Visible = false;
        }

        public void FillGrid()
        {
            bg_choice_lbl.Visible = false;
            bg_choice_tb.Visible = false;
            bg_userID_lbl.Visible = false;
            bg_userID_tb.Visible = false;
            bg_search_btn.Visible = false;
            bg_userName_lbl.Visible = false;
            bg_userName_tb.Visible = false;
            datagridview.Visible = true;
            go_homepage_btn.Visible = true;
            string connectionString = ConfigurationManager.ConnectionStrings["MS_connect_uesrTbl"].ConnectionString;
            String query = string.Empty;
            try
            {
                OleDbConnection conn = new OleDbConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                if (bg_choice_tb.Text.Trim() == "student")
                {
                    query = "SELECT student.* FROM UserTbl, student WHERE studentID=@userID AND studentName=@userName";
                }
                else if (bg_choice_tb.Text.Trim() == "teacher")
                {
                    query = "SELECT teacher.* FROM UserTbl, teacher WHERE teacherID=@userID AND teacherName=@userName";

                }
                else if (bg_choice_tb.Text.Trim() == "svcagent")
                {
                    query = "SELECT svcAgent.* FROM UserTbl, svcAgent WHERE agentID=@userID AND agentName=@userName";
                }

                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@userID", bg_userID_tb.Text.Trim());
                cmd.Parameters.AddWithValue("@userName", bg_userName_tb.Text.Trim());
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "mytable");
                datagridview.DataSource = ds.Tables[0];
                datagridview.DataBind();

                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void bg_search_btn_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        protected void datagrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                FillGrid();
                datagridview.PageIndex = e.NewPageIndex;
                datagridview.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void go_homepage_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Service Manage System.aspx");
        }
    }
}