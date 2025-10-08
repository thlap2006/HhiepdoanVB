<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvSinhVien = New System.Windows.Forms.DataGridView()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.txtMaSV = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.txtTuoi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDiem = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnHienThi = New System.Windows.Forms.Button()
        Me.btncaonhat = New System.Windows.Forms.Button()
        Me.btthoat = New System.Windows.Forms.Button()
        CType(Me.dgvSinhVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 268)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Sinh Viên:"
        '
        'dgvSinhVien
        '
        Me.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSinhVien.Location = New System.Drawing.Point(20, 11)
        Me.dgvSinhVien.Name = "dgvSinhVien"
        Me.dgvSinhVien.Size = New System.Drawing.Size(762, 227)
        Me.dgvSinhVien.TabIndex = 1
        '
        'txtMaSV
        '
        Me.txtMaSV.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMaSV.Location = New System.Drawing.Point(141, 265)
        Me.txtMaSV.Name = "txtMaSV"
        Me.txtMaSV.Size = New System.Drawing.Size(230, 20)
        Me.txtMaSV.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Họ Tên:"
        '
        'txtHoTen
        '
        Me.txtHoTen.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHoTen.Location = New System.Drawing.Point(141, 306)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(230, 20)
        Me.txtHoTen.TabIndex = 4
        '
        'txtTuoi
        '
        Me.txtTuoi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTuoi.Location = New System.Drawing.Point(141, 346)
        Me.txtTuoi.Name = "txtTuoi"
        Me.txtTuoi.Size = New System.Drawing.Size(230, 20)
        Me.txtTuoi.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 349)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tuổi:"
        '
        'txtDiem
        '
        Me.txtDiem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDiem.Location = New System.Drawing.Point(141, 388)
        Me.txtDiem.Name = "txtDiem"
        Me.txtDiem.Size = New System.Drawing.Size(230, 20)
        Me.txtDiem.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 391)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nhập Điểm:"
        '
        'btnthem
        '
        Me.btnthem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnthem.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthem.Location = New System.Drawing.Point(453, 268)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(138, 46)
        Me.btnthem.TabIndex = 9
        Me.btnthem.Text = "THÊM"
        Me.btnthem.UseVisualStyleBackColor = False
        '
        'btnsua
        '
        Me.btnsua.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsua.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsua.ForeColor = System.Drawing.Color.Black
        Me.btnsua.Location = New System.Drawing.Point(632, 268)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(136, 46)
        Me.btnsua.TabIndex = 10
        Me.btnsua.Text = "SỬA"
        Me.btnsua.UseVisualStyleBackColor = False
        '
        'btnxoa
        '
        Me.btnxoa.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnxoa.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxoa.Location = New System.Drawing.Point(453, 331)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(138, 46)
        Me.btnxoa.TabIndex = 11
        Me.btnxoa.Text = "XÓA"
        Me.btnxoa.UseVisualStyleBackColor = False
        '
        'btnHienThi
        '
        Me.btnHienThi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnHienThi.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHienThi.ForeColor = System.Drawing.Color.Transparent
        Me.btnHienThi.Location = New System.Drawing.Point(632, 331)
        Me.btnHienThi.Name = "btnHienThi"
        Me.btnHienThi.Size = New System.Drawing.Size(136, 46)
        Me.btnHienThi.TabIndex = 12
        Me.btnHienThi.Text = "HIỂN THỊ"
        Me.btnHienThi.UseVisualStyleBackColor = False
        '
        'btncaonhat
        '
        Me.btncaonhat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btncaonhat.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncaonhat.Location = New System.Drawing.Point(453, 391)
        Me.btncaonhat.Name = "btncaonhat"
        Me.btncaonhat.Size = New System.Drawing.Size(138, 46)
        Me.btncaonhat.TabIndex = 13
        Me.btncaonhat.Text = "ĐIỂM CAO"
        Me.btncaonhat.UseVisualStyleBackColor = False
        '
        'btthoat
        '
        Me.btthoat.BackColor = System.Drawing.Color.Red
        Me.btthoat.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btthoat.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btthoat.Location = New System.Drawing.Point(632, 391)
        Me.btthoat.Name = "btthoat"
        Me.btthoat.Size = New System.Drawing.Size(136, 46)
        Me.btthoat.TabIndex = 14
        Me.btthoat.Text = "THOÁT"
        Me.btthoat.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 465)
        Me.Controls.Add(Me.btthoat)
        Me.Controls.Add(Me.btncaonhat)
        Me.Controls.Add(Me.btnHienThi)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDiem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTuoi)
        Me.Controls.Add(Me.txtHoTen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMaSV)
        Me.Controls.Add(Me.dgvSinhVien)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "QUẢN LÝ SINH VIÊN"
        CType(Me.dgvSinhVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvSinhVien As DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtMaSV As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents txtTuoi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDiem As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnthem As Button
    Friend WithEvents btnsua As Button
    Friend WithEvents btnxoa As Button
    Friend WithEvents btnHienThi As Button
    Friend WithEvents btncaonhat As Button
    Friend WithEvents btthoat As Button
End Class
