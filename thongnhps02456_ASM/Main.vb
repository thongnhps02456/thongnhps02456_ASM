Public Class frmMain

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmQuanlysanpham.ShowDialog()
    End Sub

    Private Sub btnReview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReview.Click
        frmXemsanpham.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmDangnhap.txtUser.Text = ""
        frmDangnhap.txtPass.Text = ""
        frmDangnhap.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub mniLogout_Click(sender As Object, e As EventArgs) Handles mniLogout.Click
        frmDangnhap.txtUser.Text = ""
        frmDangnhap.txtPass.Text = ""
        frmDangnhap.Show()
        Me.Close()
    End Sub

    Private Sub mniThoat_Click(sender As Object, e As EventArgs) Handles mniThoat.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub mniXem_Click(sender As Object, e As EventArgs) Handles mniXem.Click
        frmXemsanpham.ShowDialog()
    End Sub

    Private Sub mniThem_Click(sender As Object, e As EventArgs) Handles mniThem.Click
        frmQuanlysanpham.ShowDialog()
    End Sub

    Private Sub mniBanquyen_Click(sender As Object, e As EventArgs) Handles mniBanquyen.Click
        frmBanquyen.Show()
    End Sub

End Class