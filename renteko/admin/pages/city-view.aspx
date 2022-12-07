<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="city-view.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <form runat="server">


            <div class="row mt-3">
           <div class="col-md-1"></div>
           <div class="col-md-10 card p-3">
                <div class="row">
                      <div class="col-md-9">
                    <p>City</p>
                      </div>
                      <div class="col-md-3">
                          <a class="btn btn-success ml-auto" href="./city-add.aspx">
                             Add City
                          </a>
                      </div>
                  </div>
               <div class="row mb-3">
                   <div class="col-md-12">
                        <asp:DropDownList ID="ddCountry" CssClass="form-control mb-3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddCountrycity_SelectedIndexChanged"></asp:DropDownList>
                   </div>
                   <div class="col-md-6">
                        <asp:DropDownList ID="ddState" CssClass="form-control mb-3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddstatecity_SelectedIndexChanged"></asp:DropDownList>
                   </div>
                   <div class="col-md-6">
                       <asp:DropDownList ID="ddDistrict" CssClass="form-control mb-3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dddistrictcity_SelectedIndexChanged"></asp:DropDownList>
                   </div>
               </div>

               <asp:GridView  CssClass="table" Id="GridView1" runat="server" AutoGenerateColumns="False">
                   <columns>
                       <asp:TemplateField HeaderText="S No.">
                           <edititemtemplate>

                           </edititemtemplate>
                           <itemtemplate>
                               <asp:Label ID="Label7" runat="server"></asp:Label>
                           </itemtemplate>
                       </asp:TemplateField>
                       <asp:BoundField DataField="city_name" HeaderText="State" />
                       <asp:TemplateField HeaderText="Status">
                           <edititemtemplate>
                               <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                           </edititemtemplate>
                           <itemtemplate>
                               <asp:Label ID="Label8" runat="server"></asp:Label>
                           </itemtemplate>
                       </asp:TemplateField>
                   </columns>
               </asp:GridView>
               <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
           </div>
       </div>

           

   </form>
</asp:Content>

