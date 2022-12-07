<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="sign-up.aspx.cs" Inherits="user_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="padding-top: 150px;">

    <div class="container border pt-2 pb-2" >
                     <h5>Sign Up</h5>
<br />
                               <form runat="server" class="needs-validation" novalidate>
        <div class="row" >
            <div class="col-sm-12 col-md-6">
                <div >
                    <div class="">
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                        <div class="mb-3">
                            <asp:TextBox ID="TextBox1" CssClass="form-control" placeholder="Full Name" runat="server" required></asp:TextBox>
                             <div class="invalid-feedback">
      Please Enter Full Name.
    </div>
                        </div>
                        <div class="mb-3">
                            <asp:TextBox ID="TextBox6" CssClass="form-control" placeholder="User Name" runat="server" required></asp:TextBox>  <div class="invalid-feedback">
      Please Enter User Name.
    </div>
                        </div>
                        <div class="mb-3">
                            <asp:TextBox ID="TextBox2" CssClass="form-control" placeholder="Email Id" runat="server" required></asp:TextBox>
                              <div class="invalid-feedback">
      Please Enter Email Id.
    </div>
                        </div>
                        <div class="mb-3">
                            <asp:TextBox ID="TextBox3" CssClass="form-control" placeholder="Mobile NO." runat="server" required></asp:TextBox>
                              <div class="invalid-feedback">
      Please Enter Mobile Number.
    </div>
                        </div>
                        <div class="mb-3">
                            <asp:TextBox ID="TextBox4" CssClass="form-control"  placeholder="Password" TextMode="Password" runat="server" pattern="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}" title="Must contain at least one number and one uppercase and lowercase letter, and at least 8 or more characters" required></asp:TextBox>
                              <div class="invalid-feedback">
      Please Enter Password.
                                                             <div id="message">
  <h10><b><i>Password must contain the following:</b></i></h10>
  <p id="letter" class="invalid">A <b>lowercase</b> letter</p>
  <p id="capital" class="invalid">A <b>capital (uppercase)</b> letter</p>
  <p id="number" class="invalid">A <b>number</b></p>
  <p id="length" class="invalid">Minimum <b>8 characters</b></p>
</div>
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
                        <div class="mb-3">
                            <asp:TextBox ID="TextBox5" CssClass="form-control" placeholder="Confirm Password" TextMode="Password" runat="server"  required></asp:TextBox>
                              <div class="invalid-feedback">
      Please Enter Confirm Password.
    </div>




                        </div>
                              <div class="row">
                        <div class="col-md-6">
                            <div class="mb-3">
                                <asp:DropDownList CssClass="form-control" ID="DropDownList1" runat="server" required>
                                    <asp:ListItem disabled >Gender</asp:ListItem>
                                    <asp:ListItem>Male</asp:ListItem>
                                    <asp:ListItem>Female</asp:ListItem>
                                                                        <asp:ListItem>Other</asp:ListItem>

                                </asp:DropDownList>
  <div class="invalid-feedback">
      Please Select Gender.
    </div>                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="mb-1">
                                <!-- file -->
                                <asp:FileUpload CssClass="form-control" ID="FileUpload1" runat="server" required/>
                                  <div class="invalid-feedback">
      Please Upload Profile Picture.
    </div> 
                            </div>
                        </div>
</div>

                    </div>
             
                   <asp:Image ID="Image1" runat="server" required/>
                    <div class="form-check form-check-info text-start">
                        <asp:CheckBox ID="CheckBox1" CssClass="" runat="server" required/>
                          <div class="invalid-feedback">
      Please Accept Terms and Conditions.
    </div> 
                        <label class="form-check-label" for="flexCheckDefault">
                            I agree the <a href="javascript:;" class="text-dark font-weight-bolder">Terms and Conditions</a>
                        </label>
                    </div>
                    <div class="text-center">
                        <asp:Button ID="Button1" CssClass="btn btn-danger w-100 my-4 mb-1" runat="server" Text="Sign up" OnClick="Button1_Click" />
                    </div>
                    <p class="text-sm  mb-0">Already have an account? <a href="sign-in.aspx" class="text-dark font-weight-bolder">Sign in</a></p>
            </div>
            
                   </div><div class="col-sm-0 col-md-6">
                <div >
                    <div class="row">
              
                    </div>
                 
                </div>
            </div>
        </div>
                                   </form>
    </div>
        
    </div>
</asp:Content>

