<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewDB
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewDB))
        Me.ParkirDataSet = New Sistem_Parkir.ParkirDataSet()
        Me.ParkirDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.TabView = New System.Windows.Forms.TabControl()
        Me.DataMasuk = New System.Windows.Forms.TabPage()
        Me.ViewDataMasuk = New System.Windows.Forms.DataGridView()
        Me.DataKeluar = New System.Windows.Forms.TabPage()
        Me.ViewDataKeluar = New System.Windows.Forms.DataGridView()
        Me.DataMember = New System.Windows.Forms.TabPage()
        Me.ViewDataMember = New System.Windows.Forms.DataGridView()
        Me.DataTarif = New System.Windows.Forms.TabPage()
        Me.ViewDataTarif = New System.Windows.Forms.DataGridView()
        CType(Me.ParkirDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParkirDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabView.SuspendLayout()
        Me.DataMasuk.SuspendLayout()
        CType(Me.ViewDataMasuk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataKeluar.SuspendLayout()
        CType(Me.ViewDataKeluar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataMember.SuspendLayout()
        CType(Me.ViewDataMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataTarif.SuspendLayout()
        CType(Me.ViewDataTarif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ParkirDataSet
        '
        Me.ParkirDataSet.DataSetName = "ParkirDataSet"
        Me.ParkirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ParkirDataSetBindingSource
        '
        Me.ParkirDataSetBindingSource.DataSource = Me.ParkirDataSet
        Me.ParkirDataSetBindingSource.Position = 0
        '
        'ButtonExit
        '
        Me.ButtonExit.BackColor = System.Drawing.Color.Tomato
        Me.ButtonExit.Image = Global.Sistem_Parkir.My.Resources.Resources.Custom_Icon_Design_Flatastic_1_Back
        Me.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonExit.Location = New System.Drawing.Point(314, 394)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(183, 46)
        Me.ButtonExit.TabIndex = 1
        Me.ButtonExit.Text = "Kembali"
        Me.ButtonExit.UseVisualStyleBackColor = False
        '
        'TabView
        '
        Me.TabView.Controls.Add(Me.DataMasuk)
        Me.TabView.Controls.Add(Me.DataKeluar)
        Me.TabView.Controls.Add(Me.DataMember)
        Me.TabView.Controls.Add(Me.DataTarif)
        Me.TabView.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabView.Location = New System.Drawing.Point(0, 0)
        Me.TabView.Name = "TabView"
        Me.TabView.SelectedIndex = 0
        Me.TabView.Size = New System.Drawing.Size(800, 386)
        Me.TabView.TabIndex = 2
        '
        'DataMasuk
        '
        Me.DataMasuk.Controls.Add(Me.ViewDataMasuk)
        Me.DataMasuk.Location = New System.Drawing.Point(4, 22)
        Me.DataMasuk.Name = "DataMasuk"
        Me.DataMasuk.Padding = New System.Windows.Forms.Padding(3)
        Me.DataMasuk.Size = New System.Drawing.Size(792, 360)
        Me.DataMasuk.TabIndex = 0
        Me.DataMasuk.Text = "Data Masuk"
        Me.DataMasuk.UseVisualStyleBackColor = True
        '
        'ViewDataMasuk
        '
        Me.ViewDataMasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewDataMasuk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewDataMasuk.Location = New System.Drawing.Point(3, 3)
        Me.ViewDataMasuk.Name = "ViewDataMasuk"
        Me.ViewDataMasuk.Size = New System.Drawing.Size(786, 354)
        Me.ViewDataMasuk.TabIndex = 0
        '
        'DataKeluar
        '
        Me.DataKeluar.Controls.Add(Me.ViewDataKeluar)
        Me.DataKeluar.Location = New System.Drawing.Point(4, 22)
        Me.DataKeluar.Name = "DataKeluar"
        Me.DataKeluar.Padding = New System.Windows.Forms.Padding(3)
        Me.DataKeluar.Size = New System.Drawing.Size(792, 360)
        Me.DataKeluar.TabIndex = 1
        Me.DataKeluar.Text = "Data Keluar"
        Me.DataKeluar.UseVisualStyleBackColor = True
        '
        'ViewDataKeluar
        '
        Me.ViewDataKeluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewDataKeluar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewDataKeluar.Location = New System.Drawing.Point(3, 3)
        Me.ViewDataKeluar.Name = "ViewDataKeluar"
        Me.ViewDataKeluar.Size = New System.Drawing.Size(786, 354)
        Me.ViewDataKeluar.TabIndex = 0
        '
        'DataMember
        '
        Me.DataMember.Controls.Add(Me.ViewDataMember)
        Me.DataMember.Location = New System.Drawing.Point(4, 22)
        Me.DataMember.Name = "DataMember"
        Me.DataMember.Padding = New System.Windows.Forms.Padding(3)
        Me.DataMember.Size = New System.Drawing.Size(792, 360)
        Me.DataMember.TabIndex = 2
        Me.DataMember.Text = "Data Member"
        Me.DataMember.UseVisualStyleBackColor = True
        '
        'ViewDataMember
        '
        Me.ViewDataMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewDataMember.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewDataMember.Location = New System.Drawing.Point(3, 3)
        Me.ViewDataMember.Name = "ViewDataMember"
        Me.ViewDataMember.Size = New System.Drawing.Size(786, 354)
        Me.ViewDataMember.TabIndex = 0
        '
        'DataTarif
        '
        Me.DataTarif.Controls.Add(Me.ViewDataTarif)
        Me.DataTarif.Location = New System.Drawing.Point(4, 22)
        Me.DataTarif.Name = "DataTarif"
        Me.DataTarif.Padding = New System.Windows.Forms.Padding(3)
        Me.DataTarif.Size = New System.Drawing.Size(792, 360)
        Me.DataTarif.TabIndex = 3
        Me.DataTarif.Text = "Data Tarif"
        Me.DataTarif.UseVisualStyleBackColor = True
        '
        'ViewDataTarif
        '
        Me.ViewDataTarif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewDataTarif.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewDataTarif.Location = New System.Drawing.Point(3, 3)
        Me.ViewDataTarif.Name = "ViewDataTarif"
        Me.ViewDataTarif.Size = New System.Drawing.Size(786, 354)
        Me.ViewDataTarif.TabIndex = 0
        '
        'ViewDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabView)
        Me.Controls.Add(Me.ButtonExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewDB"
        Me.Text = "View Data"
        CType(Me.ParkirDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParkirDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabView.ResumeLayout(False)
        Me.DataMasuk.ResumeLayout(False)
        CType(Me.ViewDataMasuk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataKeluar.ResumeLayout(False)
        CType(Me.ViewDataKeluar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataMember.ResumeLayout(False)
        CType(Me.ViewDataMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataTarif.ResumeLayout(False)
        CType(Me.ViewDataTarif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ParkirDataSetBindingSource As BindingSource
    Friend WithEvents ParkirDataSet As ParkirDataSet
    Friend WithEvents ButtonExit As Button
    Friend WithEvents TabView As TabControl
    Friend WithEvents DataMasuk As TabPage
    Friend WithEvents ViewDataMasuk As DataGridView
    Friend WithEvents DataKeluar As TabPage
    Friend WithEvents DataMember As TabPage
    Friend WithEvents DataTarif As TabPage
    Friend WithEvents ViewDataKeluar As DataGridView
    Friend WithEvents ViewDataMember As DataGridView
    Friend WithEvents ViewDataTarif As DataGridView
End Class
