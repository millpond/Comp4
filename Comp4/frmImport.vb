Public Class frmImport

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim filePicker = New OpenFileDialog()
        If filePicker.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtFilepath.Text = filePicker.FileName
        End If
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Try
            compareTables(frmMain.myExcelSpreadsheet.importFromSpreadsheet(txtFilepath.Text))
        Catch ex As Exception
            MsgBox("Couldn't find file!")
        End Try
    End Sub

    Sub compareTables(ByVal newDT As DataTable)
        Dim curDT As New DataTable
        curDT = frmMain.myMusic.musicDataTable
        curDT.Columns.Remove(0)

    End Sub
End Class