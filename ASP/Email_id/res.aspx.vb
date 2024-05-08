
Partial Class res
    Inherits System.Web.UI.Page

    Protected Sub back_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles back.Click
        Response.Redirect("Default.aspx")
    End Sub
End Class
