<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="product-detail.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="container">
            <form runat="server">
                              <asp:HiddenField ID="HiddenField1" runat="server" />

            <div class="row" style="padding-top:120px">
                <div class="col-md-1 ">
                </div>
                <div class="col-md-10 card p-3 mt-5">
                    <div class="row">

                        <div class="col-md-6  ">

                            <div CssClass="" runat="server" id="slider">
                            </div>
                        </div>
                        <div class="col-md-6">
                            <h3>
                                <asp:Label ID="Label1" runat="server" Text=""></asp:Label></h3>
                            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>

                            <div class="d-flex justify-content-start">
                                <div class="pl-0 pr-3 pt-3">
                                    Rent:  
                                    <asp:Label CssClass="txt-success" ID="Label3" runat="server" Text=""></asp:Label>\-
                                </div>
                                <div class="p-3">
                                    Location: 
                                    <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                                </div>
                            </div>
                            <div class="d-flex justify-content-start">
                                <div class="pl-0 pr-3 pt-3">
                                    <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="p-3">
                                    <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="p-3">
                                    <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
                                </div>
                            </div>
                        
                         <asp:Button ID="btncheckout" runat="server" Text="" OnClick="checkout_Click" class="btn btn-lg btn-danger btn-lg w-100 mt-4 mb-0"/>
                    </div>
                    </div>
                    <h5 class="pt-3"><asp:Label ID="lblfeedback" runat="server" Text=""></asp:Label></h5>
                      
                                                        <asp:Label ID="session" runat="server" Text=""></asp:Label>

                    <asp:GridView GridLines="None" ID="GridView2" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <div class="card p-3 mt-3">
                                        <p>
                                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("name_") %>'></asp:Label>
                                            <span class="ml-2">
                                                <asp:Label ID="Label5" runat="server" Text='<%# Bind("date_time") %>'></asp:Label>
                                            </span>
                                        </p>
                                        <h5>
                                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("feedback") %>'></asp:Label>
                                            <br />
                                            <b>Rating:</b>
                                            <span>
                                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("rating") %>'></asp:Label>
                                            </span>
                                        </h5>
                                    </div>
                                    <asp:Label ID="Label1" runat="server"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
                
            </form>
        </div>
</asp:Content>

