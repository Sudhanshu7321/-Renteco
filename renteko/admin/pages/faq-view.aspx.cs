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
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
        AdminDataBind();
    }
    protected void AdminDataBind()
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }

        string sql_query = "select * from faq where status = 1";
        SqlCommand cmd = new SqlCommand(sql_query, con);
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0 && dt != null)
        {
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

    }

    protected void GridView1_RowCommand(object sender, EventArgs e)
    {
        try
        {

        /*    if (e.CommandName == "CmdDelete")
            {
                string faq_id = e.CommandArgument.ToString().Trim();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string str = "delete from faq where faq_id = '" + faq_id + "'";
                sqlCommand cmd = new sqlCommand(str, con);
                int i = cmd.ExecuteNonQuery();
                if(i> 0)
                {
                }*/
            }
            
        catch(Exception ex)
        {

        }
    }
}