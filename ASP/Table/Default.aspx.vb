
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tb.BorderStyle = BorderStyle.Solid
        tb.BorderColor = Drawing.Color.Black
        tb.BorderWidth = Unit.Pixel(1)
        lb.Visible = False
    End Sub

    Protected Sub clear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles clear.Click
        tr.Text = ""
        tc.Text = ""
        ck.Checked = False
    End Sub

    Protected Sub yes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles yes.Click
        lb.Visible = True
        tb.Controls.Clear()
        lb.Text = "Table"
        Dim i, j As Integer
        For i = 0 To Val(tr.Text)
            Dim r As New TableRow
            For j = 0 To Val(tr.Text)
                tb.Controls.Add(r)
            Next
            For j = 0 To Val(tc.Text)
                Dim c As New TableCell
                c.Text = "" & i & "," & j & ""
                If ck.Checked = True Then
                    c.BorderStyle = BorderStyle.Solid
                    c.BorderColor = Drawing.Color.Black
                    c.BorderWidth = Unit.Pixel(1)
                End If
                r.Controls.Add(c)
            Next
        Next
    End Sub
End Class
