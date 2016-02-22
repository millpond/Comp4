Public Class MusicPiece

    Enum OrchestralScoreType
        FullScore
        MiniScore
        PianoConductor
    End Enum

    Enum MusicStatus
        Available
        Reserved
        Loaned
    End Enum

    Enum MusicType
        Orchestral
        Choral
        Both
    End Enum

    'Structure PieceBorrow
    '    Dim borrowPieceID As String
    '    Dim borrowUserID As String
    '    Dim borrowStartDate As Date
    '    Dim borrowEndDate As Date
    '    Dim borrowNotes As String
    'End Structure

    Dim baseTagList As List(Of String)

    Public Property basePieceID As Integer
    Public Property baseType As MusicType
    Public Property baseTitle As String
    Public Property baseComposerSurname As String
    Public Property baseComposerForename As String
    Public Property baseLocation As String
    Public Property baseStatus As MusicStatus
    Public Property baseYearAdded As Integer
    Public Property basePieceOrigin As String
    Public Property baseCopyNotes As String
    Public Property basePurchaseCost As Double
    Public Property baseReplacementCost As Double
    Public Property baseTags As List(Of String)
        Get

        End Get
        Set(value As String)

        End Set
    End Property
    Public Property baseDateEdited As Integer
    Public Property choralVoices As String
    Public Property choralNumCopies As Integer
    Public Property orchScoreType As OrchestralScoreType
    Public Property orchOrchestration As String

End Class
