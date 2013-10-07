Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim GERADOR As New Random
        Dim NUMERO As Integer = GERADOR.Next(1, 9)

        TextBox1.Text = NUMERO

        If NUMERO = (7) Then

            Me.Label1.Text = "Parabens acertou"
            Me.Label1.Visible = True


        Else
            Me.Label1.Text = "TENTA OUTRA VEZ"
            Me.Label1.Visible = True

        End If



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label1.Visible = False

    End Sub
End Class
