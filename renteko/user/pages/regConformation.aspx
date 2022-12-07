<%@ Page Language="C#" AutoEventWireup="true" CodeFile="regConformation.aspx.cs" Inherits="regConformation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome Letter</title>
    <style type="text/css">
    body{font-family: calibri,Arial; font-size:14px; line-height:20px;}
    </style>

    <script language="javascript" type="text/javascript">
        function ClientSidePrint(idDiv) {
            var w = 900;
            var h = 800;
            var l = (window.screen.availWidth - w) / 2;
            var t = (window.screen.availHeight - h) / 2;

            var sOption = "toolbar=no,location=no,directories=no,menubar=no,scrollbars=yes,width=" + w + ",height=" + h + ",left=" + l + ",top=" + t;
            // Get the HTML content of the div
            var sDivText = window.document.getElementById(idDiv).innerHTML;
            // Open a new window
            var objWindow = window.open("", "Print", sOption);
            // Write the div element to the window
            objWindow.document.write(sDivText);
            objWindow.document.close();
            // Print the window            
            objWindow.print();
            // Close the window
            //            objWindow.close();            
        }
        function ClientSidePrintID(idDiv) {
            var w = 900;
            var h = 800;
            var l = (window.screen.availWidth - w) / 2;
            var t = (window.screen.availHeight - h) / 2;

            var sOption = "toolbar=no,location=no,directories=no,menubar=no,scrollbars=yes,width=" + w + ",height=" + h + ",left=" + l + ",top=" + t;
            // Get the HTML content of the div
            var sDivText = window.document.getElementById(idDiv).innerHTML;
            // Open a new window
            var objWindow = window.open("", "Print", sOption);
            // Write the div element to the window
            objWindow.document.write(sDivText);
            objWindow.document.close();
            // Print the window            
            objWindow.print();
            // Close the window
            //            objWindow.close();            
        }
        function btnprint_onclick() {

        }

</script>


</head>
<body>
    <form id="form1" runat="server">
 


 <div style="width:680px; margin:10px auto; height:25px;">
 <div style="float:left;">
 <input id="btnprint" type="button" value="Print" style="width:80px" name="Print" class="btn btn-primary" onclick="ClientSidePrint('divprint')" onclick="return btnprint_onclick()" /></div>
 <div style="float:right;">  
     <asp:LinkButton ID="btnBack" runat="server" onclick="btnBack_Click">Add More</asp:LinkButton></div>
</div>
 <div id="divprint">
  <table height="635px" border="0" cellspacing="0" cellpadding="0" align="center" width="680px" style="background:#f5ffee; padding:10px; text-align:justify; border:4px double #005598; margin:10px auto; font-family: calibri,Arial; font-size:14px; line-height:20px;">
  <tr>
  <td valign="top" width="372px" colspan="2" height="120px"> <center> <img src="css2/images/logo1.png" width="100PX" /> <h1>Realty Life</h1></center><br />
      <div style="padding-left:240px"><u>www.rkdpl.co.in</u></div></td>
  </tr> 
  
  
  <tr>
  <td colspan="2" style="text-align: center" height="20px">
      <h4 style="margin:0; padding:0; text-align:center; color:#086CB0">
          HEARTIEST CONGRATULATION 
          <asp:Label ID="lblName1" runat="server"></asp:Label>
          ,  WELCOME TO Realty Life FAMILY</h4>
      </td>
  </tr>

  <tr>
  <td colspan="2" style="top: 10px">
      <br />
      Dear <asp:Label ID="lblName0" runat="server"></asp:Label>,<br />
      <br />
      Your application dated&nbsp;
      <asp:Label ID="lblJoinDate0" runat="server"></asp:Label>
      &nbsp;is received. Given below are the Field Working Id along with other details for accessing your account & any related information at our official website: www.rkdpl.co.in. We suggest you to change your password immediately & if any problem relating to login occurs or you need any assistance please do not hesitate to contact us at our Email Id: support@rkdpl.co.in. 
Last but not least you are a very important pillar of our company, it is very important that who so ever works will be rewarded with maximum returns, and it is very necessary for all field workers including you to work hard to promote our plots and earn maximum income and assured payouts. 
      <table border="0" cellspacing="0" cellpadding="4" align="center" width="650px" style="padding:10px; text-align:justify; border-collapse:collapse;">
          <tr>
              <td width="130px"><strong>Member Name  </strong></td>
              <td width="4px">:</td>
              <td><asp:Label ID="lblName" runat="server"></asp:Label></td>
          </tr> 
          <tr>
              <td><strong>Address</strong></td>
              <td>:</td>
              <td><asp:Label ID="lblAddress" runat="server"></asp:Label></td>
          </tr>
          <tr>
              <td><strong>Contact No.</strong></td>
              <td>:</td>
              <td><asp:Label ID="lblContact" runat="server"></asp:Label></td>
          </tr>
          <tr>
              <td><strong>Product Name</strong></td>
              <td>:</td>
              <td><asp:Label ID="lblPrdName" runat="server"></asp:Label></td>
          </tr>
                <tr>
              <td><strong>Member ID </strong></td>
              <td>:</td>
              <td><asp:Label ID="lblId" runat="server"></asp:Label></td>
          </tr>                
          <tr>
              <td><strong>Password</strong></td>
              <td>:</td>
              <td><asp:Label ID="lblPassword" runat="server"></asp:Label></td>
          </tr>
                              
      </table><br />
      Once again, thank you for joining our company. We look forward to a long lasting and successful relationship together.<br />
      <br />
      Yours Sincerely,<br />
      <br />
      <asp:Label ID="lblDatetime" runat="server"></asp:Label>
      </td>
      
  
      <br />
      </tr>
      <tr>
      <td colspan="2" style="text-align: center">
      (This is only a welcome letter, it will not treat as a money receipt or so.)</td></tr>
  
  </table>
  
  </div>
    </form>
</body>
</html>
