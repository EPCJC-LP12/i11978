Public Class Form1

    Private Sub UTILIZADORES_BindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles UTILIZADORES_BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UTILIZADORES_BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.UTILIZADORES_' table. You can move, or remove it, as needed.
        Me.UTILIZADORES_TableAdapter.Fill(Me.Database1DataSet.UTILIZADORES_)

    End Sub
End Class
