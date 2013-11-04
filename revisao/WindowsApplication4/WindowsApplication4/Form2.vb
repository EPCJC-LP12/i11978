Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet2.clasificacao' table. You can move, or remove it, as needed.
        Me.ClasificacaoTableAdapter.Fill(Me.Database1DataSet2.clasificacao)

    End Sub
End Class