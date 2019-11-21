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
End Class
