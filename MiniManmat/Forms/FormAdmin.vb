Imports System.Data.Odbc
Public Class FormAdmin
    Sub Reset()
        TxtCode.Text = ""
        TxtName.Text = ""
        TxtPassword.Text = ""
        CmbSetatus.Items.Clear()
        CmbSetatus.Text = ""
        TxtCode.Enabled = False
        TxtName.Enabled = False
        TxtPassword.Enabled = False
        CmbSetatus.Enabled = False
        IcbSave.Enabled = True
        IcbEdit.Enabled = True
        IcbDelete.Enabled = True
        IcbClose.Enabled = True
        IcbSave.Text = "Insert"
        IcbEdit.Text = "Edit"
        IcbDelete.Text = "Delete"
        IcbClose.Text = "Close"
        Call Connection()
        Da = New OdbcDataAdapter("select * from tbl_Admin", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_admin")
        DataGridView1.DataSource = Ds.Tables("tbl_admin")
        DataGridView1.ReadOnly = True
    End Sub

    Sub ReadyToFill()
        TxtCode.Enabled = True
        TxtName.Enabled = True
        TxtPassword.Enabled = True
        CmbSetatus.Enabled = True
        CmbSetatus.Items.Add("ADMIN")
        CmbSetatus.Items.Add("USER")

    End Sub

    Sub AutoNumber()
        Call Connection()
        Cmd = New OdbcCommand("l_admin where Kode_Admin in(select max(Kode_Admin) from tbl_admin)", Conn)
        Dim UrutKode As String
        Dim Hitung As String
        DR = Cmd.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            UrutKode = "ADM" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 3) + 1
            UrutKode = "ADM" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        TxtCode.Text = UrutKode
    End Sub
    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Private Sub IcbSave_Click(sender As Object, e As EventArgs) Handles IcbSave.Click
        If IcbSave.Text = "Insert" Then
            IcbSave.Text = "Save"
            IcbEdit.Enabled = False
            IcbDelete.Enabled = False
            IcbClose.Text = "Cancele"
            Call ReadyToFill()
            Call AutoNumber()
            TxtCode.Enabled = False
            TxtName.Focus()
        Else
            If TxtCode.Text = "" Or TxtName.Text = "" Or TxtPassword.Text = "" Or CmbSetatus.Text = "" Then
                MsgBox("Please fill in all fields")
            Else
                Call Connection()
                Dim InputData As String = " Insert into tbl_admin value('" & TxtCode.Text & "','" & TxtName.Text & "','" & TxtPassword.Text & "','" & CmbSetatus.Text & "')"
                Cmd = New OdbcCommand(InputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Save Data Successfully")
                Call Reset()
            End If
        End If
    End Sub

    Private Sub IcbEdit_Click(sender As Object, e As EventArgs) Handles IcbEdit.Click
        If IcbEdit.Text = "Edit" Then
            IcbEdit.Text = "Update"
            IcbSave.Enabled = False
            IcbDelete.Enabled = False
            IcbClose.Text = "Cancele"
            Call ReadyToFill()

        Else
            If TxtCode.Text = " " Or TxtName.Text = "" Or TxtPassword.Text = "" Or CmbSetatus.Text = "" Then
                MsgBox("Please Fill In Fields")
            Else
                Call Connection()
                Dim UpdateDate As String = "Update tbl_admin set Nama_Admin='" & TxtName.Text & "',Password_Admin='" & TxtPassword.Text & "',Level_Admin='" & CmbSetatus.Text & "' where Kode_Admin='" & TxtCode.Text & "'"
                Cmd = New OdbcCommand(UpdateDate, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Update Data Successfully")
                Call Reset()

            End If
        End If
    End Sub


    Private Sub TxtCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Connection()
            Cmd = New OdbcCommand("Select * From tbl_admin where Kode_Admin='" & TxtCode.Text & "'", Conn)
            DR = Cmd.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                MsgBox("ADMIN Code Does Not Exist!")
            Else
                TxtCode.Text = DR.Item("Kode_Admin")
                TxtName.Text = DR.Item("Nama_Admin")
                TxtPassword.Text = DR.Item("Password_Admin")
                CmbSetatus.Text = DR.Item("Level_Admin")
            End If
        End If
    End Sub

    Private Sub IcbDelete_Click(sender As Object, e As EventArgs) Handles IcbDelete.Click
        If IcbDelete.Text = "Delete" Then
            IcbDelete.Text = "Remove"
            IcbSave.Enabled = False
            IcbEdit.Enabled = False
            IcbClose.Text = "Cancele"
            Call ReadyToFill()
        Else
            If TxtCode.Text = "" Or TxtName.Text = "" Or TxtPassword.Text = "" Or CmbSetatus.Text = "" Then
                MsgBox("Please Fill In All Fields")
            Else

                Call Connection()
                Dim DeleteData As String = "Delete from tbl_admin where Kode_Admin='" & TxtCode.Text & "'"
                Cmd = New OdbcCommand(DeleteData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Delete Data Successfully")
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TxtCode_TextChanged(sender As Object, e As EventArgs) Handles TxtCode.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class