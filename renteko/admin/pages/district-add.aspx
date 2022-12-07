<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="district-add.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server" class="needs-validation" novalidate>
     <div class="row">
           <div class="col-md-1"></div>
           <div class="col-md-10 card p-3">
            <div class="row">
                      <div class="col-md-9">
                    <p>district</p>
                      </div>
                     <div class="col-md-3">
                          <a class="btn btn-success ml-auto" href="./district-view.aspx">
                            view district
                          </a>
                      </div>
                  </div> 
               <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
               <div class="row">
                   <div class="col-md-6">
                     <asp:DropDownList CssClass="form-control mb-3" ID="ddcountry" runat="server" OnSelectedIndexChanged="ddcountry_SelectedIndexChanged" AutoPostBack="True" ></asp:DropDownList>
                   </div>
                    <div class="col-md-6">
                      <asp:DropDownList CssClass="form-control mb-3" ID="ddstate" runat="server" OnSelectedIndexChanged="ddstate_SelectedIndexChanged"  AutoPostBack="True"></asp:DropDownList>
                   </div>

                     <div class="col-md-6">
                           <asp:TextBox CssClass="form-control mb-3" ID="txtdistrict" runat="server" required></asp:TextBox>
                         <div class="invalid-feedback">
                             Please Enter District
                         </div> <br/>
               <asp:Button CssClass="btn btn-success" ID="Button1" runat="server" Text="Add district" OnClick="btnsubmit_Click" />
                   </div>
               </div>
             
       
   </form>
</asp:Content>

