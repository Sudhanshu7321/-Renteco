﻿<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="feedback-update.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server" class="needs-validation" novalidate>
         <div class="row">
      <div class="col-md-1">
        </div>
      <div class="col-md-10">
            <div class="card p-3 mb-5">
                        <asp:Label ID="Label1" CssClass="mb-2" runat="server" Text=""></asp:Label> <br />

        <asp:Label ID="lblmsg" CssClass="mb-2" runat="server" Text=""></asp:Label> <br />
        <asp:TextBox ID="txtname" placeholder="Student Name" CssClass="form-control mb-2" runat="server" required></asp:TextBox> <div class="invalid-feedback">Please Enter Student Name</div><br />
        <asp:TextBox ID="textfeedback" placeholder="Feedback" CssClass="form-control mb-2" TextMode="MultiLine" MaxLength="500"  runat="server" required> 
        </asp:TextBox> 
                <div class="invalid-feedback">
                    Please Give your opnion
                </div><br />
        <asp:Button ID="btnsubmit" runat="server" CssClass="btn btn-success" Text="Update" OnClick="btnsubmit_Click"  />
        </div>
</div></div>
    </form>
</asp:Content>

