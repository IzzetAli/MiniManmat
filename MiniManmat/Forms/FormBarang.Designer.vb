<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarang
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.IcbClose = New FontAwesome.Sharp.IconButton()
        Me.TxtJumlah = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        Me.IcbSave = New FontAwesome.Sharp.IconButton()
        Me.IcbDelete = New FontAwesome.Sharp.IconButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IcbEdit = New FontAwesome.Sharp.IconButton()
        Me.CmbSatuan = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(-1, 142)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1363, 287)
        Me.DataGridView1.TabIndex = 41
        '
        'TxtSearch
        '
        Me.TxtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtSearch.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(551, 50)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtSearch.Size = New System.Drawing.Size(615, 39)
        Me.TxtSearch.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label6.Location = New System.Drawing.Point(195, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(301, 37)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Cari Nama Barang"
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
        Me.IcbClose.Location = New System.Drawing.Point(995, 644)
        Me.IcbClose.Name = "IcbClose"
        Me.IcbClose.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.IcbClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IcbClose.Size = New System.Drawing.Size(235, 88)
        Me.IcbClose.TabIndex = 36
        Me.IcbClose.Text = "Close"
        Me.IcbClose.UseVisualStyleBackColor = False
        '
        'TxtJumlah
        '
        Me.TxtJumlah.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtJumlah.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtJumlah.Location = New System.Drawing.Point(912, 541)
        Me.TxtJumlah.Name = "TxtJumlah"
        Me.TxtJumlah.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtJumlah.Size = New System.Drawing.Size(131, 44)
        Me.TxtJumlah.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label5.Location = New System.Drawing.Point(912, 492)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(127, 37)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Jumlah"
        '
        'TxtName
        '
        Me.TxtName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtName.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(358, 541)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtName.Size = New System.Drawing.Size(340, 44)
        Me.TxtName.TabIndex = 27
        '
        'TxtHarga
        '
        Me.TxtHarga.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtHarga.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHarga.Location = New System.Drawing.Point(718, 541)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtHarga.Size = New System.Drawing.Size(171, 44)
        Me.TxtHarga.TabIndex = 28
        '
        'TxtCode
        '
        Me.TxtCode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtCode.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCode.Location = New System.Drawing.Point(97, 541)
        Me.TxtCode.Margin = New System.Windows.Forms.Padding(10, 3, 20, 3)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCode.Size = New System.Drawing.Size(238, 44)
        Me.TxtCode.TabIndex = 26
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
        Me.IcbSave.Location = New System.Drawing.Point(131, 644)
        Me.IcbSave.Name = "IcbSave"
        Me.IcbSave.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.IcbSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IcbSave.Size = New System.Drawing.Size(235, 88)
        Me.IcbSave.TabIndex = 29
        Me.IcbSave.Text = "Save"
        Me.IcbSave.UseVisualStyleBackColor = False
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
        Me.IcbDelete.Location = New System.Drawing.Point(707, 644)
        Me.IcbDelete.Name = "IcbDelete"
        Me.IcbDelete.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.IcbDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IcbDelete.Size = New System.Drawing.Size(235, 88)
        Me.IcbDelete.TabIndex = 31
        Me.IcbDelete.Text = "Delete"
        Me.IcbDelete.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.Location = New System.Drawing.Point(754, 492)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(110, 37)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Harga"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(475, 492)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(108, 37)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nama"
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
        Me.IcbEdit.Location = New System.Drawing.Point(419, 644)
        Me.IcbEdit.Name = "IcbEdit"
        Me.IcbEdit.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.IcbEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IcbEdit.Size = New System.Drawing.Size(235, 88)
        Me.IcbEdit.TabIndex = 30
        Me.IcbEdit.Text = "Edit"
        Me.IcbEdit.UseVisualStyleBackColor = False
        '
        'CmbSatuan
        '
        Me.CmbSatuan.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CmbSatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSatuan.FormattingEnabled = True
        Me.CmbSatuan.Location = New System.Drawing.Point(1068, 540)
        Me.CmbSatuan.Name = "CmbSatuan"
        Me.CmbSatuan.Size = New System.Drawing.Size(195, 45)
        Me.CmbSatuan.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Location = New System.Drawing.Point(1102, 492)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(125, 37)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Satuan"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(107, 492)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(215, 37)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Kode Barang"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label7.Location = New System.Drawing.Point(617, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(127, 37)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Jumlah"
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1360, 756)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbSatuan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.IcbClose)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.TxtJumlah)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtHarga)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.IcbEdit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IcbDelete)
        Me.Controls.Add(Me.IcbSave)
        Me.Name = "FormBarang"
        Me.Text = "FormBarang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents IcbClose As FontAwesome.Sharp.IconButton
    Friend WithEvents TxtJumlah As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents IcbSave As FontAwesome.Sharp.IconButton
    Friend WithEvents IcbDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents IcbEdit As FontAwesome.Sharp.IconButton
    Friend WithEvents CmbSatuan As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
End Class
