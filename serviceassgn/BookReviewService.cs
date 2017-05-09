using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BookReviewService" in code, svc and config file together.
public class BookReviewService : IBookReviewService
{
    BookReviewDbEntities db = new BookReviewDbEntities();
    public List<BookInfo> GetBooks() //gets all the books
    {
        var bks = from b in db.Books
                  select b;
                  
        List<BookInfo> books = new List<BookInfo>(); //<> means its generic
        foreach(Book bk in bks)
        {
            BookInfo booko = new BookInfo(); //book comes from database
            booko.BookTitle = bk.BookTitle;
            booko.BookEntryDate = bk.BookEntryDate.ToShortDateString();
            booko.BookISBN = bk.BookISBN;
            booko.BookAuthor = new List<Author> ();
            foreach(Author a in bk.Authors)
            {
                Author au = new Author();
                au.AuthorName = a.AuthorName;
                booko.BookAuthor.Add(au);
            }
            books.Add(booko);
        }
        return books;
    }

    public List<Book> GetBooksByAuthor(string authorName)
    {
        var bks = from b in db.Books
                   from a in b.Authors
                   where a.AuthorName.Equals(authorName)
                   select b;

        List<Book> books = new List<Book>(); //book object

        foreach(var bk in bks)
        {
            Book bo = new Book();
            bo.BookTitle = bk.BookTitle;
            bo.BookEntryDate = bk.BookEntryDate;
            bo.BookISBN = bk.BookISBN;
            books.Add(bo);
        }
        return books;
    }

    public int Login(string user, string password)
    {
        int key = 0;//initialzing the variable
        int result = db.usp_ReviewerLogin(user, password);
        if (result != -1)
        {
            var userKey = (from k in db.Reviewers
                           where k.ReviewerUserName.Equals(user)
                           select k.ReviewerKey).FirstOrDefault();
            key = (int)userKey;
        }

        return key;
    }

    public bool RegisterReviewer(Reviewer r)
    {
        bool result = true;
        int rev = db.usp_NewReviewer(r.ReviewerUserName, r.ReviewerFirstName,
            r.ReviewerLastName, r.ReviewerEmail, r.ReviewPlainPassword);
        return result;
    }
}
