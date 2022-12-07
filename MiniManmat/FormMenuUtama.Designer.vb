<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenuUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuUtama))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnStylist = New FontAwesome.Sharp.IconButton()
        Me.btnServise = New FontAwesome.Sharp.IconButton()
        Me.btnItem = New FontAwesome.Sharp.IconButton()
        Me.btnLaporan = New FontAwesome.Sharp.IconButton()
        Me.btnRegistration = New FontAwesome.Sharp.IconButton()
        Me.btnBarang = New FontAwesome.Sharp.IconButton()
        Me.btnProducts = New FontAwesome.Sharp.IconButton()
        Me.btnAdmin = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.imgHome = New System.Windows.Forms.PictureBox()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.ICNMax = New FontAwesome.Sharp.IconButton()
        Me.ICNMin = New FontAwesome.Sharp.IconButton()
        Me.ICNClose = New FontAwesome.Sharp.IconButton()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IconMenuItem1 = New FontAwesome.Sharp.IconMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IconMenuItem2 = New FontAwesome.Sharp.IconMenuItem()
        Me.GantiPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.STLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel9 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel10 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelDesktop.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnStylist)
        Me.PanelMenu.Controls.Add(Me.btnServise)
        Me.PanelMenu.Controls.Add(Me.btnItem)
        Me.PanelMenu.Controls.Add(Me.btnLaporan)
        Me.PanelMenu.Controls.Add(Me.btnRegistration)
        Me.PanelMenu.Controls.Add(Me.btnBarang)
        Me.PanelMenu.Controls.Add(Me.btnProducts)
        Me.PanelMenu.Controls.Add(Me.btnAdmin)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 859)
        Me.PanelMenu.TabIndex = 1
        '
        'btnStylist
        '
        Me.btnStylist.CausesValidation = False
        Me.btnStylist.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStylist.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnStylist.IconChar = FontAwesome.Sharp.IconChar.Scissors
        Me.btnStylist.IconColor = System.Drawing.Color.Gainsboro
        Me.btnStylist.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnStylist.IconSize = 32
        Me.btnStylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStylist.Location = New System.Drawing.Point(0, 588)
        Me.btnStylist.Name = "btnStylist"
        Me.btnStylist.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnStylist.Size = New System.Drawing.Size(220, 64)
        Me.btnStylist.TabIndex = 16
        Me.btnStylist.Text = "Stylist"
        Me.btnStylist.UseVisualStyleBackColor = True
        '
        'btnServise
        '
        Me.btnServise.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnServise.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServise.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnServise.IconChar = FontAwesome.Sharp.IconChar.PersonChalkboard
        Me.btnServise.IconColor = System.Drawing.Color.Gainsboro
        Me.btnServise.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnServise.IconSize = 32
        Me.btnServise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnServise.Location = New System.Drawing.Point(0, 524)
        Me.btnServise.Name = "btnServise"
        Me.btnServise.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnServise.Size = New System.Drawing.Size(220, 64)
        Me.btnServise.TabIndex = 10
        Me.btnServise.TabStop = False
        Me.btnServise.Text = "Service "
        Me.btnServise.UseVisualStyleBackColor = True
        '
        'btnItem
        '
        Me.btnItem.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItem.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnItem.IconChar = FontAwesome.Sharp.IconChar.Dumpster
        Me.btnItem.IconColor = System.Drawing.Color.Gainsboro
        Me.btnItem.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnItem.IconSize = 32
        Me.btnItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnItem.Location = New System.Drawing.Point(0, 460)
        Me.btnItem.Name = "btnItem"
        Me.btnItem.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnItem.Size = New System.Drawing.Size(220, 64)
        Me.btnItem.TabIndex = 11
        Me.btnItem.TabStop = False
        Me.btnItem.Text = "Item"
        Me.btnItem.UseVisualStyleBackColor = True
        '
        'btnLaporan
        '
        Me.btnLaporan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLaporan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaporan.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnLaporan.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.btnLaporan.IconColor = System.Drawing.Color.Gainsboro
        Me.btnLaporan.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLaporan.IconSize = 32
        Me.btnLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLaporan.Location = New System.Drawing.Point(0, 396)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnLaporan.Size = New System.Drawing.Size(220, 64)
        Me.btnLaporan.TabIndex = 9
        Me.btnLaporan.TabStop = False
        Me.btnLaporan.Text = "Laporan"
        Me.btnLaporan.UseVisualStyleBackColor = True
        '
        'btnRegistration
        '
        Me.btnRegistration.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistration.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnRegistration.IconChar = FontAwesome.Sharp.IconChar.ListAlt
        Me.btnRegistration.IconColor = System.Drawing.Color.Gainsboro
        Me.btnRegistration.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRegistration.IconSize = 32
        Me.btnRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistration.Location = New System.Drawing.Point(0, 332)
        Me.btnRegistration.Name = "btnRegistration"
        Me.btnRegistration.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.btnRegistration.Size = New System.Drawing.Size(220, 64)
        Me.btnRegistration.TabIndex = 14
        Me.btnRegistration.Text = "Transaksi"
        Me.btnRegistration.UseVisualStyleBackColor = True
        '
        'btnBarang
        '
        Me.btnBarang.CausesValidation = False
        Me.btnBarang.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarang.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnBarang.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.btnBarang.IconColor = System.Drawing.Color.Gainsboro
        Me.btnBarang.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBarang.IconSize = 32
        Me.btnBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBarang.Location = New System.Drawing.Point(0, 268)
        Me.btnBarang.Name = "btnBarang"
        Me.btnBarang.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnBarang.Size = New System.Drawing.Size(220, 64)
        Me.btnBarang.TabIndex = 15
        Me.btnBarang.Text = "Barang"
        Me.btnBarang.UseVisualStyleBackColor = True
        '
        'btnProducts
        '
        Me.btnProducts.AutoSize = True
        Me.btnProducts.CausesValidation = False
        Me.btnProducts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProducts.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnProducts.IconChar = FontAwesome.Sharp.IconChar.Tag
        Me.btnProducts.IconColor = System.Drawing.Color.Gainsboro
        Me.btnProducts.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnProducts.IconSize = 32
        Me.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducts.Location = New System.Drawing.Point(0, 204)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnProducts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnProducts.Size = New System.Drawing.Size(220, 64)
        Me.btnProducts.TabIndex = 12
        Me.btnProducts.Text = "Pelanggan"
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnAdmin.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btnAdmin.IconColor = System.Drawing.Color.Gainsboro
        Me.btnAdmin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAdmin.IconSize = 32
        Me.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdmin.Location = New System.Drawing.Point(0, 140)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnAdmin.Size = New System.Drawing.Size(220, 64)
        Me.btnAdmin.TabIndex = 13
        Me.btnAdmin.Text = "Admin"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.imgHome)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(220, 140)
        Me.PanelLogo.TabIndex = 0
        '
        'imgHome
        '
        Me.imgHome.Image = CType(resources.GetObject("imgHome.Image"), System.Drawing.Image)
        Me.imgHome.Location = New System.Drawing.Point(45, 12)
        Me.imgHome.Name = "imgHome"
        Me.imgHome.Size = New System.Drawing.Size(131, 121)
        Me.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.imgHome.TabIndex = 0
        Me.imgHome.TabStop = False
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.ICNMax)
        Me.PanelTitleBar.Controls.Add(Me.ICNMin)
        Me.PanelTitleBar.Controls.Add(Me.ICNClose)
        Me.PanelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.PanelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitleBar.Controls.Add(Me.MenuStrip1)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(220, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(1200, 66)
        Me.PanelTitleBar.TabIndex = 2
        '
        'ICNMax
        '
        Me.ICNMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ICNMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ICNMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ICNMax.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ICNMax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ICNMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.ICNMax.IconColor = System.Drawing.Color.Gainsboro
        Me.ICNMax.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICNMax.IconSize = 32
        Me.ICNMax.Location = New System.Drawing.Point(1111, 4)
        Me.ICNMax.Name = "ICNMax"
        Me.ICNMax.Size = New System.Drawing.Size(40, 43)
        Me.ICNMax.TabIndex = 7
        Me.ICNMax.UseVisualStyleBackColor = False
        '
        'ICNMin
        '
        Me.ICNMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ICNMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ICNMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ICNMin.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ICNMin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ICNMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.ICNMin.IconColor = System.Drawing.Color.Gainsboro
        Me.ICNMin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICNMin.IconSize = 32
        Me.ICNMin.Location = New System.Drawing.Point(1071, 4)
        Me.ICNMin.Name = "ICNMin"
        Me.ICNMin.Size = New System.Drawing.Size(40, 43)
        Me.ICNMin.TabIndex = 6
        Me.ICNMin.UseVisualStyleBackColor = False
        '
        'ICNClose
        '
        Me.ICNClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ICNClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ICNClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ICNClose.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ICNClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ICNClose.IconChar = FontAwesome.Sharp.IconChar.X
        Me.ICNClose.IconColor = System.Drawing.Color.Gainsboro
        Me.ICNClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICNClose.IconSize = 32
        Me.ICNClose.Location = New System.Drawing.Point(1151, 4)
        Me.ICNClose.Name = "ICNClose"
        Me.ICNClose.Size = New System.Drawing.Size(40, 43)
        Me.ICNClose.TabIndex = 5
        Me.ICNClose.UseVisualStyleBackColor = False
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTitle.Location = New System.Drawing.Point(62, 28)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(52, 20)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Home"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.MediumPurple
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.HouseChimney
        Me.IconCurrentForm.IconColor = System.Drawing.Color.MediumPurple
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.IconSize = 36
        Me.IconCurrentForm.Location = New System.Drawing.Point(10, 21)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(46, 36)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IconMenuItem1, Me.IconMenuItem2})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(402, 15)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(183, 32)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IconMenuItem1
        '
        Me.IconMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IconMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.IconMenuItem1.Font = New System.Drawing.Font("Segoe UI Light", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconMenuItem1.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.FilePen
        Me.IconMenuItem1.IconColor = System.Drawing.Color.Gainsboro
        Me.IconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconMenuItem1.Name = "IconMenuItem1"
        Me.IconMenuItem1.Size = New System.Drawing.Size(71, 28)
        Me.IconMenuItem1.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.LoginToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(161, 34)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.LogOutToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(161, 34)
        Me.LogOutToolStripMenuItem.Text = "LogOut"
        '
        'IconMenuItem2
        '
        Me.IconMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IconMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GantiPasswordToolStripMenuItem})
        Me.IconMenuItem2.Font = New System.Drawing.Font("Segoe UI Light", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconMenuItem2.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench
        Me.IconMenuItem2.IconColor = System.Drawing.Color.Gainsboro
        Me.IconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconMenuItem2.IconSize = 32
        Me.IconMenuItem2.Name = "IconMenuItem2"
        Me.IconMenuItem2.Size = New System.Drawing.Size(97, 28)
        Me.IconMenuItem2.Text = "Setting"
        '
        'GantiPasswordToolStripMenuItem
        '
        Me.GantiPasswordToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GantiPasswordToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro
        Me.GantiPasswordToolStripMenuItem.Name = "GantiPasswordToolStripMenuItem"
        Me.GantiPasswordToolStripMenuItem.Size = New System.Drawing.Size(212, 34)
        Me.GantiPasswordToolStripMenuItem.Text = "Ganti Password"
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.StatusStrip1)
        Me.PanelDesktop.Controls.Add(Me.PictureBox1)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.ForeColor = System.Drawing.Color.Gainsboro
        Me.PanelDesktop.Location = New System.Drawing.Point(220, 66)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1200, 793)
        Me.PanelDesktop.TabIndex = 3
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STLabel1, Me.STLabel2, Me.STLabel3, Me.STLabel4, Me.STLabel5, Me.STLabel6, Me.STLabel7, Me.STLabel8, Me.STLabel9, Me.STLabel10})
        Me.StatusStrip1.Location = New System.Drawing.Point(464, 494)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(324, 28)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'STLabel1
        '
        Me.STLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.STLabel1.Name = "STLabel1"
        Me.STLabel1.Size = New System.Drawing.Size(53, 21)
        Me.STLabel1.Text = "Kode :"
        '
        'STLabel2
        '
        Me.STLabel2.Name = "STLabel2"
        Me.STLabel2.Size = New System.Drawing.Size(0, 21)
        '
        'STLabel3
        '
        Me.STLabel3.ForeColor = System.Drawing.Color.Gainsboro
        Me.STLabel3.Name = "STLabel3"
        Me.STLabel3.Size = New System.Drawing.Size(61, 21)
        Me.STLabel3.Text = "Nama :"
        '
        'STLabel4
        '
        Me.STLabel4.Name = "STLabel4"
        Me.STLabel4.Size = New System.Drawing.Size(0, 21)
        '
        'STLabel5
        '
        Me.STLabel5.ForeColor = System.Drawing.Color.Gainsboro
        Me.STLabel5.Name = "STLabel5"
        Me.STLabel5.Size = New System.Drawing.Size(56, 21)
        Me.STLabel5.Text = "Level  :"
        '
        'STLabel6
        '
        Me.STLabel6.Name = "STLabel6"
        Me.STLabel6.Size = New System.Drawing.Size(0, 21)
        '
        'STLabel7
        '
        Me.STLabel7.ForeColor = System.Drawing.Color.Gainsboro
        Me.STLabel7.Name = "STLabel7"
        Me.STLabel7.Size = New System.Drawing.Size(63, 21)
        Me.STLabel7.Text = "Waktu :"
        '
        'STLabel8
        '
        Me.STLabel8.Name = "STLabel8"
        Me.STLabel8.Size = New System.Drawing.Size(0, 21)
        '
        'STLabel9
        '
        Me.STLabel9.ForeColor = System.Drawing.Color.Gainsboro
        Me.STLabel9.Name = "STLabel9"
        Me.STLabel9.Size = New System.Drawing.Size(74, 21)
        Me.STLabel9.Text = "Tanggal :"
        '
        'STLabel10
        '
        Me.STLabel10.Name = "STLabel10"
        Me.STLabel10.Size = New System.Drawing.Size(0, 21)
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(490, 252)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(231, 230)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1420, 859)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelDesktop.ResumeLayout(False)
        Me.PanelDesktop.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents ICNMax As FontAwesome.Sharp.IconButton
    Friend WithEvents ICNMin As FontAwesome.Sharp.IconButton
    Friend WithEvents ICNClose As FontAwesome.Sharp.IconButton
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconMenuItem1 As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IconMenuItem2 As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents GantiPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents btnStylist As FontAwesome.Sharp.IconButton
    Friend WithEvents btnServise As FontAwesome.Sharp.IconButton
    Friend WithEvents btnItem As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLaporan As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRegistration As FontAwesome.Sharp.IconButton
    Friend WithEvents btnBarang As FontAwesome.Sharp.IconButton
    Friend WithEvents btnProducts As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAdmin As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents STLabel1 As ToolStripStatusLabel
    Friend WithEvents STLabel2 As ToolStripStatusLabel
    Friend WithEvents STLabel3 As ToolStripStatusLabel
    Friend WithEvents STLabel4 As ToolStripStatusLabel
    Friend WithEvents STLabel5 As ToolStripStatusLabel
    Friend WithEvents STLabel6 As ToolStripStatusLabel
    Friend WithEvents STLabel7 As ToolStripStatusLabel
    Friend WithEvents STLabel8 As ToolStripStatusLabel
    Friend WithEvents STLabel9 As ToolStripStatusLabel
    Friend WithEvents STLabel10 As ToolStripStatusLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Timer1 As Timer
End Class
