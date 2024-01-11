Public Class Soal4
    Private Sub Soal4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("NO ID", 110)
        ListView1.Columns.Add("NAMA", 110)
        ListView1.Columns.Add("NO HP", 110)
        ListView1.Columns.Add("JENIS MOBIL", 110)
        ListView1.Columns.Add("JENIS LAYANAN", 110)
        ListView1.Columns.Add("LAMA SEWA", 110)
        ListView1.Columns.Add("BIAYA SEWA", 110)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Id As String
        Dim Nama As String
        Dim Hp As String
        Dim Mobil As String
        Dim Layanan As String
        Dim Lama As Integer
        Dim Biaya As Integer
        Dim Tambahan As Integer
        Dim Total As Integer


        Id = TextBox1.Text
        Nama = TextBox2.Text
        Hp = TextBox3.Text
        Mobil = ComboBox1.Text
        Layanan = ComboBox2.Text
        Lama = TextBox4.Text


        If Mobil = "Toyota Avanza" Then
            Biaya = 240000 * Lama

        ElseIf Mobil = "Toyota Calya" Then
            Biaya = 210000 * Lama

        ElseIf Mobil = "Toyota Inova" Then
            Biaya = 340000 * Lama

        ElseIf Mobil = "Daihatsu Xenia" Then
            Biaya = 230000 * Lama

        ElseIf Mobil = "Daihatsu Sigra" Then
            Biaya = 200000 * Lama

        ElseIf Mobil = "Honda Brio" Then
            Biaya = 230000 * Lama

        ElseIf Mobil = "Honda Mobilio" Then
            Biaya = 240000 * Lama

        Else
            Biaya = 300000 * Lama

        End If

        If Layanan = "Sopir" Then
            Tambahan = 150000 * Lama
        End If

        Total = Biaya + Tambahan

        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(Id)
        listitem.SubItems.Add(Nama)
        listitem.SubItems.Add(Hp)
        listitem.SubItems.Add(Mobil)
        listitem.SubItems.Add(Layanan)
        listitem.SubItems.Add(Lama)
        listitem.SubItems.Add(Total)
    End Sub
End Class