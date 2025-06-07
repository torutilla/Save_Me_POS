Imports MySql.Data.MySqlClient
Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

        TextBox1.Text = ""
        TextBox2.Text = ""
        PictureBox2.Image = Image.FromFile(IO.Path.Combine(Application.StartupPath, "1234.jpg"))
        PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize
        Button1.BackColor = ColorTranslator.FromHtml("#D9AA71")
        Label1.ForeColor = ColorTranslator.FromHtml("#D9AA71")
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
        Button1.ForeColor = ColorTranslator.FromHtml("#403227")
        Panel1.BackColor = ColorTranslator.FromHtml("#212B40")
    End Sub



    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox4.PasswordChar = ""
        Else
            TextBox4.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            conn.Open()

            cmd.Parameters.Clear()

            Dim query As String = "UPDATE tblemployee SET PASSWRD = @NewPassword WHERE EMAIL = @Email AND EMPCONTACT = @PhoneNumber"
            cmd.Connection = conn
            cmd.CommandText = query

            cmd.Parameters.AddWithValue("@NewPassword", TextBox4.Text)
            cmd.Parameters.AddWithValue("@Email", TextBox1.Text)
            cmd.Parameters.AddWithValue("@PhoneNumber", TextBox2.Text)



            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Changes Applied.")
                Form1.Show()
                Me.Hide()

            Else
                MessageBox.Show("No matching records found for the given email and phone number.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()

    End Sub
End Class