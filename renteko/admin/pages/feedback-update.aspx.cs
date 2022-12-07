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
        if(!IsPostBack)
        {
            string Roll_no = Request.QueryString["val"].ToString();
            Label1.Text = Roll_no;
            FeedbackDataBind(Roll_no);
        }
   

    }

    protected void FeedbackDataBind(string Roll)
    {
        if (con.State == ConnectionState.Closed)
            con.Open();

        string sql_query = "select * from newfeedback where c_roll_no = @c_roll_no";
        SqlCommand cmd = new SqlCommand(sql_query, con);
        cmd.Parameters.AddWithValue("@c_roll_no", Roll.ToString());
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0 && dt != null)
        {
            txtname.Text = dt.Rows[0]["c_name"].ToString();
            textfeedback.Text = dt.Rows[0]["feedback"].ToString(); 
        }
       
    }

    protected void FeedbackUpdate(string Roll)
    {
        if (con.State == ConnectionState.Closed)
            con.Open();

        string sql_query = "update newfeedback set c_name = @c_name ,feedback = @feedback where c_roll_no = @c_roll_no ";
        SqlCommand cmd = new SqlCommand(sql_query, con);
        cmd.Parameters.AddWithValue("@c_name", txtname.Text.ToString());
        cmd.Parameters.AddWithValue("@c_roll_no", Roll);
        cmd.Parameters.AddWithValue("@feedback", textfeedback.Text.ToString());
     int i =   cmd.ExecuteNonQuery();
        if(i > 0)
        {
            lblmsg.Text = "Update Succesfully";
        }


    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        FeedbackUpdate(Label1.Text.Trim());
    }
}