<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="category-add.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server" class="needs-validation" novalidate>
         <div class="container ">
        <div class="row ">
            <div class="col-md-1"></div>
            <div class="col-md-10 card p-3">
                <p>Add Category</p>
                 <asp:Label  ID="Label1" runat="server" Text=""></asp:Label>
    <asp:TextBox CssClass="form-control mb-2" ID="category" runat="server" placeholder="Category" required></asp:TextBox>
               
                    <div Class="invalid-feedback">
                        Please Enter Category
                </div> <br/>

    <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="Add Category" OnClick="Button1_Click"  />
            </div>
        </div>
    </div>
        </form>
</asp:Content>

