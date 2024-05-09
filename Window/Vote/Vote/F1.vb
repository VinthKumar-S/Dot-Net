Public Class F1


    Dim names() As String = {"Karthik", "Sandhya", "Shivangi", "Ashwitha", "Somnath"}
    Dim i As String

    Dim flag As Integer
    Public Sub New(ByVal src As String)
        flag = 0
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For Each i In names
            Disp.Text = Disp.Text + i + vbNewLine + "--------------" + vbNewLine
            If (i = src) Then
                flag = 1
            End If
        Next

        If flag = 1 Then
            st.Text = "Name is Found."
        Else
            st.Text = "Name is Not Found."
        End If
    End Sub

    Private Sub close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close.Click
        Me.Visible = False
        Form1.Visible = True
    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        If flag = 1 Then
            F2.Visible = True
        Else
            MessageBox.Show("Name Not Found.")
        End If
    End Sub
End Class