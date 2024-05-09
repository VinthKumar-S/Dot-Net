Public Class Form1

    Dim main, ch, temp, disp As String
    Dim v1, v2, v3 As Double

    Private Sub n0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles n0.Click

        t1.Text = t1.Text + "0"
    End Sub

    Private Sub n1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles n1.Click

        t1.Text = t1.Text + "1"
    End Sub

    Private Sub n2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles n2.Click

        t1.Text = t1.Text + "2"
    End Sub

    Private Sub n3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles n3.Click

        t1.Text = t1.Text + "3"
    End Sub

    Private Sub n4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles n4.Click

        t1.Text = t1.Text + "4"
    End Sub

    Private Sub n5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles n5.Click

        t1.Text = t1.Text + "5"
    End Sub

    Private Sub n6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles n6.Click

        t1.Text = t1.Text + "6"
    End Sub

    Private Sub n7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles n7.Click

        t1.Text = t1.Text + "7"
    End Sub

    Private Sub n8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles n8.Click

        t1.Text = t1.Text + "8"
    End Sub

    Private Sub n9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles n9.Click

        t1.Text = t1.Text + "9"
    End Sub

    Private Sub div_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles div.Click
        disp = Val(t1.Text)
        l1.Text = disp
        main = disp
        ch = "/"
        t1.Text = ""
    End Sub

    Private Sub equal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles equal.Click

        v1 = Val(main)
        disp = Val(t1.Text)
        v2 = Val(disp)

        Select Case ch
            Case "+"
                v3 = v1 + v2
                t1.Text = v3
            Case "-"
                v3 = v1 - v2
                t1.Text = v3
            Case "*"
                v3 = v1 * v2
                t1.Text = v3
            Case "/"
                v3 = v1 / v2
                t1.Text = v3
            Case "%"
                v3 = v1 Mod v2
                t1.Text = v3
                Exit Select
        End Select
    End Sub

    Private Sub min_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles min.Click
        disp = Val(t1.Text)
        l1.Text = disp
        main = disp
        ch = "-"
        t1.Text = ""
    End Sub

    Private Sub mod1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mod1.Click
        disp = Val(t1.Text)
        l1.Text = disp
        main = disp
        ch = "%"
        t1.Text = ""
    End Sub

    Private Sub muti_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles muti.Click
        disp = Val(t1.Text)
        l1.Text = disp
        main = disp
        ch = "*"
        t1.Text = ""
    End Sub

    Private Sub plus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles plus.Click
        disp = Val(t1.Text)
        l1.Text = disp
        main = disp
        ch = "+"
        t1.Text = ""
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        t1.Text = ""
    End Sub

    Private Sub Dot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dot.Click
        t1.Text = t1.Text + "."
    End Sub
End Class
