<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class genelTablo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TablesDataSet = New projectCafe.TablesDataSet()
        Me.DailyTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DailyTableTableAdapter = New projectCafe.TablesDataSetTableAdapters.dailyTableTableAdapter()
        Me.KimlikDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MasaNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UrunDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarihDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TutarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DailyTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KimlikDataGridViewTextBoxColumn, Me.MasaNoDataGridViewTextBoxColumn, Me.UrunDataGridViewTextBoxColumn, Me.AdetDataGridViewTextBoxColumn, Me.TarihDataGridViewTextBoxColumn, Me.TutarDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DailyTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 56)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(695, 382)
        Me.DataGridView1.TabIndex = 0
        '
        'TablesDataSet
        '
        Me.TablesDataSet.DataSetName = "TablesDataSet"
        Me.TablesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DailyTableBindingSource
        '
        Me.DailyTableBindingSource.DataMember = "dailyTable"
        Me.DailyTableBindingSource.DataSource = Me.TablesDataSet
        '
        'DailyTableTableAdapter
        '
        Me.DailyTableTableAdapter.ClearBeforeFill = True
        '
        'KimlikDataGridViewTextBoxColumn
        '
        Me.KimlikDataGridViewTextBoxColumn.DataPropertyName = "Kimlik"
        Me.KimlikDataGridViewTextBoxColumn.HeaderText = "Kimlik"
        Me.KimlikDataGridViewTextBoxColumn.Name = "KimlikDataGridViewTextBoxColumn"
        Me.KimlikDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MasaNoDataGridViewTextBoxColumn
        '
        Me.MasaNoDataGridViewTextBoxColumn.DataPropertyName = "Masa_No"
        Me.MasaNoDataGridViewTextBoxColumn.HeaderText = "Masa_No"
        Me.MasaNoDataGridViewTextBoxColumn.Name = "MasaNoDataGridViewTextBoxColumn"
        Me.MasaNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UrunDataGridViewTextBoxColumn
        '
        Me.UrunDataGridViewTextBoxColumn.DataPropertyName = "Urun"
        Me.UrunDataGridViewTextBoxColumn.HeaderText = "Urun"
        Me.UrunDataGridViewTextBoxColumn.Name = "UrunDataGridViewTextBoxColumn"
        Me.UrunDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdetDataGridViewTextBoxColumn
        '
        Me.AdetDataGridViewTextBoxColumn.DataPropertyName = "Adet"
        Me.AdetDataGridViewTextBoxColumn.HeaderText = "Adet"
        Me.AdetDataGridViewTextBoxColumn.Name = "AdetDataGridViewTextBoxColumn"
        Me.AdetDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TarihDataGridViewTextBoxColumn
        '
        Me.TarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih"
        Me.TarihDataGridViewTextBoxColumn.HeaderText = "Tarih"
        Me.TarihDataGridViewTextBoxColumn.Name = "TarihDataGridViewTextBoxColumn"
        Me.TarihDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TutarDataGridViewTextBoxColumn
        '
        Me.TutarDataGridViewTextBoxColumn.DataPropertyName = "Tutar"
        Me.TutarDataGridViewTextBoxColumn.HeaderText = "Tutar"
        Me.TutarDataGridViewTextBoxColumn.Name = "TutarDataGridViewTextBoxColumn"
        Me.TutarDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(713, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Geri"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'genelTablo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "genelTablo"
        Me.Text = "Genel Tablo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DailyTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TablesDataSet As TablesDataSet
    Friend WithEvents DailyTableBindingSource As BindingSource
    Friend WithEvents DailyTableTableAdapter As TablesDataSetTableAdapters.dailyTableTableAdapter
    Friend WithEvents KimlikDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MasaNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UrunDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TarihDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TutarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
