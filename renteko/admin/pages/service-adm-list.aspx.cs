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
       if(!IsPostBack)
        { }

        if (Request.QueryString.HasKeys())
        {
            where.Value = " and service_provider_id ="+ Request.QueryString["val"];
        }
        else
        {
            where.Value = " ";
            where.Value = string.Empty;
        }
    }
    protected void AdminDataBind()
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        string sql_query = "select * from service where status != @status"+where.Value.ToString()+" ORDER BY service_id DESC";
        // string sql_query = "select * from service " + where.Text.Trim() + " ORDER BY service_id DESC";
        SqlCommand cmd = new SqlCommand(sql_query, con);
        cmd.Parameters.AddWithValue("@status", DropDownList1.SelectedValue.Trim());
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0 && dt != null)
        {
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        else
        {
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if(DropDownList1.SelectedIndex.ToString()=="0")
            Label1.Text = "Select Pending or Approved";
        else
        {
            Label1.Text = "";
            AdminDataBind();

        }
    }


    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "cmdview")
            {
                string service_id = e.CommandArgument.ToString();

                Response.Redirect("service-adm-view.aspx?val=" + service_id + "", false);
            }
        }
        catch (Exception ex)
        {
            Label1.Text = ex.Message;

        }
    }
}