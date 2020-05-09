Public Class TEST
    Private StorageManager As New StorageManager
    Private Sub TEST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Image = StorageManager.OpenImage()
        StorageManager.ReadAnnotation()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'StorageManager.WriteAnnotation()
    End Sub
End Class