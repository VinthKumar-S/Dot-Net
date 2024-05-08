
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dd.Text = caln.TodaysDate
        Time.Text = Date.Now.TimeOfDay.ToString
    End Sub

    Protected Sub Calendar1_DayRender(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DayRenderEventArgs) Handles caln.DayRender
        If e.Day.IsOtherMonth Then
            e.Day.IsSelectable = False
        End If
        If e.Day.Date.Day = Val(Dt.Text) And e.Day.Date.Month = Val(Mth.Text) Then
            Dim lb As New Label
            Dim b As String
            b = "Birthday."
            e.Cell.BackColor = Drawing.Color.Green
            lb.Text = "<br>" & nm.Text & "<br>" & b
            e.Cell.Controls.Add(lb)

        End If

    End Sub

    Protected Sub n1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nm.TextChanged

    End Sub
End Class
