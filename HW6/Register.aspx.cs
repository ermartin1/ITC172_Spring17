using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        string user = UserTextBox.Text;
        string first = FirstNameTextBox.Text;
        string last = LastNameTextBox.Text;
        string email = EmailTextBox.Text;
        string password = ConfirmTextBox.Text;

        HW6ClientRef.CommAsstRegClient sc =
             new HW6ClientRef.CommAsstRegClient();
        HW6ClientRef.Person req = new HW6ClientRef.Person();
        req.RequesterUserName = user;
        req.RequesterFirstName = first;
        req.RequesterLastName = last;
        req.RequesterEmail = email;
        req.RequestPlainPassword = password;

        bool result = sc.RegisterRequester(req);
        if (result)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            ErrorLabel.Text = "Somthing went wrong";
        }
    }
}