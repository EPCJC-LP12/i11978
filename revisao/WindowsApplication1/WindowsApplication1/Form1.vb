Public Class Form1


    Dim preco As Double
    Dim consumo As Double
    Dim distancia As Double


   

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        preco = CDbl(TextBox1.Text)
        consumo = CDbl(TextBox2.Text)
        distancia = CDbl(TextBox3.Text)

        Dim consumoTotal As Double = consumo * distancia / 100

        Dim custo As Double = consumoTotal * preco


        TextBox4.Text = consumoTotal
        TextBox5.Text = custo

    End Sub

    
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class
