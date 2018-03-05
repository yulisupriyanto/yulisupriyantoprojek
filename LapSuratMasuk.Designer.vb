<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LapSuratMasuk
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.harian = New System.Windows.Forms.DateTimePicker
        Me.mingguan1 = New System.Windows.Forms.DateTimePicker
        Me.mingguan2 = New System.Windows.Forms.DateTimePicker
        Me.bulanan = New System.Windows.Forms.DateTimePicker
        Me.CRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.btnBulanan = New System.Windows.Forms.Button
        Me.btnMingguan = New System.Windows.Forms.Button
        Me.btnHarian = New System.Windows.Forms.Button
        Me.keluar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.keluar)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(218, 741)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnHarian)
        Me.GroupBox2.Controls.Add(Me.harian)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 109)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "HARIAN"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnMingguan)
        Me.GroupBox3.Controls.Add(Me.mingguan1)
        Me.GroupBox3.Controls.Add(Me.mingguan2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 134)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 122)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "MINGGUAN"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnBulanan)
        Me.GroupBox4.Controls.Add(Me.bulanan)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 262)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 109)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "BULANAN"
        '
        'harian
        '
        Me.harian.Location = New System.Drawing.Point(6, 19)
        Me.harian.Name = "harian"
        Me.harian.Size = New System.Drawing.Size(188, 20)
        Me.harian.TabIndex = 0
        '
        'mingguan1
        '
        Me.mingguan1.Location = New System.Drawing.Point(6, 19)
        Me.mingguan1.Name = "mingguan1"
        Me.mingguan1.Size = New System.Drawing.Size(188, 20)
        Me.mingguan1.TabIndex = 1
        '
        'mingguan2
        '
        Me.mingguan2.Location = New System.Drawing.Point(6, 44)
        Me.mingguan2.Name = "mingguan2"
        Me.mingguan2.Size = New System.Drawing.Size(188, 20)
        Me.mingguan2.TabIndex = 2
        '
        'bulanan
        '
        Me.bulanan.Location = New System.Drawing.Point(6, 19)
        Me.bulanan.Name = "bulanan"
        Me.bulanan.Size = New System.Drawing.Size(188, 20)
        Me.bulanan.TabIndex = 3
        '
        'CRV
        '
        Me.CRV.ActiveViewIndex = -1
        Me.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV.Location = New System.Drawing.Point(218, 0)
        Me.CRV.Name = "CRV"
        Me.CRV.SelectionFormula = ""
        Me.CRV.Size = New System.Drawing.Size(1144, 741)
        Me.CRV.TabIndex = 1
        Me.CRV.ViewTimeSelectionFormula = ""
        '
        'btnBulanan
        '
        Me.btnBulanan.Location = New System.Drawing.Point(6, 80)
        Me.btnBulanan.Name = "btnBulanan"
        Me.btnBulanan.Size = New System.Drawing.Size(188, 23)
        Me.btnBulanan.TabIndex = 4
        Me.btnBulanan.Text = "TAMPIL"
        Me.btnBulanan.UseVisualStyleBackColor = True
        '
        'btnMingguan
        '
        Me.btnMingguan.Location = New System.Drawing.Point(6, 93)
        Me.btnMingguan.Name = "btnMingguan"
        Me.btnMingguan.Size = New System.Drawing.Size(188, 23)
        Me.btnMingguan.TabIndex = 5
        Me.btnMingguan.Text = "TAMPIL"
        Me.btnMingguan.UseVisualStyleBackColor = True
        '
        'btnHarian
        '
        Me.btnHarian.Location = New System.Drawing.Point(6, 80)
        Me.btnHarian.Name = "btnHarian"
        Me.btnHarian.Size = New System.Drawing.Size(188, 23)
        Me.btnHarian.TabIndex = 5
        Me.btnHarian.Text = "TAMPIL"
        Me.btnHarian.UseVisualStyleBackColor = True
        '
        'keluar
        '
        Me.keluar.Location = New System.Drawing.Point(67, 377)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(75, 23)
        Me.keluar.TabIndex = 3
        Me.keluar.Text = "keluar"
        Me.keluar.UseVisualStyleBackColor = True
        '
        'LapSuratMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.CRV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LapSuratMasuk"
        Me.Text = "LapSuratMasuk"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBulanan As System.Windows.Forms.Button
    Friend WithEvents bulanan As System.Windows.Forms.DateTimePicker
    Friend WithEvents mingguan1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents mingguan2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents harian As System.Windows.Forms.DateTimePicker
    Friend WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnMingguan As System.Windows.Forms.Button
    Friend WithEvents btnHarian As System.Windows.Forms.Button
    Friend WithEvents keluar As System.Windows.Forms.Button
End Class
