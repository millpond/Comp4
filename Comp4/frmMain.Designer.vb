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
        Me.tlpViewer = New System.Windows.Forms.TableLayoutPanel()
        Me.txtFilters = New System.Windows.Forms.TextBox()
        Me.grpViewInfo = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblFullscreenInfo = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtSimpleSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSimpleSearch = New System.Windows.Forms.Button()
        Me.tbcMaintab.SuspendLayout()
        Me.tabViewer.SuspendLayout()
        Me.tlpViewer.SuspendLayout()
        Me.grpViewInfo.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
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
        Me.grpViewInfo.Text = "Info"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.97436!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.02564!))
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 12
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 39)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(419, 340)
        Me.DataGridView1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel3)
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
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(430, 421)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(8, 16)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.txtSimpleSearch, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnSimpleSearch, 1, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.17801!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 259.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(632, 382)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'txtSimpleSearch
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.txtSimpleSearch, 2)
        Me.txtSimpleSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSimpleSearch.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSimpleSearch.Location = New System.Drawing.Point(3, 47)
        Me.txtSimpleSearch.Name = "txtSimpleSearch"
        Me.txtSimpleSearch.Size = New System.Drawing.Size(626, 37)
        Me.txtSimpleSearch.TabIndex = 0
        Me.txtSimpleSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label1, 2)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Verdana", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(626, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search:"
        '
        'btnSimpleSearch
        '
        Me.btnSimpleSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSimpleSearch.Location = New System.Drawing.Point(534, 90)
        Me.btnSimpleSearch.Name = "btnSimpleSearch"
        Me.btnSimpleSearch.Size = New System.Drawing.Size(95, 30)
        Me.btnSimpleSearch.TabIndex = 2
        Me.btnSimpleSearch.Text = "Search!"
        Me.btnSimpleSearch.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 438)
        Me.Controls.Add(Me.TableLayoutPanel2)
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
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
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtSimpleSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSimpleSearch As System.Windows.Forms.Button

End Class
