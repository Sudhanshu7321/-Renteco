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
                Label5.Text = dt.Rows[0]["category_name"].ToString();
                Label6.Text = dt.Rows[0]["sub_category_name"].ToString();
                if (dt.Rows[0]["status"].ToString() == "False")
                {
                    btnaction.CssClass = "btn btn-danger";
                    btnaction.Text = "Pending";
                }
                else
                {
                    btnaction.Text = "Approved";
                    btnaction.CssClass = "btn btn-success";
                }

                ServiceImageDetailsDataBind();
            }
            else
            {
                Label1.Text = dt.Rows[0]["title"].ToString();
                Label2.Text = dt.Rows[0]["description"].ToString();
                Label3.Text = dt.Rows[0]["cost"].ToString();
                Label4.Text = dt.Rows[0]["location"].ToString();
               
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

    protected void option_click(object sender, EventArgs e)
    {
     
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            if (btnaction.Text == "Pending")
            {
                string sql_query = "update service set status = @status where service_id = @service_id";
                SqlCommand cmd = new SqlCommand(sql_query, con);
                cmd.Parameters.AddWithValue("@status", 1);
                cmd.Parameters.AddWithValue("@service_id", Request.QueryString["val"].Trim());
                if (cmd.ExecuteNonQuery() > 0)
                    Response.Redirect("./service-adm-view.aspx?val=" + Request.QueryString["val"],true);

            }
            else
            {
                string sql_query = "update service set status = @status where service_id = @service_id";
                SqlCommand cmd = new SqlCommand(sql_query, con);
                cmd.Parameters.AddWithValue("@status", 0);
                cmd.Parameters.AddWithValue("@service_id", Request.QueryString["val"].Trim());
                if (cmd.ExecuteNonQuery() > 0)
                    Response.Redirect("./service-adm-view.aspx?val=" + Request.QueryString["val"], true);
            }
          

        }
        catch (Exception ex)
        {

        }
    }
    protected void btn_approve_click(object sender, EventArgs e)
    {

    }
    protected void ServiceImageDetailsDataBind()
    { 
        try
        {
            string  imgslider = "";

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql_query = "select * from service_image where service_id = @service_id";

            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@service_id", Request.QueryString["val"].ToString());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0 && dt != null)
            {
                imgslider = "<div id='carouselExampleControls'  class='carousel slide' data-bs-ride='carousel'><div class='carousel-inner'>";
                for(int i=0;i< dt.Rows.Count;i++)
                {
                    imgslider += "<div class='carousel-item active'><img src= '" + dt.Rows[i]["image_path"].ToString() + "' class='d-block w-100' alt='abccc'> </div> <div class='carousel-caption d-none d-md-block'><h5>"+ dt.Rows[i]["image_name"].ToString() + "</h5></div>";
                }
               
                imgslider += "</div><button class='carousel-control-prev' type='button' data-bs-target='#carouselExampleControls' data-bs-slide='prev'><span class='carousel-control-prev-icon' aria-hidden='true'></span><span class='visually-hidden'>Previous</span></button><button class='carousel-control-next' type='button' data-bs-target='#carouselExampleControls' data-bs-slide='next'><span class='carousel-control-next-icon' aria-hidden='true'></span><span class='visually-hidden'>Next</span></button></div>";

                slider.InnerHtml = imgslider;
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