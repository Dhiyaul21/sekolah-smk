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
        Me.txt_a = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_b = New System.Windows.Forms.TextBox()
        Me.txt_hasil = New System.Windows.Forms.TextBox()
        Me.btn_proses = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_a
        '
        Me.txt_a.Location = New System.Drawing.Point(252, 94)
        Me.txt_a.Name = "txt_a"
        Me.txt_a.Size = New System.Drawing.Size(100, 26)
        Me.txt_a.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Contoh Penerapan Tipe Data Array"
        '
        'txt_b
        '
        Me.txt_b.Location = New System.Drawing.Point(252, 137)
        Me.txt_b.Name = "txt_b"
        Me.txt_b.Size = New System.Drawing.Size(100, 26)
        Me.txt_b.TabIndex = 2
        '
        'txt_hasil
        '
        Me.txt_hasil.Location = New System.Drawing.Point(252, 241)
        Me.txt_hasil.Name = "txt_hasil"
        Me.txt_hasil.Size = New System.Drawing.Size(100, 26)
        Me.txt_hasil.TabIndex = 3
        '
        'btn_proses
        '
        Me.btn_proses.Location = New System.Drawing.Point(277, 186)
        Me.btn_proses.Name = "btn_proses"
        Me.btn_proses.Size = New System.Drawing.Size(75, 23)
        Me.btn_proses.TabIndex = 4
        Me.btn_proses.Text = "Button1"
        Me.btn_proses.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 445)
        Me.Controls.Add(Me.btn_proses)
        Me.Controls.Add(Me.txt_hasil)
        Me.Controls.Add(Me.txt_b)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_a)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_a As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_b As System.Windows.Forms.TextBox
    Friend WithEvents txt_hasil As System.Windows.Forms.TextBox
    Friend WithEvents btn_proses As System.Windows.Forms.Button

End Class
