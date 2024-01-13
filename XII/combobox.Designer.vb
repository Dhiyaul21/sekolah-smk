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
        Me.cmb_merk = New System.Windows.Forms.ComboBox()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_harga = New System.Windows.Forms.TextBox()
        Me.btn_cek = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmb_merk
        '
        Me.cmb_merk.FormattingEnabled = True
        Me.cmb_merk.Items.AddRange(New Object() {"01", "02", "03", "04", "05"})
        Me.cmb_merk.Location = New System.Drawing.Point(173, 122)
        Me.cmb_merk.Name = "cmb_merk"
        Me.cmb_merk.Size = New System.Drawing.Size(121, 28)
        Me.cmb_merk.TabIndex = 0
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(173, 275)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(100, 26)
        Me.txt_nama.TabIndex = 1
        '
        'txt_harga
        '
        Me.txt_harga.Location = New System.Drawing.Point(173, 307)
        Me.txt_harga.Name = "txt_harga"
        Me.txt_harga.Size = New System.Drawing.Size(100, 26)
        Me.txt_harga.TabIndex = 2
        '
        'btn_cek
        '
        Me.btn_cek.Location = New System.Drawing.Point(173, 207)
        Me.btn_cek.Name = "btn_cek"
        Me.btn_cek.Size = New System.Drawing.Size(75, 23)
        Me.btn_cek.TabIndex = 3
        Me.btn_cek.Text = "Button1"
        Me.btn_cek.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 420)
        Me.Controls.Add(Me.btn_cek)
        Me.Controls.Add(Me.txt_harga)
        Me.Controls.Add(Me.txt_nama)
        Me.Controls.Add(Me.cmb_merk)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_merk As System.Windows.Forms.ComboBox
    Friend WithEvents txt_nama As System.Windows.Forms.TextBox
    Friend WithEvents txt_harga As System.Windows.Forms.TextBox
    Friend WithEvents btn_cek As System.Windows.Forms.Button

End Class
