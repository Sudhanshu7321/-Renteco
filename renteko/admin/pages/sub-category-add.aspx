<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="sub-category-add.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <form runat="server" class="needs-validation" novalidate>
         <div class="container ">
        <div class="row ">
            <div class="col-md-1"></div>
            <div class="col-md-10 card p-3">
                <p>Add Sub Category</p>
                 <asp:Label  ID="Label1" runat="server" Text=""></asp:Label>
                <asp:DropDownList CssClass="form-control mb-2" ID="DropDownCategory" runat="server"></asp:DropDownList>
    <asp:TextBox CssClass="form-control mb-2" ID="subCategory" runat="server" placeholder="Sub Category" required></asp:TextBox><div class="invalid-feedback"> Please Enter sub Category</div> <br />

    <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="Add Sub Category" OnClick="Button1_Click"  />
            </div>
        </div>
    </div>
        </form>
</asp:Content>

