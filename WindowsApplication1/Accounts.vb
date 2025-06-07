Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Accounts
    Private Sub Accounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TblemployeeTableAdapter.Fill(Me.DbposDataSet.tblemployee)

        Try
            conn.Close()
            cmd.Parameters.Clear()

            Dim query As String = "SELECT * FROM tblemployee WHERE USERNAME = @Username"
            cmd.Connection = conn
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@Username", username)
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    lblName.Text = reader("EMPNAME").ToString()
                    lblAddress.Text = reader("EMPADDRESS").ToString()
                    lblContact.Text = reader("EMPCONTACT").ToString()
                    lblPosition.Text = reader("EMPPOSITION").ToString()
                    lblUsername.Text = reader("USERNAME").ToString()
                    lblPassword.Text = reader("PASSWRD").ToString()
                    lblEmail.Text = reader("EMAIL").ToString()
                    Dim byteImage() As Byte = DirectCast(reader("IMAGE"), Byte())
                    Dim ms As New MemoryStream(byteImage)
                    pic1.Image = Image.FromStream(ms)



                End While
            Else
                MessageBox.Show("Username not found in the database.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()

        End Try

        If pic1.Image Is Nothing Then
            pic1.Image = Image.FromFile(IO.Path.Combine(Application.StartupPath, "default.jpg"))
        End If
    End Sub




    Private Sub cboxShow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxShow.CheckedChanged
        If cboxShow.Checked = True Then
            lblPassword.PasswordChar = ""
        Else
            lblPassword.PasswordChar = "*"
        End If

    End Sub

    Private Sub btnAddAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAcc.Click
        addUser.Show()

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.TblemployeeTableAdapter.Fill(Me.DbposDataSet.tblemployee)
    End Sub


    Private Sub btnEditAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditAcc.Click
        If btnEditAcc.Text = "Edit Profile" Then
            lblName.Enabled = True
            lblAddress.Enabled = True
            lblContact.Enabled = True
            lblPosition.Enabled = True
            btnEditAcc.Text = "Save Profile"
        Else
            btnEditAcc.Text = "Edit Profile"
            conn.Open()
            Dim query As String = "UPDATE tblemployee SET EMPNAME = @Name1, EMPADDRESS =@Address, EMPCONTACT = @Contact, EMPPOSITION = @Position WHERE USERNAME = @usermatch"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Name1", lblName.Text)
            cmd.Parameters.AddWithValue("@Address", lblAddress.Text)
            cmd.Parameters.AddWithValue("@Contact", lblContact.Text)
            cmd.Parameters.AddWithValue("@Position", lblPosition.Text)
            cmd.Parameters.AddWithValue("@usermatch", username.ToString)
            cmd.Connection = conn
            cmd.CommandText = query
            cmd.ExecuteNonQuery()

            conn.Close()

            lblName.Enabled = False
            lblAddress.Enabled = False
            lblContact.Enabled = False
            lblPosition.Enabled = False
            Me.TblemployeeTableAdapter.Fill(Me.DbposDataSet.tblemployee)
        End If
    End Sub

    Private Sub btnDelAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelAcc.Click

        Try
            conn.Close()
            Dim inputPassword As String = InputBox("Enter your password for confirmation:", "Password Confirmation")
            Dim queryCheckUser As String = "SELECT * FROM tblemployee WHERE USERNAME = @user1 AND PASSWRD = @password"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@user1", username)
            cmd.Parameters.AddWithValue("@password", inputPassword)
            cmd.CommandText = queryCheckUser

            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Close()
                cmd.Parameters.Clear()
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim query As String = "DELETE FROM tblemployee WHERE USERNAME = @user1"
                    cmd.Parameters.AddWithValue("@user1", username)
                    cmd.CommandText = query
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("User Logout")
                        Form2.Close()
                        Form1.Show()
                    End If
                Else
                    MessageBox.Show("Error Deleting User")
                    Me.TblemployeeTableAdapter.Fill(Me.DbposDataSet.tblemployee)
                End If
            Else
                MsgBox("Incorrect Password")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            Me.TblemployeeTableAdapter.Fill(Me.DbposDataSet.tblemployee)
            conn.Close()
        End Try
    End Sub

    Private Sub btnEdit2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit2.Click
        Try
            
            If btnEdit2.Text = "Edit Security" Then
                conn.Close()
                Dim inputPassword As String = InputBox("Enter your password for confirmation:", "Password Confirmation")
                Dim queryCheckUser As String = "SELECT * FROM tblemployee WHERE USERNAME = @user1 AND PASSWRD = @password"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@user1", username)
                cmd.Parameters.AddWithValue("@password", inputPassword)
                cmd.CommandText = queryCheckUser
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    cboxShow.Visible = True
                    lblUsername.Enabled = True
                    lblEmail.Enabled = True
                    lblPassword.Enabled = True
                    btnEdit2.Text = "Save Security"
                End If
                reader.Close()
            Else
                conn.Open()
                btnEdit2.Text = "Edit Security"
                Dim query As String = "UPDATE tblemployee SET USERNAME = @user, EMAIL =@Email, PASSWRD = @pass WHERE USERNAME = @usermatch"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@user", lblUsername.Text)
                cmd.Parameters.AddWithValue("@Email", lblEmail.Text)
                cmd.Parameters.AddWithValue("@pass", lblPassword.Text)
                cmd.Parameters.AddWithValue("@usermatch", username.ToString)
                cmd.Connection = conn
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

                conn.Close()

                lblUsername.Enabled = False
                lblEmail.Enabled = False
                lblPassword.Enabled = False
                cboxShow.Visible = False
                lblPassword.PasswordChar = "*"
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try


    End Sub

    Private Sub btnAccRecover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccRecover.Click
        Try
            Dim inputPassword As String = InputBox("Enter your password for confirmation:", "Password Confirmation")
            Dim queryCheckUser As String = "SELECT * FROM tblemployee WHERE USERNAME = @user1 AND PASSWRD = @password"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@user1", username)
            cmd.Parameters.AddWithValue("@password", inputPassword)
            cmd.CommandText = queryCheckUser
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                recoverAccount.Show()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
        
    End Sub
End Class

