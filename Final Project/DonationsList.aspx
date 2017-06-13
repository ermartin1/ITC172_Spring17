<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DonationsList.aspx.cs" Inherits="DonationsList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="DonationGrid" runat="server"></asp:GridView>
      <p><asp:LinkButton ID="ReturnHome" runat="server" PostBackUrl="HomePage.aspx">Return Home</asp:LinkButton></p>
    </div>
    </form>
</body>
</html>
