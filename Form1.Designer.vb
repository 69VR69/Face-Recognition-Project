<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChoose
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChoose))
        Me.spcChoose = New System.Windows.Forms.SplitContainer()
        Me.pnlImage = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.spcChoose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcChoose.Panel1.SuspendLayout()
        Me.spcChoose.Panel2.SuspendLayout()
        Me.spcChoose.SuspendLayout()
        Me.SuspendLayout()
        '
        'spcChoose
        '
        Me.spcChoose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcChoose.Location = New System.Drawing.Point(0, 0)
        Me.spcChoose.Name = "spcChoose"
        '
        'spcChoose.Panel1
        '
        Me.spcChoose.Panel1.Controls.Add(Me.pnlImage)
        '
        'spcChoose.Panel2
        '
        Me.spcChoose.Panel2.Controls.Add(Me.btnDelete)
        Me.spcChoose.Panel2.Controls.Add(Me.btnSearch)
        Me.spcChoose.Panel2.Controls.Add(Me.btnModify)
        Me.spcChoose.Panel2.Controls.Add(Me.btnAdd)
        Me.spcChoose.Size = New System.Drawing.Size(532, 483)
        Me.spcChoose.SplitterDistance = 347
        Me.spcChoose.TabIndex = 0
        '
        'pnlImage
        '
        Me.pnlImage.BackgroundImage = CType(resources.GetObject("pnlImage.BackgroundImage"), System.Drawing.Image)
        Me.pnlImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlImage.Location = New System.Drawing.Point(29, 32)
        Me.pnlImage.Name = "pnlImage"
        Me.pnlImage.Size = New System.Drawing.Size(294, 412)
        Me.pnlImage.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(11, 289)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(158, 48)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "delete image"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(11, 202)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(158, 48)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "search into database"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(11, 120)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(158, 48)
        Me.btnModify.TabIndex = 4
        Me.btnModify.Text = "modify an image"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(11, 43)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(158, 48)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "add an image"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmChoose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 483)
        Me.Controls.Add(Me.spcChoose)
        Me.Name = "frmChoose"
        Me.Text = "FRP"
        Me.spcChoose.Panel1.ResumeLayout(False)
        Me.spcChoose.Panel2.ResumeLayout(False)
        CType(Me.spcChoose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcChoose.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents spcChoose As SplitContainer
    Friend WithEvents pnlImage As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents btnAdd As Button
End Class
