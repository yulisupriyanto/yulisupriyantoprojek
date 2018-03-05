Imports System.Data.SqlClient
Public Class LapSuratMasuk

    Private Sub keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluar.Click
        ExitYn = MsgBox("Apa Anda Ingin Menutup Form ini?", MsgBoxStyle.YesNo)
        If ExitYn = MsgBoxResult.Yes Then
            Close()
        Else
        End If
    End Sub

    Private Sub btnMingguan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMingguan.Click
        CRV.ReportSource = Nothing
        CRV.RefreshReport()
        CRV.SelectionFormula = "({surat_masuk.tgl_surat}) in date ('" & mingguan1.Text & "') to date ('" & mingguan2.Text & "')"
        CRV.ReportSource = "mingguan.rpt"
    End Sub

    Private Sub btnBulanan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBulanan.Click
        CRV.SelectionFormula = "month({surat_masuk.tgl_surat})= (" & Month(bulanan.Text) & ") and year({surat_masuk.tgl_surat}) = (" & Year(mingguan2.Text) & ")"
        CRV.ReportSource = "SMbulanan.rpt"
        CRV.RefreshReport()

    End Sub

    Private Sub btnHarian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHarian.Click
        CRV.ReportSource = Nothing
        CRV.RefreshReport()
        CRV.SelectionFormula = "({surat_masuk.tgl_surat}) in date ('" & harian.Text & "')"
        CRV.ReportSource = "SMharian.rpt"
    End Sub

    Private Sub LapSuratMasuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class