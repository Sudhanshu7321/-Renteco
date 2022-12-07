<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="country-view.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    Country
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <form runat="server">
       <div class="row">
           <div class="col-md-1"></div>
           <div class="col-md-10 card p-3">
                <div class="row">
                      <div class="col-md-9">
                    <p>Country</p>
                      </div>
                      <div class="col-md-3">
                          <a class="btn btn-success ml-auto" href="./country-add.aspx">
                             Add Country
                          </a>
                      </div>
                  </div>
               <asp:GridView  Id="Country" CssClass="table" runat="server" AutoGenerateColumns="False">
                   <columns>
                       <asp:TemplateField HeaderText="S No.">
                           <edititemtemplate>
                               <%# Container.DataItemIndex+1 %>
                           </edititemtemplate>
                           <itemtemplate>
                               <asp:Label ID="Label2" runat="server"></asp:Label>
                           </itemtemplate>
                       </asp:TemplateField>
                       <asp:BoundField DataField="country_name" HeaderText="Country" />
                       <asp:TemplateField HeaderText="Status">
                           <edititemtemplate>
                               <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                           </edititemtemplate>
                           <itemtemplate>
                               <asp:Label ID="Label1" runat="server"></asp:Label>
                           </itemtemplate>
                       </asp:TemplateField>
                   </columns>
               </asp:GridView>
           </div>
       </div>
       
   </form>
</asp:Content>

