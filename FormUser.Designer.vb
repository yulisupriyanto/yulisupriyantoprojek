<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUser))
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.cari_data = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.status = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.pwd = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.nama_user = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.id_user = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.keluar = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.save = New System.Windows.Forms.PictureBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.delet = New System.Windows.Forms.PictureBox
        Me.edit = New System.Windows.Forms.PictureBox
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keluar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.save, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.delet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(14, 15)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(449, 140)
        Me.DGV.TabIndex = 0
        '
        'cari_data
        '
        Me.cari_data.Location = New System.Drawing.Point(404, 181)
        Me.cari_data.Name = "cari_data"
        Me.cari_data.Size = New System.Drawing.Size(215, 20)
        Me.cari_data.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(286, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Password"
        '
        'status
        '
        Me.status.FormattingEnabled = True
        Me.status.Items.AddRange(New Object() {"ADMIN", "USER", "OP", "PELAJAR", "GURU"})
        Me.status.Location = New System.Drawing.Point(404, 24)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(175, 21)
        Me.status.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID User"
        '
        'pwd
        '
        Me.pwd.Location = New System.Drawing.Point(403, 63)
        Me.pwd.Name = "pwd"
        Me.pwd.Size = New System.Drawing.Size(176, 20)
        Me.pwd.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama User"
        '
        'nama_user
        '
        Me.nama_user.Location = New System.Drawing.Point(128, 62)
        Me.nama_user.Name = "nama_user"
        Me.nama_user.Size = New System.Drawing.Size(127, 20)
        Me.nama_user.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(286, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Status"
        '
        'id_user
        '
        Me.id_user.Location = New System.Drawing.Point(127, 24)
        Me.id_user.Name = "id_user"
        Me.id_user.Size = New System.Drawing.Size(128, 20)
        Me.id_user.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 42)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "USER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.keluar)
        Me.Panel1.Location = New System.Drawing.Point(127, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(634, 85)
        Me.Panel1.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 79)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'keluar
        '
        Me.keluar.BackgroundImage = Global.Surat_Masuk.My.Resources.Resources.close
        Me.keluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keluar.Location = New System.Drawing.Point(599, 6)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(30, 25)
        Me.keluar.TabIndex = 18
        Me.keluar.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.Controls.Add(Me.save)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.cari_data)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.status)
        Me.Panel2.Controls.Add(Me.id_user)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.pwd)
        Me.Panel2.Controls.Add(Me.nama_user)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(127, 112)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(634, 217)
        Me.Panel2.TabIndex = 19
        '
        'save
        '
        Me.save.BackgroundImage = Global.Surat_Masuk.My.Resources.Resources.save
        Me.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.save.Location = New System.Drawing.Point(46, 165)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(43, 45)
        Me.save.TabIndex = 20
        Me.save.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(287, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "CARI DATA"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel3.Controls.Add(Me.delet)
        Me.Panel3.Controls.Add(Me.DGV)
        Me.Panel3.Controls.Add(Me.edit)
        Me.Panel3.Location = New System.Drawing.Point(127, 329)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(634, 169)
        Me.Panel3.TabIndex = 20
        '
        'delet
        '
        Me.delet.BackgroundImage = Global.Surat_Masuk.My.Resources.Resources.forbidden
        Me.delet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.delet.Location = New System.Drawing.Point(480, 15)
        Me.delet.Name = "delet"
        Me.delet.Size = New System.Drawing.Size(45, 45)
        Me.delet.TabIndex = 21
        Me.delet.TabStop = False
        '
        'edit
        '
        Me.edit.BackgroundImage = Global.Surat_Masuk.My.Resources.Resources.modify
        Me.edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.edit.Location = New System.Drawing.Point(553, 15)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(43, 45)
        Me.edit.TabIndex = 19
        Me.edit.TabStop = False
        '
        'FormUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1159, 610)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keluar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.save, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.delet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents cari_data As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents status As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pwd As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nama_user As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents id_user As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents delet As System.Windows.Forms.PictureBox
    Friend WithEvents keluar As System.Windows.Forms.PictureBox
    Friend WithEvents save As System.Windows.Forms.PictureBox
    Friend WithEvents edit As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
