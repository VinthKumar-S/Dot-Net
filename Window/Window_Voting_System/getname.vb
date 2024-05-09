Public Class getname
    Public _name, j, k As String
    Dim flag As Integer = 0
    Dim names() As String = {"sarathi", "kannan", "sanjy", "vetri", "mani"}
    Dim voted(5) As String
    Dim i As Integer = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        _name = t1.Text
        For Each k In voted
            If (k = _name) Then
                flag = 1
            End If
        Next
        If (flag = 0) Then
            For Each j In names
                If (j = _name) Then
                    flag = 1
                End If
            Next

            If flag = 1 Then
                If (i <= 5) Then
                    voted(i) = _name
                    i += 1
                Else
                    MsgBox("cannot able to Vote.")
                    Me.Visible = False
                    Form1.Visible = True
                End If
                Me.Visible = False
                votepage.Visible = True
            Else
                MsgBox("invalid Name")
                Me.Visible = False
                Form1.Visible = True
            End If
            Me.Visible = False
        Else
            MsgBox("You are already voted")
            Me.Visible = False
            Form1.Visible = True

        End If

    End Sub
End Class