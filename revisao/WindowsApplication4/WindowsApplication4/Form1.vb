Public Class Form1

    Private Sub Utilizadores_BindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles Utilizadores_BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Utilizadores_BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.utilizadores_' table. You can move, or remove it, as needed.
        Me.Utilizadores_TableAdapter.Fill(Me.Database1DataSet.utilizadores_)

    End Sub
End Class
