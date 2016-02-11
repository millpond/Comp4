Public Class frmChoosefile

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim filePicker = New OpenFileDialog()
        If filePicker.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtFilepath.Text = filePicker.FileName
        End If
    End Sub


End Class