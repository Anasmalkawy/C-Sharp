<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="tsak8.Anas.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <style>
        .gradient-custom {
            /* fallback for old browsers */
            background: #f6d365;
            /* Chrome 10-25, Safari 5.1-6 */
            background: -webkit-linear-gradient(to right bottom, rgba(246, 211, 101, 1), rgba(253, 160, 133, 1));
            /* W3C, IE 10+/ Edge, Firefox 16+, Chrome 26+, Opera 12+, Safari 7+ */
            background: linear-gradient(to right bottom, rgba(246, 211, 101, 1), rgba(253, 160, 133, 1))
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <section class="vh-100" style="background-color: #f4f5f7;">
                <div class="container py-5 h-100">
                    <div class="row d-flex justify-content-center align-items-center h-100">
                        <div class="col col-lg-6 mb-4 mb-lg-0">
                            <div class="card mb-3" style="border-radius: .5rem;">
                                <div class="row g-0">
                                    <div class="col-md-4 gradient-custom text-center text-white"
                                        style="border-top-left-radius: .5rem; border-bottom-left-radius: .5rem;">
                                        <img src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-chat/ava1-bg.webp"
                                            alt="Avatar" class="img-fluid my-5" style="width: 80px;" />
                                        <h5>Marie Horwitz</h5>
                                        <p>Web Designer</p>
                                        <i class="far fa-edit mb-5"></i>
                                    </div>
                                    <div class="col-md-8">
                                        <div class="card-body p-4">
                                            <h6>Information</h6>
                                            <hr class="mt-0 mb-4">
                                            <div class="row pt-1">
                                                <div class="col-6 mb-3">
                                                    <div class="col-6 mb-3">
                                                        <h6>Email</h6>
                                                        <p class="text-muted">
                                                            <asp:TextBox ID="searchbye" runat="server"></asp:TextBox>
                                                        </p>
                                                    </div>
                                                </div>
                                                <div>
                                                <div class="col-6 mb-3">
                                                    <asp:Button runat="server" OnClick="Search_Click1" text="confirm email"/>

                                                    </div>
                                                </div>
                                                <div>
                                                    <h6>First Name</h6>
                                                    <p class="text-muted">
                                                        <asp:TextBox ID="fname1" runat="server"></asp:TextBox></p>
                                                </div>
                                                <div class="col-6 mb-3">
                                                    <h6>Last Name</h6>
                                                    <p class="text-muted">
                                                        <asp:TextBox ID="lname1" runat="server"></asp:TextBox>
                                                    </p>
                                                </div>
                                                <div class="col-6 mb-3">
                                                    <h6>Email</h6>
                                                    <p class="text-muted">
                                                        <asp:TextBox ID="email1" runat="server" ></asp:TextBox>
                                                    </p>
                                                </div>
                                                <div class="col-6 mb-3">
                                                    <h6>Password</h6>
                                                    <p class="text-muted">
                                                        <asp:TextBox ID="password1" runat="server"></asp:TextBox>
                                                    </p>
                                                </div>
                                                <div class="col-6 mb-3">
                                                    <h6>Phone</h6>
                                                    <p class="text-muted">
                                                        <asp:TextBox ID="phone1" runat="server"></asp:TextBox>
                                                    </p>
                                                </div>
                                                <div class="col-6 mb-3">
                                                    <h6>Gender</h6>
                                                    <p class="text-muted">
                                                        <asp:TextBox ID="gender1" runat="server"></asp:TextBox>
                                                    </p>
                                                </div>
                                                <div>
                                                    <asp:Button runat="server" OnClick="Unnamed_Click" Text="edit" />
                                                </div>
                                            </div>

                                            <hr class="mt-0 mb-4">
                                            <div class="d-flex justify-content-start">
                                                <a href="#!"><i class="fab fa-facebook-f fa-lg me-3"></i></a>
                                                <a href="#!"><i class="fab fa-twitter fa-lg me-3"></i></a>
                                                <a href="#!"><i class="fab fa-instagram fa-lg"></i></a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    </form>
</body>
</html>
