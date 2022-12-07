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
            DATABindServiceDropdown();
        }

        if (Request.QueryString.HasKeys())
        {
            Label3.Value = Request.QueryString["val"].ToString();
            Button1.Text = Label2.Text = "Edit ";
            if (!IsPostBack)
            {
                DataBindOffer();         }
        }
        else
        {
            Button1.Text = Label2.Text = "Add ";
        }
    }

    protected void DATABindServiceDropdown()
    {
        try
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql_query = "select * from service where service_provider_id = @service_provider_id";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@status", 1);
            cmd.Parameters.AddWithValue("@service_provider_id", Session["Service_provider_id"].ToString());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0 && dt != null)
            {
                ddservice.DataSource = dt;
                ddservice.DataValueField = "service_id";
                ddservice.DataTextField = "title";
                ddservice.DataBind();
                ddservice.Items.Insert(0, "Select Service");
            }
            else
            {
                ddservice.DataSource = dt;
                ddservice.DataValueField = "service_id";
                ddservice.DataTextField = "title";
                ddservice.DataBind();
                ddservice.Items.Insert(0, "Select Service");
            }


        }
        catch (Exception ex)
        {

        }


    }

    protected void DataBindOffer()
    {
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql_query = "select * from offer where status = 1 and offer_id ="+Label3.Value.Trim();
            SqlCommand cmd = new SqlCommand(sql_query, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0 && dt != null)
            {
                texttitle.Text = dt.Rows[0]["title"].ToString();
                txtdescription.Text = dt.Rows[0]["description"].ToString();
                txtstarting_date.Text = dt.Rows[0]["starting_date"].ToString();
               txtexpire_date.Text = dt.Rows[0]["expire_date"].ToString();

            }
            else
            {
            }
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

    protected void Addoffer()
    {
        try
        {
            if (ddservice.SelectedItem.ToString() == "Select Service")
                throw new Exception("Please Select Service");
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql_query = "insert into offer(service_provider_id,title,description,date_time,service_id,expire_date,starting_date,status) values(@service_provider_id,@title,@description,@date_time,@service_id,@expire_date,@starting_date,@status)";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@service_provider_id", Session["Service_provider_id"].ToString());
            cmd.Parameters.AddWithValue("@title",texttitle.Text.ToString());
            cmd.Parameters.AddWithValue("@description", txtdescription.Text.Trim());
            cmd.Parameters.AddWithValue("@date_time", System.DateTime.UtcNow.ToString("MM/dd/yyyy"));
            cmd.Parameters.AddWithValue("@service_id", ddservice.SelectedValue);
            cmd.Parameters.AddWithValue("@status", 1);
            cmd.Parameters.AddWithValue("@starting_date", txtstarting_date.Text.Trim());
            cmd.Parameters.AddWithValue("@expire_date", txtexpire_date.Text.Trim());

            if (cmd.ExecuteNonQuery() > 0)
            {
                
                Label1.Text = "offer added sucessfully";
                Label1.ForeColor = System.Drawing.Color.Green;
                clear();

            }
            else
            {
                Label1.Text = "offer not added";
                Label1.ForeColor = System.Drawing.Color.Red;

            }
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

    protected void Updateoffer()
    {
        try
        {
            if (ddservice.SelectedItem.ToString() == "Select Service")
                throw new Exception("Please Select Service");
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql_query = "update offer set service_provider_id = @service_provider_id,title = @title, description = @description, date_time = @date_time, service_id = @service_id,starting_date = @starting_date,expire_date= @expire_date ";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@service_provider_id", Session["Service_provider_id"].ToString());
            cmd.Parameters.AddWithValue("@title", texttitle.Text.ToString());
            cmd.Parameters.AddWithValue("@description", txtdescription.Text.Trim());
            cmd.Parameters.AddWithValue("@date_time", System.DateTime.UtcNow.ToString("MM/dd/yyyy"));
            cmd.Parameters.AddWithValue("@service_id", ddservice.SelectedValue);
            cmd.Parameters.AddWithValue("@status", 1);
            cmd.Parameters.AddWithValue("@starting_date", txtstarting_date.Text.Trim());
            cmd.Parameters.AddWithValue("@expire_date", txtexpire_date.Text.Trim());

            if (cmd.ExecuteNonQuery() > 0)
            {

                Label1.Text = "offer Edit sucessfully";
                Label1.ForeColor = System.Drawing.Color.Green;
                clear();

            }
            else
            {
                Label1.Text = "offer not Edit";
                Label1.ForeColor = System.Drawing.Color.Red;

            }
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

    protected void Option()
    {
        if (Request.QueryString.HasKeys())
            Updateoffer();
        else
            Addoffer();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Option();
    }


    

    protected void clear()
    {
        texttitle.Text = "";
        ddservice.SelectedIndex = 0;
        txtdescription.Text = "";
        txtexpire_date.Text = "";
        txtstarting_date.Text = "";
    }


}