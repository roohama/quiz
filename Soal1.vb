Public Class Soal1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bil As Integer
        bil = TextBox1.Text
        If bil Mod 2 = 0 Then
            MsgBox("Bilangan Genap")
        Else
            MsgBox("Bilangan Ganjil")
        End If
    End Sub
End Class