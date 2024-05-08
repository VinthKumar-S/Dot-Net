
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub yes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles yes.Click
        Dim No, M1, M2, M3, M4, M5, totl As Integer
        Dim av As Double
        Dim grad As String
        No = Val(txt2.Text)
        rd.Text = No
        M1 = Val(txt3.Text)
        M2 = Val(txt4.Text)
        M3 = Val(txt5.Text)
        M4 = Val(txt6.Text)
        M5 = Val(txt7.Text)
        totl = M1 + M2 + M3 + M4 + M5
        av = totl / 5
        tot.Text = totl
        avg.Text = av
        If (M1 > 30 And M2 > 30 And M3 > 30 And M4 > 30 And M5 > 30) Then
            If (av >= 80) Then
                grad = "A"
            End If
            If (av <= 80 And av >= 60) Then
                grad = "B"
            End If
            If (av <= 60 And av >= 40) Then
                grad = "C"
            End If
            If (av <= 40) Then
                grad = "D"
            End If
        Else
            grad = "your Faild"
        End If
        grade.Text = grad
    End Sub

    Protected Sub clean_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles clean.Click
        Dim c As String
        c = ""
        txt2.Text = c
        txt3.Text = c
        txt4.Text = c
        txt5.Text = c
        txt6.Text = c
        txt7.Text = c
        tot.Text = c
        avg.Text = c
        grade.Text = c
        rd.Text = c

    End Sub
End Class
