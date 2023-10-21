Imports System.IO
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient


Public Class KendaraanMasuk
    Dim sFileName As String = Application.StartupPath & "\DataKendaraanMasuk.txt"
    Private Sub GenerateTanggal_Click(sender As Object, e As EventArgs) Handles GenerateTanggal.TextChanged

    End Sub

    Private Sub GeneratePlatNomor_Click(sender As Object, e As EventArgs) Handles GeneratePlatNomor.TextChanged

    End Sub

    Private Sub GenerateTiketNo_Click(sender As Object, e As EventArgs) Handles GenerateTiketNo.TextChanged

    End Sub

    Private Sub GenerateJamMasuk_Click(sender As Object, e As EventArgs) Handles GenerateJamMasuk.TextChanged

    End Sub

    Private Sub GenerateJenisKendaraan_Click(sender As Object, e As EventArgs) Handles GenerateJenisKendaraan.TextChanged

    End Sub

    Private Sub KendaraanMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateTanggal.Text = TanggalHariIni
        GeneratePlatNomor.Text = PlatNomorKendaraan
        GenerateTiketNo.Text = NomorTiketKendaraan
        GenerateJamMasuk.Text = JamMasukKendaraan
        GenerateJenisKendaraan.Text = JenisKendaraanBermotor
        GenerateMemberNo.Text = NomorMember
    End Sub

    Private Sub ButtonKembali_Click(sender As Object, e As EventArgs) Handles ButtonKembali.Click
        MessageBox.Show("Menutup", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Me.Close()
    End Sub

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
        SimpanFile.Filter = "TXT Files (*.txt*)|*.txt"
        SimpanFile.ShowDialog()
        'Bagian Simpan data yang sudah terinput ke file Application.StartupPath'
        Dim myFileStream As New FileStream(sFileName, FileMode.Create, FileAccess.ReadWrite, FileShare.None)
        Dim myWriter As New StreamWriter(myFileStream)
        myWriter.WriteLine("Tanggal Hari Ini : " + GenerateTanggal.Text)
        myWriter.WriteLine("Plat Nomor Kendaraan : " + GeneratePlatNomor.Text)
        myWriter.WriteLine("Nomor Tiket Parkir : " + GenerateTiketNo.Text)
        myWriter.WriteLine("Jam Masuk kendaraan : " + GenerateJamMasuk.Text)
        myWriter.WriteLine("Jenis Kendaraan : " + GenerateJenisKendaraan.Text)
        myWriter.Flush()
        myWriter.Close()
        myFileStream.Close()
        GenerateTanggal.Text = GenerateTanggal.Text
        GeneratePlatNomor.Text = GeneratePlatNomor.Text
        GenerateTiketNo.Text = GenerateTiketNo.Text
        GenerateJamMasuk.Text = GenerateJamMasuk.Text
        GenerateJenisKendaraan.Text = GenerateJenisKendaraan.Text
        MessageBox.Show("Data Sudah Tersimpan!", "Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles ButtonPrint.Click
        PrintInformasi.ShowDialog()
        PrintKarcisMasuk.Print()
    End Sub

    Private Sub PrintKarcisMasuk_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintKarcisMasuk.PrintPage
        e.Graphics.DrawString("Karcis Parkir" + vbNewLine, Me.Font, Brushes.Black, 100, 100)
        e.Graphics.DrawString("Nomor Tiket Parkir : " + GenerateTiketNo.Text + vbNewLine, Me.Font, Brushes.Black, 100, 120)
        e.Graphics.DrawString("Tanggal Hari Ini : " + GenerateTanggal.Text + vbNewLine, Me.Font, Brushes.Black, 100, 140)
        e.Graphics.DrawString("Plat Nomor Kendaraan : " + GeneratePlatNomor.Text + vbNewLine, Me.Font, Brushes.Black, 100, 160)
        e.Graphics.DrawString("Jenis Kendaraan : " + GenerateJenisKendaraan.Text + vbNewLine, Me.Font, Brushes.Black, 100, 180)
        e.Graphics.DrawString("Jam Masuk kendaraan : " + GenerateJamMasuk.Text + vbNewLine, Me.Font, Brushes.Black, 100, 200)
        e.Graphics.DrawString("Mohon Simpan Karcis Parkir dengan baik" + vbNewLine, Me.Font, Brushes.Black, 100, 220)
        e.Graphics.DrawString("Jika Karcis hilang akan dikenakan denda Sebesar Rp. 100,000" + vbNewLine, Me.Font, Brushes.Black, 100, 240)
    End Sub

    Private Sub SimpanFile_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SimpanFile.FileOk
        Dim FileToSaveAs As String = SimpanFile.FileName

        Dim objwriter As New StreamWriter(FileToSaveAs)
        objwriter.Write("Tanggal Hari Ini : " + GenerateTanggal.Text + vbNewLine)
        objwriter.Write("Plat Nomor Kendaraan : " + GeneratePlatNomor.Text + vbNewLine)
        objwriter.Write("Nomor Tiket Parkir : " + GenerateTiketNo.Text + vbNewLine)
        objwriter.Write("Jam Masuk kendaraan : " + GenerateJamMasuk.Text + vbNewLine)
        objwriter.Write("Jenis Kendaraan : " + GenerateJenisKendaraan.Text + vbNewLine)
        objwriter.Close()
    End Sub

    Private Sub ButtonInsertDB_Click(sender As Object, e As EventArgs) Handles ButtonInsertDB.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=liko-x230;Initial Catalog=Parkir;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[DataKendaraanMasuk]
           ([TiketNo]
           ,[PlatNomorKendaraan]
           ,[MemberNo]
           ,[JamMasuk]
           ,[JenisKendaraan])
     VALUES
           ('" + GenerateTiketNo.Text + "',
           '" + GeneratePlatNomor.Text + "',
           '" + GenerateMemberNo.Text + "',
           '" + GenerateJamMasuk.Text + "',
           '" + GenerateJenisKendaraan.Text + "')", con)
        con.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data Telah Terinput", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()

    End Sub

    Private Sub GenerateMemberNo_Click(sender As Object, e As EventArgs) Handles GenerateMemberNo.Click

    End Sub
End Class