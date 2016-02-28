Public Class LocalMusic

    Public musicDataTable As DataTable

    Sub New()
        Dim headers As List(Of String) = myOptions.Headers
        musicDataTable = New DataTable
        mySQL.RetrieveTable("Music", musicDataTable)
        musicDataTable.Columns(0).Unique = True
        musicDataTable.PrimaryKey = New DataColumn() {musicDataTable.Columns(0)}
        For i = 0 To 18
            musicDataTable.Columns(i).ColumnName = headers(i)
        Next

    End Sub

    Function getTagsFromRow(ByVal row As Integer) As List(Of String)
        Dim rowString As String = musicDataTable.Rows(row)(10).ToString
        Dim stringList As New List(Of String)
        Dim tempString As String = ""
        For i = 0 To rowString.Length - 1
            If Not rowString(i) = "/" Then
                If rowString(i) = "_" Then 'Replace _ with spaces
                    tempString += " "
                Else
                    tempString += rowString(i)
                End If
            Else
                stringList.Add(tempString)
                tempString = ""
            End If
        Next
        stringList.Add(tempString)
        Return stringList
    End Function

    Function getRowsFromTags(ByVal tags As List(Of String)) As List(Of Integer)
        Dim rowsList As New List(Of Integer)
        Dim counter As Integer
        Dim listLength As Integer = tags.Count
        For i = 0 To musicDataTable.Rows.Count - 1
            counter = 0
            For j = 0 To tags.Count - 1
                If musicDataTable.Rows(i)(10).ToString.Contains(tags(j)) Then
                    counter += 1
                End If
            Next
            If counter = listLength Then
                rowsList.Add(i)
            End If
        Next
        Return rowsList
    End Function

    Sub updateDateEdited(ByVal rowID As Integer)
        musicDataTable.Rows.Find(rowID)(11) = Date.Now
    End Sub

    Sub sync()
        mySQL.SendTable("Music", musicDataTable)
        mySQL.RetrieveTable("Music", musicDataTable)
    End Sub
    Function quicksort(ByVal drArray As List(Of DataRow)) As List(Of DataRow)
        If drArray.Count <= 1 Then Return drArray
        Dim pivot As Integer = drArray(drArray.Count / 2)(0)
        Dim less, more As New List(Of DataRow)
        Dim equal As DataRow
        For i = 0 To drArray.Count - 1
            Select Case drArray(i)(0)
                Case < pivot
                    less.Add(drArray(i))
                Case = pivot
                    equal = drArray(i)
                Case > pivot
                    more.Add(drArray(i))
            End Select
        Next
        Return New List(Of DataRow)(less.Concat(more))
    End Function

End Class
