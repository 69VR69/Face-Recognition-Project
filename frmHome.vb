Imports System.IO

Public Class frmHome
    Public storageManager As StorageManager = New StorageManager
    Private Sub FrmChoose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
    End Sub
    Public Sub Init()
        frmDataViewer.Refresh()
        frmDataViewer.Show()
        storageManager.ReadAnnotation()
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim image As Image
        image = storageManager.OpenImage()
        If Not IsNothing(image) Then
            My.Forms.frmAnnotation.pnlAnnotation.BackgroundImage = image
            My.Forms.frmHome.Hide()
            frmAnnotation.Show()
            'TEST.Close()
        End If
    End Sub

    Private Sub BtnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        My.Forms.frmAnnotation.ModifyMode = True
        My.Forms.frmHome.Hide()
        frmAnnotation.Show()
        frmDataViewer.Close()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        My.Forms.frmAnnotation.SearchMode = True
        My.Forms.frmHome.Hide()
        frmAnnotation.Show()
        'TEST.Close()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim removedFile As String = InputBox("Enter the name", "Enter the name", " ")
        While (removedFile.Equals(" "))
            removedFile = InputBox("Enter the name", "Enter the name", " ")
        End While
        If removedFile.Equals("") Then
            My.Forms.frmAnnotation.BackToHome()
            Return
        End If
        removedFile &= ".png"
        storageManager.RemoveAnnotation(removedFile)
        storageManager.RemoveImage(removedFile)
    End Sub

    Private Sub FrmChoose_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        storageManager.WriteAnnotation("", Nothing)
    End Sub
End Class
