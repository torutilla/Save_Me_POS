Imports MySql.Data.MySqlClient
Public Class Form2
    Dim accs As New Accounts()
    Dim pos As New frmPOS()
    Dim stock As New frmStocks()


    Private Sub Form2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        If Not MainPanel.Controls.Contains(pos) Then
            pos.TopLevel = False
            pos.Dock = DockStyle.Fill

            MainPanel.Controls.Clear()

            MainPanel.Controls.Add(pos)
            pos.SendToBack()

        End If
        pos.Show()

        Try
            cmd.Parameters.Clear()

            Dim query As String = "SELECT * FROM tblemployee WHERE USERNAME = @Username"
            cmd.Connection = conn
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@Username", username)

            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    Label21.Text = "Welcome, " & reader("EMPNAME").ToString()
                    Label1.Text = reader("EMPPOSITION").ToString()
                End While
            Else
                MessageBox.Show("Username not found in the database.")
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        

    End Sub


    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStocks.MouseHover

        btnStocks.BackColor = ColorTranslator.FromHtml("#212B40")
        btnStocks.ForeColor = ColorTranslator.FromHtml("#D9AA71")


    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStocks.MouseLeave
        btnStocks.BackColor = ColorTranslator.FromHtml("#809BBF")
        btnStocks.ForeColor = ColorTranslator.FromHtml("#212B40")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStocks.Click
        colormove.Location = New Point(-6, 175)
        titleLabel.Text = "STOCK MANAGEMENT"
        stock.TopLevel = False

        ' fill the entire panel
        stock.Dock = DockStyle.Fill

        ' Clear existing controls in the panel (if needed)
        MainPanel.Controls.Clear()

        ' Add the form
        MainPanel.Controls.Add(stock)

        stock.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPOS.Click
        colormove.Location = New Point(-6, 107)

        titleLabel.Text = "POINT OF SALE SYSTEM"

        pos.TopLevel = False

        ' fill the entire panel
        pos.Dock = DockStyle.Fill

        ' Clear existing controls in the panel (if needed)
        MainPanel.Controls.Clear()

        ' Add the form
        MainPanel.Controls.Add(pos)

        pos.Show()
    End Sub
    Private Sub Button2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPOS.MouseHover
        btnPOS.BackColor = ColorTranslator.FromHtml("#212B40")
        btnPOS.ForeColor = ColorTranslator.FromHtml("#D9AA71")

    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPOS.MouseLeave
        btnPOS.BackColor = ColorTranslator.FromHtml("#809BBF")
        btnPOS.ForeColor = ColorTranslator.FromHtml("#212B40")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
        Form1.Show()
        cmd.Parameters.Clear()

    End Sub

    Private Sub btnAccount_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccount.MouseHover
        btnAccount.BackColor = ColorTranslator.FromHtml("#212B40")
        btnAccount.ForeColor = ColorTranslator.FromHtml("#D9AA71")

    End Sub

    Private Sub btnAccount_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccount.MouseLeave
        btnAccount.BackColor = ColorTranslator.FromHtml("#809BBF")
        btnAccount.ForeColor = ColorTranslator.FromHtml("#212B40")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccount.Click
        colormove.Location = New Point(-6, 237)
        titleLabel.Text = "ACCOUNT SETTINGS"

        accs.TopLevel = False

        ' fill the entire panel
        accs.Dock = DockStyle.Fill

        ' Clear existing controls in the panel (if needed)
        MainPanel.Controls.Clear()

        ' Add the form
        MainPanel.Controls.Add(accs)

        accs.Show()

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MainPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MainPanel.Paint

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form2_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Try
            conn.Close()
            conn.Open()
            cmd.Connection = conn
            Dim query As String = "DELETE FROM tblitemtransact"
            cmd.CommandText = query
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)

        Finally
            conn.Close()
        End Try
    End Sub

End Class