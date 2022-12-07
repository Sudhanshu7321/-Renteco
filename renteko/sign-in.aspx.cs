using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class sign_in : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SingIn_Click(object sender, EventArgs e)
    {

        try
        {
            if (EmailId.Text.Trim() == "" )
            {
                throw new Exception("Please enter valid email id.");
            }
            if(Password.Text.Trim() == "")
            {
                throw new Exception("Please enter correct password");

            }
            else if(con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql_query = "select email_id, password,name from admin where email_id = @email_id and password = @password and status = 1";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@email_id", EmailId.Text.Trim());
            cmd.Parameters.AddWithValue("@password", Password.Text.Trim());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0 && dt != null)
            {
                Session["email_id"] = dt.Rows[0]["email_id"].ToString();
                Response.Redirect("./admin/pages/dashboard.aspx", false);
            }
         
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            lblMassage.Text= ex.Message;
        }
        finally
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}