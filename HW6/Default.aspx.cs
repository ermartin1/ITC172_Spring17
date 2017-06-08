using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        HW6ClientRef.CommAsstRegClient sc =
            new HW6ClientRef.CommAsstRegClient();

        int result = sc.Login(UserTextBox.Text, PassTextBox.Text);

        if (result != 0)
        {
            Session["userKey"] = result;
         //   ResultLabel.Text = "Welcome";
            Response.Redirect("NewGrant.aspx");
        }
        else
        {
            ResultLabel.Text = "Invalid Login";
        }
    }
}