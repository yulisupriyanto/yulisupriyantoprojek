<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class test
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.S_id = New System.Windows.Forms.ToolStripStatusLabel
        Me.S_nama = New System.Windows.Forms.ToolStripStatusLabel
        Me.S_status = New System.Windows.Forms.ToolStripStatusLabel
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.S_id, Me.S_nama, Me.S_status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 239)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(496, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'S_id
        '
        Me.S_id.Name = "S_id"
        Me.S_id.Size = New System.Drawing.Size(120, 17)
        Me.S_id.Text = "ToolStripStatusLabel1"
        '
        'S_nama
        '
        Me.S_nama.Name = "S_nama"
        Me.S_nama.Size = New System.Drawing.Size(120, 17)
        Me.S_nama.Text = "ToolStripStatusLabel2"
        '
        'S_status
        '
        Me.S_status.Name = "S_status"
        Me.S_status.Size = New System.Drawing.Size(120, 17)
        Me.S_status.Text = "ToolStripStatusLabel3"
        '
        'test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 261)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "test"
        Me.Text = "test"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents S_id As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents S_nama As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents S_status As System.Windows.Forms.ToolStripStatusLabel
End Class
