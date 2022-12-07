<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="state-add.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
           <form runat="server" class="needs-validation" novalidate>
       <div class="row">
           <div class="col-md-1"></div>
           <div class="col-md-10 card p-3">
                <div class="row">
                      <div class="col-md-9">
                    <p>State</p>
                      </div>
                      <div class="col-md-3">
                          <a class="btn btn-success ml-auto" href="./state-view.aspx">
                             View State
                          </a>
                      </div>
                  </div>
               <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
               <asp:DropDownList CssClass="form-control mb-3" ID="ddcountry" runat="server" required></asp:DropDownList>
               <asp:TextBox CssClass="form-control mb-3" ID="txtstate" runat="server" required></asp:TextBox> <div class="invalid-feedback"> Please Enter State</div><br/>
               <asp:Button CssClass="btn btn-success" ID="btnsubmit" runat="server" Text="Add State" OnClick="btnsubmit_Click" />
           </div>
       </div>
       
   </form>
</asp:Content>

