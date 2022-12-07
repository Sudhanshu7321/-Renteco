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
        ReserveConfirm();
        Reserve();
    }

    protected void Reserve()
    {
        try
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql_query = "select * from  service join orders on service.service_id = orders.service_id where  user_id = @user_id and orders.status = @status order by order_id desc";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@user_id", Session["user_id"].ToString());
            cmd.Parameters.AddWithValue("@status", 0);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            string div = "";
            string div2 = "";
            if (dt.Rows.Count > 0 && dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    div = "<div class='row shadow mb-1 p-3'><div class='col-md-4'><img  src= 'https://www.bing.com/th?id=ORMS.7408173e945696e2aad1ff6b3db8486c&pid=Wdp&w=612&h=304&qlt=90&c=1&rs=1&dpr=1&p=0' class='img-fluid' alt='abccc'></div><div class='col-md-7'>" + dt.Rows[i]["title"].ToString() + "<a class='btn btn-success' href='./order.aspx?val="+dt.Rows[i]["service_id"].ToString() + "'>Confirm Reversion</a></div></div>";

                    div2 += div;
                }

              
                divpending.InnerHtml = div2;
            }
            else
            {

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

    protected void ReserveConfirm()
    {
        try
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql_query = "select * from orders where status = @status and user_id = @user_id ";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@user_id", Session["user_id"].ToString());
            cmd.Parameters.AddWithValue("@status", 1);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            string div = "";
            string div2 = "";
            if (dt.Rows.Count > 0 && dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    div = "<div class='row shadow mb-1 p-3'><div class='col-md-4'><img  src= 'https://www.bing.com/th?id=ORMS.7408173e945696e2aad1ff6b3db8486c&pid=Wdp&w=612&h=304&qlt=90&c=1&rs=1&dpr=1&p=0' class='img-fluid' alt='abccc'></div><div class='col-md-7'>" + dt.Rows[i]["doe"].ToString() + "  </div></div>";

                    div2 += div;
                }


                divconfirm.InnerHtml = div2;
            }
            else
            {

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


    protected void btnconfirm_Click(object sender, EventArgs e)
    {
    }
}