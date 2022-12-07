<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="products.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <form runat="server" >
    <div class="page-heading products-heading header-text">
      <div class="container">
        <div class="row">
          <div class="col-md-12">
            <div class="text-content">
              <h4>new arrivals</h4>
              <h2>RENTIAL SERVICE</h2>
            </div>
          </div>
        </div>
      </div>
    </div>

    
    <div class="products">
      <div class="container">
          <div class="row mb-3">
                            <div class="col-md-1"> </div>

              <div class="col-md-2">
                  <asp:DropDownList ID="DropDownCategory" CssClass="form-control mb-2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownCategory_SelectedIndexChanged"></asp:DropDownList>
              </div>
              <div class="col-md-2">
                  <asp:DropDownList ID="DropDownSubCategory" CssClass="form-control mb-2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownSubCategory_SelectedIndexChanged"></asp:DropDownList>
              </div>
              <div class="col-md-3 pr-0 border-right-0">
                  <asp:TextBox CssClass="form-control" Id="txtsearch" runat="server"></asp:TextBox>
              </div>
              <div class="col-md-1 p-0">
                  <asp:Button CssClass="btn btn-danger" Id="btnsearch" runat="server" Text="Search" OnClick="btnsearch_Click" />
              </div>
               <div class="col-md-2">
                  <asp:DropDownList ID="sortby" CssClass="form-control mb-2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="sortby_SelectedIndexChanged" >
                      <asp:ListItem>Sort By</asp:ListItem>
                      <asp:ListItem>Price: Low to High</asp:ListItem>
                      <asp:ListItem>Price: High to Low</asp:ListItem>
                   </asp:DropDownList>
              </div>
               <div class="col-md-1"> </div>
          </div>
          <div class="row">
              <div class="col-md-12">
                  <div class="filters">
                                             

                      <ul>
                          <li class="active" data-filter="*">All Products</li>
                          <li data-filter=".des">Featured</li>
                          <li data-filter=".dev">Flash Deals</li>
                          <li data-filter=".gra">Last Minute</li>
                      </ul>
                  </div>
              </div>
              <div class="col-md-12">
                  <div class="filters-content">
                      <div class="">
                          <asp:Label CssClass="p-3" ID="Label1" runat="server" Text=""></asp:Label>
                          <div runat="server" id="product"></div>


                      </div>
                  </div>
              </div>


              <div class="col-md-12">
              </div>

              <div class="col-md-12">
                  <ul class="pages">
                      <li></li>
                      <li>
                          <asp:Button runat="server" Text="Latest" />
                      </li>
                      <li class="active">
                          <asp:Label runat="server" Text="Label"></asp:Label>
                      </li>
                      <li><a href="#">3</a></li>
                      <li><a href="#">4</a></li>
                      <li><a href="#"><i class="fa fa-angle-double-right"></i></a></li>
                  </ul>
              </div>

          </div>
      </div>
    </div>

    
</form>


    <!-- Bootstrap core JavaScript -->
    <script src="vendor/jquery/jquery.min.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>


    <!-- Additional Scripts -->
    <script src="assets/js/custom.js"></script>
    <script src="assets/js/owl.js"></script>
    <script src="assets/js/slick.js"></script>
    <script src="assets/js/isotope.js"></script>
    <script src="assets/js/accordions.js"></script>


    <script language = "text/Javascript"> 
      cleared[0] = cleared[1] = cleared[2] = 0; //set a cleared flag for each field
      function clearField(t){                   //declaring the array outside of the
      if(! cleared[t.id]){                      // function makes it static and global
          cleared[t.id] = 1;  // you could use true and false, but that's more typing
          t.value='';         // with more chance of typos
          t.style.color='#fff';
          }
      }
    </script>




</asp:Content>

