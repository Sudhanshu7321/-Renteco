<%@ Page Title="" Language="C#" MasterPageFile="~/admin/service_provider.master" AutoEventWireup="true" CodeFile="offer-view.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <form runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-1">
                </div>
                <div class="col-md-10 p-3 card">
                    <div class="row">
                        <div class="col-md-10">
                            <h6 class="mb-0">Offer List</h6>
                        </div>
                        <div class="col-md-2">
                            <a class="btn btn-success ml-auto" href="./offer-edit.aspx">Add Offer
                            </a>

                        </div>
                    </div>
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    <asp:GridView CssClass="table" ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
                        <Columns>
                            <asp:BoundField HeaderText="S.no" />
                            <asp:BoundField DataField="title" HeaderText="Title" />
                            <asp:BoundField DataField="description" HeaderText="Description" />
                            <asp:BoundField DataField="starting_date" HeaderText="starting date" />
                            <asp:BoundField DataField="expire_date" HeaderText="Expire date" />
                            <asp:TemplateField HeaderText="Action">
                                <ItemTemplate>
                                        <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Edit" CommandName="cmdedit"  CommandArgument='<%# DataBinder.Eval(Container.DataItem, "offer_id") %>'/>
                                    <asp:Label ID="Label1" runat="server"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                 
                      <asp:Label ID="Label2" runat="server" Text=""></asp:Label>

                </div>
            </div>

        </div>
    </form>
</asp:Content>

