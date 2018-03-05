Imports System.Data.SqlClient
Public Class MenuUtama



    Private Sub user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user.Click
        Panel3.Controls.Clear()
        FormUser.TopLevel = False
        Panel3.Controls.Add(FormUser)
        FormUser.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Panel3.Controls.Clear()
        SuratMasuk.TopLevel = False
        Panel3.Controls.Add(SuratMasuk)
        SuratMasuk.Show()


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Panel3.Controls.Clear()
        SuratKeluar1.TopLevel = False
        Panel3.Controls.Add(SuratKeluar1)
        SuratKeluar1.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        LapSuratMasuk.Show()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        LapSuratKeluar.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        LapDisposisi.Show()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ExitYn = MsgBox("Apakah Anda Ingin Keluar ???", MsgBoxStyle.YesNo)
        If ExitYn = MsgBoxResult.Yes Then
            Close()
        Else
        End If

    End Sub

 
    Private Sub MenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class