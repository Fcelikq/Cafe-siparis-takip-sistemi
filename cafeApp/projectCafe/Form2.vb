Public Class Masalar
    Private Sub table1_Click(sender As Object, e As EventArgs) Handles table1.Click
        Me.Hide()
        masa1.Show()
    End Sub

    Private Sub btnTable_Click(sender As Object, e As EventArgs) Handles btnTable.Click
        Me.Hide()
        genelTablo.Show()

    End Sub

    Private Sub table1_MouseHover(sender As Object, e As EventArgs) Handles table1.MouseHover
        table1.BackColor = Color.Green


    End Sub

    Private Sub table1_MouseLeave(sender As Object, e As EventArgs) Handles table1.MouseLeave
        table1.BackColor = Color.AliceBlue

    End Sub

    Private Sub table2_MouseHover(sender As Object, e As EventArgs) Handles table2.MouseHover
        table2.BackColor = Color.Green

    End Sub

    Private Sub table2_MouseLeave(sender As Object, e As EventArgs) Handles table2.MouseLeave
        table2.BackColor = Color.AliceBlue

    End Sub

    Private Sub table3_MouseHover(sender As Object, e As EventArgs) Handles table3.MouseHover
        table3.BackColor = Color.Green

    End Sub

    Private Sub table3_MouseLeave(sender As Object, e As EventArgs) Handles table3.MouseLeave
        table3.BackColor = Color.AliceBlue

    End Sub

    Private Sub Masalar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Masalar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Giris.Close()

    End Sub
End Class