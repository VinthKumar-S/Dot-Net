Imports arithclass.Class1
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim c As Integer
        Dim d As Integer
        Dim obj As New arithclass.Class1
        c = Val(TextBox1.Text)
        d = Val(TextBox2.Text)
        TextBox3.Text = obj.add(c, d)
    End Sub
End Class
