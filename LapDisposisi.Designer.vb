<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LapDisposisi
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
        Me.keluar = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.dtpakhir = New System.Windows.Forms.DateTimePicker
        Me.dtpawal = New System.Windows.Forms.DateTimePicker
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.dtpbulanan = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.dtpharian = New System.Windows.Forms.DateTimePicker
        Me.CRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.keluar)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 727)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'keluar
        '
        Me.keluar.Location = New System.Drawing.Point(65, 380)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(75, 23)
        Me.keluar.TabIndex = 4
        Me.keluar.Text = "keluar"
        Me.keluar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.dtpakhir)
        Me.GroupBox3.Controls.Add(Me.dtpawal)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 118)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(188, 137)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "MINGGUAN"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 108)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(176, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "TAMPIL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dtpakhir
        '
        Me.dtpakhir.Location = New System.Drawing.Point(6, 45)
        Me.dtpakhir.Name = "dtpakhir"
        Me.dtpakhir.Size = New System.Drawing.Size(176, 20)
        Me.dtpakhir.TabIndex = 2
        '
        'dtpawal
        '
        Me.dtpawal.Location = New System.Drawing.Point(6, 19)
        Me.dtpawal.Name = "dtpawal"
        Me.dtpawal.Size = New System.Drawing.Size(176, 20)
        Me.dtpawal.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.dtpbulanan)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 261)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(188, 100)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "BULANAN"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 71)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(176, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "TAMPIL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dtpbulanan
        '
        Me.dtpbulanan.Location = New System.Drawing.Point(6, 19)
        Me.dtpbulanan.Name = "dtpbulanan"
        Me.dtpbulanan.Size = New System.Drawing.Size(176, 20)
        Me.dtpbulanan.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.dtpharian)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(188, 100)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "HARIAN"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "TAMPIL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpharian
        '
        Me.dtpharian.Location = New System.Drawing.Point(6, 19)
        Me.dtpharian.Name = "dtpharian"
        Me.dtpharian.Size = New System.Drawing.Size(176, 20)
        Me.dtpharian.TabIndex = 0
        '
        'CRV
        '
        Me.CRV.ActiveViewIndex = -1
        Me.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV.Location = New System.Drawing.Point(200, 0)
        Me.CRV.Name = "CRV"
        Me.CRV.SelectionFormula = ""
        Me.CRV.Size = New System.Drawing.Size(1162, 727)
        Me.CRV.TabIndex = 1
        Me.CRV.ViewTimeSelectionFormula = ""
        '
        'LapDisposisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 727)
        Me.Controls.Add(Me.CRV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LapDisposisi"
        Me.Text = "LapDisposisi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dtpakhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpawal As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents dtpbulanan As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtpharian As System.Windows.Forms.DateTimePicker
    Friend WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents keluar As System.Windows.Forms.Button
End Class
