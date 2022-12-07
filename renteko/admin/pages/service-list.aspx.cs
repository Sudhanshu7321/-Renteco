using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
public partial class admin_Default2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        BindDataService();
    }

    protected void BindDataService()
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }

        string sql_query = "select title,description,service_id,cost,category_id,sub_category_id,location,date_time,case when status=0 then 'Pending' else 'Approved' end as status,service_provider_id from service where service_provider_id = @service_provider_id";
        SqlCommand cmd = new SqlCommand(sql_query, con);
        cmd.Parameters.AddWithValue("@service_provider_id",Session["service_provider_id"].ToString());
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
            Label1.Text = "Add service";
        }

    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "cmdimage")
            {
                string service_id = e.CommandArgument.ToString();

                Response.Redirect("service-image.aspx?val=" + service_id + "", false);
            }
            if (e.CommandName == "cmdview")
            {
                string service_id = e.CommandArgument.ToString();

                Response.Redirect("service-add.aspx?val=" + service_id + "", false);
            }
            if (e.CommandName == "cmddetails")
            {
                string service_id = e.CommandArgument.ToString();

                Response.Redirect("service-view.aspx?val=" + service_id + "", false);
            }


        }
        catch (Exception ex)
        {
            Label1.Text = ex.Message;

        }
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                string status = Convert.ToString(DataBinder.Eval(e.Row.DataItem, "status"));
                if(status == "Approved")
                    {
                    //     e.Row.BackColor = System.Drawing.Color.Green;
                    //  e.Row.Attributes["style"] = "background-color: #28b779";
                    //  (e.Row.FindControl("lblstatus") as Label).BackColor = System.Drawing.Color.Green;
                    (e.Row.FindControl("lblstatus") as Label).ForeColor = System.Drawing.Color.Green;

                }
                else
                {
                    //       e.Row.BackColor = System.Drawing.Color.Red;
                    //  e.Row.Attributes["style"] = "background-color: #da5554";
                    //   (e.Row.FindControl("lblstatus") as Label).BackColor = System.Drawing.Color.Red;
                    (e.Row.FindControl("lblstatus") as Label).ForeColor = System.Drawing.Color.Red;
                }
            }
        }
        catch(Exception ex)
        {

        }
        finally
        {

        }
    }
}