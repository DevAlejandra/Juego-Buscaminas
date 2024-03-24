Public Class Form1
    Dim V(36) As Integer
    Dim I, N As Integer

    Sub REINICIAR()
        Dim OBJ As Control

        For Each OBJ In Me.Controls
            If TypeOf OBJ Is PictureBox Then
                Dim IMG As PictureBox
                OBJ.Tag = ""
                IMG = OBJ
                IMG.Image = Nothing
                IMG.Enabled = True
            End If
            I = 0
            N = 0
        Next
    End Sub

    Sub aleatorio()
        Randomize()
        Dim VAR, C As Integer
        VAR = 1
        While VAR > 0
            VAR = 0
            I = Math.Truncate(Rnd() * 36 + 1) 'genera un numero aletario en un rango de 1-36)
            For C = 0 To N
                If V(C) = I Then
                    VAR += 1
                End If
            Next
        End While
        V(N) = I
        N += 1
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub C11_Click(sender As Object, e As EventArgs) Handles C11.Click, C12.Click, C13.Click, C14.Click, C15.Click, C16.Click, C21.Click, C22.Click, C23.Click, C24.Click, C25.Click, C26.Click, C31.Click, C32.Click, C33.Click, C34.Click, C35.Click, C36.Click, C41.Click, C42.Click, C43.Click, C44.Click, C45.Click, C46.Click, C51.Click, C52.Click, C53.Click, C54.Click, C55.Click, C56.Click, C61.Click, C62.Click, C63.Click, C64.Click, C65.Click, C66.Click
        aleatorio()
        sender.tag = CStr(I)
        If I = 1 Or I = 2 Or I = 4 Or I = 5 Or I = 6 Then
            sender.image = Image.FromFile("C:\Users\LolaA\source\repos\Juego_Buscaminas\Juego_Buscaminas\Image\mina.png")
            MsgBox("MINA, PERDISTE", MsgBoxStyle.Critical, "DESACIERTO")
            Dim OBJ As Control
            For Each OBJ In Me.Controls
                If TypeOf OBJ Is PictureBox And OBJ.Tag = "" Then
                    aleatorio()
                    If I = 1 Or I = 2 Or I = 4 Or I = 5 Or I = 6 Then
                        Dim imagen As PictureBox
                        imagen = OBJ
                        imagen.Image = Image.FromFile("C:\Users\LolaA\source\repos\Juego_Buscaminas\Juego_Buscaminas\Image\mina.png")
                    End If
                    OBJ.Tag = CStr(I)
                End If
            Next

        Else
            sender.image = Image.FromFile("C:\Users\LolaA\source\repos\Juego_Buscaminas\Juego_Buscaminas\Image\carta1.png")
            If N = 30 Then
                MsgBox("BIEN HECHO, GANASTE!!!", MsgBoxStyle.Information, "ACIERTO")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        REINICIAR()
    End Sub
End Class
