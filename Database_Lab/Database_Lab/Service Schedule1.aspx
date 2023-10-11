<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Service Schedule1.aspx.cs" Inherits="Database_Lab.Service_Schedule" %>

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
           margin: 10px 0px;   
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

</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="datagridview" runat="server" align="center" CssClass="mydatagrid" PagerStyle-CssClass="pager"
 HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AllowPaging="True" OnPageIndexChanging="datagrid_PageIndexChanging">
            </asp:GridView>
        </div>
        <center><asp:Button ID="back_btn" CssClass="button" runat="server" Text="Go Back" OnClick="back_btn_Click" /></center>
    </form>
</body>
</html>
