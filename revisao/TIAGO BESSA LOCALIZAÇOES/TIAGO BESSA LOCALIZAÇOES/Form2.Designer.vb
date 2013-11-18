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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Database1DataSet = New TIAGO_BESSA_LOCALIZAÇOES.Database1DataSet()
        Me.Database1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSetBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalizacaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalizacaoTableAdapter = New TIAGO_BESSA_LOCALIZAÇOES.Database1DataSetTableAdapters.localizacaoTableAdapter()
        Me.TableAdapterManager = New TIAGO_BESSA_LOCALIZAÇOES.Database1DataSetTableAdapters.TableAdapterManager()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LatitudeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LongitudeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AltitudeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdutilizadoresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSetBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalizacaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.DataDataGridViewTextBoxColumn, Me.LatitudeDataGridViewTextBoxColumn, Me.LongitudeDataGridViewTextBoxColumn, Me.AltitudeDataGridViewTextBoxColumn, Me.IdutilizadoresDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LocalizacaoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(635, 78)
        Me.DataGridView1.TabIndex = 0
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
        'Database1DataSetBindingSource2
        '
        Me.Database1DataSetBindingSource2.DataSource = Me.Database1DataSet
        Me.Database1DataSetBindingSource2.Position = 0
        '
        'LocalizacaoBindingSource
        '
        Me.LocalizacaoBindingSource.DataMember = "localizacao"
        Me.LocalizacaoBindingSource.DataSource = Me.Database1DataSet
        '
        'LocalizacaoTableAdapter
        '
        Me.LocalizacaoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.localizacaoTableAdapter = Me.LocalizacaoTableAdapter
        Me.TableAdapterManager.UpdateOrder = TIAGO_BESSA_LOCALIZAÇOES.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UTILIZADORES_TableAdapter = Nothing
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "data "
        Me.DataDataGridViewTextBoxColumn.HeaderText = "data "
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        '
        'LatitudeDataGridViewTextBoxColumn
        '
        Me.LatitudeDataGridViewTextBoxColumn.DataPropertyName = "latitude "
        Me.LatitudeDataGridViewTextBoxColumn.HeaderText = "latitude "
        Me.LatitudeDataGridViewTextBoxColumn.Name = "LatitudeDataGridViewTextBoxColumn"
        '
        'LongitudeDataGridViewTextBoxColumn
        '
        Me.LongitudeDataGridViewTextBoxColumn.DataPropertyName = "longitude"
        Me.LongitudeDataGridViewTextBoxColumn.HeaderText = "longitude"
        Me.LongitudeDataGridViewTextBoxColumn.Name = "LongitudeDataGridViewTextBoxColumn"
        '
        'AltitudeDataGridViewTextBoxColumn
        '
        Me.AltitudeDataGridViewTextBoxColumn.DataPropertyName = "altitude "
        Me.AltitudeDataGridViewTextBoxColumn.HeaderText = "altitude "
        Me.AltitudeDataGridViewTextBoxColumn.Name = "AltitudeDataGridViewTextBoxColumn"
        '
        'IdutilizadoresDataGridViewTextBoxColumn
        '
        Me.IdutilizadoresDataGridViewTextBoxColumn.DataPropertyName = "id_utilizadores "
        Me.IdutilizadoresDataGridViewTextBoxColumn.HeaderText = "id_utilizadores "
        Me.IdutilizadoresDataGridViewTextBoxColumn.Name = "IdutilizadoresDataGridViewTextBoxColumn"
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.LocalizacaoBindingSource
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(132, 154)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 1
        Me.ListBox1.ValueMember = "UTILIZADORES .nome "
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 261)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSetBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalizacaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Database1DataSetBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Database1DataSet As TIAGO_BESSA_LOCALIZAÇOES.Database1DataSet
    Friend WithEvents Database1DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Database1DataSetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents LocalizacaoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocalizacaoTableAdapter As TIAGO_BESSA_LOCALIZAÇOES.Database1DataSetTableAdapters.localizacaoTableAdapter
    Friend WithEvents TableAdapterManager As TIAGO_BESSA_LOCALIZAÇOES.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LatitudeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LongitudeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AltitudeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdutilizadoresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
