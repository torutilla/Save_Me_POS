Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class frmReceipt
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Dim discountValue As Double
    Dim taxCharged As Double
    Dim cashPay As Double
    Dim cashChange As Double
    Dim totalAmount As Double
    Public Property discount As Double
    Public Property tax As Double
    Public Property cash As Double
    Public Property change As Double
    Public Property allTotal As Double
    Dim Cashier As String


    Private Sub frmReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbposDataSet.tblitemtransact' table. You can move, or remove it, as needed.
        Me.TblitemtransactTableAdapter.Fill(Me.DbposDataSet.tblitemtransact)
        discountValue = discount
        taxCharged = tax
        cashPay = cash
        cashChange = change
        totalAmount = allTotal
        DateTime1.Value = DateTime.Now

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
                    Cashier = reader("EMPNAME").ToString()
                End While
            Else
                MessageBox.Show("Username not found in the database.")
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()

        End Try

    End Sub
    'adjust paper size depending on number of items
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = DataGridView1.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 200
    End Sub
    Private Sub BtPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtPrint.Click
        changelongpaper() 'calls change long paper sub
        PPD.Document = PD
        PPD.ShowDialog()
        DateTime1.Value = DateTime.Now
    End Sub
    Public Sub PD_BeginPrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PD.BeginPrint
        'papersize
        Dim pagesetup As New PageSettings
        'pagesetup.PaperSize = New PaperSize("Custom", 250, 500) 'fixed long paper
        pagesetup.PaperSize = New PaperSize("Custom", 300, longpaper)
        PD.DefaultPageSettings = pagesetup


    End Sub

    Private Sub PD_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PD.PrintPage
        'specify font formatting
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        'specify margin 
        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        'text alignment
        Dim right As New StringFormat
        Dim center As New StringFormat
        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "---------------------------------------------------------------------------------------"

        'header
        e.Graphics.DrawString("SAVE ME", f14, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("Kaybagal Central, Tagaytay City", f10, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString("Tel: 09054472326", f8, Brushes.Black, centermargin, 40, center)

        'for invoice
        e.Graphics.DrawString("Invoice ID", f8, Brushes.Black, 0, 60)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 60)
        e.Graphics.DrawString(" ", f8, Brushes.Black, 70, 60)

        'for cashier
        e.Graphics.DrawString("Cashier", f8, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 75)
        e.Graphics.DrawString(Cashier.ToString, f8, Brushes.Black, 70, 75)

        'for date and time
        e.Graphics.DrawString("Date", f8, Brushes.Black, 0, 90)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 90)
        e.Graphics.DrawString(DateTime1.Value.ToString(), f8, Brushes.Black, 70, 90)

        'for header division (line)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 100)

        'specifies the position of the text
        Dim height As Integer 'DGV Position
        Dim i As Long

        DataGridView1.AllowUserToAddRows = False
        For row As Integer = 0 To DataGridView1.RowCount - 1
            height += 15
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(0).Value.ToString, f10, Brushes.Black, 0, 100 + height)
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(1).Value.ToString, f10, Brushes.Black, 25, 100 + height)
            i = DataGridView1.Rows(row).Cells(2).Value
            DataGridView1.Rows(row).Cells(2).Value = Format(i, "##,##0")
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(2).Value.ToString, f10, Brushes.Black, rightmargin, 100 + height, right)
        Next
        'for display of price and quantity
        Dim height2 As Integer
        height2 = 110 + height
        sumprice() 'call the sumprice sub

        ' Display tax, VAT, cash payment, and change
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
        e.Graphics.DrawString("Initial Amount: " & Format(t_price, "##,##0"), f10, Brushes.Black, rightmargin, 15 + height2, right)
        e.Graphics.DrawString(t_qty, f10, Brushes.Black, 0, 15 + height2)
        e.Graphics.DrawString("Discount: " & Format(discountValue, "##,##0"), f10, Brushes.Black, rightmargin, 30 + height2, right)
        e.Graphics.DrawString("Tax: " & Format(taxCharged, "##,##0"), f10, Brushes.Black, rightmargin, 45 + height2, right)
        e.Graphics.DrawString("Total Amount: " & Format(totalAmount, "##,##0"), f10b, Brushes.Black, rightmargin, 60 + height2, right)
        e.Graphics.DrawString("Cash Pay: " & Format(cashPay, "##,##0"), f10, Brushes.Black, rightmargin, 75 + height2, right)
        e.Graphics.DrawString("Change: " & Format(cashChange, "##,##0"), f10b, Brushes.Black, rightmargin, 90 + height2, right)

        e.Graphics.DrawString("~ Thanks for Shopping", f10, Brushes.Black, centermargin, 105 + height2, center)
        e.Graphics.DrawString("~ SAVE ME", f10, Brushes.Black, centermargin, 120 + height2, center)
    End Sub

    Dim t_price As Long
    Dim t_qty As Long

    Sub sumprice()
        'sum up price and quantity
        Dim countprice As Long = 0
        For rowitem As Long = 0 To DataGridView1.RowCount - 1
            countprice = countprice + Val(DataGridView1.Rows(rowitem).Cells(2).Value)
        Next
        t_price = countprice

        Dim countqty As Long
        For rowitem As Long = 0 To DataGridView1.RowCount - 1
            countqty = countqty + Val(DataGridView1.Rows(rowitem).Cells(0).Value)
        Next
        t_qty = countqty
    End Sub

End Class