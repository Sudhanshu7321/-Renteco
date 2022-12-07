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

    protected void ServiceProviderDataBind()
    {
        try
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql_query = "select * from service_provider where status != @status";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@status", DropDownList1.SelectedValue.Trim());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0 && dt != null)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
                Label3.Text = "";

            }
            else
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
                Label3.Text = "No Record Found";
            }
        }
        catch (Exception ex)
        {
            Label2.Text = ex.Message;
        }
        finally
        {
            con.Close();
        }

      


    }

    protected void ViewDeatils(object sender, EventArgs e)
    {
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            string a = "";
            if (DropDownList1.SelectedValue.ToString() == "0")
                a = "a";
            else
               a = "p";

            if (e.CommandName == "cmdmore")
            {
                string service_provider_id = e.CommandArgument.ToString();
                Response.Redirect("service-provider-view-details.aspx?val=" + service_provider_id + "&a="+a, false);
            }


        }
        catch (Exception ex)
        {

        }
    }


    protected void Button3_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex == 0)
        {
            Label2.Text = "Select Approve / Pending";

        }
        else
        {
            Label2.Text = "";
            ServiceProviderDataBind();

        }
    }
}