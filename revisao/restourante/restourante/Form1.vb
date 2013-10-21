Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.critica_' table. You can move, or remove it, as needed.
        Me.Critica_TableAdapter.Fill(Me.Database1DataSet.critica_)
        'TODO: This line of code loads data into the 'Database1DataSet.classificação' table. You can move, or remove it, as needed.
        Me.ClassificaçãoTableAdapter.Fill(Me.Database1DataSet.classificação)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ClassificaçãoBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ClassificaçãoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClassificaçãoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub
End Class
