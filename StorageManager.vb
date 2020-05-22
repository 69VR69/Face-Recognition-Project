Imports System.Configuration.Assemblies
Imports System.IO
Imports System.Reflection
Imports Microsoft.Win32

Public Class StorageManager 'TODO dialog to input name = endless loop ;)
    Public csvName As String = "Annotation.csv"
    Private ReadOnly csvPath As String = Application.StartupPath & "\Resources\" & csvName
    Private ReadOnly imageLocationPath As String = Application.StartupPath & "\Resources\img\"
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

        Dim dialogResult = fileDialog.ShowDialog()

        If dialogResult = System.Windows.Forms.DialogResult.OK Then
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
        ElseIf dialogResult = System.Windows.Forms.DialogResult.Cancel Then
            My.Forms.frmAnnotation.BackToHome()

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
        My.Forms.frmDataViewer.DataGridView1.DataSource = annotationDataTable
    End Sub
    Public Sub SaveImage(ByVal imagePath As String, ByVal imageNewName As String, ByRef annotation As Panel())
        If IsDuplicate(imageNewName) Then
            imageNewName = InputBox("Enter a name" & vbNewLine & "This name already exist !", "Enter a name", " ")
            While (imageNewName.Equals(" "))
                imageNewName = InputBox("Enter a name" & vbNewLine & "This name already exist !", "Enter a name", " ")
            End While
            If imageNewName.Equals("") Then
                My.Forms.frmAnnotation.BackToHome()
                Return
            End If
            imageNewName &= ".png"
            SaveImage(imagePath, imageNewName, annotation)
        ElseIf imageNewName.Length > 125 Then
            imageNewName = InputBox("Enter a name" & vbNewLine & "This name is too long !", "Enter a name", " ")
            While (imageNewName.Equals(" "))
                imageNewName = InputBox("Enter a name" & vbNewLine & "This name is too long !", "Enter a name", " ")
            End While
            If imageNewName.Equals("") Then
                My.Forms.frmAnnotation.BackToHome()
                Return
            End If
            imageNewName &= ".png"
            SaveImage(imagePath, imageNewName, annotation)
        Else
            MoveImage(imagePath, imageNewName)
            WriteAnnotation(imageNewName, annotation)
            My.Forms.frmAnnotation.Hide()
            frmHome.Show()
        End If
    End Sub

    Public Sub CompareImage(ByVal annotation As Panel())
        Dim recognizedImage As String = Nothing
        Dim lastDistance As Double = 2
        'Calculating the ratio from the selected image
        'Ratio lips
        Dim WidhtLips As Double = annotation(6).Location.X - annotation(5).Location.X
        Dim HeightLips As Double = annotation(3).Location.Y - annotation(11).Location.Y
        Dim RatioLip As Double = HeightLips / WidhtLips
        'Ratio nose
        Dim HeightNose As Double = annotation(4).Location.Y - ((annotation(0).Location.Y + annotation(1).Location.Y) / 2)
        Dim WidhtNose As Double = annotation(10).Location.X - annotation(9).Location.X
        Dim RatioNose As Double = HeightNose / WidhtNose
        'Ratio face
        Dim WidhtFace As Double = annotation(8).Location.X - annotation(7).Location.X
        Dim HeightFace As Double = annotation(2).Location.Y - ((annotation(0).Location.Y + annotation(1).Location.Y) / 2)
        Dim RatioFace As Double = HeightFace / WidhtFace
        'Ratio eye
        Dim WidhtEye As Double = Math.Abs((annotation(0).Location.X + (annotation(0).Width / 2)) - (annotation(1).Location.X + (annotation(1).Width / 2)))
        Dim RatioEye As Double = WidhtFace / WidhtEye
        For Each Row In annotationDataTable.Rows 'this loop calculate the ratio of each image in the database
            Dim E1X, E1Y, E2X, E2Y, BCX, BCY, BLX, BLY, BNX, BNY, LLX, LLY, RLX, RLY, SFLX, SFLY, SFRX, SFRY, SNLX, SNLY, SNRX, SNRY, TLX, TLY As Double
            Dim imgname As String
            Dim index As Integer = 1
            For i = 0 To 11
                Select Case i
                    'each column correspond to an annotation in the .csv file
                    Case 0 'EYE1
                        imgname = Row(index - 1) 'The name of the current image
                        E1X = Integer.Parse(Row(index))
                        E1Y = Integer.Parse(Row(index + 1))
                    Case 1 'EYE2
                        E2X = Integer.Parse(Row(index))
                        E2Y = Integer.Parse(Row(index + 1))
                    Case 2 'BC
                        BCX = Integer.Parse(Row(index))
                        BCY = Integer.Parse(Row(index + 1))
                    Case 3 'BL
                        BLX = Integer.Parse(Row(index))
                        BLY = Integer.Parse(Row(index + 1))
                    Case 4 'BN
                        BNX = Integer.Parse(Row(index))
                        BNY = Integer.Parse(Row(index + 1))
                    Case 5 'LL
                        LLX = Integer.Parse(Row(index))
                        LLY = Integer.Parse(Row(index + 1))
                    Case 6 'RL
                        RLX = Integer.Parse(Row(index))
                        RLY = Integer.Parse(Row(index + 1))
                    Case 7 'SFL
                        SFLX = Integer.Parse(Row(index))
                        SFLY = Integer.Parse(Row(index + 1))
                    Case 8 'SFR
                        SFRX = Integer.Parse(Row(index))
                        SFRY = Integer.Parse(Row(index + 1))
                    Case 9 'SNL
                        SNLX = Integer.Parse(Row(index))
                        SNLY = Integer.Parse(Row(index + 1))
                    Case 10 'SNR
                        SNRX = Integer.Parse(Row(index))
                        SNRY = Integer.Parse(Row(index + 1))
                    Case 11 'TL
                        TLX = Integer.Parse(Row(index))
                        TLY = Integer.Parse(Row(index + 1))
                End Select
                index += 2
            Next
            'Ratio lips 2
            Dim WidhtLips2 As Double = RLX - LLX
            Dim HeightLips2 As Double = BLY - TLY
            Dim RatioLip2 As Double = HeightLips2 / WidhtLips2
            'Ratio nose 2
            Dim HeightNose2 As Double = BNY - ((E1Y + E2Y) / 2)
            Dim WidhtNose2 As Double = SNRX - SNLX
            Dim RatioNose2 As Double = HeightNose2 / WidhtNose2
            'Ratio face 2
            Dim WidhtFace2 As Double = SFRX - SFLX
            Dim HeightFace2 As Double = BCY - ((E1Y + E2Y) / 2)
            Dim RatioFace2 As Double = HeightFace2 / WidhtFace2
            'Ratio eye 2
            Dim WidhtEye2 As Double = Math.Abs(E1X - E2X)
            Dim RatioEye2 As Double = WidhtFace2 / WidhtEye2
            'Compare image to another from the database
            Dim distance As Double = (((RatioLip - RatioLip2) ^ 2) + ((RatioEye - RatioEye2) ^ 2) + ((RatioFace - RatioFace2) ^ 2) + ((RatioNose - RatioNose2) ^ 2))
            'If the distance between the 2 images are below 2 then you can write the image that had been found
            Console.WriteLine(imgname & ": " & distance)
            If distance < lastDistance Then
                lastDistance = distance
                recognizedImage = imgname
            End If
        Next

        If recognizedImage IsNot Nothing Then
            MsgBox("Image found : " + recognizedImage)
        Else
            MsgBox("Image not found in the database ")
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
                If r(0) = imageNewName Then
                    Return True
                End If
            Next
        End If
        Return False
    End Function
End Class