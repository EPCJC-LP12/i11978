<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Database1DataSet1 = New WindowsApplication1.Database1DataSet1()
        Me.Marcas_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Marcas_TableAdapter = New WindowsApplication1.Database1DataSet1TableAdapters.marcas_TableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Database1DataSet1TableAdapters.TableAdapterManager()
        Me.Modelos_TableAdapter = New WindowsApplication1.Database1DataSet1TableAdapters.modelos_TableAdapter()
        Me.Modelos_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Database1DataSet = New WindowsApplication1.Database1DataSet()
        Me.Database1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Marcas_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Modelos_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Database1DataSet1
        '
        Me.Database1DataSet1.DataSetName = "Database1DataSet1"
        Me.Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Marcas_BindingSource
        '
        Me.Marcas_BindingSource.DataMember = "marcas "
        Me.Marcas_BindingSource.DataSource = Me.Database1DataSet1
        '
        'Marcas_TableAdapter
        '
        Me.Marcas_TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.marcas_TableAdapter = Me.Marcas_TableAdapter
        Me.TableAdapterManager.modelos_TableAdapter = Me.Modelos_TableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Modelos_TableAdapter
        '
        Me.Modelos_TableAdapter.ClearBeforeFill = True
        '
        'Modelos_BindingSource
        '
        Me.Modelos_BindingSource.DataMember = "modelos "
        Me.Modelos_BindingSource.DataSource = Me.Database1DataSet1
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.Database1DataSet1
        Me.ComboBox1.DisplayMember = "marcas .marca "
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(150, 49)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(347, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Inserir "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Marcas "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(150, 98)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Modelo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 246)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Marcas_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Modelos_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet1 As WindowsApplication1.Database1DataSet1
    Friend WithEvents Marcas_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Marcas_TableAdapter As WindowsApplication1.Database1DataSet1TableAdapters.marcas_TableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Database1DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Modelos_TableAdapter As WindowsApplication1.Database1DataSet1TableAdapters.modelos_TableAdapter
    Friend WithEvents Modelos_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Database1DataSet As WindowsApplication1.Database1DataSet
    Friend WithEvents Database1DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
