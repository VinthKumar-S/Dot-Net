
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Response.Redirect("sec.aspx")
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        dob.Text = ""
        emal.Text = ""
        fname.Text = ""
        ins.Text = ""
        mname.Text = ""
        name.Text = ""
        percent.Text = ""
        Phone.Text = ""
    End Sub
End Class
