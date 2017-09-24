<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransaksiForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransaksiForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ScanFingerBtn = New System.Windows.Forms.Button()
        Me.Photo = New System.Windows.Forms.PictureBox()
        Me.LblNIS = New System.Windows.Forms.Label()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.LblJumlahSimpanan = New System.Windows.Forms.Label()
        Me.LblJumlahAmbil = New System.Windows.Forms.Label()
        Me.BtnVerifikasi = New System.Windows.Forms.Button()
        Me.BoxPengambilan = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBoxScan = New System.Windows.Forms.TextBox()
        Me.TextBoxVerifBarcode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton3 = New ns1.BunifuFlatButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.Photo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(227, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Baca Siswa"
        '
        'ScanFingerBtn
        '
        Me.ScanFingerBtn.Location = New System.Drawing.Point(318, 355)
        Me.ScanFingerBtn.Name = "ScanFingerBtn"
        Me.ScanFingerBtn.Size = New System.Drawing.Size(75, 23)
        Me.ScanFingerBtn.TabIndex = 1
        Me.ScanFingerBtn.Text = "Scan Finger"
        Me.ScanFingerBtn.UseVisualStyleBackColor = True
        '
        'Photo
        '
        Me.Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Photo.Location = New System.Drawing.Point(234, 418)
        Me.Photo.Name = "Photo"
        Me.Photo.Size = New System.Drawing.Size(185, 221)
        Me.Photo.TabIndex = 2
        Me.Photo.TabStop = False
        '
        'LblNIS
        '
        Me.LblNIS.AutoSize = True
        Me.LblNIS.Location = New System.Drawing.Point(471, 453)
        Me.LblNIS.Name = "LblNIS"
        Me.LblNIS.Size = New System.Drawing.Size(25, 13)
        Me.LblNIS.TabIndex = 3
        Me.LblNIS.Text = "NIS"
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Location = New System.Drawing.Point(471, 418)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(38, 13)
        Me.LblNama.TabIndex = 4
        Me.LblNama.Text = "NAMA"
        '
        'LblJumlahSimpanan
        '
        Me.LblJumlahSimpanan.AutoSize = True
        Me.LblJumlahSimpanan.Location = New System.Drawing.Point(471, 502)
        Me.LblJumlahSimpanan.Name = "LblJumlahSimpanan"
        Me.LblJumlahSimpanan.Size = New System.Drawing.Size(63, 13)
        Me.LblJumlahSimpanan.TabIndex = 5
        Me.LblJumlahSimpanan.Text = "SIMPANAN"
        '
        'LblJumlahAmbil
        '
        Me.LblJumlahAmbil.AutoSize = True
        Me.LblJumlahAmbil.Location = New System.Drawing.Point(466, 545)
        Me.LblJumlahAmbil.Name = "LblJumlahAmbil"
        Me.LblJumlahAmbil.Size = New System.Drawing.Size(68, 13)
        Me.LblJumlahAmbil.TabIndex = 6
        Me.LblJumlahAmbil.Text = "Pengambilan"
        '
        'BtnVerifikasi
        '
        Me.BtnVerifikasi.Location = New System.Drawing.Point(477, 658)
        Me.BtnVerifikasi.Name = "BtnVerifikasi"
        Me.BtnVerifikasi.Size = New System.Drawing.Size(128, 23)
        Me.BtnVerifikasi.TabIndex = 8
        Me.BtnVerifikasi.Text = "Verifikasi Finger"
        Me.BtnVerifikasi.UseVisualStyleBackColor = True
        '
        'BoxPengambilan
        '
        Me.BoxPengambilan.Location = New System.Drawing.Point(469, 581)
        Me.BoxPengambilan.Name = "BoxPengambilan"
        Me.BoxPengambilan.Size = New System.Drawing.Size(144, 20)
        Me.BoxPengambilan.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(823, 542)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 151)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'TextBoxScan
        '
        Me.TextBoxScan.Location = New System.Drawing.Point(573, 360)
        Me.TextBoxScan.Name = "TextBoxScan"
        Me.TextBoxScan.Size = New System.Drawing.Size(146, 20)
        Me.TextBoxScan.TabIndex = 11
        '
        'TextBoxVerifBarcode
        '
        Me.TextBoxVerifBarcode.Location = New System.Drawing.Point(688, 661)
        Me.TextBoxVerifBarcode.Name = "TextBoxVerifBarcode"
        Me.TextBoxVerifBarcode.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxVerifBarcode.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(495, 360)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Scan Barcod"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(692, 645)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Scan Barcode"
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.Red
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.Silver
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "X"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = Nothing
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 90.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(1320, 0)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.Red
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(47, 28)
        Me.BunifuFlatButton3.TabIndex = 15
        Me.BunifuFlatButton3.Text = "X"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(26, 29)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(305, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(488, 126)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(148, 147)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(690, 126)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(144, 147)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 18
        Me.PictureBox4.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label4.Location = New System.Drawing.Point(525, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Finger ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label5.Location = New System.Drawing.Point(725, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Barcode ID"
        '
        'TransaksiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BunifuFlatButton3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxVerifBarcode)
        Me.Controls.Add(Me.TextBoxScan)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BoxPengambilan)
        Me.Controls.Add(Me.BtnVerifikasi)
        Me.Controls.Add(Me.LblJumlahAmbil)
        Me.Controls.Add(Me.LblJumlahSimpanan)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.LblNIS)
        Me.Controls.Add(Me.Photo)
        Me.Controls.Add(Me.ScanFingerBtn)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TransaksiForm"
        Me.Text = "SIMTITIS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Photo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ScanFingerBtn As System.Windows.Forms.Button
    Friend WithEvents Photo As System.Windows.Forms.PictureBox
    Friend WithEvents LblNIS As System.Windows.Forms.Label
    Friend WithEvents LblNama As System.Windows.Forms.Label
    Friend WithEvents LblJumlahSimpanan As System.Windows.Forms.Label
    Friend WithEvents LblJumlahAmbil As System.Windows.Forms.Label
    Friend WithEvents BtnVerifikasi As System.Windows.Forms.Button
    Friend WithEvents BoxPengambilan As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBoxScan As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxVerifBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BunifuFlatButton3 As ns1.BunifuFlatButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
