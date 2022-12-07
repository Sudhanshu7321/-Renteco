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

    protected void AddCountry()
    {
        try
        {
            if (txtcountry.Text == "")
                throw new Exception("Please Enter Country");

            if(con.State != ConnectionState.Open)
                con.Open();

            string sql_query = "insert into country (country_name , status) values(@country_name , @status)";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@country_name", txtcountry.Text.ToString());
            cmd.Parameters.AddWithValue("@status", 1);
            if (cmd.ExecuteNonQuery() > 0)
                Label1.Text = "Country added";
            Label1.ForeColor = System.Drawing.Color.Green;
            clear();

        }
        catch (Exception ex)
        {
            Label1.Text = ex.Message;
            Label1.ForeColor = System.Drawing.Color.Red;
        }
        finally
        {
            con.Close();
        }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        AddCountry();
    }
    protected void clear()
    {
        txtcountry.Text = "";
    }
}