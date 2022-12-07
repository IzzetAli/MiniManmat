<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLapDataMaster
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
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.Dtp_1 = New System.Windows.Forms.DateTimePicker()
        Me.Dtp_2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(196, 293)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(181, 65)
        Me.IconButton1.TabIndex = 0
        Me.IconButton1.Text = "ADMIN"
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'IconButton2
        '
        Me.IconButton2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.Location = New System.Drawing.Point(393, 293)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(181, 65)
        Me.IconButton2.TabIndex = 1
        Me.IconButton2.Text = "PELANGGAN"
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton3
        '
        Me.IconButton3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton3.IconColor = System.Drawing.Color.Black
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.Location = New System.Drawing.Point(580, 293)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(181, 65)
        Me.IconButton3.TabIndex = 2
        Me.IconButton3.Text = "BARANG"
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'IconButton4
        '
        Me.IconButton4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton4.IconColor = System.Drawing.Color.Black
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.Location = New System.Drawing.Point(767, 293)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Size = New System.Drawing.Size(181, 65)
        Me.IconButton4.TabIndex = 3
        Me.IconButton4.Text = "PRINT"
        Me.IconButton4.UseVisualStyleBackColor = True
        '
        'Dtp_1
        '
        Me.Dtp_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Dtp_1.CustomFormat = "dd/MM/yyyy"
        Me.Dtp_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_1.Location = New System.Drawing.Point(312, 163)
        Me.Dtp_1.Name = "Dtp_1"
        Me.Dtp_1.Size = New System.Drawing.Size(211, 39)
        Me.Dtp_1.TabIndex = 4
        '
        'Dtp_2
        '
        Me.Dtp_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Dtp_2.CustomFormat = "dd/MM/yyyy"
        Me.Dtp_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_2.Location = New System.Drawing.Point(648, 163)
        Me.Dtp_2.Name = "Dtp_2"
        Me.Dtp_2.Size = New System.Drawing.Size(223, 39)
        Me.Dtp_2.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(563, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "s/d"
        '
        'FormLapDataMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1144, 370)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Dtp_2)
        Me.Controls.Add(Me.Dtp_1)
        Me.Controls.Add(Me.IconButton4)
        Me.Controls.Add(Me.IconButton3)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.IconButton1)
        Me.Name = "FormLapDataMaster"
        Me.Text = "FormLapDataMaster"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents Dtp_1 As DateTimePicker
    Friend WithEvents Dtp_2 As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
