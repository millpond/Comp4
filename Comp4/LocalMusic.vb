Public Class LocalMusic

#Region "Enums/Structs**"

    Enum OrchestralScoreType
        FullScore
        MiniScore
        PianoConductor
    End Enum

    Enum MusicStatus
        Available
        Reserved
        OnLoan
    End Enum

    Enum MusicType
        Orchestral
        Choral
        Both
    End Enum

    Structure PieceBorrow
        Dim borrowPieceID As Integer
        Dim borrowUserID As Integer
        Dim borrowStartDate As Date
        Dim borrowEndDate As Date
        Dim borrowNotes As String
    End Structure

    Structure MusicBase
        Dim musicPieceID As Integer
        Dim musicType As MusicType
        Dim musicTitle As String
        Dim musicComposerSurname As String
        Dim musicComposerForename As String
        Dim musicLocation As String
        Dim musicStatus As MusicStatus
        Dim musicYearAdded As Integer
        Dim musicPieceOrigin As String
        Dim musicCopyNotes As String
        'Dim musicPurchaseCost As Money
        'Dim musicReplacementCost As Money TODO: Sort Money voices etc regex
    End Structure

    Structure MusicChoral
        'dim choralVoices As voicesRegex
        Dim choralNumCopies As Integer
    End Structure

    Structure MusicOrchestral
        'Dim orchestralOrchestration As regexhere
        Dim scoreType As OrchestralScoreType
    End Structure

#End Region 'TODO: check/sync with cw

    Public Class FinalMusicPiece
        Property finalMusicBase As MusicBase
        Property finalMusicChoral As MusicChoral '#idontknowwhatimdoing
        Property finalMusicOrchestral As MusicOrchestral
    End Class

    Private musicPieceList As List(Of FinalMusicPiece)

#Region "Properties"

    Property PieceList As Integer
        Get
            Return musicPieceList(PieceList)
        End Get
        Set(value As List(Of MusicFinalPiece))

        End Set
    End Property

#End Region

    Sub New()
        musicPieceList = New List(Of MusicFinalPiece)
        PopulateList(musicPieceList)
    End Sub

    Sub PopulateList(ByVal musicPieceList As List(Of MusicFinalPiece))

    End Sub
End Class
