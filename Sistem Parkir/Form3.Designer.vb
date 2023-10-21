<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KendaraanMasuk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KendaraanMasuk))
        Me.Header_Masuk = New System.Windows.Forms.Label()
        Me.NomorTiket = New System.Windows.Forms.Label()
        Me.PlatNomor = New System.Windows.Forms.Label()
        Me.JamMasuk = New System.Windows.Forms.Label()
        Me.JenisKendaraan = New System.Windows.Forms.Label()
        Me.GenerateTiketNo = New System.Windows.Forms.Label()
        Me.GeneratePlatNomor = New System.Windows.Forms.Label()
        Me.GenerateJamMasuk = New System.Windows.Forms.Label()
        Me.GenerateJenisKendaraan = New System.Windows.Forms.Label()
        Me.GenerateTanggal = New System.Windows.Forms.Label()
        Me.PrintKarcisMasuk = New System.Drawing.Printing.PrintDocument()
        Me.PrintInformasi = New System.Windows.Forms.PrintDialog()
        Me.SimpanFile = New System.Windows.Forms.SaveFileDialog()
        Me.Perhatian = New System.Windows.Forms.Label()
        Me.SimpanTiket = New System.Windows.Forms.Label()
        Me.KehilanganTiket = New System.Windows.Forms.Label()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.ButtonKembali = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.ButtonInsertDB = New System.Windows.Forms.Button()
        Me.GenerateMemberNo = New System.Windows.Forms.Label()
        Me.MemberNo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Header_Masuk
        '
        Me.Header_Masuk.AutoSize = True
        Me.Header_Masuk.BackColor = System.Drawing.Color.White
        Me.Header_Masuk.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header_Masuk.Location = New System.Drawing.Point(23, 19)
        Me.Header_Masuk.Name = "Header_Masuk"
        Me.Header_Masuk.Size = New System.Drawing.Size(164, 23)
        Me.Header_Masuk.TabIndex = 0
        Me.Header_Masuk.Text = "Info Kendaraan Masuk : "
        '
        'NomorTiket
        '
        Me.NomorTiket.AutoSize = True
        Me.NomorTiket.BackColor = System.Drawing.Color.White
        Me.NomorTiket.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomorTiket.Location = New System.Drawing.Point(24, 72)
        Me.NomorTiket.Name = "NomorTiket"
        Me.NomorTiket.Size = New System.Drawing.Size(98, 18)
        Me.NomorTiket.TabIndex = 1
        Me.NomorTiket.Text = "Nomor Tiket :"
        '
        'PlatNomor
        '
        Me.PlatNomor.AutoSize = True
        Me.PlatNomor.BackColor = System.Drawing.Color.White
        Me.PlatNomor.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlatNomor.Location = New System.Drawing.Point(24, 112)
        Me.PlatNomor.Name = "PlatNomor"
        Me.PlatNomor.Size = New System.Drawing.Size(96, 18)
        Me.PlatNomor.TabIndex = 2
        Me.PlatNomor.Text = "Plat Nomor : "
        '
        'JamMasuk
        '
        Me.JamMasuk.AutoSize = True
        Me.JamMasuk.BackColor = System.Drawing.Color.White
        Me.JamMasuk.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JamMasuk.Location = New System.Drawing.Point(24, 150)
        Me.JamMasuk.Name = "JamMasuk"
        Me.JamMasuk.Size = New System.Drawing.Size(92, 18)
        Me.JamMasuk.TabIndex = 3
        Me.JamMasuk.Text = "Jam Masuk : "
        '
        'JenisKendaraan
        '
        Me.JenisKendaraan.AutoSize = True
        Me.JenisKendaraan.BackColor = System.Drawing.Color.White
        Me.JenisKendaraan.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JenisKendaraan.Location = New System.Drawing.Point(24, 187)
        Me.JenisKendaraan.Name = "JenisKendaraan"
        Me.JenisKendaraan.Size = New System.Drawing.Size(123, 18)
        Me.JenisKendaraan.TabIndex = 4
        Me.JenisKendaraan.Text = "Jenis Kendaraan :"
        '
        'GenerateTiketNo
        '
        Me.GenerateTiketNo.AutoSize = True
        Me.GenerateTiketNo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GenerateTiketNo.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateTiketNo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GenerateTiketNo.Location = New System.Drawing.Point(122, 72)
        Me.GenerateTiketNo.Name = "GenerateTiketNo"
        Me.GenerateTiketNo.Size = New System.Drawing.Size(130, 18)
        Me.GenerateTiketNo.TabIndex = 5
        Me.GenerateTiketNo.Text = "Generate Tiket No"
        '
        'GeneratePlatNomor
        '
        Me.GeneratePlatNomor.AutoSize = True
        Me.GeneratePlatNomor.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GeneratePlatNomor.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneratePlatNomor.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GeneratePlatNomor.Location = New System.Drawing.Point(119, 112)
        Me.GeneratePlatNomor.Name = "GeneratePlatNomor"
        Me.GeneratePlatNomor.Size = New System.Drawing.Size(124, 18)
        Me.GeneratePlatNomor.TabIndex = 6
        Me.GeneratePlatNomor.Text = "Generate Plat No"
        '
        'GenerateJamMasuk
        '
        Me.GenerateJamMasuk.AutoSize = True
        Me.GenerateJamMasuk.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GenerateJamMasuk.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateJamMasuk.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GenerateJamMasuk.Location = New System.Drawing.Point(113, 150)
        Me.GenerateJamMasuk.Name = "GenerateJamMasuk"
        Me.GenerateJamMasuk.Size = New System.Drawing.Size(146, 18)
        Me.GenerateJamMasuk.TabIndex = 7
        Me.GenerateJamMasuk.Text = "Generate Jam Masuk"
        '
        'GenerateJenisKendaraan
        '
        Me.GenerateJenisKendaraan.AutoSize = True
        Me.GenerateJenisKendaraan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GenerateJenisKendaraan.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateJenisKendaraan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GenerateJenisKendaraan.Location = New System.Drawing.Point(146, 187)
        Me.GenerateJenisKendaraan.Name = "GenerateJenisKendaraan"
        Me.GenerateJenisKendaraan.Size = New System.Drawing.Size(181, 18)
        Me.GenerateJenisKendaraan.TabIndex = 8
        Me.GenerateJenisKendaraan.Text = "Generate Jenis Kendaraan"
        '
        'GenerateTanggal
        '
        Me.GenerateTanggal.AutoSize = True
        Me.GenerateTanggal.Font = New System.Drawing.Font("Bernard MT Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateTanggal.Location = New System.Drawing.Point(410, 19)
        Me.GenerateTanggal.Name = "GenerateTanggal"
        Me.GenerateTanggal.Size = New System.Drawing.Size(217, 38)
        Me.GenerateTanggal.TabIndex = 9
        Me.GenerateTanggal.Text = "Tanggal Hari Ini"
        '
        'PrintKarcisMasuk
        '
        '
        'PrintInformasi
        '
        Me.PrintInformasi.UseEXDialog = True
        '
        'SimpanFile
        '
        '
        'Perhatian
        '
        Me.Perhatian.AutoSize = True
        Me.Perhatian.Font = New System.Drawing.Font("Berlin Sans FB", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Perhatian.Location = New System.Drawing.Point(436, 115)
        Me.Perhatian.Name = "Perhatian"
        Me.Perhatian.Size = New System.Drawing.Size(156, 35)
        Me.Perhatian.TabIndex = 32
        Me.Perhatian.Text = "Perhatian!"
        '
        'SimpanTiket
        '
        Me.SimpanTiket.AutoSize = True
        Me.SimpanTiket.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpanTiket.Location = New System.Drawing.Point(370, 150)
        Me.SimpanTiket.Name = "SimpanTiket"
        Me.SimpanTiket.Size = New System.Drawing.Size(283, 21)
        Me.SimpanTiket.TabIndex = 33
        Me.SimpanTiket.Text = "Simpan Tiket Masuk Dengan Baik"
        '
        'KehilanganTiket
        '
        Me.KehilanganTiket.AutoSize = True
        Me.KehilanganTiket.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KehilanganTiket.Location = New System.Drawing.Point(345, 171)
        Me.KehilanganTiket.Name = "KehilanganTiket"
        Me.KehilanganTiket.Size = New System.Drawing.Size(342, 21)
        Me.KehilanganTiket.TabIndex = 34
        Me.KehilanganTiket.Text = "Kehilangan Tiket akan dikenakan Denda"
        '
        'ButtonPrint
        '
        Me.ButtonPrint.BackColor = System.Drawing.Color.PaleGreen
        Me.ButtonPrint.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrint.Image = CType(resources.GetObject("ButtonPrint.Image"), System.Drawing.Image)
        Me.ButtonPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPrint.Location = New System.Drawing.Point(472, 310)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(120, 41)
        Me.ButtonPrint.TabIndex = 30
        Me.ButtonPrint.Text = "Cetak Karcis Masuk"
        Me.ButtonPrint.UseVisualStyleBackColor = False
        '
        'ButtonKembali
        '
        Me.ButtonKembali.BackColor = System.Drawing.Color.Tomato
        Me.ButtonKembali.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonKembali.Image = CType(resources.GetObject("ButtonKembali.Image"), System.Drawing.Image)
        Me.ButtonKembali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonKembali.Location = New System.Drawing.Point(27, 310)
        Me.ButtonKembali.Name = "ButtonKembali"
        Me.ButtonKembali.Size = New System.Drawing.Size(120, 41)
        Me.ButtonKembali.TabIndex = 11
        Me.ButtonKembali.Text = "Kembali"
        Me.ButtonKembali.UseVisualStyleBackColor = False
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.BackColor = System.Drawing.Color.PaleGreen
        Me.ButtonSimpan.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSimpan.Image = CType(resources.GetObject("ButtonSimpan.Image"), System.Drawing.Image)
        Me.ButtonSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSimpan.Location = New System.Drawing.Point(179, 310)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(116, 41)
        Me.ButtonSimpan.TabIndex = 10
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = False
        '
        'ButtonInsertDB
        '
        Me.ButtonInsertDB.BackColor = System.Drawing.Color.PaleGreen
        Me.ButtonInsertDB.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInsertDB.Image = CType(resources.GetObject("ButtonInsertDB.Image"), System.Drawing.Image)
        Me.ButtonInsertDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonInsertDB.Location = New System.Drawing.Point(325, 310)
        Me.ButtonInsertDB.Name = "ButtonInsertDB"
        Me.ButtonInsertDB.Size = New System.Drawing.Size(116, 41)
        Me.ButtonInsertDB.TabIndex = 35
        Me.ButtonInsertDB.Text = "Masukan Ke Database"
        Me.ButtonInsertDB.UseVisualStyleBackColor = False
        '
        'GenerateMemberNo
        '
        Me.GenerateMemberNo.AutoSize = True
        Me.GenerateMemberNo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GenerateMemberNo.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateMemberNo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GenerateMemberNo.Location = New System.Drawing.Point(113, 225)
        Me.GenerateMemberNo.Name = "GenerateMemberNo"
        Me.GenerateMemberNo.Size = New System.Drawing.Size(151, 18)
        Me.GenerateMemberNo.TabIndex = 40
        Me.GenerateMemberNo.Text = "Generate Member No"
        '
        'MemberNo
        '
        Me.MemberNo.AutoSize = True
        Me.MemberNo.BackColor = System.Drawing.Color.White
        Me.MemberNo.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberNo.Location = New System.Drawing.Point(23, 225)
        Me.MemberNo.Name = "MemberNo"
        Me.MemberNo.Size = New System.Drawing.Size(97, 18)
        Me.MemberNo.TabIndex = 39
        Me.MemberNo.Text = "Member No : "
        '
        'KendaraanMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(699, 376)
        Me.Controls.Add(Me.GenerateMemberNo)
        Me.Controls.Add(Me.MemberNo)
        Me.Controls.Add(Me.ButtonInsertDB)
        Me.Controls.Add(Me.KehilanganTiket)
        Me.Controls.Add(Me.SimpanTiket)
        Me.Controls.Add(Me.Perhatian)
        Me.Controls.Add(Me.ButtonPrint)
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
        Me.Name = "KendaraanMasuk"
        Me.Text = "Kendaraan Masuk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Header_Masuk As Label
    Friend WithEvents NomorTiket As Label
    Friend WithEvents PlatNomor As Label
    Friend WithEvents JamMasuk As Label
    Friend WithEvents JenisKendaraan As Label
    Friend WithEvents GenerateTiketNo As Label
    Friend WithEvents GeneratePlatNomor As Label
    Friend WithEvents GenerateJamMasuk As Label
    Friend WithEvents GenerateJenisKendaraan As Label
    Friend WithEvents GenerateTanggal As Label
    Friend WithEvents ButtonSimpan As Button
    Friend WithEvents ButtonKembali As Button
    Friend WithEvents ButtonPrint As Button
    Friend WithEvents PrintKarcisMasuk As Printing.PrintDocument
    Friend WithEvents PrintInformasi As PrintDialog
    Friend WithEvents SimpanFile As SaveFileDialog
    Friend WithEvents Perhatian As Label
    Friend WithEvents SimpanTiket As Label
    Friend WithEvents KehilanganTiket As Label
    Friend WithEvents ButtonInsertDB As Button
    Friend WithEvents GenerateMemberNo As Label
    Friend WithEvents MemberNo As Label
End Class
