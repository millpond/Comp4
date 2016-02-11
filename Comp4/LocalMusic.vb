Imports System.ComponentModel
Imports System.Reflection

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
        Loaned
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

    Structure MusicPiece
        Dim basePieceID As Integer
        Dim baseType As MusicType
        Dim baseTitle As String
        Dim baseComposerSurname As String
        Dim baseComposerForename As String
        Dim baseLocation As String
        Dim baseStatus As MusicStatus
        Dim baseYearAdded As Integer
        Dim basePieceOrigin As String
        Dim baseCopyNotes As String
        Dim basePurchaseCost As Double
        Dim baseReplacementCost As Double
        Dim choralVoices As String
        Dim choralNumCopies As Integer
        Dim orchScoreType As OrchestralScoreType
        Dim orchOrchestration As String
    End Structure

#End Region 'TODO: check/sync with cw. note structure changes

    Public musicPieceList As List(Of MusicPiece)
    Public musicDataTable As DataTable

#Region "Properties"

#End Region

    Sub New(ByVal populate As Boolean)
        musicDataTable = New DataTable
        If populate Then frmMain.mySQL.UpdateTable("Music", musicDataTable)
        'sort out mess, convert types etc.

    End Sub

    Sub PopulateList(ByVal musicPieceList As List(Of MusicPiece))

    End Sub

    Sub SortList()

    End Sub

    Function FilterList(ByVal filters As List(Of String))
        Return True
    End Function

End Class
