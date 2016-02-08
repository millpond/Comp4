<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChoosefile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtFilepath = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(197, 45)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = true
        '
        'txtFilepath
        '
        Me.txtFilepath.Location = New System.Drawing.Point(12, 45)
        Me.txtFilepath.Name = "txtFilepath"
        Me.txtFilepath.Size = New System.Drawing.Size(166, 20)
        Me.txtFilepath.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button2.Location = New System.Drawing.Point(197, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "ok"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'frmChoosefile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtFilepath)
        Me.Controls.Add(Me.btnBrowse)
        Me.Name = "frmChoosefile"
        Me.Text = "frmChoosefile"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtFilepath As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
