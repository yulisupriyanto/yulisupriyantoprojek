Imports System.Data.SqlClient
Public Class Disposisi1


    Sub gajadi()
        txtno.Text = ""
        txtpengirim.Text = ""
        txtperihal.Text = ""
        instruksi.Text = ""
        cmbjenis.Text = ""
        cmb_diteruskan.Text = ""
        tglterima.Text = ""
        tglditeruskan.Text = ""
        tglsurat.Text = ""
        isi_disposisi.Text = ""


    End Sub

    Sub notis()
        Call Koneksi()
        CMD = New SqlCommand("select id_disposisi from disposisi order by id_disposisi desc", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            txtid.Text = "No." + "0001"
        Else
            txtid.Text = "No." + Format(Microsoft.VisualBasic.Right(DR(0), 4) + 1, "0000")

        End If
        txtid.Enabled = False
        txtpengirim.Focus()
    End Sub

    Sub simpanId()
        If txtid.Text = "" Or txtno.Text = "" Or txtpengirim.Text = "" Or txtperihal.Text = "" Or instruksi.Text = "" Or cmbjenis.Text = "" Or cmb_diteruskan.Text = "" Or tglsurat.Text = "" Or tglterima.Text = "" Or tglditeruskan.Text = "" Or isi_disposisi.Text = "" Then
            MsgBox("Data Belum Lengkap")
            txtno.Focus()
            Exit Sub
        Else

            Call Koneksi()
            CMD = New SqlCommand("select * from disposisi where id_disposisi = '" & txtid.Text & "' ", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            Try
                If Not DR.HasRows Then
                    Call Koneksi()
                    Dim simpan As String = "insert into disposisi values('" & txtid.Text & "','" & txtno.Text & "','" & txtpengirim.Text & "','" & Format(DateValue(tglsurat.Text), "MM/dd/yyyy") & "','" & txtperihal.Text & "','" & instruksi.Text & "','" & cmbjenis.Text & "','" & cmb_diteruskan.Text & "','" & Format(DateValue(tglterima.Text), "MM/dd/yyyy") & "','" & Format(DateValue(tglditeruskan.Text), "MM/dd/yyyy") & "','" & isi_disposisi.Text & "')"
                    CMD = New SqlCommand(simpan, CONN)
                    CMD.ExecuteNonQuery()
                    CONN.Close()
                    Call gajadi()
                    Call notis()
                    txtno.Focus()

                    '---------------------------------
                    If MessageBox.Show("Cetak Surat ?", "Perhatian", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        Cetak1.Show()
                        Cetak1.CRV.ReportSource = "cetak_dis.rpt"
                        Cetak1.CRV.RefreshReport()
                    End If

                    '====================================


                End If
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        End If
    End Sub

    Private Sub Disposisi1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '======== Combo Box jenis surat =======
        Me.cmbjenis.Text = "-pilihan-"
        cmbjenis.Items.Add("PENTING")
        cmbjenis.Items.Add("UMUM")
        cmbjenis.Items.Add("PRIBADI")
        cmbjenis.Items.Add("RAHASIA")

        '======= Combo Box Diteruskan Kepada ====='
        Me.cmb_diteruskan.Text = " - PILIHAN - "
        cmb_diteruskan.Items.Add("KEPALA SEKOLAH")
        cmb_diteruskan.Items.Add("WAKIL KEPALA SEKOLAH")
        cmb_diteruskan.Items.Add("TATA USAHA")
        cmb_diteruskan.Items.Add("PIKET")
        cmb_diteruskan.Items.Add("WALI KELAS")
        cmb_diteruskan.Items.Add("HUBIN")
        cmb_diteruskan.Items.Add("BKK")
        cmb_diteruskan.Items.Add("BPBK")

        Call notis()
    End Sub

    Private Sub simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click
        Call simpanId()
    End Sub

    Private Sub batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batal.Click
        Call gajadi()
    End Sub

    Private Sub keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluar.Click
        ExitYn = MsgBox("Apakah Anda Ingin Keluar ???", MsgBoxStyle.YesNo)
        If ExitYn = MsgBoxResult.Yes Then
            Close()

        End If
    End Sub

End Class