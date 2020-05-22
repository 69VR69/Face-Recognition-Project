<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAnnotation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnnotation))
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.pnlAnnotation = New System.Windows.Forms.Panel()
        Me.pnlBC = New System.Windows.Forms.Panel()
        Me.pnlBN = New System.Windows.Forms.Panel()
        Me.pnlLL = New System.Windows.Forms.Panel()
        Me.pnlRL = New System.Windows.Forms.Panel()
        Me.pnlSNR = New System.Windows.Forms.Panel()
        Me.pnlBL = New System.Windows.Forms.Panel()
        Me.pnlTL = New System.Windows.Forms.Panel()
        Me.pnlSNL = New System.Windows.Forms.Panel()
        Me.pnlSFR = New System.Windows.Forms.Panel()
        Me.pnlSFL = New System.Windows.Forms.Panel()
        Me.pnlE2 = New System.Windows.Forms.Panel()
        Me.pnlE1 = New System.Windows.Forms.Panel()
        Me.pnlAnnotation.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(391, 446)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(63, 34)
        Me.btnConfirm.TabIndex = 1
        Me.btnConfirm.Text = "save"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(0, 449)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 31)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(78, 450)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(316, 28)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlAnnotation
        '
        Me.pnlAnnotation.AllowDrop = True
        Me.pnlAnnotation.BackgroundImage = CType(resources.GetObject("pnlAnnotation.BackgroundImage"), System.Drawing.Image)
        Me.pnlAnnotation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlAnnotation.Controls.Add(Me.pnlBC)
        Me.pnlAnnotation.Controls.Add(Me.pnlBN)
        Me.pnlAnnotation.Controls.Add(Me.pnlLL)
        Me.pnlAnnotation.Controls.Add(Me.pnlRL)
        Me.pnlAnnotation.Controls.Add(Me.pnlSNR)
        Me.pnlAnnotation.Controls.Add(Me.pnlBL)
        Me.pnlAnnotation.Controls.Add(Me.pnlTL)
        Me.pnlAnnotation.Controls.Add(Me.pnlSNL)
        Me.pnlAnnotation.Controls.Add(Me.pnlSFR)
        Me.pnlAnnotation.Controls.Add(Me.pnlSFL)
        Me.pnlAnnotation.Controls.Add(Me.pnlE2)
        Me.pnlAnnotation.Controls.Add(Me.pnlE1)
        Me.pnlAnnotation.Location = New System.Drawing.Point(0, 0)
        Me.pnlAnnotation.Name = "pnlAnnotation"
        Me.pnlAnnotation.Size = New System.Drawing.Size(454, 447)
        Me.pnlAnnotation.TabIndex = 0
        '
        'pnlBC
        '
        Me.pnlBC.AutoSize = True
        Me.pnlBC.BackColor = System.Drawing.Color.Transparent
        Me.pnlBC.BackgroundImage = CType(resources.GetObject("pnlBC.BackgroundImage"), System.Drawing.Image)
        Me.pnlBC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlBC.Location = New System.Drawing.Point(411, 84)
        Me.pnlBC.Name = "pnlBC"
        Me.pnlBC.Size = New System.Drawing.Size(30, 30)
        Me.pnlBC.TabIndex = 18
        Me.pnlBC.Tag = "Bottom of the chin"
        '
        'pnlBN
        '
        Me.pnlBN.AutoSize = True
        Me.pnlBN.BackColor = System.Drawing.Color.Transparent
        Me.pnlBN.BackgroundImage = CType(resources.GetObject("pnlBN.BackgroundImage"), System.Drawing.Image)
        Me.pnlBN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlBN.Location = New System.Drawing.Point(411, 156)
        Me.pnlBN.Name = "pnlBN"
        Me.pnlBN.Size = New System.Drawing.Size(30, 30)
        Me.pnlBN.TabIndex = 17
        Me.pnlBN.Tag = "Bottom of the nose"
        '
        'pnlLL
        '
        Me.pnlLL.AutoSize = True
        Me.pnlLL.BackColor = System.Drawing.Color.Transparent
        Me.pnlLL.BackgroundImage = CType(resources.GetObject("pnlLL.BackgroundImage"), System.Drawing.Image)
        Me.pnlLL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlLL.Location = New System.Drawing.Point(411, 192)
        Me.pnlLL.Name = "pnlLL"
        Me.pnlLL.Size = New System.Drawing.Size(30, 30)
        Me.pnlLL.TabIndex = 16
        Me.pnlLL.Tag = "Left side of the lips"
        '
        'pnlRL
        '
        Me.pnlRL.AutoSize = True
        Me.pnlRL.BackColor = System.Drawing.Color.Transparent
        Me.pnlRL.BackgroundImage = CType(resources.GetObject("pnlRL.BackgroundImage"), System.Drawing.Image)
        Me.pnlRL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlRL.Location = New System.Drawing.Point(411, 228)
        Me.pnlRL.Name = "pnlRL"
        Me.pnlRL.Size = New System.Drawing.Size(30, 30)
        Me.pnlRL.TabIndex = 15
        Me.pnlRL.Tag = "Right side of the lips"
        '
        'pnlSNR
        '
        Me.pnlSNR.AutoSize = True
        Me.pnlSNR.BackColor = System.Drawing.Color.Transparent
        Me.pnlSNR.BackgroundImage = CType(resources.GetObject("pnlSNR.BackgroundImage"), System.Drawing.Image)
        Me.pnlSNR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlSNR.Location = New System.Drawing.Point(411, 372)
        Me.pnlSNR.Name = "pnlSNR"
        Me.pnlSNR.Size = New System.Drawing.Size(30, 30)
        Me.pnlSNR.TabIndex = 14
        Me.pnlSNR.Tag = "Right side of the nose"
        '
        'pnlBL
        '
        Me.pnlBL.AutoSize = True
        Me.pnlBL.BackColor = System.Drawing.Color.Transparent
        Me.pnlBL.BackgroundImage = CType(resources.GetObject("pnlBL.BackgroundImage"), System.Drawing.Image)
        Me.pnlBL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlBL.Location = New System.Drawing.Point(411, 120)
        Me.pnlBL.Name = "pnlBL"
        Me.pnlBL.Size = New System.Drawing.Size(30, 30)
        Me.pnlBL.TabIndex = 13
        Me.pnlBL.Tag = "Bottom of the lips"
        '
        'pnlTL
        '
        Me.pnlTL.AutoSize = True
        Me.pnlTL.BackColor = System.Drawing.Color.Transparent
        Me.pnlTL.BackgroundImage = CType(resources.GetObject("pnlTL.BackgroundImage"), System.Drawing.Image)
        Me.pnlTL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlTL.Location = New System.Drawing.Point(411, 408)
        Me.pnlTL.Name = "pnlTL"
        Me.pnlTL.Size = New System.Drawing.Size(30, 30)
        Me.pnlTL.TabIndex = 13
        Me.pnlTL.Tag = "Top of the lips"
        '
        'pnlSNL
        '
        Me.pnlSNL.AutoSize = True
        Me.pnlSNL.BackColor = System.Drawing.Color.Transparent
        Me.pnlSNL.BackgroundImage = CType(resources.GetObject("pnlSNL.BackgroundImage"), System.Drawing.Image)
        Me.pnlSNL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlSNL.Location = New System.Drawing.Point(411, 336)
        Me.pnlSNL.Name = "pnlSNL"
        Me.pnlSNL.Size = New System.Drawing.Size(30, 30)
        Me.pnlSNL.TabIndex = 13
        Me.pnlSNL.Tag = "Left side of the nose"
        '
        'pnlSFR
        '
        Me.pnlSFR.AutoSize = True
        Me.pnlSFR.BackColor = System.Drawing.Color.Transparent
        Me.pnlSFR.BackgroundImage = CType(resources.GetObject("pnlSFR.BackgroundImage"), System.Drawing.Image)
        Me.pnlSFR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlSFR.Location = New System.Drawing.Point(411, 300)
        Me.pnlSFR.Name = "pnlSFR"
        Me.pnlSFR.Size = New System.Drawing.Size(30, 30)
        Me.pnlSFR.TabIndex = 13
        Me.pnlSFR.Tag = "Right side of the face"
        '
        'pnlSFL
        '
        Me.pnlSFL.AutoSize = True
        Me.pnlSFL.BackColor = System.Drawing.Color.Transparent
        Me.pnlSFL.BackgroundImage = CType(resources.GetObject("pnlSFL.BackgroundImage"), System.Drawing.Image)
        Me.pnlSFL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlSFL.Location = New System.Drawing.Point(411, 264)
        Me.pnlSFL.Name = "pnlSFL"
        Me.pnlSFL.Size = New System.Drawing.Size(30, 30)
        Me.pnlSFL.TabIndex = 13
        Me.pnlSFL.Tag = "Left side of the face"
        '
        'pnlE2
        '
        Me.pnlE2.AutoSize = True
        Me.pnlE2.BackColor = System.Drawing.Color.Transparent
        Me.pnlE2.BackgroundImage = CType(resources.GetObject("pnlE2.BackgroundImage"), System.Drawing.Image)
        Me.pnlE2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlE2.Location = New System.Drawing.Point(411, 48)
        Me.pnlE2.Name = "pnlE2"
        Me.pnlE2.Size = New System.Drawing.Size(30, 30)
        Me.pnlE2.TabIndex = 13
        Me.pnlE2.Tag = "Center of the right eye"
        '
        'pnlE1
        '
        Me.pnlE1.AutoSize = True
        Me.pnlE1.BackColor = System.Drawing.Color.Transparent
        Me.pnlE1.BackgroundImage = CType(resources.GetObject("pnlE1.BackgroundImage"), System.Drawing.Image)
        Me.pnlE1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlE1.Location = New System.Drawing.Point(411, 12)
        Me.pnlE1.Name = "pnlE1"
        Me.pnlE1.Size = New System.Drawing.Size(30, 30)
        Me.pnlE1.TabIndex = 12
        Me.pnlE1.Tag = "Center of the left eye"
        '
        'frmAnnotation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 480)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.pnlAnnotation)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnConfirm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAnnotation"
        Me.Text = "FRP"
        Me.pnlAnnotation.ResumeLayout(False)
        Me.pnlAnnotation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents pnlAnnotation As Panel
    Friend WithEvents pnlBC As Panel
    Friend WithEvents pnlBN As Panel
    Friend WithEvents pnlLL As Panel
    Friend WithEvents pnlRL As Panel
    Friend WithEvents pnlSNR As Panel
    Friend WithEvents pnlBL As Panel
    Friend WithEvents pnlTL As Panel
    Friend WithEvents pnlSNL As Panel
    Friend WithEvents pnlSFR As Panel
    Friend WithEvents pnlSFL As Panel
    Friend WithEvents pnlE2 As Panel
    Friend WithEvents pnlE1 As Panel
    Friend WithEvents lblDescription As Label
End Class
