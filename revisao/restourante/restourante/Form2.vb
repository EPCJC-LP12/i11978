Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.classificação' table. You can move, or remove it, as needed.
        Me.ClassificaçãoTableAdapter.Fill(Me.Database1DataSet.classificação)
        'TODO: This line of code loads data into the 'Database1DataSet.restaurante_' table. You can move, or remove it, as needed.
        Me.Restaurante_TableAdapter.Fill(Me.Database1DataSet.restaurante_)

    End Sub
End Class