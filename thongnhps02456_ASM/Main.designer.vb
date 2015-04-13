<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.mniHethong = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniThoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniQuanly = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniXem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniThem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniThongtin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniBanquyen = New System.Windows.Forms.ToolStripMenuItem()
        Me.stsStatus = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTieude1 = New System.Windows.Forms.Label()
        Me.lblTieude2 = New System.Windows.Forms.Label()
        Me.lblTieude3 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnReview = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.mnsMenu.SuspendLayout()
        Me.stsStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnsMenu
        '
        Me.mnsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniHethong, Me.mniQuanly, Me.mniThongtin})
        Me.mnsMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenu.Name = "mnsMenu"
        Me.mnsMenu.Size = New System.Drawing.Size(638, 24)
        Me.mnsMenu.TabIndex = 0
        Me.mnsMenu.Text = "MenuStrip1"
        '
        'mniHethong
        '
        Me.mniHethong.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniLogout, Me.mniThoat})
        Me.mniHethong.Name = "mniHethong"
        Me.mniHethong.Size = New System.Drawing.Size(72, 20)
        Me.mniHethong.Text = "Hệ Thống"
        '
        'mniLogout
        '
        Me.mniLogout.Image = CType(resources.GetObject("mniLogout.Image"), System.Drawing.Image)
        Me.mniLogout.Name = "mniLogout"
        Me.mniLogout.Size = New System.Drawing.Size(117, 22)
        Me.mniLogout.Text = "Log Out"
        '
        'mniThoat
        '
        Me.mniThoat.Image = CType(resources.GetObject("mniThoat.Image"), System.Drawing.Image)
        Me.mniThoat.Name = "mniThoat"
        Me.mniThoat.Size = New System.Drawing.Size(117, 22)
        Me.mniThoat.Text = "Đóng"
        '
        'mniQuanly
        '
        Me.mniQuanly.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniXem, Me.mniThem})
        Me.mniQuanly.Name = "mniQuanly"
        Me.mniQuanly.Size = New System.Drawing.Size(60, 20)
        Me.mniQuanly.Text = "Quản lý"
        '
        'mniXem
        '
        Me.mniXem.Image = CType(resources.GetObject("mniXem.Image"), System.Drawing.Image)
        Me.mniXem.Name = "mniXem"
        Me.mniXem.Size = New System.Drawing.Size(160, 22)
        Me.mniXem.Text = "Xem sản phẩm"
        '
        'mniThem
        '
        Me.mniThem.Image = CType(resources.GetObject("mniThem.Image"), System.Drawing.Image)
        Me.mniThem.Name = "mniThem"
        Me.mniThem.Size = New System.Drawing.Size(160, 22)
        Me.mniThem.Text = "Thêm sản phẩm"
        '
        'mniThongtin
        '
        Me.mniThongtin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniBanquyen})
        Me.mniThongtin.Name = "mniThongtin"
        Me.mniThongtin.Size = New System.Drawing.Size(71, 20)
        Me.mniThongtin.Text = "Thông tin"
        '
        'mniBanquyen
        '
        Me.mniBanquyen.Image = CType(resources.GetObject("mniBanquyen.Image"), System.Drawing.Image)
        Me.mniBanquyen.Name = "mniBanquyen"
        Me.mniBanquyen.Size = New System.Drawing.Size(130, 22)
        Me.mniBanquyen.Text = "Bản quyền"
        '
        'stsStatus
        '
        Me.stsStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.stsStatus.Location = New System.Drawing.Point(0, 385)
        Me.stsStatus.Name = "stsStatus"
        Me.stsStatus.Size = New System.Drawing.Size(638, 22)
        Me.stsStatus.TabIndex = 1
        Me.stsStatus.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(180, 17)
        Me.ToolStripStatusLabel1.Text = "Nguyễn Hoàng Thông - PS02456"
        '
        'lblTieude1
        '
        Me.lblTieude1.AutoSize = True
        Me.lblTieude1.BackColor = System.Drawing.Color.Transparent
        Me.lblTieude1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTieude1.ForeColor = System.Drawing.Color.White
        Me.lblTieude1.Location = New System.Drawing.Point(158, 39)
        Me.lblTieude1.Name = "lblTieude1"
        Me.lblTieude1.Size = New System.Drawing.Size(310, 24)
        Me.lblTieude1.TabIndex = 2
        Me.lblTieude1.Text = "Âm nhạc - Nguồn cảm hứng bất tận"
        '
        'lblTieude2
        '
        Me.lblTieude2.AutoSize = True
        Me.lblTieude2.BackColor = System.Drawing.Color.Transparent
        Me.lblTieude2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTieude2.ForeColor = System.Drawing.Color.White
        Me.lblTieude2.Location = New System.Drawing.Point(92, 72)
        Me.lblTieude2.Name = "lblTieude2"
        Me.lblTieude2.Size = New System.Drawing.Size(464, 24)
        Me.lblTieude2.TabIndex = 3
        Me.lblTieude2.Text = "Chào mừng bạn đến với phần mềm quản lý sản phẩm"
        '
        'lblTieude3
        '
        Me.lblTieude3.AutoSize = True
        Me.lblTieude3.BackColor = System.Drawing.Color.Transparent
        Me.lblTieude3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTieude3.ForeColor = System.Drawing.Color.Red
        Me.lblTieude3.Location = New System.Drawing.Point(175, 118)
        Me.lblTieude3.Name = "lblTieude3"
        Me.lblTieude3.Size = New System.Drawing.Size(293, 31)
        Me.lblTieude3.TabIndex = 4
        Me.lblTieude3.Text = "HT - Thế giới nhạc cụ"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.Location = New System.Drawing.Point(144, 272)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(72, 65)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnReview
        '
        Me.btnReview.Image = CType(resources.GetObject("btnReview.Image"), System.Drawing.Image)
        Me.btnReview.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReview.Location = New System.Drawing.Point(235, 272)
        Me.btnReview.Name = "btnReview"
        Me.btnReview.Size = New System.Drawing.Size(72, 65)
        Me.btnReview.TabIndex = 6
        Me.btnReview.Text = "Review"
        Me.btnReview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnReview.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLogout.Location = New System.Drawing.Point(328, 272)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(72, 65)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.Location = New System.Drawing.Point(420, 272)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 65)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(638, 407)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnReview)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblTieude3)
        Me.Controls.Add(Me.lblTieude2)
        Me.Controls.Add(Me.lblTieude1)
        Me.Controls.Add(Me.stsStatus)
        Me.Controls.Add(Me.mnsMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnsMenu
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(654, 445)
        Me.MinimumSize = New System.Drawing.Size(654, 445)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HT-Thế giới nhạc cụ"
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        Me.stsStatus.ResumeLayout(False)
        Me.stsStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnsMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mniHethong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniThoat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniQuanly As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniXem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniThem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniThongtin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniBanquyen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents stsStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTieude1 As System.Windows.Forms.Label
    Friend WithEvents lblTieude2 As System.Windows.Forms.Label
    Friend WithEvents lblTieude3 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnReview As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
