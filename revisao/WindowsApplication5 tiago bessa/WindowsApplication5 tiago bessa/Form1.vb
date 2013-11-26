Public Class Form1

    Private Sub Marcas_BindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.Marcas_BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet1)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.modelos_' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Database1DataSet1.marcas_' table. You can move, or remove it, as needed.
        Me.Marcas_TableAdapter.Fill(Me.Database1DataSet1.marcas_)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.Modelos_TableAdapter.FillBy(Me.Database1DataSet1.modelos_)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


        Me.Modelos_TableAdapter.Insert(Me.TextBox1.Text, ComboBox1.SelectedValue)

    End Sub
End Class
