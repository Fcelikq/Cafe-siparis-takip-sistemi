<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class masa1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudCoffee = New System.Windows.Forms.NumericUpDown()
        Me.nudTea = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCloseAccount = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.pbTea = New System.Windows.Forms.PictureBox()
        Me.pbCoffee = New System.Windows.Forms.PictureBox()
        Me.TablesDataSet = New projectCafe.TablesDataSet()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1TableAdapter = New projectCafe.TablesDataSetTableAdapters.table1TableAdapter()
        Me.KimlikDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UrunDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TutarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.nudCoffee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCoffee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kahve"
        '
        'nudCoffee
        '
        Me.nudCoffee.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.nudCoffee.Location = New System.Drawing.Point(177, 57)
        Me.nudCoffee.Name = "nudCoffee"
        Me.nudCoffee.Size = New System.Drawing.Size(57, 44)
        Me.nudCoffee.TabIndex = 2
        '
        'nudTea
        '
        Me.nudTea.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.nudTea.Location = New System.Drawing.Point(423, 55)
        Me.nudTea.Name = "nudTea"
        Me.nudTea.Size = New System.Drawing.Size(57, 44)
        Me.nudTea.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(267, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cay"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KimlikDataGridViewTextBoxColumn, Me.UrunDataGridViewTextBoxColumn, Me.AdetDataGridViewTextBoxColumn, Me.TutarDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Table1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(670, 32)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(453, 230)
        Me.DataGridView1.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Location = New System.Drawing.Point(972, 268)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(151, 50)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Kaydet ve cik"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCloseAccount
        '
        Me.btnCloseAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseAccount.Location = New System.Drawing.Point(1138, 121)
        Me.btnCloseAccount.Name = "btnCloseAccount"
        Me.btnCloseAccount.Size = New System.Drawing.Size(143, 66)
        Me.btnCloseAccount.TabIndex = 5
        Me.btnCloseAccount.Text = "Hesabi Kapat"
        Me.btnCloseAccount.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Location = New System.Drawing.Point(670, 268)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(146, 50)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Siparis ver"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(1150, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Toplam"
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Location = New System.Drawing.Point(822, 268)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(144, 50)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "kaydi sil"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(1181, 71)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(30, 31)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.Text = "0"
        '
        'pbTea
        '
        Me.pbTea.Image = Global.projectCafe.My.Resources.Resources.kapak_cay_1_780x400
        Me.pbTea.Location = New System.Drawing.Point(267, 32)
        Me.pbTea.Name = "pbTea"
        Me.pbTea.Size = New System.Drawing.Size(150, 85)
        Me.pbTea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTea.TabIndex = 0
        Me.pbTea.TabStop = False
        '
        'pbCoffee
        '
        Me.pbCoffee.Image = Global.projectCafe.My.Resources.Resources.coffe
        Me.pbCoffee.Location = New System.Drawing.Point(21, 32)
        Me.pbCoffee.Name = "pbCoffee"
        Me.pbCoffee.Size = New System.Drawing.Size(150, 85)
        Me.pbCoffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCoffee.TabIndex = 0
        Me.pbCoffee.TabStop = False
        '
        'TablesDataSet
        '
        Me.TablesDataSet.DataSetName = "TablesDataSet"
        Me.TablesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "table1"
        Me.Table1BindingSource.DataSource = Me.TablesDataSet
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'KimlikDataGridViewTextBoxColumn
        '
        Me.KimlikDataGridViewTextBoxColumn.DataPropertyName = "Kimlik"
        Me.KimlikDataGridViewTextBoxColumn.HeaderText = "Kimlik"
        Me.KimlikDataGridViewTextBoxColumn.Name = "KimlikDataGridViewTextBoxColumn"
        Me.KimlikDataGridViewTextBoxColumn.ReadOnly = True
        Me.KimlikDataGridViewTextBoxColumn.Visible = False
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
        'TutarDataGridViewTextBoxColumn
        '
        Me.TutarDataGridViewTextBoxColumn.DataPropertyName = "Tutar"
        Me.TutarDataGridViewTextBoxColumn.HeaderText = "Tutar"
        Me.TutarDataGridViewTextBoxColumn.Name = "TutarDataGridViewTextBoxColumn"
        Me.TutarDataGridViewTextBoxColumn.ReadOnly = True
        '
        'masa1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(1288, 579)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCloseAccount)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.nudTea)
        Me.Controls.Add(Me.nudCoffee)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbTea)
        Me.Controls.Add(Me.pbCoffee)
        Me.Name = "masa1"
        Me.Text = "masa1"
        CType(Me.nudCoffee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCoffee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbCoffee As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents nudCoffee As NumericUpDown
    Friend WithEvents pbTea As PictureBox
    Friend WithEvents nudTea As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCloseAccount As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents TablesDataSet As TablesDataSet
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As TablesDataSetTableAdapters.table1TableAdapter
    Friend WithEvents KimlikDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UrunDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TutarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
