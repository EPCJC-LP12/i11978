<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Database1DataSet = New WindowsApplication1.Database1DataSet()
        Me.Database1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet2 = New WindowsApplication1.Database1DataSet2()
        Me.ClasificacaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClasificacaoTableAdapter = New WindowsApplication1.Database1DataSet2TableAdapters.clasificacaoTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Database1DataSet2TableAdapters.TableAdapterManager()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClasificacaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Database1DataSetBindingSource
        '
        Me.Database1DataSetBindingSource.DataSource = Me.Database1DataSet
        Me.Database1DataSetBindingSource.Position = 0
        '
        'Database1DataSetBindingSource1
        '
        Me.Database1DataSetBindingSource1.DataSource = Me.Database1DataSet
        Me.Database1DataSetBindingSource1.Position = 0
        '
        'Database1DataSet2
        '
        Me.Database1DataSet2.DataSetName = "Database1DataSet2"
        Me.Database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClasificacaoBindingSource
        '
        Me.ClasificacaoBindingSource.DataMember = "clasificacao"
        Me.ClasificacaoBindingSource.DataSource = Me.Database1DataSet2
        '
        'ClasificacaoTableAdapter
        '
        Me.ClasificacaoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clasificacaoTableAdapter = Me.ClasificacaoTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Database1DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.Database1DataSet2
        Me.ComboBox1.DisplayMember = "clasificacao.clasificacao"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(98, 94)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(209, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "clasificacao.id"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 310)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClasificacaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Database1DataSet As WindowsApplication1.Database1DataSet
    Friend WithEvents Database1DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Database1DataSetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Database1DataSet2 As WindowsApplication1.Database1DataSet2
    Friend WithEvents ClasificacaoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClasificacaoTableAdapter As WindowsApplication1.Database1DataSet2TableAdapters.clasificacaoTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Database1DataSet2TableAdapters.TableAdapterManager
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
