<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CompareListWeb._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>

<style type="text/css">
    body {
        background-color: #d0e4fe; 
        min-width: 640px;
        margin: auto;
        font-family: "Arial";
        font-size: 18px;
        padding: 10;
    }       
    td
        {
            text-align: center;
        }
        
</style>
</head>
<body>

    <div>
    <form id="form1" runat="server">
 
        <table>
            <tr>
                <td colspan="2">
                    <img alt="Panani" src="images/Panini.png" />
                    <p>Paste your card lists with commas between each number (eg: 1,2,5,9)</p>
                </td>
            </tr>

            <tr>
                <td>YOUR WANTS</td>
                <td class="style1">YOUR SWAPS</td>
            </tr>
            <tr>
                <td><asp:TextBox ID="textBoxMeWant" runat="server" Height="90px" Width="320px" 
                    TextMode="MultiLine"></asp:TextBox></td>
                <td><asp:TextBox ID="textBoxMeSwap" runat="server" Height="90px" Width="320px" 
                    TextMode="MultiLine"></asp:TextBox></td>
            </tr>
            <tr>
                <td>FRIENDS WANTS</td>
                <td class="style1">FRIENDS SWAPS</td>
            </tr>
            <tr>
                <td><asp:TextBox ID="textBoxFriendWant" runat="server" Height="90px" Width="320px" 
                    TextMode="MultiLine"></asp:TextBox></td>
                <td><asp:TextBox ID="textBoxFriendSwap" runat="server" Height="90px" Width="320px" 
                    TextMode="MultiLine"></asp:TextBox></td>
            </tr>
            <tr>
                <td>SWAPS TO FRIEND</td>
                <td class="style1">SWAPS TO ME</td>
            </tr>
            <tr>
                <td><asp:TextBox ID="textBoxFriend" runat="server" Height="90px" Width="320px" 
                    TextMode="MultiLine" ReadOnly="True"></asp:TextBox></td>
                <td><asp:TextBox ID="textBoxMe" runat="server" Height="90px" Width="320px" 
                    TextMode="MultiLine" ReadOnly="True"></asp:TextBox></td>
            </tr>

            <tr>
                <td colspan="2">
                    <asp:Button ID="ButtonSwap" runat="server" onclick="ButtonSwap_Click" 
            Text="Show Swaps" Height="50px" Width="120px" />
                </td>
            </tr>
        </table>

    </form>
    </div>

</body>
</html>
