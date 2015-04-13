Imports System.IO

Public Class frmXemsanpham
    Dim line As String
    Dim result As String()
    Dim item As ListViewItem
    Dim i As Integer

    'xự kiện load form 
    Private Sub frmXemsanpham_Load(ByVal sender As system.Object,ByVal e As system.EventArgs) Handles MyBase.Load
        'kiểm tra sự tồn tại của file
        If File.Exists("nhaccu.txt") = True Then
            Dim input As StreamReader = New StreamReader("nhaccu.txt", True) 'mở file
            Do While input.EndOfStream = False 'lặp lại tới hết file
                line = input.ReadLine() 'đọc từng dòng
                result = line.Split(ControlChars.Tab)
                item = New ListViewItem(result(0)) 'thêm dữ liệu mới
                item.SubItems.Add(result(1))
                item.SubItems.Add(result(2))
                item.SubItems.Add(result(3))
                item.SubItems.Add(result(4))
                item.SubItems.Add(result(5))
                item.SubItems.Add(result(6))
                lsvDanhsach.Items.Add(item) 'thêm vào listview
            Loop
            input.Close()
        End If
    End Sub

    Private Sub lsvDanhsach_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvDanhsach.SelectedIndexChanged
        i = lsvDanhsach.FocusedItem.Index 'biến lấy số thứ tự dòng đang chọn
        'lấy dữ liệu lên textbox
        lblMaNC.Text = lsvDanhsach.Items(i).SubItems(0).Text
        lblTenNC.Text = lsvDanhsach.Items(i).SubItems(1).Text
        lblThuonghieu.Text = lsvDanhsach.Items(i).SubItems(2).Text
        lblMau.Text = lsvDanhsach.Items(i).SubItems(3).Text
        lblGia.Text = lsvDanhsach.Items(i).SubItems(4).Text
        lblMota.Text = lsvDanhsach.Items(i).SubItems(5).Text
        lblHinhanh.Text = lsvDanhsach.Items(i).SubItems(6).Text
        ptbHinhNC.Image = Image.FromFile(lblHinhanh.Text)
    End Sub
End Class
