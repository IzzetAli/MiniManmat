Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine

Public Class FormTransaksi
    Sub KondisiAwal()
        lblNamapg.Text = ""
        lblAlamat.Text = ""
        lblTelepon.Text = ""
        lblTanggal.Text = Today
        lblAdmin.Text = FormMenuUtama.STLabel4.Text
        lblKembali.Text = ""
        txtkode.Text = ""
        lblNama.Text = ""
        lblHarga.Text = ""
        txtJumlah.Text = ""
        txtJumlah.Enabled = False
    End Sub
    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call Muncul_Kode_Pelanggan()
        Call No_Otomatis()
        lblTotal.Text = "0"
    End Sub

    Sub Muncul_Kode_Pelanggan()
        Call Connection()
        Cmd = New OdbcCommand("Select * from tbl_pelanggan", Conn)
        DR = Cmd.ExecuteReader
        Do While DR.Read
            CmbPelanggan.Items.Add(DR.Item(0))
        Loop
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblJam.Text = TimeOfDay
    End Sub

    Private Sub CmbPelanggan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPelanggan.SelectedIndexChanged
        Call Connection()
        Cmd = New OdbcCommand("Select * From tbl_pelanggan where Kode_Pelanggan = '" & CmbPelanggan.Text & "'", Conn)
        DR = Cmd.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            lblNamapg.Text = DR!Nama_Pelanggan
            lblAlamat.Text = DR!Alamat_Pelanggan
            lblTelepon.Text = DR!Telpon_Pelanggan
        End If
    End Sub
    Sub No_Otomatis()
        Cmd = New OdbcCommand("Select * from tbl_jual where No_jual in (select max(No_Jual) from tbl_jual)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        DR = Cmd.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            UrutanKode = "J" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 9) + 1
            UrutanKode = "J" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        lblNojual.Text = UrutanKode
    End Sub

    Private Sub txtkode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Connection()
            Cmd = New OdbcCommand("Select * From tbl_Barang where Kode_Barang='" & txtkode.Text & "'", Conn)
            DR = Cmd.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                MsgBox("Kde Barang Tidak Ada Kawan!!")
            Else
                txtkode.Text = DR.Item("Kode_Barang")
                lblNama.Text = DR.Item("Nama_Barang")
                lblHarga.Text = DR.Item("Harga_Barang")
                txtJumlah.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If lblNama.Text = "" Or txtJumlah.Text = "" Then
            MsgBox("Silahkan Masukkan Kode Barang Dan Tekan ENTER KAWAN!!!")
        Else
            DgvTransaksi.Rows.Add(New String() {txtkode.Text, lblNama.Text, lblHarga.Text, txtJumlah.Text, Val(lblHarga.Text) * Val(txtJumlah.Text)})
            Call RumusSubtotal()
            txtkode.Text = ""
            lblNama.Text = ""
            lblHarga.Text = ""
            txtJumlah.Text = ""
            txtJumlah.Enabled = False
            Call RumusCariItem()

        End If
    End Sub
    Sub RumusSubtotal()
        Dim Hitung As Integer = 0
        For i As Integer = 0 To DgvTransaksi.Rows.Count - 1
            Hitung = Hitung + DgvTransaksi.Rows(i).Cells(4).Value
            lblTotal.Text = Hitung
        Next
    End Sub
    Private Sub txtBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(txtBayar.Text) < Val(lblTotal.Text) Then
                MsgBox("Pembayaran Kurang")
            ElseIf Val(txtBayar.Text) = Val(lblTotal.Text) Then
                lblKembali.Text = 0
            ElseIf Val(txtBayar.Text) > Val(lblTotal.Text) Then
                lblKembali.Text = Val(txtBayar.Text) - Val(lblTotal.Text)
                btnSimpan.Focus()

            End If
        End If
    End Sub

    Sub RumusCariItem()
        Dim HitungItem As Integer = 0
        For i As Integer = 0 To DgvTransaksi.Rows.Count - 1
            HitungItem = HitungItem + DgvTransaksi.Rows(i).Cells(3).Value
            LblItem.Text = HitungItem

        Next
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call Connection()
        If lblKembali.Text = "" Or lblNamapg.Text = "" Or lblTotal.Text = "" Then
            MsgBox("Transaksi Tidak Ada, Silahkan Lakukan Transaksi Terlebih Dahulu!")
        Else
            Dim TglOdbc = Format(Today, "yyyy-MM-dd")
            Dim SimpanJual As String = "Insert into tbl_jual values ('" & lblNojual.Text & "', '" & TglOdbc & "', '" & lblJam.Text & "', '" & LblItem.Text & "', '" & Label17.Text & "', '" & txtBayar.Text & "', '" & lblKembali.Text & "', '" & CmbPelanggan.Text & "', '" & FormMenuUtama.STLabel2.Text & "')"
            Cmd = New OdbcCommand(SimpanJual, Conn)
            Cmd.ExecuteNonQuery()
            For Baris As Integer = 0 To DgvTransaksi.Rows.Count - 2
                Dim SimpanDitail As String = "Insert into tbl_detailjual value('" & lblNojual.Text & "', '" & DgvTransaksi.Rows(Baris).Cells(0).Value & "','" & DgvTransaksi.Rows(Baris).Cells(1).Value & "','" & DgvTransaksi.Rows(Baris).Cells(2).Value & "','" & DgvTransaksi.Rows(Baris).Cells(3).Value & "','" & DgvTransaksi.Rows(Baris).Cells(4).Value & "')"
                Cmd = New OdbcCommand(SimpanDitail, Conn)
                Cmd.ExecuteNonQuery()
                Cmd = New OdbcCommand("Select * from tbl_barang where Kode_Barang='" & DgvTransaksi.Rows(Baris).Cells(0).Value & "'", Conn)
                DR = Cmd.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    Dim KurangiStok As String = "Update tbl_barang set Jumlah_Barang = '" & DR.Item("Jumlah_Barang") - DgvTransaksi.Rows(Baris).Cells(3).Value & "' where Kode_Barang='" & DgvTransaksi.Rows(Baris).Cells(0).Value & "'"
                    Cmd = New OdbcCommand(KurangiStok, Conn)
                    Cmd.ExecuteNonQuery()
                End If
            Next

            If MessageBox.Show("Apakah Ingin Cektak Faktur...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim Lap As New ReportDocument
                Lap.Load("..\..\CRV.rpt")
                CetakLpPenjualan.CrystalReportViewer1.SelectionFormula = "Totext({tbl_jual1.No_Jual})= '" & lblNojual.Text & "'"
                CetakLpPenjualan.CrystalReportViewer1.ReportSource = Lap
                CetakLpPenjualan.Show()
            Else
                Call KondisiAwal()
                MsgBox("Transaksi Berhasil Disimpan!")

            End If

        End If
    End Sub


End Class