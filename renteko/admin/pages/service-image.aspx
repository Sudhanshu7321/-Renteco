<%@ Page Title="" Language="C#" MasterPageFile="~/admin/service_provider.master" AutoEventWireup="true" CodeFile="service-image.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server">
        <div class="container">
            <div class="row card p-3">
                <div class="col-md-1">
                </div>
                <div class="col-md-10">
                    <p>Add service image</p>
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    <asp:TextBox CssClass="form-control mb-3" placeholder="Image Name" ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:FileUpload CssClass="form-control mb-3" ID="FileUpload1" runat="server" />
                    <asp:Button CssClass="btn  btn-success" ID="Button1" runat="server" Text="Upload" OnClick="Button1_Click" />
                </div>
            </div>

              <div class="row card p-3 mt-3">
                <div class="col-md-1">
                </div>
                <div class="col-md-10">
                    <asp:GridView CssClass="container"  ID="GridView1" runat="server" AutoGenerateColumns="False">
                        <Columns >
                            <asp:TemplateField >
                                <ItemTemplate >
                                    <asp:Image CssClass="img-thumbnail"  ID="Image1" runat="server" ImageUrl='<%# Eval("image_path") %>' />
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

