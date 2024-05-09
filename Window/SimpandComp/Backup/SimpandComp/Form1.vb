Public Class Form1

    Dim prin, rt, tim, interest, amt As Double
    Dim result As String
    Dim no As Integer


    Private Sub sim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sim.Click
        prin = Val(princ.Text)
        rt = Val(rate.Text)
        tim = Val(Time.Text)
        interest = (prin * tim * rt) / 100
        result = interest.ToString

    End Sub

    Private Sub cmp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmp.Click
        prin = Val(princ.Text)
        rt = Val(rate.Text)
        tim = Val(Time.Text)
        interest = (prin * tim * rt) / 100
        amt = prin * Math.Pow((1.0 + rt / 100.0), tim) - prin


        result = amt.ToString

    End Sub

    Private Sub submit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles submit.Click
        res.Text = result

    End Sub
    
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        princ.Text = ""
        rate.Text = ""
        Time.Text = ""

    End Sub
End Class
