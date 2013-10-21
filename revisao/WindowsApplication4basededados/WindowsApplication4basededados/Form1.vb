Public Class Form1



    Private Sub PilotosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.PilotosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub PilotosBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.PilotosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub PilotosBindingNavigatorSaveItem_Click_2(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.PilotosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub


    Private Sub PilotosBindingNavigatorSaveItem_Click_3(sender As System.Object, e As System.EventArgs) Handles PilotosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PilotosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.pilotos' table. You can move, or remove it, as needed.
        Me.PilotosTableAdapter.Fill(Me.Database1DataSet.pilotos)

    End Sub
End Class
