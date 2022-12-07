using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie reqCookies = Request.Cookies["userInfo"];
        if (reqCookies != null)
        {
            EmailId.Text = reqCookies["email_id"].ToString();
            Password.Text = reqCookies["password"].ToString();
        }
    }
    protected void SingIn_Click(object sender, EventArgs e)
    {

        try
        {
          
            if (EmailId.Text.Trim() == "")
            {
                throw new Exception("Enter Valid Email ID");
            }
            if(Password.Text.Trim() == "")
            {
                throw new Exception("Please Enter Password");
            }

            Password enc = new Password();
            string password = enc.EncryptPlainTextToCipherText(Password.Text.Trim(),EmailId.Text.Trim());

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string sql_query = "select * from service_provider where email_id = @email_id and password = @password and status = 1";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@email_id", EmailId.Text.Trim());
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0 && dt != null)
            {
                if (checkbox.Checked == true)
                    Cookie();

                Session["name"] = dt.Rows[0]["name"].ToString();
                Session["image_path"] = dt.Rows[0]["image_path"].ToString();
                Session["service_provider_id"] = dt.Rows[0]["service_provider_id"].ToString();
                Response.Redirect("../pages/service-provider.aspx", false);

            }
            else
            {
                string sql_query_admin = "select * from admin where email_id = @email_id_a and password = @password_a and status = 1";
                SqlCommand cmd_admin = new SqlCommand(sql_query_admin, con);
                cmd_admin.Parameters.AddWithValue("@email_id_a", EmailId.Text.Trim());
                cmd_admin.Parameters.AddWithValue("@password_a", password);
                SqlDataAdapter adp_admin = new SqlDataAdapter(cmd_admin);
                DataTable dt_admin = new DataTable();
                adp_admin.Fill(dt_admin);
                if (dt_admin.Rows.Count > 0 && dt_admin != null)
                {
                    Session["name"] = dt_admin.Rows[0]["name"].ToString();
                    Session["type"] = dt_admin.Rows[0]["type"].ToString();
                    Response.Redirect("../pages/dashboard.aspx", false);

                }
                else
                {
                    lblMassage.Text = "Wrong Credentials";
                    lblMassage.ForeColor = System.Drawing.Color.Red;
                    clear();
                }

               
            }

        }
        catch (Exception ex)
        {
            lblMassage.Text = ex.Message;
            lblMassage.ForeColor = System.Drawing.Color.Red;
        }
        finally 
        {
            con.Close();

        }
    }

    protected void Cookie()
    {
        HttpCookie userInfo = new HttpCookie("userInfo");
        userInfo["email_id"] = EmailId.Text.Trim();
        userInfo["password"] = Password.Text.Trim();
        userInfo.Expires.Add(new TimeSpan(0, 1, 0));
        Response.Cookies.Add(userInfo);
    }
    //This security key should be very complex and Random for encrypting the text. This playing vital role in encrypting the text.
    private const string SecurityKey = "ComplexKeyHere_12121";

    //This method is used to convert the plain text to Encrypted/Un-Readable Text format.
    public static string EncryptPlainTextToCipherText(string PlainText)
    {
        // Getting the bytes of Input String.
        byte[] toEncryptedArray = UTF8Encoding.UTF8.GetBytes(PlainText);

        MD5CryptoServiceProvider objMD5CryptoService = new MD5CryptoServiceProvider();
        //Gettting the bytes from the Security Key and Passing it to compute the Corresponding Hash Value.
        byte[] securityKeyArray = objMD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(SecurityKey));
        //De-allocatinng the memory after doing the Job.
        objMD5CryptoService.Clear();

        var objTripleDESCryptoService = new TripleDESCryptoServiceProvider();
        //Assigning the Security key to the TripleDES Service Provider.
        objTripleDESCryptoService.Key = securityKeyArray;
        //Mode of the Crypto service is Electronic Code Book.
        objTripleDESCryptoService.Mode = CipherMode.ECB;
        //Padding Mode is PKCS7 if there is any extra byte is added.
        objTripleDESCryptoService.Padding = PaddingMode.PKCS7;


        var objCrytpoTransform = objTripleDESCryptoService.CreateEncryptor();
        //Transform the bytes array to resultArray
        byte[] resultArray = objCrytpoTransform.TransformFinalBlock(toEncryptedArray, 0, toEncryptedArray.Length);
        objTripleDESCryptoService.Clear();
        return Convert.ToBase64String(resultArray, 0, resultArray.Length);
    }

    //This method is used to convert the Encrypted/Un-Readable Text back to readable  format.
    public static string DecryptCipherTextToPlainText(string CipherText)
    {
        byte[] toEncryptArray = Convert.FromBase64String(CipherText);
        MD5CryptoServiceProvider objMD5CryptoService = new MD5CryptoServiceProvider();

        //Gettting the bytes from the Security Key and Passing it to compute the Corresponding Hash Value.
        byte[] securityKeyArray = objMD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(SecurityKey));
        objMD5CryptoService.Clear();

        var objTripleDESCryptoService = new TripleDESCryptoServiceProvider();
        //Assigning the Security key to the TripleDES Service Provider.
        objTripleDESCryptoService.Key = securityKeyArray;
        //Mode of the Crypto service is Electronic Code Book.
        objTripleDESCryptoService.Mode = CipherMode.ECB;
        //Padding Mode is PKCS7 if there is any extra byte is added.
        objTripleDESCryptoService.Padding = PaddingMode.PKCS7;

        var objCrytpoTransform = objTripleDESCryptoService.CreateDecryptor();
        //Transform the bytes array to resultArray
        byte[] resultArray = objCrytpoTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
        objTripleDESCryptoService.Clear();

        //Convert and return the decrypted data/byte into string format.
        return UTF8Encoding.UTF8.GetString(resultArray);
    }

    protected void clear()
    {
        EmailId = null;
        Password = null;    

    }
}