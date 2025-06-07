Imports MySql.Data.MySqlClient

Public Class frmFind
    Dim pos As New frmPOS()
    Private nonFilter As DataTable

    Private Sub frmFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbposDataSet.tblitem' table. You can move, or remove it, as needed.
        Me.TblitemTableAdapter.Fill(Me.DbposDataSet.tblitem)
        Try
            conn.Open()
            Dim query As String = "SELECT DISTINCT ITEMCATEGORY FROM tblitem"
            cmd.Connection = conn
            cmd.CommandText = query

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                ComboBox1.Items.Add(reader("ITEMCATEGORY").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
        ComboBox1.Items.Insert(0, "None")
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For Each selectedRow As DataGridViewRow In DataGridView1.SelectedRows
            Dim i As String = selectedRow.Cells(0).Value.ToString()
            Try
                conn.Close()

                conn.Open()
                Using cmdCheckQuantity As New MySqlCommand()
                    cmdCheckQuantity.Connection = conn
                    cmdCheckQuantity.CommandText = "SELECT QTY FROM tblitem WHERE ITEMNO = @Code"
                    cmdCheckQuantity.Parameters.AddWithValue("@Code", i)

                    Dim readerQuantity As MySqlDataReader = cmdCheckQuantity.ExecuteReader()

                    If readerQuantity.Read() Then
                        Dim availableQuantity As Integer = Convert.ToInt32(readerQuantity("QTY"))

                        If availableQuantity > 0 Then

                            readerQuantity.Close()
                            Dim query As String = "SELECT * FROM tblitem WHERE ITEMNO = @Itemnum"
                            cmd.Connection = conn
                            cmd.CommandText = query
                            cmd.Parameters.AddWithValue("@Itemnum", i)
                            Dim reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.HasRows Then
                                While reader.Read()
                                    pos.txtitemname.Text = reader("ITEMNAME").ToString()
                                    pos.txtprice.Text = reader("UNITPRICE").ToString()
                                    pos.txtItemCode.Text = reader("ITEMCODE").ToString()
                                    pos.txtcategory.Text = reader("ITEMCATEGORY").ToString()

                                    pos.txtqty.Text = 1
                                    pos.TopLevel = False

                                    ' fill the entire panel
                                    pos.Dock = DockStyle.Fill

                                    ' Clear existing controls in the panel (if needed)
                                    Form2.MainPanel.Controls.Clear()

                                    ' Add the form
                                    Form2.MainPanel.Controls.Add(pos)
                                    pos.Show()

                                    Me.Close()

                                End While
                            Else
                                MessageBox.Show("Item not found in the database.")
                            End If

                        Else
                            MessageBox.Show("Not Enough Quantity")
                        End If
                    End If

                End Using

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
                cmd.Parameters.Clear()
            End Try
        Next

    End Sub


    Private Sub txtSearch_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.Enter
        If txtSearch.Text = "Search" Then
            txtSearch.Text = ""
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem.ToString = "None" Then
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


        Else

            Dim selectedValue As String = ComboBox1.SelectedItem.ToString()
            UpdateDataGridView(selectedValue)
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

End Class