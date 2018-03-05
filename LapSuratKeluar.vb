Public Class LapSuratKeluar

    Private Sub LapSuratKeluar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluar.Click
        ExitYn = MsgBox("Apa Anda Ingin Menutup Form ini?", MsgBoxStyle.YesNo)
        If ExitYn = MsgBoxResult.Yes Then
            Close()
        Else
        End If
    End Sub

    Private Sub Tmingguan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tmingguan.Click
        CRV.ReportSource = Nothing
        CRV.RefreshReport()
        CRV.SelectionFormula = "({surat_keluar.tgl_kirim}) in date ('" & dtpawal.Text & "') to date ('" & dtpakhir.Text & "')"
        CRV.ReportSource = "SKmingguan2.rpt"
    End Sub

    Private Sub Tharian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tharian.Click
        CRV.ReportSource = Nothing
        CRV.RefreshReport()
        CRV.SelectionFormula = "({surat_keluar.tgl_kirim}) in date ('" & dtpharian.Text & "')"
        CRV.ReportSource = "SKharian.rpt"
    End Sub

    Private Sub Tbulanan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbulanan.Click
        CRV.SelectionFormula = "month({surat_keluar.tgl_kirim})= (" & Month(dtpbulanan.Text) & ") and year({surat_keluar.tgl_kirim}) = (" & Year(dtpakhir.Text) & ")"
        CRV.ReportSource = "SKbulanan.rpt"
        CRV.RefreshReport()
    End Sub
End Class