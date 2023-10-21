Public Class MenuParkir
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click, LoginButton.Enter
        If Boxusername.Text = "Admin" And BoxPassword.Text = "Admin" Then
            MessageBox.Show("Berhasil Login", "Informasi login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UsernameInput = Boxusername.Text
            Aplikasi.Show()
            Me.Close()

        ElseIf Boxusername.Text = "Supervisor" And BoxPassword.Text = "Supervisor" Then
            MessageBox.Show("Berhasil Login", "Informasi Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UsernameInput = Boxusername.Text
            Aplikasi.Show()
            Me.Close()

        Else
            MessageBox.Show("Username atau Password Invalid", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        '        If Boxusername.Text = "" Then
        '        MessageBox.Show("Masukan Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        ElseIf BoxPassword.Text = "" Then
        '        MessageBox.Show("Masukan Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Else
        '        Try
        '        ConnectDatabase()
        '        sql = "SELECT * FROM LoginUser
        '                        WHERE Username = @Username 
        '                        AND
        '                        Password = @Password;"
        '        cmd = New SqlClient.SqlCommand
        '        With cmd
        '        .Connection = Conn
        '        .CommandText = sql
        '        .Parameters.Clear()
        '        .Parameters.AddWithValue("@Username", Boxusername.Text)
        '        .Parameters.AddWithValue("@Password", BoxPassword.Text)
        '        .ExecuteNonQuery()
        '       End With
        '       da = New SqlClient.SqlDataAdapter
        '      dt = New DataTable
        '      da.SelectCommand = cmd
        '      da.Fill(dt)
        '      Catch ex As Exception
        '      MessageBox.Show("Error")
        '      Finally
        '      Conn.Close()
        '      da.Dispose()
        '      If dt.Rows.Count > 0 Then
        '      Dim Username, Password As String
        '      Username = dt.Rows(0).Item("Username")
        '      Password = dt.Rows(0).Item("Password")
        '      If Boxusername.Text = Username And BoxPassword.Text = Password Then
        '      MessageBox.Show("Berhasil Login", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '      Aplikasi.Show()
        '      Me.Close()
        '     ElseIf Boxusername.Text <> Username Then
        '     MessageBox.Show("Username Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '     ElseIf BoxPassword.Text <> Password Then
        '     MessageBox.Show("Password Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '     Else
        '     MessageBox.Show("Username atau Password Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '     BoxPassword.Text = ""
        '     BoxPassword.Focus()
        '     Boxusername.Text = ""
        '     BoxPassword.Text = ""
        '     End If
        '     End If
        '     End Try
        '     End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub
End Class
