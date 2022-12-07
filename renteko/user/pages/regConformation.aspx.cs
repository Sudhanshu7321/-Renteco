using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
public partial class regConformation : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    DataTable dt = null;
    SqlDataAdapter da = null;
    string image_path = "";
    string image_path1 = "";
    string image_path2 = "";
    string image_path3 = "";
    string unique_img_path = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //string datetim = DateTime.UtcNow.AddMinutes(330).ToString("dd/MM/yyyy");
            //lblDatetime.Text = datetim;
            //lblJoinDate.Text = datetim;
            //lblDate.Text = datetim;
            //lblId.Text = "1111111";
            if (Session["newmid"].ToString() != "")
            {
                lblId.Text = Session["newmid"].ToString();
            }
            if (Session["name"].ToString() != "")
            {
                lblName.Text = Session["name"].ToString();
                lblName0.Text = Session["name"].ToString();
                lblName1.Text = Session["name"].ToString();
            }
            lblAddress.Text = Session["address"].ToString();
            lblContact.Text = Session["mobile"].ToString();
            lblJoinDate0.Text = DateTime.UtcNow.AddMinutes(330).ToString("dd/MM/yyyy");
            //lblPrdName.Text = Session["product"].ToString();
            //lblAppNo.Text = Session["regNo"].ToString();
            lblPassword.Text = Session["pwd"].ToString();
            //if (Session["product"].ToString().Length==33)
            //    lblAmount.Text = Session["product"].ToString().Substring(26,7);
            lblDatetime.Text = DateTime.UtcNow.AddMinutes(330).ToString("dd/MM/yyyy");
        }
        catch { }


    }
    protected string truncate(string path)
    {
        char[] len = path.ToCharArray(0, path.Length);
        int count = 0;
        int length = path.Length;
        for (int i = length - 1; i > 0; i--)
        {
            char tx = len[i];

            if (tx != '\\')
            {
                count++;
            }
            else
                break;

        }
        string ret_str = (path.Substring(length - count, count));
        return ret_str;

    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("adminUserRegistration.aspx", false);
    }
}