using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_user : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (System.Web.HttpContext.Current.Session["user_id"] == null)
            navitem.InnerHtml= "<ul class='navbar-nav ml-auto'><li class='nav-item'><a class='nav-link' href='index.aspx'>Home</a></li><li class='nav-item'><a class='nav-link' href='./about-us.aspx'>About Us</a></li><li class='nav-item'><a class='nav-link' href='./contact-us.aspx'>Contact Us</a></li><li class='nav-item'><a class='nav-link' href='../../admin/auth/sign-in.aspx'>Service Provider</a></li>><li class='nav-item'><a class='nav-link' href='./sign-in.aspx'>Sign In</a></li></ul>";
        else
            navitem.InnerHtml = "<ul class='navbar-nav ml-auto'><li class='nav-item'><a class='nav-link' href='index.aspx'>Home</a></li><li class='nav-item'><a class='nav-link' href='./about-us.aspx'>About Us</a></li><li class='nav-item'><a class='nav-link' href='./contact-us.aspx'>Contact Us</a></li><li class='nav-item'><a class='nav-link' href='./profile.aspx'>Profile</a></li><li class='nav-item'><a class='nav-link' href='./order-list.aspx'>Order</a></li><li class='nav-item'><a class='nav-link' href='./sign-out.aspx'>Sign Out</a></li></ul>";
    }



    /* protected void btnsign(object sender, EventArgs e)
     {
         if (System.Web.HttpContext.Current.Session["user_id"] == null)
             Response.Redirect("../auth/sign-out.aspx", true);
         else
             Response.Redirect("../auth/sign-in.aspx", false);
           <form runat="server">
                      <asp:Button CssClass="nav-link text-white border-top-0 border-left-0 border-right-0 "  ID="sign" runat="server" Text="" OnClick="btnsign" BackColor="#212529"/>
                </form>

     }*/
}
