<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Contact.aspx.vb" Inherits="Contact" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 100%;
            height: 148px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style3">
        <tr>
            <td><center><h1>
                <asp:Label ID="Label1" runat="server" 
                    Text="Address: 95-A, E Avani Moola St, Madurai Main, Madurai, Tamil Nadu 625001" 
                    ForeColor="#996633" Font-Names="Arial Rounded MT Bold"></asp:Label></h1></center>
            <center><h3>
                    <asp:Label ID="Label2" runat="server" Text="Phone: 088703 21976" 
                    Font-Names="Britannic Bold" ForeColor="#663300"></asp:Label>&nbsp; </h3>
                </center>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

