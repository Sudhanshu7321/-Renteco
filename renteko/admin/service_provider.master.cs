using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_service_provider : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (System.Web.HttpContext.Current.Session["name"] == null)
        {
            Response.Redirect("../auth/sign-in.aspx", true);

        }
        else
        {
        Label1.Text = Session["name"].ToString();
      
        Image1.ImageUrl = "."+Session["image_path"].ToString();
        }

    }
}
