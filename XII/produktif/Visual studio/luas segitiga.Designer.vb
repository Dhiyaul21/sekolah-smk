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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_alas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_tinggi = New System.Windows.Forms.TextBox()
        Me.btn_hitung = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_hasil = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aplikasi Mencari Luas Segitiga"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Masukan Ukuran Alas"
        '
        'txt_alas
        '
        Me.txt_alas.Location = New System.Drawing.Point(99, 96)
        Me.txt_alas.Name = "txt_alas"
        Me.txt_alas.Size = New System.Drawing.Size(100, 26)
        Me.txt_alas.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Masukan Ukuran Tinggi"
        '
        'txt_tinggi
        '
        Me.txt_tinggi.Location = New System.Drawing.Point(99, 181)
        Me.txt_tinggi.Name = "txt_tinggi"
        Me.txt_tinggi.Size = New System.Drawing.Size(100, 26)
        Me.txt_tinggi.TabIndex = 4
        '
        'btn_hitung
        '
        Me.btn_hitung.Location = New System.Drawing.Point(99, 230)
        Me.btn_hitung.Name = "btn_hitung"
        Me.btn_hitung.Size = New System.Drawing.Size(100, 42)
        Me.btn_hitung.TabIndex = 5
        Me.btn_hitung.Text = "Hitung"
        Me.btn_hitung.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Hasil"
        '
        'txt_hasil
        '
        Me.txt_hasil.Location = New System.Drawing.Point(99, 314)
        Me.txt_hasil.Name = "txt_hasil"
        Me.txt_hasil.Size = New System.Drawing.Size(100, 26)
        Me.txt_hasil.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 352)
        Me.Controls.Add(Me.txt_hasil)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_hitung)
        Me.Controls.Add(Me.txt_tinggi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_alas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_alas As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_tinggi As System.Windows.Forms.TextBox
    Friend WithEvents btn_hitung As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_hasil As System.Windows.Forms.TextBox

End Class
