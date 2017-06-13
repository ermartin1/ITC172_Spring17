﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class BusinessRule
{
    public int BusinessRuleKey { get; set; }
    public string BusinessRuleText { get; set; }
}

public partial class Contact
{
    public int ContactKey { get; set; }
    public string ContactNumber { get; set; }
    public Nullable<int> ContactTypeKey { get; set; }
    public Nullable<int> PersonKey { get; set; }

    public virtual ContactType ContactType { get; set; }
    public virtual ContactType ContactType1 { get; set; }
    public virtual ContactType ContactType2 { get; set; }
    public virtual Person Person { get; set; }
    public virtual Person Person1 { get; set; }
    public virtual Person Person2 { get; set; }
}

public partial class ContactType
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ContactType()
    {
        this.Contacts = new HashSet<Contact>();
        this.Contacts1 = new HashSet<Contact>();
        this.Contacts2 = new HashSet<Contact>();
    }

    public int ContactTypeKey { get; set; }
    public string ContactTypeName { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Contact> Contacts { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Contact> Contacts1 { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Contact> Contacts2 { get; set; }
}

public partial class Donation
{
    public int DonationKey { get; set; }
    public Nullable<int> PersonKey { get; set; }
    public System.DateTime DonationDate { get; set; }
    public decimal DonationAmount { get; set; }
    public Nullable<System.Guid> DonationConfirmation { get; set; }

    public virtual Person Person { get; set; }
    public virtual Person Person1 { get; set; }
    public virtual Person Person2 { get; set; }
}

public partial class Employee
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Employee()
    {
        this.EmployeePositions = new HashSet<EmployeePosition>();
        this.EmployeePositions1 = new HashSet<EmployeePosition>();
        this.EmployeePositions2 = new HashSet<EmployeePosition>();
        this.GrantReviews = new HashSet<GrantReview>();
        this.GrantReviewComments = new HashSet<GrantReviewComment>();
        this.GrantReviews1 = new HashSet<GrantReview>();
        this.GrantReviewComments1 = new HashSet<GrantReviewComment>();
        this.GrantReviews2 = new HashSet<GrantReview>();
        this.GrantReviewComments2 = new HashSet<GrantReviewComment>();
    }

    public int EmployeeKey { get; set; }
    public Nullable<int> PersonKey { get; set; }
    public System.DateTime EmployeeHireDate { get; set; }
    public Nullable<decimal> EmployeeAnnualSalary { get; set; }

    public virtual Person Person { get; set; }
    public virtual Person Person1 { get; set; }
    public virtual Person Person2 { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<EmployeePosition> EmployeePositions { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<EmployeePosition> EmployeePositions1 { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<EmployeePosition> EmployeePositions2 { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<GrantReview> GrantReviews { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<GrantReviewComment> GrantReviewComments { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<GrantReview> GrantReviews1 { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<GrantReviewComment> GrantReviewComments1 { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<GrantReview> GrantReviews2 { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<GrantReviewComment> GrantReviewComments2 { get; set; }
}

public partial class EmployeePosition
{
    public int PositionKey { get; set; }
    public int EmployeeKey { get; set; }

    public virtual Employee Employee { get; set; }
    public virtual Employee Employee1 { get; set; }
    public virtual Employee Employee2 { get; set; }
    public virtual Position Position { get; set; }
    public virtual Position Position1 { get; set; }
    public virtual Position Position2 { get; set; }
}

public partial class GrantRequest
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public GrantRequest()
    {
        this.GrantReviews = new HashSet<GrantReview>();
        this.GrantReviews1 = new HashSet<GrantReview>();
        this.GrantReviews2 = new HashSet<GrantReview>();
    }

    public int GrantRequestKey { get; set; }
    public System.DateTime GrantRequestDate { get; set; }
    public Nullable<int> PersonKey { get; set; }
    public Nullable<int> GrantTypeKey { get; set; }
    public string GrantRequestExplanation { get; set; }
    public Nullable<decimal> GrantRequestAmount { get; set; }

    public virtual GrantType GrantType { get; set; }
    public virtual GrantType GrantType1 { get; set; }
    public virtual GrantType GrantType2 { get; set; }
    public virtual Person Person { get; set; }
    public virtual Person Person1 { get; set; }
    public virtual Person Person2 { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<GrantReview> GrantReviews { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<GrantReview> GrantReviews1 { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<GrantReview> GrantReviews2 { get; set; }
}

public partial class GrantReview
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public GrantReview()
    {
        this.GrantReviewComments = new HashSet<GrantReviewComment>();
    }

    public int GrantReviewKey { get; set; }
    public System.DateTime GrantReviewDate { get; set; }
    public Nullable<int> GrantRequestKey { get; set; }
    public string GrantRequestStatus { get; set; }
    public Nullable<decimal> GrantAllocationAmount { get; set; }
    public Nullable<int> EmployeeKey { get; set; }

    public virtual Employee Employee { get; set; }
    public virtual Employee Employee1 { get; set; }
    public virtual Employee Employee2 { get; set; }
    public virtual GrantRequest GrantRequest { get; set; }
    public virtual GrantRequest GrantRequest1 { get; set; }
    public virtual GrantRequest GrantRequest2 { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<GrantReviewComment> GrantReviewComments { get; set; }
}

public partial class GrantReviewComment
{
    public int GrantReviewCommentKey { get; set; }
    public Nullable<int> GrantReviewKey { get; set; }
    public Nullable<int> EmployeeKey { get; set; }
    public System.DateTime GrantReviewCommentDate { get; set; }
    public string GrantReviewNote { get; set; }

    public virtual Employee Employee { get; set; }
    public virtual Employee Employee1 { get; set; }
    public virtual Employee Employee2 { get; set; }
    public virtual GrantReview GrantReview { get; set; }
}

public partial class GrantType
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public GrantType()
    {
        this.GrantRequests = new HashSet<GrantRequest>();
        this.GrantRequests1 = new HashSet<GrantRequest>();
        this.GrantRequests2 = new HashSet<GrantRequest>();
    }

    public int GrantTypeKey { get; set; }
    public string GrantTypeName { get; set; }
    public decimal GrantTypeMaximum { get; set; }
    public decimal GrantTypeLifetimeMaximum { get; set; }
    public string GrantTypeDescription { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<GrantRequest> GrantRequests { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<GrantRequest> GrantRequests1 { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<GrantRequest> GrantRequests2 { get; set; }
}

public partial class LoginHistoryTable
{
    public int LoginHistoryKey { get; set; }
    public Nullable<int> PersonKey { get; set; }
    public System.DateTime LoginTimeStamp { get; set; }

    public virtual Person Person { get; set; }
    public virtual Person Person1 { get; set; }
    public virtual Person Person2 { get; set; }
}

public partial class Person
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Person()
    {
        this.Contacts = new HashSet<Contact>();
        this.Contacts1 = new HashSet<Contact>();
        this.Contacts2 = new HashSet<Contact>();
        this.Donations = new HashSet<Donation>();
        this.Donations1 = new HashSet<Donation>();
        this.Donations2 = new HashSet<Donation>();
        this.Employees = new HashSet<Employee>();
        this.Employees1 = new HashSet<Employee>();
        this.Employees2 = new HashSet<Employee>();
        this.GrantRequests = new HashSet<GrantRequest>();
        this.GrantRequests1 = new HashSet<GrantRequest>();
        this.GrantRequests2 = new HashSet<GrantRequest>();
        this.LoginHistoryTables = new HashSet<LoginHistoryTable>();
        this.LoginHistoryTables1 = new HashSet<LoginHistoryTable>();
        this.LoginHistoryTables2 = new HashSet<LoginHistoryTable>();
        this.PersonAddresses = new HashSet<PersonAddress>();
        this.PersonAddresses1 = new HashSet<PersonAddress>();
        this.PersonAddresses2 = new HashSet<PersonAddress>();
    }

    public int PersonKey { get; set; }
    public string PersonLastName { get; set; }
    public string PersonFirstName { get; set; }
    public string PersonEmail { get; set; }
    public byte[] PersonPassWord { get; set; }
    public System.DateTime PersonEntryDate { get; set; }
    public Nullable<int> PersonPassWordSeed { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Contact> Contacts { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Contact> Contacts1 { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Contact> Contacts2 { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Donation> Donations { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Donation> Donations1 { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Donation> Donations2 { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Employee> Employees { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Employee> Employees1 { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Employee> Employees2 { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<GrantRequest> GrantRequests { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<GrantRequest> GrantRequests1 { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<GrantRequest> GrantRequests2 { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<LoginHistoryTable> LoginHistoryTables { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<LoginHistoryTable> LoginHistoryTables1 { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<LoginHistoryTable> LoginHistoryTables2 { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<PersonAddress> PersonAddresses { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<PersonAddress> PersonAddresses1 { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<PersonAddress> PersonAddresses2 { get; set; }
}

public partial class PersonAddress
{
    public int PersonAddressKey { get; set; }
    public string PersonAddressApt { get; set; }
    public string PersonAddressStreet { get; set; }
    public string PersonAddressCity { get; set; }
    public string PersonAddressState { get; set; }
    public string PersonAddressZip { get; set; }
    public Nullable<int> PersonKey { get; set; }

    public virtual Person Person { get; set; }
    public virtual Person Person1 { get; set; }
    public virtual Person Person2 { get; set; }
}

public partial class Position
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Position()
    {
        this.EmployeePositions = new HashSet<EmployeePosition>();
        this.EmployeePositions1 = new HashSet<EmployeePosition>();
        this.EmployeePositions2 = new HashSet<EmployeePosition>();
    }

    public int PositionKey { get; set; }
    public string PositionName { get; set; }
    public string PositionDescription { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<EmployeePosition> EmployeePositions { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<EmployeePosition> EmployeePositions1 { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<EmployeePosition> EmployeePositions2 { get; set; }
}