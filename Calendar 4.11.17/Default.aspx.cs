using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string[,] books = new string[5, 2]; //2 dimensional array set up
    protected void Page_Load(object sender, EventArgs e)
    { //2 dimensional array implemented 
       // if (!IsPostBack)
        
            books[0, 0] = "John Steinbeck"; //first column
            books[0, 1] = "The Grapes of Wrath"; //2nd columns
            books[1, 0] = "Ray Bradbury";
            books[1, 1] = "The Martian Chronlicles";
            books[2, 0] = "Isacc Asimo";
            books[2, 1] = "I Robot";
            books[3, 0] = "JR Token";
            books[3, 1] = "The Hobbit";
            books[4, 0] = "Ray Bradbury";
            books[4, 1] = "Farenheight 911";

        if (!IsPostBack)
            FillAuthor();
        
    }

    protected void FillAuthor()
    {
        for (int i = 0; i < 5; i++) //for loop will keep looping as long as less than 4
        {
            AuthorsDropDownList1.Items.Add(books[i, 0]); //i = book name 0 = title
        }
        ListItem item = new ListItem("Choose and Author");
        AuthorsDropDownList1.Items.Insert(0, item);
    }


    protected void AuthorsDropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        ResultLabel1.Text = "";
        string author;
        author = AuthorsDropDownList1.SelectedItem.Text; //calnder.selectdate to get items from clnd
        for (int i =0; i < 5; i++)
        {
            if (books[i,0].Equals(author))
            {
                ResultLabel1.Text += books[i, 1] + "<br/>";
            }
            
        }
    }
}