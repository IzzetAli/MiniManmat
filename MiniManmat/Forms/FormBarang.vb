Imports System.Data.Odbc

Public Class FormBarang
    Sub Reset()
        TxtCode.Text = ""
        TxtName.Text = ""
        TxtHarga.Text = ""
        TxtJumlah.Text = ""
        CmbSatuan.Items.Clear()
        CmbSatuan.Text = ""
        TxtCode.Enabled = False
        TxtName.Enabled = False
        TxtHarga.Enabled = False
        TxtJumlah.Enabled = False
        CmbSatuan.Enabled = False
        IcbSave.Enabled = True
        IcbEdit.Enabled = True
        IcbDelete.Enabled = True
        IcbClose.Enabled = True
        IcbSave.Text = "Insert"
        IcbEdit.Text = "Edit"
        IcbDelete.Text = "Delete"
        IcbClose.Text = "Close"
        Call Connection()
        Da = New OdbcDataAdapter("select * from tbl_barang", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_barang")
        DataGridView1.DataSource = Ds.Tables("tbl_barang")
        DataGridView1.ReadOnly = True
    End Sub
    Sub AutoNumbers()
        Cmd = New OdbcCommand("select * from tbl_Barang where Kode_Barang in (select max(Kode_Barang) from tbl_Barang)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        DR = Cmd.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            UrutanKode = "BRG" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 3) + 1
            UrutanKode = "BRG" + Microsoft.VisualBasic.Right("000" & Hitung, 3)

        End If
        TxtCode.Text = UrutanKode
    End Sub
    Sub ReadyTofill()
        TxtCode.Enabled = True
        TxtName.Enabled = True
        TxtHarga.Enabled = True
        TxtJumlah.Enabled = True
        CmbSatuan.Enabled = True
        CmbSatuan.Items.Add("PCS")
        CmbSatuan.Items.Add("DUS")
    End Sub

    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()

    End Sub


    Private Sub IcbSave_Click(sender As Object, e As EventArgs) Handles IcbSave.Click
        If IcbSave.Text = "Insert" Then
            IcbSave.Text = "Simpan"
            IcbEdit.Text = False
            IcbDelete.Enabled = False
            IcbClose.Text = "Batal"
            Call ReadyTofill()
            Call AutoNumbers()
            TxtCode.Enabled = False
            TxtName.Focus()

        Else

            If TxtCode.Text = "" Or TxtName.Text = "" Or CmbSatuan.Text = "" Or TxtHarga.Text = "" Then
                MsgBox("Pleasse fill in all fielde")
            Else
                Call Connection()
                Dim inputData As String = "insert into tbl_Barang value ( '" & TxtCode.Text & "','" & TxtName.Text & "','" & TxtHarga.Text & "','" & TxtJumlah.Text & "','" & CmbSatuan.Text & "')"
                Cmd = New OdbcCommand(inputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("save data successfullyl")
                Call Reset()
            End If
        End If
    End Sub

    Private Sub IcbEdit_Click(sender As Object, e As EventArgs) Handles IcbEdit.Click
        If IcbEdit.Text = "Edit" Then
            IcbEdit.Text = "Simpan"
            IcbSave.Enabled = False
            IcbDelete.Enabled = False
            IcbClose.Text = "Batal"
            Call ReadyTofill()
        Else

            If TxtCode.Text = "" Or TxtName.Text = "" Or CmbSatuan.Text = "" Or TxtHarga.Text = "" Then
                MsgBox("Please fill in all fields")
            Else
                Call Connection()
                Dim UpdateData As String = "Update tbl_barang set Nama_Barang='" & TxtName.Text & "',Harga_Barang='" & TxtHarga.Text & "',Jumlah_Barang='" & TxtJumlah.Text & "',Satuan_Barang='" & CmbSatuan.Text & "' where Kode_Barang='" & TxtCode.Text & "'"
                Cmd = New OdbcCommand(UpdateData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Update data successfullyl")
                Call Reset()
            End If
        End If
    End Sub
    Private Sub TxtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Connection()
            Cmd = New OdbcCommand("Select * From tbl_Barang where Kode_Barang='" & TxtCode.Text & "'", Conn)
            DR = Cmd.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                MsgBox("Admin Kode Does Not Exist!!")
            Else
                TxtCode.Text = DR.Item("Kode_Barang")
                TxtName.Text = DR.Item("Nama_Barang")
                TxtHarga.Text = DR.Item("Harga_Barang")
                TxtJumlah.Text = DR.Item("Jumlah_Barang")
                CmbSatuan.Text = DR.Item("Satuan_Barang")
            End If
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TxtCode_TextChanged(sender As Object, e As EventArgs) Handles TxtCode.TextChanged

    End Sub
End Class