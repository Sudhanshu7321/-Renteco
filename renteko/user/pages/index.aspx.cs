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
        LatestProduct();
    }

    protected void LatestProduct()
    {
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql_query = "select top 6 * from service where status != @status ORDER BY service_id DESC";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@status", 0);
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

   protected void Rating(string service_id)
    {
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql_query = "select rating  from feedback where service_id = @service_id";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@service_id", service_id);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            int rating = 0;
           if (adp.Fill(dt) >0 )
              rating =  dt.Rows.Count;
         else
                rating = 0;

        }
        catch (Exception ex)
        {

        }
        finally
        {
            con.Close();
        }
    }
}
