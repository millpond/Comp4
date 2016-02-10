Imports Excel = Microsoft.Office.Interop.Excel

Public Class ExcelSpreadsheet

    Dim XLap As Excel.Application 'our Excel container
    Dim XLwb As Excel.Workbook 'our Excel workbook
    Dim XLsh As Excel.Worksheet 'our Excel worksheet
    Dim XLrg As Excel.Range 'A specific range of cells we may want to work with

    Public Sub New()
        'create spreadsheet object
    End Sub

    Public Sub importFromSpreadsheet(ByVal filepath As String)
        XLap = CreateObject("Excel.Application")
        'HER
    End Sub

    Public Sub exportToSpreadsheet(ByVal table As DataTable)
        'start excel and get application object
        XLap = CreateObject("Excel.Application")
        'add a new workbook
        XLwb = XLap.Workbooks.Add
        XLsh = XLap.ActiveSheet
        'Add and format table headers
        With XLsh
            'add and format row 1
            .Cells(1, 1).value = "All Music"
            .Cells(1, 10).value = "Orchestral"
            .Cells(1, 13).value = "Choral"
            .Cells(1, 16).value = "Notes"
            .Range(.Cells(1, 1), .Cells(1, 9)).Merge()
            .Range(.Cells(1, 10), .Cells(1, 12)).Merge()
            .Range(.Cells(1, 13), .Cells(1, 15)).Merge()
            .Range(.Cells(1, 16), .Cells(2, 16)).Merge()
            .Cells(1, 1).interior.color = Color.OliveDrab
            .Cells(1, 10).interior.color = Color.DarkCyan
            .Cells(1, 13).interior.color = Color.Goldenrod
            .Cells(1, 16).interior.color = Color.Firebrick
            With .Range("A1", "P1")
                .Font.Bold = True
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            'now row 2
            .Cells(2, 1).value = "Type"
            .Cells(2, 2).value = "Title"
            .Cells(2, 3).value = "Surname"
            .Cells(2, 4).value = "Fore Initials"
            .Cells(2, 5).value = "Status"
            .Cells(2, 6).value = "Year Added"
            .Cells(2, 7).value = "Piece Origin"
            .Cells(2, 8).value = "Purchase Cost"
            .Cells(2, 9).value = "Replacement Cost"
            .Cells(2, 10).value = "Orchestration"
            .Cells(2, 11).value = "Score Type"
            .Cells(2, 12).value = "Orch Location"
            .Cells(2, 13).value = "Voices"
            .Cells(2, 14).value = "No. of Copies"
            .Cells(2, 15).value = "Choral Location"
            .Cells(2, 16).value = "Notes"
            'TODO: potentially add comments
        End With
        XLap.Visible = True
        'Remove PieceID column - unnecessary to user
        table.Columns.Remove("pieceid")

        Dim tableDataColumn As DataColumn
        Dim tableDataRow As DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0

        'Insert datatable data into spreadsheet
        For Each tableDataRow In table.Rows
            rowIndex += 1
            colIndex = 0
            For Each tableDataColumn In table.Columns
                colIndex += 1
                XLsh.Cells(rowIndex + 2, colIndex) = tableDataRow(tableDataColumn.ColumnName)
            Next
        Next
        'Autofit columns
        XLrg = XLsh.Range("A1", "P1")
        XLrg.EntireColumn.AutoFit()
        XLap.Visible = True
        XLap.UserControl = True
        ' Release object references.
        XLrg = Nothing
        XLsh = Nothing
        XLwb = Nothing
        XLap.Quit()
        XLap = Nothing
    End Sub
End Class
