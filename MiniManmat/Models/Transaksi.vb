Imports System.Data.Odbc

Public Class Transaksi
    Public No_Jual As String
    Public Tgl_Jual As String
    Public Jam_Jual As String
    Public Item_Jual As Integer
    Public Total_Jual As Integer
    Public Dibayar As Integer
    Public Kembali As Integer
    Public Kode_Pelanggan As String
    Public Kode_Admin As String
    Sub SaveDB()
        Call Connection()
        Dim SimpanJual As String = "Insert into tbl_jual values ('" & No_Jual & "', '" & Tgl_Jual & "', '" &
            Jam_Jual & "', '" & Item_Jual & "', '" & Total_Jual & "', '" & Dibayar & "', '" & Kembali & "', '" & Kode_Pelanggan & "', '" & Kode_Admin & "')"
        Cmd = New OdbcCommand(SimpanJual, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
End Class
