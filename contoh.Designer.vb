<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class contoh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(contoh))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.save = New System.Windows.Forms.PictureBox
        Me.id_petugas = New System.Windows.Forms.TextBox
        Me.edit = New System.Windows.Forms.PictureBox
        Me.delet = New System.Windows.Forms.PictureBox
        Me.DGV1 = New System.Windows.Forms.DataGridView
        Me.cari = New System.Windows.Forms.TextBox
        Me.tglkirim = New System.Windows.Forms.DateTimePicker
        Me.jmlh = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.keluar = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_perihal = New System.Windows.Forms.TextBox
        Me.pengirim = New System.Windows.Forms.TextBox
        Me.txt_no_surat = New System.Windows.Forms.TextBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.keterangan = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmb_jenis = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.no_agenda = New System.Windows.Forms.TextBox
        CType(Me.save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.delet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keluar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Jumlah Surat Keluar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 16)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Id Petugas"
        '
        'save
        '
        Me.save.BackgroundImage = Global.Surat_Masuk.My.Resources.Resources.floppy_128
        Me.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.save.Location = New System.Drawing.Point(286, 229)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(73, 49)
        Me.save.TabIndex = 18
        Me.save.TabStop = False
        Me.save.Tag = ""
        '
        'id_petugas
        '
        Me.id_petugas.Location = New System.Drawing.Point(144, 56)
        Me.id_petugas.Name = "id_petugas"
        Me.id_petugas.Size = New System.Drawing.Size(154, 20)
        Me.id_petugas.TabIndex = 36
        '
        'edit
        '
        Me.edit.BackgroundImage = Global.Surat_Masuk.My.Resources.Resources.modify
        Me.edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.edit.Location = New System.Drawing.Point(400, 229)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(58, 49)
        Me.edit.TabIndex = 17
        Me.edit.TabStop = False
        '
        'delet
        '
        Me.delet.BackgroundImage = CType(resources.GetObject("delet.BackgroundImage"), System.Drawing.Image)
        Me.delet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.delet.Location = New System.Drawing.Point(499, 229)
        Me.delet.Name = "delet"
        Me.delet.Size = New System.Drawing.Size(63, 49)
        Me.delet.TabIndex = 15
        Me.delet.TabStop = False
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(5, 16)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(601, 200)
        Me.DGV1.TabIndex = 0
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(16, 254)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(154, 20)
        Me.cari.TabIndex = 5
        '
        'tglkirim
        '
        Me.tglkirim.Location = New System.Drawing.Point(143, 108)
        Me.tglkirim.Name = "tglkirim"
        Me.tglkirim.Size = New System.Drawing.Size(192, 20)
        Me.tglkirim.TabIndex = 35
        '
        'jmlh
        '
        Me.jmlh.Location = New System.Drawing.Point(156, 295)
        Me.jmlh.Name = "jmlh"
        Me.jmlh.Size = New System.Drawing.Size(118, 20)
        Me.jmlh.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "No Agenda"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Thistle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.keluar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(23, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(950, 110)
        Me.Panel1.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(17, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 104)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'keluar
        '
        Me.keluar.BackgroundImage = Global.Surat_Masuk.My.Resources.Resources.close
        Me.keluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keluar.Location = New System.Drawing.Point(908, 13)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(30, 29)
        Me.keluar.TabIndex = 14
        Me.keluar.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Poor Richard", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(368, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SURAT KELUAR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_perihal
        '
        Me.txt_perihal.Location = New System.Drawing.Point(143, 186)
        Me.txt_perihal.Name = "txt_perihal"
        Me.txt_perihal.Size = New System.Drawing.Size(154, 20)
        Me.txt_perihal.TabIndex = 21
        '
        'pengirim
        '
        Me.pengirim.Location = New System.Drawing.Point(143, 161)
        Me.pengirim.Name = "pengirim"
        Me.pengirim.Size = New System.Drawing.Size(154, 20)
        Me.pengirim.TabIndex = 20
        '
        'txt_no_surat
        '
        Me.txt_no_surat.Location = New System.Drawing.Point(144, 82)
        Me.txt_no_surat.Name = "txt_no_surat"
        Me.txt_no_surat.Size = New System.Drawing.Size(154, 20)
        Me.txt_no_surat.TabIndex = 19
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Violet
        Me.Panel4.Controls.Add(Me.jmlh)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.save)
        Me.Panel4.Controls.Add(Me.edit)
        Me.Panel4.Controls.Add(Me.delet)
        Me.Panel4.Controls.Add(Me.DGV1)
        Me.Panel4.Controls.Add(Me.cari)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Location = New System.Drawing.Point(364, 137)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(609, 334)
        Me.Panel4.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(43, 227)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 18)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Cari Data"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 16)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Keterangan"
        '
        'keterangan
        '
        Me.keterangan.Location = New System.Drawing.Point(143, 216)
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Size = New System.Drawing.Size(154, 20)
        Me.keterangan.TabIndex = 33
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Plum
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.id_petugas)
        Me.Panel2.Controls.Add(Me.tglkirim)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.keterangan)
        Me.Panel2.Controls.Add(Me.cmb_jenis)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txt_perihal)
        Me.Panel2.Controls.Add(Me.pengirim)
        Me.Panel2.Controls.Add(Me.txt_no_surat)
        Me.Panel2.Controls.Add(Me.no_agenda)
        Me.Panel2.Location = New System.Drawing.Point(23, 137)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(341, 334)
        Me.Panel2.TabIndex = 12
        '
        'cmb_jenis
        '
        Me.cmb_jenis.FormattingEnabled = True
        Me.cmb_jenis.Location = New System.Drawing.Point(143, 134)
        Me.cmb_jenis.Name = "cmb_jenis"
        Me.cmb_jenis.Size = New System.Drawing.Size(154, 21)
        Me.cmb_jenis.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 16)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Jenis Surat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Perihal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Pengirim"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "No Surat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Tanggal Kirim"
        '
        'no_agenda
        '
        Me.no_agenda.Location = New System.Drawing.Point(144, 30)
        Me.no_agenda.Name = "no_agenda"
        Me.no_agenda.Size = New System.Drawing.Size(154, 20)
        Me.no_agenda.TabIndex = 17
        '
        'contoh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 499)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "contoh"
        Me.Text = "contoh"
        CType(Me.save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.delet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keluar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents save As System.Windows.Forms.PictureBox
    Friend WithEvents id_petugas As System.Windows.Forms.TextBox
    Friend WithEvents edit As System.Windows.Forms.PictureBox
    Friend WithEvents delet As System.Windows.Forms.PictureBox
    Friend WithEvents DGV1 As System.Windows.Forms.DataGridView
    Friend WithEvents cari As System.Windows.Forms.TextBox
    Friend WithEvents tglkirim As System.Windows.Forms.DateTimePicker
    Friend WithEvents jmlh As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents keluar As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_perihal As System.Windows.Forms.TextBox
    Friend WithEvents pengirim As System.Windows.Forms.TextBox
    Friend WithEvents txt_no_surat As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents keterangan As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmb_jenis As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents no_agenda As System.Windows.Forms.TextBox
End Class
