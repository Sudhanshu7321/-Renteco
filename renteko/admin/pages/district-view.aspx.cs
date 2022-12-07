﻿using System;
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
                ddCountry.DataSource = dt;
                ddCountry.DataValueField = "country_id";
                ddCountry.DataTextField = "country_name";
                ddCountry.DataBind();
                ddCountry.Items.Insert(0, "Select country");
            }
            else
            {
                ddCountry.DataSource = dt;
                ddCountry.DataValueField = "country_id";
                ddCountry.DataTextField = "country_name";
                ddCountry.DataBind();
                ddCountry.Items.Insert(0, "Select country");
            }


        }
        catch (Exception ex)
        {

        }

    }

    protected void ddCountrydistic_SelectedIndexChanged(object sender, EventArgs e)
    {
        DATABindStateDropdown();
    }

    protected void DATABindStateDropdown()
    {
        try
        {
             if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql_query = "select * from state where country_id=@country and status = 1";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@country", ddCountry.SelectedValue.ToString());

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0 && dt != null)
            {
              ddState.DataSource = dt;
              ddState.DataValueField = "state_id";
              ddState.DataTextField = "state_name";
              ddState.DataBind();
              ddState.Items.Insert(0, "Select state");
            }
            else
            {
                ddState.DataSource = dt;
                ddState.DataValueField = "state_id";
                ddState.DataTextField = "state_name";
                ddState.DataBind();
                ddState.Items.Insert(0, "State not found");
            }


        }
        catch (Exception ex)
        {

        }

    }


    protected void ddstatedistic_SelectedIndexChanged(object sender, EventArgs e)
    {
        DistrictDataBind();
    }
    protected void DistrictDataBind()
    {
        try
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql_query = "select * from district where state_id = @state and status = @status";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@state", ddState.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@status", 1);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0 && dt != null)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
                Label1.Text = "";

            }
            else
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
                Label1.Text = "District not found";
            }
        }
        catch (Exception ex)
        {
        }
        finally
        {
            con.Close();
        }
    }
}