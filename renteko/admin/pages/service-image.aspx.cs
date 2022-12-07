using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

public partial class admin_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
       if(!IsCallback)
        {
            ServiceImage();
        }
    }

    protected void ServiceImage()
    {

        if (con.State != ConnectionState.Open)
        {
            con.Open();
        }

        string sql_query = "select * from service_image where service_id = @service_id";
        SqlCommand cmd = new SqlCommand(sql_query, con);
        cmd.Parameters.AddWithValue("service_id", Request.QueryString["val"].ToString());
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0 && dt != null)
        {
            GridView1.DataSource = dt;
            GridView1.DataBind();
            Label2.Text = "";
        }
        else
        {
            GridView1.DataSource = dt;
            GridView1.DataBind();
            Label2.Text = "Upload Images";
        }
       
    }
    protected void ServiceImageAdd()
    {
        try
        {
            string file_name1, ImagePath = "";
            if (TextBox1.Text.Trim() == "")
                throw new Exception("Please Enter Image Name");

            if(FileUpload1.HasFile)
            {
                Guid gid;
                gid = Guid.NewGuid();
                file_name1 = gid + FileUpload1.FileName;
                int file_size = FileUpload1.PostedFile.ContentLength;
                string file_extension = Path.GetExtension(FileUpload1.PostedFile.FileName);
                if (file_size > 100)
                {
                    if (file_extension == ".jpg")
                        ImagePath = "../assets/service/" + file_name1;
                    else
                        throw new Exception("Image must be in jpg formate");
                }
                else
                {
                    throw new Exception("Image size must be greater than 100kb");
                }
            }
            else
            {
                throw new Exception("Please Select Image");
            }
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql_query = "insert into service_image (service_id,image_name,image_path,status) values (@service_id,@image_name,@image_path,@status)";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@service_id", Request.QueryString["val"].ToString());
             cmd.Parameters.AddWithValue("@image_name",TextBox1.Text.ToString());
             cmd.Parameters.AddWithValue("@image_path",ImagePath);
            cmd.Parameters.AddWithValue("@status",1);
            if(cmd.ExecuteNonQuery() > 0)
            {
                FileUpload1.SaveAs(Server.MapPath("../assets/service/") + file_name1);
                Label1.Text = "Image Uploaded";
                ServiceImage();
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

    protected void Button1_Click(object sender, EventArgs e)
    {
        ServiceImageAdd();
    }
}