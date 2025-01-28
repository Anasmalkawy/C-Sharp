<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppDemo.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Form Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Label -->
            <asp:Label ID="Label1" runat="server" Text="Enter Name: "></asp:Label>
            
            <!-- Textbox -->
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            
            <!-- Button -->
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            
            <!-- Navigate to Another Page -->
            <asp:Button ID="ButtonNavigate" runat="server" Text="Go to Page 2" OnClick="ButtonNavigate1" />

            <!-- Label to display message -->
            <asp:Label ID="LabelResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
