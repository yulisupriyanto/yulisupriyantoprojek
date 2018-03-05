Public Class LapDisposisi

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CRV.ReportSource = Nothing
        CRV.RefreshReport()
        CRV.SelectionFormula = "({disposisi.tgl_surat}) in date ('" & dtpharian.Text & "')"
        CRV.ReportSource = "dpharianbaru.rpt"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CRV.ReportSource = Nothing
        CRV.RefreshReport()
        CRV.SelectionFormula = "({disposisi.tgl_surat}) in date ('" & dtpawal.Text & "') to date ('" & dtpakhir.Text & "')"
        CRV.ReportSource = "dpmingguanbaru.rpt"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CRV.SelectionFormula = "month({disposisi.tgl_surat})= (" & Month(dtpbulanan.Text) & ") and year({disposisi.tgl_surat}) = (" & Year(dtpakhir.Text) & ")"
        CRV.ReportSource = "dpbulananbaru.rpt"
        CRV.RefreshReport()
    End Sub

    Private Sub keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluar.Click
        ExitYn = MsgBox("Apa Anda Ingin Menutup Form ini?", MsgBoxStyle.YesNo)
        If ExitYn = MsgBoxResult.Yes Then
            Close()
        Else
        End If
    End Sub

    Private Sub LapDisposisi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class