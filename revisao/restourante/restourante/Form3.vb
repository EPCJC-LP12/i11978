Public Class Form3

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.restaurante_' table. You can move, or remove it, as needed.
        Me.Restaurante_TableAdapter.Fill(Me.Database1DataSet.restaurante_)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Restaurante_TableAdapter.FillByNomeContacto(Me.Database1DataSet.restaurante_, Me.TextBox1.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Me.Restaurante_TableAdapter.FillByNomeContacto(Me.Database1DataSet.restaurante_, Me.TextBox1.Text)
    End Sub
End Class