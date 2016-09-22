<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.WindTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GetKeysControl = New System.Windows.Forms.TextBox()
        Me.LoginPanel = New System.Windows.Forms.Panel()
        Me.LoginButton = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UserNameLabel = New System.Windows.Forms.Label()
        Me.RingLabel = New System.Windows.Forms.Label()
        Me.ExamineLabel = New System.Windows.Forms.Label()
        Me.EarthLabel = New System.Windows.Forms.Label()
        Me.CodeLabel = New System.Windows.Forms.Label()
        Me.LoginPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'WindTimer
        '
        Me.WindTimer.Enabled = True
        '
        'GetKeysControl
        '
        Me.GetKeysControl.Location = New System.Drawing.Point(0, 0)
        Me.GetKeysControl.MaxLength = 20
        Me.GetKeysControl.Name = "GetKeysControl"
        Me.GetKeysControl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.GetKeysControl.ShortcutsEnabled = False
        Me.GetKeysControl.Size = New System.Drawing.Size(0, 21)
        Me.GetKeysControl.TabIndex = 2
        '
        'LoginPanel
        '
        Me.LoginPanel.BackColor = System.Drawing.Color.Transparent
        Me.LoginPanel.BackgroundImage = Global.风_滤镜.My.Resources.BitmapResource.LoginArea
        Me.LoginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LoginPanel.Controls.Add(Me.LoginButton)
        Me.LoginPanel.Controls.Add(Me.PasswordLabel)
        Me.LoginPanel.Controls.Add(Me.UserNameLabel)
        Me.LoginPanel.Location = New System.Drawing.Point(43, 12)
        Me.LoginPanel.Name = "LoginPanel"
        Me.LoginPanel.Size = New System.Drawing.Size(360, 360)
        Me.LoginPanel.TabIndex = 3
        '
        'LoginButton
        '
        Me.LoginButton.Font = New System.Drawing.Font("Agency FB", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LoginButton.Image = Global.风_滤镜.My.Resources.BitmapResource.Button_0
        Me.LoginButton.Location = New System.Drawing.Point(108, 202)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(138, 164)
        Me.LoginButton.TabIndex = 2
        Me.LoginButton.Text = "Login In"
        Me.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.PasswordLabel.Image = Global.风_滤镜.My.Resources.BitmapResource.InputBox_Normal
        Me.PasswordLabel.Location = New System.Drawing.Point(51, 156)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(259, 49)
        Me.PasswordLabel.TabIndex = 1
        Me.PasswordLabel.Text = "Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserNameLabel
        '
        Me.UserNameLabel.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameLabel.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.UserNameLabel.Image = Global.风_滤镜.My.Resources.BitmapResource.InputBox_Focus
        Me.UserNameLabel.Location = New System.Drawing.Point(51, 107)
        Me.UserNameLabel.Name = "UserNameLabel"
        Me.UserNameLabel.Size = New System.Drawing.Size(259, 49)
        Me.UserNameLabel.TabIndex = 0
        Me.UserNameLabel.Text = "UserName"
        Me.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RingLabel
        '
        Me.RingLabel.BackColor = System.Drawing.Color.Transparent
        Me.RingLabel.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RingLabel.ForeColor = System.Drawing.Color.Aqua
        Me.RingLabel.Location = New System.Drawing.Point(0, 200)
        Me.RingLabel.Name = "RingLabel"
        Me.RingLabel.Size = New System.Drawing.Size(100, 100)
        Me.RingLabel.TabIndex = 3
        Me.RingLabel.Text = "Connecting ..."
        Me.RingLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ExamineLabel
        '
        Me.ExamineLabel.BackColor = System.Drawing.Color.Transparent
        Me.ExamineLabel.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExamineLabel.ForeColor = System.Drawing.Color.Aqua
        Me.ExamineLabel.Location = New System.Drawing.Point(0, 300)
        Me.ExamineLabel.Name = "ExamineLabel"
        Me.ExamineLabel.Size = New System.Drawing.Size(116, 100)
        Me.ExamineLabel.TabIndex = 4
        Me.ExamineLabel.Text = "Testing ..."
        Me.ExamineLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'EarthLabel
        '
        Me.EarthLabel.BackColor = System.Drawing.Color.Transparent
        Me.EarthLabel.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EarthLabel.ForeColor = System.Drawing.Color.Aqua
        Me.EarthLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EarthLabel.Location = New System.Drawing.Point(370, 254)
        Me.EarthLabel.Name = "EarthLabel"
        Me.EarthLabel.Size = New System.Drawing.Size(120, 100)
        Me.EarthLabel.TabIndex = 5
        Me.EarthLabel.Text = "Scaning ..."
        Me.EarthLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'CodeLabel
        '
        Me.CodeLabel.BackColor = System.Drawing.Color.Transparent
        Me.CodeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CodeLabel.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CodeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CodeLabel.Location = New System.Drawing.Point(0, 0)
        Me.CodeLabel.Name = "CodeLabel"
        Me.CodeLabel.Size = New System.Drawing.Size(450, 400)
        Me.CodeLabel.TabIndex = 6
        Me.CodeLabel.Text = resources.GetString("CodeLabel.Text")
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.风_滤镜.My.Resources.BitmapResource.Test
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(450, 400)
        Me.Controls.Add(Me.EarthLabel)
        Me.Controls.Add(Me.ExamineLabel)
        Me.Controls.Add(Me.RingLabel)
        Me.Controls.Add(Me.LoginPanel)
        Me.Controls.Add(Me.GetKeysControl)
        Me.Controls.Add(Me.CodeLabel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HackSystem-Login In"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.LoginPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WindTimer As System.Windows.Forms.Timer
    Friend WithEvents GetKeysControl As TextBox
    Friend WithEvents LoginPanel As Panel
    Friend WithEvents UserNameLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents LoginButton As Label
    Friend WithEvents RingLabel As Label
    Friend WithEvents ExamineLabel As Label
    Friend WithEvents EarthLabel As Label
    Friend WithEvents CodeLabel As Label
End Class
