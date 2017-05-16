using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICommAsstReg" in both code and config file together.
[ServiceContract]
public interface ICommAsstReg
{
    [OperationContract]
    int Login(string user, string password);

    [OperationContract]
    bool RegisterPerson(PersonInfo pi);

    [OperationContract]
    List<GrantRequest> GetGrantsbyRequest();

    //[OperationContract]
    //List<GrantReview> GetGrantsByReview();

    [OperationContract]
    bool NewGrant(GrantRequest r);

}

[DataContract]
public class PersonInfo
{
    [DataMember]
    public string lastname { get; set; }

    [DataMember]
    public string firstname { get; set; }

    [DataMember]
    public string email { get; set; }

    [DataMember]
    public string password { get; set; }

    [DataMember]
    public string ApartmentNumber { get; set; }

    [DataMember]
    public string Street { get; set; }

    [DataMember]
    public string City { get; set; }

    [DataMember]
    public string State { get; set; }

    [DataMember]
    public string Zipcode { get; set; }

    [DataMember]
    public string HomePhone { get; set; }

    [DataMember]
    public string WorkPhone { get; set; }

}