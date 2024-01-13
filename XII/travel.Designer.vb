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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txt_harga = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_maskapai = New System.Windows.Forms.ComboBox()
        Me.cmb_tujuan = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txt_harga
        '
        Me.txt_harga.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txt_harga.Location = New System.Drawing.Point(144, 218)
        Me.txt_harga.Name = "txt_harga"
        Me.txt_harga.Size = New System.Drawing.Size(199, 26)
        Me.txt_harga.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(101, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pilih Maskapai"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Info
        Me.Label2.Location = New System.Drawing.Point(286, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tujuan"
        '
        'cmb_maskapai
        '
        Me.cmb_maskapai.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.cmb_maskapai.FormattingEnabled = True
        Me.cmb_maskapai.Items.AddRange(New Object() {"Garuda", "Lion", "Sriwijaya"})
        Me.cmb_maskapai.Location = New System.Drawing.Point(90, 144)
        Me.cmb_maskapai.Name = "cmb_maskapai"
        Me.cmb_maskapai.Size = New System.Drawing.Size(135, 28)
        Me.cmb_maskapai.TabIndex = 4
        '
        'cmb_tujuan
        '
        Me.cmb_tujuan.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmb_tujuan.FormattingEnabled = True
        Me.cmb_tujuan.Items.AddRange(New Object() {"Medan-Padang", "Medan-Jakarta", "Medan-Bali"})
        Me.cmb_tujuan.Location = New System.Drawing.Point(258, 144)
        Me.cmb_tujuan.Name = "cmb_tujuan"
        Me.cmb_tujuan.Size = New System.Drawing.Size(135, 28)
        Me.cmb_tujuan.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(487, 423)
        Me.Controls.Add(Me.cmb_tujuan)
        Me.Controls.Add(Me.cmb_maskapai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_harga)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_harga As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_maskapai As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_tujuan As System.Windows.Forms.ComboBox

End Class
