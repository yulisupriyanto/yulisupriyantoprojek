<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuratMasuk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SuratMasuk))
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tambahdispos = New System.Windows.Forms.Label
        Me.edit = New System.Windows.Forms.Label
        Me.simpan = New System.Windows.Forms.Label
        Me.hapus = New System.Windows.Forms.Label
        Me.cari_data = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmbjenis = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_perihal = New System.Windows.Forms.TextBox
        Me.txt_id = New System.Windows.Forms.TextBox
        Me.txt_ket = New System.Windows.Forms.TextBox
        Me.tgl_terima = New System.Windows.Forms.DateTimePicker
        Me.txt_pengirim = New System.Windows.Forms.TextBox
        Me.tgl_surat = New System.Windows.Forms.DateTimePicker
        Me.txt_no_surat = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.jmlh = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MisterEarl BT", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(438, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Surat Masuk"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cmbjenis)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_perihal)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.txt_ket)
        Me.GroupBox1.Controls.Add(Me.tgl_terima)
        Me.GroupBox1.Controls.Add(Me.txt_pengirim)
        Me.GroupBox1.Controls.Add(Me.tgl_surat)
        Me.GroupBox1.Controls.Add(Me.txt_no_surat)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(913, 185)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tambahdispos)
        Me.GroupBox2.Controls.Add(Me.edit)
        Me.GroupBox2.Controls.Add(Me.simpan)
        Me.GroupBox2.Controls.Add(Me.hapus)
        Me.GroupBox2.Controls.Add(Me.cari_data)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(677, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(230, 167)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'tambahdispos
        '
        Me.tambahdispos.Font = New System.Drawing.Font("Tempus Sans ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tambahdispos.Image = Global.Surat_Masuk.My.Resources.Resources.add
        Me.tambahdispos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tambahdispos.Location = New System.Drawing.Point(128, 68)
        Me.tambahdispos.Name = "tambahdispos"
        Me.tambahdispos.Size = New System.Drawing.Size(76, 53)
        Me.tambahdispos.TabIndex = 14
        Me.tambahdispos.Text = "DISPOSISI"
        Me.tambahdispos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'edit
        '
        Me.edit.Font = New System.Drawing.Font("Tempus Sans ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit.Image = Global.Surat_Masuk.My.Resources.Resources.modify
        Me.edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.edit.Location = New System.Drawing.Point(16, 68)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(72, 53)
        Me.edit.TabIndex = 13
        Me.edit.Text = "EDIT"
        Me.edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'simpan
        '
        Me.simpan.Font = New System.Drawing.Font("Tempus Sans ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.simpan.Image = Global.Surat_Masuk.My.Resources.Resources.save
        Me.simpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.simpan.Location = New System.Drawing.Point(16, 10)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(75, 52)
        Me.simpan.TabIndex = 12
        Me.simpan.Text = "SIMPAN"
        Me.simpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'hapus
        '
        Me.hapus.Font = New System.Drawing.Font("Tempus Sans ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hapus.Image = Global.Surat_Masuk.My.Resources.Resources.forbidden
        Me.hapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.hapus.Location = New System.Drawing.Point(131, 10)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(73, 52)
        Me.hapus.TabIndex = 11
        Me.hapus.Text = "HAPUS"
        Me.hapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cari_data
        '
        Me.cari_data.Location = New System.Drawing.Point(110, 140)
        Me.cari_data.Name = "cari_data"
        Me.cari_data.Size = New System.Drawing.Size(114, 20)
        Me.cari_data.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Sneakerhead BTN Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 24)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Cari Data"
        '
        'cmbjenis
        '
        Me.cmbjenis.FormattingEnabled = True
        Me.cmbjenis.Location = New System.Drawing.Point(448, 86)
        Me.cmbjenis.Name = "cmbjenis"
        Me.cmbjenis.Size = New System.Drawing.Size(147, 21)
        Me.cmbjenis.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(351, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Jenis Surat"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Perihal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Id Surat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(350, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Keterangan Surat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(351, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Tanggal Terima"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "pengirim"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Tanggal Surat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(351, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "No Surat"
        '
        'txt_perihal
        '
        Me.txt_perihal.Location = New System.Drawing.Point(106, 98)
        Me.txt_perihal.Multiline = True
        Me.txt_perihal.Name = "txt_perihal"
        Me.txt_perihal.Size = New System.Drawing.Size(200, 46)
        Me.txt_perihal.TabIndex = 9
        '
        'txt_id
        '
        Me.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_id.Location = New System.Drawing.Point(106, 17)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(121, 20)
        Me.txt_id.TabIndex = 7
        '
        'txt_ket
        '
        Me.txt_ket.Location = New System.Drawing.Point(448, 113)
        Me.txt_ket.Name = "txt_ket"
        Me.txt_ket.Size = New System.Drawing.Size(200, 20)
        Me.txt_ket.TabIndex = 6
        '
        'tgl_terima
        '
        Me.tgl_terima.Location = New System.Drawing.Point(448, 60)
        Me.tgl_terima.Name = "tgl_terima"
        Me.tgl_terima.Size = New System.Drawing.Size(200, 20)
        Me.tgl_terima.TabIndex = 5
        '
        'txt_pengirim
        '
        Me.txt_pengirim.Location = New System.Drawing.Point(106, 43)
        Me.txt_pengirim.Name = "txt_pengirim"
        Me.txt_pengirim.Size = New System.Drawing.Size(121, 20)
        Me.txt_pengirim.TabIndex = 3
        '
        'tgl_surat
        '
        Me.tgl_surat.Location = New System.Drawing.Point(106, 69)
        Me.tgl_surat.Name = "tgl_surat"
        Me.tgl_surat.Size = New System.Drawing.Size(200, 20)
        Me.tgl_surat.TabIndex = 2
        '
        'txt_no_surat
        '
        Me.txt_no_surat.Location = New System.Drawing.Point(448, 19)
        Me.txt_no_surat.Name = "txt_no_surat"
        Me.txt_no_surat.Size = New System.Drawing.Size(121, 20)
        Me.txt_no_surat.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.jmlh)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.DGV)
        Me.GroupBox3.Location = New System.Drawing.Point(34, 304)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(913, 220)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'jmlh
        '
        Me.jmlh.Location = New System.Drawing.Point(160, 16)
        Me.jmlh.Name = "jmlh"
        Me.jmlh.Size = New System.Drawing.Size(146, 20)
        Me.jmlh.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 21)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Jumlah Surat Masuk"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(3, 48)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(904, 166)
        Me.DGV.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(34, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(913, 80)
        Me.Panel1.TabIndex = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Surat_Masuk.My.Resources.Resources.close
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(859, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 30)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(14, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 64)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'SuratMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1159, 610)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SuratMasuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SuratMasuk"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_perihal As System.Windows.Forms.TextBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_ket As System.Windows.Forms.TextBox
    Friend WithEvents tgl_terima As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_pengirim As System.Windows.Forms.TextBox
    Friend WithEvents tgl_surat As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_no_surat As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cari_data As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbjenis As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents hapus As System.Windows.Forms.Label
    Friend WithEvents simpan As System.Windows.Forms.Label
    Friend WithEvents edit As System.Windows.Forms.Label
    Friend WithEvents tambahdispos As System.Windows.Forms.Label
    Friend WithEvents jmlh As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
