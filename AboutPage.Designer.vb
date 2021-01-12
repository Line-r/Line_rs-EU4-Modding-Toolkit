<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AboutPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutPage))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGithub = New System.Windows.Forms.Button()
        Me.btnDiscord = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-13, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "------------------------------------"
        '
        'btnGithub
        '
        Me.btnGithub.BackgroundImage = CType(resources.GetObject("btnGithub.BackgroundImage"), System.Drawing.Image)
        Me.btnGithub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGithub.Location = New System.Drawing.Point(12, 160)
        Me.btnGithub.Name = "btnGithub"
        Me.btnGithub.Size = New System.Drawing.Size(40, 40)
        Me.btnGithub.TabIndex = 1
        Me.btnGithub.UseVisualStyleBackColor = True
        '
        'btnDiscord
        '
        Me.btnDiscord.BackgroundImage = CType(resources.GetObject("btnDiscord.BackgroundImage"), System.Drawing.Image)
        Me.btnDiscord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDiscord.Location = New System.Drawing.Point(121, 160)
        Me.btnDiscord.Name = "btnDiscord"
        Me.btnDiscord.Size = New System.Drawing.Size(40, 40)
        Me.btnDiscord.TabIndex = 1
        Me.btnDiscord.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(6, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 63)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Line_r's" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Europa Universalis IV" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Modding Toolkit"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label3.Location = New System.Drawing.Point(6, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Registered under GNU GPLv3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 15)
        Me.Label4.TabIndex = 3
        '
        'AboutPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(173, 232)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDiscord)
        Me.Controls.Add(Me.btnGithub)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AboutPage"
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnGithub As Button
    Friend WithEvents btnDiscord As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
