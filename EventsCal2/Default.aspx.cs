using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

     protected void EventCalendar_SelectionChanged1(object sender, EventArgs e)
    {
        {
            EventLabel.Text = "";
            string[,] events = new string[6, 2];

            events[0, 0] = "4/13/2017";
            events[0, 1] = "Classes at SCC";
            events[1, 0] = " 4/14/2017";
            events[1, 1] = "Work but it's Friday!";
            events[2, 0] = "4/17/2017";
            events[2, 1] = "Work meh oh well";
            events[3, 0] = "4/20/2017";
            events[3, 1] = "Yeah buddy! Meeting on the Green";
            events[4, 0] = "4/21/2017";
            events[4, 1] = "Payday!!!!";
            events[5, 0] = "4/30/2017";
            events[5, 1] = "Submit timesheet";

            string dates = EventCalendar.SelectedDate.ToShortDateString();


            for (int i = 0; i < 6; i++) //for loop
            {
                if (dates.Equals(events[i, 0]))
                {
                    EventLabel.Text += events[i, 1] + "<br/>";
                }
            }

            if (EventLabel.Text == "") EventLabel.Text = dates;


        }
    }
}
