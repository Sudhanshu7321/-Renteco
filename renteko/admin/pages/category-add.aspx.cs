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
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void category_add()
    {
        try
        {
            if (category.Text.Trim() == "")
            {
                throw new Exception("Please enter Category");
            }
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql_query = "insert into category (category_name, status) values (@category_name , @status)";

            SqlCommand cmd = new SqlCommand(sql_query, con);

            cmd.Parameters.AddWithValue("@category_name", category.Text.Trim());
            cmd.Parameters.AddWithValue("@status", 1);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Label1.Text = "Category Added";
                Label1.ForeColor = System.Drawing.Color.Green;
                clear();
            }
            else
            {
                Label1.Text = "Failed";
                Label1.ForeColor = System.Drawing.Color.Red;
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
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        category_add();
    }
    protected void clear()
    {
        category.Text = "";
    }
}