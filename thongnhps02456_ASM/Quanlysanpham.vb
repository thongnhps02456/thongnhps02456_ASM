Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data.Sql

Public Class frmQuanlysanpham
    Dim connectsql As String = "workstation id=thongnhps02456.mssql.somee.com;packet size=4096;user id=thongnhps02456_SQLLogin_1;pwd=cvq21na3lb;data source=thongnhps02456.mssql.somee.com;persist security info=False;initial catalog=thongnhps02456"
    Dim dt As New DataTable

    Public Sub loaddata()
        Dim ketnoi As New SqlConnection(connectsql)
        Dim sqladapter As New SqlDataAdapter("select * from SanPham", ketnoi)
        Try
            sqladapter.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        View1.DataSource = dt
        ketnoi.Close()
    End Sub
    Private Sub frmQuanlysanpham_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load       
        Dim ketnoi As New SqlConnection(connectsql)
        ketnoi.Open()
        Me.loaddata()
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub


    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim ketnoi As New SqlConnection(connectsql)
        Dim add As String = "insert into SanPham values (@MaSP,@TenSP,@GiaSP,@SoluongSP,@ChitietSP,@LoaiSP_MaloaiSP)"
        ketnoi.Open()
        Dim cmd As New SqlCommand(add, ketnoi)
        Try
            cmd.Parameters.AddWithValue("@MaSP", txtMa.Text)
            cmd.Parameters.AddWithValue("@TenSP", txtTen.Text)
            cmd.Parameters.AddWithValue("@GiaSP", txtGia.Text)
            cmd.Parameters.AddWithValue("@SoluongSP", txtSoluong.Text)
            cmd.Parameters.AddWithValue("@ChitietSP", txtChitiet.Text)
            cmd.Parameters.AddWithValue("@LoaiSP_MaloaiSP", txtLoai.Text)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Đã thêm sản phẩm")
        End Try
        dt.Clear()
        View1.DataSource = dt
        View1.DataSource = Nothing
        loaddata()

    End Sub

    Private Sub View1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles View1.CellClick
        Dim getdata As Integer = View1.CurrentCell.RowIndex
        txtMa.Text = View1.Item(0, getdata).Value
        txtTen.Text = View1.Item(1, getdata).Value
        txtGia.Text = View1.Item(2, getdata).Value
        txtSoluong.Text = View1.Item(3, getdata).Value
        txtChitiet.Text = View1.Item(4, getdata).Value
        txtLoai.Text = View1.Item(5, getdata).Value
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim ketnoi As New SqlConnection(connectsql)
        ketnoi.Open()
        Dim ud As String = ("Update SanPham set TenSP = @TenSP, GiaSP = @GiaSP, SoluongSP = @SoluongSP, ChitietSP = @ChitietSP , LoaiSP_MaloaiSP = @LoaiSP_MaloaiSP where MaSP=@MaSP ")
        Dim cmd As New SqlCommand(ud, ketnoi)
        Try
            cmd.Parameters.AddWithValue("@MaSP", txtMa.Text)
            cmd.Parameters.AddWithValue("@TenSP", txtTen.Text)
            cmd.Parameters.AddWithValue("@GiaSP", Convert.ToInt32(txtGia.Text))
            cmd.Parameters.AddWithValue("@SoluongSP", Convert.ToInt32(txtSoluong.Text))
            cmd.Parameters.AddWithValue("@ChitietSP", txtChitiet.Text)
            cmd.Parameters.AddWithValue("@LoaiSP_MaloaiSP", txtLoai.Text)

            cmd.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Update thành công")
        End Try
        dt.Clear()
        View1.DataSource = dt
        View1.DataSource = Nothing
        loaddata()

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim ketnoi As New SqlConnection(connectsql)
        ketnoi.Open()
        Dim del As String = ("Delete from SanPham where MaSP=@MaSP")
        Dim cmd As New SqlCommand(del, ketnoi)
        Try
            cmd.Parameters.AddWithValue("@MaSP", txtMa.Text)
            cmd.ExecuteNonQuery()
            ketnoi.Close()

        Catch ex As Exception
            MessageBox.Show("Xóa thành công")

        End Try
        dt.Clear()
        View1.DataSource = dt
        View1.DataSource = Nothing
        loaddata()
    End Sub
End Class