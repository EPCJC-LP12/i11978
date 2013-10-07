Public Class Form1
    Dim numero1 As Double
    Dim numero2 As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        numero1 = CDbl(TextBox1.Text)
        numero2 = CDbl(TextBox2.Text)


        Dim numero_mais As Double = numero1 + numero2
        Dim numero_menos As Double = numero1 - numero2
        Dim numero_vezes As Double = numero1 * numero2
        Dim numero_dividir As Double = numero1 / numero2

        TextBox3.Text = numero_mais
        TextBox3.Text = numero_menos
        TextBox3.Text = numero_vezes
        TextBox3.Text = numero_dividir
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        numero1 = CDbl(TextBox1.Text)
        numero2 = CDbl(TextBox2.Text)


        Dim numero_mais As Double = numero1 + numero2
        Dim numero_menos As Double = numero1 - numero2
        Dim numero_vezes As Double = numero1 * numero2
        Dim numero_dividir As Double = numero1 / numero2


        TextBox3.Text = numero_menos
       
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        numero1 = CDbl(TextBox1.Text)
        numero2 = CDbl(TextBox2.Text)


        Dim numero_mais As Double = numero1 + numero2
        Dim numero_menos As Double = numero1 - numero2
        Dim numero_vezes As Double = numero1 * numero2
        Dim numero_dividir As Double = numero1 / numero2


        TextBox3.Text = numero_vezes

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        numero1 = CDbl(TextBox1.Text)
        numero2 = CDbl(TextBox2.Text)

        Dim numero_mais As Double = numero1 + numero2
        Dim numero_menos As Double = numero1 - numero2
        Dim numero_vezes As Double = numero1 * numero2
        Dim numero_dividir As Double = numero1 / numero2

        TextBox3.Text = numero_dividir
    End Sub
End Class
