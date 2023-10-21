Imports System.ComponentModel
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Public Class KendaraanKeluar
    Dim sFileName As String = Application.StartupPath & "\DataKendaraanKeluar.txt"
    Private Sub KendaraanKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateTanggal.Text = TanggalHariIni
        GeneratePlatNomor.Text = PlatNomorKendaraan
        GenerateTiketNo.Text = NomorTiketKendaraan
        GenerateJamMasuk.Text = JamMasukKendaraan
        GenerateJenisKendaraan.Text = JenisKendaraanBermotor
        GenerateJamKeluar.Text = JamKeluarKendaraan
        GenerateBiaya.Text = TarifMasukKendaraan
        GenerateDurasiParkir.Text = DurasiJamParkir
        GenerateMemberNo.Text = NomorMember
        GenerateExitNo.Text = NomorKeluartiket
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
        myWriter.WriteLine("Jam Keluar Kendaraan : " + GenerateJamKeluar.Text)
        myWriter.WriteLine("Biaya Parkir Kendaraan : " + GenerateBiaya.Text)
        myWriter.WriteLine("Lama Parkir Kendaraan : " + GenerateDurasiParkir.Text)
        myWriter.Flush()
        myWriter.Close()
        myFileStream.Close()
        GenerateTanggal.Text = GenerateTanggal.Text
        GeneratePlatNomor.Text = GeneratePlatNomor.Text
        GenerateTiketNo.Text = GenerateTiketNo.Text
        GenerateJamMasuk.Text = GenerateJamMasuk.Text
        GenerateJenisKendaraan.Text = GenerateJenisKendaraan.Text
        GenerateJamKeluar.Text = GenerateJamKeluar.Text
        GenerateBiaya.Text = GenerateBiaya.Text
        GenerateDurasiParkir.Text = GenerateDurasiParkir.Text
        MessageBox.Show("Data Sudah Tersimpan!", "Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintKarcisKeluar.PrintPage
        e.Graphics.DrawString("Invoice Keluar Parkir" + vbNewLine, Me.Font, Brushes.Black, 100, 100)
        e.Graphics.DrawString("Nomor Tiket Parkir : " + GenerateTiketNo.Text + vbNewLine, Me.Font, Brushes.Black, 100, 120)
        e.Graphics.DrawString("Tanggal Hari Ini : " + GenerateTanggal.Text + vbNewLine, Me.Font, Brushes.Black, 100, 140)
        e.Graphics.DrawString("Plat Nomor Kendaraan : " + GeneratePlatNomor.Text + vbNewLine, Me.Font, Brushes.Black, 100, 160)
        e.Graphics.DrawString("Jenis Kendaraan : " + GenerateJenisKendaraan.Text + vbNewLine, Me.Font, Brushes.Black, 100, 180)
        e.Graphics.DrawString("Jam Masuk kendaraan : " + GenerateJamMasuk.Text + vbNewLine, Me.Font, Brushes.Black, 100, 200)
        e.Graphics.DrawString("Jam Keluar Kendaraan : " + GenerateJamKeluar.Text + vbNewLine, Me.Font, Brushes.Black, 100, 220)
        e.Graphics.DrawString("Lama Parkir Kendaraan : " + GenerateDurasiParkir.Text + vbNewLine, Me.Font, Brushes.Black, 100, 240)
        e.Graphics.DrawString("Biaya Parkir Kendaraan : " + GenerateBiaya.Text + vbNewLine, Me.Font, Brushes.Black, 100, 260)
        e.Graphics.DrawString("Terima Kasih!", Me.Font, Brushes.Black, 100, 280)
    End Sub

    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles ButtonPrint.Click
        InformasiPrint.ShowDialog()
        PrintKarcisKeluar.Print()
    End Sub

    Private Sub SimpanFile_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SimpanFile.FileOk
        Dim FileToSaveAs As String = SimpanFile.FileName

        Dim objwriter As New StreamWriter(FileToSaveAs)
        objwriter.Write("Tanggal Hari Ini : " + GenerateTanggal.Text + vbNewLine)
        objwriter.Write("Plat Nomor Kendaraan : " + GeneratePlatNomor.Text + vbNewLine)
        objwriter.Write("Nomor Tiket Parkir : " + GenerateTiketNo.Text + vbNewLine)
        objwriter.Write("Jam Masuk kendaraan : " + GenerateJamMasuk.Text + vbNewLine)
        objwriter.Write("Jenis Kendaraan : " + GenerateJenisKendaraan.Text + vbNewLine)
        objwriter.Write("Jam Keluar Kendaraan : " + GenerateJamKeluar.Text + vbNewLine)
        objwriter.Write("Lama Parkir Kendaran : " + GenerateDurasiParkir.Text + vbNewLine)
        objwriter.Write("Biaya Parkir Kendaraan : " + GenerateBiaya.Text + vbNewLine)
        objwriter.Close()

    End Sub

    Private Sub GenerateDurasiParkir_Click(sender As Object, e As EventArgs) Handles GenerateDurasiParkir.TextChanged
        GenerateDurasiParkir.Text = DurasiJamParkir
    End Sub

    Private Sub GenerateMemberNo_Click(sender As Object, e As EventArgs) Handles GenerateMemberNo.Click
        GenerateMemberNo.Text = NomorMember
    End Sub

    Private Sub ButtonInsertDB_Click(sender As Object, e As EventArgs) Handles ButtonInsertDB.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=liko-x230;Initial Catalog=Parkir;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[DataKendaraanKeluar]
           ([ExitNo]
           ,[TiketNo]
           ,[PlatNomorKendaraan]
           ,[JamMasuk]
           ,[JamKeluar]
           ,[JenisKendaraan]
           ,[MemberNo])
     VALUES
           ('" + GenerateExitNo.Text + "',
           '" + GenerateTiketNo.Text + "',
           '" + GeneratePlatNomor.Text + "',
           '" + GenerateJamMasuk.Text + "',
           '" + GenerateJamKeluar.Text + "',
           '" + GenerateJenisKendaraan.Text + "',
           '" + GenerateMemberNo.Text + "')", con)
        con.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data Telah Terinput", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GenerateExitNo_Click(sender As Object, e As EventArgs) Handles GenerateExitNo.Click
        GenerateExitNo.Text = NomorKeluartiket
    End Sub
End Class