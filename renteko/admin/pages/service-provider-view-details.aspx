<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="service-provider-view-details.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server">


     <div class="container-fluid py-4 ">
      <div class="row">
                  <div class="col-md-1">
</div>
        <div class="col-md-10">
          <div class="card card-profile">
           
            <div class="row justify-content-center">
              <div class="col-4 col-lg-4 order-lg-2">
                <div class="mt-n4 mt-lg-n6 mb-4 mb-lg-0">
                    <asp:Image CssClass="rounded-circle img-fluid border border-2 border-white" ID="Image1" runat="server" />
                </div>
              </div>
            </div>
            <div class="card-header text-center border-0 pt-0 pt-lg-2 pb-4 pb-lg-3">
              <div class="d-flex justify-content-between">
                <asp:Button CssClass="btn btn-sm btn-primary float-right mb-0 d-none d-lg-block" ID="Button1" runat="server" Text="Service" OnClick="Button1_Click"  />
                  <asp:Button CssClass="btn btn-sm btn-success float-right mb-0 d-none d-lg-block" ID="btnaction" runat="server" Text="Approved" OnClick="Approved_Click" />

                <a href="javascript:;" class="btn btn-sm btn-dark float-right mb-0 d-block d-lg-none"><i class="ni ni-email-83"></i></a>
              </div>
            </div>
            <div class="card-body pt-0">
              <div class="row">
                <div class="col">
                  <div class="d-flex justify-content-center">
                    <div class="d-grid text-center">
                        <h5>
                            <asp:Label ID="Name" runat="server"></asp:Label>
                        </h5>
                    </div>
                   
                  </div>
                </div>
                 
              </div>
                <div class="row">
   <div class="col-md-1"></div>
   <div class="col-md-10">
        <div class="text-center mt-4">
                <div class="h6 font-weight-300">
                                         <asp:Label ID="Email" runat="server"></asp:Label><br/>
                    <asp:Label ID="phoneno" runat="server"></asp:Label>
                  <i class="ni location_pin mr-2"></i> 
                    <asp:Label ID="Country" runat="server"></asp:Label>
                    <asp:Label ID="State" runat="server"></asp:Label>
                    <asp:Label ID="City" runat="server"></asp:Label>
                    <asp:Label ID="Distic" runat="server"></asp:Label>
                                        <asp:Label ID="Locality" runat="server"></asp:Label>
                    <asp:Label ID="Pincode" runat="server"></asp:Label>
                                        <asp:Label ID="service_provider_id" runat="server"></asp:Label>


                </div>
                <div class="h6 mt-4">
                  <i class="ni business_briefcase-24 mr-2"></i>Solution Manager - Creative Tim Officer
                </div>
                <div>
                  <i class="ni education_hat mr-2"></i>
                     <asp:Label ID="DateTime" runat="server"></asp:Label>
                </div>
              </div>
   </div>
   <div class="col-md-1"></div>
</div>
            </div>
          </div>
        </div>
      </div>
     
  </div>
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
            </form>
</asp:Content>

