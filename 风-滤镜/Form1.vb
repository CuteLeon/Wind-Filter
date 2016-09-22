Public Class Form1
    Dim WindBitmap As Bitmap = My.Resources.BitmapResource.Test
    Dim WallpaperPath As String() = IO.Directory.GetFiles("E:\MyPicture\DesktopBackground")
    Dim WallpaperCount As Integer = WallpaperPath.Length

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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static I As Integer = 0
        Static LastMax As Integer = 5
        If I = 0 Then
            If VBMath.Rnd > 0.5 Then
                Me.BackgroundImage = WindLine(WindBitmap, Me.Width * 0.05, VBMath.Rnd / 2 + 0.5)
            Else
                Me.BackgroundImage = WindWave(WindBitmap, Me.Width * 0.05, Me.Height * 0.2, Me.Height * 0.01, VBMath.Rnd / 2 + 0.5)
            End If
            GC.Collect()
        ElseIf I = 3 Then '表示滤镜持续时间
            Me.BackgroundImage = WindBitmap
        End If

        If I = LastMax Then '表示每个滤镜开始于结束的周期
            LastMax = VBMath.Rnd * 10 + 2
            I = 0
        Else
            I += 1
        End If
    End Sub

    Private Sub LoginLabel_Click(sender As Object, e As EventArgs) Handles LoginLabel.Click
        If WallpaperCount = 0 Then Exit Sub
        '用于自动跳过费图像文件
        On Error GoTo NextBitmap
        Timer1.Stop()
NextBitmap:
        WindBitmap.Dispose()
        Static WallpaperIndex As Integer = -1
        WallpaperIndex += 1
        WallpaperIndex = WallpaperIndex Mod WallpaperCount
        WindBitmap = Bitmap.FromFile(WallpaperPath(WallpaperIndex))
        Timer1.Start()
    End Sub
End Class
