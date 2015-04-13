<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangnhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDangnhap))
        Me.ptbHinh = New System.Windows.Forms.PictureBox()
        Me.lblTieude = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnDangnhap = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        CType(Me.ptbHinh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptbHinh
        '
        Me.ptbHinh.Image = CType(resources.GetObject("ptbHinh.Image"), System.Drawing.Image)
        Me.ptbHinh.Location = New System.Drawing.Point(12, 22)
        Me.ptbHinh.Name = "ptbHinh"
        Me.ptbHinh.Size = New System.Drawing.Size(123, 123)
        Me.ptbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbHinh.TabIndex = 0
        Me.ptbHinh.TabStop = False
        '
        'lblTieude
        '
        Me.lblTieude.AutoSize = True
        Me.lblTieude.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTieude.ForeColor = System.Drawing.Color.Blue
        Me.lblTieude.Location = New System.Drawing.Point(169, 9)
        Me.lblTieude.Name = "lblTieude"
        Me.lblTieude.Size = New System.Drawing.Size(183, 24)
        Me.lblTieude.TabIndex = 1
        Me.lblTieude.Text = "Đăng nhập hệ thống"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(142, 44)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(60, 13)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = "User Name"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(141, 81)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(53, 13)
        Me.lblPass.TabIndex = 3
        Me.lblPass.Text = "Password"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(203, 41)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(170, 20)
        Me.txtUser.TabIndex = 4
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(203, 81)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(170, 20)
        Me.txtPass.TabIndex = 5
        '
        'btnDangnhap
        '
        Me.btnDangnhap.Location = New System.Drawing.Point(173, 121)
        Me.btnDangnhap.Name = "btnDangnhap"
        Me.btnDangnhap.Size = New System.Drawing.Size(75, 23)
        Me.btnDangnhap.TabIndex = 6
        Me.btnDangnhap.Text = "Đăng Nhập"
        Me.btnDangnhap.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(277, 121)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 7
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'frmDangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(385, 158)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnDangnhap)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblTieude)
        Me.Controls.Add(Me.ptbHinh)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(401, 196)
        Me.MinimumSize = New System.Drawing.Size(401, 196)
        Me.Name = "frmDangnhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng nhập"
        CType(Me.ptbHinh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ptbHinh As System.Windows.Forms.PictureBox
    Friend WithEvents lblTieude As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents btnDangnhap As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
End Class
