using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {

        string myDate = Label1.Text = Calendar1.SelectedDate.ToShortDateString();
        string birthday = "11/4/2017";
        if (myDate.Equals(birthday))
        {
            Label1.Text = "Happy Flipping Day of Birth!";
        }
        else
        { //gives you short date
            Label1.Text = Calendar1.SelectedDate.ToShortDateString(); 
        }
        //Label1.Text = Calendar1.SelectedDate.ToShortDateString();
        //Label1.Text = DateTime.Now.ToString(); //date and time
        //Label1.Text = Calendar1.SelectedDate.ToLongDateString(); //longer date
    }
}