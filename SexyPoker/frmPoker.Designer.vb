<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPoker
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPoker))
        Me.Cartes = New System.Windows.Forms.ImageList(Me.components)
        Me.pan1 = New System.Windows.Forms.Panel()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.pan2 = New System.Windows.Forms.Panel()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.pan3 = New System.Windows.Forms.Panel()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.pan5 = New System.Windows.Forms.Panel()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.panJeu = New System.Windows.Forms.Panel()
        Me.panCartes = New System.Windows.Forms.Panel()
        Me.pan4 = New System.Windows.Forms.Panel()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.cmdJouer = New System.Windows.Forms.Button()
        Me.txtGain = New System.Windows.Forms.TextBox()
        Me.cmdQuitter = New System.Windows.Forms.Button()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.lblMise = New System.Windows.Forms.Label()
        Me.lblGain = New System.Windows.Forms.Label()
        Me.txtCredits = New System.Windows.Forms.TextBox()
        Me.stBar = New System.Windows.Forms.StatusStrip()
        Me.lblstMsg = New System.Windows.Forms.ToolStripStatusLabel()
        Me.panMise = New System.Windows.Forms.Panel()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb4 = New System.Windows.Forms.RadioButton()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblWow = New System.Windows.Forms.Label()
        Me.PanWinner = New System.Windows.Forms.Panel()
        Me.panPrix = New System.Windows.Forms.Panel()
        Me.cmdReglement = New System.Windows.Forms.Button()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic5 = New System.Windows.Forms.PictureBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.pic4 = New System.Windows.Forms.PictureBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.pan1.SuspendLayout()
        Me.pan2.SuspendLayout()
        Me.pan3.SuspendLayout()
        Me.pan5.SuspendLayout()
        Me.panJeu.SuspendLayout()
        Me.panCartes.SuspendLayout()
        Me.pan4.SuspendLayout()
        Me.stBar.SuspendLayout()
        Me.panMise.SuspendLayout()
        Me.PanWinner.SuspendLayout()
        Me.panPrix.SuspendLayout()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cartes
        '
        Me.Cartes.ImageStream = CType(resources.GetObject("Cartes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Cartes.TransparentColor = System.Drawing.Color.Transparent
        Me.Cartes.Images.SetKeyName(0, "01c.gif")
        Me.Cartes.Images.SetKeyName(1, "02c.gif")
        Me.Cartes.Images.SetKeyName(2, "03c.gif")
        Me.Cartes.Images.SetKeyName(3, "04c.gif")
        Me.Cartes.Images.SetKeyName(4, "05c.gif")
        Me.Cartes.Images.SetKeyName(5, "06c.gif")
        Me.Cartes.Images.SetKeyName(6, "07c.gif")
        Me.Cartes.Images.SetKeyName(7, "08c.gif")
        Me.Cartes.Images.SetKeyName(8, "09c.gif")
        Me.Cartes.Images.SetKeyName(9, "10c.gif")
        Me.Cartes.Images.SetKeyName(10, "11c.gif")
        Me.Cartes.Images.SetKeyName(11, "12c.gif")
        Me.Cartes.Images.SetKeyName(12, "13c.gif")
        Me.Cartes.Images.SetKeyName(13, "01d.gif")
        Me.Cartes.Images.SetKeyName(14, "02d.gif")
        Me.Cartes.Images.SetKeyName(15, "03d.gif")
        Me.Cartes.Images.SetKeyName(16, "04d.gif")
        Me.Cartes.Images.SetKeyName(17, "05d.gif")
        Me.Cartes.Images.SetKeyName(18, "06d.gif")
        Me.Cartes.Images.SetKeyName(19, "07d.gif")
        Me.Cartes.Images.SetKeyName(20, "08d.gif")
        Me.Cartes.Images.SetKeyName(21, "09d.gif")
        Me.Cartes.Images.SetKeyName(22, "10d.gif")
        Me.Cartes.Images.SetKeyName(23, "11d.gif")
        Me.Cartes.Images.SetKeyName(24, "12d.gif")
        Me.Cartes.Images.SetKeyName(25, "13d.gif")
        Me.Cartes.Images.SetKeyName(26, "01h.gif")
        Me.Cartes.Images.SetKeyName(27, "02h.gif")
        Me.Cartes.Images.SetKeyName(28, "03h.gif")
        Me.Cartes.Images.SetKeyName(29, "04h.gif")
        Me.Cartes.Images.SetKeyName(30, "05h.gif")
        Me.Cartes.Images.SetKeyName(31, "06h.gif")
        Me.Cartes.Images.SetKeyName(32, "07h.gif")
        Me.Cartes.Images.SetKeyName(33, "08h.gif")
        Me.Cartes.Images.SetKeyName(34, "09h.gif")
        Me.Cartes.Images.SetKeyName(35, "10h.gif")
        Me.Cartes.Images.SetKeyName(36, "11h.gif")
        Me.Cartes.Images.SetKeyName(37, "12h.gif")
        Me.Cartes.Images.SetKeyName(38, "13h.gif")
        Me.Cartes.Images.SetKeyName(39, "01s.gif")
        Me.Cartes.Images.SetKeyName(40, "02s.gif")
        Me.Cartes.Images.SetKeyName(41, "03s.gif")
        Me.Cartes.Images.SetKeyName(42, "04s.gif")
        Me.Cartes.Images.SetKeyName(43, "05s.gif")
        Me.Cartes.Images.SetKeyName(44, "06s.gif")
        Me.Cartes.Images.SetKeyName(45, "07s.gif")
        Me.Cartes.Images.SetKeyName(46, "08s.gif")
        Me.Cartes.Images.SetKeyName(47, "09s.gif")
        Me.Cartes.Images.SetKeyName(48, "10s.gif")
        Me.Cartes.Images.SetKeyName(49, "11s.gif")
        Me.Cartes.Images.SetKeyName(50, "12s.gif")
        Me.Cartes.Images.SetKeyName(51, "13s.gif")
        '
        'pan1
        '
        Me.pan1.Controls.Add(Me.lbl1)
        Me.pan1.Controls.Add(Me.pic1)
        Me.pan1.Location = New System.Drawing.Point(5, 6)
        Me.pan1.Name = "pan1"
        Me.pan1.Size = New System.Drawing.Size(114, 197)
        Me.pan1.TabIndex = 10
        Me.pan1.Tag = "jeu"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Matura MT Script Capitals", 14.0!)
        Me.lbl1.Location = New System.Drawing.Point(18, 161)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(0, 25)
        Me.lbl1.TabIndex = 21
        Me.lbl1.Tag = "lbl"
        '
        'pan2
        '
        Me.pan2.Controls.Add(Me.lbl2)
        Me.pan2.Controls.Add(Me.pic2)
        Me.pan2.Location = New System.Drawing.Point(131, 6)
        Me.pan2.Name = "pan2"
        Me.pan2.Size = New System.Drawing.Size(118, 197)
        Me.pan2.TabIndex = 11
        Me.pan2.Tag = "jeu"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Matura MT Script Capitals", 14.0!)
        Me.lbl2.Location = New System.Drawing.Point(23, 161)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(0, 25)
        Me.lbl2.TabIndex = 25
        Me.lbl2.Tag = "lbl"
        '
        'pan3
        '
        Me.pan3.Controls.Add(Me.lbl3)
        Me.pan3.Controls.Add(Me.pic3)
        Me.pan3.Location = New System.Drawing.Point(259, 6)
        Me.pan3.Name = "pan3"
        Me.pan3.Size = New System.Drawing.Size(118, 197)
        Me.pan3.TabIndex = 12
        Me.pan3.Tag = "jeu"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Matura MT Script Capitals", 14.0!)
        Me.lbl3.Location = New System.Drawing.Point(19, 161)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(0, 25)
        Me.lbl3.TabIndex = 24
        Me.lbl3.Tag = "lbl"
        '
        'pan5
        '
        Me.pan5.Controls.Add(Me.lbl5)
        Me.pan5.Controls.Add(Me.pic5)
        Me.pan5.Location = New System.Drawing.Point(515, 6)
        Me.pan5.Name = "pan5"
        Me.pan5.Size = New System.Drawing.Size(118, 197)
        Me.pan5.TabIndex = 14
        Me.pan5.Tag = "jeu"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Matura MT Script Capitals", 14.0!)
        Me.lbl5.Location = New System.Drawing.Point(26, 161)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(0, 25)
        Me.lbl5.TabIndex = 22
        Me.lbl5.Tag = "lbl"
        '
        'panJeu
        '
        Me.panJeu.BackColor = System.Drawing.Color.DarkGreen
        Me.panJeu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panJeu.Controls.Add(Me.panCartes)
        Me.panJeu.Controls.Add(Me.lblNom)
        Me.panJeu.Controls.Add(Me.cmdJouer)
        Me.panJeu.Location = New System.Drawing.Point(12, 12)
        Me.panJeu.Name = "panJeu"
        Me.panJeu.Size = New System.Drawing.Size(651, 313)
        Me.panJeu.TabIndex = 12
        '
        'panCartes
        '
        Me.panCartes.Controls.Add(Me.pan2)
        Me.panCartes.Controls.Add(Me.pan5)
        Me.panCartes.Controls.Add(Me.pan3)
        Me.panCartes.Controls.Add(Me.pan4)
        Me.panCartes.Controls.Add(Me.pan1)
        Me.panCartes.Location = New System.Drawing.Point(3, 44)
        Me.panCartes.Name = "panCartes"
        Me.panCartes.Size = New System.Drawing.Size(645, 210)
        Me.panCartes.TabIndex = 20
        '
        'pan4
        '
        Me.pan4.Controls.Add(Me.lbl4)
        Me.pan4.Controls.Add(Me.pic4)
        Me.pan4.Location = New System.Drawing.Point(387, 6)
        Me.pan4.Name = "pan4"
        Me.pan4.Size = New System.Drawing.Size(118, 197)
        Me.pan4.TabIndex = 13
        Me.pan4.Tag = "jeu"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Matura MT Script Capitals", 14.0!)
        Me.lbl4.Location = New System.Drawing.Point(21, 161)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(0, 25)
        Me.lbl4.TabIndex = 23
        Me.lbl4.Tag = "lbl"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Bauhaus 93", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(196, 7)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(124, 30)
        Me.lblNom.TabIndex = 19
        Me.lblNom.Text = "Sans Nom"
        '
        'cmdJouer
        '
        Me.cmdJouer.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdJouer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdJouer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdJouer.Location = New System.Drawing.Point(202, 265)
        Me.cmdJouer.Name = "cmdJouer"
        Me.cmdJouer.Size = New System.Drawing.Size(209, 31)
        Me.cmdJouer.TabIndex = 12
        Me.cmdJouer.Text = "Donner cartes"
        Me.cmdJouer.UseVisualStyleBackColor = False
        '
        'txtGain
        '
        Me.txtGain.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGain.Location = New System.Drawing.Point(81, 7)
        Me.txtGain.Name = "txtGain"
        Me.txtGain.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtGain.Size = New System.Drawing.Size(159, 29)
        Me.txtGain.TabIndex = 15
        '
        'cmdQuitter
        '
        Me.cmdQuitter.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuitter.Location = New System.Drawing.Point(845, 273)
        Me.cmdQuitter.Name = "cmdQuitter"
        Me.cmdQuitter.Size = New System.Drawing.Size(85, 37)
        Me.cmdQuitter.TabIndex = 17
        Me.cmdQuitter.Text = "Quitter"
        Me.cmdQuitter.UseVisualStyleBackColor = False
        '
        'lblCredit
        '
        Me.lblCredit.AutoSize = True
        Me.lblCredit.Font = New System.Drawing.Font("Matura MT Script Capitals", 16.0!)
        Me.lblCredit.Location = New System.Drawing.Point(678, 23)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(87, 29)
        Me.lblCredit.TabIndex = 18
        Me.lblCredit.Text = "Crédit :"
        '
        'lblMise
        '
        Me.lblMise.AutoSize = True
        Me.lblMise.Font = New System.Drawing.Font("Matura MT Script Capitals", 16.0!)
        Me.lblMise.Location = New System.Drawing.Point(680, 73)
        Me.lblMise.Name = "lblMise"
        Me.lblMise.Size = New System.Drawing.Size(85, 29)
        Me.lblMise.TabIndex = 19
        Me.lblMise.Text = "Mise :"
        '
        'lblGain
        '
        Me.lblGain.AutoSize = True
        Me.lblGain.Font = New System.Drawing.Font("Matura MT Script Capitals", 16.0!)
        Me.lblGain.Location = New System.Drawing.Point(3, 7)
        Me.lblGain.Name = "lblGain"
        Me.lblGain.Size = New System.Drawing.Size(72, 29)
        Me.lblGain.TabIndex = 20
        Me.lblGain.Text = "Gain :"
        '
        'txtCredits
        '
        Me.txtCredits.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCredits.Location = New System.Drawing.Point(771, 23)
        Me.txtCredits.Name = "txtCredits"
        Me.txtCredits.ReadOnly = True
        Me.txtCredits.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCredits.Size = New System.Drawing.Size(159, 29)
        Me.txtCredits.TabIndex = 21
        '
        'stBar
        '
        Me.stBar.BackColor = System.Drawing.Color.White
        Me.stBar.Enabled = False
        Me.stBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.stBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblstMsg})
        Me.stBar.Location = New System.Drawing.Point(0, 341)
        Me.stBar.Name = "stBar"
        Me.stBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.stBar.Size = New System.Drawing.Size(941, 22)
        Me.stBar.TabIndex = 100
        '
        'lblstMsg
        '
        Me.lblstMsg.Enabled = False
        Me.lblstMsg.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblstMsg.Name = "lblstMsg"
        Me.lblstMsg.Size = New System.Drawing.Size(0, 17)
        Me.lblstMsg.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'panMise
        '
        Me.panMise.Controls.Add(Me.rb2)
        Me.panMise.Controls.Add(Me.rb4)
        Me.panMise.Controls.Add(Me.rb3)
        Me.panMise.Controls.Add(Me.rb1)
        Me.panMise.Location = New System.Drawing.Point(771, 73)
        Me.panMise.Name = "panMise"
        Me.panMise.Size = New System.Drawing.Size(159, 31)
        Me.panMise.TabIndex = 23
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb2.Location = New System.Drawing.Point(42, 4)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(34, 21)
        Me.rb2.TabIndex = 3
        Me.rb2.TabStop = True
        Me.rb2.Tag = "mise"
        Me.rb2.Text = "2"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'rb4
        '
        Me.rb4.AutoSize = True
        Me.rb4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb4.Location = New System.Drawing.Point(118, 4)
        Me.rb4.Name = "rb4"
        Me.rb4.Size = New System.Drawing.Size(34, 21)
        Me.rb4.TabIndex = 2
        Me.rb4.TabStop = True
        Me.rb4.Tag = "mise"
        Me.rb4.Text = "4"
        Me.rb4.UseVisualStyleBackColor = True
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb3.Location = New System.Drawing.Point(82, 4)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(34, 21)
        Me.rb3.TabIndex = 1
        Me.rb3.TabStop = True
        Me.rb3.Tag = "mise"
        Me.rb3.Text = "3"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb1.Location = New System.Drawing.Point(4, 4)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(34, 21)
        Me.rb1.TabIndex = 0
        Me.rb1.TabStop = True
        Me.rb1.Tag = "mise"
        Me.rb1.Text = "1"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.Font = New System.Drawing.Font("Bauhaus 93", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.Black
        Me.lblResult.Location = New System.Drawing.Point(17, 49)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(628, 54)
        Me.lblResult.TabIndex = 21
        Me.lblResult.Text = "Hola"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblResult.UseCompatibleTextRendering = True
        '
        'lblWow
        '
        Me.lblWow.AutoSize = True
        Me.lblWow.Font = New System.Drawing.Font("Matura MT Script Capitals", 18.0!)
        Me.lblWow.ForeColor = System.Drawing.Color.Black
        Me.lblWow.Location = New System.Drawing.Point(256, 9)
        Me.lblWow.Name = "lblWow"
        Me.lblWow.Size = New System.Drawing.Size(150, 38)
        Me.lblWow.TabIndex = 24
        Me.lblWow.Text = "WOW !!!!!"
        Me.lblWow.UseCompatibleTextRendering = True
        '
        'PanWinner
        '
        Me.PanWinner.AutoSize = True
        Me.PanWinner.BackColor = System.Drawing.Color.YellowGreen
        Me.PanWinner.Controls.Add(Me.lblResult)
        Me.PanWinner.Controls.Add(Me.lblWow)
        Me.PanWinner.Location = New System.Drawing.Point(12, 160)
        Me.PanWinner.Name = "PanWinner"
        Me.PanWinner.Size = New System.Drawing.Size(660, 109)
        Me.PanWinner.TabIndex = 200
        Me.PanWinner.TabStop = True
        Me.PanWinner.Tag = ""
        Me.PanWinner.Visible = False
        '
        'panPrix
        '
        Me.panPrix.Controls.Add(Me.lblGain)
        Me.panPrix.Controls.Add(Me.txtGain)
        Me.panPrix.Location = New System.Drawing.Point(690, 215)
        Me.panPrix.Name = "panPrix"
        Me.panPrix.Size = New System.Drawing.Size(250, 45)
        Me.panPrix.TabIndex = 201
        Me.panPrix.Visible = False
        '
        'cmdReglement
        '
        Me.cmdReglement.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdReglement.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdReglement.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReglement.Location = New System.Drawing.Point(698, 273)
        Me.cmdReglement.Name = "cmdReglement"
        Me.cmdReglement.Size = New System.Drawing.Size(85, 37)
        Me.cmdReglement.TabIndex = 202
        Me.cmdReglement.Text = "Guide"
        Me.cmdReglement.UseVisualStyleBackColor = False
        '
        'pic2
        '
        Me.pic2.Location = New System.Drawing.Point(9, 13)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(99, 139)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 0
        Me.pic2.TabStop = False
        Me.pic2.Tag = "carte"
        '
        'pic5
        '
        Me.pic5.Location = New System.Drawing.Point(6, 13)
        Me.pic5.Name = "pic5"
        Me.pic5.Size = New System.Drawing.Size(108, 139)
        Me.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic5.TabIndex = 0
        Me.pic5.TabStop = False
        Me.pic5.Tag = "carte"
        '
        'pic3
        '
        Me.pic3.Location = New System.Drawing.Point(10, 14)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(99, 139)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic3.TabIndex = 0
        Me.pic3.TabStop = False
        Me.pic3.Tag = "carte"
        '
        'pic4
        '
        Me.pic4.Location = New System.Drawing.Point(10, 13)
        Me.pic4.Name = "pic4"
        Me.pic4.Size = New System.Drawing.Size(99, 139)
        Me.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic4.TabIndex = 0
        Me.pic4.TabStop = False
        Me.pic4.Tag = "carte"
        '
        'pic1
        '
        Me.pic1.Location = New System.Drawing.Point(8, 13)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(99, 139)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 0
        Me.pic1.TabStop = False
        Me.pic1.Tag = "carte"
        '
        'frmPoker
        '
        Me.AcceptButton = Me.cmdJouer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.CancelButton = Me.cmdQuitter
        Me.ClientSize = New System.Drawing.Size(941, 363)
        Me.Controls.Add(Me.cmdReglement)
        Me.Controls.Add(Me.panPrix)
        Me.Controls.Add(Me.PanWinner)
        Me.Controls.Add(Me.panMise)
        Me.Controls.Add(Me.stBar)
        Me.Controls.Add(Me.txtCredits)
        Me.Controls.Add(Me.lblMise)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.cmdQuitter)
        Me.Controls.Add(Me.panJeu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPoker"
        Me.ShowIcon = False
        Me.Text = "SEXY POKER !"
        Me.pan1.ResumeLayout(False)
        Me.pan1.PerformLayout()
        Me.pan2.ResumeLayout(False)
        Me.pan2.PerformLayout()
        Me.pan3.ResumeLayout(False)
        Me.pan3.PerformLayout()
        Me.pan5.ResumeLayout(False)
        Me.pan5.PerformLayout()
        Me.panJeu.ResumeLayout(False)
        Me.panJeu.PerformLayout()
        Me.panCartes.ResumeLayout(False)
        Me.pan4.ResumeLayout(False)
        Me.pan4.PerformLayout()
        Me.stBar.ResumeLayout(False)
        Me.stBar.PerformLayout()
        Me.panMise.ResumeLayout(False)
        Me.panMise.PerformLayout()
        Me.PanWinner.ResumeLayout(False)
        Me.PanWinner.PerformLayout()
        Me.panPrix.ResumeLayout(False)
        Me.panPrix.PerformLayout()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents Cartes As System.Windows.Forms.ImageList
    Friend WithEvents pan1 As System.Windows.Forms.Panel
    Friend WithEvents pan2 As System.Windows.Forms.Panel
    Friend WithEvents pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents pan3 As System.Windows.Forms.Panel
    Friend WithEvents pic3 As System.Windows.Forms.PictureBox
    Friend WithEvents pan5 As System.Windows.Forms.Panel
    Friend WithEvents pic5 As System.Windows.Forms.PictureBox
    Friend WithEvents panJeu As System.Windows.Forms.Panel
    Friend WithEvents cmdJouer As System.Windows.Forms.Button
    Friend WithEvents txtGain As System.Windows.Forms.TextBox
    Friend WithEvents cmdQuitter As System.Windows.Forms.Button
    Friend WithEvents lblCredit As System.Windows.Forms.Label
    Friend WithEvents lblMise As System.Windows.Forms.Label
    Friend WithEvents lblGain As System.Windows.Forms.Label
    Friend WithEvents pan4 As System.Windows.Forms.Panel
    Friend WithEvents pic4 As System.Windows.Forms.PictureBox
    Friend WithEvents txtCredits As System.Windows.Forms.TextBox
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents stBar As System.Windows.Forms.StatusStrip
    Friend WithEvents panMise As System.Windows.Forms.Panel
    Friend WithEvents rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb4 As System.Windows.Forms.RadioButton
    Friend WithEvents rb3 As System.Windows.Forms.RadioButton
    Friend WithEvents rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents panCartes As System.Windows.Forms.Panel
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents lblWow As System.Windows.Forms.Label
    Friend WithEvents lblstMsg As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PanWinner As System.Windows.Forms.Panel
    Friend WithEvents panPrix As System.Windows.Forms.Panel
    Friend WithEvents cmdReglement As System.Windows.Forms.Button

End Class
