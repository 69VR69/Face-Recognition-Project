Public Class DataManager

    Public Sub New(ByRef storageManager As StorageManager)
        Me.storageManager = storageManager
    End Sub
    Private storageManager As StorageManager
    'TODO: protect from double imageName
    Public Function AddAnnotation(ByVal name As String, ByVal annotation As Panel()) As String()
        Dim newAnnotation As String() = Nothing
        Dim index As Integer = 1
        newAnnotation(0) = name
        For Each p In annotation
            newAnnotation(index) = p.Location.X + (p.Size.Width / 2)
            index += 1
            newAnnotation(index) = p.Location.Y + (p.Size.Height / 2)
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
    Private Function SearchAnnotatedImage(ByVal imageName As String) As String()
        Dim rowString As String() = Nothing
        Dim index As Integer = 0
        Dim dataRow As DataRow() = storageManager.annotationDataTable.Select("fileName = " & imageName)
        'rowString = String.Join(",", dataRow.ItemArray).Split(",").ToArray()

        For Each dr In dataRow
            rowString(index) += dr.ToString()
            index += 1
        Next
        Return rowString
    End Function
End Class
