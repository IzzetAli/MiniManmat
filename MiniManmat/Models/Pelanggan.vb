Imports System.Data.Odbc

Public Class Pelanggan
    Public Kode_Pelanggan As String
    Public Nama_Pelanggan As String
    Public Alamat_Pelanggan As String
    Public Telpon_Pelanggan As String
    Sub Save()
        Call Connection()
        Dim inputData As String = "insert into tbl_Pelanggan value ( '" & Kode_Pelanggan & "','" & Nama_Pelanggan & "','" & Alamat_Pelanggan & "','" & Telpon_Pelanggan & "')"
        Cmd = New OdbcCommand(inputData, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
    Sub Edit()
        Call Connection()
        Dim UpdateData As String = "Update tbl_Pelanggan set Nama_Pelanggan='" & Nama_Pelanggan & "',Alamat_Pelanggan='" & Alamat_Pelanggan & "',Telpon_Pelanggan='" & Telpon_Pelanggan & "' Where Kode_Pelanggan='" & Kode_Pelanggan & "'"
        Cmd = New OdbcCommand(UpdateData, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
    Sub Delete()
        Call Connection()
        Dim HapusData As String = "Delete  from tbl_Pelanggan where Kode_Pelanggan='" & Kode_Pelanggan & "'"
        Cmd = New OdbcCommand(HapusData, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
End Class
