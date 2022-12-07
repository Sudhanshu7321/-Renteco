<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="order.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    Order
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
                <form runat="server" class="needs-validation" novalidate>

    <body>
            <div class="container" style="padding-top:150px">
<div class="row">
    <div class="col-12" >
            <ul class="nav nav-tabs pt-3 pl-3 pr-3 pb-0" id="myTab" role="tablist" style="background-color:#212529">
                <asp:Label ID="lblerror" runat="server" Text="Label"></asp:Label>
  <li class="nav-item" role="presentation">
    <button class="nav-link text-danger active" id="home-tab" data-bs-toggle="tab" data-bs-target="#home" type="button" role="tab" aria-controls="home" aria-selected="true">About</button>
  </li>
  <li class="nav-item" role="presentation">
    <button class="nav-link text-danger" id="profile-tab" data-bs-toggle="tab" data-bs-target="#profile" type="button" role="tab" aria-controls="profile" aria-selected="false">Details</button>
  </li>
  <li class="nav-item" role="presentation">
    <button class="nav-link text-danger" id="contact-tab" data-bs-toggle="tab" data-bs-target="#contact" type="button" role="tab" aria-controls="contact" aria-selected="false">Payment</button>
  </li>
</ul>
<div class="tab-content" id="myTabContent">
  <div class="tab-pane fade show active p-3" id="home" role="tabpanel" aria-labelledby="home-tab" style="background-color:#fff">

        <div class="container">
            <asp:HiddenField ID="HiddenField1" runat="server" />

            <div class="row" style="padding-top:0px">
                <div class="col-md-1 ">
                </div>
                <div class="col-md-10  p-3 mt-1">
                    <div class="row">

                        <div class="col-md-5  ">

                            <div CssClass="" runat="server" id="slider">
                            </div>
                        </div>
                        <div class="col-md-7">
                            <h3>
                                <asp:Label ID="Label1" runat="server" Text=""></asp:Label></h3>
                            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>

                            <div class="d-flex justify-content-start">
                                <div class="pl-0 pr-3 pt-3">
                                    Rent:  
                                    <asp:Label CssClass="txt-success" ID="Label3" runat="server" Text=""></asp:Label>\-
                                </div>
                                <div class="p-3">
                                    Location: 
                                    <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                                </div>
                            </div>
                            <div class="d-flex justify-content-start">
                                <div class="pl-0 pr-3 pt-3">
                                    <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="p-3">
                                    <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="p-3">
                                    <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
                                </div>
                            </div>                      
                    </div>
                    </div>
                    <h5 class="pt-3"><asp:Label ID="lblfeedback" runat="server" Text=""></asp:Label></h5>
                      
                                                        <asp:Label ID="session" runat="server" Text=""></asp:Label>

                    <asp:GridView GridLines="None" ID="GridView2" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <div class="card p-3 mt-3">
                                        <p>
                                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("name_") %>'></asp:Label>
                                            <span class="ml-2">
                                                <asp:Label ID="Label5" runat="server" Text='<%# Bind("date_time") %>'></asp:Label>
                                            </span>
                                        </p>
                                        <h5>
                                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("feedback") %>'></asp:Label>
                                            <br />
                                            <b>Rating:</b>
                                            <span>
                                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("rating") %>'></asp:Label>
                                            </span>
                                        </h5>
                                    </div>
                                    <asp:Label ID="Label1" runat="server"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
                
        </div>

  </div>
  <div class="tab-pane fade p-3" id="profile" role="tabpanel" aria-labelledby="profile-tab" style="background-color:#fff">
            <div class="row">
          <div class="col-md-6">
<table class="table">
         <h4 class="mb-1">Payment Mode</h4>
           <tr>
              <td>Online <asp:RadioButton ID="RadioButton2" runat="server" />
              </td>
              <td class="">
               Offline<asp:RadioButton ID="RadioButton1" runat="server" />
              </td>
          </tr>
           <tr>
              <td>  <ul>
                     <li> Debit Card </li>
                     <li>
                         Credit
                     </li>
                      <li> Upi </li>
                     <li>
                         Net Banking
                     </li>
                 </ul>
              </td>
              <td >
                  Som offline instructions
              </td>
          </tr>
        
      </table>
          </div>
           <div class="col-md-6">
<table class="table">
          <tr>
              <td>Total Rent:
              </td>
              <td class="text-Primary">Rs.  <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
/-
              </td>
          </tr>
           <tr>
              <td>Advance:
              </td>
              <td class="text-success">Rs.  <asp:Label ID="Label9" runat="server" Text=""></asp:Label> /- (10% of Total Rent)
              </td>
          </tr>
           <tr>
              <td>Processing Fee:
              </td>
              <td class="text-danger">Rs. 0.0/-
              </td>
          </tr>
           <tr>
              <td>Amount to be pay:
              </td>
              <td class="text-success">Rs. <asp:Label ID="Label10" runat="server" Text=""></asp:Label>/-
              </td>
          </tr>
          
      </table>
          </div>
      </div>

  </div>
  <div class="tab-pane fade p-3" id="contact" role="tabpanel" aria-labelledby="contact-tab" style="background-color:#fff">

            <div class="row">
          <div class="col-md-6 mb-3">
              <asp:TextBox ID="TextBox1" CssClass="form-control" placeholder="Full Name" runat="server" required></asp:TextBox>
              <div class="invalid-feedback">
                  Please Enter Full Name.
              </div>
          </div>
          <div class="col-md-6 mb-3">

           
               <asp:TextBox ID="TextBox2" CssClass="form-control" placeholder="Email Id" runat="server" disabled required></asp:TextBox>
              <div class="invalid-feedback">
                  Please Enter Email Id.
              </div>
          </div>
          <div class="col-md-6 mb-3">
               <asp:TextBox ID="TextBox3" CssClass="form-control" placeholder="Your Phone Number" runat="server" required></asp:TextBox>
              <div class="invalid-feedback">
                  Please Enter Phone Number.
              </div>
          </div>
          <div class="col-md-6 mb-3">
               <asp:TextBox ID="TextBox4" CssClass="form-control" placeholder="Other Phone Number" runat="server" required></asp:TextBox>
              <div class="invalid-feedback">
                  Please Enter Other Phone Number.
              </div>
          </div>
            <div class="col-md-6 mb-3">
               <asp:TextBox ID="TextBox5" CssClass="form-control" placeholder="Date of Birth" runat="server" required TextMode="Date"></asp:TextBox>
              <div class="invalid-feedback">
                  Please Enter Date Of Birth.
              </div>
          </div>
          <div class="col-md-6 mb-3">
              <asp:DropDownList CssClass="form-control" ID="DropDownList1" runat="server" required>
                  <asp:ListItem disabled>Gender</asp:ListItem>
                  <asp:ListItem>Male</asp:ListItem>
                  <asp:ListItem>Female</asp:ListItem>
                  <asp:ListItem>Other</asp:ListItem>
              </asp:DropDownList>
          </div>
 
      <div class="col-md-6 mb-3">
              <!-- file -->
              <asp:FileUpload CssClass="form-control" ID="FileUpload1" runat="server" required />
              <div class="invalid-feedback">
                  Please Upload Id Proof.
              </div>
          </div>
                <div class="col-md-6">
                      <asp:TextBox ID="TextBox6" CssClass="form-control" placeholder="Mesage" runat="server" required></asp:TextBox>
              <div class="invalid-feedback">
                  Please Enter Message.
              </div>
                </div>
                <div class="col-3 ml-auto">
                     <asp:Button ID="btnconfirm" CssClass="btn btn-success" runat="server" Text="Confirm Reservation" OnClick="btnconfirm_Click" />
                </div>
                  
               </div>

  </div>
</div>
    </div>
</div>

</div>





    </body>
  </form>

</asp:Content>

