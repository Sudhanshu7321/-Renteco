using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Razorpay.Api;
using System.Collections.Generic;
//using NUnit.Framework;

public partial class payrequest : System.Web.UI.Page
{
  
    public string orderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        Dictionary<string, object> input = new Dictionary<string, object>();
        input.Add("amount", 100); // this amount should be same as transaction amount
        input.Add("currency", "INR");
        input.Add("receipt", "12121");
        input.Add("payment_capture", 1);

        string key = "rzp_test_ErXHk947hWYPvK";
        string secret = "fDegGXU06nFrPkhg2ioDlscl";

        RazorpayClient client = new RazorpayClient(key, secret);
        System.Net.ServicePointManager.Expect100Continue = false;
        Razorpay.Api.Order order = client.Order.Create(input);
        // orderId = order["id"].ToString();
        orderId = "78459";

    }
}