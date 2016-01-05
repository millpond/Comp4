<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.splLogin = New System.Windows.Forms.SplitContainer()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.splLoginExtra = New System.Windows.Forms.SplitContainer()
        Me.btnAdduser = New System.Windows.Forms.Button()
        CType(Me.splLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splLogin.Panel1.SuspendLayout()
        Me.splLogin.Panel2.SuspendLayout()
        Me.splLogin.SuspendLayout()
        CType(Me.splLoginExtra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splLoginExtra.SuspendLayout()
        Me.SuspendLayout()
        '
        'splLogin
        '
        Me.splLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splLogin.IsSplitterFixed = True
        Me.splLogin.Location = New System.Drawing.Point(0, 0)
        Me.splLogin.Name = "splLogin"
        '
        'splLogin.Panel1
        '
        Me.splLogin.Panel1.Controls.Add(Me.btnAdduser)
        Me.splLogin.Panel1.Controls.Add(Me.btnLogin)
        Me.splLogin.Panel1.Controls.Add(Me.lblPassword)
        Me.splLogin.Panel1.Controls.Add(Me.txtPassword)
        Me.splLogin.Panel1.Controls.Add(Me.lblUsername)
        Me.splLogin.Panel1.Controls.Add(Me.Label1)
        Me.splLogin.Panel1.Controls.Add(Me.txtUsername)
        '
        'splLogin.Panel2
        '
        Me.splLogin.Panel2.Controls.Add(Me.splLoginExtra)
        Me.splLogin.Size = New System.Drawing.Size(622, 376)
        Me.splLogin.SplitterDistance = 311
        Me.splLogin.TabIndex = 0
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(71, 192)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(185, 58)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(42, 126)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(106, 123)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(150, 20)
        Me.txtPassword.TabIndex = 3
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(42, 100)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(58, 13)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 52)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Login"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(106, 97)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(150, 20)
        Me.txtUsername.TabIndex = 0
        '
        'splLoginExtra
        '
        Me.splLoginExtra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splLoginExtra.Location = New System.Drawing.Point(0, 0)
        Me.splLoginExtra.Name = "splLoginExtra"
        Me.splLoginExtra.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splLoginExtra.Panel1
        '
        Me.splLoginExtra.Panel1.BackgroundImage = CType(resources.GetObject("splLoginExtra.Panel1.BackgroundImage"), System.Drawing.Image)
        Me.splLoginExtra.Size = New System.Drawing.Size(307, 376)
        Me.splLoginExtra.SplitterDistance = 291
        Me.splLoginExtra.TabIndex = 0
        '
        'btnAdduser
        '
        Me.btnAdduser.Location = New System.Drawing.Point(75, 286)
        Me.btnAdduser.Name = "btnAdduser"
        Me.btnAdduser.Size = New System.Drawing.Size(75, 23)
        Me.btnAdduser.TabIndex = 5
        Me.btnAdduser.Text = "Add User"
        Me.btnAdduser.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(622, 376)
        Me.Controls.Add(Me.splLogin)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.splLogin.Panel1.ResumeLayout(False)
        Me.splLogin.Panel1.PerformLayout()
        Me.splLogin.Panel2.ResumeLayout(False)
        CType(Me.splLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splLogin.ResumeLayout(False)
        CType(Me.splLoginExtra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splLoginExtra.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents splLogin As System.Windows.Forms.SplitContainer
    Friend WithEvents splLoginExtra As System.Windows.Forms.SplitContainer
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnAdduser As Button
End Class
