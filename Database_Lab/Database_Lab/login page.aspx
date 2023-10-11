<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login page.aspx.cs" Inherits="Database_Lab.login_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> Login Page </title>  
<style>   
    Body {  
      font-family: Calibri, Helvetica, sans-serif;  
      background-color: orange;  
    }  
    .button{
           font: 12pt verdana;
           background-color: #4CAF50;   
           width: 100%;  
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
           width: 100%;   
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
    <center> <h1> Login Page </h1> </center>   
    <form id="loginForm" runat="server">  
        <div class="container">   
            <asp:Label ID="Label1" runat="server" Text="Username :"></asp:Label>
            <asp:TextBox ID="txtUserName" placeholder="Enter Username" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Password :"></asp:Label>
            <asp:TextBox ID="txtPassword" placeholder="Enter Password" runat="server" TextMode="Password"></asp:TextBox>
            <asp:button ID="loginBtn" runat="server" CssClass="button" Text="submit" OnClick="loginBtn_Click" />
            <asp:Button ID="registerBtn" runat="server" CssClass="button" Text="Register" OnClick="registerBtn_Click"  />
            <asp:Label ID="lblErrorMsg" runat="server" Text="Message: Invalid username or passward!" ForeColor="red"></asp:Label>
        </div>
    </form>     
</body>     
</html>
