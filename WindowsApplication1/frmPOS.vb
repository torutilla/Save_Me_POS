Imports MySql.Data.MySqlClient

Public Class frmPOS

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        frmFind.Show()

    End Sub

    Private Sub frmPOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TblitemtransactTableAdapter.Fill(Me.DbposDataSet.tblitemtransact)
        'TODO: This line of code loads data into the 'DbposDataSet.tblitem' table. You can move, or remove it, as needed.
        Me.TblitemTableAdapter.Fill(Me.DbposDataSet.tblitem)

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btnAddtoDgv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddtoDgv.Click
        Try

            conn.Close()
            conn.Open()
            Using cmdCheckQuantity As New MySqlCommand()
                cmdCheckQuantity.Connection = conn
                cmdCheckQuantity.CommandText = "SELECT QTY FROM tblitem WHERE ITEMCODE = @Code"
                cmdCheckQuantity.Parameters.AddWithValue("@Code", txtItemCode.Text)

                Dim readerQuantity As MySqlDataReader = cmdCheckQuantity.ExecuteReader()

                If readerQuantity.Read() Then
                    Dim availableQuantity As Integer = Convert.ToInt32(readerQuantity("QTY"))
                    If availableQuantity < txtqty.Text Then
                        MsgBox("Not Enough Quantity in Stock")
                    ElseIf availableQuantity > 0 Then

                        readerQuantity.Close()
                        Dim query As String = "INSERT INTO tblitemtransact(ITEMCODE, ITEMNAME, ITEMCATEGORY, QTY, UNITPRICE, TOTALPRICE) VALUES(@Code, @Name, @Category, @Quantity, @UnitPrice, @TotalPrice)"
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@Code", txtItemCode.Text)
                        cmd.Parameters.AddWithValue("@Name", txtitemname.Text)
                        cmd.Parameters.AddWithValue("@Category", txtcategory.Text)
                        cmd.Parameters.AddWithValue("@Quantity", txtqty.Text)
                        cmd.Parameters.AddWithValue("@UnitPrice", txtprice.Text)
                        cmd.Parameters.AddWithValue("@TotalPrice", txttotalPrice.Text)
                        cmd.Connection = conn
                        cmd.CommandText = query
                        cmd.ExecuteNonQuery()

                        cmd.CommandText = "SELECT SUM(TOTALPRICE) FROM tblitemtransact"
                        Dim subT As Double = cmd.ExecuteScalar()
                        txtSubtotal1.Text = subT.ToString("0.00")

                    Else
                        MsgBox("Not Enough Quantity")
                    End If
                End If
            End Using

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try


        Me.TblitemtransactTableAdapter.Fill(Me.DbposDataSet.tblitemtransact)
        txtitemname.Text = ""
        txtItemCode.Text = ""
        txtqty.Text = ""
        txtprice.Text = ""
        txttotalPrice.Text = ""
        txtcategory.Text = ""


    End Sub

    Private Sub txtqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.TextChanged

        Dim strprice As String = txtprice.Text
        Dim strqty As String = txtqty.Text

        Dim price As Integer
        Dim qty As Integer

        Integer.TryParse(strprice, price)
        Integer.TryParse(strqty, qty)


        txttotalPrice.Text = price * qty

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Dim disc As Double = txtSubtotal1.Text * 0.1
            txtdiscount.Text = disc.ToString("0.00")
        Else
            txtdiscount.Text = "0.00"
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Me.TblitemtransactTableAdapter.Fill(Me.DbposDataSet.tblitemtransact)

        txtSubtotal1.Text = "0.00"
        txtdiscount.Text = "0.00"
        txtTax.Text = "0.00"
        txtAmountRecieve.Text = "0.00"
        txtChange.Text = "0.00"
        txtalltotal.Text = "0.00"
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked = True Then
            Dim tax As Double = txtSubtotal1.Text * 0.12
            txtTax.Text = tax.ToString("0.00")
        Else
            txtTax.Text = "0.00"
        End If
    End Sub

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        Dim strsubtotal As String = txtSubtotal1.Text
        Dim strdiscount As String = txtdiscount.Text
        Dim strtax As String = txtTax.Text

        Dim intsub As Double
        Dim intdisc As Double
        Dim inttax As Double

        Double.TryParse(strsubtotal, intsub)
        Double.TryParse(strdiscount, intdisc)
        Double.TryParse(strtax, inttax)

        Dim total As Double = intsub - intdisc + inttax
        txtalltotal.Text = total.ToString("0.00")


    End Sub

    Private Sub txtTax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTax.TextChanged

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtprice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprice.TextChanged

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtAmountRecieve.Text = 0 Then
            MsgBox("Insufficient Amount Received")
        ElseIf txtChange.Text < 0 Then
            MsgBox("Insufficient Amount")
        Else
            Dim OBJ As New frmReceipt
            OBJ.discount = txtdiscount.Text
            OBJ.tax = txtTax.Text
            OBJ.cash = txtAmountRecieve.Text
            OBJ.change = txtChange.Text
            OBJ.allTotal = txtalltotal.Text
            OBJ.Show()
        End If
       

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            conn.Open()
            cmd.Connection = conn
            Dim query As String = "DELETE FROM tblitemtransact"
            cmd.CommandText = query
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Error" & ex.Message)

        Finally
            conn.Close()
            Me.TblitemtransactTableAdapter.Fill(Me.DbposDataSet.tblitemtransact)
            txtSubtotal1.Text = "0.00"
            txtdiscount.Text = "0.00"
            txtTax.Text = "0.00"
            txtAmountRecieve.Text = "0.00"
            txtChange.Text = "0.00"
            txtalltotal.Text = "0.00"

        End Try
    End Sub

    Private Sub txtAmountRecieve_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmountRecieve.TextChanged
        Try
            Dim change As Double = txtAmountRecieve.Text - txtalltotal.Text
            txtChange.Text = change.ToString("0.00")
        Catch ex As Exception
            txtAmountRecieve.Text = 0
            MessageBox.Show("Input Amount")
        End Try





    End Sub

    Private Sub txtalltotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtalltotal.TextChanged

    End Sub

End Class