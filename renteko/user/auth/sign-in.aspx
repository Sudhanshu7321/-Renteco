<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="sign-in.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- JavaScript Bundle with Popper 
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-A3rJD856KowSb7dwlZdYEkO39Gagi7vIsF0jrRAoQmDKKtQBHUuLZ9AsSv4jD4Xa" crossorigin="anonymous"></script>
    <script src="https://www.google.com/recaptcha/api.js"></script>
    <script>
        var Onloadcallback = function () {
            grecaptcha.render('divcaptcha', {
                'sitekey': '6LeIxAcTAAAAAJcZVRqyHh71UMIEGNQ_MXjiZKhI'
                'callback': function () {
                    $'#txtcaptcha'.val('t');
                }
            }) 
        }
    </script>-->

    <div class="container">
        <div class="row">
            <div class="col-sm-12 col-md-6">
                       <form runat="server" class="needs-validation" novalidate>
                     
             
                <div class="card p-5" style="margin-top:150px">
                     <h4 class="font-weight-bolder">Sign In</h4>
                  <p class="mb-0">Enter your email and password to sign in</p>
                   <div class="mb-3">
                          <asp:Label ID="lblMassage" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="mb-3">
                        <asp:TextBox ID="EmailId" runat="server" placeholder="Email" class="form-control form-control-lg" required></asp:TextBox>
                         <div class="invalid-feedback">
             Please Enter Email Id
         </div>
                    </div>
                    <div class="mb-3">
                        <asp:TextBox ID="Password" runat="server" placeholder="Password" type="password" class="form-control form-control-lg" required></asp:TextBox>
                         <div class="invalid-feedback">
             Please Enter Password
         </div>


                    </div>
                    <div class="">
                        <asp:CheckBox ID="CheckBox1" CssClass="" runat="server"/>
                      <label class="form-check-label" for="rememberMe">Remember me</label>
                  <!--      <div id="divcaptcha"></div>
                         <asp:TextBox ID="txtcaptcha" runat="server"  type="captcha" class="form-control form-control-lg" required></asp:TextBox> <br/>

                        
                    </div>-->
                    <div class="text-center">
                        <asp:Button ID="SingIn" runat="server" Text="Sign In" OnClick="SingIn_Click" class="btn btn-lg btn-danger btn-lg w-100 mt-4 mb-0"/>
                    </div>
                     <p class="mt-2 text-sm mx-auto">
                    Don't have an account?
                    <a href="sign-up.aspx" class="text-dark text-gradient font-weight-bold">Sign up</a>
                  </p>
            </div>
                             </form></div>
           
            <div class="col-sm-0 col-md-6">
                 <div class="card p-5" style="margin-top: 150px">
                     <h4>Some Images</h4>
                 </div>
            </div>
        </div>
    </div>
</asp:Content>

