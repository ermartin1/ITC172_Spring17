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
        string lastname = LastNameTextBox.Text;
        string firstname = FirstNameTextBox.Text;
        string email = EmailTextBox.Text;
        string password = ConfirmTextBox.Text;
        string apt = AptTextBox.Text;
        string street = StreetBox.Text;
        string city = CityBox.Text;
        string state = StateBox.Text;
        string zipcode = ZipBox.Text;
        string homePhone = HomeBox.Text;
        string workPhone = WorkBox.Text;


        Community_AssistEntities db = new Community_AssistEntities();
        int result = db.usp_Register(lastname, firstname, email, password, apt, street, city, state, zipcode, homePhone, workPhone);
        if (result != -1)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            ErrorLabel.Text = "Something went terribly wrong";
        }

    }
}