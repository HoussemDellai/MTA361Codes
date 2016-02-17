<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormClient.aspx.cs" Inherits="WebServiceClient.WebFormClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="textBox1"
                     runat="server"/>
        </br></br>
        <asp:Button runat="server"
            OnClick="OnClick"
            Text="Invoke Web Service"/>
         </br></br>
        <asp:Label ID="label1"
            runat="server"/>
    </div>
    </form>
</body>
</html>
