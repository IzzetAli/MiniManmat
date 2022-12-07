<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNojual = New System.Windows.Forms.Label()
        Me.lblNamapg = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.lblTelepon = New System.Windows.Forms.Label()
        Me.CmbPelanggan = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.DgvTransaksi = New System.Windows.Forms.DataGridView()
        Me.Kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.lblJam = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblKembali = New System.Windows.Forms.Label()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.btnInsert = New FontAwesome.Sharp.IconButton()
        Me.btnSimpan = New FontAwesome.Sharp.IconButton()
        Me.btnBatal = New FontAwesome.Sharp.IconButton()
        Me.btnTutup = New FontAwesome.Sharp.IconButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblItem = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.DgvTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(39, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Jual"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(39, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Telepon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(39, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(39, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(39, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kode Pelanggan"
        '
        'lblNojual
        '
        Me.lblNojual.AutoSize = True
        Me.lblNojual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNojual.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblNojual.Location = New System.Drawing.Point(342, 72)
        Me.lblNojual.Name = "lblNojual"
        Me.lblNojual.Size = New System.Drawing.Size(118, 29)
        Me.lblNojual.TabIndex = 5
        Me.lblNojual.Text = "lblNojual"
        '
        'lblNamapg
        '
        Me.lblNamapg.AutoSize = True
        Me.lblNamapg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamapg.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblNamapg.Location = New System.Drawing.Point(342, 166)
        Me.lblNamapg.Name = "lblNamapg"
        Me.lblNamapg.Size = New System.Drawing.Size(140, 29)
        Me.lblNamapg.TabIndex = 7
        Me.lblNamapg.Text = "lblNamapg"
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlamat.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblAlamat.Location = New System.Drawing.Point(342, 209)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(121, 29)
        Me.lblAlamat.TabIndex = 8
        Me.lblAlamat.Text = "lblAlamat"
        '
        'lblTelepon
        '
        Me.lblTelepon.AutoSize = True
        Me.lblTelepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelepon.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblTelepon.Location = New System.Drawing.Point(342, 252)
        Me.lblTelepon.Name = "lblTelepon"
        Me.lblTelepon.Size = New System.Drawing.Size(140, 29)
        Me.lblTelepon.TabIndex = 9
        Me.lblTelepon.Text = "lblTelepon"
        '
        'CmbPelanggan
        '
        Me.CmbPelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPelanggan.FormattingEnabled = True
        Me.CmbPelanggan.Location = New System.Drawing.Point(342, 115)
        Me.CmbPelanggan.Name = "CmbPelanggan"
        Me.CmbPelanggan.Size = New System.Drawing.Size(385, 37)
        Me.CmbPelanggan.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(587, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(351, 64)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "TOTAL : Rp."
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblTotal.Location = New System.Drawing.Point(915, 43)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(342, 64)
        Me.lblTotal.TabIndex = 12
        Me.lblTotal.Text = "Rp. 000.000"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(37, 302)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 29)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Kode"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(889, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 29)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Jumlah"
        '
        'lblHarga
        '
        Me.lblHarga.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHarga.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblHarga.Location = New System.Drawing.Point(733, 312)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(112, 29)
        Me.lblHarga.TabIndex = 16
        Me.lblHarga.Text = "lblHarga"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label11.Location = New System.Drawing.Point(605, 312)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 29)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Harga"
        '
        'lblNama
        '
        Me.lblNama.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblNama.Location = New System.Drawing.Point(459, 312)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(110, 29)
        Me.lblNama.TabIndex = 18
        Me.lblNama.Text = "lblNama"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label13.Location = New System.Drawing.Point(338, 312)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 29)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Nama"
        '
        'txtkode
        '
        Me.txtkode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtkode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkode.Location = New System.Drawing.Point(129, 312)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(180, 35)
        Me.txtkode.TabIndex = 20
        '
        'txtJumlah
        '
        Me.txtJumlah.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlah.Location = New System.Drawing.Point(998, 309)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(152, 35)
        Me.txtJumlah.TabIndex = 21
        '
        'DgvTransaksi
        '
        Me.DgvTransaksi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvTransaksi.ColumnHeadersHeight = 34
        Me.DgvTransaksi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kode, Me.Nama, Me.Harga, Me.Jumlah, Me.SubTotal})
        Me.DgvTransaksi.Location = New System.Drawing.Point(43, 368)
        Me.DgvTransaksi.Name = "DgvTransaksi"
        Me.DgvTransaksi.RowHeadersWidth = 62
        Me.DgvTransaksi.RowTemplate.Height = 28
        Me.DgvTransaksi.Size = New System.Drawing.Size(1214, 291)
        Me.DgvTransaksi.TabIndex = 22
        '
        'Kode
        '
        Me.Kode.HeaderText = "Kode"
        Me.Kode.MinimumWidth = 8
        Me.Kode.Name = "Kode"
        '
        'Nama
        '
        Me.Nama.HeaderText = "Nama Pelanggan"
        Me.Nama.MinimumWidth = 8
        Me.Nama.Name = "Nama"
        '
        'Harga
        '
        Me.Harga.HeaderText = "Harga"
        Me.Harga.MinimumWidth = 8
        Me.Harga.Name = "Harga"
        '
        'Jumlah
        '
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.MinimumWidth = 8
        Me.Jumlah.Name = "Jumlah"
        '
        'SubTotal
        '
        Me.SubTotal.HeaderText = "SubTotal"
        Me.SubTotal.MinimumWidth = 8
        Me.SubTotal.Name = "SubTotal"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(841, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 29)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Tanggal"
        '
        'lblAdmin
        '
        Me.lblAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblAdmin.Location = New System.Drawing.Point(1060, 220)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(115, 29)
        Me.lblAdmin.TabIndex = 24
        Me.lblAdmin.Text = "lblAdmin"
        '
        'lblJam
        '
        Me.lblJam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblJam.AutoSize = True
        Me.lblJam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJam.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblJam.Location = New System.Drawing.Point(1060, 169)
        Me.lblJam.Name = "lblJam"
        Me.lblJam.Size = New System.Drawing.Size(90, 29)
        Me.lblJam.TabIndex = 25
        Me.lblJam.Text = "lblJam"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label14.Location = New System.Drawing.Point(841, 220)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 29)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Admin"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label15.Location = New System.Drawing.Point(841, 169)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 29)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Jam"
        '
        'lblTanggal
        '
        Me.lblTanggal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggal.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblTanggal.Location = New System.Drawing.Point(1060, 118)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(138, 29)
        Me.lblTanggal.TabIndex = 28
        Me.lblTanggal.Text = "lblTanggal"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label10.Location = New System.Drawing.Point(841, 681)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 29)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Di Bayar"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label12.Location = New System.Drawing.Point(841, 735)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 29)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Kembali"
        '
        'lblKembali
        '
        Me.lblKembali.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblKembali.AutoSize = True
        Me.lblKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKembali.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblKembali.Location = New System.Drawing.Point(993, 735)
        Me.lblKembali.Name = "lblKembali"
        Me.lblKembali.Size = New System.Drawing.Size(138, 29)
        Me.lblKembali.TabIndex = 36
        Me.lblKembali.Text = "lblKembali"
        '
        'txtBayar
        '
        Me.txtBayar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBayar.Location = New System.Drawing.Point(988, 678)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(270, 35)
        Me.txtBayar.TabIndex = 37
        '
        'btnInsert
        '
        Me.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnInsert.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnInsert.IconColor = System.Drawing.Color.Black
        Me.btnInsert.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnInsert.Location = New System.Drawing.Point(1160, 300)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(97, 53)
        Me.btnInsert.TabIndex = 38
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSimpan.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnSimpan.IconColor = System.Drawing.Color.Black
        Me.btnSimpan.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSimpan.Location = New System.Drawing.Point(44, 678)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(169, 71)
        Me.btnSimpan.TabIndex = 39
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnBatal.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnBatal.IconColor = System.Drawing.Color.Black
        Me.btnBatal.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBatal.Location = New System.Drawing.Point(232, 678)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(169, 71)
        Me.btnBatal.TabIndex = 40
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnTutup
        '
        Me.btnTutup.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnTutup.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnTutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTutup.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnTutup.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnTutup.IconColor = System.Drawing.Color.Black
        Me.btnTutup.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTutup.Location = New System.Drawing.Point(420, 678)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(169, 71)
        Me.btnTutup.TabIndex = 41
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'LblItem
        '
        Me.LblItem.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LblItem.AutoSize = True
        Me.LblItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblItem.ForeColor = System.Drawing.Color.Gainsboro
        Me.LblItem.Location = New System.Drawing.Point(694, 684)
        Me.LblItem.Name = "LblItem"
        Me.LblItem.Size = New System.Drawing.Size(99, 29)
        Me.LblItem.TabIndex = 43
        Me.LblItem.Text = "LblItem"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label17.Location = New System.Drawing.Point(625, 681)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 29)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Item"
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1296, 797)
        Me.Controls.Add(Me.LblItem)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.txtBayar)
        Me.Controls.Add(Me.lblKembali)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblTanggal)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblJam)
        Me.Controls.Add(Me.lblAdmin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DgvTransaksi)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.txtkode)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblHarga)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CmbPelanggan)
        Me.Controls.Add(Me.lblTelepon)
        Me.Controls.Add(Me.lblAlamat)
        Me.Controls.Add(Me.lblNamapg)
        Me.Controls.Add(Me.lblNojual)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormTransaksi"
        Me.Text = "FormDasboard"
        CType(Me.DgvTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNojual As Label
    Friend WithEvents lblNamapg As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents CmbPelanggan As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtkode As TextBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents DgvTransaksi As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents lblAdmin As Label
    Friend WithEvents lblJam As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblKembali As Label
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents btnInsert As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSimpan As FontAwesome.Sharp.IconButton
    Friend WithEvents btnBatal As FontAwesome.Sharp.IconButton
    Friend WithEvents btnTutup As FontAwesome.Sharp.IconButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Kode As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents Harga As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents LblItem As Label
    Friend WithEvents Label17 As Label
End Class
