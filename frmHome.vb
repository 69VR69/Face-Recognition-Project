Imports System.IO

Public Class frmChoose
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        openFile()
    End Sub

    Private Sub openFile()
        Dim myStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "*.png|*.png|*.jpg|*.jpg"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = False

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = openFileDialog1.OpenFile()
                If (myStream IsNot Nothing) Then
                    Dim image As Image = Image.FromStream(myStream)
                    My.Forms.frmAnnotation.pnlAnnotation.BackgroundImage = image
                    My.Forms.frmChoose.Hide()
                    frmAnnotation.Show()
                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
    End Sub

End Class
