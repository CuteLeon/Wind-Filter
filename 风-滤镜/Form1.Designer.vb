<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LoginLabel = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'LoginLabel
        '
        Me.LoginLabel.BackColor = System.Drawing.Color.Transparent
        Me.LoginLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoginLabel.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginLabel.ForeColor = System.Drawing.Color.White
        Me.LoginLabel.Image = Global.风_滤镜.My.Resources.BitmapResource.LoginArea
        Me.LoginLabel.Location = New System.Drawing.Point(0, 0)
        Me.LoginLabel.Name = "LoginLabel"
        Me.LoginLabel.Padding = New System.Windows.Forms.Padding(0, 200, 0, 0)
        Me.LoginLabel.Size = New System.Drawing.Size(541, 361)
        Me.LoginLabel.TabIndex = 1
        Me.LoginLabel.Text = "Leon" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password"
        Me.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(0, 21)
        Me.TextBox1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.风_滤镜.My.Resources.BitmapResource.Test
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(541, 361)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LoginLabel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "匿名者-黑客系统-登录"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LoginLabel As Label
    Friend WithEvents TextBox1 As TextBox
End Class
