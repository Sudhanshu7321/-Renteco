using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class admin_Default : System.Web.UI.Page
{
    
   SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        offerDataBind();

    }
    protected void offerDataBind()
    {
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql_query = "select * from offer where status = 1  and  service_provider_id= @service_provider_id order by offer_id desc";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@service_provider_id", Session["service_provider_id"].ToString());
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
                Label2.Text = "Offer Not found Please Add.";
                Label2.ForeColor = System.Drawing.Color.Red;

            }
        }
        catch (Exception ex)
        {
            Label1.Text = ex.Message;
        }
        finally
        {
            con.Close();
        }
    }


    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdedit")
            Response.Redirect("./offer-edit.aspx?val="+ e.CommandArgument.ToString()+ "&a=e", false);
    }
}