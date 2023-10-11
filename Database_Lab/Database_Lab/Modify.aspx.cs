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
    public partial class Modify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void insert_btn_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MS_connect_schedule"].ConnectionString;
            try
            {
                OleDbConnection conn = new OleDbConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                String query = "INSERT INTO schedule VALUES (@serviceID, @studentID, @studentName, @start_time, @end_time, @job_category)";
                OleDbCommand sqlcmd = new OleDbCommand(query, conn);
                sqlcmd.Parameters.AddWithValue("@serviceID", svcID_tb.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@studentID", stdID_tb.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@studentName", stdName_tb.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@start_time", svcdate_tb.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@end_time", svctime_tb.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@job_category", jc_tb.Text.Trim());
                sqlcmd.ExecuteNonQuery();

                conn.Close();
                Response.Redirect("Service Manage System.aspx");

            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void delete_btn_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MS_connect_schedule"].ConnectionString;
            try
            {
                OleDbConnection conn = new OleDbConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                String query = "DELETE FROM schedule WHERE serviceID = @dserviceID";
                OleDbCommand sqlcmd = new OleDbCommand(query, conn);
                sqlcmd.Parameters.AddWithValue("@dserviceID", delete_svcID_tb.Text.Trim());
                sqlcmd.ExecuteNonQuery();

                conn.Close();
                Response.Redirect("Service Manage System.aspx");

            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void cancel_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Service Manage System.aspx");
        }
    }
}