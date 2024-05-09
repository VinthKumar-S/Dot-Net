Imports EB_Bill_calculation_class
Public Class Form1
    Private Sub btnCalculate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCalculate.Click
        Dim totalUnitsUse As Double = Double.Parse(txtTotalUnits.Text)
        Dim thisMonthUnitsUse As Double = Double.Parse(txtThisMonthUnits.Text)
        Dim billCalculator As New ElectricityBillCalculator(totalUnitsUse, thisMonthUnitsUse)
        Dim billAmount As Double = billCalculator.CalculateBillAmount()
        lblBillAmount.Text = "Rs. " + billAmount.ToString()
    End Sub

    Private Sub txtTotalUnits_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalUnits.TextChanged

    End Sub
End Class
