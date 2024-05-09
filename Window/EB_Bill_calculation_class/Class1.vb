Public Class ElectricityBillCalculator
    Private PreivousUnitsUse As Double
    Private thisMonthUnitsUse As Double

    Public Sub New(ByVal totalUnitsUse As Double, ByVal thisMonthUnitsUse As Double)
        Me.PreivousUnitsUse = totalUnitsUse
        Me.thisMonthUnitsUse = thisMonthUnitsUse
    End Sub

    Public Function CalculateBillAmount() As Double
        Dim units = thisMonthUnitsUse - PreivousUnitsUse
        Dim billAmount As Double = 0

        If units <= 100 Then
            billAmount = 0 'free of cost'
        ElseIf units > 100 And units <= 200 Then
            billAmount = (units - 100) * 1.5 'for balance rs.1.5 per unit'
        ElseIf units > 200 And units <= 500 Then
            billAmount = 100 * 0 'first 100 units free'
            billAmount = billAmount + (100 * 2) 'for next 100 rs.2 per unit'
            billAmount = billAmount + ((units - 200) * 3) 'for balance rs.3 per unit'
        ElseIf units > 500 Then
            billAmount = 100 * 0 'first 100 units free'
            billAmount = billAmount + (100 * 3.5) 'for next 100 rs.3.5 per unit'
            billAmount = billAmount + (300 * 4.6) 'next 201-500 rs.4.6 per unit'
            billAmount = billAmount + ((units - 500) * 6.6) '>500 rs.6.6 per unit'
        End If
        Return billAmount
    End Function
End Class
