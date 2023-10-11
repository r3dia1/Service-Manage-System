<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Service Manage System.aspx.cs" Inherits="Database_Lab.schedule" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Servie Manage System</title>

<style>
    Body {  
        font-family: Calibri, Helvetica, sans-serif;  
        background-color: orange;  
    }  

    .button {
        font: 12pt verdana;
        background-color: #4CAF50;   
        width: 100%;  
        color: black;   
        padding: 15px;   
        margin: 10px 0px;   
        border: none;   
        cursor: pointer;   
    }

    input[type=text], input[type=password] {   
           width: 80%;   
           margin: 8px 0;  
           padding: 12px 20px;   
           display: inline-block;   
           border: 2px solid green;   
           box-sizing: border-box;   
    }
    .container {   
        padding: 25px;   
        background-color: lightblue;  
    }
</style>
</head>
<body>
    <center><h1>Service Manage System</h1></center>
    <center><asp:Label ID="currentUser" runat="server" ></asp:Label></center>
    <center><asp:Label ID="userCate" runat="server" ></asp:Label></center>
    <br/>
    <form id="form1" runat="server">
        <div class="container">
            <asp:Button ID="serviceSchdeule" runat="server" CssClass="button" Text="View Service Schedule" OnClick="serviceSchedule_click" />
            <asp:Button ID="modifySchedule" runat="server" CssClass="button" Text="Modify Service Schedule" OnClick="modifySchedule_click" />
            <asp:Button ID="comment_btn" runat="server" CssClass="button" Text="Comment" OnClick="comment_btn_Click" />
            <asp:Button ID="bg_btn" runat="server" CssClass="button" Text="Background Check" OnClick="bg_btn_Click" />
            <asp:Button ID="bulletin_btn" runat="server" CssClass="button" Text="Bulletin Board" OnClick="bulletin_btn_Click" />
            <asp:Button ID="msg_btn" runat="server" CssClass="button" Text="Message Board" OnClick="msg_btn_Click" />
            <asp:Button ID="LogoutBtn" runat="server" CssClass="button" Text="Logout" Onclick="logout_click" />
        </div>
    </form>
</body>
</html>
