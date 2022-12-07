using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class user_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);




    protected void Page_Load(object sender, EventArgs e)
    {
        if (System.Web.HttpContext.Current.Session["user_id"] == null)
        {
            Response.Redirect("../auth/sign-in.aspx?val=" + HiddenField1.Value.Trim());
        }
        ServiceDetailsDataBind();
        UserDataBind();
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
                Label8.Text = dt.Rows[0]["cost"].ToString();
                Label9.Text = Convert.ToString((10 * Convert.ToInt64(Label8.Text.ToString())) / 100);
                Label8.Text = dt.Rows[0]["cost"].ToString();
                Label10.Text = Label9.Text.ToString();

                ServiceImageDetailsDataBind();
              //  checkoutDataBind();
            }
            else
            {
                Label1.Text = dt.Rows[0]["title"].ToString();
                Label2.Text = dt.Rows[0]["description"].ToString();
                Label3.Text = dt.Rows[0]["cost"].ToString();
                Label4.Text = dt.Rows[0]["location"].ToString();
                Label5.Text = dt.Rows[0]["category_name"].ToString();
                Label6.Text = dt.Rows[0]["sub_category_name"].ToString();
                Label8.Text = dt.Rows[0]["cost"].ToString();
                Label9.Text = Convert.ToString((10 * Convert.ToInt64( Label8.Text.ToString())) /100);


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

    protected void ServiceImageDetailsDataBind()
    {
        try
        {
            string imgslider = "";

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
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    imgslider += "<div class='carousel-item active'><img src= '../../admin/admin/" + dt.Rows[i]["image_path"].ToString() + "' class='d-block w-100' alt='abccc'> </div> <div class='carousel-caption d-none d-md-block'><h5>" + dt.Rows[i]["image_name"].ToString() + "</h5></div>";
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

    protected void UserDataBind()
    {

        try
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql_query = "SELECT name,email_id,mobile_no FROM users  where user_id = @user_id and status = @status";

            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@user_id", Session["user_id"].ToString());
            cmd.Parameters.AddWithValue("@status", 1);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0 && dt != null)
            {
                TextBox1.Text = dt.Rows[0]["name"].ToString();
                TextBox2.Text = dt.Rows[0]["email_id"].ToString();
                TextBox3.Text = dt.Rows[0]["mobile_no"].ToString();
               
            }
            else
            {
                TextBox1.Text = dt.Rows[0]["name"].ToString();
                TextBox2.Text = dt.Rows[0]["email_id"].ToString();
                TextBox3.Text = dt.Rows[0]["mobil_no"].ToString();


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

    protected void ConfirmOrder()
    {
        try
        {
            string ImagePath = "";
            string file_name1 = "";

            if (FileUpload1.HasFile)
            {
                Guid gid;
                gid = Guid.NewGuid();
                file_name1 = gid + FileUpload1.FileName;
                int file_size = FileUpload1.PostedFile.ContentLength;
                string file_extension = Path.GetExtension(FileUpload1.PostedFile.FileName);
                if (file_size > 100)
                {

                    if (file_extension == ".jpg")
                        ImagePath = "/assets/idProof/" + file_name1;
                    else
                        throw new Exception("Id Proof must be in jpg formate");
                }
                else
                {
                    throw new Exception("Id Proof size must be greater than 100kb");

                }

            }
            else
            {
                throw new Exception("Please selectId Proof");

            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql_query = "update orders set service_id = @service_id,user_id = @user_id,tra_id = @tra_id,tra_status = @tra_status,id_proof = @id_proof,name = @name,dob = @dob,gender = @gender,mobile_no_one = @mobile_no_one,mobile_no_two = @mobile_no_two,message = @message,adv_amount = @adv_amount,rest_amount = @rest_amount, status = @status_p where user_id = @user_id and service_id = @service_id and status = @status";

            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@service_id", Request.QueryString["val"].ToString() );
            cmd.Parameters.AddWithValue("@user_id", Session["user_id"].ToString());
            cmd.Parameters.AddWithValue("@tra_id", "Null");
            cmd.Parameters.AddWithValue("@tra_status", "init");
         //    cmd.Parameters.AddWithValue("@date_time", System.DateTime.UtcNow.ToString("MM/dd/yyyy"));
            cmd.Parameters.AddWithValue("@status_p",0);
            cmd.Parameters.AddWithValue("@status", 0);
            cmd.Parameters.AddWithValue("@id_proof", ImagePath);
            cmd.Parameters.AddWithValue("@name", TextBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@dob", TextBox5.Text.ToString());
            cmd.Parameters.AddWithValue("@gender", DropDownList1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@mobile_no_one", TextBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@mobile_no_two", TextBox4.Text.ToString());
            cmd.Parameters.AddWithValue("@message", TextBox6.Text.ToString());
            cmd.Parameters.AddWithValue("@adv_amount", Label9.Text.ToString());
            cmd.Parameters.AddWithValue("@rest_amount", Label8.Text.ToString());
            if (cmd.ExecuteNonQuery() > 0)
            {
                FileUpload1.SaveAs(Server.MapPath("../assets/idProof/") + file_name1);
              Response.Redirect("back/payrequest.aspx?val="+ Request.QueryString["val"].ToString(), false);
                //  Label1.Text = "Order done";
                // Label1.ForeColor = System.Drawing.Color.Green;


            }

        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }
        finally
        {

        }
    }




    protected void btnconfirm_Click(object sender, EventArgs e)
    {
        //   Response.Redirect("back/payrequest.aspx?val=" + Request.QueryString["val"].ToString(), false);

        ConfirmOrder();
    }
}