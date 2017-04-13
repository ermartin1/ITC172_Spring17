<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <p><asp:Label ID="Label1" runat="server" Text="Label" CssClass="result"></asp:Label></p>
    </div>
    </form>
</body>
</html>
