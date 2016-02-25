Public Class frmImport

    Dim newDT, leftDT, rightDT As New DataTable
    Dim currentIDs, newIDs, bothIDs As New List(Of Integer)

    Private Sub frmImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLeft.DataSource = leftDT
        dgvRight.DataSource = rightDT

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim filePicker = New OpenFileDialog()
        If filePicker.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtFilepath.Text = filePicker.FileName
        End If
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Try
            newDT = frmMain.myExcelSpreadsheet.importFromSpreadsheet(txtFilepath.Text)
            compareTables()
        Catch ex As Exception
            MsgBox("Error!")
        End Try
    End Sub

    Sub compareTables()

        currentIDs = getIDList(frmMain.myMusic.musicDataTable)
        newIDs = getIDList(newDT)

        For i = 0 To currentIDs.Count - 1
            For j = 0 To newIDs.Count - 1
                If currentIDs(i) = newIDs(j) Then
                    bothIDs.Add(newIDs(j))
                    currentIDs(i) = -1 'mark for deletion
                    newIDs.RemoveAt(j)
                End If
            Next
        Next
        'now delete relic entries
        currentIDs.RemoveAll(Function(i)
                                 Return (i < 0)
                             End Function)

        leftDT = frmMain.myMusic.musicDataTable.Clone
        rightDT = newDT.Clone

        For i = 0 To currentIDs.Count - 1
            leftDT.ImportRow(frmMain.myMusic.musicDataTable.Rows(currentIDs(i)))
        Next

        For i = 0 To newIDs.Count - 1
            rightDT.ImportRow(newDT.Rows(currentIDs(i)))
        Next

        'Future Ben - no way to tell when importing what entries have been changed, cause date edited will be the same. Maybe use formulas or something?
    End Sub

    Function getIDList(ByVal dt As DataTable) As List(Of Integer)
        Dim tempIDs As New List(Of Integer)
        For i = 0 To dt.Rows.Count - 1
            tempIDs.Add(dt.Rows(i)(0))
        Next
        Return tempIDs
    End Function

End Class