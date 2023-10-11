<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Database_Lab.Modify" %>

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
    form {   
           border: 3px solid #f1f1f1;   
    }   
    input[type=text], input[type=password] {   
           width: 80%;   
           margin: 8px 0;  
           padding: 12px 20px;   
           display: inline-block;   
           border: 2px solid green;   
           box-sizing: border-box;   
    }  
    button:hover {   
           opacity: 0.7;   
    }   
    .cancelbtn {   
           width: auto;   
           padding: 10px 18px;  
           margin: 10px 5px;  
    }   
        
     
    .container {   
           padding: 25px;   
           background-color: lightblue;  
     }   
</style>
</head>
<body>
    <center> <h1> Modify Page </h1> </center>   
    <form id="form1" runat="server">
        <div>
            <center>      
            
            <br/>
            <asp:Label ID="svcID_lbl" runat="server" Text="service ID:"></asp:Label>
            <br/>
            <asp:TextBox ID="svcID_tb" runat="server"></asp:TextBox>
            <br/>

            <asp:Label ID="stdID_lbl" runat="server" Text="student ID:"></asp:Label>
            <br/>
            <asp:TextBox ID="stdID_tb" runat="server"></asp:TextBox>
            <br/>

            <asp:Label ID="stdName_lbl" runat="server" Text="student name:"></asp:Label>
            <br/>
            <asp:TextBox ID="stdName_tb" runat="server"></asp:TextBox>
            <br/>

             <asp:Label ID="svcdate_lbl" runat="server" Text="service date:"></asp:Label>
            <br/>
            <asp:TextBox ID="svcdate_tb" runat="server"></asp:TextBox>
            <br/>

             <asp:Label ID="svctime_lbl" runat="server" Text="service time:"></asp:Label>
            <br/>
            <asp:TextBox ID="svctime_tb" runat="server"></asp:TextBox>
            <br/>

             <asp:Label ID="jc_lbl" runat="server" Text="job category:"></asp:Label>
            <br/>
            <asp:TextBox ID="jc_tb" runat="server"></asp:TextBox>
            <br/>
            <asp:Button ID="insert_btn" runat="server" Text="Insert" cssClass="button" OnClick="insert_btn_Click"/>
            
            <br/>
            <asp:Label ID="delete_svcID_lbl" runat="server" Text="service ID:"></asp:Label>
            <br/>
            <asp:TextBox ID="delete_svcID_tb" runat="server"></asp:TextBox>
            <br/>
            <asp:Button ID="delete_btn" runat="server" Text="Delete" cssClass="button" OnClick="delete_btn_Click"/>
            <br/>
            <asp:Button ID="cancel_btn" CssClass="button" runat="server" Text="Cancel" OnClick="cancel_btn_Click" />
        </center>
        </div>
    </form>
</body>
</html>
