<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="feedback.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server">
        <div class="container">
 <div class="row">
      <div class="col-md-1">
        </div>
      <div class="col-md-10">
            <div class="card p-3 mb-5">
        <asp:Label ID="lblmsg" CssClass="mb-2" runat="server" Text=""></asp:Label> <br />
        <asp:TextBox ID="txtname" placeholder="Student Name" CssClass="form-control mb-2" runat="server"></asp:TextBox> <br />
        <asp:TextBox ID="textrollno" placeholder="Student Roll No" CssClass="form-control mb-2" runat="server"></asp:TextBox> <br />
        <asp:TextBox ID="textfeedback" placeholder="Feedback" CssClass="form-control mb-2" TextMode="MultiLine" MaxLength="500"  runat="server"></asp:TextBox> <br />
        <asp:Button ID="btnsubmit" runat="server" CssClass="btn btn-success" Text="Submit" OnClick="btnsubmit_Click" />
        </div>

          <!-- Grid VIew -->
              <asp:Label ID="lblerror" runat="server" Text=""></asp:Label>
          <div class="card p-3">
               <asp:GridView CssClass="table" ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
            <columns>
                <asp:BoundField DataField="c_name" HeaderText="Name" />
                <asp:BoundField DataField="c_roll_no" HeaderText="Roll no." />
                <asp:BoundField DataField="feedback" HeaderText="Feedback" />
                <asp:BoundField DataField="rating" HeaderText="Rating" />
                <asp:BoundField DataField="doe" HeaderText="Date &amp; Time" />
                <asp:TemplateField HeaderText="Action">
                    <itemtemplate>
                        <a href="#" onclick="return confirm('Are You Sure\You Want to delete the record')">
                            <asp:Button ID="btndelete" CssClass="btn btn-danger" runat="server" Text="Delete" CommandName="cmddelete" CauseValidation="false" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "c_roll_no") %>' />
                        </a>
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </itemtemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Update">
                    <itemtemplate>
                        <a href="#" onclick="return confirm(' You  Want to Update this record')">
                            <asp:Button ID="btnupdate" CssClass="btn btn-success" runat="server" Text="Select" CommandName="cmdupdate" CauseValidation="false" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "c_roll_no") %>' />
                        </a>
                        <asp:Label ID="Label22" runat="server"></asp:Label>
                    </itemtemplate>
                </asp:TemplateField>
            </columns>
        </asp:GridView>
          </div>
        </div>
        </div>
        </div>
      
            
    </form>
</asp:Content>

