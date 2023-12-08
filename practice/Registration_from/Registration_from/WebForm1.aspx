<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Registration_from.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<section id="main-content">
<section class="wrapper">
<div class="row">
<div class="col-lg-12">
<section class="panel">
<header class="panel-Biv class=">
<h1>Registration Form</h1>
</div>
</header>
</section>
    <body>
        <p>
            <table class="auto-style1">
                <tr>
                    <td>Name :</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Confirm Password</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>City</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Text="Select City" Value="select" Selected="True"></asp:ListItem>
                            <asp:ListItem Text="Bangalore" Value="Bangalore"></asp:ListItem>
                            <asp:ListItem Text="Mysore" Value="Mysore"></asp:ListItem>
                            <asp:ListItem Text="Hubli" Value="hubli"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Gender</td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>Gmail</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Button" />
                    </td>
                </tr>
            </table>
        </p>
</body>
</div>
</div>
</section>
</section>
</asp:Content>
