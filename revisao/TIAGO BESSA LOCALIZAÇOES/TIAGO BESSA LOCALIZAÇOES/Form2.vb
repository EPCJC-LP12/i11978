Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.localizacao' table. You can move, or remove it, as needed.
        Me.LocalizacaoTableAdapter.Fill(Me.Database1DataSet.localizacao)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class