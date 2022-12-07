Imports System.Data.Odbc
Imports System.Runtime.CompilerServices.RuntimeHelpers

Public Class FormPelanggan
    Sub Reset()
        TxtKode.Text = ""
        TxtNama.Text = ""
        TxtAlamat.Text = ""
        TxtNoHP.Text = ""
        TxtKode.Enabled = False
        TxtNama.Enabled = False
        TxtAlamat.Enabled = False
        TxtNoHP.Enabled = False
        IcbSave.Enabled = True
        IcbEdit.Enabled = True
        IcbDelete.Enabled = True
        IcbClose.Enabled = True
        IcbSave.Text = "Input"
        IcbEdit.Text = "Edit"
        IcbDelete.Text = "Delete"
        IcbClose.Text = "Close"
        Call Connection()
        Da = New OdbcDataAdapter("select * from tbl_pelanggan", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_pelanggan")
        DataGridView1.DataSource = Ds.Tables("tbl_Pelanggan")
        DataGridView1.ReadOnly = True
    End Sub

    Sub AutoNumbers()
        Cmd = New OdbcCommand("select * from tbl_pelanggan", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        DR = Cmd.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            UrutanKode = "PLG" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 3) + 1
            UrutanKode = "PLG" + Microsoft.VisualBasic.Right("000" & Hitung, 3)

        End If
        TxtKode.Text = UrutanKode
    End Sub

    Sub ReadyToFi11()
        TxtKode.Enabled = True
        TxtNama.Enabled = True
        TxtAlamat.Enabled = True
        TxtNoHP.Enabled = True
    End Sub

    Private Sub FormPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Reset()

    End Sub

    Private Sub IcbSave_Click(sender As Object, e As EventArgs) Handles IcbSave.Click
        If IcbSave.Text = "Input" Then
            IcbSave.Text = "Simpan"
            IcbEdit.Enabled = False
            IcbDelete.Enabled = False
            IcbClose.Text = "Batal"
            Call ReadyToFi11()
            Call AutoNumbers()
            TxtKode.Enabled = False

            TxtNama.Focus()

        Else

            If TxtKode.Text = "" Or TxtNama.Text = "" Or TxtAlamat.Text = "" Or TxtNoHP.Text = "" Then
                MsgBox("Pleasse fill in all fields")
            Else
                Call Connection()
                Dim inputData As String = "insert into tbl_Pelanggan value ( '" & TxtKode.Text & "','" & TxtNama.Text & "','" & TxtAlamat.Text & "','" & TxtNoHP.Text & "')"
                Cmd = New OdbcCommand(inputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("save data successfullyl")
                Call Reset()
            End If
        End If
    End Sub

    Private Sub IcbEdit_Click(sender As Object, e As EventArgs) Handles IcbEdit.Click
        If IcbEdit.Text = "Edit" Then
            IcbEdit.Text = "simpan"
            IcbSave.Enabled = False
            IcbDelete.Text = False
            IcbClose.Text = "Batal"
            Call ReadyToFi11()
        Else

            If TxtKode.Text = "" Or TxtNama.Text = "" Or TxtAlamat.Text = "" Or TxtNoHP.Text = "" Then
                MsgBox("Please fill in all fields")
            Else
                Call Connection()
                Dim UpdateData As String = "Update tbl_Pelanggan set Nama_Pelanggan='" & TxtNama.Text & "',Alamat_Pelanggan='" & TxtAlamat.Text & "',Telpon_Pelanggan='" & TxtNoHP.Text & "' Where Kode_Pelanggan='" & TxtKode.Text & "'"
                Cmd = New OdbcCommand(UpdateData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Update data successfullyl")
                Call Reset()
            End If
        End If
    End Sub

    Private Sub TxtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Connection()
            Cmd = New OdbcCommand("Select * From tbl_pelanggan where Kode_Pelanggan='" & TxtKode.Text & "'", Conn)
            DR = Cmd.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                MsgBox("Admin Kode Does Not Exist!!")
            Else
                TxtKode.Text = DR.Item("Kode_Pelanggan")
                TxtNama.Text = DR.Item("Nama_Pelanggan")
                TxtAlamat.Text = DR.Item("Alamat_Pelanggan")
                TxtNoHP.Text = DR.Item("Telpon_Pelanggan")

            End If
        End If
    End Sub

    Private Sub IcbDelete_Click(sender As Object, e As EventArgs) Handles IcbDelete.Click
        If IcbDelete.Text = "Delete" Then
            IcbDelete.Text = "Remove"
            IcbSave.Enabled = False
            IcbEdit.Enabled = False
            IcbClose.Text = "Cancel"
            Call ReadyToFi11()
        Else

            If TxtKode.Text = "" Or TxtNama.Text = "" Or TxtAlamat.Text = "" Or TxtNoHP.Text = "" Then
                MsgBox("Please fill in all fields")
            Else
                Call Connection()
                Dim HapusData As String = "Delete  from tbl_Pelanggan where Kode_Pelanggan='" & TxtKode.Text & "'"
                Cmd = New OdbcCommand(HapusData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Delete Data successfullyl")
                Call Reset()
            End If
        End If
    End Sub

    Private Sub IcbClose_Click(sender As Object, e As EventArgs) Handles IcbClose.Click
        If IcbClose.Text = "Close" Then
            Me.Close()
        Else
            Call Reset()

        End If
    End Sub

    Private Sub TxtKode_TextChanged(sender As Object, e As EventArgs) Handles TxtKode.TextChanged

    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged

    End Sub
End Class