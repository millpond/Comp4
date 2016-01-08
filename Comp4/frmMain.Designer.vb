<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tbcMaintab = New System.Windows.Forms.TabControl()
        Me.tabViewer = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblFullscreenInfo = New System.Windows.Forms.Label()
        Me.tlpViewer = New System.Windows.Forms.TableLayoutPanel()
        Me.txtFilters = New System.Windows.Forms.TextBox()
        Me.grpViewInfo = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tbcMaintab.SuspendLayout()
        Me.tabViewer.SuspendLayout()
        Me.tlpViewer.SuspendLayout()
        Me.grpViewInfo.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcMaintab
        '
        Me.tbcMaintab.Controls.Add(Me.tabViewer)
        Me.tbcMaintab.Controls.Add(Me.TabPage2)
        Me.tbcMaintab.HotTrack = True
        Me.tbcMaintab.Location = New System.Drawing.Point(12, 12)
        Me.tbcMaintab.Name = "tbcMaintab"
        Me.tbcMaintab.SelectedIndex = 0
        Me.tbcMaintab.Size = New System.Drawing.Size(646, 414)
        Me.tbcMaintab.TabIndex = 0
        '
        'tabViewer
        '
        Me.tabViewer.Controls.Add(Me.tlpViewer)
        Me.tabViewer.Location = New System.Drawing.Point(4, 22)
        Me.tabViewer.Name = "tabViewer"
        Me.tabViewer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabViewer.Size = New System.Drawing.Size(638, 388)
        Me.tabViewer.TabIndex = 0
        Me.tabViewer.Text = "View music"
        Me.tabViewer.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(638, 388)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblFullscreenInfo
        '
        Me.lblFullscreenInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFullscreenInfo.AutoSize = True
        Me.lblFullscreenInfo.Location = New System.Drawing.Point(532, 13)
        Me.lblFullscreenInfo.Name = "lblFullscreenInfo"
        Me.lblFullscreenInfo.Size = New System.Drawing.Size(120, 13)
        Me.lblFullscreenInfo.TabIndex = 1
        Me.lblFullscreenInfo.Text = "Ctrl-F to leave fullscreen"
        '
        'tlpViewer
        '
        Me.tlpViewer.ColumnCount = 2
        Me.tlpViewer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.40506!))
        Me.tlpViewer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.59494!))
        Me.tlpViewer.Controls.Add(Me.txtFilters, 0, 0)
        Me.tlpViewer.Controls.Add(Me.grpViewInfo, 1, 1)
        Me.tlpViewer.Controls.Add(Me.DataGridView1, 0, 1)
        Me.tlpViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpViewer.Location = New System.Drawing.Point(3, 3)
        Me.tlpViewer.Name = "tlpViewer"
        Me.tlpViewer.RowCount = 2
        Me.tlpViewer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.685863!))
        Me.tlpViewer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.31413!))
        Me.tlpViewer.Size = New System.Drawing.Size(632, 382)
        Me.tlpViewer.TabIndex = 0
        '
        'txtFilters
        '
        Me.txtFilters.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFilters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFilters.Location = New System.Drawing.Point(3, 3)
        Me.txtFilters.Multiline = True
        Me.txtFilters.Name = "txtFilters"
        Me.txtFilters.ReadOnly = True
        Me.txtFilters.Size = New System.Drawing.Size(419, 30)
        Me.txtFilters.TabIndex = 0
        Me.txtFilters.Text = "Filters applied: None"
        Me.txtFilters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpViewInfo
        '
        Me.grpViewInfo.Controls.Add(Me.TableLayoutPanel1)
        Me.grpViewInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpViewInfo.Location = New System.Drawing.Point(428, 39)
        Me.grpViewInfo.Name = "grpViewInfo"
        Me.grpViewInfo.Size = New System.Drawing.Size(201, 340)
        Me.grpViewInfo.TabIndex = 1
        Me.grpViewInfo.TabStop = False
        Me.grpViewInfo.Text = "grpViewInfo"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.97436!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.02564!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.MaskedTextBox1, 1, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 12
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 321)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stuff:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaskedTextBox1.Location = New System.Drawing.Point(78, 143)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(114, 20)
        Me.MaskedTextBox1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 39)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(419, 340)
        Me.DataGridView1.TabIndex = 2
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 438)
        Me.Controls.Add(Me.lblFullscreenInfo)
        Me.Controls.Add(Me.tbcMaintab)
        Me.MinimumSize = Me.ClientSize
        Me.Name = "frmMain"
        Me.Text = "Main"
        Me.tbcMaintab.ResumeLayout(False)
        Me.tabViewer.ResumeLayout(False)
        Me.tlpViewer.ResumeLayout(False)
        Me.tlpViewer.PerformLayout()
        Me.grpViewInfo.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbcMaintab As System.Windows.Forms.TabControl
    Friend WithEvents tabViewer As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lblFullscreenInfo As System.Windows.Forms.Label
    Friend WithEvents tlpViewer As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtFilters As System.Windows.Forms.TextBox
    Friend WithEvents grpViewInfo As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
