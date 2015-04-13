Imports System.Data.SqlClient

Public Class frmDangnhap

    'xử lý sự kiện button đăng nhập
    Private Sub btnDangnhap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDangnhap.Click
        Dim chuoiketnoi As String = "workstation id=thongnhps02456.mssql.somee.com;packet size=4096;user id=thongnhps02456_SQLLogin_1;pwd=cvq21na3lb;data source=thongnhps02456.mssql.somee.com;persist security info=False;initial catalog=thongnhps02456"
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqladapter As New SqlDataAdapter("select * from NhanVien where MaNV='" & txtUser.Text & "' and MatKhau='" & txtPass.Text & "' ", ketnoi)
        Dim dt As New DataTable

        Try
            ketnoi.Open()
            sqladapter.Fill(dt)
            If dt.Rows.Count > 0 Then
                MessageBox.Show("Bạn đã kết nối thành công")
                frmMain.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu")

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
        Application.Exit()
    End Sub
End Class