<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DaftarMember
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DaftarMember))
        Me.TextNamaDepanMember = New System.Windows.Forms.Label()
        Me.TextNomorMember = New System.Windows.Forms.Label()
        Me.TextNamaBelakangMember = New System.Windows.Forms.Label()
        Me.TextJenisKendaraan = New System.Windows.Forms.Label()
        Me.TextPlatNomorKendaraan = New System.Windows.Forms.Label()
        Me.MemberNomorMember = New System.Windows.Forms.TextBox()
        Me.MemberPlatNo = New System.Windows.Forms.TextBox()
        Me.MemberFirstName = New System.Windows.Forms.TextBox()
        Me.MemberLastName = New System.Windows.Forms.TextBox()
        Me.ParkirDataSet = New Sistem_Parkir.ParkirDataSet()
        Me.ButtonKembali = New System.Windows.Forms.Button()
        Me.TampilDataMember = New System.Windows.Forms.DataGridView()
        Me.MemberNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlatNomorKendaraanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDepanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBelakangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisKendaraanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataMemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDataSet = New Sistem_Parkir.UserDataSet()
        Me.DataMemberTableAdapter = New Sistem_Parkir.ParkirDataSetTableAdapters.DataMemberTableAdapter()
        Me.TombolMasukanDatabase = New System.Windows.Forms.Button()
        Me.FKDataKeluarDataMemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataKeluarTableAdapter = New Sistem_Parkir.ParkirDataSetTableAdapters.DataKeluarTableAdapter()
        Me.DataTarifBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTarifTableAdapter = New Sistem_Parkir.ParkirDataSetTableAdapters.DataTarifTableAdapter()
        Me.MemberJenisKendaraan = New System.Windows.Forms.ComboBox()
        CType(Me.ParkirDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TampilDataMember, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataMemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKDataKeluarDataMemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTarifBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextNamaDepanMember
        '
        Me.TextNamaDepanMember.AutoSize = True
        Me.TextNamaDepanMember.BackColor = System.Drawing.Color.White
        Me.TextNamaDepanMember.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNamaDepanMember.Location = New System.Drawing.Point(33, 104)
        Me.TextNamaDepanMember.Name = "TextNamaDepanMember"
        Me.TextNamaDepanMember.Size = New System.Drawing.Size(239, 25)
        Me.TextNamaDepanMember.TabIndex = 0
        Me.TextNamaDepanMember.Text = "Nama Depan                 :"
        '
        'TextNomorMember
        '
        Me.TextNomorMember.AutoSize = True
        Me.TextNomorMember.BackColor = System.Drawing.Color.White
        Me.TextNomorMember.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNomorMember.Location = New System.Drawing.Point(33, 34)
        Me.TextNomorMember.Name = "TextNomorMember"
        Me.TextNomorMember.Size = New System.Drawing.Size(237, 25)
        Me.TextNomorMember.TabIndex = 1
        Me.TextNomorMember.Text = "Nomor                          :"
        '
        'TextNamaBelakangMember
        '
        Me.TextNamaBelakangMember.AutoSize = True
        Me.TextNamaBelakangMember.BackColor = System.Drawing.Color.White
        Me.TextNamaBelakangMember.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNamaBelakangMember.Location = New System.Drawing.Point(33, 138)
        Me.TextNamaBelakangMember.Name = "TextNamaBelakangMember"
        Me.TextNamaBelakangMember.Size = New System.Drawing.Size(237, 25)
        Me.TextNamaBelakangMember.TabIndex = 2
        Me.TextNamaBelakangMember.Text = "Nama Belakang            :"
        '
        'TextJenisKendaraan
        '
        Me.TextJenisKendaraan.AutoSize = True
        Me.TextJenisKendaraan.BackColor = System.Drawing.Color.White
        Me.TextJenisKendaraan.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextJenisKendaraan.Location = New System.Drawing.Point(33, 172)
        Me.TextJenisKendaraan.Name = "TextJenisKendaraan"
        Me.TextJenisKendaraan.Size = New System.Drawing.Size(234, 25)
        Me.TextJenisKendaraan.TabIndex = 3
        Me.TextJenisKendaraan.Text = "Jenis Kendaraan          :"
        '
        'TextPlatNomorKendaraan
        '
        Me.TextPlatNomorKendaraan.AutoSize = True
        Me.TextPlatNomorKendaraan.BackColor = System.Drawing.Color.White
        Me.TextPlatNomorKendaraan.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPlatNomorKendaraan.Location = New System.Drawing.Point(33, 69)
        Me.TextPlatNomorKendaraan.Name = "TextPlatNomorKendaraan"
        Me.TextPlatNomorKendaraan.Size = New System.Drawing.Size(237, 25)
        Me.TextPlatNomorKendaraan.TabIndex = 4
        Me.TextPlatNomorKendaraan.Text = "Plat Nomor Kendaraan :"
        '
        'MemberNomorMember
        '
        Me.MemberNomorMember.BackColor = System.Drawing.Color.White
        Me.MemberNomorMember.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberNomorMember.Location = New System.Drawing.Point(266, 32)
        Me.MemberNomorMember.Name = "MemberNomorMember"
        Me.MemberNomorMember.Size = New System.Drawing.Size(210, 30)
        Me.MemberNomorMember.TabIndex = 5
        '
        'MemberPlatNo
        '
        Me.MemberPlatNo.BackColor = System.Drawing.Color.White
        Me.MemberPlatNo.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberPlatNo.Location = New System.Drawing.Point(266, 67)
        Me.MemberPlatNo.Name = "MemberPlatNo"
        Me.MemberPlatNo.Size = New System.Drawing.Size(210, 30)
        Me.MemberPlatNo.TabIndex = 6
        '
        'MemberFirstName
        '
        Me.MemberFirstName.BackColor = System.Drawing.Color.White
        Me.MemberFirstName.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberFirstName.Location = New System.Drawing.Point(266, 102)
        Me.MemberFirstName.Name = "MemberFirstName"
        Me.MemberFirstName.Size = New System.Drawing.Size(210, 30)
        Me.MemberFirstName.TabIndex = 7
        '
        'MemberLastName
        '
        Me.MemberLastName.BackColor = System.Drawing.Color.White
        Me.MemberLastName.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberLastName.Location = New System.Drawing.Point(266, 137)
        Me.MemberLastName.Name = "MemberLastName"
        Me.MemberLastName.Size = New System.Drawing.Size(210, 30)
        Me.MemberLastName.TabIndex = 8
        '
        'ParkirDataSet
        '
        Me.ParkirDataSet.DataSetName = "ParkirDataSet"
        Me.ParkirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonKembali
        '
        Me.ButtonKembali.BackColor = System.Drawing.Color.Tomato
        Me.ButtonKembali.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonKembali.Image = CType(resources.GetObject("ButtonKembali.Image"), System.Drawing.Image)
        Me.ButtonKembali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonKembali.Location = New System.Drawing.Point(557, 104)
        Me.ButtonKembali.Name = "ButtonKembali"
        Me.ButtonKembali.Size = New System.Drawing.Size(120, 41)
        Me.ButtonKembali.TabIndex = 24
        Me.ButtonKembali.Text = "Kembali"
        Me.ButtonKembali.UseVisualStyleBackColor = False
        '
        'TampilDataMember
        '
        Me.TampilDataMember.AutoGenerateColumns = False
        Me.TampilDataMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TampilDataMember.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MemberNoDataGridViewTextBoxColumn, Me.PlatNomorKendaraanDataGridViewTextBoxColumn, Me.NamaDepanDataGridViewTextBoxColumn, Me.NamaBelakangDataGridViewTextBoxColumn, Me.JenisKendaraanDataGridViewTextBoxColumn})
        Me.TampilDataMember.DataSource = Me.DataMemberBindingSource
        Me.TampilDataMember.Location = New System.Drawing.Point(38, 218)
        Me.TampilDataMember.Name = "TampilDataMember"
        Me.TampilDataMember.Size = New System.Drawing.Size(544, 150)
        Me.TampilDataMember.TabIndex = 25
        '
        'MemberNoDataGridViewTextBoxColumn
        '
        Me.MemberNoDataGridViewTextBoxColumn.DataPropertyName = "MemberNo"
        Me.MemberNoDataGridViewTextBoxColumn.HeaderText = "MemberNo"
        Me.MemberNoDataGridViewTextBoxColumn.Name = "MemberNoDataGridViewTextBoxColumn"
        '
        'PlatNomorKendaraanDataGridViewTextBoxColumn
        '
        Me.PlatNomorKendaraanDataGridViewTextBoxColumn.DataPropertyName = "PlatNomorKendaraan"
        Me.PlatNomorKendaraanDataGridViewTextBoxColumn.HeaderText = "PlatNomorKendaraan"
        Me.PlatNomorKendaraanDataGridViewTextBoxColumn.Name = "PlatNomorKendaraanDataGridViewTextBoxColumn"
        '
        'NamaDepanDataGridViewTextBoxColumn
        '
        Me.NamaDepanDataGridViewTextBoxColumn.DataPropertyName = "NamaDepan"
        Me.NamaDepanDataGridViewTextBoxColumn.HeaderText = "NamaDepan"
        Me.NamaDepanDataGridViewTextBoxColumn.Name = "NamaDepanDataGridViewTextBoxColumn"
        '
        'NamaBelakangDataGridViewTextBoxColumn
        '
        Me.NamaBelakangDataGridViewTextBoxColumn.DataPropertyName = "NamaBelakang"
        Me.NamaBelakangDataGridViewTextBoxColumn.HeaderText = "NamaBelakang"
        Me.NamaBelakangDataGridViewTextBoxColumn.Name = "NamaBelakangDataGridViewTextBoxColumn"
        '
        'JenisKendaraanDataGridViewTextBoxColumn
        '
        Me.JenisKendaraanDataGridViewTextBoxColumn.DataPropertyName = "JenisKendaraan"
        Me.JenisKendaraanDataGridViewTextBoxColumn.HeaderText = "JenisKendaraan"
        Me.JenisKendaraanDataGridViewTextBoxColumn.Name = "JenisKendaraanDataGridViewTextBoxColumn"
        '
        'DataMemberBindingSource
        '
        Me.DataMemberBindingSource.DataMember = "DataMember"
        Me.DataMemberBindingSource.DataSource = Me.ParkirDataSet
        '
        'UserDataSet
        '
        Me.UserDataSet.DataSetName = "UserDataSet"
        Me.UserDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataMemberTableAdapter
        '
        Me.DataMemberTableAdapter.ClearBeforeFill = True
        '
        'TombolMasukanDatabase
        '
        Me.TombolMasukanDatabase.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TombolMasukanDatabase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TombolMasukanDatabase.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TombolMasukanDatabase.Image = CType(resources.GetObject("TombolMasukanDatabase.Image"), System.Drawing.Image)
        Me.TombolMasukanDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TombolMasukanDatabase.Location = New System.Drawing.Point(510, 45)
        Me.TombolMasukanDatabase.Name = "TombolMasukanDatabase"
        Me.TombolMasukanDatabase.Size = New System.Drawing.Size(212, 38)
        Me.TombolMasukanDatabase.TabIndex = 26
        Me.TombolMasukanDatabase.Text = "Masukan Database"
        Me.TombolMasukanDatabase.UseVisualStyleBackColor = False
        '
        'FKDataKeluarDataMemberBindingSource
        '
        Me.FKDataKeluarDataMemberBindingSource.DataMember = "FK_DataKeluar_DataMember"
        Me.FKDataKeluarDataMemberBindingSource.DataSource = Me.DataMemberBindingSource
        '
        'DataKeluarTableAdapter
        '
        Me.DataKeluarTableAdapter.ClearBeforeFill = True
        '
        'DataTarifBindingSource
        '
        Me.DataTarifBindingSource.DataMember = "DataTarif"
        Me.DataTarifBindingSource.DataSource = Me.ParkirDataSet
        '
        'DataTarifTableAdapter
        '
        Me.DataTarifTableAdapter.ClearBeforeFill = True
        '
        'MemberJenisKendaraan
        '
        Me.MemberJenisKendaraan.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataTarifBindingSource, "JenisKendaraan", True))
        Me.MemberJenisKendaraan.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberJenisKendaraan.ForeColor = System.Drawing.Color.Black
        Me.MemberJenisKendaraan.FormattingEnabled = True
        Me.MemberJenisKendaraan.Items.AddRange(New Object() {"Mobil", "Motor"})
        Me.MemberJenisKendaraan.Location = New System.Drawing.Point(266, 171)
        Me.MemberJenisKendaraan.Name = "MemberJenisKendaraan"
        Me.MemberJenisKendaraan.Size = New System.Drawing.Size(210, 31)
        Me.MemberJenisKendaraan.TabIndex = 9
        '
        'DaftarMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 388)
        Me.Controls.Add(Me.TombolMasukanDatabase)
        Me.Controls.Add(Me.TampilDataMember)
        Me.Controls.Add(Me.ButtonKembali)
        Me.Controls.Add(Me.MemberJenisKendaraan)
        Me.Controls.Add(Me.MemberLastName)
        Me.Controls.Add(Me.MemberFirstName)
        Me.Controls.Add(Me.MemberPlatNo)
        Me.Controls.Add(Me.MemberNomorMember)
        Me.Controls.Add(Me.TextPlatNomorKendaraan)
        Me.Controls.Add(Me.TextJenisKendaraan)
        Me.Controls.Add(Me.TextNamaBelakangMember)
        Me.Controls.Add(Me.TextNomorMember)
        Me.Controls.Add(Me.TextNamaDepanMember)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DaftarMember"
        Me.Text = "Daftar Member"
        CType(Me.ParkirDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TampilDataMember, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataMemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKDataKeluarDataMemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTarifBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextNamaDepanMember As Label
    Friend WithEvents TextNomorMember As Label
    Friend WithEvents TextNamaBelakangMember As Label
    Friend WithEvents TextJenisKendaraan As Label
    Friend WithEvents TextPlatNomorKendaraan As Label
    Friend WithEvents MemberNomorMember As TextBox
    Friend WithEvents MemberPlatNo As TextBox
    Friend WithEvents MemberFirstName As TextBox
    Friend WithEvents MemberLastName As TextBox
    Friend WithEvents ButtonKembali As Button
    Friend WithEvents TampilDataMember As DataGridView
    Friend WithEvents UserDataSet As UserDataSet
    Friend WithEvents ParkirDataSet As ParkirDataSet
    Friend WithEvents DataMemberBindingSource As BindingSource
    Friend WithEvents DataMemberTableAdapter As ParkirDataSetTableAdapters.DataMemberTableAdapter
    Friend WithEvents MemberNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlatNomorKendaraanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaDepanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaBelakangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JenisKendaraanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TombolMasukanDatabase As Button
    Friend WithEvents FKDataKeluarDataMemberBindingSource As BindingSource
    Friend WithEvents DataKeluarTableAdapter As ParkirDataSetTableAdapters.DataKeluarTableAdapter
    Friend WithEvents DataTarifBindingSource As BindingSource
    Friend WithEvents DataTarifTableAdapter As ParkirDataSetTableAdapters.DataTarifTableAdapter
    Friend WithEvents MemberJenisKendaraan As ComboBox
End Class
