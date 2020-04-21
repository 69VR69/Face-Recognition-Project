<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnnotation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnnotation))
        Me.spnAnnotation = New System.Windows.Forms.SplitContainer()
        Me.pnlAnnotation = New System.Windows.Forms.Panel()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.grpAnnotation = New System.Windows.Forms.GroupBox()
        Me.btnBc = New System.Windows.Forms.Button()
        Me.btnBn = New System.Windows.Forms.Button()
        Me.btnLl = New System.Windows.Forms.Button()
        Me.btnRl = New System.Windows.Forms.Button()
        Me.btnSnr = New System.Windows.Forms.Button()
        Me.btnSnl = New System.Windows.Forms.Button()
        Me.btnTl = New System.Windows.Forms.Button()
        Me.btnBl = New System.Windows.Forms.Button()
        Me.btnSfr = New System.Windows.Forms.Button()
        Me.btnSfl = New System.Windows.Forms.Button()
        Me.btnE2 = New System.Windows.Forms.Button()
        Me.btnE1 = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.spnAnnotation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spnAnnotation.Panel1.SuspendLayout()
        Me.spnAnnotation.Panel2.SuspendLayout()
        Me.spnAnnotation.SuspendLayout()
        Me.grpAnnotation.SuspendLayout()
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
        Me.spnAnnotation.Panel1.Controls.Add(Me.btnBack)
        Me.spnAnnotation.Panel1.Controls.Add(Me.pnlAnnotation)
        '
        'spnAnnotation.Panel2
        '
        Me.spnAnnotation.Panel2.Controls.Add(Me.btnConfirm)
        Me.spnAnnotation.Panel2.Controls.Add(Me.grpAnnotation)
        Me.spnAnnotation.Size = New System.Drawing.Size(532, 483)
        Me.spnAnnotation.SplitterDistance = 341
        Me.spnAnnotation.TabIndex = 1
        '
        'pnlAnnotation
        '
        Me.pnlAnnotation.BackgroundImage = CType(resources.GetObject("pnlAnnotation.BackgroundImage"), System.Drawing.Image)
        Me.pnlAnnotation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlAnnotation.Location = New System.Drawing.Point(29, 32)
        Me.pnlAnnotation.Name = "pnlAnnotation"
        Me.pnlAnnotation.Size = New System.Drawing.Size(294, 412)
        Me.pnlAnnotation.TabIndex = 0
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
        'grpAnnotation
        '
        Me.grpAnnotation.Controls.Add(Me.btnBc)
        Me.grpAnnotation.Controls.Add(Me.btnBn)
        Me.grpAnnotation.Controls.Add(Me.btnLl)
        Me.grpAnnotation.Controls.Add(Me.btnRl)
        Me.grpAnnotation.Controls.Add(Me.btnSnr)
        Me.grpAnnotation.Controls.Add(Me.btnSnl)
        Me.grpAnnotation.Controls.Add(Me.btnTl)
        Me.grpAnnotation.Controls.Add(Me.btnBl)
        Me.grpAnnotation.Controls.Add(Me.btnSfr)
        Me.grpAnnotation.Controls.Add(Me.btnSfl)
        Me.grpAnnotation.Controls.Add(Me.btnE2)
        Me.grpAnnotation.Controls.Add(Me.btnE1)
        Me.grpAnnotation.Location = New System.Drawing.Point(15, 30)
        Me.grpAnnotation.Name = "grpAnnotation"
        Me.grpAnnotation.Size = New System.Drawing.Size(160, 376)
        Me.grpAnnotation.TabIndex = 0
        Me.grpAnnotation.TabStop = False
        Me.grpAnnotation.Text = "Annotation"
        '
        'btnBc
        '
        Me.btnBc.Location = New System.Drawing.Point(94, 332)
        Me.btnBc.Name = "btnBc"
        Me.btnBc.Size = New System.Drawing.Size(50, 23)
        Me.btnBc.TabIndex = 11
        Me.btnBc.Text = "BC"
        Me.btnBc.UseVisualStyleBackColor = True
        '
        'btnBn
        '
        Me.btnBn.Location = New System.Drawing.Point(13, 332)
        Me.btnBn.Name = "btnBn"
        Me.btnBn.Size = New System.Drawing.Size(48, 23)
        Me.btnBn.TabIndex = 10
        Me.btnBn.Text = "BN"
        Me.btnBn.UseVisualStyleBackColor = True
        '
        'btnLl
        '
        Me.btnLl.Location = New System.Drawing.Point(94, 271)
        Me.btnLl.Name = "btnLl"
        Me.btnLl.Size = New System.Drawing.Size(50, 23)
        Me.btnLl.TabIndex = 9
        Me.btnLl.Text = "LL"
        Me.btnLl.UseVisualStyleBackColor = True
        '
        'btnRl
        '
        Me.btnRl.Location = New System.Drawing.Point(13, 271)
        Me.btnRl.Name = "btnRl"
        Me.btnRl.Size = New System.Drawing.Size(48, 23)
        Me.btnRl.TabIndex = 8
        Me.btnRl.Text = "RL"
        Me.btnRl.UseVisualStyleBackColor = True
        '
        'btnSnr
        '
        Me.btnSnr.Location = New System.Drawing.Point(94, 212)
        Me.btnSnr.Name = "btnSnr"
        Me.btnSnr.Size = New System.Drawing.Size(50, 23)
        Me.btnSnr.TabIndex = 7
        Me.btnSnr.Text = "SNR"
        Me.btnSnr.UseVisualStyleBackColor = True
        '
        'btnSnl
        '
        Me.btnSnl.Location = New System.Drawing.Point(13, 212)
        Me.btnSnl.Name = "btnSnl"
        Me.btnSnl.Size = New System.Drawing.Size(48, 23)
        Me.btnSnl.TabIndex = 6
        Me.btnSnl.Text = "SNL"
        Me.btnSnl.UseVisualStyleBackColor = True
        '
        'btnTl
        '
        Me.btnTl.Location = New System.Drawing.Point(94, 154)
        Me.btnTl.Name = "btnTl"
        Me.btnTl.Size = New System.Drawing.Size(50, 23)
        Me.btnTl.TabIndex = 5
        Me.btnTl.Text = "TL"
        Me.btnTl.UseVisualStyleBackColor = True
        '
        'btnBl
        '
        Me.btnBl.Location = New System.Drawing.Point(13, 154)
        Me.btnBl.Name = "btnBl"
        Me.btnBl.Size = New System.Drawing.Size(48, 23)
        Me.btnBl.TabIndex = 4
        Me.btnBl.Text = "BL"
        Me.btnBl.UseVisualStyleBackColor = True
        '
        'btnSfr
        '
        Me.btnSfr.Location = New System.Drawing.Point(94, 99)
        Me.btnSfr.Name = "btnSfr"
        Me.btnSfr.Size = New System.Drawing.Size(50, 23)
        Me.btnSfr.TabIndex = 3
        Me.btnSfr.Text = "SFR"
        Me.btnSfr.UseVisualStyleBackColor = True
        '
        'btnSfl
        '
        Me.btnSfl.Location = New System.Drawing.Point(13, 99)
        Me.btnSfl.Name = "btnSfl"
        Me.btnSfl.Size = New System.Drawing.Size(48, 23)
        Me.btnSfl.TabIndex = 2
        Me.btnSfl.Text = "SFL"
        Me.btnSfl.UseVisualStyleBackColor = True
        '
        'btnE2
        '
        Me.btnE2.Location = New System.Drawing.Point(94, 44)
        Me.btnE2.Name = "btnE2"
        Me.btnE2.Size = New System.Drawing.Size(50, 23)
        Me.btnE2.TabIndex = 1
        Me.btnE2.Text = "E2"
        Me.btnE2.UseVisualStyleBackColor = True
        '
        'btnE1
        '
        Me.btnE1.Location = New System.Drawing.Point(13, 44)
        Me.btnE1.Name = "btnE1"
        Me.btnE1.Size = New System.Drawing.Size(48, 23)
        Me.btnE1.TabIndex = 0
        Me.btnE1.Text = "E1"
        Me.btnE1.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(29, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 31)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
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
        Me.grpAnnotation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents spnAnnotation As SplitContainer
    Friend WithEvents pnlAnnotation As Panel
    Friend WithEvents btnConfirm As Button
    Friend WithEvents grpAnnotation As GroupBox
    Friend WithEvents btnBc As Button
    Friend WithEvents btnBn As Button
    Friend WithEvents btnLl As Button
    Friend WithEvents btnRl As Button
    Friend WithEvents btnSnr As Button
    Friend WithEvents btnSnl As Button
    Friend WithEvents btnTl As Button
    Friend WithEvents btnBl As Button
    Friend WithEvents btnSfr As Button
    Friend WithEvents btnSfl As Button
    Friend WithEvents btnE2 As Button
    Friend WithEvents btnE1 As Button
    Friend WithEvents btnBack As Button
End Class
