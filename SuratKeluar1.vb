Imports System.Data.SqlClient

Public Class SuratKeluar1


    Sub gajadi()
        cmb_jenis.Text = "-Pilihan-"
        tglkirim.Text = Today
        keterangan.Text = ""
        pengirim.Text = ""
        txt_perihal.Text = ""
        txt_no_surat.Text = ""
    End Sub
    Sub TampilSurat()
        Call Koneksi()
        da = New SqlDataAdapter("select * from surat_keluar", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV1.DataSource = DS.Tables(0)

    End Sub
    Sub kodesurat()
        Call Koneksi()
        CMD = New SqlCommand("select no_agenda from surat_keluar order by no_agenda desc", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            no_agenda.Text = "SK" + "0001"
        Else
            no_agenda.Text = "SK" + Format(Microsoft.VisualBasic.Right(DR(0), 4) + 1, "0000")

        End If
        no_agenda.Enabled = False
        pengirim.Focus()
    End Sub
    Sub jumlah()
        Call koneksi()
        da = New SqlDataAdapter("select * from surat_keluar", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV1.DataSource = DS.Tables(0)
        jmlh.Text = DGV1.RowCount - 1
    End Sub
    Sub idpetugas()
        Call Koneksi()
        cmd = New SqlCommand("select id_petugas from surat_keluar order by id_petugas desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            id_petugas.Text = "P" + "0001"
        Else
            id_petugas.Text = "P" + Format(Microsoft.VisualBasic.Right(DR(0), 4) + 1, "0000")

        End If
        id_petugas.Enabled = False
        pengirim.Focus()
    End Sub
    Sub SimpanSurat()
        If txt_no_surat.Text = "" Or no_agenda.Text = "" Or cmb_jenis.Text = "" Or id_petugas.Text = "" Or keterangan.Text = "" Or pengirim.Text = "" Or txt_perihal.Text = "" Or tglkirim.Text = "" Or txt_perihal.Text = "" Then
            MsgBox("Data Belum Lengkap")
            txt_no_surat.Focus()
            Exit Sub
        Else

            Call Koneksi()
            CMD = New SqlCommand("select * from surat_keluar where no_agenda = '" & no_agenda.Text & "' ", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            Try
                If Not DR.HasRows Then
                    Call Koneksi()
                    Dim simpan As String = "insert into surat_keluar values('" & no_agenda.Text & "','" & id_petugas.Text & "','" & cmb_jenis.Text & "','" & Format(DateValue(tglkirim.Text), "MM/dd/yyyy") & "','" & txt_no_surat.Text & "','" & pengirim.Text & "','" & txt_perihal.Text & "','" & keterangan.Text & "')"
                    CMD = New SqlCommand(simpan, CONN)
                    CMD.ExecuteNonQuery()
                    CONN.Close()
                    Call gajadi()
                    Call TampilSurat()
                    Call jumlah()
                    Call kodesurat()
                    Call idpetugas()
                    txt_no_surat.Focus()
                Else
                    Call Koneksi()
                    Dim edit As String = "update surat_keluar set id_petugas='" & id_petugas.Text & "',jenis_surat='" & cmb_jenis.Text & "',tgl_kirim='" & Format(DateValue(tglkirim.Text), "MM/dd/yyyy") & "',no_surat = '" & txt_no_surat.Text & "',pengirim='" & pengirim.Text & "', perihal='" & txt_perihal.Text & "', keterangan='" & keterangan.Text & "'where no_agenda = '" & Me.no_agenda.Text & "'"

                    CMD = New SqlCommand(edit, CONN)
                    CMD.ExecuteNonQuery()
                    CONN.Close()
                    Call gajadi()
                    Call jumlah()
                    Call TampilSurat()
                    Call kodesurat()
                    Call idpetugas()

                    no_agenda.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
    Sub HapusSurat()
        If no_agenda.Text = "" Then
            MsgBox("Pilih Surat Yang Akan Dihapus")
            pengirim.Focus()
            Exit Sub
        Else
            Call Koneksi()
            If MessageBox.Show("Hapus data ini?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String = "delete from surat_keluar where no_agenda = '" & no_agenda.Text & "'"
                CMD = New SqlCommand(hapus, CONN)
                CMD.ExecuteNonQuery()
                CONN.Close()
                Call gajadi()
                Call TampilSurat()
                Call jumlah()
            Else
                Call gajadi()
            End If
        End If
    End Sub

    Private Sub SuratKeluar1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '======== Combo Box jenis surat =======
        Me.cmb_jenis.Text = "-pilihan-"
        cmb_jenis.Items.Add("PENTING")
        cmb_jenis.Items.Add("UMUM")
        cmb_jenis.Items.Add("PRIBADI")
        cmb_jenis.Items.Add("RAHASIA")
        Call gajadi()
        Call TampilSurat()
        Call kodesurat()
        Call jumlah()
        Call idpetugas()
    End Sub

    Private Sub DGV1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV1.CellContentClick
       
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        Call SimpanSurat()

    End Sub

    Private Sub delet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delet.Click
        Call HapusSurat()

    End Sub

    Private Sub keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluar.Click
        ExitYn = MsgBox("Apa Anda Ingin Menutup Form ini?", MsgBoxStyle.YesNo)
        If ExitYn = MsgBoxResult.Yes Then
            Close()
        Else
        End If
    End Sub

    Private Sub cari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cari.TextChanged
        Call Koneksi()
        CMD = New SqlCommand("select * from surat_keluar where no_surat like '%" & Me.cari.Text & "%'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then

            Call Koneksi()
            DA = New SqlDataAdapter("select * from surat_keluar where no_surat like '%" & Me.cari.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            Me.DGV1.DataSource = DS.Tables(0)

        Else
            MsgBox("Surat tidak ditemukan")
        End If
    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        '----------------EDIT------------
        Call Koneksi()
        Dim edit As String = "update surat_keluar set id_petugas ='" & id_petugas.Text & "', jenis_surat ='" & Me.cmb_jenis.Text & "', tgl_kirim ='" & Format(DateValue(tglkirim.Text), "MM/dd/yyyy") & "', no_surat ='" & txt_no_surat.Text & "', pengirim ='" & Me.pengirim.Text & "', perihal ='" & txt_perihal.Text & "', keterangan ='" & Me.keterangan.Text & "' where no_agenda = '" & Me.no_agenda.Text & "'"
        CMD = New SqlCommand(edit, CONN)
        CMD.ExecuteNonQuery()
        CONN.Close()
        Call kodesurat()
        Call jumlah()
        Call gajadi()
        Call TampilSurat()
    End Sub

    Private Sub DGV1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV1.CellMouseClick
        no_agenda.Text = DGV1.Rows(e.RowIndex).Cells(0).Value
        id_petugas.Text = DGV1.Rows(e.RowIndex).Cells(1).Value
        cmb_jenis.Text = DGV1.Rows(e.RowIndex).Cells(2).Value
        tglkirim.Text = DGV1.Rows(e.RowIndex).Cells(3).Value
        txt_no_surat.Text = DGV1.Rows(e.RowIndex).Cells(4).Value
        pengirim.Text = DGV1.Rows(e.RowIndex).Cells(5).Value
        txt_perihal.Text = DGV1.Rows(e.RowIndex).Cells(6).Value
        keterangan.Text = DGV1.Rows(e.RowIndex).Cells(7).Value
    End Sub
End Class