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
    public partial class BulletinBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cate"].ToString().Trim() == "2")
            {
                announcer_lbl.Visible = false;
                announcer.Visible = false;
                title_lbl.Visible = false;
                title_tb.Visible = false;
                txtinput_lbl.Visible = false;
                txtInput_tb.Visible = false;
                submit_btn.Visible = false;
                delete_btn.Visible = false;
            }
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
                String query = "SELECT announcer, title, content, submitDate FROM bulletin_board";
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

                String query = "INSERT INTO bulletin_board(announcer, title, content, submitDate) VALUES (@announcer, @title, @content, @submitDate)";
                OleDbCommand sqlcmd = new OleDbCommand(query, conn);
                sqlcmd.Parameters.AddWithValue("@announcer", announcer.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@title", title_tb.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@content", txtInput_tb.Text.Trim());
                string current_time = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt");
                sqlcmd.Parameters.AddWithValue("@submitDate", current_time);

                sqlcmd.ExecuteNonQuery();

                conn.Close();
                //Response.Redirect("Service Manage System.aspx");
                announcer.Text = "";
                title_tb.Text = "";
                txtInput_tb.Text = "";
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

                String query = "DELETE FROM bulletin_board WHERE nickname = @nickname AND title = @title";
                OleDbCommand sqlcmd = new OleDbCommand(query, conn);
                sqlcmd.Parameters.AddWithValue("@nickname", announcer.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@title", title_tb.Text.Trim());
                sqlcmd.ExecuteNonQuery();

                conn.Close();
                //Response.Redirect("Service Manage System.aspx");
                announcer.Text = "";
                title_tb.Text = "";
                txtInput_tb.Text = "";
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