Public Class ck

    Public Function calc(ByVal unit As Integer)
        Dim result, temp As Double
        If unit <= 100 Then
            result = 0
        ElseIf unit <= 200 Then
            temp = unit - 100
            result = temp * 1.5

        ElseIf unit <= 500 Then
            temp = unit - 100
            If temp <= 200 Then
                result = temp * 3.5
            ElseIf temp <= 500 Then
                result = temp * 4.6
            End If

        ElseIf unit > 500 Then
            temp = unit - 100
            result = temp * 6.6
        End If
        Return result
    End Function
End Class
