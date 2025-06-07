<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindItems
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TblitemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ITEMNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMCATEGORYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SIZEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNITPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ONHANDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARKUPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENCODEDBYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DISPLAYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DISPLAYMENUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMGDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.BARCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TblitemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(461, 417)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TblitemBindingSource
        '
        Me.TblitemBindingSource.DataMember = "tblitem"
        Me.TblitemBindingSource.DataSource = Me.DbposDataSet
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEMNODataGridViewTextBoxColumn, Me.ITEMCODEDataGridViewTextBoxColumn, Me.ITEMNAMEDataGridViewTextBoxColumn, Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn, Me.ITEMCATEGORYDataGridViewTextBoxColumn, Me.SIZEDataGridViewTextBoxColumn, Me.QTYDataGridViewTextBoxColumn, Me.UNITPRICEDataGridViewTextBoxColumn, Me.ONHANDDataGridViewTextBoxColumn, Me.DATEINDataGridViewTextBoxColumn, Me.MARKUPDataGridViewTextBoxColumn, Me.ENCODEDBYDataGridViewTextBoxColumn, Me.EMPIDDataGridViewTextBoxColumn, Me.DISPLAYDataGridViewTextBoxColumn, Me.DISPLAYMENUDataGridViewTextBoxColumn, Me.IMGDataGridViewImageColumn, Me.BARCODEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblitemBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(163, 105)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(373, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'ITEMNODataGridViewTextBoxColumn
        '
        Me.ITEMNODataGridViewTextBoxColumn.DataPropertyName = "ITEMNO"
        Me.ITEMNODataGridViewTextBoxColumn.HeaderText = "ITEMNO"
        Me.ITEMNODataGridViewTextBoxColumn.Name = "ITEMNODataGridViewTextBoxColumn"
        '
        'ITEMCODEDataGridViewTextBoxColumn
        '
        Me.ITEMCODEDataGridViewTextBoxColumn.DataPropertyName = "ITEMCODE"
        Me.ITEMCODEDataGridViewTextBoxColumn.HeaderText = "ITEMCODE"
        Me.ITEMCODEDataGridViewTextBoxColumn.Name = "ITEMCODEDataGridViewTextBoxColumn"
        '
        'ITEMNAMEDataGridViewTextBoxColumn
        '
        Me.ITEMNAMEDataGridViewTextBoxColumn.DataPropertyName = "ITEMNAME"
        Me.ITEMNAMEDataGridViewTextBoxColumn.HeaderText = "ITEMNAME"
        Me.ITEMNAMEDataGridViewTextBoxColumn.Name = "ITEMNAMEDataGridViewTextBoxColumn"
        '
        'ITEMDESCRIPTIONDataGridViewTextBoxColumn
        '
        Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "ITEMDESCRIPTION"
        Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "ITEMDESCRIPTION"
        Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn.Name = "ITEMDESCRIPTIONDataGridViewTextBoxColumn"
        '
        'ITEMCATEGORYDataGridViewTextBoxColumn
        '
        Me.ITEMCATEGORYDataGridViewTextBoxColumn.DataPropertyName = "ITEMCATEGORY"
        Me.ITEMCATEGORYDataGridViewTextBoxColumn.HeaderText = "ITEMCATEGORY"
        Me.ITEMCATEGORYDataGridViewTextBoxColumn.Name = "ITEMCATEGORYDataGridViewTextBoxColumn"
        '
        'SIZEDataGridViewTextBoxColumn
        '
        Me.SIZEDataGridViewTextBoxColumn.DataPropertyName = "SIZE"
        Me.SIZEDataGridViewTextBoxColumn.HeaderText = "SIZE"
        Me.SIZEDataGridViewTextBoxColumn.Name = "SIZEDataGridViewTextBoxColumn"
        '
        'QTYDataGridViewTextBoxColumn
        '
        Me.QTYDataGridViewTextBoxColumn.DataPropertyName = "QTY"
        Me.QTYDataGridViewTextBoxColumn.HeaderText = "QTY"
        Me.QTYDataGridViewTextBoxColumn.Name = "QTYDataGridViewTextBoxColumn"
        '
        'UNITPRICEDataGridViewTextBoxColumn
        '
        Me.UNITPRICEDataGridViewTextBoxColumn.DataPropertyName = "UNITPRICE"
        Me.UNITPRICEDataGridViewTextBoxColumn.HeaderText = "UNITPRICE"
        Me.UNITPRICEDataGridViewTextBoxColumn.Name = "UNITPRICEDataGridViewTextBoxColumn"
        '
        'ONHANDDataGridViewTextBoxColumn
        '
        Me.ONHANDDataGridViewTextBoxColumn.DataPropertyName = "ONHAND"
        Me.ONHANDDataGridViewTextBoxColumn.HeaderText = "ONHAND"
        Me.ONHANDDataGridViewTextBoxColumn.Name = "ONHANDDataGridViewTextBoxColumn"
        '
        'DATEINDataGridViewTextBoxColumn
        '
        Me.DATEINDataGridViewTextBoxColumn.DataPropertyName = "DATEIN"
        Me.DATEINDataGridViewTextBoxColumn.HeaderText = "DATEIN"
        Me.DATEINDataGridViewTextBoxColumn.Name = "DATEINDataGridViewTextBoxColumn"
        '
        'MARKUPDataGridViewTextBoxColumn
        '
        Me.MARKUPDataGridViewTextBoxColumn.DataPropertyName = "MARKUP"
        Me.MARKUPDataGridViewTextBoxColumn.HeaderText = "MARKUP"
        Me.MARKUPDataGridViewTextBoxColumn.Name = "MARKUPDataGridViewTextBoxColumn"
        '
        'ENCODEDBYDataGridViewTextBoxColumn
        '
        Me.ENCODEDBYDataGridViewTextBoxColumn.DataPropertyName = "ENCODEDBY"
        Me.ENCODEDBYDataGridViewTextBoxColumn.HeaderText = "ENCODEDBY"
        Me.ENCODEDBYDataGridViewTextBoxColumn.Name = "ENCODEDBYDataGridViewTextBoxColumn"
        '
        'EMPIDDataGridViewTextBoxColumn
        '
        Me.EMPIDDataGridViewTextBoxColumn.DataPropertyName = "EMPID"
        Me.EMPIDDataGridViewTextBoxColumn.HeaderText = "EMPID"
        Me.EMPIDDataGridViewTextBoxColumn.Name = "EMPIDDataGridViewTextBoxColumn"
        '
        'DISPLAYDataGridViewTextBoxColumn
        '
        Me.DISPLAYDataGridViewTextBoxColumn.DataPropertyName = "DISPLAY"
        Me.DISPLAYDataGridViewTextBoxColumn.HeaderText = "DISPLAY"
        Me.DISPLAYDataGridViewTextBoxColumn.Name = "DISPLAYDataGridViewTextBoxColumn"
        '
        'DISPLAYMENUDataGridViewTextBoxColumn
        '
        Me.DISPLAYMENUDataGridViewTextBoxColumn.DataPropertyName = "DISPLAYMENU"
        Me.DISPLAYMENUDataGridViewTextBoxColumn.HeaderText = "DISPLAYMENU"
        Me.DISPLAYMENUDataGridViewTextBoxColumn.Name = "DISPLAYMENUDataGridViewTextBoxColumn"
        '
        'IMGDataGridViewImageColumn
        '
        Me.IMGDataGridViewImageColumn.DataPropertyName = "IMG"
        Me.IMGDataGridViewImageColumn.HeaderText = "IMG"
        Me.IMGDataGridViewImageColumn.Name = "IMGDataGridViewImageColumn"
        '
        'BARCODEDataGridViewTextBoxColumn
        '
        Me.BARCODEDataGridViewTextBoxColumn.DataPropertyName = "BARCODE"
        Me.BARCODEDataGridViewTextBoxColumn.HeaderText = "BARCODE"
        Me.BARCODEDataGridViewTextBoxColumn.Name = "BARCODEDataGridViewTextBoxColumn"
        '
        'frmFindItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 452)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmFindItems"
        Me.Text = "frmFindItems"
        CType(Me.TblitemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TblitemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ITEMNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ITEMCODEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ITEMNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ITEMDESCRIPTIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ITEMCATEGORYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SIZEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UNITPRICEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ONHANDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATEINDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARKUPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ENCODEDBYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DISPLAYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DISPLAYMENUDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMGDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents BARCODEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DbposDataSet As WindowsApplication1.dbposDataSet
    Friend WithEvents TblitemTableAdapter As WindowsApplication1.dbposDataSetTableAdapters.tblitemTableAdapter
End Class
