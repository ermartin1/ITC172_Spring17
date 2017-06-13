<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h2>Welcome to the Community Assistance Home Page</h2>
        </header>
    <div>
    <p>Community Assist offers great ways to help get people back on their feet, with grants that are able to help with just about anything.</p>
    <p>If you would like to make a donation you can simply <asp:LinkButton ID="DonorLink" runat="server" PostBackUrl="DonorPage.aspx">click here </asp:LinkButton>and you can assist those in need by donating to our cause.</p>
   <%-- <p>As is our tradition we can help with our <asp:LinkButton ID="GrantApp" runat="server" PostBackUrl="GrantApplication.aspx">grant application </asp:LinkButton>process. Please seek out our assistance if you're in need.</p>--%>
    </div>
    </form>
</body>
</html>
