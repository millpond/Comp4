Imports Excel = Microsoft.Office.Interop.Excel

Public Class ExcelSpreadsheet

    Dim XLap As Excel.Application 'our Excel container
    Dim XLwb As Excel.Workbook 'our Excel workbook
    Dim XLsh As Excel.Worksheet 'our Excel worksheet
    Dim XLrg As Excel.Range 'A specific range of cells we may want to work with
    Dim excelHeaderList As List(Of String)

    Public Sub New()
        'Get list of headers from our options
        excelHeaderList = frmMain.myOptions.Headers
    End Sub

    ''' <summary>
    ''' Attempts to import data from an excel spreadsheet into the main datatable, then compares
    ''' </summary>    
    Public Function importFromSpreadsheet(ByVal filepath As String) As DataTable
        Dim tempDataTable As New DataTable
        Dim tempDataRow(15) As String
        Dim copyDataTable As DataTable = frmMain.myMusic.musicDataTable
        Dim rowIndex As Integer = 3
        XLap = CreateObject("Excel.Application")
        XLwb = XLap.Workbooks.Open(filepath)
        XLsh = XLap.ActiveSheet
        'Set up our temp datatable - deliberately leave out pieceid column(0)
        For i = 1 To copyDataTable.Columns.Count - 1
            tempDataTable.Columns.Add(copyDataTable.Columns(i).ToString)
        Next
        While Not XLsh.Cells(rowIndex, 1).text.ToString = ""
            For colIndex = 1 To 16
                tempDataRow(colIndex - 1) = XLsh.Cells(rowIndex, colIndex).value
            Next
            tempDataTable.Rows.Add(tempDataRow)
            rowIndex += 1
        End While
        Return tempDataTable
    End Function

    ''' <summary>
    ''' Exports the given table to a new spreadsheet and formats nicely
    ''' </summary>    
    Public Sub exportToSpreadsheet(ByVal table As DataTable)
        Dim tempDataTable As DataTable = table.Copy
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
            .Cells(2, 16).value = "Notes"
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
            For i = 1 To 16
                .Cells(2, i) = excelHeaderList(i - 1)
            Next
            'TODO: potentially add comments
        End With

        'Remove PieceID column - unnecessary to user
        tempDataTable.Columns.Remove("pieceid")

        Dim tableDataColumn As DataColumn
        Dim tableDataRow As DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0

        'Insert datatable data into spreadsheet
        For Each tableDataRow In tempDataTable.Rows
            rowIndex += 1
            colIndex = 0
            For Each tableDataColumn In tempDataTable.Columns
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
