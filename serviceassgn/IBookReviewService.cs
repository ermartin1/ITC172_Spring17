using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBookReviewService" in both code and config file together.
[ServiceContract]
public interface IBookReviewService
{
    [OperationContract] //means pass this information to the webpage
    int Login(string user, string password);

    [OperationContract]
    bool RegisterReviewer(Reviewer r);

    [OperationContract]
    List<BookInfo> GetBooks();

    [OperationContract]
    List<Book> GetBooksByAuthor(string authorName);

}

[DataContract] //writing another data class
public class BookInfo
{
    [DataMember]
    public string BookTitle { get; set; } //auto generate get and set statements

    [DataMember]
    public string BookEntryDate { get; set; }

    [DataMember]
    public string BookISBN { get; set; }

    [DataMember]
    public List<Author> BookAuthor { get; set; } //array of authors with List<Author>


}