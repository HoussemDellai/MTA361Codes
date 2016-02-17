<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormSession.aspx.cs" Inherits="WebApplication1.WebFormSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server"
                Text="Please enter your name:" /><br />
            <asp:TextBox ID="TextBox1" runat="server" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server"
                Text="Submit" OnClick="Button1_OnClick" />
        </div>
    </form>
</body>
</html>
