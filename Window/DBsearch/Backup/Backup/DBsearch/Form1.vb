Imports System.Data.OleDb
Imports System.Data

Public Class Form1
    Dim mycon As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim read As System.Data.OleDb.OleDbDataReader
    Dim src As String

    Private Sub disp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles disp.Click
        mycon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Z:\D Lab\Window\DG.mdb"
        cmd.Connection = mycon
        mycon.Open()
        cmd.CommandText = "select*from search"
        cmd.ExecuteNonQuery()
        read = cmd.ExecuteReader
        While read.Read
            list1.Items.Add(read(2))
            list2.Items.Add(read(1))
        End While
        read.Close()
        mycon.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mycon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Z:\D Lab\Window\DG.mdb"
        cmd.Connection = mycon
        mycon.Open()
        src = t11.Text
        cmd.CommandText = "select*from search where pname='" + src + "'"
        cmd.ExecuteNonQuery()
        read = cmd.ExecuteReader
        If read.Read Then
            res.Text = read(2)
        Else
            MsgBox("No Student.")
        End If

    End Sub
End Class
