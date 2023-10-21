Public Class Aplikasi
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UsernameGenerate_Click(sender As Object, e As EventArgs) Handles UsernameGenerate.Click

    End Sub

    Private Sub Aplikasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsernameGenerate.Text = UsernameInput
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles BoxInformasi.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles LabelNoTiket.Click

    End Sub

    Private Sub ButtonMasuk_Click(sender As Object, e As EventArgs) Handles ButtonMasuk.Click
        MessageBox.Show("Data Tersimpan! ", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        KendaraanMasuk.Show()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub TanggalSekarang_ValueChanged(sender As Object, e As EventArgs) Handles TanggalSekarang.ValueChanged
        TanggalHariIni = TanggalSekarang.Text
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles BoxNomorTiket.TextChanged
        NomorTiketKendaraan = BoxNomorTiket.Text
    End Sub

    Private Sub BoxPlatNomor_TextChanged(sender As Object, e As EventArgs) Handles BoxPlatNomor.TextChanged
        PlatNomorKendaraan = BoxPlatNomor.Text
    End Sub

    Private Sub BoxJenisKendaraan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BoxJenisKendaraan.SelectedIndexChanged
        JenisKendaraanBermotor = BoxJenisKendaraan.Text
    End Sub

    Private Sub JamMasuk_ValueChanged(sender As Object, e As EventArgs) Handles JamMasuk.ValueChanged
        JamMasukKendaraan = JamMasuk.Text
    End Sub

    Private Sub BoxTarifPerjam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BoxTarifPerjam.SelectedIndexChanged
        TarifMasukKendaraan = BoxTarifPerjam.Text
    End Sub

    Private Sub JamKeluar_ValueChanged(sender As Object, e As EventArgs) Handles JamKeluar.ValueChanged
        JamKeluarKendaraan = JamKeluar.Text
    End Sub

    Private Sub ButtonKeluar_Click(sender As Object, e As EventArgs) Handles ButtonKeluar.Click
        MessageBox.Show("Data Tersimpan! ", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        KendaraanKeluar.Show()
    End Sub

    Private Sub DurasiParkir_TextChanged(sender As Object, e As EventArgs) Handles DurasiParkir.TextChanged
        DurasiJamParkir = DurasiParkir.Text
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        MessageBox.Show("Anda akan Logout", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        MenuParkir.Show()
        Me.Close()
    End Sub

    Private Sub ButtonDaftarMember_Click(sender As Object, e As EventArgs) Handles ButtonDaftarMember.Click
        DaftarMember.Show()
    End Sub

    Private Sub ButtonBukaDatabase_Click(sender As Object, e As EventArgs) Handles ButtonBukaDatabase.Click
        ViewDB.Show()
    End Sub

    Private Sub MemberNo_TextChanged(sender As Object, e As EventArgs) Handles MemberNo.TextChanged
        NomorMember = MemberNo.Text
    End Sub

    Private Sub ExitNo_TextChanged(sender As Object, e As EventArgs) Handles ExitNo.TextChanged
        NomorKeluartiket = ExitNo.Text
    End Sub
End Class