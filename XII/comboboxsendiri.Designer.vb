<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cmb_jenis = New System.Windows.Forms.ComboBox()
        Me.cmd_merk = New System.Windows.Forms.ComboBox()
        Me.txt_hasil = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmb_jenis
        '
        Me.cmb_jenis.FormattingEnabled = True
        Me.cmb_jenis.Items.AddRange(New Object() {"Gaming", "Office"})
        Me.cmb_jenis.Location = New System.Drawing.Point(231, 104)
        Me.cmb_jenis.Name = "cmb_jenis"
        Me.cmb_jenis.Size = New System.Drawing.Size(121, 28)
        Me.cmb_jenis.TabIndex = 0
        '
        'cmd_merk
        '
        Me.cmd_merk.FormattingEnabled = True
        Me.cmd_merk.Items.AddRange(New Object() {"Asus", "Lenovo", "MSI"})
        Me.cmd_merk.Location = New System.Drawing.Point(231, 161)
        Me.cmd_merk.Name = "cmd_merk"
        Me.cmd_merk.Size = New System.Drawing.Size(121, 28)
        Me.cmd_merk.TabIndex = 1
        '
        'txt_hasil
        '
        Me.txt_hasil.Location = New System.Drawing.Point(231, 244)
        Me.txt_hasil.Name = "txt_hasil"
        Me.txt_hasil.Size = New System.Drawing.Size(251, 26)
        Me.txt_hasil.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(231, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Masukan Jenis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(231, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Masukan Merk"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 400)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_hasil)
        Me.Controls.Add(Me.cmd_merk)
        Me.Controls.Add(Me.cmb_jenis)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_jenis As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_merk As System.Windows.Forms.ComboBox
    Friend WithEvents txt_hasil As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
