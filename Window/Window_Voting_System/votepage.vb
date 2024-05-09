Public Class votepage
    Dim s As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If RadioButton1.Checked Then
            display.admk += 1
            s = 1
        ElseIf RadioButton2.Checked Then
            display.dmk += 1
            s = 1
        ElseIf RadioButton3.Checked Then
            display.bjb += 1
            s = 1
        ElseIf RadioButton4.Checked Then
            display.abc += 1
            s = 1
        Else
            s = 0
        End If
        If (s = 1) Then
            MsgBox("Vote is Recored.")
            Me.Visible = False
            Form1.Visible = True
        Else
            MsgBox("Vote is Not Recored.")
        End If

    End Sub
End Class