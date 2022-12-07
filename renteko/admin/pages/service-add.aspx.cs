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
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString.HasKeys())
        {
            Label3.Text = Request.QueryString["val"].ToString();
            Button1.Text = Label2.Text = "Update ";
            if (!IsPostBack)
            {
                ServiceDataBind(Label3.Text.ToString());
            }
        }
        else
        {
            Button1.Text = Label2.Text = "Add ";
        }

        if (!IsPostBack)
        {
            DATABindCategory();
        }
    }

    protected void ServiceDataBind(string service_id)
    {
        try
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            string sql_query = "select * from service where service_id = @service_id";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@service_id", service_id.ToString());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0 && dt != null)
            {
                title.Text = dt.Rows[0]["title"].ToString();
                description.Text = dt.Rows[0]["description"].ToString();
                cost.Text = dt.Rows[0]["cost"].ToString();
                location.Text = dt.Rows[0]["location"].ToString(); 
         //   DropDownCategory.SelectedValue = dt.Rows[0]["category_id"].ToString();
            //   DropDownSubCategory.SelectedValue = dt.Rows[0]["sub_category_id"].ToString();

            }
        }
        catch(Exception ex)
        {

        }
        finally
        {
            con.Close();
        }
    }
   
    protected void DATABindCategory()
    {
        try
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql_query = "select * from category where status = 1";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0 && dt != null)
            {
                DropDownCategory.DataSource = dt;
                DropDownCategory.DataValueField = "category_id";
                DropDownCategory.DataTextField = "category_name";
                DropDownCategory.DataBind();
                DropDownCategory.Items.Insert(0, "Select");
            }
            else
            {
                DropDownCategory.DataSource = dt;
                DropDownCategory.DataValueField = "category_id";
                DropDownCategory.DataTextField = "category_name";
                DropDownCategory.DataBind();
                DropDownCategory.Items.Insert(0, "Select");
            }


        }
        catch (Exception ex)
        {

        }

    }

    protected void DATABindSubCategory()
    {
        try
        {
            int Category_id;
            if (DropDownCategory.SelectedIndex == 0)
            {
                Category_id = 0;
            }
            else
            {
                Category_id = Convert.ToInt32(DropDownCategory.SelectedValue);
            }
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql_query = "select * from sub_category where status = 1 and Category_id = @Category_id ";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@Category_id", Category_id);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0 && dt != null)
            {
                DropDownSubCategory.DataSource = dt;
                DropDownSubCategory.DataValueField = "sub_category_id";
                DropDownSubCategory.DataTextField = "sub_category_name";
                DropDownSubCategory.DataBind();
                DropDownSubCategory.Items.Insert(0, "Select");
            }
            else
            {
                DropDownSubCategory.DataSource = dt;
                DropDownSubCategory.DataValueField = "sub_category_id";
                DropDownSubCategory.DataTextField = "sub_category_name";
                DropDownSubCategory.DataBind();
                DropDownSubCategory.Items.Insert(0, "Select");
            
        }


        }
        catch (Exception ex)
        {

        }

    }

    protected void DropDownCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        DATABindSubCategory();
    }

    protected void option(string service_id)
    {
        if (Request.QueryString.HasKeys())
            service_update(Label3.Text.ToString());
        else
            service_add();
        }
    
    protected void service_add()
    {
       
        try
        {
            if (title.Text.Trim() == "")
            {
                throw new Exception("Please enter title");
            }
            if (description.Text.Trim() == "")
            {
                throw new Exception("Please enter description");
            }
            if (cost.Text.Trim() == "")
            {
                throw new Exception("Please enter cost");
            }
            if (location.Text.Trim() == "")
            {
                throw new Exception("Please enter location");

            }
            else if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql_query = "insert into service (title, description, cost, location, category_id, sub_category_id, service_provider_id, date_time, status) values (@title , @description,@cost,@location,@category_id,@sub_category_id,@service_provider_id,@date_time,@status)";

            SqlCommand cmd = new SqlCommand(sql_query, con);

            cmd.Parameters.AddWithValue("@title", title.Text.Trim());
            cmd.Parameters.AddWithValue("@description", description.Text.Trim());
            cmd.Parameters.AddWithValue("@cost", cost.Text.Trim());
            cmd.Parameters.AddWithValue("@location", location.Text.Trim());
            cmd.Parameters.AddWithValue("@category_id", DropDownCategory.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@sub_category_id", DropDownSubCategory.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@service_provider_id", Session["Service_provider_id"].ToString());
            cmd.Parameters.AddWithValue("@date_time", System.DateTime.UtcNow.ToString("MM/dd/yyyy"));
            cmd.Parameters.AddWithValue("@status",0);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Label1.Text = "Service Added";
                Label1.ForeColor = System.Drawing.Color.Green;
                clear();
            }
            else
            {
                Label1.Text = "Failed";
                Label1.ForeColor = System.Drawing.Color.Red;
                clear();

            }
        }
        catch (Exception ex)
        {
           Label1.Text = ex.Message;
            Label1.ForeColor = System.Drawing.Color.Red;

        }
        finally
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        
    }

    protected void service_update(string service_id)
    {
        try
        {
            if (title.Text.Trim() == "")
            {
                throw new Exception("Please enter title");
            }
            if (description.Text.Trim() == "")
            {
                throw new Exception("Please enter description");
            }
            if (cost.Text.Trim() == "")
            {
                throw new Exception("Please enter cost");
            }
            if (location.Text.Trim() == "")
            {
                throw new Exception("Please enter location");

            }
            else if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql_query = "update  service set title = @title, description = @description, cost = @cost, location = @location, category_id = @category_id, sub_category_id = @sub_category_id where service_id = @service_id";

            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@title", title.Text.Trim());
            cmd.Parameters.AddWithValue("@description", description.Text.Trim());
            cmd.Parameters.AddWithValue("@cost", cost.Text.Trim());
            cmd.Parameters.AddWithValue("@location", location.Text.Trim());
            cmd.Parameters.AddWithValue("@category_id", DropDownCategory.SelectedValue);
            cmd.Parameters.AddWithValue("@sub_category_id", DropDownSubCategory.SelectedValue);
            cmd.Parameters.AddWithValue("@service_id", service_id);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Label1.Text = "Service Update";
                Label1.ForeColor = System.Drawing.Color.Green;
                clear();
            }
            else
            {
                Label1.Text = "Failed";
                Label1.ForeColor = System.Drawing.Color.Red;
                clear();

            }
        }
        catch (Exception ex)
        {
            Label1.Text = ex.Message;
            Label1.ForeColor = System.Drawing.Color.Red;

        }
        finally
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }

    protected void clear()
    {
        title.Text = "";
        description.Text = "";
        cost.Text = "";
        location.Text = "";
        DropDownCategory.SelectedIndex = 0;
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        option(Label3.Text.ToString());
    }
}