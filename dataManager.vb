Public Class DataManager

    Public Sub New(ByRef storageManager As StorageManager)
        Me.storageManager = storageManager
    End Sub
    Private ReadOnly storageManager As StorageManager

    Public Function AddAnnotation(ByVal name As String, ByVal annotation As Panel()) As String()
        If annotation IsNot Nothing Then
            Dim newAnnotation As New List(Of String) From {name}
            For Each a In annotation
                newAnnotation.Add(a.Location.X)
                newAnnotation.Add(a.Location.Y)
            Next
            Return newAnnotation.ToArray
        End If
        Return {""}
    End Function

    Public Sub LoadAnnotation(ByVal name As String, ByRef panelList As Panel())
        Dim annotationArray As String() = SearchAnnotatedImage(name)
        If annotationArray.Length > 0 Then
            Dim index As Integer = 1
            For Each p In panelList
                Dim x As Integer = Integer.Parse(annotationArray(index))
                Dim y As Integer = Integer.Parse(annotationArray(index + 1))
                index += 2
                p.Location = New Point(x, y)
                p.Visible = True
            Next
        Else
            MessageBox.Show("file not found")
        End If
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
