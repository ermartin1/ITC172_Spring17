using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GetGrants : System.Web.UI.Page
{
    HW6ClientRef.CommAsstRegClient gr =
        new HW6ClientRef.CommAsstRegClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userKey"] == null)
            Response.Redirect("Default.aspx");
       // if (!IsPostBack)
            FillGrantRequest();
    }

    protected void FillGrantRequest()
    {
        HW6ClientRef.GrantRequest[] grants = gr.GetGrantsbyRequest((int)Session["userKey"]);


        GridView1.DataSource = grants;
        GridView1.DataBind();


        //        string[] person = gr.GetGrantsbyRequest();
        //        GrantDropDownList.DataSource = person;
        //        GrantDropDownList.DataBind();
        //        ListItem item = new ListItem("Choose a Donor");
        //        GrantDropDownList.Items.Insert(0, item);
        //    }
    }



    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

