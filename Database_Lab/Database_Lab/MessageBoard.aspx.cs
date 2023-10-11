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
    public partial class MessageBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        public void FillGrid()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MS_connect_schedule"].ConnectionString;
                OleDbConnection conn = new OleDbConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                String query = "SELECT nickname, messagetxt FROM message_board";
                OleDbCommand sqlcmd = new OleDbCommand(query, conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(sqlcmd);
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

                String query = "INSERT INTO message_board(nickname, messagetxt) VALUES (@nickname, @messagetxt)";
                OleDbCommand sqlcmd = new OleDbCommand(query, conn);
                sqlcmd.Parameters.AddWithValue("@nickname", nickname.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@messagetxt", myInput.Text.Trim());
                sqlcmd.ExecuteNonQuery();

                conn.Close();
                //Response.Redirect("Service Manage System.aspx");
                nickname.Text = "";
                myInput.Text = "";
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

                String query = "DELETE FROM message_board WHERE nickname = @nickname";
                OleDbCommand sqlcmd = new OleDbCommand(query, conn);
                sqlcmd.Parameters.AddWithValue("@nickname", nickname.Text.Trim());
                sqlcmd.ExecuteNonQuery();

                conn.Close();
                //Response.Redirect("Service Manage System.aspx");
                nickname.Text = "";
                myInput.Text = "";
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void home_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Service Manage System.aspx");
        }
    }
}