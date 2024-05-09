Imports System.Data.OleDb
Imports System.Data

Public Class Form1
    Dim mycon As New OleDbConnection
    Dim cmd As New OleDbCommand
    'Dim read As New System.Data.OleDb.OleDbDataReader

    Private Sub Insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insert.Click
        mycon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Z:\D Lab\Window\DG.mdb"
        cmd.Connection = mycon
        mycon.Open()
        cmd.CommandText = "insert into zoo values('lion')"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "insert into zoo values('Deer')"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "insert into zoo values('Tiger')"
        cmd.ExecuteNonQuery()
        mycon.Close()
        MsgBox("Data Inseted")
    End Sub

    Private Sub create_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles create.Click
        mycon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Z:\D Lab\Window\DG.mdb"
        cmd.Connection = mycon
        cmd.CommandText = "create table zoo(aname varchar(30))"
        mycon.Open()
        cmd.ExecuteNonQuery()
        mycon.Close()
        MsgBox("Table Create.")
    End Sub

    
    
End Class
