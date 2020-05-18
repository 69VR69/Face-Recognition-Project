Public Class TEST
    Private StorageManager As New StorageManager
    Private Sub TEST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StorageManager.ReadAnnotation()
    End Sub
End Class