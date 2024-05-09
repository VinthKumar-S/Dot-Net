Public Class Form1

    Dim res, Destination, Source As String
    Dim FLen As String


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            OpenFileDialog1.InitialDirectory = "F:\Documents\Programing Languages"
            OpenFileDialog1.Title = "Open a Program file"
            'OpenFileDialog1.Filter = "Textt Files|*.java"
            F.Text = OpenFileDialog1.FileName
            Destination = "F:\Documents\Programing Languages\Dot Net\Programs\Window\FC.txt"
            Source = OpenFileDialog1.FileName
            Dim infoReader As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName)
            FLen = infoReader.Length.ToString
            Disp.Text = "FileLength:" + "                        " + FLen + vbNewLine + vbNewLine + "FileName:" + "                          " + infoReader.Name + vbNewLine + vbNewLine + "FileExtention:" + "                    " + infoReader.Extension + vbNewLine + vbNewLine + "FileLastTimeAccess:" + "         " + infoReader.LastAccessTime + vbNewLine + vbNewLine + "FileLastWritentime:" + "           " + infoReader.LastWriteTime + vbNewLine + vbNewLine

        End If

    End Sub

   
    
End Class
