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
        CheckoutDataBind();
        if (Request.QueryString.HasKeys())
            RemoveCheckout();
    }

    protected void CheckoutDataBind()
    {
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql_query = "select * from service join checkout on service.service_id = checkout.service_id where checkout.status = 1 and user_id = @user_id";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@user_id", Session["user_id"].ToString());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0 && dt != null)
            {
                string col = "<div class='row'>";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    col += "<div class='col-md-4'><a href='./product-detail.aspx?val=" + dt.Rows[i]["service_id"] + "'><div class='product-item'><img src='https://www.bing.com/th?id=ORMS.7408173e945696e2aad1ff6b3db8486c&pid=Wdp&w=612&h=304&qlt=90&c=1&rs=1&dpr=1&p=0' alt=''><div class='down-content'><h4>" + dt.Rows[i]["title"].ToString() + "</h4><h6>RS. " + dt.Rows[i]["cost"].ToString() + "</h6><p>" + dt.Rows[i]["description"] + "</p><a href='./checkout.aspx?val=" + dt.Rows[i]["service_id"] + "'>Remove</a><span>Reviews (20)</span></div></div></a></div>";
                }
                col += "</div>";
                product.InnerHtml = col;

            }
            else
            {
                Label1.Text = "You don't have chackout";

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

    protected void RemoveCheckout()
    {
        try
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            string sql_query = "update checkout set status = @status where service_id = @service_id and user_id = @user_id";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@service_id", Request.QueryString["val"].ToString());
            cmd.Parameters.AddWithValue("@user_id", Session["user_id"].ToString());
            cmd.Parameters.AddWithValue("@status", 0);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Response.Redirect("./checkout.aspx",false);
            }
        }
        catch (Exception ex)
        {
            Label1.Text = ex.Message;
            Label1.ForeColor = System.Drawing.Color.Red;

        }
        finally
        {
            con.Close();
        }
    }

}