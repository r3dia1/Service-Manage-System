<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MessageBoard.aspx.cs" Inherits="Database_Lab.MessageBoard" %>

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
           width: 50%;  
           color: black;   
           padding: 15px;   
           margin: 10px 30px ;   
           border: none;   
           cursor: pointer;

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
    <form id="form1" runat="server">
        <div class="container">
            <center>
            <div><h2>Message Board</h2></div>
            <div>
                <asp:GridView ID="datagridview" runat="server" align="center" CssClass="mydatagrid" PagerStyle-CssClass="pager"
     HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AllowPaging="True" OnPageIndexChanging="datagrid_PageIndexChanging">
                </asp:GridView>
            </div>
            <div>
                <asp:Label ID="nickname_lbl" runat="server" Text="Name:"></asp:Label>
                <br/>
                <asp:TextBox ID="nickname" runat="server" Width="50%" placeholder="Nickname"></asp:TextBox>
                <br/>
                <asp:Label ID="txtinput_lbl" runat="server" Text="Message:"></asp:Label>
                <br/>
                <asp:TextBox ID="myInput" runat="server" Width="50%" placeholder="please input message"></asp:TextBox>
                <br/>
                <asp:Button ID="submit_btn" CssClass="button" Width="10%" runat="server" Text="Submit" OnClick="submit_btn_Click"  />
                <asp:Button ID="delete_btn" CssClass="button" Width="10%" runat="server" Text="Delete" OnClick="delete_btn_Click" />
                <asp:Button ID="home_btn" CssClass="button" Width="10%" runat="server" Text="Homepage" OnClick="home_btn_Click" />
            </div>
            </center>
        </div>
    </form>
</body>
</html>
