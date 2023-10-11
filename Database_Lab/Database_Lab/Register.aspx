<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Database_Lab.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<style>   
    Body {  
      font-family: Calibri, Helvetica, sans-serif;  
      background-color: orange;  
    }  
    .button{
           font: 12pt verdana;
           background-color: #4CAF50;   
           width: 30%;  
           color: black;   
           padding: 15px;   
           margin: 10px 0px;   
           border: none;   
           cursor: pointer;   
     }   
    form {   
           border: 3px solid #f1f1f1;   
    }   
    input[type=text], input[type=password] {   
           width: 50%;   
           margin: 8px 0;  
           padding: 12px 20px;   
           display: inline-block;   
           border: 2px solid green;   
           box-sizing: border-box;   
    }  
    button:hover {   
           opacity: 0.7;   
    }   

    .container {   
           padding: 25px;   
           background-color: lightblue;  
     }
    .mydatagrid
    {
        width: 80%;
        border: solid 2px black;
        min-width: 80%;
    }
    .header
    {
        background-color: #646464;
        font-family: Arial;
        color: White;
        border: none 0px transparent;
        height: 25px;
        text-align: center;
        font-size: 16px;
    }

    .rows
    {
        background-color: #fff;
        font-family: Arial;
        font-size: 14px;
        color: #000;
        min-height: 25px;
        text-align: center;
        border: none 0px transparent;
    }
    .rows:hover
    {
        background-color: #ff8000;
        font-family: Arial;
        color: #fff;
        text-align: center;
    }
    .selectedrow
    {
        background-color: #ff8000;
        font-family: Arial;
        color: #fff;
        font-weight: bold;
        text-align: left;
    }
    .mydatagrid a /** FOR THE PAGING ICONS **/
    {
        background-color: Transparent;
        padding: 5px 5px 5px 5px;
        color: #fff;
        text-decoration: none;
        font-weight: bold;
    }

    .mydatagrid a:hover /** FOR THE PAGING ICONS HOVER STYLES**/
    {
        background-color: #000;
        color: #fff;
    }
    .mydatagrid span /** FOR THE PAGING ICONS CURRENT PAGE INDICATOR **/
    {
        background-color: #c9c9c9;
        color: #000;
        padding: 5px 5px 5px 5px;
    }
    .pager
    {
        background-color: #646464;
        font-family: Arial;
        color: White;
        height: 30px;
        text-align: left;
    }

    .mydatagrid td
    {
        padding: 5px;
    }
    .mydatagrid th
    {
        padding: 5px;
    }
</style>
</head>
<body>
    <center> <h1> Register </h1> </center>   
    <form id="form1" runat="server">
        <div class="container">
        <center>
            <asp:Label ID="cate_lbl" runat="server" Text="Category:"></asp:Label>
            <br/>
            <asp:TextBox ID="cate_tb" runat="server" ></asp:TextBox>
            <br/>
            <asp:Label ID="ID_lbl" runat="server" Text="ID:"></asp:Label>
            <br/>
            <asp:TextBox ID="ID_tb" runat="server" ></asp:TextBox>
            <br/>
            <asp:Label ID="userName_lbl" runat="server" Text="Name:"></asp:Label>
            <br/>
            <asp:TextBox ID="userName_tb" runat="server" ></asp:TextBox>
            <br/>
            <asp:Label ID="ps_lbl" runat="server" Text="Password:"></asp:Label>
            <br/>
            <asp:TextBox ID="ps_tb" runat="server" ></asp:TextBox>
            <br/>
            <asp:Button ID="bg_create_btn" runat="server" CssClass="button" Text="Create" OnClick="bg_create_btn_Click" TextMode="Password" />
            <br/>
            <asp:Button ID="go_loginpage_btn" runat="server" CssClass="button" Text="cancel" OnClick="go_loginpage_btn_Click" />
        </center>
        </div>
    </form>
</body>
</html>
