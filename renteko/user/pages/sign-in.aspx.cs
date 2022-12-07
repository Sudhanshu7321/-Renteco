using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
public partial class user_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie reqCookies = Request.Cookies["userInfo"];
        if (reqCookies != null)
        {
           
            EmailId.Text = reqCookies["email_id"].ToString();
            Password.Text = reqCookies["password"].ToString();
        }
    }
    protected void SingIn_Click(object sender, EventArgs e)
    {

        try
        {

            if (EmailId.Text.Trim() == "")
            {
                throw new Exception("Enter Valid Email ID");
            }
            if (Password.Text.Trim() == "")
            {
                throw new Exception("Please Enter Password");
            }

            

            Password enc = new Password();
            string password = enc.EncryptPlainTextToCipherText(Password.Text.Trim(), EmailId.Text.Trim());

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string sql_query = "select * from users where email_id = @email_id and password = @password and status = 1";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@email_id", EmailId.Text.Trim());
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0 && dt != null)
            {
                if (checkbox.Checked == true)
                    Cookie();

                Session["name"] = dt.Rows[0]["name"].ToString();
                Session["user_id"] = dt.Rows[0]["user_id"].ToString();
                if (Request.QueryString.HasKeys())
                    Response.Redirect("../pages/order.aspx?val=" + Request.QueryString["val"], false);
                else
                    Response.Redirect("../pages/index.aspx", false);


            }
            else
            {
                lblMassage.Text = "Wrong Credentials";
                lblMassage.ForeColor = System.Drawing.Color.Red;
                clear(); 
            }

        }
        catch (Exception ex)
        {
            lblMassage.Text = ex.Message;
            lblMassage.ForeColor = System.Drawing.Color.Red;
        }
        finally
        {
            con.Close();

        }
    }

    protected void clear()
    {
        EmailId.Text = "";
        Password.Text = "";
    }

   protected void Cookie()
    {
        HttpCookie userInfo = new HttpCookie("userInfo");
        userInfo["email_id"] = EmailId.Text.Trim();
        userInfo["password"] = Password.Text.Trim();
        userInfo.Expires.Add(new TimeSpan(0, 1, 0));
        Response.Cookies.Add(userInfo);
    }
}