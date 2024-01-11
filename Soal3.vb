Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Soal3
    Private Sub Soal3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("NO ID", 110)
        ListView1.Columns.Add("NAMA", 110)
        ListView1.Columns.Add("NO HP", 110)
        ListView1.Columns.Add("JENIS KELAMIN", 110)
        ListView1.Columns.Add("JENIS LAYANAN", 110)
        ListView1.Columns.Add("LAMA MENGINAP", 110)
        ListView1.Columns.Add("BIAYA SEWA", 110)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Id As String
        Dim Nama As String
        Dim Hp As String
        Dim Kelamin As String
        Dim Layanan As String
        Dim Lama As Integer
        Dim Biaya As Integer
        Dim Tambahan As Integer
        Dim Total As Integer


        Id = TextBox1.Text
        Nama = TextBox2.Text
        Hp = TextBox3.Text
        Kelamin = ComboBox1.Text
        Layanan = ComboBox2.Text
        Lama = Val(TextBox4.Text)


        If Layanan = "Standard Room" Then
            Biaya = 200000 * Lama
            Tambahan = 0
        ElseIf Layanan = "Superior Room" Then
            Biaya = 300000 * Lama
            Tambahan = 0
        ElseIf Layanan = "Deluxe Room" Then
            Biaya = 350000 * Lama
            Tambahan = 0
        Else
            Biaya = 550000 * Lama
            Tambahan = 20000 * Lama

        End If

        Total = Biaya + Tambahan

        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(Id)
        listitem.SubItems.Add(Nama)
        listitem.SubItems.Add(Hp)
        listitem.SubItems.Add(Kelamin)
        listitem.SubItems.Add(Layanan)
        listitem.SubItems.Add(Lama)
        listitem.SubItems.Add(Total)

    End Sub
End Class