using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewGrant : System.Web.UI.Page
{
    private decimal amount;
    private int result;

    public object ResultLabel { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userKey"] == null)
        {
            Response.Redirect("Default.aspx");
        }
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        HW6ClientRef.CommAsstRegClient sc = new HW6ClientRef.CommAsstRegClient();
        decimal amount;
        //HW6ClientRef.Person r = new HW6ClientRef.Person();
        HW6ClientRef.GrantRequest r = new HW6ClientRef.GrantRequest();
        // r.GrantRequestKey = decimal.TryParse(GrantTextBox.Text);
        bool GrantRequestKey = decimal.TryParse(GrantTextBox.Text, out amount);
        r.PersonKey = (int)Session["userKey"];

      /*  r.GrantRequestDate = DateTime.Now;
          sc.Grants.Add(r);
          sc.SaveChanges();
         Response.Redirect("GetGrants.aspx"); */

        if (GrantRequestKey)
        {
            r.GrantRequestAmount = amount;
            r.GrantRequestDate = DateTime.Now;
            int? person = null;
            r.PersonKey = person;

            Response.Redirect("GetGrants.aspx");
        }
     
    }
}