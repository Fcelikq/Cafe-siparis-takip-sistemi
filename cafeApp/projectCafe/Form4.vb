Public Class genelTablo
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        'TODO: This line of code loads data into the 'TablesDataSet.dailyTable' table. You can move, or remove it, as needed.
        Me.DailyTableTableAdapter.Fill(Me.TablesDataSet.dailyTable)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Masalar.Show()

    End Sub
End Class