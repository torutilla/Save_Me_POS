Public Class addUser

    Private Sub addUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If String.IsNullOrEmpty(lblName.Text) AndAlso String.IsNullOrEmpty(lblContact.Text) AndAlso String.IsNullOrEmpty(lblUsername.Text) Then
            MsgBox("Incomplete Information")
        Else
                Try
                    conn.Open()
                    Dim query As String = "INSERT INTO tblemployee(EMPNAME, EMPADDRESS, EMPCONTACT, EMPPOSITION, USERNAME, EMAIL, PASSWRD) VALUES(@Name1, @Address, @Contact, @Position, @Username1, @Email, @Password)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@Name1", lblName.Text)
                    cmd.Parameters.AddWithValue("@Address", lblAddress.Text)
                    cmd.Parameters.AddWithValue("@Contact", lblContact.Text)
                    cmd.Parameters.AddWithValue("@Position", lblPosition.Text)
                    cmd.Parameters.AddWithValue("@Username1", lblUsername.Text)
                    cmd.Parameters.AddWithValue("@Email", lblEmail.Text)
                    cmd.Parameters.AddWithValue("@Password", lblPassword.Text)
                    cmd.Connection = conn
                    cmd.CommandText = query
                    cmd.ExecuteNonQuery()
                MessageBox.Show("Successfully Added!")
                    conn.Close()
                    Me.Hide()
                Catch ex As Exception
                MessageBox.Show("Error Adding User: " & ex.Message)
                Finally
                    conn.Close()
                End Try
        End If


    End Sub

    Private Sub cboxShow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxShow.CheckedChanged
        If cboxShow.Checked = True Then
            lblPassword.PasswordChar = ""
        Else
            lblPassword.PasswordChar = "*"
        End If
    End Sub
End Class