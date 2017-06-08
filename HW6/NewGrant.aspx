<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewGrant.aspx.cs" Inherits="NewGrant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>New Grant Request</title>
</head>
<body>
    <h1>New Grant Request</h1>
    <h2>Enter Information for Request</h2>
    <form id="form1" runat="server">
    <div>
<table>
    <tr>
        <td>First Name</td>
        <td>
            <asp:TextBox ID="FirstTextBox" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td>Last Name</td>
        <td>
            <asp:TextBox ID="LastTextBox" runat="server"></asp:TextBox></td>
    </tr>
  <!--  <tr>
        <td>User Name</td>
        <td>
            <asp:TextBox ID="UserTextBox" runat="server"></asp:TextBox></td>
    </tr> -->
        <tr>
        <td>Email</td>
        <td>
            <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox></td>
    </tr>
   <tr>
     <td>Request Date</td>
    <td>
        <asp:TextBox ID="RequestTextBox" runat="server"></asp:TextBox></td>
    </tr>
      <tr>
   <td>Grant Type</td>
    <td>
        <asp:TextBox ID="TypeTextBox" runat="server"></asp:TextBox></td>
    </tr>
    
    <tr>
   <td>Grant Amount</td>
    <td>
            <asp:TextBox ID="GrantTextBox" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
    <td><asp:Button ID="SubmitButton" runat="server" Text="Submit Request" OnClick="SubmitButton_Click"/> </td>
    </tr>
           </table>
          </div>

    </form>
    
</body>
</html>
