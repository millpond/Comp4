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
        Me.txtUID = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtForename = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAddtoDb = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtUID
        '
        Me.txtUID.Location = New System.Drawing.Point(139, 12)
        Me.txtUID.Name = "txtUID"
        Me.txtUID.Size = New System.Drawing.Size(223, 20)
        Me.txtUID.TabIndex = 0
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(139, 38)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(223, 20)
        Me.txtLogin.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(139, 64)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(223, 20)
        Me.txtPassword.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(139, 90)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(223, 20)
        Me.txtEmail.TabIndex = 3
        '
        'txtForename
        '
        Me.txtForename.Location = New System.Drawing.Point(139, 116)
        Me.txtForename.Name = "txtForename"
        Me.txtForename.Size = New System.Drawing.Size(223, 20)
        Me.txtForename.TabIndex = 4
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(139, 142)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(223, 20)
        Me.txtSurname.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "UID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Login:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(96, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(76, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Forename:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(81, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Surname:"
        '
        'btnAddtoDb
        '
        Me.btnAddtoDb.Location = New System.Drawing.Point(194, 196)
        Me.btnAddtoDb.Name = "btnAddtoDb"
        Me.btnAddtoDb.Size = New System.Drawing.Size(75, 23)
        Me.btnAddtoDb.TabIndex = 12
        Me.btnAddtoDb.Text = "Add to DB"
        Me.btnAddtoDb.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 438)
        Me.Controls.Add(Me.btnAddtoDb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtForename)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.txtUID)
        Me.Name = "frmMain"
        Me.Text = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUID As TextBox
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtForename As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAddtoDb As Button
End Class
