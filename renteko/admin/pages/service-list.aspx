<%@ Page  Title="" Language="C#" MasterPageFile="~/admin/service_provider.master" AutoEventWireup="true" CodeFile="service-list.aspx.cs" Inherits="admin_Default2" EnableEventValidation="false"  %>

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
                            <h6 class="mb-0">Service List</h6>
                        </div>
                        <div class="col-md-2">
                            <a class="btn btn-success ml-auto" href="./service-add.aspx">Add Service
                            </a>
                        </div>
                    </div>
                    <div style="overflow:auto">
                    <asp:GridView ID="GridView1" CssClass="table" runat="server" AutoGenerateColumns="False" GridLines="None" OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound">
                        <columns>
                            <asp:TemplateField HeaderText="S No.">

                                <itemtemplate>
                                    <%# Container.DataItemIndex+1 %>
                                </itemtemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="title" HeaderText="Title" />
                            <asp:BoundField DataField="location" HeaderText="Location" />
                            <asp:BoundField DataField="Cost" HeaderText="Rent" />
                            <asp:BoundField DataField="status" HeaderText="Status" />
                              <asp:TemplateField HeaderText="Status">
                                <itemtemplate>
                                      <asp:Label ID="lblstatus" Text='<%# Bind("status") %>' runat="server"></asp:Label>
                                </itemtemplate>
                            </asp:TemplateField>

                                                       <asp:TemplateField HeaderText="Image">
                                <itemtemplate>
                                    <a href="#">
                                        <asp:Button ID="btnimage" CssClass="btn btn-primary" runat="server" Text="Add" CommandName="cmdimage" CauseValidation="false" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "service_id") %>' />
                                    </a>
                                    <asp:Label ID="Label11" runat="server"></asp:Label>
                                </itemtemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Action" ShowHeader="False">
                                <itemtemplate>
                                    <a href="#">
                                        <asp:Button ID="btnview" CssClass="btn btn-success" runat="server" Text="Edit" CommandName="cmdview" CauseValidation="true" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "service_id") %>' />
                                    </a>
                                </itemtemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="View">
                                <itemtemplate>
                                    <a href="#">
                                        <asp:Button ID="btndetails" CssClass="btn btn-warning" runat="server" Text="Details" CommandName="cmddetails" CauseValidation="false" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "service_id") %>' />
                                    </a>
                                    <asp:Label ID="Label1" runat="server"></asp:Label>
                                </itemtemplate>
                            </asp:TemplateField>
                        </columns>
                    </asp:GridView>

                    </div>
                    <asp:Label class="" ID="Label1" runat="server" Text=""></asp:Label>

                </div>
            </div>

        </div>
    </form>
</asp:Content>

