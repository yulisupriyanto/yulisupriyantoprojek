Imports System.Data.SqlClient
Public Class SuratMasuk
    Sub kosongkan()
        tgl_surat.Text = Today
        txt_ket.Clear()
        txt_no_surat.Clear()
        tgl_terima.Text = Today
        txt_pengirim.Clear()
        cmbjenis.Text = "-PILIHAN-"
        txt_perihal.Clear()

    End Sub

    Sub tampilgrid()
        Call Koneksi()
        DA = New SqlDataAdapter("select * from surat_masuk", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
        CONN.Close()
    End Sub

    Sub notis()
        Call Koneksi()
        CMD = New SqlCommand("select id_surat_masuk from surat_masuk order by id_surat_masuk desc", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            txt_id.Text = Format(Now, "ddMMyy") + "0001"
        Else
            If Microsoft.VisualBasic.Left(DR.Item("id_surat_masuk"), 6) <> Format(Now, "ddMMyy") Then
                txt_id.Text = Format(Now, "ddMMyy") + "0001"
            Else
                txt_id.Text = DR.Item("id_surat_masuk") + 1
            End If
        End If
    End Sub
    Sub jumlah()
        Call Koneksi()
        DA = New SqlDataAdapter("select * from surat_masuk", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        jmlh.Text = DGV.RowCount - 1
    End Sub

    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        Call Koneksi()
        txt_id.Text = DGV.Rows(e.RowIndex).Cells(0).Value()
        txt_no_surat.Text = DGV.Rows(e.RowIndex).Cells(2).Value()
        txt_pengirim.Text = DGV.Rows(e.RowIndex).Cells(3).Value()
        tgl_surat.Text = DGV.Rows(e.RowIndex).Cells(4).Value()
        txt_perihal.Text = DGV.Rows(e.RowIndex).Cells(5).Value()
        tgl_terima.Text = DGV.Rows(e.RowIndex).Cells(6).Value()
        cmbjenis.Text = DGV.Rows(e.RowIndex).Cells(7).Value()
        txt_ket.Text = DGV.Rows(e.RowIndex).Cells(8).Value()
    End Sub
    Private Sub cari_data_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cari_data.TextChanged
        Call Koneksi()
        CMD = New SqlCommand("select * from surat_masuk where no_surat_masuk like '%" & Me.cari_data.Text & "%'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then

            Call Koneksi()
            DA = New SqlDataAdapter("select * from surat_masuk where no_surat_masuk like '%" & Me.cari_data.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            Me.DGV.DataSource = DS.Tables(0)
        Else
            MsgBox("No Surat tidak ada ")
        End If
    End Sub

    Private Sub SuratMasuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_id.Enabled = False

        '======== Combo Box jenis surat =======
        Me.cmbjenis.Text = "-pilihan-"
        cmbjenis.Items.Add("PENTING")
        cmbjenis.Items.Add("UMUM")
        cmbjenis.Items.Add("PRIBADI")
        cmbjenis.Items.Add("RAHASIA")

        Call notis()
        Call tampilgrid()
        Call jumlah()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        ExitYn = MsgBox("Apa Anda Ingin Menutup Form ini?", MsgBoxStyle.YesNo)
        If ExitYn = MsgBoxResult.Yes Then
            Close()
        Else
        End If
    End Sub

    Private Sub simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click
        If cmbjenis.Text = "" Or tgl_surat.Text = "" Or txt_pengirim.Text = "" Or tgl_terima.Text = "" Or txt_ket.Text = "" Or txt_perihal.Text = "" Then

            MsgBox("DATA BELUM LENGKAP")
            Exit Sub
        End If
        Call Koneksi()


        Dim simpan As String = "insert into surat_masuk values('" & txt_id.Text & "','" & MenuUtama.panelkode.Text & "','" & txt_no_surat.Text & "','" & txt_pengirim.Text & "','" & Format(DateValue(tgl_surat.Text), "MM/dd/yyyy") & "','" & txt_perihal.Text & "','" & Format(DateValue(tgl_terima.Text), "MM/dd/yyyy") & "','" & cmbjenis.Text & "','" & txt_ket.Text & "')"

        CMD = New SqlCommand(simpan, CONN)
        CMD.ExecuteNonQuery()
        CONN.Close()
        Call kosongkan()
        Call tampilgrid()
        Call jumlah()
        Call notis()

    End Sub

    Private Sub hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapus.Click

        If Me.txt_id.Text = "" Then
            MsgBox("PILIH SURAT YANG AKAN DIHAPUS")
            Me.txt_id.Focus()
            Exit Sub
        End If
        '-----------hapus----------

        Call Koneksi()
        If MessageBox.Show("Anda Yakin Akan Menghapus Surat Ini ? ", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim hapus As String = "delete from surat_masuk where id_surat_masuk = '" & txt_id.Text & "'"

            CMD = New SqlCommand(hapus, CONN)
            CMD.ExecuteNonQuery()
            CONN.Close()
            Call tampilgrid()
            Call jumlah()
            Call notis()
            Call kosongkan()

        Else
            Call kosongkan()
        End If
    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click

        Call Koneksi()
        Dim edit As String = "update surat_masuk set id_user ='" & MenuUtama.panelkode.Text & "',jenis_surat ='" & Me.cmbjenis.Text & "', tgl_surat='" & Format(DateValue(tgl_surat.Text), "MM/dd/yyyy") & "', tgl_terima ='" & Format(DateValue(tgl_terima.Text), "MM/dd/yyyy") & "', no_surat_masuk ='" & Me.txt_no_surat.Text & "', pengirim ='" & Me.txt_pengirim.Text & "', perihal ='" & Me.txt_perihal.Text & "', catatan ='" & Me.txt_ket.Text & "' where id_surat_masuk = '" & Me.txt_id.Text & "'"

        CMD = New SqlCommand(edit, CONN)
        CMD.ExecuteNonQuery()
        CONN.Close()
        Call notis()
        Call kosongkan()
        Call tampilgrid()
        Call jumlah()

    End Sub

    Private Sub tambahdispos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tambahdispos.Click

        Disposisi1.Show()
        Disposisi1.txtpengirim.Text = MenuUtama.panelnama.Text
        Disposisi1.txtno.Text = txt_no_surat.Text
        Disposisi1.tglsurat.Text = tgl_surat.Text
        Disposisi1.tglterima.Text = tgl_terima.Text
        Disposisi1.txtperihal.Text = txt_perihal.Text
        Disposisi1.cmbjenis.Text = cmbjenis.Text


        Dispose()


    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub cmbjenis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbjenis.SelectedIndexChanged

    End Sub
End Class