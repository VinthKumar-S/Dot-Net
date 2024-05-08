
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles yes.Click
        Dim a, f, i As Integer
        f = 1
        a = Val(txt1.Text)
        For i = 1 To a
            f = f * i
        Next
        txt2.Text = f


    End Sub

    Protected Sub clear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles clear.Click
        Dim c As String
        c = ""
        txt1.Text = c
        txt2.Text = c

    End Sub
End Class
