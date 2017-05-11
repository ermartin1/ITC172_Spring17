using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CommAsstReg" in code, svc and config file together.
public class CommAsstReg : ICommAsstReg
{
    Community_AssistEntities db = new Community_AssistEntities();
    public List<GrantRequest> GetGrants()
    {
        var grantreq = from g in db.GrantRequests
                       select g;

        List<GrantRequest> grants = new List<GrantRequest>();
        //loop through the request and write each field to the Grant Request 
        foreach(var gr in grantreq)
        {
            GrantRequest grant1 = new GrantRequest();
            grant1.GrantRequestDate = gr.GrantRequestDate;
            grant1.GrantTypeKey = gr.GrantTypeKey;
            grant1.PersonKey = gr.PersonKey;
            grant1.GrantRequestAmount = gr.GrantRequestAmount;

            grants.Add(grant1);
            }
        return grants;
        } 
    }

