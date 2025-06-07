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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnPOS = New System.Windows.Forms.Button()
        Me.btnStocks = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.ico4 = New System.Windows.Forms.PictureBox()
        Me.ico3 = New System.Windows.Forms.PictureBox()
        Me.ico2 = New System.Windows.Forms.PictureBox()
        Me.ico1 = New System.Windows.Forms.PictureBox()
        Me.colormove = New System.Windows.Forms.Panel()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.ico4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ico3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ico2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ico1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.titleLabel)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1379, 71)
        Me.Panel3.TabIndex = 6
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(47, 20)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(136, 37)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.ForeColor = System.Drawing.Color.White
        Me.titleLabel.Location = New System.Drawing.Point(587, 22)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(244, 26)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "POINT OF SALE SYSTEM"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1094, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 57)
        Me.Panel1.TabIndex = 10
        '
        'Label21
        '
        Me.Label21.AutoEllipsis = True
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(32, 13)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(184, 17)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Welcome Message Here! "
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(75, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Administrator"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnAccount)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.btnPOS)
        Me.Panel2.Controls.Add(Me.btnStocks)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(212, 649)
        Me.Panel2.TabIndex = 7
        '
        'btnAccount
        '
        Me.btnAccount.FlatAppearance.BorderSize = 0
        Me.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAccount.Location = New System.Drawing.Point(67, 237)
        Me.btnAccount.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnAccount.Size = New System.Drawing.Size(145, 43)
        Me.btnAccount.TabIndex = 3
        Me.btnAccount.Text = "Account"
        Me.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccount.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(67, 531)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(145, 43)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Logout"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnPOS
        '
        Me.btnPOS.FlatAppearance.BorderSize = 0
        Me.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPOS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPOS.Location = New System.Drawing.Point(67, 110)
        Me.btnPOS.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPOS.Name = "btnPOS"
        Me.btnPOS.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnPOS.Size = New System.Drawing.Size(145, 43)
        Me.btnPOS.TabIndex = 1
        Me.btnPOS.Text = "Point of Sale"
        Me.btnPOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPOS.UseVisualStyleBackColor = True
        '
        'btnStocks
        '
        Me.btnStocks.FlatAppearance.BorderSize = 0
        Me.btnStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStocks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnStocks.Location = New System.Drawing.Point(67, 175)
        Me.btnStocks.Margin = New System.Windows.Forms.Padding(0)
        Me.btnStocks.Name = "btnStocks"
        Me.btnStocks.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnStocks.Size = New System.Drawing.Size(145, 43)
        Me.btnStocks.TabIndex = 0
        Me.btnStocks.Text = "Stocks"
        Me.btnStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStocks.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 159)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel7.Controls.Add(Me.ico4)
        Me.Panel7.Controls.Add(Me.ico3)
        Me.Panel7.Controls.Add(Me.ico2)
        Me.Panel7.Controls.Add(Me.ico1)
        Me.Panel7.Controls.Add(Me.colormove)
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(67, 653)
        Me.Panel7.TabIndex = 12
        '
        'ico4
        '
        Me.ico4.Image = CType(resources.GetObject("ico4.Image"), System.Drawing.Image)
        Me.ico4.Location = New System.Drawing.Point(21, 537)
        Me.ico4.Name = "ico4"
        Me.ico4.Size = New System.Drawing.Size(30, 30)
        Me.ico4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ico4.TabIndex = 4
        Me.ico4.TabStop = False
        '
        'ico3
        '
        Me.ico3.Image = CType(resources.GetObject("ico3.Image"), System.Drawing.Image)
        Me.ico3.Location = New System.Drawing.Point(21, 242)
        Me.ico3.Name = "ico3"
        Me.ico3.Size = New System.Drawing.Size(30, 30)
        Me.ico3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ico3.TabIndex = 3
        Me.ico3.TabStop = False
        '
        'ico2
        '
        Me.ico2.Image = CType(resources.GetObject("ico2.Image"), System.Drawing.Image)
        Me.ico2.Location = New System.Drawing.Point(21, 180)
        Me.ico2.Name = "ico2"
        Me.ico2.Size = New System.Drawing.Size(30, 30)
        Me.ico2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ico2.TabIndex = 2
        Me.ico2.TabStop = False
        '
        'ico1
        '
        Me.ico1.Image = CType(resources.GetObject("ico1.Image"), System.Drawing.Image)
        Me.ico1.Location = New System.Drawing.Point(21, 113)
        Me.ico1.Name = "ico1"
        Me.ico1.Size = New System.Drawing.Size(30, 30)
        Me.ico1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ico1.TabIndex = 1
        Me.ico1.TabStop = False
        '
        'colormove
        '
        Me.colormove.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.colormove.Location = New System.Drawing.Point(-6, 107)
        Me.colormove.Name = "colormove"
        Me.colormove.Size = New System.Drawing.Size(10, 42)
        Me.colormove.TabIndex = 0
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.White
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(212, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1152, 649)
        Me.MainPanel.TabIndex = 13
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 649)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        CType(Me.ico4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ico3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ico2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ico1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents titleLabel As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnStocks As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPOS As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnAccount As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents colormove As System.Windows.Forms.Panel
    Friend WithEvents ico3 As System.Windows.Forms.PictureBox
    Friend WithEvents ico2 As System.Windows.Forms.PictureBox
    Friend WithEvents ico1 As System.Windows.Forms.PictureBox
    Friend WithEvents ico4 As System.Windows.Forms.PictureBox
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
