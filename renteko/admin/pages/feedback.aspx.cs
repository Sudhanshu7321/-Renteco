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
            FeedbackDataBind();

        }
    }

    protected void Feedback()
    {
        try
        {
            if (txtname.Text.ToString() == "")
                throw new Exception("Please enter Name");

            if (textrollno.Text.ToString() == "")
                throw new Exception("Please enter Roll No");

            if (textfeedback.Text.ToString() == "")
                throw new Exception("Please enter Feedback");

            if (con.State == ConnectionState.Closed )
                con.Open();

            string sql_query = "insert into newfeedback(c_name,c_roll_no,feedback,rating,status,doe) values('"+ txtname.Text.Trim()+ "','"+textrollno.Text.Trim() + "','"+ textfeedback.Text.Trim() + "','5',1,'"+System.DateTime.UtcNow.AddMinutes(330)+"')";
            SqlCommand cmd = new SqlCommand(sql_query, con);
           int i = cmd.ExecuteNonQuery();
            if(i> 0)
            {
                lblmsg.Text = "Feedback Inserted";
                clear();
                FeedbackDataBind();
            }
        }
        catch(Exception ex)
        {
            lblmsg.Text = ex.Message;
        }
        finally
        {
            con.Close();
        }
    }

    protected void clear()
    {
        txtname.Text = "";
        textrollno.Text = "";
        textfeedback.Text = "";
    }

    protected void FeedbackDataBind()
    {
        if (con.State == ConnectionState.Closed)
            con.Open();

        string sql_query = "select * from newfeedback";
        SqlCommand cmd = new SqlCommand(sql_query, con);
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
            GridView1.DataSource = dt;
            GridView1.DataBind();
            lblerror.Text = "No Record Found";
        }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        Feedback();
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if(e.CommandName == "cmddelete")
            {
                string Roll_No = e.CommandArgument.ToString();
                if(con.State == ConnectionState.Closed)
                con.Open();

                string sql_query = "delete from newfeedback where c_roll_no = '" + Roll_No.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sql_query, con);
              int i =  cmd.ExecuteNonQuery();
                if (i > 0)
                    lblmsg.Text = "Record Deleted";
                FeedbackDataBind();
            }else if(e.CommandName == "cmdupdate")
            {
                string Roll_No = e.CommandArgument.ToString();

                Response.Redirect("feedback-update.aspx?val="+ Roll_No + "",false);
            }

            
        }
        catch(Exception ex)
        {
            lblmsg.Text = ex.Message;

        }
    }

}