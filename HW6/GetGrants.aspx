<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GetGrants.aspx.cs" Inherits="GetGrants" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Grant Review</title>
</head>
<body>
    <h1>Grant Request List</h1>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>
    </div>
    </form>
</body>
</html>
