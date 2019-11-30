Public Class Giris
    Private Sub btnGiris_Click(sender As Object, e As EventArgs) Handles btnGiris.Click
        Dim id As String
        Dim pass As Integer
        id = txtId.Text
        pass = txtPass.Text
        If id = "celik" And pass = 1234 Then
            Me.Hide()
            Masalar.Show()

        Else
            MsgBox("Kullanici adi veya sifre hatali")
        End If




    End Sub

    Private Sub Giris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(200, 100)
    End Sub
End Class
