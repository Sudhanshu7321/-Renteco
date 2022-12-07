<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="service-adm-view.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-1">
                </div>
                 <div class="col-md-10 card p-3">
                       <div class="row">
                           <div class="col-md-5  ">
                               <div runat="server" id="slider">

                               </div>
                      
                           </div>
                           <div class="col-md-7">
                               <h3>
                                   <asp:Label ID="Label1" runat="server" Text=""></asp:Label></h3>
                               <asp:Label ID="Label2" runat="server" Text=""></asp:Label>

                               <div class="d-flex justify-content-start">
                                   <div class="pl-0 pr-3 pt-3">
                                    Rent:   <asp:Label CssClass="txt-success" ID="Label3" runat="server" Text=""></asp:Label>\-
                                   </div>
                                   <div class="p-3">
                                     Location:  <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
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
                                   <asp:Button ID="btnaction" OnClick="option_click" runat="server" Text=""  class="btn btn-danger btn-lg w-100 mt-4 mb-0" />
                               </div>
                              
                           </div>
                          
            </div>

                       <h5 class="pt-3">Feedback</h5>
                           <asp:GridView GridLines="None" ID="GridView2" runat="server" AutoGenerateColumns="False">
                               <Columns>
                                   <asp:TemplateField>
                                       <ItemTemplate>
                                           <div class="card p-3 mt-3">
                                               <p>
                                                   <asp:Label ID="Label2" runat="server" Text='<%# Bind("name") %>'></asp:Label>
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
    </form>
</asp:Content>

