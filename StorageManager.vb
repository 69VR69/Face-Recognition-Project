Imports System.Data.OleDb
Imports System.IO

Public Class StorageManager
    Private fileName As String = "Annotation.csv"
    Private filePath As String = "C:\Users\afouq\Google Drive\Projet tutoré\IHM Face Recognition Project\Code\FRP\Face-Recognition-Project\res\Annotation.csv"
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

    Public Sub readAnnotation()

        'Create and config the tool to explore the csv file
        Dim TextFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(filePath)
        TextFileReader.TextFieldType = FileIO.FieldType.Delimited
        TextFileReader.SetDelimiters(";")

        'Create variables to contain annotations while the program is running
        Dim TextFileTable As DataTable = Nothing
        Dim Column As DataColumn
        Dim Row As DataRow
        Dim ColumnOnRow As Int32
        Dim ColumnCount As Int32
        Dim CurrentRow As String()

        While Not TextFileReader.EndOfData
            Try
                CurrentRow = TextFileReader.ReadFields() 'read row

                If CurrentRow IsNot Nothing Then

                    If TextFileTable Is Nothing Then 'check if the row we're going to fill into DataTable is empty

                        TextFileTable = New DataTable()
                        ColumnOnRow = CurrentRow.GetUpperBound(0)

                        For ColumnCount = 1 To ColumnOnRow
                            Column = New DataColumn()
                            Column.DataType = System.Type.GetType("System.String")
                            Column.ColumnName = "Column" & ColumnCount
                            Column.Caption = "Col" & ColumnCount
                            Column.ReadOnly = True
                            Column.Unique = False
                            TextFileTable.Columns.Add(Column)
                        Next

                    End If
                    Row = TextFileTable.NewRow
                    For ColumnCount = 1 To ColumnOnRow
                        Row("Column" & ColumnCount) = CurrentRow(ColumnCount).ToString
                    Next
                    TextFileTable.Rows.Add(Row)

                End If

            Catch ex As _
            Microsoft.VisualBasic.FileIO.MalformedLineException
                MsgBox("Line " & ex.Message &
                "is not valid and will be skipped.")
            End Try
        End While
        TextFileReader.Dispose()
        'Show data
        My.Forms.TEST.DataGridView1.DataSource = TextFileTable
    End Sub

    Private Sub writeAnnotation()

    End Sub

End Class
