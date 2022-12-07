using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class login : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    SqlCommand cmd;
    // C#
    string name = "abc";

    protected void Page_Load(object sender, EventArgs e)
    {


    }




    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            Class1 cs = new Class1();

            cs.login3(6);
            //addition

            /*
            int a = Convert.ToInt32( TextBox1.Text.Trim());
            int b = Convert.ToInt32(TextBox2.Text.Trim());
            int sum = a + b;
            int sub = a - b;
            int mul = a * b;
            int div = b / a;

            Label1.Text = sum.ToString();
            Label2.Text = sub.ToString();
            Label3.Text = mul.ToString();
            Label4.Text = div.ToString();
            */
            //decimal
            double a, b, sum, sub, mul, div, per;
            int x = Convert.ToInt32(TextBox1.Text.Trim());

            a = Convert.ToDouble(TextBox1.Text.Trim());
            b = Convert.ToDouble(TextBox2.Text.Trim());

            sum = a + b;
            sub = a - b;
            mul = a * b;
            div = a / b;
            per = div * 100;
            int y = 0;
            for (int i = 0; i < x; i++)
            {
                y += i;
            }
            y = y + x;

            int ii = 0;

            while (ii < x)
            {

                ii++;

            }

            Label1.Text = sum.ToString();
            Label2.Text = sub.ToString();
            Label3.Text = mul.ToString();
            Label4.Text = div.ToString();
            Label5.Text = div.ToString();
            Label6.Text = y.ToString();
            Label7.Text = ii.ToString();

            switchcase();
            cs.getvalue("");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        { 
        }


    }
    //if else statment & conditions

    protected void conditions(int a,int b)
    {
       if(a>b)
        {
            Label8.Text = a.ToString();
        }
        else if(a<b)
        {
            Label8.Text = b.ToString();
        }
       else if(a==b)
       {

        }
       else if (a!=b)
        {

        }
        else if (a >= b)
        {

        }
        else if (a <= b)
        {

        }
    }
    protected void conditions1(int a, int b)
    {
        if (a > b || a < b && a == b)
        {
            Label8.Text = a.ToString();
        }
        else if (a < b)
        {
            Label8.Text = b.ToString();
        }
        else if (a == b)
        {

        }
        else if (a != b)
        {

        }
        else if (a >= b)
        {

        }
        else if (a <= b)
        {

        }
    }

    protected void switchcase()
    {
        int day =7;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
        }

    }

    protected void sign_in()
    {
        try
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql_query = "select email_id, password,name from admin where email_id = @email_id and password = @password and status = 1";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@email_id", TextBox3.Text.Trim());
            cmd.Parameters.AddWithValue("@password", TextBox4.Text.Trim());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if(dt.Rows.Count > 0 && dt != null)
            {
                Response.Redirect("./admin/pages/dashboard.aspx", false);
            }
        }
        catch ( Exception ex )
        {
            Console.WriteLine(ex.Message);
        }
    }

    protected void methodoverloading (int x, string x1)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        sign_in();
    }
}