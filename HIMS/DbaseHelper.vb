'written by:Nura

Imports System.Data.SqlClient
Imports System.Data

Module DbaseHelper

    Private Function checkID(ByVal ID As Int32)
        Dim con As SqlConnection
        Dim cmd As SqlCommand
        Dim connection As String
        connection = "DRIVER=sql server;server=NEO;UID=sa;PWD=root;database=ghgl"
        con = New SqlConnection(connection)
        con.Open()
        cmd = New SqlCommand("select * from 用户表 where id=" + ID)
        cmd.ExecuteNonQuery()
        Console.WriteLine("Success!")
        Dim dt As DataTable
        Dim dr As SqlDataReader
        dt = New DataTable

    End Function

End Module