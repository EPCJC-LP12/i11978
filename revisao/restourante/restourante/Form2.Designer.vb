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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Database1DataSet = New WindowsApplication1.Database1DataSet()
        Me.Database1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RestauranteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Restaurante_TableAdapter = New WindowsApplication1.Database1DataSetTableAdapters.restaurante_TableAdapter()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.RestauranteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClassificaçãoTableAdapter = New WindowsApplication1.Database1DataSetTableAdapters.classificaçãoTableAdapter()
        Me.RestauranteBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestauranteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestauranteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestauranteBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.RestauranteBindingSource
        Me.ListBox1.DisplayMember = "nome "
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 63)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.ValueMember = "id "
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
        'RestauranteBindingSource
        '
        Me.RestauranteBindingSource.DataMember = "restaurante "
        Me.RestauranteBindingSource.DataSource = Me.Database1DataSetBindingSource1
        '
        'Restaurante_TableAdapter
        '
        Me.Restaurante_TableAdapter.ClearBeforeFill = True
        '
        'ListBox2
        '
        Me.ListBox2.DataSource = Me.RestauranteBindingSource2
        Me.ListBox2.DisplayMember = "classificacao"
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(152, 63)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 95)
        Me.ListBox2.TabIndex = 1
        Me.ListBox2.ValueMember = "id_classificacao"
        '
        'RestauranteBindingSource1
        '
        Me.RestauranteBindingSource1.DataMember = "restaurante "
        Me.RestauranteBindingSource1.DataSource = Me.RestauranteBindingSource
        '
        'ClassificaçãoTableAdapter
        '
        Me.ClassificaçãoTableAdapter.ClearBeforeFill = True
        '
        'RestauranteBindingSource2
        '
        Me.RestauranteBindingSource2.DataMember = "restaurante "
        Me.RestauranteBindingSource2.DataSource = Me.RestauranteBindingSource
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestauranteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestauranteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestauranteBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Database1DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Database1DataSet As WindowsApplication1.Database1DataSet
    Friend WithEvents Database1DataSetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents RestauranteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Restaurante_TableAdapter As WindowsApplication1.Database1DataSetTableAdapters.restaurante_TableAdapter
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents RestauranteBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ClassificaçãoTableAdapter As WindowsApplication1.Database1DataSetTableAdapters.classificaçãoTableAdapter
    Friend WithEvents RestauranteBindingSource2 As System.Windows.Forms.BindingSource
End Class
