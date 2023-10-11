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
    public partial class schedule : System.Web.UI.Page
    {
        //學生2 老師1 服務單位0
        protected void Page_Load(object sender, EventArgs e)
        {
            currentUser.Text = "current user: " + Session["UserName"];
            
            if (Session["cate"].ToString().Trim() == "2")
            {
                userCate.Text = "current category: student";
                modifySchedule.Visible = false;
                comment_btn.Visible = false;
            }
            else if(Session["cate"].ToString().Trim() == "1")
            {
                userCate.Text = "current category: teacher";
            }
            else if(Session["cate"].ToString().Trim() == "0")
            {
                userCate.Text = "current category: service agent";
            }

        }

        protected void serviceSchedule_click(object sender, EventArgs e)
        {
            Response.Redirect("Service Schedule1.aspx");
        }

        protected void logout_click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("login page.aspx");
        }

        protected void modifySchedule_click(object sender, EventArgs e)
        {
            Response.Redirect("Modify.aspx");
        }

        protected void bg_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("BGcheck.aspx");
        }

        protected void msg_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("MessageBoard.aspx");
        }

        protected void bulletin_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("BulletinBoard.aspx");
        }

        protected void comment_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Comment.aspx");
        }
    }
}