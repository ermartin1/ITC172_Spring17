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
    //    string user = UserTextBox.Text;
        string first = FirstNameTextBox.Text;
        string last = LastNameTextBox.Text;
        string email = EmailTextBox.Text;
        string password = ConfirmTextBox.Text;

        HW6ClientRef.CommAsstRegClient sc =
             new HW6ClientRef.CommAsstRegClient();
        HW6ClientRef.PersonInfo req = new HW6ClientRef.PersonInfo();
    //    req.PersonEmail = user;
        req.firstname = first;
        req.lastname = last;
        req.email = email;
        req.password = password;

        bool result = sc.RegisterPerson(req);
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