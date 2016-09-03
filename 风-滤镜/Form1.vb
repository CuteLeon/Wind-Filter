Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = My.Resources.BitmapResource.Test_2
    End Sub

    Private Function WindWave(ByVal BitmapRes As Bitmap, ByVal WaveWidth As Integer, ByVal WaveHeight As Integer, ByVal VolatilityPixel As Integer) As Bitmap
        Dim GetBitmap As Bitmap = BitmapRes
        Dim TempWaveHeight As Integer
        Dim PointX, PointY, IndexY As Integer
        Dim RndPixel As Integer
        Dim MyColor As Color

        For PointY = 0 To GetBitmap.Height - 1
            If VBMath.Rnd > 0.975 Then
                VBMath.Randomize()
                TempWaveHeight = VBMath.Rnd * WaveHeight
                For IndexY = 0 To TempWaveHeight - 1
                    If (IndexY + PointY < GetBitmap.Height) Then
                        RndPixel = Math.Sin(Math.PI * IndexY / TempWaveHeight) * WaveWidth + VolatilityPixel * VBMath.Rnd
                        For PointX = 0 To GetBitmap.Width - 1
                            If (PointX + RndPixel >= GetBitmap.Width) Then MyColor = GetBitmap.GetPixel(PointX + RndPixel - GetBitmap.Width, PointY) Else MyColor = GetBitmap.GetPixel(PointX + RndPixel, PointY)
                            GetBitmap.SetPixel(PointX, PointY + IndexY, MyColor)
                        Next
                    End If
                Next

                PointY += TempWaveHeight
            End If
        Next

        Return GetBitmap
    End Function

    Private Function WindLine(ByVal BitmapRes As Bitmap, ByVal Pixel As Integer, ByVal WindRnd As Single) As Bitmap
        Dim GetBitmap As Bitmap = BitmapRes
        Dim RndPixel As Integer
        Dim MyColor As Color
        For Y As Long = 0 To GetBitmap.Height - 1
            VBMath.Randomize()
            RndPixel = VBMath.Rnd * Pixel
            If VBMath.Rnd > WindRnd Then
                If VBMath.Rnd > 0.5 Then
                    For X As Long = 0 To GetBitmap.Width - 1
                        If (X + RndPixel >= GetBitmap.Width) Then MyColor = GetBitmap.GetPixel(X + RndPixel - GetBitmap.Width, Y) Else MyColor = GetBitmap.GetPixel(X + RndPixel, Y)
                        GetBitmap.SetPixel(X, Y, MyColor)
                    Next
                Else
                    For X As Long = 0 To GetBitmap.Width - 1
                        If (X - RndPixel < 0) Then MyColor = GetBitmap.GetPixel(GetBitmap.Width - X - RndPixel, Y) Else MyColor = GetBitmap.GetPixel(X - RndPixel, Y)
                        GetBitmap.SetPixel(X, Y, MyColor)
                    Next
                End If
            End If
        Next
        Return GetBitmap
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static I As Integer = 0
        Static LastMax As Integer = 5
        If I = 0 Then
            If VBMath.Rnd > 0.5 Then
                PictureBox1.Image = WindLine(My.Resources.BitmapResource.Test_4, 50, VBMath.Rnd)
            Else
                PictureBox1.Image = WindWave(My.Resources.BitmapResource.Test_4, 30, 15, 5)
            End If
        ElseIf I = 5 Then
                PictureBox1.Image = My.Resources.BitmapResource.Test_4
        End If

        If I = LastMax Then
            LastMax = VBMath.Rnd * 10 + 2
            I = 0
        Else
            I += 1
        End If
    End Sub
End Class
