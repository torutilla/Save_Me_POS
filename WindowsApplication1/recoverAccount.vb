Imports MySql.Data.MySqlClient

Public Class recoverAccount

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If txtpass.Text <> txtconfirm.Text Then
                MessageBox.Show("Password not matched!")
            Else
                Dim queryCheckUser As String = "SELECT * FROM tblemployee_backup WHERE (USERNAME = @user1 OR EMAIL = @user1) AND PASSWRD = @password"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@user1", txtemailuser.Text)
                cmd.Parameters.AddWithValue("@password", txtpass.Text)

                cmd.CommandText = queryCheckUser
                conn.Open()

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    reader.Close()
                    Dim query As String = "INSERT INTO tblemployee SELECT DISTINCT * FROM tblemployee_backup WHERE (USERNAME = @user1 OR EMAIL = @user1)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@user1", txtemailuser.Text)

                    cmd.CommandText = query
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then

                        cmd.Parameters.Clear()
                        Dim queryDelete As String = "DELETE FROM tblemployee_backup WHERE USERNAME = @user1"
                        cmd.Parameters.AddWithValue("@user1", txtemailuser.Text)
                        cmd.CommandText = queryDelete
                        Dim rowsAffectedDelete As Integer = cmd.ExecuteNonQuery()

                        MessageBox.Show("Recovery Successful!")
                        Me.Close()

                    End If
                Else
                    MessageBox.Show("Account does not exist")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
        

    End Sub
End Class