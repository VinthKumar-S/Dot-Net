Public Class Form1
    Dim name As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b1.Click
        name = t1.Text
        Me.Visible = False

        Dim frm As New ck(name)
        frm.Show()

    End Sub
End Class
