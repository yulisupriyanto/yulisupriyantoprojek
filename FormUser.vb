Imports System.Data.SqlClient
Public Class FormUser
    Sub IDOtomatis()
        Call Koneksi()
        CMD = New SqlCommand("select id_user from tbl_user order by id_user desc", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            id_user.Text = "USR" + "0000001"
        Else
            id_user.Text = "USR" + Format(Microsoft.VisualBasic.Right(DR(0), 7) + 1, "0000000")
        End If
        id_user.Enabled = False
    End Sub
    Sub Kosongkan()
        nama_user.Clear()
        status.Text = ""
        pwd.Clear()
        cari_data.Clear()
        id_user.Focus()
        Call tampilgrid()
    End Sub
    Sub DataBaru()
        nama_user.Clear()
        status.Text = ""
        pwd.Clear()
        cari_data.Clear()
        nama_user.Focus()
    End Sub
    Sub Ketemu()
        nama_user.Text = DR.Item("nama_user")
        pwd.Text = DR.Item("password")
        status.Text = UCase(DR.Item("status"))

        nama_user.Focus()
    End Sub
    Sub tampilgrid()
        Call Koneksi()
        DA = New SqlDataAdapter("select * from tbl_user", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
    End Sub
    Sub cariid()
        Call Koneksi()
        CMD = New SqlCommand("select * from tbl_user where id_user='" & id_user.Text & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
    End Sub

    Private Sub FormUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Call Koneksi()
        Call Kosongkan()
        Call IDOtomatis()
    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick
        On Error Resume Next
        id_user.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        nama_user.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        pwd.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        status.Text = DGV.Rows(e.RowIndex).Cells(3).Value
    End Sub

    Private Sub cari_data_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cari_data.TextChanged
        Call Koneksi()
        CMD = New SqlCommand("select * from tbl_user where nama_user like '%" & Me.cari_data.Text & "%'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then


            Call Koneksi()
            DA = New SqlDataAdapter("select * from tbl_user where nama_user like '%" & Me.cari_data.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            Me.DGV.DataSource = DS.Tables(0)
        Else
            MsgBox("No Surat tidak ada ")
        End If

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        id_user.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        nama_user.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        pwd.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        status.Text = DGV.Rows(e.RowIndex).Cells(3).Value
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        Call Koneksi()
        Dim edit As String = "update tbl_user set nama_user ='" & nama_user.Text & "', password='" & pwd.Text & "',status='" & status.Text & "' where id_user='" & id_user.Text & "'"
        CMD = New SqlCommand(edit, CONN)
        CMD.ExecuteNonQuery()
        Call IDOtomatis()
        Call Kosongkan()
        CONN.Close()
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        Call cariid()
        Try
            If Not DR.HasRows Then
                Call Koneksi()
                Dim simpan As String = "insert into tbl_user values ('" & id_user.Text & "','" & nama_user.Text & "','" & pwd.Text & "','" & UCase(status.Text) & "')"
                CMD = New SqlCommand(simpan, CONN)
                CMD.ExecuteNonQuery()
                Call IDOtomatis()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call Kosongkan()
    End Sub

    Private Sub delet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delet.Click
        If Me.id_user.Text = "" Then
            MsgBox("ID user HARUS DIISI")
            Me.id_user.Focus()
            Exit Sub
        End If
        '-----------proses delete---
        Call Koneksi()
        If MessageBox.Show("Hapus data ini ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim hapus As String = "delete from tbl_user where id_user  ='" & id_user.Text & "'"
            CMD = New SqlCommand(hapus, CONN)
            CMD.ExecuteNonQuery()
            CONN.Close()
            Call tampilgrid()
            Call Kosongkan()
        Else

        End If
    End Sub

    Private Sub keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluar.Click
        Me.Close()
    End Sub
End Class
