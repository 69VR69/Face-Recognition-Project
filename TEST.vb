Public Class TEST
    Private Sub TEST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim StorageManager As New StorageManager
        StorageManager.readAnnotation()
    End Sub
End Class