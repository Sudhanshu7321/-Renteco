using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using System.Data.SqlClient;


/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    SqlCommand cmd;
    public Class1()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public void login3( int x)
    {
        int y = 0;
        
    }
    public string getvalue(string sqlquery)
    {
        string sendvalue = "";
        try
        {
            if (con.State == ConnectionState.Closed)
               // if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand drcmd = new SqlCommand(sqlquery, con);
            SqlDataReader dr = null;
            dr = drcmd.ExecuteReader();
            while (dr.Read())
            {
                sendvalue = dr[0].ToString();
            }
            dr.Close();
            return sendvalue;
        }
        catch (Exception ex)
        {
            return ex.Message.ToString();
        }
        finally
        {

        }
    }


}