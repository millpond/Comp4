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
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnTableEdit = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.tabSearch = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtSimpleSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSimpleSearch = New System.Windows.Forms.Button()
        Me.btnExcelExport = New System.Windows.Forms.Button()
        Me.btnExcelImport = New System.Windows.Forms.Button()
        Me.lblFullscreenInfo = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbcMaintab.SuspendLayout()
        Me.tabViewer.SuspendLayout()
        Me.tlpViewer.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.tabSearch.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcMaintab
        '
        Me.tbcMaintab.Controls.Add(Me.tabViewer)
        Me.tbcMaintab.Controls.Add(Me.tabSearch)
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
        Me.tlpViewer.Controls.Add(Me.dgvMain, 0, 1)
        Me.tlpViewer.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.tlpViewer.Controls.Add(Me.TableLayoutPanel1, 1, 1)
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
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AllowUserToOrderColumns = True
        Me.dgvMain.AllowUserToResizeRows = False
        Me.dgvMain.BackgroundColor = System.Drawing.Color.LemonChiffon
        Me.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvMain.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgvMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvMain.Location = New System.Drawing.Point(3, 39)
        Me.dgvMain.MultiSelect = False
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvMain.RowHeadersVisible = False
        Me.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMain.ShowCellErrors = False
        Me.dgvMain.ShowEditingIcon = False
        Me.dgvMain.ShowRowErrors = False
        Me.dgvMain.Size = New System.Drawing.Size(419, 340)
        Me.dgvMain.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnTableEdit, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnInfo, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(428, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(200, 30)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'btnTableEdit
        '
        Me.btnTableEdit.BackColor = System.Drawing.Color.LightGreen
        Me.btnTableEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTableEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab
        Me.btnTableEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTableEdit.Location = New System.Drawing.Point(103, 3)
        Me.btnTableEdit.Name = "btnTableEdit"
        Me.btnTableEdit.Size = New System.Drawing.Size(94, 24)
        Me.btnTableEdit.TabIndex = 1
        Me.btnTableEdit.Text = "Change Display"
        Me.btnTableEdit.UseVisualStyleBackColor = False
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.MistyRose
        Me.btnInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon
        Me.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfo.Location = New System.Drawing.Point(3, 3)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(94, 24)
        Me.btnInfo.TabIndex = 0
        Me.btnInfo.Text = "Piece Info"
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'tabSearch
        '
        Me.tabSearch.Controls.Add(Me.TableLayoutPanel3)
        Me.tabSearch.Location = New System.Drawing.Point(4, 22)
        Me.tabSearch.Name = "tabSearch"
        Me.tabSearch.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSearch.Size = New System.Drawing.Size(638, 388)
        Me.tabSearch.TabIndex = 1
        Me.tabSearch.Text = "Search"
        Me.tabSearch.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.txtSimpleSearch, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnSimpleSearch, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.btnExcelExport, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.btnExcelImport, 1, 3)
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
        'btnExcelExport
        '
        Me.btnExcelExport.Location = New System.Drawing.Point(3, 90)
        Me.btnExcelExport.Name = "btnExcelExport"
        Me.btnExcelExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExcelExport.TabIndex = 3
        Me.btnExcelExport.Text = "Export excel"
        Me.btnExcelExport.UseVisualStyleBackColor = True
        '
        'btnExcelImport
        '
        Me.btnExcelImport.Location = New System.Drawing.Point(534, 126)
        Me.btnExcelImport.Name = "btnExcelImport"
        Me.btnExcelImport.Size = New System.Drawing.Size(75, 23)
        Me.btnExcelImport.TabIndex = 4
        Me.btnExcelImport.Text = "Import excel"
        Me.btnExcelImport.UseVisualStyleBackColor = True
        '
        'lblFullscreenInfo
        '
        Me.lblFullscreenInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFullscreenInfo.AutoSize = True
        Me.lblFullscreenInfo.Location = New System.Drawing.Point(532, 13)
        Me.lblFullscreenInfo.Name = "lblFullscreenInfo"
        Me.lblFullscreenInfo.Size = New System.Drawing.Size(114, 13)
        Me.lblFullscreenInfo.TabIndex = 1
        Me.lblFullscreenInfo.Text = "F11 to leave fullscreen"
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(187, 234)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(187, 234)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(428, 39)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(201, 340)
        Me.TableLayoutPanel1.TabIndex = 5
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
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.tabSearch.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbcMaintab As System.Windows.Forms.TabControl
    Friend WithEvents tabViewer As System.Windows.Forms.TabPage
    Friend WithEvents tabSearch As System.Windows.Forms.TabPage
    Friend WithEvents lblFullscreenInfo As System.Windows.Forms.Label
    Friend WithEvents tlpViewer As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtFilters As System.Windows.Forms.TextBox
    Friend WithEvents dgvMain As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtSimpleSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSimpleSearch As System.Windows.Forms.Button
    Friend WithEvents btnExcelImport As Button
    Friend WithEvents btnExcelExport As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnTableEdit As Button
    Friend WithEvents btnInfo As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
