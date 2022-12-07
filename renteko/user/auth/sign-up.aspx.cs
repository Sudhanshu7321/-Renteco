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
public partial class user_Default2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
      try
        {
            if (!IsPostBack)
            {
               // DATABindCountry();
            }

        }
        catch (Exception ex)
        {

        }
    }
    /*
    protected void DATABindCountry()
    {
        try
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql_query = "select country_name , country_id from country where status = 1 ";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0 && dt != null)
            {
                DropDownList2.DataSource = dt;
                DropDownList2.DataValueField = "country_id";
                DropDownList2.DataTextField = "country_name";
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, "select country");
            }
            else
            {
                DropDownList2.DataSource = dt;
                DropDownList2.DataValueField = "country_id";
                DropDownList2.DataTextField = "country_name";
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, "select country");
            }


        }
        catch (Exception ex)
        {

        }

    }

    protected void DATABindState()
    {


        try
        {
            int Country_id;
            if (DropDownList2.SelectedIndex == 0)
            {
                Country_id = 0;
            }
            else
            {
                Country_id = Convert.ToInt32(DropDownList2.SelectedValue);
            }
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql_query = "select state_name , state_id from state where status = 1 and country_id = @country_id ";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@country_id", Country_id);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0 && dt != null)
            {
                DropDownList3.DataSource = dt;
                DropDownList3.DataValueField = "state_id";
                DropDownList3.DataTextField = "state_name";
                DropDownList3.DataBind();
                DropDownList3.Items.Insert(0, "Select state");
            }
            else
            {
                DropDownList3.DataSource = dt;
                DropDownList3.DataValueField = "state_id";
                DropDownList3.DataTextField = "state_name";
                DropDownList3.DataBind();
                DropDownList3.Items.Insert(0, "Select state");
            }


        }
        catch (Exception ex)
        {

        }

    }


    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        DATABindState();
    }

    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataBindDistrict();
    }

    protected void DataBindDistrict()
    {
        try
        {

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql_query = "select * from district where status = 1 and state_id = @state_id ";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@state_id", DropDownList3.SelectedIndex.ToString());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0 && dt != null)
            {
                DropDownList4.DataSource = dt;
                DropDownList4.DataValueField = "district_id";
                DropDownList4.DataTextField = "district_name";
                DropDownList4.DataBind();
                DropDownList4.Items.Insert(0, "Select district");
            }
            else
            {
                DropDownList4.DataSource = dt;
                DropDownList4.DataValueField = "district_id";
                DropDownList4.DataTextField = "district_name";
                DropDownList4.DataBind();
                DropDownList4.Items.Insert(0, "Select district");
            }


        }
        catch (Exception ex)
        {

        }
    }

    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataBindCity();
    }

    protected void DataBindCity()
    {
        try
        {

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql_query = "select * from city where status = 1 and district_id = @district_id ";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@district_id", DropDownList4.SelectedIndex.ToString());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0 && dt != null)
            {
                DropDownList5.DataSource = dt;
                DropDownList5.DataValueField = "city_id";
                DropDownList5.DataTextField = "city_name";
                DropDownList5.DataBind();
                DropDownList5.Items.Insert(0, "Select city");
            }
            else
            {
                DropDownList5.DataSource = dt;
                DropDownList5.DataValueField = "city_id";
                DropDownList5.DataTextField = "city_name";
                DropDownList5.DataBind();
                DropDownList5.Items.Insert(0, "Select city");
            }


        }
        catch (Exception ex)
        {

        }
    }

    protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataBindLocality();
    }

    protected void DataBindLocality()
    {
        try
        {

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql_query = "select * from locality where status = 1 and city_id = @city_id ";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@city_id", DropDownList5.SelectedIndex.ToString());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0 && dt != null)
            {
                DropDownList6.DataSource = dt;
                DropDownList6.DataValueField = "locality_id";
                DropDownList6.DataTextField = "locality_name";
                DropDownList6.DataBind();
                DropDownList6.Items.Insert(0, "Select locality");
            }
            else
            {
                DropDownList6.DataSource = dt;
                DropDownList6.DataValueField = "locality_id";
                DropDownList6.DataTextField = "locality_name";
                DropDownList6.DataBind();
                DropDownList6.Items.Insert(0, "Select locality");
            }


        }
        catch (Exception ex)
        {

        }
    }

    protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataBindPincode();
    }

    protected void DataBindPincode()
    {
        try
        {

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql_query = "select * from pincode where status = 1 and district_id = @district_id ";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@district_id", DropDownList4.SelectedIndex.ToString());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0 && dt != null)
            {
                DropDownList7.DataSource = dt;
                DropDownList7.DataValueField = "pincode_id";
                DropDownList7.DataTextField = "pincode";
                DropDownList7.DataBind();
                DropDownList7.Items.Insert(0, "Select pincode");
            }
            else
            {
                DropDownList7.DataSource = dt;
                DropDownList7.DataValueField = "pincode_id";
                DropDownList7.DataTextField = "pincode";
                DropDownList7.DataBind();
                DropDownList7.Items.Insert(0, "Select pincode");
            }


        }
        catch (Exception ex)
        {

        }
    }
    */
    protected void AddUser()
    {
        try
        {
            string ImagePath = "";
            string file_name1 = "";
            if (TextBox1.Text.ToString() == "")
                throw new Exception("Please Enter Name");

            if (TextBox2.Text.ToString() == "")
                throw new Exception("Please Enter Email Id");

            if (TextBox3.Text.ToString() == "")
                throw new Exception("Please Enter Mobile Number");

            if (TextBox4.Text.ToString() == "")
                throw new Exception("Please Enter Password");


            if (TextBox6.Text.ToString() == "")
                throw new Exception("Please Enter User Name");


            if (DropDownList1.SelectedValue.Trim() == "Gender")
                throw new Exception("Please Select Gender");

            if (CheckBox1.Checked == false)
                throw new Exception("Please accept Terms and Conditions");

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
                        ImagePath = "/assets/profile/" + file_name1;
                    else
                        throw new Exception("Profile pictrue must be in jpg formate");
                }
                else
                {
                    throw new Exception("Profile size must be greater than 100kb");

                }

            }
            else
            {
                throw new Exception("Please select Profile Picture");

            }

/*
            if (DropDownList2.SelectedValue.Trim() == "select country")
                throw new Exception("Please Select Country");

            if (DropDownList3.SelectedValue.Trim() == "select state")
                throw new Exception("Please Select State");

            if (DropDownList4.SelectedValue.Trim() == "select district")
                throw new Exception("Please Select District");

            if (DropDownList5.SelectedValue.Trim() == "select city")
                throw new Exception("Please Select Country");

            if (DropDownList6.SelectedValue.Trim() == "select locality")
                throw new Exception("Please Select Locality");

            if (DropDownList7.SelectedValue.Trim() == "select pincode")
                throw new Exception("Please Select Pincode");*/

            Password enc = new Password();
            string password = enc.EncryptPlainTextToCipherText(TextBox4.Text.Trim(), TextBox2.Text.Trim());

            if (con.State == ConnectionState.Closed)
                con.Open();

            string sql_query = "insert into users(name,user_name, email_id, mobile_no, password, gender, date_time, status, image_path) values(@name, @user_name, @email_id, @mobile_no,@password, @gender, @time_date, @status, @image_path)";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@name", TextBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@email_id", TextBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@user_name", TextBox6.Text.ToString());
            cmd.Parameters.AddWithValue("@mobile_no", TextBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@gender", DropDownList1.SelectedValue);
            cmd.Parameters.AddWithValue("@time_date", System.DateTime.UtcNow.ToString("MM/dd/yyyy"));
        /*    cmd.Parameters.AddWithValue("@country_id", DropDownList2.SelectedIndex);
            cmd.Parameters.AddWithValue("@state_id", DropDownList3.SelectedIndex);
            cmd.Parameters.AddWithValue("@district_id", DropDownList4.SelectedIndex);
            cmd.Parameters.AddWithValue("@city_id", DropDownList5.SelectedIndex);
            cmd.Parameters.AddWithValue("@locality_id", DropDownList6.SelectedIndex);
            cmd.Parameters.AddWithValue("@pincode_id", DropDownList7.SelectedIndex);*/
            cmd.Parameters.AddWithValue("@status", 1);
            cmd.Parameters.AddWithValue("@image_path", ImagePath);
            if (cmd.ExecuteNonQuery() > 0)
            {
                FileUpload1.SaveAs(Server.MapPath("../assets/profile/") + file_name1);
                Label1.Text = "Sign Up Done";
                Label1.ForeColor = System.Drawing.Color.Green;
                clear();
                    

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

    protected void Button1_Click(object sender, EventArgs e)
    {
        AddUser();
    }
    protected void clear()
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        DropDownList1.SelectedIndex= 0;
    }
}