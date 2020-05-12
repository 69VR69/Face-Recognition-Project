Public Class DataManager

    Public Sub New(ByRef storageManager As StorageManager)
        Me.storageManager = storageManager
    End Sub
    Private ReadOnly storageManager As StorageManager
    'TODO: protect from double imageName
    Public Function AddAnnotation(ByVal name As String, ByRef annotation As Panel()) As String()
        Dim newAnnotation As String() = Nothing
        Dim index As Integer = 1
        newAnnotation(0) = name 'TODO: bug NPE
        For i = 0 To 11
            newAnnotation(index) = annotation(i).Location.X + (annotation(i).Size.Width / 2)
            index += 1
            newAnnotation(index) = annotation(i).Location.Y + (annotation(i).Size.Height / 2)
            index += 1
        Next
        Return newAnnotation
    End Function
    Public Sub LoadAnnotation(ByVal name As String)
        Try
            'Dim annotation As Panel() = My.Forms.frmAnnotation.annotation
            For Each s In SearchAnnotatedImage(name)

            Next

        Catch ex As Exception
            MessageBox.Show("Cannot load annotations. Original error: " & ex.Message)
        End Try
    End Sub
    Public Function SearchAnnotatedImage(ByVal imageName As String) As String()
        Dim rowString As New List(Of String)
        Dim dataRow As DataRow() = storageManager.annotationDataTable.Select("imageFile = '" & imageName & "'")
        For Each dr In dataRow
            For Each d In dr.ItemArray
                rowString.Add(CType(d, String))
            Next
        Next
        Return rowString.ToArray
    End Function
End Class
