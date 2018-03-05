Imports System.Data.SqlClient

Public Class LoginForm1

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Dispose()

    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_user_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_user.KeyPress

        If e.KeyChar = Chr(13) Then
            Me.txt_password.Focus()

        End If
    End Sub

    Private Sub txt_password_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_password.KeyPress

        If e.KeyChar = Chr(13) Then
            Me.btn_simpan.FindForm()

        End If
    End Sub

    Sub kosongkan()
        Me.txt_user.Clear()
        Me.txt_password.Clear()

    End Sub

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        Call Koneksi()
        CMD = New SqlCommand("select * from tbl_user where nama_user='" & txt_user.Text & "' and password='" & txt_password.Text & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            MsgBox("Login Berhasil")
            '================================
            Me.Visible = False
            MenuUtama.Show()
            '============================== loger
            MenuUtama.panelkode.Text = DR.Item("id_user")
            MenuUtama.panelnama.Text = DR.Item("nama_user")
            MenuUtama.panelstatus.Text = UCase(DR.Item("status"))


        Else
            MsgBox("login gagal")
            txt_user.Clear()
            txt_password.Text = ""
            txt_user.Focus()
        End If
    End Sub
End Class
