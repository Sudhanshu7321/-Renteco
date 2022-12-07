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
        if (!IsPostBack)
        {
            DATABindCategory();
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

    protected void sub_category_add()
    {
        try
        {
            if (DropDownCategory.SelectedItem.ToString() == "Select Category")
            {
                throw new Exception("Please Select Category");
            }

            if (subCategory.Text.Trim() == "")
            {
                throw new Exception("Please enter Sub-Category");
            }
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql_query = "insert into sub_category (category_id,sub_category_name, status) values (@category_id,@sub_category_name , @status)";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@category_id", DropDownCategory.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@sub_category_name", subCategory.Text.Trim());
            cmd.Parameters.AddWithValue("@status", 1);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Label1.Text = "Sub Category Added";
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        sub_category_add();
    }
    protected void clear()
    {
        subCategory.Text = "";
    }
}