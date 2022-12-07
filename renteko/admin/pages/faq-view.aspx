<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="faq-view.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    FAQ
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <form id="form1" runat="server">


            <div class="col-md-10 mt-4">
          <div class="card">
              <div class="card-header pb-0 px-3">
                  <div class="row">
                      <div class="col-md-10">
                          <h6 class="mb-0">FAQ</h6>
                          <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                      </div>
                      <div class="col-md-2">
                          <a href="./faq-add.aspx">
                              <button class="btn btn-success ml-auto">Add faq</button>
                          </a>
                      </div>
                  </div>
              </div>

              <asp:GridView ID="GridView1" GridLines="None" runat="server" AutoGenerateColumns="False" AlternatingRowStyle-BorderWidth="0" OnRowCommand="GridView1_RowCommand">
                  <AlternatingRowStyle BorderWidth="0px"></AlternatingRowStyle>
                  <Columns>
                      <asp:TemplateField>
                          <ItemTemplate>
                              <div class="card-body pt-1 p-3">
                                  <ul class="list-group">
                                      <li class="list-group-item border-0 d-flex p-4  bg-gray-100 border-radius-lg">
                                          <div class="d-flex flex-column">
                                              <h6 class=" text-sm">
                                                  <asp:Label ID="lblq1" runat="server" Text='<%# Bind("question") %>'></asp:Label>
                                              </h6>
                                              <span class="mb-2 text-xs">
                                                  <asp:Label ID="lbla1" runat="server" Text='<%# Bind("answer") %>'></asp:Label>
                                              </span></span>
                          </ItemTemplate>
                      </asp:TemplateField>
                   
                  </Columns>
              </asp:GridView>
           </div>
     <!--   <div class="col-md-10 mt-4">
          <div class="card">
            <div class="card-header pb-0 px-3">
                 <div class="row">
          <div class="col-md-10">
                            <h6 class="mb-0">FAQ</h6>
          </div>
          <div class="col-md-2">
                        <a href="./faq-add.aspx">
                 <button class="btn btn-success ml-auto"  > Add faq +</button>
</a>
          </div>
        </div>
            </div>
            <div class="card-body pt-4 p-3">

              <ul class="list-group">
                <li class="list-group-item border-0 d-flex p-4 mb-2 bg-gray-100 border-radius-lg">
                  <div class="d-flex flex-column">
                    <h6 class="mb-3 text-sm">Dummy Text Generator - Free, For Web Designers - Lorem Ipsum ?</h6>
                    <span class="mb-2 text-xs">With dummy text you can view your website as it's supposed to look, without being distracted by familiar, readable text. Generate Dummy Text. Use 'Lorem Ipsum...' words; Use English words; Number of Words: Number of Paragraphs<span class="text-dark font-weight-bold ms-sm-2">Viking
                        Burrito</span></span>
                  </div>
                  <div class="ms-auto text-end">
                    <a class="btn btn-link text-danger text-gradient px-3 mb-0" href="javascript:;"><i
                        class="far fa-trash-alt me-2"></i>Delete</a>
                    <a class="btn btn-link text-dark px-3 mb-0" href="javascript:;"><i
                        class="fas fa-pencil-alt text-dark me-2" aria-hidden="true"></i>Edit</a>
                  </div>
                </li>
               <li class="list-group-item border-0 d-flex p-4 mb-2 bg-gray-100 border-radius-lg">
                  <div class="d-flex flex-column">
                    <h6 class="mb-3 text-sm">Dummy Text Generator - Free, For Web Designers - Lorem Ipsum ?</h6>
                    <span class="mb-2 text-xs">With dummy text you can view your website as it's supposed to look, without being distracted by familiar, readable text. Generate Dummy Text. Use 'Lorem Ipsum...' words; Use English words; Number of Words: Number of Paragraphs<span class="text-dark font-weight-bold ms-sm-2">Viking
                        Burrito</span></span>
                  </div>
                  <div class="ms-auto text-end">
                    <a class="btn btn-link text-danger text-gradient px-3 mb-0" href="javascript:;"><i
                        class="far fa-trash-alt me-2"></i>Delete</a>
                    <a class="btn btn-link text-dark px-3 mb-0" href="javascript:;"><i
                        class="fas fa-pencil-alt text-dark me-2" aria-hidden="true"></i>Edit</a>
                  </div>
                </li> <li class="list-group-item border-0 d-flex p-4 mb-2 bg-gray-100 border-radius-lg">
                  <div class="d-flex flex-column">
                    <h6 class="mb-3 text-sm">Dummy Text Generator - Free, For Web Designers - Lorem Ipsum ?</h6>
                    <span class="mb-2 text-xs">With dummy text you can view your website as it's supposed to look, without being distracted by familiar, readable text. Generate Dummy Text. Use 'Lorem Ipsum...' words; Use English words; Number of Words: Number of Paragraphs<span class="text-dark font-weight-bold ms-sm-2">Viking
                        Burrito</span></span>
                  </div>
                  <div class="ms-auto text-end">
                    <a class="btn btn-link text-danger text-gradient px-3 mb-0" href="javascript:;"><i
                        class="far fa-trash-alt me-2"></i>Delete</a>
                    <a class="btn btn-link text-dark px-3 mb-0" href="javascript:;"><i
                        class="fas fa-pencil-alt text-dark me-2" aria-hidden="true"></i>Edit</a>
                  </div>
                </li> <li class="list-group-item border-0 d-flex p-4 mb-2 bg-gray-100 border-radius-lg">
                  <div class="d-flex flex-column">
                    <h6 class="mb-3 text-sm">Dummy Text Generator - Free, For Web Designers - Lorem Ipsum ?</h6>
                    <span class="mb-2 text-xs">With dummy text you can view your website as it's supposed to look, without being distracted by familiar, readable text. Generate Dummy Text. Use 'Lorem Ipsum...' words; Use English words; Number of Words: Number of Paragraphs<span class="text-dark font-weight-bold ms-sm-2">Viking
                        Burrito</span></span>
                  </div>
                  <div class="ms-auto text-end">
                    <a class="btn btn-link text-danger text-gradient px-3 mb-0" href="javascript:;"><i
                        class="far fa-trash-alt me-2"></i>Delete</a>
                    <a class="btn btn-link text-dark px-3 mb-0" href="javascript:;"><i
                        class="fas fa-pencil-alt text-dark me-2" aria-hidden="true"></i>Edit</a>
                  </div>
                </li> <li class="list-group-item border-0 d-flex p-4 mb-2 bg-gray-100 border-radius-lg">
                  <div class="d-flex flex-column">
                    <h6 class="mb-3 text-sm">Dummy Text Generator - Free, For Web Designers - Lorem Ipsum ?</h6>
                    <span class="mb-2 text-xs">With dummy text you can view your website as it's supposed to look, without being distracted by familiar, readable text. Generate Dummy Text. Use 'Lorem Ipsum...' words; Use English words; Number of Words: Number of Paragraphs<span class="text-dark font-weight-bold ms-sm-2">Viking
                        Burrito</span></span>
                  </div>
                  <div class="ms-auto text-end">
                    <a class="btn btn-link text-danger text-gradient px-3 mb-0" href="javascript:;"><i
                        class="far fa-trash-alt me-2"></i>Delete</a>
                    <a class="btn btn-link text-dark px-3 mb-0" href="javascript:;"><i
                        class="fas fa-pencil-alt text-dark me-2" aria-hidden="true"></i>Edit</a>
                  </div>
                </li> <li class="list-group-item border-0 d-flex p-4 mb-2 bg-gray-100 border-radius-lg">
                  <div class="d-flex flex-column">
                    <h6 class="mb-3 text-sm">Dummy Text Generator - Free, For Web Designers - Lorem Ipsum ?</h6>
                    <span class="mb-2 text-xs">With dummy text you can view your website as it's supposed to look, without being distracted by familiar, readable text. Generate Dummy Text. Use 'Lorem Ipsum...' words; Use English words; Number of Words: Number of Paragraphs<span class="text-dark font-weight-bold ms-sm-2">Viking
                        Burrito</span></span>
                  </div>
                  <div class="ms-auto text-end">
                    <a class="btn btn-link text-danger text-gradient px-3 mb-0" href="javascript:;"><i
                        class="far fa-trash-alt me-2"></i>Delete</a>
                    <a class="btn btn-link text-dark px-3 mb-0" href="javascript:;"><i
                        class="fas fa-pencil-alt text-dark me-2" aria-hidden="true"></i>Edit</a>
                  </div>
                </li>
              </ul>
            </div>
          </div>
        </div> -->
      
      </div>
             </form>
</asp:Content>

