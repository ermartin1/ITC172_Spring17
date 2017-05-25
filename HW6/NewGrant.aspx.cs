using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewGrant : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userKey"] == null)
        {
            Response.Redirect("Default.aspx");
        }
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        GrantReqRequest.CommAsstRegServiceClient sc = new GrantReqRequest.CommAsstRegServiceClient();
        Request r = new Request();
        r.RequestAmount = decimal.Parse(this.GrantTextBox.Text);
        r.PersonKey = (int)Session["userKey"];
        r.RequestDate = DateTime.Now;

        db.Requests.Add(r);
        db.SaveChanges();

        Response.Redirect("GetGrants.aspx");
    }
}