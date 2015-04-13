<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXemsanpham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmXemsanpham))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblMota = New System.Windows.Forms.Label()
        Me.lblGia = New System.Windows.Forms.Label()
        Me.lblMau = New System.Windows.Forms.Label()
        Me.lblThuonghieu = New System.Windows.Forms.Label()
        Me.lblTenNC = New System.Windows.Forms.Label()
        Me.lblMaNC = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ptbHinhNC = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lsvDanhsach = New System.Windows.Forms.ListView()
        Me.lsvcolMa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvcolTen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvcolThuonghieu = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvcolMausac = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvcolGia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvcolMota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvcolHinhanh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblHinhanh = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ptbHinhNC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblHinhanh)
        Me.GroupBox1.Controls.Add(Me.lblMota)
        Me.GroupBox1.Controls.Add(Me.lblGia)
        Me.GroupBox1.Controls.Add(Me.lblMau)
        Me.GroupBox1.Controls.Add(Me.lblThuonghieu)
        Me.GroupBox1.Controls.Add(Me.lblTenNC)
        Me.GroupBox1.Controls.Add(Me.lblMaNC)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ptbHinhNC)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 459)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin sản phẩm"
        '
        'lblMota
        '
        Me.lblMota.BackColor = System.Drawing.SystemColors.Window
        Me.lblMota.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMota.Location = New System.Drawing.Point(88, 188)
        Me.lblMota.Name = "lblMota"
        Me.lblMota.Size = New System.Drawing.Size(160, 23)
        Me.lblMota.TabIndex = 27
        Me.lblMota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGia
        '
        Me.lblGia.BackColor = System.Drawing.SystemColors.Window
        Me.lblGia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGia.Location = New System.Drawing.Point(88, 154)
        Me.lblGia.Name = "lblGia"
        Me.lblGia.Size = New System.Drawing.Size(160, 23)
        Me.lblGia.TabIndex = 25
        Me.lblGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMau
        '
        Me.lblMau.BackColor = System.Drawing.SystemColors.Window
        Me.lblMau.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMau.Location = New System.Drawing.Point(88, 121)
        Me.lblMau.Name = "lblMau"
        Me.lblMau.Size = New System.Drawing.Size(160, 23)
        Me.lblMau.TabIndex = 24
        Me.lblMau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblThuonghieu
        '
        Me.lblThuonghieu.BackColor = System.Drawing.SystemColors.Window
        Me.lblThuonghieu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblThuonghieu.Location = New System.Drawing.Point(88, 90)
        Me.lblThuonghieu.Name = "lblThuonghieu"
        Me.lblThuonghieu.Size = New System.Drawing.Size(160, 23)
        Me.lblThuonghieu.TabIndex = 23
        Me.lblThuonghieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTenNC
        '
        Me.lblTenNC.BackColor = System.Drawing.SystemColors.Window
        Me.lblTenNC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTenNC.Location = New System.Drawing.Point(88, 60)
        Me.lblTenNC.Name = "lblTenNC"
        Me.lblTenNC.Size = New System.Drawing.Size(160, 23)
        Me.lblTenNC.TabIndex = 22
        Me.lblTenNC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMaNC
        '
        Me.lblMaNC.BackColor = System.Drawing.SystemColors.Window
        Me.lblMaNC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMaNC.Location = New System.Drawing.Point(88, 27)
        Me.lblMaNC.Name = "lblMaNC"
        Me.lblMaNC.Size = New System.Drawing.Size(160, 23)
        Me.lblMaNC.TabIndex = 21
        Me.lblMaNC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Mô tả"
        '
        'ptbHinhNC
        '
        Me.ptbHinhNC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ptbHinhNC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptbHinhNC.Image = CType(resources.GetObject("ptbHinhNC.Image"), System.Drawing.Image)
        Me.ptbHinhNC.Location = New System.Drawing.Point(9, 258)
        Me.ptbHinhNC.Name = "ptbHinhNC"
        Me.ptbHinhNC.Size = New System.Drawing.Size(239, 191)
        Me.ptbHinhNC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbHinhNC.TabIndex = 19
        Me.ptbHinhNC.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Giá"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Màu sắc"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Thương hiệu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(7, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên nhạc cụ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã nhạc cụ"
        '
        'lsvDanhsach
        '
        Me.lsvDanhsach.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lsvcolMa, Me.lsvcolTen, Me.lsvcolThuonghieu, Me.lsvcolMausac, Me.lsvcolGia, Me.lsvcolMota, Me.lsvcolHinhanh})
        Me.lsvDanhsach.Location = New System.Drawing.Point(277, 22)
        Me.lsvDanhsach.Name = "lsvDanhsach"
        Me.lsvDanhsach.Size = New System.Drawing.Size(413, 449)
        Me.lsvDanhsach.TabIndex = 15
        Me.lsvDanhsach.TileSize = New System.Drawing.Size(228, 34)
        Me.lsvDanhsach.UseCompatibleStateImageBehavior = False
        Me.lsvDanhsach.View = System.Windows.Forms.View.Details
        '
        'lsvcolMa
        '
        Me.lsvcolMa.Text = "Mã NC"
        '
        'lsvcolTen
        '
        Me.lsvcolTen.Text = "Tên NC"
        '
        'lsvcolThuonghieu
        '
        Me.lsvcolThuonghieu.Text = "Thương hiệu"
        '
        'lsvcolMausac
        '
        Me.lsvcolMausac.Text = "Màu sắc"
        '
        'lsvcolGia
        '
        Me.lsvcolGia.Text = "Giá"
        '
        'lsvcolMota
        '
        Me.lsvcolMota.Text = "Mô tả"
        '
        'lsvcolHinhanh
        '
        Me.lsvcolHinhanh.Text = "Hình ảnh"
        '
        'lblHinhanh
        '
        Me.lblHinhanh.BackColor = System.Drawing.SystemColors.Window
        Me.lblHinhanh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHinhanh.Location = New System.Drawing.Point(88, 222)
        Me.lblHinhanh.Name = "lblHinhanh"
        Me.lblHinhanh.Size = New System.Drawing.Size(160, 23)
        Me.lblHinhanh.TabIndex = 28
        Me.lblHinhanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Hình ảnh"
        '
        'frmXemsanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(702, 480)
        Me.Controls.Add(Me.lsvDanhsach)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmXemsanpham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin sản phẩm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ptbHinhNC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ptbHinhNC As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblMota As System.Windows.Forms.Label
    Friend WithEvents lblGia As System.Windows.Forms.Label
    Friend WithEvents lblMau As System.Windows.Forms.Label
    Friend WithEvents lblThuonghieu As System.Windows.Forms.Label
    Friend WithEvents lblTenNC As System.Windows.Forms.Label
    Friend WithEvents lblMaNC As System.Windows.Forms.Label
    Friend WithEvents lsvDanhsach As System.Windows.Forms.ListView
    Friend WithEvents lsvcolMa As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvcolTen As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvcolThuonghieu As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvcolMausac As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvcolGia As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvcolMota As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvcolHinhanh As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblHinhanh As System.Windows.Forms.Label
End Class
