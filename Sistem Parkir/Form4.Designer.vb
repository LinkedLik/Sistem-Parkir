<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KendaraanKeluar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KendaraanKeluar))
        Me.GenerateTanggal = New System.Windows.Forms.Label()
        Me.GenerateJenisKendaraan = New System.Windows.Forms.Label()
        Me.GenerateJamMasuk = New System.Windows.Forms.Label()
        Me.GeneratePlatNomor = New System.Windows.Forms.Label()
        Me.GenerateTiketNo = New System.Windows.Forms.Label()
        Me.JenisKendaraan = New System.Windows.Forms.Label()
        Me.JamMasuk = New System.Windows.Forms.Label()
        Me.PlatNomor = New System.Windows.Forms.Label()
        Me.NomorTiket = New System.Windows.Forms.Label()
        Me.Header_Masuk = New System.Windows.Forms.Label()
        Me.GenerateJamKeluar = New System.Windows.Forms.Label()
        Me.JamKeluar = New System.Windows.Forms.Label()
        Me.Biaya = New System.Windows.Forms.Label()
        Me.GenerateBiaya = New System.Windows.Forms.Label()
        Me.PrintKarcisKeluar = New System.Drawing.Printing.PrintDocument()
        Me.InformasiPrint = New System.Windows.Forms.PrintDialog()
        Me.SimpanFile = New System.Windows.Forms.SaveFileDialog()
        Me.Durasi = New System.Windows.Forms.Label()
        Me.GenerateDurasiParkir = New System.Windows.Forms.Label()
        Me.GenerateMemberNo = New System.Windows.Forms.Label()
        Me.MemberNo = New System.Windows.Forms.Label()
        Me.ButtonInsertDB = New System.Windows.Forms.Button()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.ButtonKembali = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.GenerateExitNo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GenerateTanggal
        '
        Me.GenerateTanggal.AutoSize = True
        Me.GenerateTanggal.BackColor = System.Drawing.Color.White
        Me.GenerateTanggal.Font = New System.Drawing.Font("Bernard MT Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateTanggal.Location = New System.Drawing.Point(469, 19)
        Me.GenerateTanggal.Name = "GenerateTanggal"
        Me.GenerateTanggal.Size = New System.Drawing.Size(217, 38)
        Me.GenerateTanggal.TabIndex = 21
        Me.GenerateTanggal.Text = "Tanggal Hari Ini"
        '
        'GenerateJenisKendaraan
        '
        Me.GenerateJenisKendaraan.AutoSize = True
        Me.GenerateJenisKendaraan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GenerateJenisKendaraan.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateJenisKendaraan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GenerateJenisKendaraan.Location = New System.Drawing.Point(145, 187)
        Me.GenerateJenisKendaraan.Name = "GenerateJenisKendaraan"
        Me.GenerateJenisKendaraan.Size = New System.Drawing.Size(181, 18)
        Me.GenerateJenisKendaraan.TabIndex = 20
        Me.GenerateJenisKendaraan.Text = "Generate Jenis Kendaraan"
        '
        'GenerateJamMasuk
        '
        Me.GenerateJamMasuk.AutoSize = True
        Me.GenerateJamMasuk.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GenerateJamMasuk.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateJamMasuk.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GenerateJamMasuk.Location = New System.Drawing.Point(112, 150)
        Me.GenerateJamMasuk.Name = "GenerateJamMasuk"
        Me.GenerateJamMasuk.Size = New System.Drawing.Size(146, 18)
        Me.GenerateJamMasuk.TabIndex = 19
        Me.GenerateJamMasuk.Text = "Generate Jam Masuk"
        '
        'GeneratePlatNomor
        '
        Me.GeneratePlatNomor.AutoSize = True
        Me.GeneratePlatNomor.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GeneratePlatNomor.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneratePlatNomor.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GeneratePlatNomor.Location = New System.Drawing.Point(118, 112)
        Me.GeneratePlatNomor.Name = "GeneratePlatNomor"
        Me.GeneratePlatNomor.Size = New System.Drawing.Size(124, 18)
        Me.GeneratePlatNomor.TabIndex = 18
        Me.GeneratePlatNomor.Text = "Generate Plat No"
        '
        'GenerateTiketNo
        '
        Me.GenerateTiketNo.AutoSize = True
        Me.GenerateTiketNo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GenerateTiketNo.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateTiketNo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GenerateTiketNo.Location = New System.Drawing.Point(121, 72)
        Me.GenerateTiketNo.Name = "GenerateTiketNo"
        Me.GenerateTiketNo.Size = New System.Drawing.Size(130, 18)
        Me.GenerateTiketNo.TabIndex = 17
        Me.GenerateTiketNo.Text = "Generate Tiket No"
        '
        'JenisKendaraan
        '
        Me.JenisKendaraan.AutoSize = True
        Me.JenisKendaraan.BackColor = System.Drawing.Color.White
        Me.JenisKendaraan.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JenisKendaraan.Location = New System.Drawing.Point(23, 187)
        Me.JenisKendaraan.Name = "JenisKendaraan"
        Me.JenisKendaraan.Size = New System.Drawing.Size(123, 18)
        Me.JenisKendaraan.TabIndex = 16
        Me.JenisKendaraan.Text = "Jenis Kendaraan :"
        '
        'JamMasuk
        '
        Me.JamMasuk.AutoSize = True
        Me.JamMasuk.BackColor = System.Drawing.Color.White
        Me.JamMasuk.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JamMasuk.Location = New System.Drawing.Point(23, 150)
        Me.JamMasuk.Name = "JamMasuk"
        Me.JamMasuk.Size = New System.Drawing.Size(92, 18)
        Me.JamMasuk.TabIndex = 15
        Me.JamMasuk.Text = "Jam Masuk : "
        '
        'PlatNomor
        '
        Me.PlatNomor.AutoSize = True
        Me.PlatNomor.BackColor = System.Drawing.Color.White
        Me.PlatNomor.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlatNomor.Location = New System.Drawing.Point(23, 112)
        Me.PlatNomor.Name = "PlatNomor"
        Me.PlatNomor.Size = New System.Drawing.Size(96, 18)
        Me.PlatNomor.TabIndex = 14
        Me.PlatNomor.Text = "Plat Nomor : "
        '
        'NomorTiket
        '
        Me.NomorTiket.AutoSize = True
        Me.NomorTiket.BackColor = System.Drawing.Color.White
        Me.NomorTiket.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomorTiket.Location = New System.Drawing.Point(23, 72)
        Me.NomorTiket.Name = "NomorTiket"
        Me.NomorTiket.Size = New System.Drawing.Size(98, 18)
        Me.NomorTiket.TabIndex = 13
        Me.NomorTiket.Text = "Nomor Tiket :"
        '
        'Header_Masuk
        '
        Me.Header_Masuk.AutoSize = True
        Me.Header_Masuk.BackColor = System.Drawing.Color.White
        Me.Header_Masuk.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header_Masuk.Location = New System.Drawing.Point(22, 19)
        Me.Header_Masuk.Name = "Header_Masuk"
        Me.Header_Masuk.Size = New System.Drawing.Size(163, 23)
        Me.Header_Masuk.TabIndex = 12
        Me.Header_Masuk.Text = "Info Kendaraan Keluar : "
        '
        'GenerateJamKeluar
        '
        Me.GenerateJamKeluar.AutoSize = True
        Me.GenerateJamKeluar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GenerateJamKeluar.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateJamKeluar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GenerateJamKeluar.Location = New System.Drawing.Point(112, 222)
        Me.GenerateJamKeluar.Name = "GenerateJamKeluar"
        Me.GenerateJamKeluar.Size = New System.Drawing.Size(147, 18)
        Me.GenerateJamKeluar.TabIndex = 25
        Me.GenerateJamKeluar.Text = "Generate Jam Keluar"
        '
        'JamKeluar
        '
        Me.JamKeluar.AutoSize = True
        Me.JamKeluar.BackColor = System.Drawing.Color.White
        Me.JamKeluar.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JamKeluar.Location = New System.Drawing.Point(23, 222)
        Me.JamKeluar.Name = "JamKeluar"
        Me.JamKeluar.Size = New System.Drawing.Size(93, 18)
        Me.JamKeluar.TabIndex = 24
        Me.JamKeluar.Text = "Jam Keluar : "
        '
        'Biaya
        '
        Me.Biaya.AutoSize = True
        Me.Biaya.BackColor = System.Drawing.Color.White
        Me.Biaya.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Biaya.Location = New System.Drawing.Point(360, 94)
        Me.Biaya.Name = "Biaya"
        Me.Biaya.Size = New System.Drawing.Size(55, 18)
        Me.Biaya.TabIndex = 26
        Me.Biaya.Text = "Biaya :"
        '
        'GenerateBiaya
        '
        Me.GenerateBiaya.AutoSize = True
        Me.GenerateBiaya.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GenerateBiaya.Font = New System.Drawing.Font("Berlin Sans FB", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateBiaya.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GenerateBiaya.Location = New System.Drawing.Point(360, 112)
        Me.GenerateBiaya.Name = "GenerateBiaya"
        Me.GenerateBiaya.Size = New System.Drawing.Size(208, 35)
        Me.GenerateBiaya.TabIndex = 27
        Me.GenerateBiaya.Text = "Generate Tarif"
        '
        'PrintKarcisKeluar
        '
        '
        'InformasiPrint
        '
        Me.InformasiPrint.UseEXDialog = True
        '
        'SimpanFile
        '
        '
        'Durasi
        '
        Me.Durasi.AutoSize = True
        Me.Durasi.BackColor = System.Drawing.Color.White
        Me.Durasi.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Durasi.Location = New System.Drawing.Point(360, 169)
        Me.Durasi.Name = "Durasi"
        Me.Durasi.Size = New System.Drawing.Size(102, 18)
        Me.Durasi.TabIndex = 31
        Me.Durasi.Text = "Durasi Parkir :"
        '
        'GenerateDurasiParkir
        '
        Me.GenerateDurasiParkir.AutoSize = True
        Me.GenerateDurasiParkir.BackColor = System.Drawing.Color.Black
        Me.GenerateDurasiParkir.Font = New System.Drawing.Font("Berlin Sans FB", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateDurasiParkir.ForeColor = System.Drawing.Color.White
        Me.GenerateDurasiParkir.Location = New System.Drawing.Point(361, 188)
        Me.GenerateDurasiParkir.Name = "GenerateDurasiParkir"
        Me.GenerateDurasiParkir.Size = New System.Drawing.Size(326, 35)
        Me.GenerateDurasiParkir.TabIndex = 32
        Me.GenerateDurasiParkir.Text = "Generate Durasi Parkir"
        '
        'GenerateMemberNo
        '
        Me.GenerateMemberNo.AutoSize = True
        Me.GenerateMemberNo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GenerateMemberNo.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateMemberNo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GenerateMemberNo.Location = New System.Drawing.Point(112, 257)
        Me.GenerateMemberNo.Name = "GenerateMemberNo"
        Me.GenerateMemberNo.Size = New System.Drawing.Size(151, 18)
        Me.GenerateMemberNo.TabIndex = 38
        Me.GenerateMemberNo.Text = "Generate Member No"
        '
        'MemberNo
        '
        Me.MemberNo.AutoSize = True
        Me.MemberNo.BackColor = System.Drawing.Color.White
        Me.MemberNo.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberNo.Location = New System.Drawing.Point(22, 257)
        Me.MemberNo.Name = "MemberNo"
        Me.MemberNo.Size = New System.Drawing.Size(97, 18)
        Me.MemberNo.TabIndex = 37
        Me.MemberNo.Text = "Member No : "
        '
        'ButtonInsertDB
        '
        Me.ButtonInsertDB.BackColor = System.Drawing.Color.PaleGreen
        Me.ButtonInsertDB.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInsertDB.Image = CType(resources.GetObject("ButtonInsertDB.Image"), System.Drawing.Image)
        Me.ButtonInsertDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonInsertDB.Location = New System.Drawing.Point(328, 301)
        Me.ButtonInsertDB.Name = "ButtonInsertDB"
        Me.ButtonInsertDB.Size = New System.Drawing.Size(116, 41)
        Me.ButtonInsertDB.TabIndex = 36
        Me.ButtonInsertDB.Text = "Masukan Ke Database"
        Me.ButtonInsertDB.UseVisualStyleBackColor = False
        '
        'ButtonPrint
        '
        Me.ButtonPrint.BackColor = System.Drawing.Color.PaleGreen
        Me.ButtonPrint.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrint.Image = CType(resources.GetObject("ButtonPrint.Image"), System.Drawing.Image)
        Me.ButtonPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPrint.Location = New System.Drawing.Point(476, 301)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(120, 41)
        Me.ButtonPrint.TabIndex = 29
        Me.ButtonPrint.Text = "Cetak Karcis Keluar"
        Me.ButtonPrint.UseVisualStyleBackColor = False
        '
        'ButtonKembali
        '
        Me.ButtonKembali.BackColor = System.Drawing.Color.Tomato
        Me.ButtonKembali.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonKembali.Image = CType(resources.GetObject("ButtonKembali.Image"), System.Drawing.Image)
        Me.ButtonKembali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonKembali.Location = New System.Drawing.Point(26, 301)
        Me.ButtonKembali.Name = "ButtonKembali"
        Me.ButtonKembali.Size = New System.Drawing.Size(120, 41)
        Me.ButtonKembali.TabIndex = 23
        Me.ButtonKembali.Text = "Kembali"
        Me.ButtonKembali.UseVisualStyleBackColor = False
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.BackColor = System.Drawing.Color.PaleGreen
        Me.ButtonSimpan.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSimpan.Image = CType(resources.GetObject("ButtonSimpan.Image"), System.Drawing.Image)
        Me.ButtonSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSimpan.Location = New System.Drawing.Point(179, 301)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(116, 41)
        Me.ButtonSimpan.TabIndex = 22
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = False
        '
        'GenerateExitNo
        '
        Me.GenerateExitNo.AutoSize = True
        Me.GenerateExitNo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GenerateExitNo.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateExitNo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GenerateExitNo.Location = New System.Drawing.Point(180, 19)
        Me.GenerateExitNo.Name = "GenerateExitNo"
        Me.GenerateExitNo.Size = New System.Drawing.Size(158, 23)
        Me.GenerateExitNo.TabIndex = 39
        Me.GenerateExitNo.Text = "Generate Exit No"
        '
        'KendaraanKeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(698, 370)
        Me.Controls.Add(Me.GenerateExitNo)
        Me.Controls.Add(Me.GenerateMemberNo)
        Me.Controls.Add(Me.MemberNo)
        Me.Controls.Add(Me.ButtonInsertDB)
        Me.Controls.Add(Me.GenerateDurasiParkir)
        Me.Controls.Add(Me.Durasi)
        Me.Controls.Add(Me.ButtonPrint)
        Me.Controls.Add(Me.GenerateBiaya)
        Me.Controls.Add(Me.Biaya)
        Me.Controls.Add(Me.GenerateJamKeluar)
        Me.Controls.Add(Me.JamKeluar)
        Me.Controls.Add(Me.ButtonKembali)
        Me.Controls.Add(Me.ButtonSimpan)
        Me.Controls.Add(Me.GenerateTanggal)
        Me.Controls.Add(Me.GenerateJenisKendaraan)
        Me.Controls.Add(Me.GenerateJamMasuk)
        Me.Controls.Add(Me.GeneratePlatNomor)
        Me.Controls.Add(Me.GenerateTiketNo)
        Me.Controls.Add(Me.JenisKendaraan)
        Me.Controls.Add(Me.JamMasuk)
        Me.Controls.Add(Me.PlatNomor)
        Me.Controls.Add(Me.NomorTiket)
        Me.Controls.Add(Me.Header_Masuk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KendaraanKeluar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonKembali As Button
    Friend WithEvents ButtonSimpan As Button
    Friend WithEvents GenerateTanggal As Label
    Friend WithEvents GenerateJenisKendaraan As Label
    Friend WithEvents GenerateJamMasuk As Label
    Friend WithEvents GeneratePlatNomor As Label
    Friend WithEvents GenerateTiketNo As Label
    Friend WithEvents JenisKendaraan As Label
    Friend WithEvents JamMasuk As Label
    Friend WithEvents PlatNomor As Label
    Friend WithEvents NomorTiket As Label
    Friend WithEvents Header_Masuk As Label
    Friend WithEvents GenerateJamKeluar As Label
    Friend WithEvents JamKeluar As Label
    Friend WithEvents Biaya As Label
    Friend WithEvents GenerateBiaya As Label
    Friend WithEvents PrintKarcisKeluar As Printing.PrintDocument
    Friend WithEvents ButtonPrint As Button
    Friend WithEvents InformasiPrint As PrintDialog
    Friend WithEvents SimpanFile As SaveFileDialog
    Friend WithEvents Durasi As Label
    Friend WithEvents GenerateDurasiParkir As Label
    Friend WithEvents ButtonInsertDB As Button
    Friend WithEvents GenerateMemberNo As Label
    Friend WithEvents MemberNo As Label
    Friend WithEvents GenerateExitNo As Label
End Class
