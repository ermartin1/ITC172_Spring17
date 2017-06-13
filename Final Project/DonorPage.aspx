<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DonorPage.aspx.cs" Inherits="DonorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" />
    <title>Donaor Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Donate</h1>
     <table>
            <tr>
                <td>
                    Enter a Donation amount: 
                </td>
                <td>
                    <asp:TextBox ID="DonateBox" runat="server" ></asp:TextBox>
                </td>
            </tr> 
            
        </table>
        <p><asp:Button ID="DonationSubmit" runat="server" Text="Donate" OnClick="DonationSubmit_Click" /></p>
    </div>
    </form>
</body>
</html>

