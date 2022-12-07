<%@ Page Title="" Language="C#" MasterPageFile="~/admin/service_provider.master" AutoEventWireup="true" CodeFile="service-add.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server" class="needs-validation" novalidate>
        <div class="container ">
            <div class="row ">
                <div class="col-md-1"></div>
                <div class="col-md-10 card p-3">
                    <p>
                        <asp:Label ID="Label2" runat="server" Text=" Service"></asp:Label>Service
                    </p>
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                    <asp:TextBox CssClass="form-control mb-2" ID="title" runat="server" placeholder="Title" required></asp:TextBox>
                    <div class="invalid-feedback"> Please Enter Title</div><br/>
                    <asp:TextBox CssClass="form-control mb-2" ID="description" runat="server" placeholder="Description" required></asp:TextBox><div class="invalid-feedback"> Please Enter description</div><br/>
                    <asp:TextBox CssClass="form-control mb-2" ID="cost" runat="server" placeholder="Cost" required></asp:TextBox><div class="invalid-feedback"> Please Enter Cost</div><br/>
                    <asp:TextBox CssClass="form-control mb-2" ID="location" runat="server" placeholder="Location" required></asp:TextBox><div class="invalid-feedback"> Please Enter Location</div><br/>
                    <div class="row">
                        <div class="col-md-6">

                            <asp:DropDownList ID="DropDownCategory" CssClass="form-control mb-2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownCategory_SelectedIndexChanged" required></asp:DropDownList>
                        </div>
                        <div class="col-md-6">
                            <asp:DropDownList ID="DropDownSubCategory" CssClass="form-control mb-2" runat="server" required> </asp:DropDownList> <div class="invalid-feedback"> Please fill the box</div
                        </div>
                    </div>
                    <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="" OnClick="Button1_Click" />
                </div>
            </div>
        </div>
    </form>
</asp:Content>

