using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DonorPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userKey"] == null)
        {
            Response.Redirect("Default");
        }
    }

    protected void DonationSubmit_Click(object sender, EventArgs e)
    {
        Community_AssistEntities db = new Community_AssistEntities();
        Donation d = new Donation();
        d.DonationAmount = decimal.Parse(this.DonateBox.Text);
        d.PersonKey = (int)Session["userKey"];
        d.DonationDate = DateTime.Now;

        db.Donations.Add(d);
        db.SaveChanges();

        Response.Redirect("DonationsList.aspx");
    }
}