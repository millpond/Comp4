'Public Class MusicPiece

'    Private baseTagList As List(Of String)
'    Private baseTagListString As String

'    Public Property basePieceID As Integer
'    Public Property baseType As MusicType
'    Public Property baseTitle As String
'    Public Property baseComposerSurname As String
'    Public Property baseComposerForename As String
'    Public Property baseLocation As String
'    Public Property baseStatus As MusicStatus
'    Public Property baseYearAdded As Integer
'    Public Property basePieceOrigin As String
'    Public Property baseCopyNotes As String
'    Public Property basePurchaseCost As Double
'    Public Property baseReplacementCost As Double
'    Public Property baseTags As List(Of String)
'        Get
'            'Convert Tagliststring into actual list of tags
'            Dim stringList As New List(Of String)
'            Dim tempString As String = ""
'            For i = 0 To baseTagListString.Length - 1
'                If Not baseTagListString(i) = "/" Then
'                    If baseTagListString(i) = "_" Then 'Replace _ with spaces
'                        tempString += " "
'                    Else
'                        tempString += baseTagListString(i)
'                    End If
'                Else
'                    stringList.Add(tempString)
'                    tempString = ""
'                End If
'            Next
'            stringList.Add(tempString)
'            baseTagList = stringList

'            Return baseTagList
'        End Get
'        Set(value As List(Of String))
'            baseTagList = value
'        End Set
'    End Property
'    Public Property baseTagsString As String
'        Get
'            'Convert Tag List back to string
'            Dim tempString As String = ""
'            Dim tempTag As String = ""

'            For i = 0 To baseTagList.Count - 1
'                'Replace any spaces with _
'                tempTag = baseTagList(i).Replace(" ", "_")
'                tempString = tempString + tempTag + "/"
'            Next

'            Return tempString
'        End Get
'        Set(value As String)
'            baseTagListString = value
'        End Set
'    End Property
'    Public Property baseDateEdited As Integer
'    Public Property choralVoices As String
'    Public Property choralNumCopies As Integer
'    Public Property orchScoreType As OrchestralScoreType
'    Public Property orchOrchestration As String

'End Class
