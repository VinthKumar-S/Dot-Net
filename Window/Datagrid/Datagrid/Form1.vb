Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DGDataSet1.DC1' table. You can move, or remove it, as needed.
        Me.DC1TableAdapter1.Fill(Me.DGDataSet1.DC1)
        'TODO: This line of code loads data into the 'DGDataSet.DC1' table. You can move, or remove it, as needed.
        Me.DC1TableAdapter.Fill(Me.DGDataSet.DC1)

    End Sub
End Class
