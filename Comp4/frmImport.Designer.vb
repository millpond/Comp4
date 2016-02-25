<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImport
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
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dgvRight = New System.Windows.Forms.DataGridView()
        Me.dgvLeft = New System.Windows.Forms.DataGridView()
        CType(Me.dgvRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(184, 10)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(26, 23)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFilepath
        '
        Me.txtFilepath.Location = New System.Drawing.Point(12, 12)
        Me.txtFilepath.Name = "txtFilepath"
        Me.txtFilepath.Size = New System.Drawing.Size(166, 20)
        Me.txtFilepath.TabIndex = 1
        '
        'btnDone
        '
        Me.btnDone.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnDone.Location = New System.Drawing.Point(707, 436)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 2
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(216, 10)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 3
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(12, 436)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dgvRight
        '
        Me.dgvRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRight.Location = New System.Drawing.Point(422, 82)
        Me.dgvRight.Name = "dgvRight"
        Me.dgvRight.Size = New System.Drawing.Size(360, 348)
        Me.dgvRight.TabIndex = 6
        '
        'dgvLeft
        '
        Me.dgvLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLeft.Location = New System.Drawing.Point(12, 82)
        Me.dgvLeft.Name = "dgvLeft"
        Me.dgvLeft.Size = New System.Drawing.Size(360, 348)
        Me.dgvLeft.TabIndex = 7
        '
        'frmImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 471)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvLeft)
        Me.Controls.Add(Me.dgvRight)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.txtFilepath)
        Me.Controls.Add(Me.btnBrowse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(810, 509)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(810, 509)
        Me.Name = "frmImport"
        Me.Text = "Import"
        CType(Me.dgvRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtFilepath As System.Windows.Forms.TextBox
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents dgvRight As DataGridView
    Friend WithEvents dgvLeft As DataGridView
End Class
