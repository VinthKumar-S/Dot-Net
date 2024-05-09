Public Class display
    Public admk, dmk, bjb, abc As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Visible = False
        Form1.Visible = True
    End Sub

    Private Sub display_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label5.Text = admk
        Label6.Text = dmk
        Label7.Text = bjb
        Label8.Text = abc
    End Sub
End Class