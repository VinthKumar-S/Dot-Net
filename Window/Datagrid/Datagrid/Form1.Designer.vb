<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DGDataSet = New Datagrid.DGDataSet
        Me.DC1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DC1TableAdapter = New Datagrid.DGDataSetTableAdapters.DC1TableAdapter
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DGDataSet1 = New Datagrid.DGDataSet1
        Me.DC1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DC1TableAdapter1 = New Datagrid.DGDataSet1TableAdapters.DC1TableAdapter
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DC1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DC1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.SnameDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DC1BindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(113, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(446, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'DGDataSet
        '
        Me.DGDataSet.DataSetName = "DGDataSet"
        Me.DGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DC1BindingSource
        '
        Me.DC1BindingSource.DataMember = "DC1"
        Me.DC1BindingSource.DataSource = Me.DGDataSet
        '
        'DC1TableAdapter
        '
        Me.DC1TableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'SnameDataGridViewTextBoxColumn
        '
        Me.SnameDataGridViewTextBoxColumn.DataPropertyName = "sname"
        Me.SnameDataGridViewTextBoxColumn.HeaderText = "sname"
        Me.SnameDataGridViewTextBoxColumn.Name = "SnameDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "class"
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        '
        'DGDataSet1
        '
        Me.DGDataSet1.DataSetName = "DGDataSet1"
        Me.DGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DC1BindingSource1
        '
        Me.DC1BindingSource1.DataMember = "DC1"
        Me.DC1BindingSource1.DataSource = Me.DGDataSet1
        '
        'DC1TableAdapter1
        '
        Me.DC1TableAdapter1.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 262)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DC1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DC1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DGDataSet As Datagrid.DGDataSet
    Friend WithEvents DC1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DC1TableAdapter As Datagrid.DGDataSetTableAdapters.DC1TableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGDataSet1 As Datagrid.DGDataSet1
    Friend WithEvents DC1BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DC1TableAdapter1 As Datagrid.DGDataSet1TableAdapters.DC1TableAdapter

End Class
