<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="complaine-view-details.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <form runat=server >
       <div class="container">
           <div class="row">
               <div class="col-md-1">
               </div>
               <div class="col-md-10">
                     <div class="card p-3">
                         <p>
                             <b>Complain</b>
                         </p>
        <asp:GridView runat="server" AutoGenerateColumns="False" ID="GridView1">
        <Columns>
            <asp:BoundField DataField="email_id" HeaderText="Reason" />
        </Columns>
    </asp:GridView>
             </div>
               </div>
           </div>
           </div>
     
   </form> 
</asp:Content>

