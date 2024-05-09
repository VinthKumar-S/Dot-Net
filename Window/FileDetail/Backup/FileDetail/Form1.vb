Public Class Form1

    Dim res, Destination, Source As String
    Dim fr As System.IO.StreamReader

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            OpenFileDialog1.InitialDirectory = "F:\Documents\Programing Languages"
            OpenFileDialog1.Title = "Open a Program file"
            'OpenFileDialog1.Filter = "Textt Files|*.java"
            FD.Text = OpenFileDialog1.FileName
            Destination = "Z:\D Lab\Window\FileDescribe\FC.txt"
            Source = OpenFileDialog1.FileName

            If System.IO.File.Exists(Source) = True Then

                Dim rd As New System.IO.StreamReader(Source)
                Do While rd.Peek() <> -1
                    res = res + rd.ReadLine() + vbNewLine
                Loop
                Disp.Text = res

                System.IO.File.Copy(Source, Destination)
                MessageBox.Show("File Copied")

            End If
        End If

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Disp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Disp.TextChanged

    End Sub
End Class
