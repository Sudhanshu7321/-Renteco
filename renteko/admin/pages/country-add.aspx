<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="country-add.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <form runat="server" Class="needs-validation" novalidate>
       <div class="row">
           <div class="col-md-1"></div>
           <div class="col-md-10 card p-3">
                <div class="row">
                      <div class="col-md-9">
                    <p>Country</p>
                      </div>
                      <div class="col-md-3">
                          <a class="btn btn-success ml-auto" href="./country-view.aspx">
                             View Country
                          </a>
                      </div>
                  </div>
               <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
               <asp:TextBox CssClass="form-control mb-3" ID="txtcountry" runat="server" required>
                    </asp:TextBox>

                <div Class="invalid-feedback">
                       Please Enter a Country
                   </div> <br/>
               <asp:Button CssClass="btn btn-success" ID="btnsubmit" runat="server" Text="Add Country" OnClick="btnsubmit_Click" />
           </div>
       </div>
       
   </form>
</asp:Content>

