Imports MySql.Data.MySqlClient

Public Class frmStocks

    Private Property btnSave As Object

    Private Sub frmStocks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbposDataSet.tblitem' table. You can move, or remove it, as needed.
        Me.TblitemTableAdapter.Fill(Me.DbposDataSet.tblitem)

        btnAdd.BackColor = ColorTranslator.FromHtml("#212B40")

        Try
            conn.Open()
            Dim query As String = "SELECT DISTINCT ITEMCATEGORY FROM tblitem"
            cmd.Connection = conn
            cmd.CommandText = query

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                cbxCategory.Items.Add(reader("ITEMCATEGORY").ToString())
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        cbxCategory.SelectedIndex = -1

        If cbxFilter.SelectedIndex = 0 Then
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM tblitem"
                cmd.Connection = conn
                cmd.CommandText = query

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                DataGridView1.DataSource = dataTable

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If

        txtItemCode.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtitemname.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtcategory.Text = DataGridView1.CurrentRow.Cells(3).Value
        txtqty.Text = DataGridView1.CurrentRow.Cells(4).Value
        Dim unitP As Double = DataGridView1.CurrentRow.Cells(5).Value
        txtUnitPrice.Text = unitP.ToString("0.00")

    End Sub

    Private Sub btsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click


        If btnAdd.Text = "Add" Then
            txtItemCode.Enabled = True
            txtitemname.Enabled = True
            txtcategory.Enabled = True
            txtqty.Enabled = True
            txtUnitPrice.Enabled = True
            txtItemCode.Text = ""
            txtitemname.Text = ""
            txtcategory.Text = ""
            txtqty.Text = ""
            txtUnitPrice.Text = ""
            btnAdd.Text = "Adding..."
        Else
            If String.IsNullOrEmpty(txtItemCode.Text) AndAlso
            String.IsNullOrEmpty(txtitemname.Text) AndAlso
            String.IsNullOrEmpty(txtcategory.Text) AndAlso
            String.IsNullOrEmpty(txtqty.Text) AndAlso
            String.IsNullOrEmpty(txtUnitPrice.Text) Then
                MsgBox("Invalid Input")
            Else
                Try
                    conn.Open()
                    Dim query As String = "INSERT INTO tblitem(ITEMCODE, ITEMNAME, ITEMCATEGORY, QTY, UNITPRICE) VALUES(@Code, @Name, @Category, @Qty, @UnitP) ON DUPLICATE KEY UPDATE QTY = QTY + VALUES(QTY);"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@Code", txtItemCode.Text)
                    cmd.Parameters.AddWithValue("@Name", txtitemname.Text)
                    cmd.Parameters.AddWithValue("@Category", txtcategory.Text)
                    cmd.Parameters.AddWithValue("@Qty", txtqty.Text)
                    cmd.Parameters.AddWithValue("@UnitP", txtUnitPrice.Text)
                    cmd.Connection = conn
                    cmd.CommandText = query
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error Adding Item")
                Finally
                    conn.Close()
                    btnAdd.Text = "Add"
                    txtItemCode.Enabled = False
                    txtitemname.Enabled = False
                    txtcategory.Enabled = False
                    txtqty.Enabled = False
                    txtUnitPrice.Enabled = False
                    txtItemCode.Text = ""
                    txtitemname.Text = ""
                    txtcategory.Text = ""
                    txtqty.Text = ""
                    txtUnitPrice.Text = ""
                    Me.TblitemTableAdapter.Fill(Me.DbposDataSet.tblitem)
                End Try
            End If
        End If

    End Sub
    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click

        txtItemCode.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtitemname.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtcategory.Text = DataGridView1.CurrentRow.Cells(3).Value
        txtqty.Text = DataGridView1.CurrentRow.Cells(4).Value
        Dim unitP As Double = DataGridView1.CurrentRow.Cells(5).Value
        txtUnitPrice.Text = unitP.ToString("0.00")

    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        For Each selectedRow As DataGridViewRow In DataGridView1.SelectedRows
            Dim i As String = selectedRow.Cells(0).Value.ToString()
            Try
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    conn.Open()

                    Dim query As String = "DELETE FROM tblitem WHERE ITEMNO = " & i.ToString
                    cmd.Connection = conn
                    cmd.CommandText = query
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show(rowsAffected & " row(s) deleted.")
                    End If


                Else
                    MessageBox.Show("Error Deleting Item")
                    Me.TblitemTableAdapter.Fill(Me.DbposDataSet.tblitem)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)

            Finally
                Me.TblitemTableAdapter.Fill(Me.DbposDataSet.tblitem)
                conn.Close()
            End Try


        Next
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        For Each selectedRow As DataGridViewRow In DataGridView1.SelectedRows
            Dim i As String = selectedRow.Cells(0).Value.ToString()

            If btnupdate.Text = "Update" Then
                txtItemCode.Enabled = True
                txtitemname.Enabled = True
                txtcategory.Enabled = True
                txtqty.Enabled = True
                txtUnitPrice.Enabled = True
                btnupdate.Text = "Save"
            Else
                btnupdate.Text = "Update"
                Try
                    conn.Open()
                    Dim query As String = "UPDATE tblitem SET ITEMCODE = @Code, ITEMNAME = @Name, ITEMCATEGORY = @Category,  QTY = @Qty, UNITPRICE = @UnitP WHERE ITEMNO =" & i.ToString()
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@Code", txtItemCode.Text)
                    cmd.Parameters.AddWithValue("@Name", txtitemname.Text)
                    cmd.Parameters.AddWithValue("@Category", txtcategory.Text)
                    cmd.Parameters.AddWithValue("@Qty", txtqty.Text)
                    cmd.Parameters.AddWithValue("@UnitP", txtUnitPrice.Text)
                    cmd.Connection = conn
                    cmd.CommandText = query
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error Updating Item")
                Finally
                    conn.Close()
                    txtItemCode.Enabled = False
                    txtitemname.Enabled = False
                    txtcategory.Enabled = False
                    txtqty.Enabled = False
                    txtUnitPrice.Enabled = False
                    txtItemCode.Text = ""
                    txtitemname.Text = ""
                    txtcategory.Text = ""
                    txtqty.Text = ""
                    txtUnitPrice.Text = ""
                    Me.TblitemTableAdapter.Fill(Me.DbposDataSet.tblitem)
                End Try
            End If
        Next



    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM tblitem"
            cmd.Connection = conn
            cmd.CommandText = query

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            DataGridView1.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub cbxFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFilter.SelectedIndexChanged
        If cbxFilter.SelectedIndex = 0 Then
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM tblitem"
                cmd.Connection = conn
                cmd.CommandText = query

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                DataGridView1.DataSource = dataTable

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        ElseIf cbxFilter.SelectedIndex = 1 Then
            cbxCategory.Visible = True
        ElseIf cbxFilter.SelectedIndex = 2 Then
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM tblitem WHERE QTY < 4"
                cmd.Connection = conn
                cmd.CommandText = query

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                DataGridView1.DataSource = dataTable

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If

    End Sub

    Private Sub UpdateDataGridView(ByVal filterValue As String)

        Try
            conn.Open()
            Dim query As String = "SELECT * FROM tblitem WHERE ITEMCATEGORY = '" & filterValue & "'"
            cmd.Connection = conn
            cmd.CommandText = query

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            DataGridView1.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub cbxCategory_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxCategory.DropDown
       

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim searchStr As String = txtSearch.Text.Trim()
        UpdateSearch(searchStr)
    End Sub
    Private Sub UpdateSearch(ByVal searchStr As String)
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM tblitem WHERE ITEMNAME LIKE '%" & searchStr & "%'"
            cmd.Connection = conn
            cmd.CommandText = query

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' Display the updated data in the DataGridView
            DataGridView1.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            txtSearch.Text = ""
            conn.Close()
        End Try
    End Sub


    Private Sub cbxCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCategory.SelectedIndexChanged
        Dim selectedValue As String = cbxCategory.SelectedItem.ToString()
        UpdateDataGridView(selectedValue)
    End Sub
End Class