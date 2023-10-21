Imports System.Data.SqlClient
Public Class DaftarMember
    Dim Conn As SqlConnection
    Dim Da As SqlDataAdapter
    Dim Ds As DataSet
    Dim MyDB As String
    Sub koneksi()
        MyDB = "Data Source=LIKO-X230;initial catalog=Parkir; integrated security=true"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

    Private Sub ButtonKembali_Click(sender As Object, e As EventArgs) Handles ButtonKembali.Click
        MessageBox.Show("Menutup", "Kembali", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub TombolMasukanDatabase_Click(sender As Object, e As EventArgs) Handles TombolMasukanDatabase.Click

        DataMemberTableAdapter.Insert(MemberNomorMember.Text, MemberPlatNo.Text, MemberFirstName.Text, MemberLastName.Text,
                                      MemberJenisKendaraan.SelectedItem)
        MessageBox.Show("Tersimpan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.Close()
    End Sub

    Private Sub MemberNomorMember_TextChanged(sender As Object, e As EventArgs) Handles MemberNomorMember.TextChanged

    End Sub

    Private Sub MemberPlatNo_TextChanged(sender As Object, e As EventArgs) Handles MemberPlatNo.TextChanged

    End Sub

    Private Sub MemberFirstName_TextChanged(sender As Object, e As EventArgs) Handles MemberFirstName.TextChanged

    End Sub

    Private Sub MemberLastName_TextChanged(sender As Object, e As EventArgs) Handles MemberLastName.TextChanged

    End Sub

    Private Sub MemberJenisKendaraan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MemberJenisKendaraan.SelectedIndexChanged

    End Sub

    Private Sub DaftarMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Da = New SqlDataAdapter("SELECT * FROM datamember", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "DataMember")
        TampilDataMember.DataSource = (Ds.Tables("DataMember"))
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub FillByToolStripButton1_Click(sender As Object, e As EventArgs)


    End Sub
End Class