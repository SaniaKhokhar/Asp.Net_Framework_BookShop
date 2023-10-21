<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="BookShop.Views.Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Assets/Lib/css/bootstrap.min.css" />
</head>
<body>
   <div class="container-fluid">
    <div class="row mt-5 mb-5">
    </div>
    <div class="row">
        <div class="col-md-4">

        </div>
        <div class="col-md-4">
            <form id="form1" runat="server">
                <div>
                    <div class="row">
                        <div class="col-md-4"></div>
                        <div class="col-md-8">
                           <img src="../Assets/Images/book.jfif" class ="align-content-center" />
                        </div>
                    </div>
                 </div>
                <div class="mt-3">
                    <label for="" class="form-label">Name</label>
                    <input type="text" placeholder="Your Name" runat="server" autocomplete="off" class="form-control" id="UNameTb"/>
                </div>
                <div class="mt-3">
                    <label for="" class="form-label">Email</label>
                    <input type="email" placeholder="Your Email here" runat="server" autocomplete="off" class="form-control" id="EmailTb"/>
                </div>
                <div class="mt-3">
                    <label for="" class="form-label">Phone no.</label>
                    <input type="text" placeholder="Phone Number" autocomplete="off" runat="server" class="form-control" id="PhoneTb"/>
                </div>
                <div class="mt-3">
                    <label for="" class="form-label">Password</label>
                    <input type="password" placeholder="Password" runat="server" autocomplete="off" class="form-control" id="PasswordTb"/>
                </div>
                <div class="mt-3 d-grid">
                    <asp:Label runat = "server" ID="ErrMsg" class="text-danger text-center"></asp:Label><br />
                    <asp:Button Text="Sign Up"  runat="server" CssClass="btn-success btn" ID="SignupBtn" OnClick="SignupBtn_Click"/><br />
                    <a href="Login.aspx">Already have an account? Login here</a>
                </div>
            </form>
          </div>
        <div class="col-md-4">
        </div>
      </div>
    </div>
</body>
</html>
