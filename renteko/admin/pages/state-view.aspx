<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="state-view.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <form runat="server">
       
       
         <div class="row mt-3">
           <div class="col-md-1"></div>
           <div class="col-md-10 card p-3">
                <div class="row">
                      <div class="col-md-9">
                    <p>State</p>
                      </div>
                      <div class="col-md-3">
                          <a class="btn btn-success ml-auto" href="./state-add.aspx">
                             Add State
                          </a>
                      </div>
                  </div>
               <asp:DropDownList Id="ddCountryState" CssClass="form-control mb-3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddCountryState_SelectedIndexChanged"></asp:DropDownList>
               <asp:GridView CssClass="table" Id="GridView2" runat="server" AutoGenerateColumns="False">
                   <columns>
                       <asp:TemplateField HeaderText="S No.">
                           <edititemtemplate>

                           </edititemtemplate>
                           <itemtemplate>
                               <asp:Label ID="Label3" runat="server"></asp:Label>
                           </itemtemplate>
                       </asp:TemplateField>
                       <asp:BoundField DataField="state_name" HeaderText="State" />
                       <asp:TemplateField HeaderText="Status">
                           <edititemtemplate>
                               <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                           </edititemtemplate>
                           <itemtemplate>
                               <asp:Label ID="Label4" runat="server"></asp:Label>
                           </itemtemplate>
                       </asp:TemplateField>
                   </columns>
               </asp:GridView>
               <asp:Label ID="Label11" runat="server" Text=""></asp:Label>
           </div>
       </div>


   </form>
</asp:Content>

