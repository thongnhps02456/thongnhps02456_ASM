<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanlysanpham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanlysanpham))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtChitiet = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSoluong = New System.Windows.Forms.TextBox()
        Me.txtGia = New System.Windows.Forms.TextBox()
        Me.txtTen = New System.Windows.Forms.TextBox()
        Me.txtMa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ptbHinhNC = New System.Windows.Forms.PictureBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ofdHinh = New System.Windows.Forms.OpenFileDialog()
        Me.View1 = New System.Windows.Forms.DataGridView()
        Me.txtLoai = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ptbHinhNC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtLoai)
        Me.GroupBox1.Controls.Add(Me.txtChitiet)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtSoluong)
        Me.GroupBox1.Controls.Add(Me.txtGia)
        Me.GroupBox1.Controls.Add(Me.txtTen)
        Me.GroupBox1.Controls.Add(Me.txtMa)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(454, 233)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nhập thông tin"
        '
        'txtChitiet
        '
        Me.txtChitiet.Location = New System.Drawing.Point(250, 51)
        Me.txtChitiet.Multiline = True
        Me.txtChitiet.Name = "txtChitiet"
        Me.txtChitiet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtChitiet.Size = New System.Drawing.Size(193, 165)
        Me.txtChitiet.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(251, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Chi tiết"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(239, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(5, 211)
        Me.Label6.TabIndex = 10
        '
        'txtSoluong
        '
        Me.txtSoluong.Location = New System.Drawing.Point(92, 150)
        Me.txtSoluong.Name = "txtSoluong"
        Me.txtSoluong.Size = New System.Drawing.Size(141, 23)
        Me.txtSoluong.TabIndex = 8
        '
        'txtGia
        '
        Me.txtGia.Location = New System.Drawing.Point(92, 107)
        Me.txtGia.Name = "txtGia"
        Me.txtGia.Size = New System.Drawing.Size(141, 23)
        Me.txtGia.TabIndex = 7
        '
        'txtTen
        '
        Me.txtTen.Location = New System.Drawing.Point(92, 66)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(141, 23)
        Me.txtTen.TabIndex = 6
        '
        'txtMa
        '
        Me.txtMa.Location = New System.Drawing.Point(92, 29)
        Me.txtMa.Name = "txtMa"
        Me.txtMa.Size = New System.Drawing.Size(141, 23)
        Me.txtMa.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Loại"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Số lượng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Giá"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(7, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên nhạc cụ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã nhạc cụ"
        '
        'ptbHinhNC
        '
        Me.ptbHinhNC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ptbHinhNC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptbHinhNC.Image = CType(resources.GetObject("ptbHinhNC.Image"), System.Drawing.Image)
        Me.ptbHinhNC.Location = New System.Drawing.Point(474, 29)
        Me.ptbHinhNC.Name = "ptbHinhNC"
        Me.ptbHinhNC.Size = New System.Drawing.Size(255, 218)
        Me.ptbHinhNC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbHinhNC.TabIndex = 2
        Me.ptbHinhNC.TabStop = False
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(658, 278)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(71, 23)
        Me.btnThem.TabIndex = 3
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(658, 317)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(71, 23)
        Me.btnSua.TabIndex = 4
        Me.btnSua.Text = "Cập nhật"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(658, 361)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(71, 23)
        Me.btnXoa.TabIndex = 5
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(658, 408)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(71, 23)
        Me.btnThoat.TabIndex = 6
        Me.btnThoat.Text = "Đóng"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Danh sách nhạc cụ"
        '
        'ofdHinh
        '
        Me.ofdHinh.FileName = "OpenFileDialog1"
        '
        'View1
        '
        Me.View1.AllowUserToAddRows = False
        Me.View1.AllowUserToDeleteRows = False
        Me.View1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View1.Location = New System.Drawing.Point(14, 278)
        Me.View1.Name = "View1"
        Me.View1.ReadOnly = True
        Me.View1.Size = New System.Drawing.Size(635, 153)
        Me.View1.TabIndex = 18
        '
        'txtLoai
        '
        Me.txtLoai.Location = New System.Drawing.Point(92, 188)
        Me.txtLoai.Name = "txtLoai"
        Me.txtLoai.Size = New System.Drawing.Size(141, 23)
        Me.txtLoai.TabIndex = 19
        '
        'frmQuanlysanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(737, 437)
        Me.Controls.Add(Me.View1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.ptbHinhNC)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(826, 479)
        Me.Name = "frmQuanlysanpham"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý nhạc cụ"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ptbHinhNC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtChitiet As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSoluong As System.Windows.Forms.TextBox
    Friend WithEvents txtGia As System.Windows.Forms.TextBox
    Friend WithEvents txtTen As System.Windows.Forms.TextBox
    Friend WithEvents txtMa As System.Windows.Forms.TextBox
    Friend WithEvents ptbHinhNC As System.Windows.Forms.PictureBox
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ofdHinh As System.Windows.Forms.OpenFileDialog
    Friend WithEvents View1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtLoai As System.Windows.Forms.TextBox

End Class
