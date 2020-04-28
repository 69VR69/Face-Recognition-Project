﻿Imports System.IO

Public Class frmChoose

    Private fileName As String
    Private filePath As String
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        openImage()
    End Sub

    Private Sub openImage()
        Dim newFile As Stream = Nothing
        Dim fileDialog As New OpenFileDialog()

        fileDialog.InitialDirectory = "c:\"
        fileDialog.Filter = "*.png|*.png|*.jpg|*.jpg"
        fileDialog.FilterIndex = 2
        fileDialog.RestoreDirectory = True

        If fileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                newFile = fileDialog.OpenFile()
                If (newFile IsNot Nothing) Then
                    fileName = fileDialog.FileName()
                    filePath = fileDialog.SafeFileName()
                    Dim image As Image = Image.FromStream(newFile)
                    My.Forms.frmAnnotation.pnlAnnotation.BackgroundImage = image
                    My.Forms.frmChoose.Hide()
                    frmAnnotation.ShowDialog()
                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                If (newFile IsNot Nothing) Then
                    newFile.Close()
                End If
            End Try
        End If
    End Sub

End Class
