Imports System.Data.OleDb
Imports System.IO

Public Class StorageManager
    Public csvName As String = "Annotation.csv"
    Private ReadOnly csvPath As String = "C:\Users\afouq\Google Drive\Projet tutoré\IHM Face Recognition Project\Code\FRP\Face-Recognition-Project\res\Annotation.csv"
    Public headerString As String()
    Public annotationDataTable As DataTable = Nothing
    Private ReadOnly dataManager As New DataManager(Me)
    Public imagePath As String

    Public Function OpenImage() As Image
        Dim newFile As Stream = Nothing
        Dim fileDialog As New OpenFileDialog()
        Dim image As Image = Nothing
        fileDialog.InitialDirectory = "c:\"
        fileDialog.Filter = "*.png|*.png|*.jpg|*.jpg"
        fileDialog.FilterIndex = 2
        fileDialog.RestoreDirectory = True

        If fileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                newFile = fileDialog.OpenFile()
                If (newFile IsNot Nothing) Then
                    imagePath = fileDialog.FileName()
                    image = Image.FromStream(newFile)
                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                If (newFile IsNot Nothing) Then
                    newFile.Close()
                End If
            End Try
        End If
        Return image
    End Function
    Public Function OpenImage(ByVal imagePath As String) As Image
        Dim image As Image = Image.FromFile(imagePath)
        Me.imagePath = imagePath
        Return image
    End Function
    'TODO: protect from double imageName
    Public Sub ReadAnnotation()
        Dim TextFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(csvPath)
        TextFileReader.TextFieldType = FileIO.FieldType.Delimited
        TextFileReader.SetDelimiters(";")
        Dim Column As DataColumn
        Dim Row As DataRow
        Dim ColumnOnRow As Int32
        Dim ColumnCount As Int32
        Dim CurrentRow As String() = Nothing
        Dim header As Boolean = True
        Dim headerIndex As Integer = 0

        While Not TextFileReader.EndOfData
            Try
                If header Then
                    headerString = TextFileReader.ReadFields()
                    header = False
                Else
                    CurrentRow = TextFileReader.ReadFields()
                End If
                If CurrentRow IsNot Nothing Then

                    If annotationDataTable Is Nothing Then

                        annotationDataTable = New DataTable()
                        ColumnOnRow = CurrentRow.GetUpperBound(0)

                        For ColumnCount = 0 To ColumnOnRow
                            Column = New DataColumn With {
                                .DataType = System.Type.GetType("System.String"),
                                .ColumnName = headerString(headerIndex),
                                .Caption = "Col" & ColumnCount,
                                .ReadOnly = True,
                                .Unique = False
                            }
                            headerIndex += 1
                            annotationDataTable.Columns.Add(Column)
                        Next
                    End If
                    Row = annotationDataTable.NewRow
                    For ColumnCount = 0 To ColumnOnRow
                        Row(headerString(ColumnCount)) = CurrentRow(ColumnCount).ToString
                    Next
                    annotationDataTable.Rows.Add(Row)

                End If

            Catch ex As _
            Microsoft.VisualBasic.FileIO.MalformedLineException
                MsgBox("Line " & ex.Message &
                "is not valid and will be skipped.")
            End Try
        End While
        TextFileReader.Dispose()
        'Show data
        My.Forms.TEST.DataGridView1.DataSource = annotationDataTable
    End Sub
    'TODO: Save need an interface to write the newName
    Public Sub SaveImage(ByVal imagePath As String, ByVal imageNewName As String, ByRef annotation As Panel())
        MoveImage(imagePath, imageNewName)
        WriteAnnotation(imageNewName, annotation)
    End Sub
    Private Sub MoveImage(ByVal imagePath As String, ByVal imageNewName As String)
        My.Computer.FileSystem.CopyFile(imagePath, "C:\Users\afouq\Google Drive\Projet tutoré\IHM Face Recognition Project\Code\FRP\Face-Recognition-Project\res\img\" & imageNewName)
    End Sub
    Public Sub WriteAnnotation(ByVal imageName As String, ByRef annotation As Panel())
        Dim csv As String = String.Empty

        'Add header row
        For Each h In headerString
            csv += h & ";"c
        Next
        csv += vbCr & vbLf

        'Add rows
        For Each row In annotationDataTable.Rows
            For Each column In annotationDataTable.Columns
                csv += row(column) & ";"c
            Next
            csv += vbCr & vbLf
        Next

        'Add New row
        For Each s In dataManager.AddAnnotation(imageName, annotation)
            csv += s & ";"c
        Next

        File.WriteAllText(csvPath, csv)
    End Sub

End Class