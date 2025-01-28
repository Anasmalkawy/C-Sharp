<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm9.aspx.cs" Inherits="task7new.WebForm9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox class="form-label" for="form3Example4cdg" id="m1" runat="server"> id</asp:TextBox>
            <asp:TextBox class="form-label" for="form3Example4cdg" ID="m2" runat="server"> meting</asp:TextBox>
            <asp:TextBox class="form-label" for="form3Example4cdg" ID="m3" runat="server"> time</asp:TextBox>
            <asp:TextBox class="form-label" for="form3Example4cdg" ID="m4" runat="server"> data</asp:TextBox>
            <asp:Button class="btn btn-success btn-block btn-lg gradient-custom-4 text-body" OnClick="Unnamed_Click" runat="server" Text="add meting" />
        </div>
    </form>
</body>
</html>
