<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Aplikasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Aplikasi))
        Me.UcapanSelamat = New System.Windows.Forms.Label()
        Me.UsernameGenerate = New System.Windows.Forms.Label()
        Me.BoxInformasi = New System.Windows.Forms.GroupBox()
        Me.MemberNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DurasiParkir = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.JamKeluar = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BoxTarifPerjam = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.JamMasuk = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BoxJenisKendaraan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BoxPlatNomor = New System.Windows.Forms.TextBox()
        Me.LabelPlatNo = New System.Windows.Forms.Label()
        Me.BoxNomorTiket = New System.Windows.Forms.TextBox()
        Me.LabelNoTiket = New System.Windows.Forms.Label()
        Me.TanggalSekarang = New System.Windows.Forms.DateTimePicker()
        Me.LabelTanggal = New System.Windows.Forms.Label()
        Me.ButtonBukaDatabase = New System.Windows.Forms.Button()
        Me.ButtonDaftarMember = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.ButtonKeluar = New System.Windows.Forms.Button()
        Me.ButtonMasuk = New System.Windows.Forms.Button()
        Me.ExitNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BoxInformasi.SuspendLayout()
        Me.SuspendLayout()
        '
        'UcapanSelamat
        '
        Me.UcapanSelamat.AutoSize = True
        Me.UcapanSelamat.BackColor = System.Drawing.Color.Transparent
        Me.UcapanSelamat.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcapanSelamat.Location = New System.Drawing.Point(8, 9)
        Me.UcapanSelamat.Name = "UcapanSelamat"
        Me.UcapanSelamat.Size = New System.Drawing.Size(178, 30)
        Me.UcapanSelamat.TabIndex = 1
        Me.UcapanSelamat.Text = "Selamat Datang : "
        Me.UcapanSelamat.UseWaitCursor = True
        '
        'UsernameGenerate
        '
        Me.UsernameGenerate.AutoSize = True
        Me.UsernameGenerate.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameGenerate.Location = New System.Drawing.Point(172, 10)
        Me.UsernameGenerate.Name = "UsernameGenerate"
        Me.UsernameGenerate.Size = New System.Drawing.Size(168, 30)
        Me.UsernameGenerate.TabIndex = 2
        Me.UsernameGenerate.Text = "Nama Username"
        Me.UsernameGenerate.UseWaitCursor = True
        '
        'BoxInformasi
        '
        Me.BoxInformasi.BackColor = System.Drawing.Color.PaleGreen
        Me.BoxInformasi.Controls.Add(Me.ExitNo)
        Me.BoxInformasi.Controls.Add(Me.Label7)
        Me.BoxInformasi.Controls.Add(Me.MemberNo)
        Me.BoxInformasi.Controls.Add(Me.Label6)
        Me.BoxInformasi.Controls.Add(Me.DurasiParkir)
        Me.BoxInformasi.Controls.Add(Me.Label5)
        Me.BoxInformasi.Controls.Add(Me.JamKeluar)
        Me.BoxInformasi.Controls.Add(Me.Label4)
        Me.BoxInformasi.Controls.Add(Me.BoxTarifPerjam)
        Me.BoxInformasi.Controls.Add(Me.Label3)
        Me.BoxInformasi.Controls.Add(Me.JamMasuk)
        Me.BoxInformasi.Controls.Add(Me.Label2)
        Me.BoxInformasi.Controls.Add(Me.BoxJenisKendaraan)
        Me.BoxInformasi.Controls.Add(Me.Label1)
        Me.BoxInformasi.Controls.Add(Me.BoxPlatNomor)
        Me.BoxInformasi.Controls.Add(Me.LabelPlatNo)
        Me.BoxInformasi.Controls.Add(Me.BoxNomorTiket)
        Me.BoxInformasi.Controls.Add(Me.LabelNoTiket)
        Me.BoxInformasi.Controls.Add(Me.TanggalSekarang)
        Me.BoxInformasi.Controls.Add(Me.LabelTanggal)
        Me.BoxInformasi.Location = New System.Drawing.Point(15, 47)
        Me.BoxInformasi.Name = "BoxInformasi"
        Me.BoxInformasi.Size = New System.Drawing.Size(312, 355)
        Me.BoxInformasi.TabIndex = 6
        Me.BoxInformasi.TabStop = False
        Me.BoxInformasi.Text = "Informasi"
        Me.BoxInformasi.UseWaitCursor = True
        '
        'MemberNo
        '
        Me.MemberNo.Location = New System.Drawing.Point(104, 296)
        Me.MemberNo.Name = "MemberNo"
        Me.MemberNo.Size = New System.Drawing.Size(182, 20)
        Me.MemberNo.TabIndex = 17
        Me.MemberNo.UseWaitCursor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Member No :"
        Me.Label6.UseWaitCursor = True
        '
        'DurasiParkir
        '
        Me.DurasiParkir.Location = New System.Drawing.Point(104, 264)
        Me.DurasiParkir.Name = "DurasiParkir"
        Me.DurasiParkir.Size = New System.Drawing.Size(182, 20)
        Me.DurasiParkir.TabIndex = 15
        Me.DurasiParkir.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Durasi Parkir :"
        Me.Label5.UseWaitCursor = True
        '
        'JamKeluar
        '
        Me.JamKeluar.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.JamKeluar.Location = New System.Drawing.Point(104, 230)
        Me.JamKeluar.Name = "JamKeluar"
        Me.JamKeluar.Size = New System.Drawing.Size(182, 20)
        Me.JamKeluar.TabIndex = 13
        Me.JamKeluar.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Jam Keluar : "
        Me.Label4.UseWaitCursor = True
        '
        'BoxTarifPerjam
        '
        Me.BoxTarifPerjam.FormattingEnabled = True
        Me.BoxTarifPerjam.Items.AddRange(New Object() {"Gratis (Dibawah 1 Jam)", "Rp. 2000", "Rp. 3000", "Rp. 4000", "Rp. 6000", "Rp. 8000", "Rp. 9000", "Rp. 10000", "Rp. 12000", "Rp. 14000", "Rp. 15000", "Rp. 16000", "Rp. 18000", "Rp. 20000", "Rp. 21000", "Rp. 22000", "Rp. 24000", "Rp. 26000", "Rp. 27000", "RP. 28000", "Rp. 30000", "Terdaftar (Gratis)"})
        Me.BoxTarifPerjam.Location = New System.Drawing.Point(104, 196)
        Me.BoxTarifPerjam.Name = "BoxTarifPerjam"
        Me.BoxTarifPerjam.Size = New System.Drawing.Size(182, 21)
        Me.BoxTarifPerjam.TabIndex = 11
        Me.BoxTarifPerjam.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Tarif Perjam : "
        Me.Label3.UseWaitCursor = True
        '
        'JamMasuk
        '
        Me.JamMasuk.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.JamMasuk.Location = New System.Drawing.Point(104, 161)
        Me.JamMasuk.Name = "JamMasuk"
        Me.JamMasuk.Size = New System.Drawing.Size(182, 20)
        Me.JamMasuk.TabIndex = 9
        Me.JamMasuk.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Jam Masuk :"
        Me.Label2.UseWaitCursor = True
        '
        'BoxJenisKendaraan
        '
        Me.BoxJenisKendaraan.FormattingEnabled = True
        Me.BoxJenisKendaraan.Items.AddRange(New Object() {"Motor", "Mobil"})
        Me.BoxJenisKendaraan.Location = New System.Drawing.Point(104, 125)
        Me.BoxJenisKendaraan.Name = "BoxJenisKendaraan"
        Me.BoxJenisKendaraan.Size = New System.Drawing.Size(182, 21)
        Me.BoxJenisKendaraan.TabIndex = 7
        Me.BoxJenisKendaraan.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Jenis Kendaraan :"
        Me.Label1.UseWaitCursor = True
        '
        'BoxPlatNomor
        '
        Me.BoxPlatNomor.Location = New System.Drawing.Point(104, 93)
        Me.BoxPlatNomor.Name = "BoxPlatNomor"
        Me.BoxPlatNomor.Size = New System.Drawing.Size(182, 20)
        Me.BoxPlatNomor.TabIndex = 5
        Me.BoxPlatNomor.UseWaitCursor = True
        '
        'LabelPlatNo
        '
        Me.LabelPlatNo.AutoSize = True
        Me.LabelPlatNo.Location = New System.Drawing.Point(7, 93)
        Me.LabelPlatNo.Name = "LabelPlatNo"
        Me.LabelPlatNo.Size = New System.Drawing.Size(65, 13)
        Me.LabelPlatNo.TabIndex = 4
        Me.LabelPlatNo.Text = "Plat Nomor :"
        Me.LabelPlatNo.UseWaitCursor = True
        '
        'BoxNomorTiket
        '
        Me.BoxNomorTiket.Location = New System.Drawing.Point(104, 60)
        Me.BoxNomorTiket.Name = "BoxNomorTiket"
        Me.BoxNomorTiket.Size = New System.Drawing.Size(182, 20)
        Me.BoxNomorTiket.TabIndex = 3
        Me.BoxNomorTiket.UseWaitCursor = True
        '
        'LabelNoTiket
        '
        Me.LabelNoTiket.AutoSize = True
        Me.LabelNoTiket.Location = New System.Drawing.Point(7, 63)
        Me.LabelNoTiket.Name = "LabelNoTiket"
        Me.LabelNoTiket.Size = New System.Drawing.Size(71, 13)
        Me.LabelNoTiket.TabIndex = 2
        Me.LabelNoTiket.Text = "Nomor Tiket :"
        Me.LabelNoTiket.UseWaitCursor = True
        '
        'TanggalSekarang
        '
        Me.TanggalSekarang.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TanggalSekarang.Location = New System.Drawing.Point(104, 28)
        Me.TanggalSekarang.Name = "TanggalSekarang"
        Me.TanggalSekarang.Size = New System.Drawing.Size(182, 20)
        Me.TanggalSekarang.TabIndex = 1
        Me.TanggalSekarang.UseWaitCursor = True
        '
        'LabelTanggal
        '
        Me.LabelTanggal.AutoSize = True
        Me.LabelTanggal.Location = New System.Drawing.Point(7, 30)
        Me.LabelTanggal.Name = "LabelTanggal"
        Me.LabelTanggal.Size = New System.Drawing.Size(55, 13)
        Me.LabelTanggal.TabIndex = 0
        Me.LabelTanggal.Text = "Tanggal : "
        Me.LabelTanggal.UseWaitCursor = True
        '
        'ButtonBukaDatabase
        '
        Me.ButtonBukaDatabase.BackColor = System.Drawing.Color.PaleGreen
        Me.ButtonBukaDatabase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonBukaDatabase.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBukaDatabase.Image = CType(resources.GetObject("ButtonBukaDatabase.Image"), System.Drawing.Image)
        Me.ButtonBukaDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBukaDatabase.Location = New System.Drawing.Point(386, 246)
        Me.ButtonBukaDatabase.Name = "ButtonBukaDatabase"
        Me.ButtonBukaDatabase.Size = New System.Drawing.Size(180, 44)
        Me.ButtonBukaDatabase.TabIndex = 10
        Me.ButtonBukaDatabase.Text = "Buka Database"
        Me.ButtonBukaDatabase.UseVisualStyleBackColor = False
        Me.ButtonBukaDatabase.UseWaitCursor = True
        '
        'ButtonDaftarMember
        '
        Me.ButtonDaftarMember.BackColor = System.Drawing.Color.PaleGreen
        Me.ButtonDaftarMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonDaftarMember.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDaftarMember.Image = CType(resources.GetObject("ButtonDaftarMember.Image"), System.Drawing.Image)
        Me.ButtonDaftarMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDaftarMember.Location = New System.Drawing.Point(386, 180)
        Me.ButtonDaftarMember.Name = "ButtonDaftarMember"
        Me.ButtonDaftarMember.Size = New System.Drawing.Size(180, 44)
        Me.ButtonDaftarMember.TabIndex = 9
        Me.ButtonDaftarMember.Text = "Daftar Member"
        Me.ButtonDaftarMember.UseVisualStyleBackColor = False
        Me.ButtonDaftarMember.UseWaitCursor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.BackColor = System.Drawing.Color.Tomato
        Me.LogoutButton.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutButton.Image = CType(resources.GetObject("LogoutButton.Image"), System.Drawing.Image)
        Me.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutButton.Location = New System.Drawing.Point(470, 324)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(110, 40)
        Me.LogoutButton.TabIndex = 8
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = False
        Me.LogoutButton.UseWaitCursor = True
        '
        'ButtonKeluar
        '
        Me.ButtonKeluar.BackColor = System.Drawing.Color.PaleGreen
        Me.ButtonKeluar.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonKeluar.Image = CType(resources.GetObject("ButtonKeluar.Image"), System.Drawing.Image)
        Me.ButtonKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonKeluar.Location = New System.Drawing.Point(386, 118)
        Me.ButtonKeluar.Name = "ButtonKeluar"
        Me.ButtonKeluar.Size = New System.Drawing.Size(180, 44)
        Me.ButtonKeluar.TabIndex = 4
        Me.ButtonKeluar.Text = "Kendaraan Keluar"
        Me.ButtonKeluar.UseVisualStyleBackColor = False
        Me.ButtonKeluar.UseWaitCursor = True
        '
        'ButtonMasuk
        '
        Me.ButtonMasuk.BackColor = System.Drawing.Color.PaleGreen
        Me.ButtonMasuk.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMasuk.Image = CType(resources.GetObject("ButtonMasuk.Image"), System.Drawing.Image)
        Me.ButtonMasuk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMasuk.Location = New System.Drawing.Point(386, 57)
        Me.ButtonMasuk.Name = "ButtonMasuk"
        Me.ButtonMasuk.Size = New System.Drawing.Size(180, 44)
        Me.ButtonMasuk.TabIndex = 3
        Me.ButtonMasuk.Text = "Kendaraan Masuk"
        Me.ButtonMasuk.UseVisualStyleBackColor = False
        Me.ButtonMasuk.UseWaitCursor = True
        '
        'ExitNo
        '
        Me.ExitNo.Location = New System.Drawing.Point(104, 329)
        Me.ExitNo.Name = "ExitNo"
        Me.ExitNo.Size = New System.Drawing.Size(182, 20)
        Me.ExitNo.TabIndex = 19
        Me.ExitNo.UseWaitCursor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 329)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Exit No :"
        Me.Label7.UseWaitCursor = True
        '
        'Aplikasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(592, 414)
        Me.Controls.Add(Me.ButtonBukaDatabase)
        Me.Controls.Add(Me.ButtonDaftarMember)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.BoxInformasi)
        Me.Controls.Add(Me.ButtonKeluar)
        Me.Controls.Add(Me.ButtonMasuk)
        Me.Controls.Add(Me.UsernameGenerate)
        Me.Controls.Add(Me.UcapanSelamat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Aplikasi"
        Me.Text = "Sistem Parkir"
        Me.UseWaitCursor = True
        Me.BoxInformasi.ResumeLayout(False)
        Me.BoxInformasi.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcapanSelamat As Label
    Friend WithEvents UsernameGenerate As Label
    Friend WithEvents ButtonMasuk As Button
    Friend WithEvents ButtonKeluar As Button
    Friend WithEvents BoxInformasi As GroupBox
    Friend WithEvents LabelNoTiket As Label
    Friend WithEvents TanggalSekarang As DateTimePicker
    Friend WithEvents LabelTanggal As Label
    Friend WithEvents BoxNomorTiket As TextBox
    Friend WithEvents JamMasuk As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents BoxJenisKendaraan As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BoxPlatNomor As TextBox
    Friend WithEvents LabelPlatNo As Label
    Friend WithEvents BoxTarifPerjam As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents JamKeluar As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DurasiParkir As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LogoutButton As Button
    Friend WithEvents MemberNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonDaftarMember As Button
    Friend WithEvents ButtonBukaDatabase As Button
    Friend WithEvents ExitNo As TextBox
    Friend WithEvents Label7 As Label
End Class
