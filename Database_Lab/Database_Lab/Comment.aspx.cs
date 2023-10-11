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
    public partial class Comment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_btn_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MS_connect_schedule"].ConnectionString;
            try
            {
                OleDbConnection conn = new OleDbConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                String query = "INSERT INTO comment (svcID, commenttxt, reviewer) VALUES (@svcID, @comment, @reviewer)";
                OleDbCommand sqlcmd = new OleDbCommand(query, conn);
                sqlcmd.Parameters.AddWithValue("@svcID", svcID_tb.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@comment", comment_tb.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@reviewer", Session["UserName"].ToString().Trim());          
                sqlcmd.ExecuteNonQuery();

                conn.Close();
                Response.Redirect("Service Manage System.aspx");

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