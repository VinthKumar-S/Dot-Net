Public Class adminlogin
    Dim username, password As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        username = t1.Text
        password = t2.Text
        If (username = "sarathi" And password = "1234") Then
            display.Show()
            Me.Visible = False
        Else
            MsgBox("Invalid User")
            t1.Text = ""
            t2.Text = ""
        End If
    End Sub
End Class