Imports System.IO

Public Class frmChoose
    Public storageManager As StorageManager = New StorageManager
    Private Sub FrmChoose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        storageManager.ReadAnnotation()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim image As Image
        image = storageManager.OpenImage()
        My.Forms.frmAnnotation.pnlAnnotation.BackgroundImage = image
        My.Forms.frmChoose.Hide()
        frmAnnotation.ShowDialog()
    End Sub
End Class
