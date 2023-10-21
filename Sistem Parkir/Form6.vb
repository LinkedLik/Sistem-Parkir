Imports System.Data.SqlClient
Public Class ViewDB
    Dim Conn As SqlConnection
    Dim DMasuk As SqlDataAdapter
    Dim DMember As SqlDataAdapter
    Dim DKeluar As SqlDataAdapter
    Dim DTarif As SqlDataAdapter
    Dim Ds As DataSet
    Dim MyDB As String
    Sub koneksi()
        MyDB = "Data Source=LIKO-X230;initial catalog=Parkir; integrated security=true"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub ViewDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        DMasuk = New SqlDataAdapter("SELECT * FROM datakendaraanmasuk", Conn)
        DKeluar = New SqlDataAdapter("SELECT * FROM datakendaraankeluar", Conn)
        DMember = New SqlDataAdapter("SELECT * FROM datamember", Conn)
        DTarif = New SqlDataAdapter("SELECT * FROM datatarif", Conn)
        Ds = New DataSet
        Ds.Clear()
        DMasuk.Fill(Ds, "datakendaraanmasuk")
        DKeluar.Fill(Ds, "datakendaraankeluar")
        DMember.Fill(Ds, "datamember")
        DTarif.Fill(Ds, "datatarif")
        ViewDataMasuk.DataSource = (Ds.Tables("datakendaraanmasuk"))
        ViewDataKeluar.DataSource = (Ds.Tables("datakendaraankeluar"))
        ViewDataMember.DataSource = (Ds.Tables("datamember"))
        ViewDataTarif.DataSource = (Ds.Tables("datatarif"))
    End Sub

    Private Sub ViewDataMasuk_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ViewDataMasuk.CellContentClick

    End Sub
End Class