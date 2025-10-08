Imports System.Data.SqlClient
Public Class Form1
    Dim con As New SqlConnection("Data Source=Thlap\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True")

    Private Sub KetNoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
    Private Sub HienThi()
        KetNoi()
        Dim cmd As New SqlCommand("SELECT * FROM SinhVien", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvSinhVien.DataSource = dt
        con.Close()
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        KetNoi()
        Dim sql As String = "INSERT INTO SinhVien VALUES (@MaSV, @HoTen, @Tuoi, @Diem)"
        Dim cmd As New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text)
        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text)
        cmd.Parameters.AddWithValue("@Tuoi", txtTuoi.Text)
        cmd.Parameters.AddWithValue("@Diem", txtDiem.Text)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Đã thêm sinh viên thành công!")
        con.Close()
        HienThi()
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        KetNoi()
        Dim sql As String = "UPDATE SinhVien SET HoTen=@HoTen, Tuoi=@Tuoi, Diem=@Diem WHERE MaSV=@MaSV"
        Dim cmd As New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text)
        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text)
        cmd.Parameters.AddWithValue("@Tuoi", txtTuoi.Text)
        cmd.Parameters.AddWithValue("@Diem", txtDiem.Text)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Đã cập nhật sinh viên!")
        con.Close()
        HienThi()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        KetNoi()
        Dim sql As String = "DELETE FROM SinhVien WHERE MaSV=@MaSV"
        Dim cmd As New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Đã xóa sinh viên!")
        con.Close()
        HienThi()
    End Sub

    Private Sub btnHienThi_Click(sender As Object, e As EventArgs) Handles btnHienThi.Click
        HienThi()
    End Sub

    Private Sub btncaonhat_Click(sender As Object, e As EventArgs) Handles btncaonhat.Click
        KetNoi()
        Dim cmd As New SqlCommand("SELECT TOP 1 * FROM SinhVien ORDER BY Diem DESC", con)
        Dim rd As SqlDataReader = cmd.ExecuteReader()
        If rd.Read() Then
            MessageBox.Show("SV điểm cao nhất: " & rd("HoTen") & " (" & rd("Diem") & ")")
        Else
            MessageBox.Show("Danh sách rỗng.")
        End If
        rd.Close()
        con.Close()
    End Sub

    Private Sub btthoat_Click(sender As Object, e As EventArgs) Handles btthoat.Click
        Dim result As DialogResult
        result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
