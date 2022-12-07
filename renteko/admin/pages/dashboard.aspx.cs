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
        AdminDataBind();
    }
    protected void AdminDataBind()
    {
        if(con.State == ConnectionState.Closed )
        {
            con.Open();
        }

        string sql_query = "select admin_id,email_id,password from admin";
        SqlCommand cmd = new SqlCommand(sql_query, con);    
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if(dt.Rows.Count > 0 && dt != null)
        {
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    
    }
}