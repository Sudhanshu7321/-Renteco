using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class admin_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
     

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        Addcomplain();
    }
    protected void Addcomplain()
    {
        try
        {
            if (txtreason.Text.ToString() == "")
                throw new Exception("Please enter reason");

            if (textcomplainbox.Text.ToString() == "")
                throw new Exception("Please Drop your complain");



            if (con.State == ConnectionState.Closed)
                con.Open();

            string sql_query = "insert into complain(service_provider_id,reason,date_time,status,complain) values(@service_provider_id,@reason,@date_time,@status,@complain)";

            SqlCommand cmd = new SqlCommand(sql_query, con);

           
            cmd.Parameters.AddWithValue("@service_provider_id", Session["Service_provider_id"].ToString());
            cmd.Parameters.AddWithValue("@reason", txtreason.Text.ToString());
            cmd.Parameters.AddWithValue("@complain", textcomplainbox.Text.Trim());
            cmd.Parameters.AddWithValue("@date_time", System.DateTime.UtcNow.ToString("MM/dd/yyyy"));
           
            cmd.Parameters.AddWithValue("@status", 1);
      

            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                lblmsg.Text = "complain Inserted";
                lblmsg.ForeColor = System.Drawing.Color.Green;
                clear();
            }
        }
        catch (Exception ex)
        {
            lblmsg.Text = ex.Message;
            lblmsg.ForeColor = System.Drawing.Color.Red;
            clear();
        }
        finally
        {
            con.Close();
        }
    }

  
    protected void clear()
    {
        
        txtreason.Text = "";
        textcomplainbox.Text = "";
    }
}