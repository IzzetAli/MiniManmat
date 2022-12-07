Imports System.Data.Odbc
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Module Module1
    Public Conn As OdbcConnection
    Public Da As OdbcDataAdapter
    Public Ds As DataSet
    Public DR As OdbcDataReader
    Public Cmd As OdbcCommand
    Public MyDB As String
    '=========================================================================================
    Public Rpt As New ReportDocument
    Public crtableLogoninfos As New TableLogOnInfos
    Public crtableLogoinfo As New TableLogOnInfo
    Public crConnectinInfo As New ConnectionInfo
    Public CrTables As Tables

    Public Sub Connection()
        MyDB = "Driver={Mysql ODBC 3.51 Driver};Database=dbpenjualan;server=localhost;uid=root"
        Conn = New OdbcConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
End Module
