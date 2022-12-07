using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Add_Click(object sender, EventArgs e)
    {

        try
        {
            if (Question.Text.Trim() == "")
            {
                throw new Exception("Please enter question");
            }
            if (Answer.Text.Trim() == "")
            {
                throw new Exception("Please enter answer");

            }
            else if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql_query = "insert into faq (question, answer, status) values (@question , @answer, 1)"; 
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@question", Question.Text.Trim());
            cmd.Parameters.AddWithValue("@answer", Answer.Text.Trim());
           int i = cmd.ExecuteNonQuery();
            if(i >0)
            {
                Label2.Text = "FAQ Added";

            }
            else
            {
                Label2.Text = "Failed";

            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            lblMassage.Text = ex.Message;
            Label2.ForeColor = System.Drawing.Color.Red;
        }
        finally
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}