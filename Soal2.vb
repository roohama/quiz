Public Class Soal2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NIM As String
        Dim Nama As String
        Dim Kelas As String
        Dim UTS As Double
        Dim UAS As Double
        Dim Tugas As Double
        Dim Status As String
        Dim Nilai As Double

        NIM = TextBox1.Text
        Nama = TextBox2.Text
        Kelas = TextBox3.Text
        UTS = Val(TextBox4.Text)
        UAS = Val(TextBox5.Text)
        Tugas = Val(TextBox6.Text)
        Nilai = (0.3 * UTS + 0.5 * UAS + 0.2 * Tugas)

        If Nilai >= 60 Then
            Status = "Lulus"
        Else
            Status = "Tidak Lulus"
        End If

        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(NIM)
        listitem.SubItems.Add(Nama)
        listitem.SubItems.Add(Kelas)
        listitem.SubItems.Add(UTS)
        listitem.SubItems.Add(UAS)
        listitem.SubItems.Add(Tugas)
        listitem.SubItems.Add(Nilai)
        listitem.SubItems.Add(Status)


    End Sub

    Private Sub Soal2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("NIM", 110)
        ListView1.Columns.Add("NAMA", 110)
        ListView1.Columns.Add("KELAS", 110)
        ListView1.Columns.Add("NILAI UTS", 110)
        ListView1.Columns.Add("NILAI UAS", 110)
        ListView1.Columns.Add("NILAI TUGAS", 110)
        ListView1.Columns.Add("NILAI AKHIR", 110)
        ListView1.Columns.Add("STATUS", 110)
    End Sub
End Class