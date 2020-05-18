Imports System.IO

Public Class StorageManager 'TODO dialog to input name = endless loop ;)
    Public csvName As String = "Annotation.csv"
    Private ReadOnly csvPath As String = "C:\Users\afouq\Google Drive\Projet tutoré\IHM Face Recognition Project\Code\FRP\Face-Recognition-Project\res\Annotation.csv"
    Private ReadOnly imageLocationPath As String = "C:\Users\afouq\Google Drive\Projet tutoré\IHM Face Recognition Project\Code\FRP\Face-Recognition-Project\res\img\"
    Public headerString As String()
    Public annotationDataTable As DataTable = Nothing
    Public dataManager As New DataManager(Me)
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
    Public Function OpenImage(ByVal imageName As String) As Image
        Me.imagePath = imageLocationPath & imageName
        Dim image As Image = Image.FromFile(imagePath)
        Return image
    End Function
    Public Sub ReadAnnotation()
        Dim TextFileReader As New FileIO.TextFieldParser(csvPath) With {
            .TextFieldType = FileIO.FieldType.Delimited
        }
        TextFileReader.SetDelimiters(";")
        Dim Column As DataColumn
        Dim Row As DataRow
        Dim ColumnOnRow As Int32
        Dim ColumnCount As Int32
        Dim CurrentRow As String() = Nothing
        Dim header As Boolean = True
        Dim headerIndex As Integer = 0
        annotationDataTable = Nothing

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
                        ColumnOnRow = 24

                        For ColumnCount = 0 To ColumnOnRow
                            Column = New DataColumn With {
                                .DataType = System.Type.GetType("System.String"),
                                .ColumnName = headerString(headerIndex),
                                .ReadOnly = False,
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
            FileIO.MalformedLineException
                MsgBox("Line " & ex.Message &
                "is not valid and will be skipped.")
            End Try
        End While
        TextFileReader.Dispose()
        My.Forms.TEST.DataGridView1.DataSource = annotationDataTable
    End Sub
    Public Sub SaveImage(ByVal imagePath As String, ByVal imageNewName As String, ByRef annotation As Panel())
        If IsDuplicate(imageNewName) Then
            imageNewName = InputBox("Enter a name" & vbNewLine & "This name already exist !", "Enter a name", "")
            imageNewName &= ".png"
            SaveImage(imagePath, imageNewName, annotation)
        ElseIf imageNewName.Length > 125 Then
            imageNewName = InputBox("Enter a name" & vbNewLine & "This name is too long !", "Enter a name", "")
            imageNewName &= ".png"
            SaveImage(imagePath, imageNewName, annotation)
        Else
            MoveImage(imagePath, imageNewName)
            WriteAnnotation(imageNewName, annotation)
            My.Forms.frmAnnotation.Hide()
            frmChoose.Show()
        End If
    End Sub
    Public Sub SaveModifiedImage(ByVal imageName As String, ByVal annotation As Panel())
        If imageName.Length > 125 Then
            imageName = InputBox("Enter a name" & vbNewLine & "This name is too long !", "Enter a name", "")
            imageName &= ".png"
            SaveModifiedImage(imageName, annotation)
        Else
            RemoveAnnotation(imageName)
            WriteAnnotation(imageName, annotation)
        End If
    End Sub
    Private Sub MoveImage(ByVal imagePath As String, ByVal imageNewName As String)
        My.Computer.FileSystem.CopyFile(imagePath, imageLocationPath & imageNewName)
    End Sub
    Public Sub WriteAnnotation(ByVal imageName As String, ByVal annotation As Panel())
        Dim csv As String = String.Empty

        'Add header row
        For Each h In headerString
            csv += h & ";"c
        Next
        csv += vbNewLine

        'Add rows
        If (annotationDataTable IsNot Nothing) Then
            For Each row In annotationDataTable.Rows
                For Each column In annotationDataTable.Columns
                    csv += row(column) & ";"c
                Next
                csv += vbNewLine
            Next
        End If

        'Add New row
        If Not IsNothing(annotation) Then
            If annotation.Length > 0 Then
                For Each s In dataManager.AddAnnotation(imageName, annotation)
                    csv += s & ";"c
                Next
            End If
        End If
        File.WriteAllText(csvPath, csv)
    End Sub

    Public Sub RemoveAnnotation(ByVal imageName)
        For Each d In annotationDataTable.Select("imageFile = '" & imageName & "'")
            annotationDataTable.Rows.Remove(d)
        Next
    End Sub

    Public Sub RemoveImage(ByVal imageName)
        File.Delete(imageLocationPath & imageName)
    End Sub

    Private Function IsDuplicate(ByRef imageNewName As String) As Boolean
        If My.Computer.FileSystem.FileExists(imageLocationPath & imageNewName) Then
            Return True
        End If
        If (annotationDataTable IsNot Nothing) Then
            For Each r In annotationDataTable.Rows
                Console.WriteLine(r(0).ToString)
                If r(0) = imageNewName Then
                    Return True
                End If
            Next
        End If
        Return False
    End Function
End Class