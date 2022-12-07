<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPelanggan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IcbEdit = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IcbDelete = New FontAwesome.Sharp.IconButton()
        Me.IcbSave = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNoHP = New System.Windows.Forms.TextBox()
        Me.IcbClose = New FontAwesome.Sharp.IconButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(1, 144)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1461, 308)
        Me.DataGridView1.TabIndex = 39
        '
        'IcbEdit
        '
        Me.IcbEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IcbEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IcbEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IcbEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IcbEdit.ForeColor = System.Drawing.Color.Gainsboro
        Me.IcbEdit.IconChar = FontAwesome.Sharp.IconChar.Recycle
        Me.IcbEdit.IconColor = System.Drawing.Color.Gainsboro
        Me.IcbEdit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IcbEdit.IconSize = 32
        Me.IcbEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IcbEdit.Location = New System.Drawing.Point(448, 641)
        Me.IcbEdit.Name = "IcbEdit"
        Me.IcbEdit.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.IcbEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IcbEdit.Size = New System.Drawing.Size(256, 88)
        Me.IcbEdit.TabIndex = 30
        Me.IcbEdit.Text = "Edit"
        Me.IcbEdit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(509, 489)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(104, 37)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.Location = New System.Drawing.Point(841, 489)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(118, 37)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Alamat"
        '
        'IcbDelete
        '
        Me.IcbDelete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IcbDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IcbDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IcbDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IcbDelete.ForeColor = System.Drawing.Color.Gainsboro
        Me.IcbDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.IcbDelete.IconColor = System.Drawing.Color.GhostWhite
        Me.IcbDelete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IcbDelete.IconSize = 32
        Me.IcbDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IcbDelete.Location = New System.Drawing.Point(737, 641)
        Me.IcbDelete.Name = "IcbDelete"
        Me.IcbDelete.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.IcbDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IcbDelete.Size = New System.Drawing.Size(256, 88)
        Me.IcbDelete.TabIndex = 31
        Me.IcbDelete.Text = "Delete"
        Me.IcbDelete.UseVisualStyleBackColor = False
        '
        'IcbSave
        '
        Me.IcbSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IcbSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IcbSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IcbSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IcbSave.ForeColor = System.Drawing.Color.Gainsboro
        Me.IcbSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.IcbSave.IconColor = System.Drawing.Color.Gainsboro
        Me.IcbSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IcbSave.IconSize = 32
        Me.IcbSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IcbSave.Location = New System.Drawing.Point(159, 641)
        Me.IcbSave.Name = "IcbSave"
        Me.IcbSave.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.IcbSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IcbSave.Size = New System.Drawing.Size(256, 88)
        Me.IcbSave.TabIndex = 29
        Me.IcbSave.Text = "Save"
        Me.IcbSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(128, 489)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(253, 37)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Kode Pelanggan"
        '
        'TxtKode
        '
        Me.TxtKode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtKode.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtKode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKode.Location = New System.Drawing.Point(149, 538)
        Me.TxtKode.Margin = New System.Windows.Forms.Padding(10, 3, 20, 3)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtKode.Size = New System.Drawing.Size(211, 44)
        Me.TxtKode.TabIndex = 26
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtAlamat.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAlamat.Location = New System.Drawing.Point(763, 538)
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtAlamat.Size = New System.Drawing.Size(284, 44)
        Me.TxtAlamat.TabIndex = 28
        '
        'TxtNama
        '
        Me.TxtNama.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtNama.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNama.Location = New System.Drawing.Point(395, 538)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNama.Size = New System.Drawing.Size(340, 44)
        Me.TxtNama.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label5.Location = New System.Drawing.Point(1132, 489)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(112, 37)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "No HP"
        '
        'TxtNoHP
        '
        Me.TxtNoHP.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtNoHP.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtNoHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNoHP.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNoHP.Location = New System.Drawing.Point(1074, 538)
        Me.TxtNoHP.Name = "TxtNoHP"
        Me.TxtNoHP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNoHP.Size = New System.Drawing.Size(238, 44)
        Me.TxtNoHP.TabIndex = 35
        '
        'IcbClose
        '
        Me.IcbClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IcbClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IcbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IcbClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IcbClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IcbClose.ForeColor = System.Drawing.Color.Gainsboro
        Me.IcbClose.IconChar = FontAwesome.Sharp.IconChar.SignOut
        Me.IcbClose.IconColor = System.Drawing.Color.Gainsboro
        Me.IcbClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IcbClose.IconSize = 32
        Me.IcbClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IcbClose.Location = New System.Drawing.Point(1026, 641)
        Me.IcbClose.Name = "IcbClose"
        Me.IcbClose.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.IcbClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IcbClose.Size = New System.Drawing.Size(256, 88)
        Me.IcbClose.TabIndex = 36
        Me.IcbClose.Text = "Close"
        Me.IcbClose.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label6.Location = New System.Drawing.Point(234, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(312, 32)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Cari Nama Pelanggan"
        '
        'TxtSearch
        '
        Me.TxtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtSearch.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(591, 39)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtSearch.Size = New System.Drawing.Size(615, 39)
        Me.TxtSearch.TabIndex = 38
        '
        'FormPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1441, 741)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.IcbClose)
        Me.Controls.Add(Me.IcbEdit)
        Me.Controls.Add(Me.TxtNoHP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.IcbDelete)
        Me.Controls.Add(Me.TxtAlamat)
        Me.Controls.Add(Me.IcbSave)
        Me.Controls.Add(Me.TxtKode)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPelanggan"
        Me.Text = "FormCustomers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IcbEdit As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents IcbDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents IcbSave As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtKode As TextBox
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNoHP As TextBox
    Friend WithEvents IcbClose As FontAwesome.Sharp.IconButton
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtSearch As TextBox
End Class
