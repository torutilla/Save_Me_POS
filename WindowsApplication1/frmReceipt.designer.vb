<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceipt
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
        Me.BtPrint = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TblitemtransactBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbposDataSet = New WindowsApplication1.dbposDataSet()
        Me.TblitemtransactTableAdapter = New WindowsApplication1.dbposDataSetTableAdapters.tblitemtransactTableAdapter()
        Me.QTYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTime1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemtransactBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbposDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtPrint
        '
        Me.BtPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtPrint.FlatAppearance.BorderSize = 0
        Me.BtPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtPrint.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtPrint.ForeColor = System.Drawing.Color.White
        Me.BtPrint.Location = New System.Drawing.Point(234, 344)
        Me.BtPrint.Name = "BtPrint"
        Me.BtPrint.Size = New System.Drawing.Size(157, 31)
        Me.BtPrint.TabIndex = 0
        Me.BtPrint.Text = "PRINT"
        Me.BtPrint.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.QTYDataGridViewTextBoxColumn, Me.ITEMNAMEDataGridViewTextBoxColumn, Me.TOTALPRICEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblitemtransactBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 147)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(597, 172)
        Me.DataGridView1.TabIndex = 1
        '
        'TblitemtransactBindingSource
        '
        Me.TblitemtransactBindingSource.DataMember = "tblitemtransact"
        Me.TblitemtransactBindingSource.DataSource = Me.DbposDataSet
        '
        'DbposDataSet
        '
        Me.DbposDataSet.DataSetName = "dbposDataSet"
        Me.DbposDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblitemtransactTableAdapter
        '
        Me.TblitemtransactTableAdapter.ClearBeforeFill = True
        '
        'QTYDataGridViewTextBoxColumn
        '
        Me.QTYDataGridViewTextBoxColumn.DataPropertyName = "QTY"
        Me.QTYDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QTYDataGridViewTextBoxColumn.Name = "QTYDataGridViewTextBoxColumn"
        '
        'ITEMNAMEDataGridViewTextBoxColumn
        '
        Me.ITEMNAMEDataGridViewTextBoxColumn.DataPropertyName = "ITEMNAME"
        Me.ITEMNAMEDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.ITEMNAMEDataGridViewTextBoxColumn.Name = "ITEMNAMEDataGridViewTextBoxColumn"
        '
        'TOTALPRICEDataGridViewTextBoxColumn
        '
        Me.TOTALPRICEDataGridViewTextBoxColumn.DataPropertyName = "TOTALPRICE"
        Me.TOTALPRICEDataGridViewTextBoxColumn.HeaderText = "Total Price"
        Me.TOTALPRICEDataGridViewTextBoxColumn.Name = "TOTALPRICEDataGridViewTextBoxColumn"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-4, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(636, 88)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(199, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RECEIPT CONFIRMATION"
        '
        'DateTime1
        '
        Me.DateTime1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTime1.Location = New System.Drawing.Point(409, 113)
        Me.DateTime1.Name = "DateTime1"
        Me.DateTime1.Size = New System.Drawing.Size(200, 21)
        Me.DateTime1.TabIndex = 3
        Me.DateTime1.Value = New Date(2024, 1, 17, 23, 37, 3, 0)
        '
        'frmReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 410)
        Me.Controls.Add(Me.DateTime1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtPrint)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReceipt"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemtransactBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbposDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtPrint As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DbposDataSet As WindowsApplication1.dbposDataSet
    Friend WithEvents TblitemtransactBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblitemtransactTableAdapter As WindowsApplication1.dbposDataSetTableAdapters.tblitemtransactTableAdapter
    Friend WithEvents QTYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ITEMNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALPRICEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTime1 As System.Windows.Forms.DateTimePicker
End Class
