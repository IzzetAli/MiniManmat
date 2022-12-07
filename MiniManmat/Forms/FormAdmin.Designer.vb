<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.CmbSetatus = New System.Windows.Forms.ComboBox()
        Me.IcbSave = New FontAwesome.Sharp.IconButton()
        Me.IcbEdit = New FontAwesome.Sharp.IconButton()
        Me.IcbDelete = New FontAwesome.Sharp.IconButton()
        Me.IcbClose = New FontAwesome.Sharp.IconButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(2, 122)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 100, 100, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 100
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1283, 262)
        Me.DataGridView1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(137, 411)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(97, 37)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Code"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(438, 408)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(107, 37)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.Location = New System.Drawing.Point(717, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(166, 37)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Location = New System.Drawing.Point(1033, 408)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(96, 37)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Level"
        '
        'TxtCode
        '
        Me.TxtCode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtCode.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCode.Location = New System.Drawing.Point(46, 460)
        Me.TxtCode.Margin = New System.Windows.Forms.Padding(10, 3, 20, 3)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCode.Size = New System.Drawing.Size(274, 44)
        Me.TxtCode.TabIndex = 16
        '
        'TxtName
        '
        Me.TxtName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtName.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(341, 460)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtName.Size = New System.Drawing.Size(317, 44)
        Me.TxtName.TabIndex = 17
        '
        'TxtPassword
        '
        Me.TxtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtPassword.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(679, 460)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtPassword.Size = New System.Drawing.Size(256, 44)
        Me.TxtPassword.TabIndex = 18
        '
        'CmbSetatus
        '
        Me.CmbSetatus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CmbSetatus.BackColor = System.Drawing.Color.Gainsboro
        Me.CmbSetatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSetatus.Location = New System.Drawing.Point(956, 459)
        Me.CmbSetatus.Name = "CmbSetatus"
        Me.CmbSetatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbSetatus.Size = New System.Drawing.Size(265, 45)
        Me.CmbSetatus.TabIndex = 19
        '
        'IcbSave
        '
        Me.IcbSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IcbSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IcbSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IcbSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IcbSave.ForeColor = System.Drawing.Color.Gainsboro
        Me.IcbSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.IcbSave.IconColor = System.Drawing.Color.Gainsboro
        Me.IcbSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IcbSave.IconSize = 32
        Me.IcbSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IcbSave.Location = New System.Drawing.Point(69, 571)
        Me.IcbSave.Name = "IcbSave"
        Me.IcbSave.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.IcbSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IcbSave.Size = New System.Drawing.Size(249, 89)
        Me.IcbSave.TabIndex = 20
        Me.IcbSave.Text = "Save"
        Me.IcbSave.UseVisualStyleBackColor = False
        '
        'IcbEdit
        '
        Me.IcbEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IcbEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IcbEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IcbEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IcbEdit.ForeColor = System.Drawing.Color.Gainsboro
        Me.IcbEdit.IconChar = FontAwesome.Sharp.IconChar.Recycle
        Me.IcbEdit.IconColor = System.Drawing.Color.Gainsboro
        Me.IcbEdit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IcbEdit.IconSize = 32
        Me.IcbEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IcbEdit.Location = New System.Drawing.Point(369, 571)
        Me.IcbEdit.Name = "IcbEdit"
        Me.IcbEdit.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.IcbEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IcbEdit.Size = New System.Drawing.Size(249, 89)
        Me.IcbEdit.TabIndex = 21
        Me.IcbEdit.Text = "Edit"
        Me.IcbEdit.UseVisualStyleBackColor = False
        '
        'IcbDelete
        '
        Me.IcbDelete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IcbDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IcbDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IcbDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IcbDelete.ForeColor = System.Drawing.Color.Gainsboro
        Me.IcbDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.IcbDelete.IconColor = System.Drawing.Color.GhostWhite
        Me.IcbDelete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IcbDelete.IconSize = 32
        Me.IcbDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IcbDelete.Location = New System.Drawing.Point(669, 571)
        Me.IcbDelete.Name = "IcbDelete"
        Me.IcbDelete.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.IcbDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IcbDelete.Size = New System.Drawing.Size(249, 89)
        Me.IcbDelete.TabIndex = 22
        Me.IcbDelete.Text = "Delete"
        Me.IcbDelete.UseVisualStyleBackColor = False
        '
        'IcbClose
        '
        Me.IcbClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IcbClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IcbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IcbClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IcbClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IcbClose.ForeColor = System.Drawing.Color.Gainsboro
        Me.IcbClose.IconChar = FontAwesome.Sharp.IconChar.SignOut
        Me.IcbClose.IconColor = System.Drawing.Color.Gainsboro
        Me.IcbClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IcbClose.IconSize = 32
        Me.IcbClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IcbClose.Location = New System.Drawing.Point(969, 571)
        Me.IcbClose.Name = "IcbClose"
        Me.IcbClose.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.IcbClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IcbClose.Size = New System.Drawing.Size(249, 89)
        Me.IcbClose.TabIndex = 23
        Me.IcbClose.Text = "Close"
        Me.IcbClose.UseVisualStyleBackColor = False
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1287, 715)
        Me.Controls.Add(Me.IcbClose)
        Me.Controls.Add(Me.IcbDelete)
        Me.Controls.Add(Me.IcbEdit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.IcbSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbSetatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtCode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "FormAdmin"
        Me.Text = "FormAdmin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents CmbSetatus As ComboBox
    Friend WithEvents IcbSave As FontAwesome.Sharp.IconButton
    Friend WithEvents IcbEdit As FontAwesome.Sharp.IconButton
    Friend WithEvents IcbDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents IcbClose As FontAwesome.Sharp.IconButton
End Class
