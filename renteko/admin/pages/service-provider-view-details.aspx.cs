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
        ServiceProviderDetailsDataBind();

        if (Request.QueryString.HasKeys())
        if (Request.QueryString["a"].ToString() != "a")
            btnaction.Text = "Pending";
        else
            btnaction.Text = "Approved";

    }
    protected void ServiceProviderDetailsDataBind()
    {
        try
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql_query = "select * from service_provider join country on service_provider.country_id =  country.country_id join state on service_provider.state_id =  state.state_id join city on service_provider.city_id =  city.city_id join district on  service_provider.district_id =  district.district_id join locality on service_provider.locality_id =  locality.locality_id join pincode on service_provider.pincode_id =  pincode.pincode_id  where service_provider_id = @service_provider_id";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@service_provider_id", Request.QueryString["val"].ToString());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0 && dt != null)
            {
                // Name.Text = dt["name"].ToString();
                 Name.Text = dt.Rows[0]["name"].ToString();
                Email.Text = dt.Rows[0]["email_id"].ToString();
                phoneno.Text = dt.Rows[0]["mobile_no"].ToString();
                string url= ".."+dt.Rows[0]["image_path"].ToString();
                Image1.ImageUrl = url.Trim();
                Country.Text = dt.Rows[0]["country_name"].ToString();
                State.Text = dt.Rows[0]["state_name"].ToString();
                Distic.Text = dt.Rows[0]["district_name"].ToString();
                City.Text = dt.Rows[0]["city_name"].ToString();
                Locality.Text = dt.Rows[0]["locality_name"].ToString();
                Pincode.Text = dt.Rows[0]["pincode"].ToString();
                service_provider_id.Text = dt.Rows[0]["service_provider_id"].ToString();





                //  Name.Text = Convert.ToString(dt.Tables[0].Columns["Bname"]);

            }
        }
        catch (Exception ex)
        {
           // Label2.Text = ex.Message;
        }
        finally
        {
            con.Close();
        }




    }

    protected void option()
    {
        if (Request.QueryString.HasKeys())
            if (Request.QueryString["a"].ToString() != "a")
                Approve();
            else
                Pending();
    }

    protected void Approve()
    {
        try
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql_query = "update service_provider set status = @status where service_provider_id = @service_provider_id";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@service_provider_id", Request.QueryString["val"].Trim());
            cmd.Parameters.AddWithValue("@status", 1);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Redirect("./service-provider-list.aspx");
            }
            else
            {
             //   Label2.Text = "Failed";
             //   Label2.ForeColor = System.Drawing.Color.Red;

            }
        }
        catch (Exception ex)
        {
            // Label2.Text = ex.Message;
        }
        finally
        {
            con.Close();
        }


    }

    protected void Pending()
    {
        try
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql_query = "update service_provider set status = @status where service_provider_id = @service_provider_id";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@service_provider_id", Request.QueryString["val"].Trim());
            cmd.Parameters.AddWithValue("@status", 0);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Redirect("./service-provider-list.aspx");

            }
            else
            {
                //   Label2.Text = "Failed";
                //   Label2.ForeColor = System.Drawing.Color.Red;

            }
        }
        catch (Exception ex)
        {
            // Label2.Text = ex.Message;
        }
        finally
        {
            con.Close();
        }


    }

    protected void Approved_Click(object sender, EventArgs e)
    {
        option();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("./service-adm-list.aspx?val= " + service_provider_id.Text.Trim());
    }
}