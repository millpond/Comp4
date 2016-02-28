Public Class frmLogin

    Private Sub btnAdduser_Click(sender As Object, e As EventArgs) Handles btnAdduser.Click
        Dim myFrmMain As New frmMain
        frmMain.Activate()
        frmMain.Show()
    End Sub

End Class
