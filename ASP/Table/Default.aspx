<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
<center> 
    <form id="form1" runat="server">
    <div id="lbl">
        <br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; Row: &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp;<asp:TextBox ID="tr" runat="server"></asp:TextBox><br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; Column: &nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="tc" runat="server"></asp:TextBox><br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<br />
        &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:CheckBox ID="ck" runat="server" Text="Enable Border" />
        &nbsp;<br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp;
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; <asp:Button ID="yes"
            runat="server" Text="yes" />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:Button ID="clear" runat="server" Text="clear" /><br />
        <br />
        <br />
        <asp:Label ID="lb" runat="server" Text="Label"></asp:Label>
        <asp:Table ID="tb" runat="server">
        </asp:Table>
    </div>
    </form>
    </center>
</body>
</html>
