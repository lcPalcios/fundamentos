Public Class Form1
    Dim usuario As Integer
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Application.Exit()
    End Sub

 
    Private Sub pbPiedra_Click(sender As Object, e As EventArgs) Handles pbPiedra.Click
        usuario = 1
        validar()
    End Sub

    Private Sub pbPapel_Click(sender As Object, e As EventArgs) Handles pbPapel.Click
        usuario = 2
        validar()
    End Sub

    Private Sub pbTijera_Click(sender As Object, e As EventArgs) Handles pbTijera.Click
        usuario = 3
        validar()
    End Sub

    Sub validar()
        Dim rnd As New Random
        Dim opcionMaquina As Integer
        opcionMaquina = rnd.Next(1, 3)
        Dim img1, img2, img3 As String
        img1 = "C:\Users\LLC\Documents\Visual Studio 2012\Projects\PapelLic\PapelLic\Resources\1413826997_3D_Stone.png"
        img2 = "C:\Users\LLC\Documents\Visual Studio 2012\Projects\PapelLic\PapelLic\Resources\1413827028_FEZ-03-128.png"
        img3 = "C:\Users\LLC\Documents\Visual Studio 2012\Projects\PapelLic\PapelLic\Resources\1413827088_barber_scissors.png"
        If usuario = 1 Then ' Piedra
            pbUsuario.ImageLocation = img1
            If opcionMaquina = 1 Then
                pbMaquina.ImageLocation = img1
                lblResultado.Text = "Empatados"
            ElseIf opcionMaquina = 2 Then
                pbMaquina.ImageLocation = img2
                lblResultado.Text = "Ganador PC"
            Else
                pbMaquina.ImageLocation = img3
                lblResultado.Text = "Ganador Usuario"
            End If
        ElseIf usuario = 2 Then
            pbUsuario.ImageLocation = img2
            If opcionMaquina = 1 Then
                pbMaquina.ImageLocation = img1
                lblResultado.Text = "Ganador Usuario"
            ElseIf opcionMaquina = 2 Then
                pbMaquina.ImageLocation = img2
                lblResultado.Text = "Empatados"
            Else
                pbMaquina.ImageLocation = img3
                lblResultado.Text = "Ganador PC"
            End If
        ElseIf usuario = 3 Then
            pbUsuario.ImageLocation = img3
            If opcionMaquina = 1 Then
                pbMaquina.ImageLocation = img1
                lblResultado.Text = "Ganador PC"
            ElseIf opcionMaquina = 2 Then
                pbMaquina.ImageLocation = img2
                lblResultado.Text = "Ganador Usuario"
            Else
                pbMaquina.ImageLocation = img3
                lblResultado.Text = "Empatados"
            End If

        End If
    End Sub

End Class
