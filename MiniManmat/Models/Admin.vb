Imports System.Data.Odbc
Imports System.Runtime.CompilerServices.RuntimeHelpers

Public Class Admin
    Public Kode_Admin As String
    Public Nama_Admin As String
    Public Password_Admin As String
    Public Level_Admin As String
    Sub Save()
        Call Connection()
        Dim InputData As String = " Insert into tbl_admin value('" & Kode_Admin & "','" & Nama_Admin & "','" & Password_Admin & "','" & Level_Admin & "')"
        Cmd = New OdbcCommand(InputData, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
    Sub Edit()
        Call Connection()
        Dim UpdateDate As String = "Update tbl_admin Set Nama_Admin='" & Nama_Admin & "',Password_Admin='" & Password_Admin & "',Level_Admin='" & Level_Admin & "' where Kode_Admin='" & Kode_Admin & "'"
        Cmd = New OdbcCommand(UpdateDate, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
    Sub Delete()
        Call Connection()
        Dim DeleteData As String = "Delete from tbl_admin where Kode_Admin='" & Kode_Admin & "'"
        Cmd = New OdbcCommand(DeleteData, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
    Sub Close()
        Call Reset()
    End Sub
End Class
