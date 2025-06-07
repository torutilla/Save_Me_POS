<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accounts
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.lblPosition = New System.Windows.Forms.TextBox()
        Me.lblContact = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.TextBox()
        Me.tlPosition = New System.Windows.Forms.Label()
        Me.btnEditAcc = New System.Windows.Forms.Button()
        Me.tlContact = New System.Windows.Forms.Label()
        Me.tlAddress = New System.Windows.Forms.Label()
        Me.tlName = New System.Windows.Forms.Label()
        Me.btnDelAcc = New System.Windows.Forms.Button()
        Me.btnAddAcc = New System.Windows.Forms.Button()
        Me.cboxShow = New System.Windows.Forms.CheckBox()
        Me.lblEmail = New System.Windows.Forms.TextBox()
        Me.tlEmail = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.TextBox()
        Me.tlPassword = New System.Windows.Forms.Label()
        Me.tlUsername = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEdit2 = New System.Windows.Forms.Button()
        Me.TblemployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbposDataSet = New WindowsApplication1.dbposDataSet()
        Me.TblemployeeTableAdapter = New WindowsApplication1.dbposDataSetTableAdapters.tblemployeeTableAdapter()
        Me.btnAccRecover = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblemployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbposDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.pic1)
        Me.GroupBox3.Controls.Add(Me.lblPosition)
        Me.GroupBox3.Controls.Add(Me.lblContact)
        Me.GroupBox3.Controls.Add(Me.lblAddress)
        Me.GroupBox3.Controls.Add(Me.lblName)
        Me.GroupBox3.Controls.Add(Me.tlPosition)
        Me.GroupBox3.Controls.Add(Me.btnEditAcc)
        Me.GroupBox3.Controls.Add(Me.tlContact)
        Me.GroupBox3.Controls.Add(Me.tlAddress)
        Me.GroupBox3.Controls.Add(Me.tlName)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(103, 139)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(904, 196)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "My Profile"
        '
        'pic1
        '
        Me.pic1.Location = New System.Drawing.Point(16, 29)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(158, 148)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic1.TabIndex = 25
        Me.pic1.TabStop = False
        '
        'lblPosition
        '
        Me.lblPosition.Enabled = False
        Me.lblPosition.Location = New System.Drawing.Point(470, 143)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(241, 27)
        Me.lblPosition.TabIndex = 20
        '
        'lblContact
        '
        Me.lblContact.Enabled = False
        Me.lblContact.Location = New System.Drawing.Point(470, 74)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(241, 27)
        Me.lblContact.TabIndex = 19
        '
        'lblAddress
        '
        Me.lblAddress.Enabled = False
        Me.lblAddress.Location = New System.Drawing.Point(211, 143)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(228, 27)
        Me.lblAddress.TabIndex = 18
        '
        'lblName
        '
        Me.lblName.Enabled = False
        Me.lblName.Location = New System.Drawing.Point(211, 74)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(228, 27)
        Me.lblName.TabIndex = 17
        '
        'tlPosition
        '
        Me.tlPosition.AutoSize = True
        Me.tlPosition.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlPosition.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tlPosition.Location = New System.Drawing.Point(467, 114)
        Me.tlPosition.Name = "tlPosition"
        Me.tlPosition.Size = New System.Drawing.Size(60, 17)
        Me.tlPosition.TabIndex = 10
        Me.tlPosition.Text = "Position"
        '
        'btnEditAcc
        '
        Me.btnEditAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditAcc.FlatAppearance.BorderSize = 0
        Me.btnEditAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditAcc.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditAcc.ForeColor = System.Drawing.Color.White
        Me.btnEditAcc.Location = New System.Drawing.Point(759, 28)
        Me.btnEditAcc.Name = "btnEditAcc"
        Me.btnEditAcc.Size = New System.Drawing.Size(122, 31)
        Me.btnEditAcc.TabIndex = 8
        Me.btnEditAcc.Text = "Edit Profile"
        Me.btnEditAcc.UseVisualStyleBackColor = False
        '
        'tlContact
        '
        Me.tlContact.AutoSize = True
        Me.tlContact.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlContact.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tlContact.Location = New System.Drawing.Point(467, 42)
        Me.tlContact.Name = "tlContact"
        Me.tlContact.Size = New System.Drawing.Size(62, 17)
        Me.tlContact.TabIndex = 5
        Me.tlContact.Text = "Contact"
        '
        'tlAddress
        '
        Me.tlAddress.AutoSize = True
        Me.tlAddress.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlAddress.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tlAddress.Location = New System.Drawing.Point(208, 114)
        Me.tlAddress.Name = "tlAddress"
        Me.tlAddress.Size = New System.Drawing.Size(61, 17)
        Me.tlAddress.TabIndex = 3
        Me.tlAddress.Text = "Address"
        '
        'tlName
        '
        Me.tlName.AutoSize = True
        Me.tlName.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tlName.Location = New System.Drawing.Point(208, 40)
        Me.tlName.Name = "tlName"
        Me.tlName.Size = New System.Drawing.Size(50, 17)
        Me.tlName.TabIndex = 1
        Me.tlName.Text = "Name"
        '
        'btnDelAcc
        '
        Me.btnDelAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelAcc.FlatAppearance.BorderSize = 0
        Me.btnDelAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelAcc.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelAcc.ForeColor = System.Drawing.Color.White
        Me.btnDelAcc.Location = New System.Drawing.Point(103, 580)
        Me.btnDelAcc.Name = "btnDelAcc"
        Me.btnDelAcc.Size = New System.Drawing.Size(173, 28)
        Me.btnDelAcc.TabIndex = 9
        Me.btnDelAcc.Text = "Delete Account"
        Me.btnDelAcc.UseVisualStyleBackColor = False
        '
        'btnAddAcc
        '
        Me.btnAddAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddAcc.FlatAppearance.BorderSize = 0
        Me.btnAddAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAcc.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAcc.ForeColor = System.Drawing.Color.White
        Me.btnAddAcc.Location = New System.Drawing.Point(862, 103)
        Me.btnAddAcc.Name = "btnAddAcc"
        Me.btnAddAcc.Size = New System.Drawing.Size(145, 30)
        Me.btnAddAcc.TabIndex = 7
        Me.btnAddAcc.Text = "Add Account"
        Me.btnAddAcc.UseVisualStyleBackColor = False
        '
        'cboxShow
        '
        Me.cboxShow.AutoSize = True
        Me.cboxShow.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxShow.Location = New System.Drawing.Point(632, 109)
        Me.cboxShow.Name = "cboxShow"
        Me.cboxShow.Size = New System.Drawing.Size(55, 19)
        Me.cboxShow.TabIndex = 24
        Me.cboxShow.Text = "Show"
        Me.cboxShow.UseVisualStyleBackColor = True
        Me.cboxShow.Visible = False
        '
        'lblEmail
        '
        Me.lblEmail.Enabled = False
        Me.lblEmail.Location = New System.Drawing.Point(58, 143)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(243, 27)
        Me.lblEmail.TabIndex = 23
        '
        'tlEmail
        '
        Me.tlEmail.AutoSize = True
        Me.tlEmail.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlEmail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tlEmail.Location = New System.Drawing.Point(55, 109)
        Me.tlEmail.Name = "tlEmail"
        Me.tlEmail.Size = New System.Drawing.Size(46, 17)
        Me.tlEmail.TabIndex = 22
        Me.tlEmail.Text = "Email"
        '
        'lblUsername
        '
        Me.lblUsername.Enabled = False
        Me.lblUsername.Location = New System.Drawing.Point(58, 72)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(243, 27)
        Me.lblUsername.TabIndex = 21
        '
        'lblPassword
        '
        Me.lblPassword.Enabled = False
        Me.lblPassword.Location = New System.Drawing.Point(442, 72)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.lblPassword.Size = New System.Drawing.Size(245, 27)
        Me.lblPassword.TabIndex = 15
        '
        'tlPassword
        '
        Me.tlPassword.AutoSize = True
        Me.tlPassword.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlPassword.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tlPassword.Location = New System.Drawing.Point(439, 38)
        Me.tlPassword.Name = "tlPassword"
        Me.tlPassword.Size = New System.Drawing.Size(70, 17)
        Me.tlPassword.TabIndex = 14
        Me.tlPassword.Text = "Password"
        '
        'tlUsername
        '
        Me.tlUsername.AutoSize = True
        Me.tlUsername.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlUsername.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tlUsername.Location = New System.Drawing.Point(55, 41)
        Me.tlUsername.Name = "tlUsername"
        Me.tlUsername.Size = New System.Drawing.Size(76, 17)
        Me.tlUsername.TabIndex = 12
        Me.tlUsername.Text = "Username"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEdit2)
        Me.GroupBox1.Controls.Add(Me.tlUsername)
        Me.GroupBox1.Controls.Add(Me.cboxShow)
        Me.GroupBox1.Controls.Add(Me.lblPassword)
        Me.GroupBox1.Controls.Add(Me.tlPassword)
        Me.GroupBox1.Controls.Add(Me.lblEmail)
        Me.GroupBox1.Controls.Add(Me.lblUsername)
        Me.GroupBox1.Controls.Add(Me.tlEmail)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(103, 350)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(904, 202)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information and Security"
        '
        'btnEdit2
        '
        Me.btnEdit2.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEdit2.FlatAppearance.BorderSize = 0
        Me.btnEdit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit2.ForeColor = System.Drawing.Color.White
        Me.btnEdit2.Location = New System.Drawing.Point(759, 31)
        Me.btnEdit2.Name = "btnEdit2"
        Me.btnEdit2.Size = New System.Drawing.Size(122, 31)
        Me.btnEdit2.TabIndex = 26
        Me.btnEdit2.Text = "Edit Security"
        Me.btnEdit2.UseVisualStyleBackColor = False
        '
        'TblemployeeBindingSource
        '
        Me.TblemployeeBindingSource.DataMember = "tblemployee"
        Me.TblemployeeBindingSource.DataSource = Me.DbposDataSet
        '
        'DbposDataSet
        '
        Me.DbposDataSet.DataSetName = "dbposDataSet"
        Me.DbposDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblemployeeTableAdapter
        '
        Me.TblemployeeTableAdapter.ClearBeforeFill = True
        '
        'btnAccRecover
        '
        Me.btnAccRecover.BackColor = System.Drawing.Color.DimGray
        Me.btnAccRecover.FlatAppearance.BorderSize = 0
        Me.btnAccRecover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccRecover.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccRecover.ForeColor = System.Drawing.Color.White
        Me.btnAccRecover.Location = New System.Drawing.Point(834, 580)
        Me.btnAccRecover.Name = "btnAccRecover"
        Me.btnAccRecover.Size = New System.Drawing.Size(173, 28)
        Me.btnAccRecover.TabIndex = 26
        Me.btnAccRecover.Text = "Account Recovery"
        Me.btnAccRecover.UseVisualStyleBackColor = False
        '
        'Accounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 649)
        Me.Controls.Add(Me.btnAccRecover)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnDelAcc)
        Me.Controls.Add(Me.btnAddAcc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Accounts"
        Me.Text = "Accounts"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TblemployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbposDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tlAddress As System.Windows.Forms.Label
    Friend WithEvents tlName As System.Windows.Forms.Label
    Friend WithEvents tlContact As System.Windows.Forms.Label
    Friend WithEvents DbposDataSet As WindowsApplication1.dbposDataSet
    Friend WithEvents TblemployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblemployeeTableAdapter As WindowsApplication1.dbposDataSetTableAdapters.tblemployeeTableAdapter
    Friend WithEvents btnDelAcc As System.Windows.Forms.Button
    Friend WithEvents btnEditAcc As System.Windows.Forms.Button
    Friend WithEvents btnAddAcc As System.Windows.Forms.Button
    Friend WithEvents tlPosition As System.Windows.Forms.Label
    Friend WithEvents tlPassword As System.Windows.Forms.Label
    Friend WithEvents tlUsername As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPosition As System.Windows.Forms.TextBox
    Friend WithEvents lblContact As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.TextBox
    Friend WithEvents tlEmail As System.Windows.Forms.Label
    Friend WithEvents cboxShow As System.Windows.Forms.CheckBox
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEdit2 As System.Windows.Forms.Button
    Friend WithEvents btnAccRecover As System.Windows.Forms.Button
End Class
