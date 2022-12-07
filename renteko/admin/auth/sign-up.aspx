<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sign-up.aspx.cs" Inherits="admin_Default" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta charset="utf-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
  <link rel="apple-touch-icon" sizes="76x76" href="../assets/img/apple-icon.png">
  <link rel="icon" type="image/png" href="../assets/img/favicon.png">
  <title>
     Dashboard 2 
  </title>
  <!--     Fonts and icons     -->
  <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700" rel="stylesheet" />
  <!-- Nucleo Icons -->
  <link href="../assets/css/nucleo-icons.css" rel="stylesheet" />
  <link href="../assets/css/nucleo-svg.css" rel="stylesheet" />
  <!-- Font Awesome Icons -->
  <script src="https://kit.fontawesome.com/42d5adcbca.js" crossorigin="anonymous"></script>
  <link href="../assets/css/nucleo-svg.css" rel="stylesheet" />
  <!-- CSS Files -->
  <link id="pagestyle" href="../assets/css/argon-dashboard.css?v=2.0.4" rel="stylesheet" />

    
</head>
<body>
    <form id="form1" runat="server" class="needs-validation" novalidate >
        <div>
  <main class="main-content  mt-0">
    <div class="page-header align-items-start min-vh-50 pt-5 pb-11 m-3 border-radius-lg" style="background-image: url('https://raw.githubusercontent.com/creativetimofficial/public-assets/master/argon-dashboard-pro/assets/img/signup-cover.jpg'); background-position: top;">
      <span class="mask bg-gradient-dark opacity-6"></span>
      <div class="container">
        <div class="row justify-content-center">
          <div class="col-lg-5 text-center mx-auto">
            <h1 class="text-white mb-2 mt-5">Welcome!</h1>
            <p class="text-lead text-white">Use these awesome forms to login or create new account in your project for free.</p>
          </div>
        </div>
      </div>
    </div>
    <div class="container">
      <div class="row mt-lg-n10 mt-md-n11 mt-n10 justify-content-center">
        <div class="col-xl-5 col-lg- col-md-8 mx-auto">
          <div class="card z-index-0">
            <div class="card-header text-center pt-4">
              <h5>Sign Up</h5>
            </div>
            <div class="card-body">
              <form role="form">
                  <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                <div class="mb-3">
                    <asp:TextBox ID="TextBox1" cssclass="form-control" placeholder="Name" runat="server" required></asp:TextBox>
                                  <div class="invalid-feedback">
             Please Enter Name
         </div>
                </div >
                <div class="mb-3">
                    <asp:TextBox ID="TextBox2" cssclass="form-control" placeholder="Email Id" runat="server" required></asp:TextBox>
                                        <div class="invalid-feedback">
             Please Enter Email id
         </div>
                </div>
                <div class="mb-3">
                    <asp:TextBox ID="TextBox3" cssclass="form-control" placeholder="Mobile NO." runat="server" required></asp:TextBox>
                                        <div class="invalid-feedback">
             Please Enter mobile no.
         </div>
                </div>
                   <div class="mb-3">
                    <asp:TextBox ID="TextBox4" cssclass="form-control" placeholder="Password" runat="server" TextMode="Password"  pattern="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}" title="Must contain at least one number and one uppercase and lowercase letter, and at least 8 or more characters" required></asp:TextBox>
                                           <div class="invalid-feedback">
             Please Enter Password
                                                                                                        <div id="message">
  <h10><b><i>Password must contain the following:</b></i></h10>
  <p id="letter" class="invalid">A <b>lowercase</b> letter</p>
  <p id="capital" class="invalid">A <b>capital (uppercase)</b> letter</p>
  <p id="number" class="invalid">A <b>number</b></p>
  <p id="length" class="invalid">Minimum <b>8 characters</b></p>
</div>

    <script>
                                                   var myInput = document.getElementById("psw");
                                                   var letter = document.getElementById("letter");
                                                   var capital = document.getElementById("capital");
                                                   var number = document.getElementById("number");
                                                   var length = document.getElementById("length");

                                                   // When the user clicks on the password field, show the message box
                                                   myInput.onfocus = function () {
                                                       document.getElementById("message").style.display = "block";
                                                   }

                                                   // When the user clicks outside of the password field, hide the message box
                                                   myInput.onblur = function () {
                                                       document.getElementById("message").style.display = "none";
                                                   }

                                                   // When the user starts to type something inside the password field
                                                   myInput.onkeyup = function () {
                                                       // Validate lowercase letters
                                                       var lowerCaseLetters = /[a-z]/g;
                                                       if (myInput.value.match(lowerCaseLetters)) {
                                                           letter.classList.remove("invalid");
                                                           letter.classList.add("valid");
                                                       } else {
                                                           letter.classList.remove("valid");
                                                           letter.classList.add("invalid");
                                                       }

                                                       // Validate capital letters
                                                       var upperCaseLetters = /[A-Z]/g;
                                                       if (myInput.value.match(upperCaseLetters)) {
                                                           capital.classList.remove("invalid");
                                                           capital.classList.add("valid");
                                                       } else {
                                                           capital.classList.remove("valid");
                                                           capital.classList.add("invalid");
                                                       }

                                                       // Validate numbers
                                                       var numbers = /[0-9]/g;
                                                       if (myInput.value.match(numbers)) {
                                                           number.classList.remove("invalid");
                                                           number.classList.add("valid");
                                                       } else {
                                                           number.classList.remove("valid");
                                                           number.classList.add("invalid");
                                                       }

                                                       // Validate length
                                                       if (myInput.value.length >= 8) {
                                                           length.classList.remove("invalid");
                                                           length.classList.add("valid");
                                                       } else {
                                                           length.classList.remove("valid");
                                                           length.classList.add("invalid");
                                                       }
                                                   }
                                               </script>
         </div>
                </div>
                   <div class="mb-3">
                    <asp:TextBox ID="TextBox5" cssclass="form-control" placeholder="Confirm-Password" runat="server" TextMode="Password" required></asp:TextBox>
                                           <div class="invalid-feedback">
             Please Enter confirm password
</div>
    
                                               

         </div>
                </div>

                  <div class="row">
                      <div class="col-md-6">
                          <div class="mb-3">
                              <asp:DropDownList cssclass="form-control" ID="DropDownList1" runat="server" required>
                            <asp:ListItem>Gender</asp:ListItem>
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                                                  <div class="invalid-feedback">
             Please select Gender
         </div>
                          </div>
                      </div>
                       <div class="col-md-6">
                          <div class="mb-3">
                             <!-- file -->
                              <asp:FileUpload CssClass="form-control" ID="FileUpload1" runat="server" required />
                          </div>
                      </div>
                      <div class="col-md-6">
                          <div class="mb-3">
                              <asp:DropDownList cssclass="form-control" ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" required>
                              </asp:DropDownList>
                          </div>
                      </div>
                       <div class="col-md-6">
                          <div class="mb-3">
                              <asp:DropDownList cssclass="form-control" ID="DropDownList3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged" required>
                              
                              </asp:DropDownList>
                          </div>
                      </div>
                      <div class="col-md-6">
                          <div class="mb-3">
                              <asp:DropDownList cssclass="form-control" ID="DropDownList4" runat="server" AutoPostBack="True" 
                                  OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged" required>

                              </asp:DropDownList>
                          </div>
                      </div>
                       <div class="col-md-6">
                          <div class="mb-3">
                              <asp:DropDownList cssclass="form-control" ID="DropDownList5" runat="server" AutoPostBack="True" 
                                  OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged" required></asp:DropDownList>
                          </div>
                      </div>
                      <div class="col-md-6">
                          <div class="mb-3">
                              <asp:DropDownList cssclass="form-control" ID="DropDownList6" runat="server" AutoPostBack="True" 
                                  OnSelectedIndexChanged="DropDownList6_SelectedIndexChanged" required></asp:DropDownList>
                          </div>
                          </div>
                           <div class="col-md-6">
                          <div class="mb-3">
                              <asp:DropDownList cssclass="form-control" ID="DropDownList7" runat="server" required ></asp:DropDownList>
                          </div>
                      </div>
                  </div>
                  <asp:Image ID="Image1" runat="server" required />
                <div class="form-check form-check-info text-start">
                    <asp:CheckBox ID="CheckBox1" CssClass="form-check-input" runat="server" />
                  <label class="form-check-label" for="flexCheckDefault">
                    I agree the <a href="javascript:;" class="text-dark font-weight-bolder">Terms and Conditions</a>
                  </label>
                </div>
                <div class="text-center">
                    <asp:Button ID="Button1" cssClass="btn bg-gradient-dark w-100 my-4 mb-2" runat="server" Text="Sign up" OnClick="Button1_Click" />
                </div>
                <p class="text-sm mt-3 mb-0">Already have an account? <a href="sign-in.aspx" class="text-dark font-weight-bolder">Sign in</a></p>
              </form>
            </div>
          </div>
        </div>
      </div>
    </div>
  </main>
  <!-- -------- START FOOTER 3 w/ COMPANY DESCRIPTION WITH LINKS & SOCIAL ICONS & COPYRIGHT ------- -->
  <footer class="footer py-5">
    <div class="container">
      <div class="row">
        <div class="col-lg-8 mb-4 mx-auto text-center">
          <a href="javascript:;" target="_blank" class="text-secondary me-xl-5 me-3 mb-sm-0 mb-2">
            Company
          </a>
          <a href="javascript:;" target="_blank" class="text-secondary me-xl-5 me-3 mb-sm-0 mb-2">
            About Us
          </a>
          <a href="javascript:;" target="_blank" class="text-secondary me-xl-5 me-3 mb-sm-0 mb-2">
            Team
          </a>
          <a href="javascript:;" target="_blank" class="text-secondary me-xl-5 me-3 mb-sm-0 mb-2">
            Products
          </a>
          <a href="javascript:;" target="_blank" class="text-secondary me-xl-5 me-3 mb-sm-0 mb-2">
            Blog
          </a>
          <a href="javascript:;" target="_blank" class="text-secondary me-xl-5 me-3 mb-sm-0 mb-2">
            Pricing
          </a>
        </div>
        <div class="col-lg-8 mx-auto text-center mb-4 mt-2">
          <a href="javascript:;" target="_blank" class="text-secondary me-xl-4 me-4">
            <span class="text-lg fab fa-dribbble"></span>
          </a>
          <a href="javascript:;" target="_blank" class="text-secondary me-xl-4 me-4">
            <span class="text-lg fab fa-twitter"></span>
          </a>
          <a href="javascript:;" target="_blank" class="text-secondary me-xl-4 me-4">
            <span class="text-lg fab fa-instagram"></span>
          </a>
          <a href="javascript:;" target="_blank" class="text-secondary me-xl-4 me-4">
            <span class="text-lg fab fa-pinterest"></span>
          </a>
          <a href="javascript:;" target="_blank" class="text-secondary me-xl-4 me-4">
            <span class="text-lg fab fa-github"></span>
          </a>
        </div>
      </div>
      <div class="row">
        <div class="col-8 mx-auto text-center mt-1">
          <p class="mb-0 text-secondary">
            Copyright © <script>
              document.write(new Date().getFullYear())
            </script> Soft by Creative Tim.
          </p>
        </div>
      </div>
    </div>
  </footer>
  <!-- -------- END FOOTER 3 w/ COMPANY DESCRIPTION WITH LINKS & SOCIAL ICONS & COPYRIGHT ------- -->
  <!--   Core JS Files   -->
  <script src="../assets/js/core/popper.min.js"></script>
  <script src="../assets/js/core/bootstrap.min.js"></script>
  <script src="../assets/js/plugins/perfect-scrollbar.min.js"></script>
  <script src="../assets/js/plugins/smooth-scrollbar.min.js"></script>
  <script>
    var win = navigator.platform.indexOf('Win') > -1;
    if (win && document.querySelector('#sidenav-scrollbar')) {
      var options = {
        damping: '0.5'
      }
      Scrollbar.init(document.querySelector('#sidenav-scrollbar'), options);
    }
  </script>
  <!-- Github buttons -->
  <script async defer src="https://buttons.github.io/buttons.js"></script>
  <!-- Control Center for Soft Dashboard: parallax effects, scripts for the example pages etc -->
  <script src="../assets/js/argon-dashboard.min.js?v=2.0.4"></script>

        </div>
    </form>
        <!-- Form validation -->
        <script>
            (function () {
                'use strict'
                var forms = document.querySelectorAll('.needs-validation')
                Array.prototype.slice.call(forms)
                    .forEach(function (form) {
                        form.addEventListener('submit', function (event) {
                            if (!form.checkValidity()) {
                                event.preventDefault()
                                event.stopPropagation()
                            }

                            form.classList.add('was-validated')
                        }, false)
                    })
            })()
        </script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous">
    </script>
</body>
</html>
