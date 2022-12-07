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
        ServiceDetailsDataBind();
        FeedbackDetailsDataBind();
    }

    protected void ServiceDetailsDataBind()
    {
        try
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql_query = "SELECT * FROM service JOIN service_image ON service.service_id = service_image.service_id  JOIN category on category.category_id = service.category_id JOIN sub_category on sub_category.sub_category_id = service.sub_category_id where service.service_id = @service_id";

            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@service_id", Request.QueryString["val"].ToString());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0 && dt != null)
            {
                Label1.Text = dt.Rows[0]["title"].ToString();
                Label2.Text = dt.Rows[0]["description"].ToString();
                Label3.Text = dt.Rows[0]["cost"].ToString();
                Label4.Text = dt.Rows[0]["location"].ToString();
                GridView1.DataSource = dt;
                GridView1.DataBind();         
                 Label5.Text = dt.Rows[0]["category_name"].ToString();
                Label6.Text = dt.Rows[0]["sub_category_name"].ToString();



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

    protected void FeedbackDetailsDataBind()
    {
        try
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql_query = "SELECT * FROM feedback JOIN users ON feedback.user_id = users.user_id   where feedback.service_id = @service_id";

            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@service_id", Request.QueryString["val"].ToString());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0 && dt != null)
            {
                GridView2.DataSource = dt;
                GridView2.DataBind();
             
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
}