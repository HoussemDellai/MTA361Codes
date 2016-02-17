<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormAddition.aspx.cs" Inherits="WebServiceClient.WebFormAddition" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div>
        <asp:TextBox ID="textBox1"
                     runat="server"/>
         </br></br>
        <asp:TextBox ID="textBox2"
                     runat="server"/>
        </br></br>
        <asp:Button runat="server"
            OnClick="OnClick"
            Text="Invoke Web Service Addition"/>
         </br></br>
        <asp:Label ID="label1"
            runat="server"/>
    </div>
    </div>
    </form>
</body>
</html>
