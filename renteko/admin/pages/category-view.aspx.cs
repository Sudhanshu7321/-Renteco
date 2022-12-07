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
        DataBindCategory();
        if (!IsPostBack)
        {
            DATABindCategoryDropdown();
        }
    }

    protected void DataBindCategory()
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }

        string sql_query = "select category_name from category";
        SqlCommand cmd = new SqlCommand(sql_query, con);
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0 && dt != null)
        {
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

    }

    protected void DATABindCategoryDropdown()
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
                DropDownCategory.Items.Insert(0, "Select Category");
            }
            else
            {
                DropDownCategory.DataSource = dt;
                DropDownCategory.DataValueField = "category_id";
                DropDownCategory.DataTextField = "category_name";
                DropDownCategory.DataBind();
                DropDownCategory.Items.Insert(0, "Select Category");
            }


        }
        catch (Exception ex)
        {

        }

    }

    protected void DropDownSubCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataBindSubCategory();
    }

    protected void DataBindSubCategory()
    {
        try
        {

        if (DropDownCategory.SelectedItem.ToString()== "Select Category")
        {
            throw new Exception("Please Select Category");
        }

            if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }

        string sql_query = "select Sub_category_name from sub_category where  category_id = @category_id";
        SqlCommand cmd = new SqlCommand(sql_query, con);
        cmd.Parameters.AddWithValue("@category_id", DropDownCategory.SelectedValue.ToString());
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0 && dt != null)
        {
            GridView2.DataSource = dt;
            GridView2.DataBind();
                lblmsg.Text = "";

            }
            else
        {
            GridView2.DataSource = dt;
            GridView2.DataBind();
                lblmsg.Text = "No Sub-Category Found";

        }

        }
        catch(Exception ex)
        {
        //    Label1.Text = ex.Message;
        }
        }
}
