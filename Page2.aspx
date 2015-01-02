<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="Assignment5.News" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            The previous credentials entered are:</p>
        <p>
            <asp:Label ID="LabelCredentials" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="SolarIntensity" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="News" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Weather" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Back" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
