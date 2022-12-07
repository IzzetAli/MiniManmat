Imports System.Data.Odbc
Public Class Login
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Hide()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUser.Text = "Admin"
        TxtUser.ForeColor = Color.Black

        TxtPassword.Text = "ADMIN"
        TxtPassword.ForeColor = Color.Black


    End Sub



    Private Sub TxtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUser.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtPassword.Focus()

        End If
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Call Connection()
        Cmd = New OdbcCommand("Select * from tbl_admin where Nama_Admin='" & TxtUser.Text & "'and Password_Admin='" & TxtPassword.Text & "'", Conn)
        DR = Cmd.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            MsgBox("Login Error!")
            Exit Sub
        Else
            Me.Visible = False
            FormMenuUtama.Show()

            FormMenuUtama.STLabel2.Text = DR.Item("Kode_Admin")
            FormMenuUtama.STLabel4.Text = DR.Item("Nama_Admin")
            FormMenuUtama.STLabel6.Text = DR.Item("Level_Admin")

            If FormMenuUtama.STLabel4.Text <> "ADMIN" Then
                'MenuUtamaForm.btnUser1.Visible = False
                'PanelDekstop.BarangToolStripButton8.Visible = False
                'PanelDekstop.ProdukToolStripButton2.Visible = False
                'PanelDekstop.LayananToolStripButton6.Visible = False
            End If
        End If
    End Sub

    Private Sub TxtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            BtnLogin.Focus()
        End If
    End Sub
End Class