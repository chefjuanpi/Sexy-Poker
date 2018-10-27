<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWellcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWellcome))
        Me.lblElle = New System.Windows.Forms.Label()
        Me.timAuto = New System.Windows.Forms.Timer(Me.components)
        Me.stBar = New System.Windows.Forms.StatusStrip()
        Me.stlAlert = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtToi = New System.Windows.Forms.TextBox()
        Me.cmdEnter = New System.Windows.Forms.Button()
        Me.panToi = New System.Windows.Forms.Panel()
        Me.grpCase = New System.Windows.Forms.GroupBox()
        Me.cbCredits = New System.Windows.Forms.ComboBox()
        Me.lblCredits = New System.Windows.Forms.Label()
        Me.stBar.SuspendLayout()
        Me.panToi.SuspendLayout()
        Me.grpCase.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblElle
        '
        Me.lblElle.AutoSize = True
        Me.lblElle.Enabled = False
        Me.lblElle.Font = New System.Drawing.Font("Bauhaus 93", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElle.Location = New System.Drawing.Point(243, 43)
        Me.lblElle.Name = "lblElle"
        Me.lblElle.Size = New System.Drawing.Size(555, 39)
        Me.lblElle.TabIndex = 0
        Me.lblElle.Text = "Bonjour, asseyez-vous pour jouer... "
        '
        'timAuto
        '
        Me.timAuto.Enabled = True
        Me.timAuto.Interval = 3000
        '
        'stBar
        '
        Me.stBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stlAlert})
        Me.stBar.Location = New System.Drawing.Point(0, 411)
        Me.stBar.Name = "stBar"
        Me.stBar.Size = New System.Drawing.Size(815, 22)
        Me.stBar.TabIndex = 2
        Me.stBar.Text = "StatusStrip1"
        '
        'stlAlert
        '
        Me.stlAlert.Name = "stlAlert"
        Me.stlAlert.Size = New System.Drawing.Size(0, 17)
        '
        'txtToi
        '
        Me.txtToi.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToi.Location = New System.Drawing.Point(12, 16)
        Me.txtToi.MaxLength = 20
        Me.txtToi.Name = "txtToi"
        Me.txtToi.Size = New System.Drawing.Size(167, 29)
        Me.txtToi.TabIndex = 0
        '
        'cmdEnter
        '
        Me.cmdEnter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdEnter.Location = New System.Drawing.Point(177, 16)
        Me.cmdEnter.Name = "cmdEnter"
        Me.cmdEnter.Size = New System.Drawing.Size(16, 29)
        Me.cmdEnter.TabIndex = 3
        Me.cmdEnter.UseVisualStyleBackColor = True
        '
        'panToi
        '
        Me.panToi.BackColor = System.Drawing.Color.Transparent
        Me.panToi.Controls.Add(Me.cmdEnter)
        Me.panToi.Controls.Add(Me.txtToi)
        Me.panToi.Location = New System.Drawing.Point(601, 353)
        Me.panToi.Name = "panToi"
        Me.panToi.Size = New System.Drawing.Size(202, 55)
        Me.panToi.TabIndex = 4
        Me.panToi.Visible = False
        '
        'grpCase
        '
        Me.grpCase.BackColor = System.Drawing.Color.DarkGreen
        Me.grpCase.Controls.Add(Me.cbCredits)
        Me.grpCase.Controls.Add(Me.lblCredits)
        Me.grpCase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCase.ForeColor = System.Drawing.Color.White
        Me.grpCase.Location = New System.Drawing.Point(576, 263)
        Me.grpCase.Name = "grpCase"
        Me.grpCase.Size = New System.Drawing.Size(227, 84)
        Me.grpCase.TabIndex = 5
        Me.grpCase.TabStop = False
        Me.grpCase.Text = "Case"
        Me.grpCase.Visible = False
        '
        'cbCredits
        '
        Me.cbCredits.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbCredits.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCredits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCredits.FormatString = "9999"
        Me.cbCredits.FormattingEnabled = True
        Me.cbCredits.Items.AddRange(New Object() {"100", "300", "500", "700", "1000"})
        Me.cbCredits.Location = New System.Drawing.Point(89, 36)
        Me.cbCredits.Name = "cbCredits"
        Me.cbCredits.Size = New System.Drawing.Size(121, 28)
        Me.cbCredits.TabIndex = 1
        '
        'lblCredits
        '
        Me.lblCredits.AutoSize = True
        Me.lblCredits.Location = New System.Drawing.Point(16, 39)
        Me.lblCredits.Name = "lblCredits"
        Me.lblCredits.Size = New System.Drawing.Size(67, 20)
        Me.lblCredits.TabIndex = 0
        Me.lblCredits.Text = "Credits :"
        '
        'frmWellcome
        '
        Me.AcceptButton = Me.cmdEnter
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(815, 433)
        Me.Controls.Add(Me.grpCase)
        Me.Controls.Add(Me.panToi)
        Me.Controls.Add(Me.stBar)
        Me.Controls.Add(Me.lblElle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.MaximizeBox = False
        Me.Name = "frmWellcome"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sexy Poker"
        Me.stBar.ResumeLayout(False)
        Me.stBar.PerformLayout()
        Me.panToi.ResumeLayout(False)
        Me.panToi.PerformLayout()
        Me.grpCase.ResumeLayout(False)
        Me.grpCase.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblElle As System.Windows.Forms.Label
    Friend WithEvents timAuto As System.Windows.Forms.Timer
    Friend WithEvents stBar As System.Windows.Forms.StatusStrip
    Friend WithEvents txtToi As System.Windows.Forms.TextBox
    Friend WithEvents stlAlert As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmdEnter As System.Windows.Forms.Button
    Friend WithEvents panToi As System.Windows.Forms.Panel
    Friend WithEvents grpCase As System.Windows.Forms.GroupBox
    Friend WithEvents lblCredits As System.Windows.Forms.Label
    Friend WithEvents cbCredits As System.Windows.Forms.ComboBox
End Class
