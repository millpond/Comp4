

Public Class frmImport

    Dim newDT, removeDT, addDT, editBeforeDT, editAfterDT As New DataTable
    Dim removeIDs, addIDs, editedIDs As New List(Of Integer)

    Private Sub frmImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpImport.Visible = False
        btnDone.Enabled = False
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim filePicker = New OpenFileDialog()
        If filePicker.ShowDialog() = DialogResult.OK Then
            txtFilepath.Text = filePicker.FileName
        End If
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        acceptChanges()
        myMusic.sync()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Try
            newDT = myExcelSpreadsheet.importFromSpreadsheet(txtFilepath.Text)
            newDT.PrimaryKey = New DataColumn() {newDT.Columns(0)}
            grpImport.Text = txtFilepath.Text
            getAllIDLists()
            makeDisplayTables()
            btnDone.Enabled = True
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
            MsgBox("Error!")
        End Try
    End Sub

    Sub getAllIDLists()
        removeIDs = getIDList(myMusic.musicDataTable)
        addIDs = getIDList(newDT)

        For i = 0 To removeIDs.Count - 1
            For j = 0 To addIDs.Count - 1
                If removeIDs(i) = addIDs(j) Then
                    If compareRows(myMusic.musicDataTable.Rows.Find(removeIDs(i)), newDT.Rows.Find(addIDs(j))) Then
                        editedIDs.Add(removeIDs(i))
                    End If
                    removeIDs(i) = -1 'mark for deletion
                    addIDs.RemoveAt(j)
                    Exit For 'TODO: maybe remove this?
                End If
            Next
        Next

        'now delete negative entries
        removeIDs.RemoveAll(Function(i)
                                Return (i < 0)
                            End Function)
    End Sub

    Sub makeDisplayTables()

        removeDT = myMusic.musicDataTable.Clone
        addDT = newDT.Clone
        editBeforeDT = myMusic.musicDataTable.Clone
        editAfterDT = newDT.Clone

        For i = 0 To removeIDs.Count - 1
            removeDT.ImportRow(myMusic.musicDataTable.Rows.Find(removeIDs(i)))
        Next

        For i = 0 To addIDs.Count - 1
            addDT.ImportRow(newDT.Rows.Find(addIDs(i)))
        Next

        For i = 0 To editedIDs.Count - 1
            editBeforeDT.ImportRow(myMusic.musicDataTable.Rows.Find(editedIDs(i)))
        Next

        For i = 0 To editedIDs.Count - 1
            editAfterDT.ImportRow(newDT.Rows.Find(editedIDs(i)))
        Next

        dgvRemove.DataSource = removeDT
        dgvAdd.DataSource = addDT
        dgvEditBefore.DataSource = editBeforeDT
        dgvEditAfter.DataSource = editAfterDT

        dgvRemove.ClearSelection()
        dgvAdd.ClearSelection()
        dgvEditBefore.ClearSelection()
        dgvEditAfter.ClearSelection()

        grpImport.Visible = True
    End Sub

    Sub acceptChanges()
        For i = 0 To removeIDs.Count - 1
            myMusic.musicDataTable.Rows.Remove(myMusic.musicDataTable.Rows.Find(removeIDs(i)))
        Next
        For i = 0 To editedIDs.Count - 1
            myMusic.musicDataTable.Rows.Remove(myMusic.musicDataTable.Rows.Find(editedIDs(i)))
            myMusic.musicDataTable.ImportRow(newDT.Rows.Find(editedIDs(i)))
            myMusic.updateDateEdited(editedIDs(i))
        Next
        For i = 0 To addIDs.Count - 1
            myMusic.musicDataTable.ImportRow(newDT.Rows.Find(addIDs(i)))
            myMusic.updateDateEdited(addIDs(i))
        Next

    End Sub

    Function getIDList(ByVal dt As DataTable) As List(Of Integer)
        Dim tempIDs As New List(Of Integer)
        For i = 0 To dt.Rows.Count - 1
            tempIDs.Add(dt.Rows(i)(0))
        Next
        Return tempIDs
    End Function

    'Compares rows and returns whether columns have changed
    Function compareRows(ByVal row1 As DataRow, ByVal row2 As DataRow) As Boolean
        'ignore row 0 - primary key since we know they are the same already
        For i = 1 To numHeaders
            If Not row1.Item(i) = row2.Item(i) Then
                Return True
            End If
        Next
        Return False
    End Function
End Class