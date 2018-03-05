Imports System.Data.SqlClient
Module Module1
    Public CONN As SqlConnection
    Public DA As SqlDataAdapter
    Public DS As DataSet
    Public CMD As SqlCommand
    Public DR As SqlDataReader
    Public ExitYn As System.Windows.Forms.DialogResult

    Public Sub Koneksi()
        CONN = New SqlConnection("data source=KHN-CB0FQC7\sqlexpress; initial catalog=surat;integrated security=true")
        CONN.Open()
    End Sub
End Module
