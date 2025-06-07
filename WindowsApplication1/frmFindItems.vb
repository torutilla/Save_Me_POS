Public Class frmFindItems

    Private Sub frmFindItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgv_Click(ByVal sender As Object, ByVal e As System.EventArgs)



    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For Each selectedRow As DataGridViewRow In DataGridView1.SelectedRows
            Dim i As String = selectedRow.Cells(0).Value.ToString()
            ShowMainForm(i)
        Next

    End Sub

    Public Function ShowMainForm(ByVal i As String)
        Dim findItemForm As New frmPOS()
        findItemForm.getData(i)
    End Function
End Class