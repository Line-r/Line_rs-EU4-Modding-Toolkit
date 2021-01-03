<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtCountryName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTag = New System.Windows.Forms.TextBox()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMonarch = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLeader = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbGraphicalCulture = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAdjective = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkFixed = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCapital = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPrimaryCulture = New System.Windows.Forms.TextBox()
        Me.txtMercantilism = New System.Windows.Forms.TextBox()
        Me.cmbReligion = New System.Windows.Forms.ComboBox()
        Me.cmbTech = New System.Windows.Forms.ComboBox()
        Me.cmbGovernment = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnFlag = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.fbdModDirectory = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.mnuMain.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCountryName
        '
        Me.txtCountryName.Location = New System.Drawing.Point(114, 31)
        Me.txtCountryName.Name = "txtCountryName"
        Me.txtCountryName.Size = New System.Drawing.Size(119, 23)
        Me.txtCountryName.TabIndex = 0
        Me.txtCountryName.Text = "Bohemia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Country Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Country Tag:"
        '
        'txtTag
        '
        Me.txtTag.Location = New System.Drawing.Point(114, 88)
        Me.txtTag.Name = "txtTag"
        Me.txtTag.Size = New System.Drawing.Size(119, 23)
        Me.txtTag.TabIndex = 0
        Me.txtTag.Text = "BOH"
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnuMain.Size = New System.Drawing.Size(738, 24)
        Me.mnuMain.TabIndex = 3
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpen, Me.toolStripSeparator, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuOpen
        '
        Me.mnuOpen.Image = CType(resources.GetObject("mnuOpen.Image"), System.Drawing.Image)
        Me.mnuOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOpen.Size = New System.Drawing.Size(146, 22)
        Me.mnuOpen.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(143, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(146, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Graphical Culture:"
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(114, 145)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(119, 23)
        Me.txtColor.TabIndex = 0
        Me.txtColor.Text = "161  139  40"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Color:"
        '
        'txtMonarch
        '
        Me.txtMonarch.Location = New System.Drawing.Point(114, 176)
        Me.txtMonarch.Name = "txtMonarch"
        Me.txtMonarch.Size = New System.Drawing.Size(119, 23)
        Me.txtMonarch.TabIndex = 0
        Me.txtMonarch.Text = "Václav #4"" = 50"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Monarch name:"
        '
        'txtLeader
        '
        Me.txtLeader.Location = New System.Drawing.Point(114, 210)
        Me.txtLeader.Name = "txtLeader"
        Me.txtLeader.Size = New System.Drawing.Size(119, 23)
        Me.txtLeader.TabIndex = 0
        Me.txtLeader.Text = "Zajíc"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Leader name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbGraphicalCulture)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtAdjective)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCountryName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTag)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtColor)
        Me.GroupBox1.Controls.Add(Me.txtLeader)
        Me.GroupBox1.Controls.Add(Me.txtMonarch)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 247)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Country File"
        '
        'cmbGraphicalCulture
        '
        Me.cmbGraphicalCulture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGraphicalCulture.FormattingEnabled = True
        Me.cmbGraphicalCulture.Items.AddRange(New Object() {"westerngfx", "easterngfx", "muslimgfx", "indiangfx", "asiangfx", "africangfx", "northamericagfx", "southamericagfx", "inuitgfx"})
        Me.cmbGraphicalCulture.Location = New System.Drawing.Point(114, 116)
        Me.cmbGraphicalCulture.Name = "cmbGraphicalCulture"
        Me.cmbGraphicalCulture.Size = New System.Drawing.Size(119, 23)
        Me.cmbGraphicalCulture.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 15)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Adjective:"
        '
        'txtAdjective
        '
        Me.txtAdjective.Location = New System.Drawing.Point(114, 59)
        Me.txtAdjective.Name = "txtAdjective"
        Me.txtAdjective.Size = New System.Drawing.Size(119, 23)
        Me.txtAdjective.TabIndex = 0
        Me.txtAdjective.Text = "Bohemian"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkFixed)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtCapital)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtPrimaryCulture)
        Me.GroupBox2.Controls.Add(Me.txtMercantilism)
        Me.GroupBox2.Controls.Add(Me.cmbReligion)
        Me.GroupBox2.Controls.Add(Me.cmbTech)
        Me.GroupBox2.Controls.Add(Me.cmbGovernment)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(307, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(241, 247)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Country History"
        '
        'chkFixed
        '
        Me.chkFixed.AutoSize = True
        Me.chkFixed.Location = New System.Drawing.Point(107, 208)
        Me.chkFixed.Name = "chkFixed"
        Me.chkFixed.Size = New System.Drawing.Size(58, 19)
        Me.chkFixed.TabIndex = 6
        Me.chkFixed.Text = "Fixed?"
        Me.chkFixed.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 182)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 15)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Capital:"
        '
        'txtCapital
        '
        Me.txtCapital.Location = New System.Drawing.Point(107, 179)
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.Size = New System.Drawing.Size(121, 23)
        Me.txtCapital.TabIndex = 2
        Me.txtCapital.Text = "266"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 15)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Primary Culture:"
        '
        'txtPrimaryCulture
        '
        Me.txtPrimaryCulture.Location = New System.Drawing.Point(107, 148)
        Me.txtPrimaryCulture.Name = "txtPrimaryCulture"
        Me.txtPrimaryCulture.Size = New System.Drawing.Size(121, 23)
        Me.txtPrimaryCulture.TabIndex = 2
        Me.txtPrimaryCulture.Text = "czech"
        '
        'txtMercantilism
        '
        Me.txtMercantilism.Location = New System.Drawing.Point(107, 62)
        Me.txtMercantilism.Name = "txtMercantilism"
        Me.txtMercantilism.Size = New System.Drawing.Size(121, 23)
        Me.txtMercantilism.TabIndex = 2
        Me.txtMercantilism.Text = "10"
        '
        'cmbReligion
        '
        Me.cmbReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReligion.FormattingEnabled = True
        Me.cmbReligion.Items.AddRange(New Object() {"Catholic", "Protestant", "Reformed", "Orthodox", "Coptic", "Anglican", "Hussite", "Sunni", "Shia", "Ibadi", "Mahayana", "Theravada", "Vajrayana", "Confucian", "Shinto", "Animist", "Fetishist", "Totemist", "Inti", "Mayan", "Nahuatl", "Tengri", "Norse", "Hindu", "Sikh", "Jewish", "Zoroastrian"})
        Me.cmbReligion.Location = New System.Drawing.Point(107, 120)
        Me.cmbReligion.Name = "cmbReligion"
        Me.cmbReligion.Size = New System.Drawing.Size(121, 23)
        Me.cmbReligion.TabIndex = 1
        '
        'cmbTech
        '
        Me.cmbTech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTech.FormattingEnabled = True
        Me.cmbTech.Items.AddRange(New Object() {"western", "high_american", "eastern", "anatolian", "muslim", "indian", "east_african", "chinese", "west_african", "central_african", "nomadic", "mesoamerican", "andean", "north_american", "south_american"})
        Me.cmbTech.Location = New System.Drawing.Point(107, 91)
        Me.cmbTech.Name = "cmbTech"
        Me.cmbTech.Size = New System.Drawing.Size(121, 23)
        Me.cmbTech.TabIndex = 1
        '
        'cmbGovernment
        '
        Me.cmbGovernment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGovernment.FormattingEnabled = True
        Me.cmbGovernment.Items.AddRange(New Object() {"monarchy", "republic", "tribal", "native", "theocracy"})
        Me.cmbGovernment.Location = New System.Drawing.Point(107, 31)
        Me.cmbGovernment.Name = "cmbGovernment"
        Me.cmbGovernment.Size = New System.Drawing.Size(121, 23)
        Me.cmbGovernment.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Mercantilism:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Religion:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Tech Group:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Government:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(582, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'btnFlag
        '
        Me.btnFlag.Location = New System.Drawing.Point(582, 38)
        Me.btnFlag.Name = "btnFlag"
        Me.btnFlag.Size = New System.Drawing.Size(75, 23)
        Me.btnFlag.TabIndex = 8
        Me.btnFlag.Text = "Select Flag"
        Me.btnFlag.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(582, 262)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(128, 23)
        Me.btnGenerate.TabIndex = 8
        Me.btnGenerate.Text = "Generate Country"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 303)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 15)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Debug"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 330)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.btnFlag)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mnuMain)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCountryName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTag As TextBox
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents txtColor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMonarch As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLeader As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCapital As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPrimaryCulture As TextBox
    Friend WithEvents txtMercantilism As TextBox
    Friend WithEvents cmbReligion As ComboBox
    Friend WithEvents cmbTech As ComboBox
    Friend WithEvents cmbGovernment As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtAdjective As TextBox
    Friend WithEvents chkFixed As CheckBox
    Friend WithEvents cmbGraphicalCulture As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnFlag As Button
    Friend WithEvents btnGenerate As Button
    Friend WithEvents mnuOpen As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents fbdModDirectory As FolderBrowserDialog
    Friend WithEvents Label14 As Label
End Class
