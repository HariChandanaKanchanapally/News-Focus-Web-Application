<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment5._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-4">
            <p>
                Welcome User!</p>
            <p>
                This is a web application that allows you to find information about a place</p>
            <p>
                For finding all the required information please enter the following</p>
            <p>
                Latitude&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                <asp:TextBox ID="TextBoxLatitude" runat="server"></asp:TextBox>
            &nbsp;[52.629729]</p>
            <p>
                Longitude&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxLongitude" runat="server"></asp:TextBox>
            &nbsp;[-1.131592]</p>
            <p>
                Place Name&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxName" runat="server" Width="120px"></asp:TextBox>
            &nbsp;[Tempe]</p>
            <p>
                Zip&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                <asp:TextBox ID="TextBoxZip" runat="server"></asp:TextBox>
            &nbsp;[85281]</p>
            <p>
                <asp:Button ID="ButtonNews" runat="server" OnClick="ButtonNews_Click" Text="Gas Stations" />
                <asp:Button ID="ButtonWeather" runat="server" OnClick="ButtonWeather_Click" Text="Crime Rate" />
            </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Label ID="LabelNewsWeather" runat="server"></asp:Label>
            </p>
            <p>
                People who have seen this have also seen
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Click Here for more News" />
            </p>
            <p>
                &nbsp;</p>
        </div>
    </div>

</asp:Content>
