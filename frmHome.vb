Imports System.IO

Public Class frmChoose
    Public storageManager As StorageManager = New StorageManager
    Private Sub FrmChoose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
    End Sub
    Public Sub Init()
        TEST.Show()
        storageManager.ReadAnnotation()
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim image As Image
        image = storageManager.OpenImage()
        My.Forms.frmAnnotation.pnlAnnotation.BackgroundImage = image
        My.Forms.frmChoose.Hide()
        frmAnnotation.Show()
        TEST.Close()
    End Sub

    Private Sub BtnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        My.Forms.frmAnnotation.ModifyMode = True
        My.Forms.frmChoose.Hide()
        frmAnnotation.Show()
        TEST.Close()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim removedFile As String = InputBox("Enter the name", "Enter the name", "")
        removedFile &= ".png"
        storageManager.RemoveAnnotation(removedFile)
        storageManager.RemoveImage(removedFile)
    End Sub

    Private Sub FrmChoose_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        storageManager.WriteAnnotation("", Nothing)
    End Sub
End Class
