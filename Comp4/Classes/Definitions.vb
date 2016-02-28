Public Module Definitions 'TODO: check/sync with cw. note structure changes

    Public Const numHeaders As Integer = 18

    Public Const configFile As String = "C:\Users\Ben\Dropbox\comp4\Comp4\Comp4\ELConfig.txt"

    Public myOptions As Options
    Public mySQL As PostgreSQL
    Public myMusic As LocalMusic
    Public myActiveMusic As DataTable
    Public myExcelSpreadsheet As ExcelSpreadsheet

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
        Dim borrowPieceID As String
        Dim borrowUserID As String
        Dim borrowStartDate As Date
        Dim borrowEndDate As Date
        Dim borrowNotes As String
    End Structure

End Module
