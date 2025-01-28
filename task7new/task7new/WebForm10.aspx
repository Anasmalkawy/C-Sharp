<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm10.aspx.cs" Inherits="task7new.WebForm10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox class="form-label" for="form3Example4cdg" ID="bookid" runat="server">id</asp:TextBox>
            <asp:TextBox class="form-label" for="form3Example4cdg" ID="bookname" runat="server">bookname</asp:TextBox>
            <asp:TextBox class="form-label" for="form3Example4cdg" ID="booktype" runat="server">level</asp:TextBox>
            <asp:TextBox class="form-label" for="form3Example4cdg" ID="booklevel" runat="server">type</asp:TextBox>
            <asp:Button class="btn btn-success btn-block btn-lg gradient-custom-4 text-body" OnClick="Unnamed_Click" runat="server" Text="edit book" />
        </div>
    </form>
</body>
</html>
