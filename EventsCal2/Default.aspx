<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Events Calendar</title>
   
    <link href="StyleSheet.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>Events Calendar April 2017</h3>
        <asp:Label ID="EventLabel" runat="server" Text=""></asp:Label>
        <asp:Calendar ID="EventCalendar" runat="server" OnSelectionChanged="EventCalendar_SelectionChanged1"></asp:Calendar>

    </div>
    </form>
</body>
</html>
