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
        if (!IsPostBack)
        {
            DATABindCountryDropdown();
        }
    }

    protected void DATABindCountryDropdown()
    {
        try
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql_query = "select * from country where status = 1";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0 && dt != null)
            {
                ddCountryState.DataSource = dt;
                ddCountryState.DataValueField = "country_id";
                ddCountryState.DataTextField = "country_name";
                ddCountryState.DataBind();
                ddCountryState.Items.Insert(0, "Select country");
            }
            else
            {
                ddCountryState.DataSource = dt;
                ddCountryState.DataValueField = "country_id";
                ddCountryState.DataTextField = "country_name";
                ddCountryState.DataBind();
                ddCountryState.Items.Insert(0, "Select country");
            }


        }
        catch (Exception ex)
        {

        }

    }

    protected void ddCountryState_SelectedIndexChanged(object sender, EventArgs e)
    {
        StateDataBind();
    }
    protected void StateDataBind()
    {
        try
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql_query = "select * from state where country_id = @country and status = @status";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@country", ddCountryState.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@status", 1);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0 && dt != null)
            {
                GridView2.DataSource = dt;
                GridView2.DataBind();
                Label11.Text = "";

            }
            else
            {
                GridView2.DataSource = dt;
                GridView2.DataBind();
                Label11.Text = "State not found";
            }
        }
        catch (Exception ex)
        {
            //abel11.Text = ex.Message;
        }
        finally
        {
            con.Close();
        }
    }
}