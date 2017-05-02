using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DonationList : System.Web.UI.Page
{
    private object db;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userKey"] != null)
        {
            Community_AssistEntities db = new Community_AssistEntities();
            int key = (int)Session["userKey"];
            var donations = (from d in db.Donations
                             where d.PersonKey == key
                             select d).ToList();
            GridView.DataSource = donations;
            GridView.DataBind();
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }
}