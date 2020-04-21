Public Class frmAnnotation
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Forms.frmAnnotation.Hide()
        My.Forms.frmChoose.Show()
    End Sub
End Class