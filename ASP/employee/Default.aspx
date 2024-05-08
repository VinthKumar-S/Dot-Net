<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgcolor="lightgreen" style="background-color: #ccffff;"><center>
    <form id="form1" runat="server">
    <div style="font-family: Aharoni">
        
        <h1>
            <span style="color: #009933; font-family: Algerian, Aharoni;">
             Employee
            Salary Calculation </span>
        </h1>
        <br />
        &nbsp; &nbsp; &nbsp; Name :&nbsp;
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; Id :&nbsp;
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox><br />
        &nbsp;&nbsp;<br />
        &nbsp; &nbsp; &nbsp; &nbsp;
        
        Department :&nbsp;
        <asp:TextBox ID="txtDpt" runat="server"></asp:TextBox>
        &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;<br />
        <br />
         Destination :&nbsp;
        <asp:TextBox ID="txtDes" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp; &nbsp;&nbsp;
        
        Basic Salary :&nbsp;
        <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
        &nbsp; &nbsp;&nbsp;&nbsp; &nbsp;<br />
        <br />
        <br />
        <asp:Button ID="submitBtn" runat="server" Text="Submit" BackColor="Fuchsia" BorderColor="Black" Font-Names="Aharoni" />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;<asp:Button ID="displayBtn" runat="server" Text="Display" BackColor="Fuchsia" BorderColor="Black" ForeColor="Transparent" Font-Names="Aharoni" /><br />
        <br />
        
        <center><h3><asp:Label ID="tableTitle" runat="server" Text="Employee Details" BackColor="Yellow" BorderColor="Black" ForeColor="#0000C0"></asp:Label></h3>
        </center>
        <center>
            &nbsp;</center>
        <center>
        <asp:Table ID="Table1" runat="server">
        </asp:Table>
            &nbsp;</center>
        <br />
        <br />
    
    </div>
    </form></center>
</body>
</html>
