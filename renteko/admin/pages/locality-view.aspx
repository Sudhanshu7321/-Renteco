<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="locality-view.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <form runat="server">

                   <div class="row mt-3">
           <div class="col-md-1"></div>
           <div class="col-md-10 card p-3">
                <div class="row">
                      <div class="col-md-9">
                    <p>Locality</p>
                      </div>
                      <div class="col-md-3">
                          <a class="btn btn-success ml-auto" href="./locality-add.aspx">
                             Add Locality
                          </a>
                      </div>
                  </div>
              <div class="row mb-3">
                   <div class="col-md-6">
                        <asp:DropDownList ID="ddCountry" CssClass="form-control mb-3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddCountrylocality_SelectedIndexChanged"></asp:DropDownList>
                   </div>
                   <div class="col-md-6">
                        <asp:DropDownList ID="ddState" CssClass="form-control mb-3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddstatelocality_SelectedIndexChanged"></asp:DropDownList>
                   </div>
                   <div class="col-md-6">
                       <asp:DropDownList ID="ddDistrict" CssClass="form-control mb-3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dddistrictlocality_SelectedIndexChanged"></asp:DropDownList>
                   </div>
                   <div class="col-md-6">
                       <asp:DropDownList ID="ddcity" CssClass="form-control mb-3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddcitylocality_SelectedIndexChanged"></asp:DropDownList>
                   </div>
               </div>

               <asp:GridView  CssClass="table" Id="GridView1" runat="server" AutoGenerateColumns="False">
                   <columns>
                       <asp:TemplateField HeaderText="S No.">
                           <edititemtemplate>

                           </edititemtemplate>
                           <itemtemplate>
                               <asp:Label ID="Label9" runat="server"></asp:Label>
                           </itemtemplate>
                       </asp:TemplateField>
                       <asp:BoundField DataField="locality_name" HeaderText="State" />
                       <asp:TemplateField HeaderText="Status">
                           <edititemtemplate>
                               <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                           </edititemtemplate>
                           <itemtemplate>
                               <asp:Label ID="Label10" runat="server"></asp:Label>
                           </itemtemplate>
                       </asp:TemplateField>
                   </columns>
               </asp:GridView>
               <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
           </div>
       </div>

   </form>
</asp:Content>

