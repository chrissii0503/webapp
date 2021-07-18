<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="WebApp.Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload" runat="server" AllowMultiple="True" Height="26px" Width="254px" />
            <br />
            <br />
            <asp:Button ID="btnLoad" runat="server" Height="24px" OnClick="btnLoad_Click" Text="Upload" Width="114px" />
            <br />
            <br />
            <hr />  
    <asp:GridView ID="GridView" runat="server">  
    </asp:GridView>
        </div>
    </form>
</body>
</html>
