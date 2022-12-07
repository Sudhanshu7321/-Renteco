<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="order-list.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <form runat="server" class="needs-validation" novalidate>

           <body>
               <div class="container" style="padding-top: 150px">
                   <div class="row">
                       <div class="col-12">
                           <ul class="nav nav-tabs pt-3 pl-3 pr-3 pb-0" id="myTab" role="tablist" style="background-color: #212529">
                               <asp:Label ID="lblerror" runat="server" Text="Label"></asp:Label>
                               <li class="nav-item" role="presentation">
                                   <button class="nav-link text-danger active" id="home-tab" data-bs-toggle="tab" data-bs-target="#home" type="button" role="tab" aria-controls="home" aria-selected="true">Reserv</button>
                               </li>
                               <li class="nav-item" role="presentation">
                                   <button class="nav-link text-danger" id="profile-tab" data-bs-toggle="tab" data-bs-target="#profile" type="button" role="tab" aria-controls="profile" aria-selected="false">Conform Reservation</button>
                               </li>
                     <!--      <li class="nav-item" role="presentation">
                                   <button class="nav-link text-danger" id="contact-tab" data-bs-toggle="tab" data-bs-target="#contact" type="button" role="tab" aria-controls="contact" aria-selected="false">Payment</button>
                               </li> -->
                           </ul>
                           <div class="tab-content" id="myTabContent">
                               <div class="tab-pane fade show active p-3" id="home" role="tabpanel" aria-labelledby="home-tab" style="background-color: #fff">

                                       <div id="divpending" runat="server"></div>


                               </div>
                               <div class="tab-pane fade p-3" id="profile" role="tabpanel" aria-labelledby="profile-tab" style="background-color: #fff">
                                 
                                   <div id="divconfirm" runat="server"></div>

                               </div>
                               <div class="tab-pane fade p-3" id="contact" role="tabpanel" aria-labelledby="contact-tab" style="background-color: #fff">

                               

                               </div>
                           </div>
                       </div>
                   </div>

               </div>

           </body>
  </form>
</asp:Content>

