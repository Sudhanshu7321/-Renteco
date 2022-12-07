<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server" class="needs-validation" novalidate>
        <div>
       sum     <asp:Label ID="Label1" runat="server" Text=""></asp:Label> <br/>
         sub     <asp:Label ID="Label2" runat="server" Text=""></asp:Label> <br/>
         mul   <asp:Label ID="Label3" runat="server" Text=""></asp:Label> <br/>
      div      <asp:Label ID="Label4" runat="server" Text=""></asp:Label> <br/>
      per  <asp:Label ID="Label5" runat="server" Text=""></asp:Label> <br/>
           <asp:Label ID="Label6" runat="server" Text=""></asp:Label> <br/>
         <asp:Label ID="Label7" runat="server" Text=""></asp:Label> <br/>
             <asp:Label ID="Label8" runat="server" Text=""></asp:Label> <br/>

            <div class="col-md-4">
        <label for="validationCustom01" class="form-label">First name</label>
        <input type="text" class="form-control" id="validationCustom01" value="Mark" required>
        <div class="valid-feedback">
            Looks good!
        </div>
         <div class="invalid-feedback">
             Please Enter first name
         </div>
    </div>

            <br />

        </div>
     value of A:   <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" required></asp:TextBox>
         <div class="valid-feedback">
            Looks good!
        </div>
         <div class="invalid-feedback">
             Please Enter Value of A
         </div>
     Value of B:   <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

         User name <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
         Password  <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
         <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click"  />


    </form>
    <script>
        // Example starter JavaScript for disabling form submissions if there are invalid fields
        (function () {
            'use strict'

            // Fetch all the forms we want to apply custom Bootstrap validation styles to
            var forms = document.querySelectorAll('.needs-validation')

            // Loop over them and prevent submission
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
    <!-- Option 1: Bootstrap Bundle with Popper -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous">
    </script>
</body>
</html>
