<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="service-adm-list.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <form runat="server">
        <div class="container ">
            <div class="row ">
                <div class="col-md-1"></div>
                <div class="col-md-10 card p-3">
                    <p>
                        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>Service
                    </p>
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                   
                    <div class="row">
                        <div class="col-md-10">
                                                                                     <asp:HiddenField ID="where" runat="server" />

                             <asp:DropDownList CssClass="form-control mb-2" ID="DropDownList1" runat="server" >
                         <asp:ListItem Value="3">Select</asp:ListItem>
                        <asp:ListItem Value="0">Approved</asp:ListItem>
                        <asp:ListItem Value="1">Panding</asp:ListItem>
                    </asp:DropDownList>
                        </div>
                     
                         <div class="col-md-2">
                               <asp:Button CssClass="btn btn-primary" ID="Button3" runat="server" Text="Search" OnClick="Button2_Click" />

                        </div>
                    </div>
                    <asp:GridView CssClass="table" ID="GridView1" runat="server" AutoGenerateColumns="false" GridLines="None" OnRowCommand="GridView1_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="title" HeaderText="Title" />
                            <asp:BoundField DataField="cost" HeaderText="Rent" />
                            <asp:BoundField DataField="location" HeaderText="Location" />
                            <asp:BoundField DataField="date_time" HeaderText="Date &amp; Time" />
                            <asp:TemplateField HeaderText="Action">
                                <ItemTemplate>
                                    <a href="#">
                                        <asp:Button ID="btnview" CssClass="btn btn-warning" runat="server" Text="View" CommandName="cmdview" CauseValidation="false" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "service_id") %>' />
                                    </a>
                                    <asp:Label ID="Label1" runat="server"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </form>
</asp:Content>

