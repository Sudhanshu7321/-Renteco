using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class user_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label1.Text = "Result: All";
           Product("where status = 1 ORDER BY service_id DESC");
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
                DropDownCategory.Items.Insert(0, "Category");
            }
            else
            {
                DropDownCategory.DataSource = dt;
                DropDownCategory.DataValueField = "category_id";
                DropDownCategory.DataTextField = "category_name";
                DropDownCategory.DataBind();
                DropDownCategory.Items.Insert(0, "Category");
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
    protected void DropDownSubCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label1.Text = DropDownCategory.SelectedItem.ToString() + " > " + DropDownSubCategory.SelectedItem.ToString();
        Product("where status = 1 and category_id = "+DropDownCategory.SelectedIndex+" and sub_category_id = "+DropDownSubCategory.SelectedIndex+" ORDER BY service_id DESC");

    }


    protected void Product(string where)
    {
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql_query = "select top 6 * from service "+ where.Trim();
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@where", where.Trim());

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0 && dt != null)
            {
                string col = "<div class='row'>";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    col += "<div class='row shadow m-3 p-3'><div class='col-md-4'><a href='./product-detail.aspx?val=" + dt.Rows[i]["service_id"] + "'><div class='product-item'><img class='img-fluid' src='https://www.bing.com/th?id=ORMS.7408173e945696e2aad1ff6b3db8486c&pid=Wdp&w=612&h=304&qlt=90&c=1&rs=1&dpr=1&p=0' alt=''></div></a></div>" +
                        "<div class='col-md-4'><div class='down-content'><h4>" + dt.Rows[i]["title"].ToString() + "</h4><h6>RS. " + dt.Rows[i]["cost"].ToString() + "</h6><p>" + dt.Rows[i]["description"] + "</p><span>Reviews (20)</span></div> </div>" +
                        "</div>";
                }
                col += "</div>";
                product.InnerHtml = col;
                
            }
            else
            {
                Label1.Text = "Result Not Found";

                string col = "<div class='row'>";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    col += "<div class='col-md-4'><a href='./product-detail.aspx?val=" + dt.Rows[i]["service_id"] + "'><div class='product-item'><img src='https://www.bing.com/th?id=ORMS.7408173e945696e2aad1ff6b3db8486c&pid=Wdp&w=612&h=304&qlt=90&c=1&rs=1&dpr=1&p=0' alt=''><div class='down-content'><h4>" + dt.Rows[i]["title"].ToString() + "</h4><h6>RS. " + dt.Rows[i]["cost"].ToString() + "</h6><p>" + dt.Rows[i]["description"] + "</p><span>Reviews (20)</span></div></div></a></div>";
                }
                col += "</div>";
                product.InnerHtml = col;
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


    protected void btnsearch_Click(object sender, EventArgs e)
    {

        Label1.Text = "Result: " + txtsearch.Text.Trim();
        Product("where status = 1 and title like '"+txtsearch.Text.Trim()+"%' ORDER BY service_id DESC");
    }

    protected void sortby_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label1.Text = "Result: " +sortby.SelectedValue.Trim();

        if(sortby.SelectedValue.Trim() == "Price: Low to High")
            Product("where status = 1  ORDER BY cost ASC");
        else
            Product("where status = 1  ORDER By cost DESC");

    }
}