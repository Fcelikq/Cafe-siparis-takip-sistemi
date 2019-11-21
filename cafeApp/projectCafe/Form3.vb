Imports System.Data.OleDb




Public Class masa1
    Dim komut As New OleDbCommand
    Dim baglan As New OleDbConnection("provider=microsoft.jet.oledb.4.0;Data Source= C:\Users\FIRAT\Desktop\Cafe\dataBase\Tables.mdb")

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TablesDataSet.table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.TablesDataSet.table1)
        toplam()

    End Sub
    Dim tablo As New DataTable
    Private Sub listele()
        DataGridView1.Refresh()

        baglan.Open()
        Dim adtr As New OleDbDataAdapter("select * from table1", baglan)
        adtr.Fill(tablo)
        DataGridView1.DataSource = tablo
        baglan.Close()
    End Sub

    Private Sub coffee()
        While nudCoffee.Value > 0
            Dim yol As String = Application.StartupPath.ToString()
            Try
                baglan.Open()
                komut.Connection = baglan
                komut.CommandType = CommandType.Text
                komut.CommandText = "INSERT INTO table1 (Urun, Adet,Tutar) values ('" & Label1.Text & "','" & nudCoffee.Value & "','" & nudCoffee.Value * 5 & "')"
                komut.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("Veri Tabanina baglanamadi")

            Finally
                baglan.Close()
                tablo.Clear()
                listele()
                nudCoffee.Value = 0

            End Try
        End While
    End Sub


    Private Sub tea()
        While nudTea.Value > 0
            Dim yol As String = Application.StartupPath.ToString()
            Try
                baglan.Open()
                komut.Connection = baglan
                komut.CommandType = CommandType.Text
                komut.CommandText = "INSERT INTO table1 (Urun, Adet,Tutar) values ('" & Label2.Text & "','" & nudTea.Value & "','" & nudTea.Value * 2 & "')"
                komut.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("Veri Tabanina baglanamadi")

            Finally
                baglan.Close()
                tablo.Clear()
                listele()
                nudTea.Value = 0

            End Try
        End While
    End Sub
    Private Sub toplam()
        Dim tot As Double = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            tot = tot + Convert.ToDouble(DataGridView1.Rows(i).Cells(3).Value)
        Next
        lblTotal.Text = tot
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        coffee()
        tea()
        toplam()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim deleteIndex As Integer
        Try
            deleteIndex = DataGridView1.CurrentRow.Cells("KimlikDataGridViewTextBoxColumn").Value
        Catch ex As Exception
            MsgBox("Secili urun yok")
        End Try
        While (deleteIndex > 0)


            Try
                baglan.Open()
                komut.Connection = baglan
                komut.CommandType = CommandType.Text
                komut.CommandText = "delete from table1 where Kimlik=" & deleteIndex & ""
                komut.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("Veri Silinemedi")
            Finally
                baglan.Close()
                tablo.Clear()
                listele()
                toplam()
                deleteIndex = 0
            End Try




        End While
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Close()
        Masalar.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCloseAccount.Click
        Dim result As Integer = MessageBox.Show("Hesabi Kapatmak Istediginize Eminmisiniz ?", "Masa 1", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            dailyTable()
            MsgBox("Toplam Tutar = " + lblTotal.Text)
        Try
                baglan.Open()
                komut.Connection = baglan
                komut.CommandType = CommandType.Text
                komut.CommandText = "delete *from table1"
                komut.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Veri Silinemedi")
            Finally
                baglan.Close()
                tablo.Clear()
                listele()
                toplam()
                Me.Close()
                Masalar.Show()


            End Try
        End If


    End Sub
    Private Sub dailyTable()
        Dim totUrun As String = ""
        Dim totAdet As Integer = 0
        Dim totTutar As Double = 0
        Try

            baglan.Open()
            komut.Connection = baglan
            komut.CommandType = CommandType.Text

            For i As Integer = 0 To DataGridView1.Rows.Count - 2
                totUrun = DataGridView1.Rows(i).Cells(1).Value
                totAdet = Convert.ToInt32(DataGridView1.Rows(i).Cells(2).Value)
                totTutar = Convert.ToDouble(DataGridView1.Rows(i).Cells(3).Value)

                komut.CommandText = "INSERT INTO dailyTable (Masa_No,Urun, Adet,Tarih,Tutar) values ('" & "Masa1" & "','" & totUrun & "','" & totAdet & "','" & DateTime.Today & "','" & totTutar & "')"
                komut.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MsgBox("Gunluk Tabloya Aktarilamadi")
        Finally
            baglan.Close()
        End Try


    End Sub

End Class