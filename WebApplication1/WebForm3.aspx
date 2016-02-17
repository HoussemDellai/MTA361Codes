<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server"
                ID="textBox1" />
            </br>  </br>
        <asp:TextBox runat="server"
            ID="textBox2" />
            </br>  </br>
        <asp:Button runat="server"
            OnClick="OnClick"
            Text="Somme" />
            </br>  </br>
        <asp:Label runat="server"
            ID="label1" />
        </div>
    </form>
</body>
</html>
