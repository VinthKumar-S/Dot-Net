<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp;&nbsp; STUDENT
        MARKLIST<br />
        <br />
        RollNo &nbsp;&nbsp;
        <asp:TextBox ID="txt2" runat="server"></asp:TextBox><br />
        <br />
        Mark1 &nbsp; &nbsp;
        <asp:TextBox ID="txt3" runat="server"></asp:TextBox><br />
        <br />
        Mark2 &nbsp;&nbsp; &nbsp;<asp:TextBox ID="txt4" runat="server"></asp:TextBox><br />
        <br />
        Mark3 &nbsp;&nbsp;
        <asp:TextBox ID="txt5" runat="server"></asp:TextBox><br />
        <br />
        Mark4 &nbsp;&nbsp; &nbsp;<asp:TextBox ID="txt6" runat="server"></asp:TextBox><br />
        <br />
        Mark5 &nbsp;&nbsp;
        <asp:TextBox ID="txt7" runat="server"></asp:TextBox><br />
        <br />
        <asp:Button ID="yes" runat="server" Text="Submit" />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Button ID="clean" runat="server" Text="Close" /><br />
        <br />
        &nbsp; RollNo: &nbsp;&nbsp; &nbsp;<asp:TextBox ID="rd" runat="server"></asp:TextBox><br />
        <br />
        &nbsp;
        Total: &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:TextBox ID="tot" runat="server"></asp:TextBox>
        &nbsp; Average:&nbsp;
        <asp:TextBox ID="avg" runat="server"></asp:TextBox>
        &nbsp;Grade:
        <asp:TextBox ID="grade" runat="server"></asp:TextBox><br />
    </div>
    </form>
</body>
</html>
