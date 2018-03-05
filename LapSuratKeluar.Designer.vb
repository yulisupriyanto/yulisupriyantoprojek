<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LapSuratKeluar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.dtpawal = New System.Windows.Forms.DateTimePicker
        Me.dtpakhir = New System.Windows.Forms.DateTimePicker
        Me.dtpharian = New System.Windows.Forms.DateTimePicker
        Me.dtpbulanan = New System.Windows.Forms.DateTimePicker
        Me.Tharian = New System.Windows.Forms.Button
        Me.Tmingguan = New System.Windows.Forms.Button
        Me.Tbulanan = New System.Windows.Forms.Button
        Me.keluar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkSalmon
        Me.GroupBox1.Controls.Add(Me.keluar)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(212, 741)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CRV
        '
        Me.CRV.ActiveViewIndex = -1
        Me.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV.Location = New System.Drawing.Point(212, 0)
        Me.CRV.Name = "CRV"
        Me.CRV.SelectionFormula = ""
        Me.CRV.Size = New System.Drawing.Size(921, 741)
        Me.CRV.TabIndex = 1
        Me.CRV.ViewTimeSelectionFormula = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Tharian)
        Me.GroupBox2.Controls.Add(Me.dtpharian)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 108)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "HARIAN"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Tmingguan)
        Me.GroupBox3.Controls.Add(Me.dtpakhir)
        Me.GroupBox3.Controls.Add(Me.dtpawal)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 126)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 124)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "MINGGUAN"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Tbulanan)
        Me.GroupBox4.Controls.Add(Me.dtpbulanan)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 256)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 108)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "BULANAN"
        '
        'dtpawal
        '
        Me.dtpawal.Location = New System.Drawing.Point(6, 19)
        Me.dtpawal.Name = "dtpawal"
        Me.dtpawal.Size = New System.Drawing.Size(188, 20)
        Me.dtpawal.TabIndex = 0
        '
        'dtpakhir
        '
        Me.dtpakhir.Location = New System.Drawing.Point(6, 45)
        Me.dtpakhir.Name = "dtpakhir"
        Me.dtpakhir.Size = New System.Drawing.Size(188, 20)
        Me.dtpakhir.TabIndex = 1
        '
        'dtpharian
        '
        Me.dtpharian.Location = New System.Drawing.Point(6, 19)
        Me.dtpharian.Name = "dtpharian"
        Me.dtpharian.Size = New System.Drawing.Size(188, 20)
        Me.dtpharian.TabIndex = 1
        '
        'dtpbulanan
        '
        Me.dtpbulanan.Location = New System.Drawing.Point(6, 19)
        Me.dtpbulanan.Name = "dtpbulanan"
        Me.dtpbulanan.Size = New System.Drawing.Size(188, 20)
        Me.dtpbulanan.TabIndex = 1
        '
        'Tharian
        '
        Me.Tharian.Location = New System.Drawing.Point(6, 79)
        Me.Tharian.Name = "Tharian"
        Me.Tharian.Size = New System.Drawing.Size(188, 23)
        Me.Tharian.TabIndex = 2
        Me.Tharian.Text = "Tampil"
        Me.Tharian.UseVisualStyleBackColor = True
        '
        'Tmingguan
        '
        Me.Tmingguan.Location = New System.Drawing.Point(6, 95)
        Me.Tmingguan.Name = "Tmingguan"
        Me.Tmingguan.Size = New System.Drawing.Size(188, 23)
        Me.Tmingguan.TabIndex = 3
        Me.Tmingguan.Text = "Tampil"
        Me.Tmingguan.UseVisualStyleBackColor = True
        '
        'Tbulanan
        '
        Me.Tbulanan.Location = New System.Drawing.Point(6, 79)
        Me.Tbulanan.Name = "Tbulanan"
        Me.Tbulanan.Size = New System.Drawing.Size(188, 23)
        Me.Tbulanan.TabIndex = 3
        Me.Tbulanan.Text = "Tampil"
        Me.Tbulanan.UseVisualStyleBackColor = True
        '
        'keluar
        '
        Me.keluar.Location = New System.Drawing.Point(53, 389)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(75, 23)
        Me.keluar.TabIndex = 2
        Me.keluar.Text = "Keluar"
        Me.keluar.UseVisualStyleBackColor = True
        '
        'LapSuratKeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 741)
        Me.Controls.Add(Me.CRV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LapSuratKeluar"
        Me.Text = "LapSuratKeluar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpakhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpawal As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpbulanan As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpharian As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tmingguan As System.Windows.Forms.Button
    Friend WithEvents Tbulanan As System.Windows.Forms.Button
    Friend WithEvents Tharian As System.Windows.Forms.Button
    Friend WithEvents keluar As System.Windows.Forms.Button
End Class
