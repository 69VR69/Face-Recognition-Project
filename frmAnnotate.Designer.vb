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
        Me.spnAnnotation = New System.Windows.Forms.SplitContainer()
        Me.grpAnnotation = New System.Windows.Forms.GroupBox()
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        CType(Me.spnAnnotation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spnAnnotation.Panel1.SuspendLayout()
        Me.spnAnnotation.Panel2.SuspendLayout()
        Me.spnAnnotation.SuspendLayout()
        Me.pnlAnnotation.SuspendLayout()
        Me.SuspendLayout()
        '
        'spnAnnotation
        '
        Me.spnAnnotation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spnAnnotation.Location = New System.Drawing.Point(0, 0)
        Me.spnAnnotation.Name = "spnAnnotation"
        '
        'spnAnnotation.Panel1
        '
        Me.spnAnnotation.Panel1.Controls.Add(Me.grpAnnotation)
        Me.spnAnnotation.Panel1.Controls.Add(Me.pnlAnnotation)
        '
        'spnAnnotation.Panel2
        '
        Me.spnAnnotation.Panel2.Controls.Add(Me.btnBack)
        Me.spnAnnotation.Panel2.Controls.Add(Me.btnConfirm)
        Me.spnAnnotation.Size = New System.Drawing.Size(532, 483)
        Me.spnAnnotation.SplitterDistance = 341
        Me.spnAnnotation.TabIndex = 1
        '
        'grpAnnotation
        '
        Me.grpAnnotation.Location = New System.Drawing.Point(348, 32)
        Me.grpAnnotation.Name = "grpAnnotation"
        Me.grpAnnotation.Size = New System.Drawing.Size(181, 412)
        Me.grpAnnotation.TabIndex = 0
        Me.grpAnnotation.TabStop = False
        Me.grpAnnotation.Text = "Annotation"
        Me.grpAnnotation.Visible = False
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
        Me.pnlAnnotation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAnnotation.Location = New System.Drawing.Point(0, 0)
        Me.pnlAnnotation.Name = "pnlAnnotation"
        Me.pnlAnnotation.Size = New System.Drawing.Size(341, 483)
        Me.pnlAnnotation.TabIndex = 0
        '
        'pnlBC
        '
        Me.pnlBC.AutoSize = True
        Me.pnlBC.BackgroundImage = Global.FRP.My.Resources.Resources.BC
        Me.pnlBC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlBC.Location = New System.Drawing.Point(75, 48)
        Me.pnlBC.Name = "pnlBC"
        Me.pnlBC.Size = New System.Drawing.Size(30, 30)
        Me.pnlBC.TabIndex = 18
        '
        'pnlBN
        '
        Me.pnlBN.AutoSize = True
        Me.pnlBN.BackgroundImage = Global.FRP.My.Resources.Resources.BN
        Me.pnlBN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlBN.Location = New System.Drawing.Point(39, 48)
        Me.pnlBN.Name = "pnlBN"
        Me.pnlBN.Size = New System.Drawing.Size(30, 30)
        Me.pnlBN.TabIndex = 17
        '
        'pnlLL
        '
        Me.pnlLL.AutoSize = True
        Me.pnlLL.BackgroundImage = Global.FRP.My.Resources.Resources.LL
        Me.pnlLL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlLL.Location = New System.Drawing.Point(219, 3)
        Me.pnlLL.Name = "pnlLL"
        Me.pnlLL.Size = New System.Drawing.Size(30, 30)
        Me.pnlLL.TabIndex = 16
        '
        'pnlRL
        '
        Me.pnlRL.AutoSize = True
        Me.pnlRL.BackgroundImage = Global.FRP.My.Resources.Resources.RL
        Me.pnlRL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlRL.Location = New System.Drawing.Point(255, 3)
        Me.pnlRL.Name = "pnlRL"
        Me.pnlRL.Size = New System.Drawing.Size(30, 30)
        Me.pnlRL.TabIndex = 15
        '
        'pnlSNR
        '
        Me.pnlSNR.AutoSize = True
        Me.pnlSNR.BackgroundImage = Global.FRP.My.Resources.Resources.SNR
        Me.pnlSNR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlSNR.Location = New System.Drawing.Point(3, 48)
        Me.pnlSNR.Name = "pnlSNR"
        Me.pnlSNR.Size = New System.Drawing.Size(30, 30)
        Me.pnlSNR.TabIndex = 14
        '
        'pnlBL
        '
        Me.pnlBL.AutoSize = True
        Me.pnlBL.BackgroundImage = Global.FRP.My.Resources.Resources.BL
        Me.pnlBL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlBL.Location = New System.Drawing.Point(183, 3)
        Me.pnlBL.Name = "pnlBL"
        Me.pnlBL.Size = New System.Drawing.Size(30, 30)
        Me.pnlBL.TabIndex = 13
        '
        'pnlTL
        '
        Me.pnlTL.AutoSize = True
        Me.pnlTL.BackgroundImage = Global.FRP.My.Resources.Resources.TL
        Me.pnlTL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlTL.Location = New System.Drawing.Point(147, 3)
        Me.pnlTL.Name = "pnlTL"
        Me.pnlTL.Size = New System.Drawing.Size(30, 30)
        Me.pnlTL.TabIndex = 13
        '
        'pnlSNL
        '
        Me.pnlSNL.AutoSize = True
        Me.pnlSNL.BackgroundImage = Global.FRP.My.Resources.Resources.SNL
        Me.pnlSNL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlSNL.Location = New System.Drawing.Point(291, 3)
        Me.pnlSNL.Name = "pnlSNL"
        Me.pnlSNL.Size = New System.Drawing.Size(30, 30)
        Me.pnlSNL.TabIndex = 13
        '
        'pnlSFR
        '
        Me.pnlSFR.AutoSize = True
        Me.pnlSFR.BackgroundImage = Global.FRP.My.Resources.Resources.SFR
        Me.pnlSFR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlSFR.Location = New System.Drawing.Point(111, 3)
        Me.pnlSFR.Name = "pnlSFR"
        Me.pnlSFR.Size = New System.Drawing.Size(30, 30)
        Me.pnlSFR.TabIndex = 13
        '
        'pnlSFL
        '
        Me.pnlSFL.AutoSize = True
        Me.pnlSFL.BackgroundImage = Global.FRP.My.Resources.Resources.SFL
        Me.pnlSFL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlSFL.Location = New System.Drawing.Point(39, 3)
        Me.pnlSFL.Name = "pnlSFL"
        Me.pnlSFL.Size = New System.Drawing.Size(30, 30)
        Me.pnlSFL.TabIndex = 13
        '
        'pnlE2
        '
        Me.pnlE2.AutoSize = True
        Me.pnlE2.BackgroundImage = Global.FRP.My.Resources.Resources.E2
        Me.pnlE2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlE2.Location = New System.Drawing.Point(75, 3)
        Me.pnlE2.Name = "pnlE2"
        Me.pnlE2.Size = New System.Drawing.Size(30, 30)
        Me.pnlE2.TabIndex = 13
        '
        'pnlE1
        '
        Me.pnlE1.AutoSize = True
        Me.pnlE1.BackgroundImage = Global.FRP.My.Resources.Resources.E1
        Me.pnlE1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlE1.Location = New System.Drawing.Point(3, 3)
        Me.pnlE1.Name = "pnlE1"
        Me.pnlE1.Size = New System.Drawing.Size(30, 30)
        Me.pnlE1.TabIndex = 12
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(79, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 31)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(28, 423)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(131, 34)
        Me.btnConfirm.TabIndex = 1
        Me.btnConfirm.Text = "save"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'frmAnnotation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 483)
        Me.Controls.Add(Me.spnAnnotation)
        Me.Name = "frmAnnotation"
        Me.Text = "FRP"
        Me.spnAnnotation.Panel1.ResumeLayout(False)
        Me.spnAnnotation.Panel2.ResumeLayout(False)
        CType(Me.spnAnnotation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spnAnnotation.ResumeLayout(False)
        Me.pnlAnnotation.ResumeLayout(False)
        Me.pnlAnnotation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents spnAnnotation As SplitContainer
    Friend WithEvents pnlAnnotation As Panel
    Friend WithEvents btnConfirm As Button
    Friend WithEvents grpAnnotation As GroupBox
    Friend WithEvents btnBack As Button
    Friend WithEvents pnlE1 As Panel
    Friend WithEvents pnlE2 As Panel
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
End Class
