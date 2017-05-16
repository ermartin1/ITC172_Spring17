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
    public List<GrantRequest> GetGrantsbyRequest()
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

    //public List<GrantReview> GetGrantsbyReview()
    //{
    //    var grantrev = from g in db.GrantReview
    //                   from g in db.People
    //                   where g
    //}


    public int Login(string user, string password)
    {
        int key = 0;
        int result = db.usp_Login(user, password);
        if (result != -1)
        {
            var userKey = (from k in db.People
                           where k.PersonEmail.Equals(user)
                           select k.PersonKey).FirstOrDefault();
            key = (int)userKey;
        }
        return key;
    }

    public bool NewGrant(GrantRequest r)
    {
        bool result = true;
        try
        {
            GrantReview grantrev = new GrantReview();
            grantrev.GrantRequest = r;
            grantrev.GrantRequestStatus = "pending";
            grantrev.GrantReviewDate = DateTime.Now;

            db.GrantRequests.Add(r);
            db.GrantReviews.Add(grantrev);
            db.SaveChanges();
                   }
        catch (Exception ex)
        {
            result = false;
        }
        return result; 
    }

    public bool RegisterPerson(PersonInfo pi)
    {
        bool result = true;
        int reg = db.usp_Register(pi.lastname, pi.firstname, pi.email, pi.password, 
            pi.ApartmentNumber, pi.Street, pi.City, pi.State, pi.Zipcode, 
            pi.HomePhone, pi.WorkPhone);

        return result;
    }

  }


