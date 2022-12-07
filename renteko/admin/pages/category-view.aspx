<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="category-view.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server">
        <div class="container ">
            <div class="row ">
                <div class="col-md-1"></div>
                <div class="col-md-10 card p-3">

                     <div class="row">
                      <div class="col-md-9">
                    <p>Category</p>
                      </div>
                      <div class="col-md-3">
                          <a  class="btn btn-success ml-auto" href="./category-add.aspx">
                              Add Category
                          </a>
                      </div>
                  </div>
                    <asp:GridView ID="GridView1" runat="server" CssClass="table" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField HeaderText="S No." />
                            <asp:BoundField DataField="category_name" HeaderText="Category" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>

        <div class="container mt-3">
            <div class="row ">
                <div class="col-md-1"></div>
                <div class="col-md-10 card p-3">
                    <div class="row">
                      <div class="col-md-9">
                    <p>Sub Category</p>
                      </div>
                      <div class="col-md-3">
                          <a class="btn btn-success ml-auto" href="./sub-category-add.aspx">
                             Add Sub Category
                          </a>
                      </div>
                  </div>

                    <asp:DropDownList ID="DropDownCategory" CssClass="form-control" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownSubCategory_SelectedIndexChanged"></asp:DropDownList>
                    <asp:GridView ID="GridView2" runat="server" CssClass="table mt-3" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField HeaderText="S No." />
                            <asp:BoundField DataField="Sub_category_name" HeaderText="Category" />
                             </Columns>
                    </asp:GridView>
 <asp:Label CssClass=" p-3" ID="lblmsg" runat="server" Text=""></asp:Label>

                </div>
            </div>
        </div>
    </form>

</asp:Content>

