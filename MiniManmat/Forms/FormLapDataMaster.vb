Imports CrystalDecisions.CrystalReports.Engine

Public Class FormLapDataMaster
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click

    End Sub

    Private Sub FormLapDataMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Dim Lap As New ReportDocument
        Lap.Load("..\..\CRV.rpt")
        Lap.SetParameterValue("dt1", Dtp_1.Text)
        Lap.SetParameterValue("dt2", Dtp_2.Text)
        CetakLpPenjualan.CrystalReportViewer1.ReportSource = Lap
        CetakLpPenjualan.Show()
    End Sub
End Class