using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GetGrants : System.Web.UI.Page
{
    GrantReqRequest.Community_AssistEntities sc = 
        new GrantReqRequest.Community_AssistEntities();

        protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            FillGrantRequest();
    }

    protected void GrantDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        GrantReqRequest.Grant[] grants =
            sc.GetGrantRequests(GrantDropDownList.SelectedItem.Text);
        GridView1.DataSource = grants;
        GridView1.DataBind();
    }

    protected void FillGrantRequest()
    {
        string[] donors = sc.GetDonors();
        GrantDropDownList.DataSource = donors;
        GrantDropDownList.DataBind();
        ListItem item = new ListItem("Choose a Donor");
        GrantDropDownList.Items.Insert(0, item);
    }
}

