﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgcolor="#0cd0ff">
    <form id="form1" runat="server">
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        Mail Id Form</p>
    <p style="margin-left: 80px">
        &nbsp;
        Frist Name:&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp;&nbsp; &nbsp;<asp:TextBox ID="fn" runat="server" Height="35px" Width="202px" BackColor="#FFFFC0"></asp:TextBox>
&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="fn" ErrorMessage="Frist Name's Empty"></asp:RequiredFieldValidator>
&nbsp;
    </p>
    <p style="margin-left: 80px">
&nbsp;LastName:&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="ln" runat="server" Height="31px" Width="205px" BackColor="#FFFFC0"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="Require" runat="server" ControlToValidate="ln" 
            ErrorMessage="last name is empty"></asp:RequiredFieldValidator>
    </p>
    <p style="margin-left: 80px">
        &nbsp;
        UserName:&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp;&nbsp; &nbsp;<asp:TextBox ID="uid" runat="server" Height="34px" Width="200px" BackColor="#FFFFC0"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="uid" ErrorMessage="UserId is Empty"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="uid"
            ErrorMessage="Invalid UserId" ForeColor="LawnGreen" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></p>
    <div>
    
    </div>
    <p style="margin-left: 80px">
&nbsp; Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;
        <asp:TextBox ID="pass" runat="server" Height="34px" Width="198px" BackColor="#FFFFC0"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ControlToValidate="pass" ErrorMessage="Password is Empty "></asp:RequiredFieldValidator></p>
        <p style="margin-left: 80px">
&nbsp;ConfrimPassword&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="cpass" runat="server" Height="34px" Width="196px" BackColor="#FFFFC0"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
            ControlToValidate="cpass" ErrorMessage="ConfrimPassword isEmpty"></asp:RequiredFieldValidator>
            &nbsp;
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="pass"
                ControlToValidate="cpass" ErrorMessage="Password Not Matched" ForeColor="LawnGreen"></asp:CompareValidator></p>
        <p>
            &nbsp;</p>
    <p style="margin-left: 80px">
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp;
        <asp:Button ID="submit" runat="server" Height="42px" Text="Submit" 
            Width="113px" BackColor="#C0FFC0" />
    </p>
    </form>
</body>
</html>
