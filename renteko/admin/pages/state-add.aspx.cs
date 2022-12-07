using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            ddCountryDataBind();
        }
    }

    protected void ddCountryDataBind()
    {
        try
        {
            if (con.State != ConnectionState.Open)
                con.Open();

            string sql_query = "select * from country";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0 && dt != null)
            {
                ddcountry.DataSource = dt;
                ddcountry.DataValueField = "country_id";
                ddcountry.DataTextField = "country_name";
                ddcountry.DataBind();
                ddcountry.Items.Insert(0, "Select country");
                clear();
            }
        }
        catch (Exception ex)
        {
            Label1.Text = ex.Message;
        }
        finally
        {
            con.Close();
        }
    }

    protected void AddState()
    {
        try
        {
            if (ddcountry.SelectedValue == "")
                throw new Exception("Please select state");

            if (txtstate.Text == "")
                throw new Exception("Please Enter state");

            if (con.State != ConnectionState.Open)
                con.Open();

            string sql_query = "insert into state (state_name, country_id , status) values(@state_name, @country_id , @status)";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@state_name", txtstate.Text.ToString());
            cmd.Parameters.AddWithValue("@country_id", ddcountry.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@status", 1);
            if (cmd.ExecuteNonQuery() > 0)
                Label1.Text = "State added";
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
        AddState();
    }
    protected void clear()
    {
        ddcountry.SelectedIndex = 0;
        txtstate.Text = "";
    }
}