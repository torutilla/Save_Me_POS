<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addUser
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
        Me.tlAdd = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.TextBox()
        Me.tlName = New System.Windows.Forms.Label()
        Me.tlAddress = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblAddress = New System.Windows.Forms.TextBox()
        Me.tlContact = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.TextBox()
        Me.tlEmail = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.TextBox()
        Me.tlUsername = New System.Windows.Forms.Label()
        Me.tlPosition = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.TextBox()
        Me.tlPassword = New System.Windows.Forms.Label()
        Me.cboxShow = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'tlAdd
        '
        Me.tlAdd.AutoSize = True
        Me.tlAdd.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.tlAdd.Location = New System.Drawing.Point(192, 32)
        Me.tlAdd.Name = "tlAdd"
        Me.tlAdd.Size = New System.Drawing.Size(124, 28)
        Me.tlAdd.TabIndex = 0
        Me.tlAdd.Text = "ADD USER"
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(43, 115)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(184, 23)
        Me.lblName.TabIndex = 1
        '
        'tlName
        '
        Me.tlName.AutoSize = True
        Me.tlName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlName.ForeColor = System.Drawing.Color.White
        Me.tlName.Location = New System.Drawing.Point(40, 89)
        Me.tlName.Name = "tlName"
        Me.tlName.Size = New System.Drawing.Size(48, 17)
        Me.tlName.TabIndex = 2
        Me.tlName.Text = "Name"
        '
        'tlAddress
        '
        Me.tlAddress.AutoSize = True
        Me.tlAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlAddress.ForeColor = System.Drawing.Color.White
        Me.tlAddress.Location = New System.Drawing.Point(40, 155)
        Me.tlAddress.Name = "tlAddress"
        Me.tlAddress.Size = New System.Drawing.Size(57, 17)
        Me.tlAddress.TabIndex = 3
        Me.tlAddress.Text = "Address"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(160, 400)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(99, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkRed
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(265, 400)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblAddress
        '
        Me.lblAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(43, 184)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(184, 23)
        Me.lblAddress.TabIndex = 6
        '
        'tlContact
        '
        Me.tlContact.AutoSize = True
        Me.tlContact.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlContact.ForeColor = System.Drawing.Color.White
        Me.tlContact.Location = New System.Drawing.Point(40, 231)
        Me.tlContact.Name = "tlContact"
        Me.tlContact.Size = New System.Drawing.Size(63, 17)
        Me.tlContact.TabIndex = 7
        Me.tlContact.Text = "Contact"
        '
        'lblContact
        '
        Me.lblContact.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(43, 259)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(184, 23)
        Me.lblContact.TabIndex = 8
        '
        'lblEmail
        '
        Me.lblEmail.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(300, 184)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(178, 23)
        Me.lblEmail.TabIndex = 14
        '
        'tlEmail
        '
        Me.tlEmail.AutoSize = True
        Me.tlEmail.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlEmail.ForeColor = System.Drawing.Color.White
        Me.tlEmail.Location = New System.Drawing.Point(297, 157)
        Me.tlEmail.Name = "tlEmail"
        Me.tlEmail.Size = New System.Drawing.Size(43, 17)
        Me.tlEmail.TabIndex = 13
        Me.tlEmail.Text = "Email"
        '
        'lblUsername
        '
        Me.lblUsername.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(300, 114)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(178, 23)
        Me.lblUsername.TabIndex = 12
        '
        'tlUsername
        '
        Me.tlUsername.AutoSize = True
        Me.tlUsername.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlUsername.ForeColor = System.Drawing.Color.White
        Me.tlUsername.Location = New System.Drawing.Point(297, 90)
        Me.tlUsername.Name = "tlUsername"
        Me.tlUsername.Size = New System.Drawing.Size(71, 17)
        Me.tlUsername.TabIndex = 11
        Me.tlUsername.Text = "Username"
        '
        'tlPosition
        '
        Me.tlPosition.AutoSize = True
        Me.tlPosition.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlPosition.ForeColor = System.Drawing.Color.White
        Me.tlPosition.Location = New System.Drawing.Point(40, 307)
        Me.tlPosition.Name = "tlPosition"
        Me.tlPosition.Size = New System.Drawing.Size(58, 17)
        Me.tlPosition.TabIndex = 10
        Me.tlPosition.Text = "Position"
        '
        'lblPosition
        '
        Me.lblPosition.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(43, 333)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(184, 23)
        Me.lblPosition.TabIndex = 9
        '
        'lblPassword
        '
        Me.lblPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(300, 259)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.lblPassword.Size = New System.Drawing.Size(178, 23)
        Me.lblPassword.TabIndex = 16
        '
        'tlPassword
        '
        Me.tlPassword.AutoSize = True
        Me.tlPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlPassword.ForeColor = System.Drawing.Color.White
        Me.tlPassword.Location = New System.Drawing.Point(297, 233)
        Me.tlPassword.Name = "tlPassword"
        Me.tlPassword.Size = New System.Drawing.Size(69, 17)
        Me.tlPassword.TabIndex = 15
        Me.tlPassword.Text = "Password"
        '
        'cboxShow
        '
        Me.cboxShow.AutoSize = True
        Me.cboxShow.ForeColor = System.Drawing.Color.White
        Me.cboxShow.Location = New System.Drawing.Point(425, 291)
        Me.cboxShow.Name = "cboxShow"
        Me.cboxShow.Size = New System.Drawing.Size(53, 17)
        Me.cboxShow.TabIndex = 17
        Me.cboxShow.Text = "Show"
        Me.cboxShow.UseVisualStyleBackColor = True
        '
        'addUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(513, 454)
        Me.Controls.Add(Me.cboxShow)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.tlPassword)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.tlEmail)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.tlUsername)
        Me.Controls.Add(Me.tlPosition)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.tlContact)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.tlAddress)
        Me.Controls.Add(Me.tlName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.tlAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "addUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tlAdd As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.TextBox
    Friend WithEvents tlName As System.Windows.Forms.Label
    Friend WithEvents tlAddress As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblAddress As System.Windows.Forms.TextBox
    Friend WithEvents tlContact As System.Windows.Forms.Label
    Friend WithEvents lblContact As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.TextBox
    Friend WithEvents tlEmail As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.TextBox
    Friend WithEvents tlUsername As System.Windows.Forms.Label
    Friend WithEvents tlPosition As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.TextBox
    Friend WithEvents tlPassword As System.Windows.Forms.Label
    Friend WithEvents cboxShow As System.Windows.Forms.CheckBox
End Class
