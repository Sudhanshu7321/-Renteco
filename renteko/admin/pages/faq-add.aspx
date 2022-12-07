<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="faq-add.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="container">
        <div class="row mt-7">
            <div class="col-md-1">
            </div>
            <div class="col-md-10 card p-4">
                <form id="form1" runat="server" class="needs-validation" novalidate>
                    <div>
                        <asp:Label class="text-danger" ID="lblMassage" runat="server" Text=""></asp:Label>
                        <asp:Label class="text-success" ID="Label2" runat="server" Text=""></asp:Label>
                        <br/>
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                        <label for="Question" class="form-control-label">Question :</label>

                        <asp:TextBox class="form-control mb-3" ID="Question" runat="server" placeholder="Question" required></asp:TextBox>
                        <div class="invalid-feedback">
                            please Enter a Question
                        </div><br/>
                        <label for="Answer" class="form-control-label">Answer :</label>

                        <asp:TextBox class="form-control mb-3" ID="Answer" runat="server" placeholder="Answers" type="Answer" required></asp:TextBox>
                        <div Class="invalid-feedback">
                            Please Give Answer
                        </div>

                        <asp:Button class="btn btn-success" ID="Add" runat="server" Text="Add" OnClick="Add_Click" />
                    </div>
                </form>

            </div>

        </div>
    </div>

</asp:Content>

