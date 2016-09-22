Public Class LoginForm
    Dim ActiveLabel As Label

    ''' <summary>
    ''' 正弦式风滤镜
    ''' </summary>
    ''' <param name="BitmapRes">传入的图像</param>
    ''' <param name="WaveWidth">波形宽度</param>
    ''' <param name="WaveHeight">波形高度</param>
    ''' <param name="VolatilityPixel">在宽度的基础上随机偏移的距离范围</param>
    ''' <param name="WindRnd">表示滤镜浓度</param>
    ''' <returns></returns>
    Private Function WindWave(ByVal BitmapRes As Bitmap, ByVal WaveWidth As Integer, ByVal WaveHeight As Integer, ByVal VolatilityPixel As Integer, ByVal WindRnd As Single) As Bitmap
        Dim ResultBitmap As Bitmap = BitmapRes.Clone
        Dim TempBitmap As Bitmap
        Dim TempRectangle As Rectangle = New Rectangle(0, 0, ResultBitmap.Width, 1)
        Dim TempWaveHeight As Integer
        Dim ToRight As Boolean
        Dim RndPixel As Integer
        Using TempGraphics As Graphics = Graphics.FromImage(ResultBitmap)
            For PointY = 0 To ResultBitmap.Height - 1
                If VBMath.Rnd > WindRnd Then
                    VBMath.Randomize()
                    ToRight = (VBMath.Rnd > 0.5)
                    TempWaveHeight = VBMath.Rnd * WaveHeight
                    For IndexY = 0 To TempWaveHeight - 1
                        If (IndexY + PointY < ResultBitmap.Height) Then
                            RndPixel = Math.Sin(IIf(ToRight, 1, -1) * Math.PI * IndexY / TempWaveHeight) * WaveWidth + VolatilityPixel * VBMath.Rnd
                            TempRectangle.Y = IndexY + PointY
                            TempBitmap = ResultBitmap.Clone(TempRectangle, Imaging.PixelFormat.Format32bppArgb)
                            'TempGraphics.DrawLine(Pens.Gray, 0, IndexY + PointY, ResultBitmap.Width, IndexY + PointY)
                            TempGraphics.DrawImage(TempBitmap, RndPixel, IndexY + PointY)
                        End If
                    Next

                    PointY += TempWaveHeight
                End If
            Next
        End Using
        Return ResultBitmap
    End Function

    ''' <summary>
    ''' 离散型风滤镜
    ''' </summary>
    ''' <param name="BitmapRes">传入的图像资源</param>
    ''' <param name="Pixel">线条偏移的宽度范围</param>
    ''' <param name="WindRnd">滤镜浓度</param>
    ''' <returns></returns>
    Private Function WindLine(ByVal BitmapRes As Bitmap, ByVal Pixel As Integer, ByVal WindRnd As Single) As Bitmap
        Dim ResultBitmap As Bitmap = BitmapRes.Clone
        Dim RndPixel As Integer
        Dim TempBitmap As Bitmap
        Dim TempRectangle As Rectangle = New Rectangle(0, 0, ResultBitmap.Width, 1)
        Using TempGraphics As Graphics = Graphics.FromImage(ResultBitmap)
            For Y As Long = 0 To ResultBitmap.Height - 1
                If VBMath.Rnd > WindRnd Then
                    VBMath.Randomize()
                    RndPixel = VBMath.Rnd * Pixel * 2 - Pixel
                    TempRectangle.Y = Y
                    TempBitmap = ResultBitmap.Clone(TempRectangle, Imaging.PixelFormat.Format32bppArgb)
                    'TempGraphics.DrawLine(Pens.Gray, 0, Y, ResultBitmap.Width, Y)
                    TempGraphics.DrawImage(TempBitmap, RndPixel, Y)
                End If
            Next
        End Using

        Return ResultBitmap
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles WindTimer.Tick
        Static WindFlag As Boolean = False
        Static RingIndex As Integer = 0
        Static ExamineIndex As Integer = 0
        Static EarthIndex As Integer = 45
        RingLabel.Image = My.Resources.BitmapResource.ResourceManager.GetObject("Ring_" & RingIndex)
        RingIndex = (RingIndex + 1 + 20) Mod 20
        ExamineLabel.Image = My.Resources.BitmapResource.ResourceManager.GetObject("Examine_" & ExamineIndex)
        ExamineIndex = (ExamineIndex + 1 + 18) Mod 18
        EarthLabel.Image = My.Resources.BitmapResource.ResourceManager.GetObject("Earth_" & EarthIndex)
        EarthIndex = (EarthIndex - 1 + 45) Mod 45

        '循环滚动代码；按换行符分割代码为两个元素，颠倒两个元素顺序后合并后显示，循环即可
        Dim CodeString() As String = Split(CodeLabel.Text, vbCrLf, 2)
        CodeLabel.Text = CodeString(1) & vbCrLf & CodeString(0)

        If WindFlag Then
            WindFlag = False
            If WindFlag = 0 Then Me.BackgroundImage = My.Resources.BitmapResource.Test
        Else
            If VBMath.Rnd < 0.1 Then
                WindFlag = True
                If VBMath.Rnd > 0.5 Then
                    Me.BackgroundImage = WindLine(My.Resources.BitmapResource.Test, Me.Width * 0.1, VBMath.Rnd / 2 + 0.5)
                Else
                    Me.BackgroundImage = WindWave(My.Resources.BitmapResource.Test, Me.Width * 0.1, Me.Height * 0.2, Me.Height * 0.01, VBMath.Rnd / 2 + 0.5)
                End If
                GC.Collect()
            End If
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = My.Resources.BitmapResource.Wind

        EarthLabel.Parent = CodeLabel
        RingLabel.Parent = CodeLabel
        ExamineLabel.Parent = CodeLabel
        'LoginPanel.Parent = CodeLabel

        ActiveLabel = UserNameLabel
        CodeLabel.Width = Me.Width / 2
        LoginPanel.Left = (Me.Width - LoginPanel.Width) - 45
        LoginPanel.Top = (Me.Height - LoginPanel.Height) / 2
        LoginButton.Left = (LoginPanel.Width - LoginButton.Width) / 2
        LoginButton.Top = (LoginPanel.Height - LoginButton.Height) + 10
        RingLabel.Left = 30
        RingLabel.Top = Me.Height - RingLabel.Height - 30
        ExamineLabel.Left = RingLabel.Right + 20
        ExamineLabel.Top = RingLabel.Top
        EarthLabel.Left = ExamineLabel.Right + 20
        EarthLabel.Top = ExamineLabel.Top
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

    End Sub


#Region "登录按钮动态效果"
    Private Sub LoginButton_MouseDown(sender As Object, e As MouseEventArgs) Handles LoginButton.MouseDown
        LoginButton.Image = My.Resources.BitmapResource.Button_2
        LoginButton.Font = New Font(LoginButton.Font.FontFamily, 20)
    End Sub

    Private Sub LoginButton_MouseEnter(sender As Object, e As EventArgs) Handles LoginButton.MouseEnter
        LoginButton.Image = My.Resources.BitmapResource.Button_1
        LoginButton.Font = New Font(LoginButton.Font.FontFamily, 22)
    End Sub

    Private Sub LoginButton_MouseLeave(sender As Object, e As EventArgs) Handles LoginButton.MouseLeave
        LoginButton.Image = My.Resources.BitmapResource.Button_0
        LoginButton.Font = New Font(LoginButton.Font.FontFamily, 21.75)
    End Sub

    Private Sub LoginButton_MouseUp(sender As Object, e As MouseEventArgs) Handles LoginButton.MouseUp
        LoginButton.Image = My.Resources.BitmapResource.Button_1
        LoginButton.Font = New Font(LoginButton.Font.FontFamily, 22)
    End Sub
#End Region

#Region "用户输入数据动态效果"

    Private Sub UserDataLabel_MouseEnter(sender As Object, e As EventArgs) Handles UserNameLabel.MouseEnter, PasswordLabel.MouseEnter
        CType(sender, Label).Image = My.Resources.BitmapResource.InputBox_Active
    End Sub

    Private Sub UserDataLabel_MouseLeave(sender As Object, e As EventArgs) Handles UserNameLabel.MouseLeave, PasswordLabel.MouseLeave
        CType(sender, Label).Image = My.Resources.BitmapResource.InputBox_Normal
    End Sub

    Private Sub UserDataLabel_MouseDown(sender As Object, e As MouseEventArgs) Handles UserNameLabel.MouseDown, PasswordLabel.MouseDown
        CType(sender, Label).Image = My.Resources.BitmapResource.InputBox_Active
    End Sub

    Private Sub UserDataLabel_MouseUp(sender As Object, e As MouseEventArgs) Handles UserNameLabel.MouseUp, PasswordLabel.MouseUp
        CType(sender, Label).Image = My.Resources.BitmapResource.InputBox_Focus
    End Sub
#End Region

#Region "使用 TextBox 接收按键消息"
    Private Sub GetKeysControl_TextChanged(sender As Object, e As EventArgs) Handles GetKeysControl.TextChanged
        ActiveLabel.Text = GetKeysControl.Text
    End Sub

    Private Sub GetKeysControl_LostFocus(sender As Object, e As EventArgs) Handles GetKeysControl.LostFocus
        GetKeysControl.Focus()
    End Sub

    Private Sub UserDataLabel_Click(sender As Object, e As EventArgs) Handles UserNameLabel.Click, PasswordLabel.Click
        If ActiveLabel IsNot sender Then
            ActiveLabel = sender
            GetKeysControl.Text = sender.Text
            GetKeysControl.SelectionStart = GetKeysControl.Text.Length
        End If
    End Sub

#End Region

End Class
