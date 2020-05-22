Public Class frmDataViewer
    Private StorageManager As New StorageManager
    Private Sub TEST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(My.Forms.frmHome.Location.X + My.Forms.frmHome.Width, My.Forms.frmHome.Location.Y)
        StorageManager.ReadAnnotation()
    End Sub
End Class