<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="district-view.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <form runat="server">
    

         <div class="row mt-3">
           <div class="col-md-1"></div>
           <div class="col-md-10 card p-3">
                <div class="row">
                      <div class="col-md-9">
                    <p>District</p>
                      </div>
                      <div class="col-md-3">
                          <a class="btn btn-success ml-auto" href="./district-add.aspx">
                             Add District
                          </a>
                      </div>
                  </div>
               <div class="row mb-3">
                   <div class="col-md-6">
                       <asp:DropDownList ID="ddCountry" CssClass="form-control mb-3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddCountrydistic_SelectedIndexChanged"></asp:DropDownList>
                   </div>
                   <div class="col-md-6">
                       <asp:DropDownList ID="ddState" CssClass="form-control mb-3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddstatedistic_SelectedIndexChanged"></asp:DropDownList>
                   </div>
               </div>
               <asp:GridView CssClass="table" Id="GridView1" runat="server" AutoGenerateColumns="False">
                   <columns>
                       <asp:TemplateField HeaderText="S No.">
                           <edititemtemplate>

                           </edititemtemplate>
                           <itemtemplate>
                               <asp:Label ID="Label5" runat="server"></asp:Label>
                           </itemtemplate>
                       </asp:TemplateField>
                       <asp:BoundField DataField="district_name" HeaderText="State" />
                       <asp:TemplateField HeaderText="Status">
                           <edititemtemplate>
                               <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                           </edititemtemplate>
                           <itemtemplate>
                               <asp:Label ID="Label6" runat="server"></asp:Label>
                           </itemtemplate>
                       </asp:TemplateField>
                   </columns>
               </asp:GridView>
               <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
           </div>
       </div>

   

   </form>
</asp:Content>

