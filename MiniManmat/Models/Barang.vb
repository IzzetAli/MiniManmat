Imports System.Data.Odbc
Imports System.Runtime.CompilerServices.RuntimeHelpers

Public Class Barang
    Public Kode_Barang As String
    Public Nama_Barang As String
    Public Harga_Barang As Integer
    Public Jumlah_Barang As String
    Public Satuan_Barang As String
    Sub Save()
        Call Connection()
        Dim inputData As String = "insert into tbl_Barang value ( '" & Kode_Barang & "','" & Nama_Barang & "','" & Harga_Barang & "','" & Jumlah_Barang & "','" & Satuan_Barang & "')"
        Cmd = New OdbcCommand(inputData, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
    Sub Edit()
        Call Connection()
        Dim UpdateData As String = "Update tbl_barang set Nama_Barang='" & Nama_Barang & "',Harga_Barang='" & Harga_Barang & "',Jumlah_Barang='" & Jumlah_Barang & "',Satuan_Barang='" & Satuan_Barang & "' where Kode_Barang='" & Kode_Barang & "'"
        Cmd = New OdbcCommand(UpdateData, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
    Sub Delete()
        Call Connection()
        Dim DeleteData As String = "Delete from tbl_admin where Kode_Admin='" & Kode_Barang & "'"
        Cmd = New OdbcCommand(DeleteData, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
    Public Shared Sub SaveDetail(ByVal No_Jual As String, ByVal Kode_Barang As String, ByVal Nama_Barang As String, ByVal Harga_Jual As Integer, ByVal Jumlah_Jual As Integer, ByVal Sub_Total As Integer)
        Dim SimpanDitail As String = "Insert into tbl_detailjual value('" & No_Jual & "', '" & Kode_Barang & "','" & Nama_Barang & "','" & Harga_Jual & "','" & Jumlah_Jual & "','" & Sub_Total & "')"
        Cmd = New OdbcCommand(SimpanDitail, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
    Public Shared Sub SelectKode(ByVal Kode_Barang As String)
        Cmd = New OdbcCommand("Select * from tbl_barang where Kode_Barang='" & Kode_Barang & "'", Conn)
        DR = Cmd.ExecuteReader
        DR.Read()
    End Sub
    Public Shared Sub KurangiStokBarang(ByVal Jumlah_Barang As Integer, ByVal Kode_Barang As String)
        Dim KurangiStok As String = "Update tbl_barang set Jumlah_Barang = '" & DR.Item("Jumlah_Barang") - Jumlah_Barang & "' where Kode_Barang='" & Kode_Barang & "'"
        Cmd = New OdbcCommand(KurangiStok, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
End Class
