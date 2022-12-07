<%@ Page Title="" Language="C#" MasterPageFile="~/admin/service_provider.master" AutoEventWireup="true" CodeFile="offer-edit.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server" Class="needs-validation" novalidate>
        <div class="container ">
            <div class="row ">
                <div class="col-md-1"></div>
                <div class="col-md-10 card p-3">
                    <p>
                        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>Offer
                    </p>
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    <asp:HiddenField ID="Label3" runat="server" />
                    <asp:DropDownList CssClass="form-control mb-2" ID="ddservice" runat="server" required></asp:DropDownList>
                    
                  <asp:TextBox ID="texttitle" placeholder="Title" CssClass="form-control mb-2" runat="server" required></asp:TextBox> <div class="invalid-feedback"> Please Enter a Title </div><br/>
                     <asp:TextBox ID="txtdescription" placeholder="description" CssClass="form-control mb-2" runat="server" TextMode="MultiLine" required></asp:TextBox> <div class="invalid-feedback"> Please Enter Description</div> 
                    <div class="row">
                    <div class="col-md-6 mt-1">
                          Staring Date   <asp:TextBox ID="txtstarting_date"  CssClass="form-control mb-2" TextMode="Date" runat="server" required></asp:TextBox> <div class="invalid-feedback"> Please Enter Starting Date </div> 
                     <div class="col-md-6 mt-1">
                                         Expire Date     <asp:TextBox ID="txtexpire_date"  CssClass="form-control mb-2" TextMode="Date" runat="server" required></asp:TextBox><div class="invalid-feedback"> Please Enter Expire Date </div>

                    </div> <br/>
                </div>
                    <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="" OnClick="Button1_Click" />
                </div>
            </div>
        </div>
    </form>
</asp:Content>

