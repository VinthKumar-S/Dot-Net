<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="background-image: url(back.jpg); background-repeat:no-repeat; background-attachment: fixed;  background-position:center; width=100px; height:200px;">
<center>
    <form id="form1" runat="server">
    <div>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp;<h1 style="color: #66ff66; font-family: Aharoni"> Flowers</h1><br />
        &nbsp;<br />
        <asp:Image ID="Image1" runat="server" Height="500px" ImageUrl="p1.jpeg" Width="500px" />
        <asp:Image ID="Image2" runat="server" Height="500px" ImageUrl="p2.jpeg" Width="500px" />
        <br />
        <asp:Image ID="Image3" runat="server" Height="500px" ImageUrl="p3.jpg" Width="500px" />
        <asp:Image ID="Image4" runat="server" Height="500px" ImageUrl="p4.jpg" Width="500px" /></div>
    </form>
    </center>
</body>
</html>
