using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanNhap2_2_
{
    public partial class MainBhFrm : Form
    {
        public MainBhFrm()
        {
            InitializeComponent();
        }
        string sConnect = "Data Source=RINN\\SQLDEV2;Initial Catalog=dbms_nhom2;Integrated Security=True;TrustServerCertificate=True";
        DataTable dt = new DataTable();

        private void EnableControls(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                control.Enabled = true;
            }
        }
        private void UnableControls(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                control.Enabled = false;
            }
        }
        private void ResetText(List<Control> controls)
        {
            foreach (Control control in controls)
                control.Text = "";
        }

        private void MainBhFrm_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            UnableControls(new List<Control> { txtMaDonHang, txtMaKhachHang, cbBox_Manv_BH, txtTongTien, dateTimePickerDH, btnLuu });

            string quyen = PhanQuyen.Instance.Quyen;

            switch (quyen)
            {
                case "Chu":
                    {
                        // Toàn quyền, không cần giới hạn gì
                        break;
                    }
                case "BanHang":
                    {
                        UnableControls(new List<Control> { btnXoa, btnSua });
                        break;
                    }
            }

        }
        private void LoadTableDonHang()
        {
            // query ->  lay data tu csdl -> datatable -> datagridview
            string query = "SELECT TOP 1000 * FROM BANHANG ORDER BY NGAYHD DESC";
            dt.Clear();
            dt = DataProvider.LoadCSDL(query);
            dtgvDH.DataSource = dt;
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            LoadTableDonHang();
        }
        private void LoadDHmoi()
        {
            string query = "SELECT TOP 1 * FROM BANHANG ORDER BY MAHD DESC";
            DataTable dt = DataProvider.LoadCSDL(query);
            dt.Clear();
            dt = DataProvider.LoadCSDL(query);
            dtgvDH.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            EnableControls(new List<Control> { txtMaDonHang, txtMaKhachHang, cbBox_Manv_BH, txtTongTien, dateTimePickerDH, btnLuu });
            ResetText(new List<Control> { txtMaDonHang, txtMaKhachHang, cbBox_Manv_BH, dateTimePickerDH, txtTongTien });
            txtMaDonHang.Focus();

            string connectionString = "Data Source=RINN\\SQLDEV2;Initial Catalog=dbms_nhom2;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Tạo SqlCommand để gọi stored procedure
                    using (SqlCommand command = new SqlCommand("GetNewMADHBH", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số OUTPUT
                        SqlParameter outputParam = new SqlParameter("@New_SODHBH", SqlDbType.VarChar, 10)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputParam);

                        // Thực thi stored procedure
                        command.ExecuteNonQuery();

                        // Lấy giá trị từ tham số OUTPUT
                        string newMaHDBH = outputParam.Value.ToString();

                        // Điền giá trị vào txtBox_mahang_Lh
                        txtMaDonHang.Text = newMaHDBH;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maDonHang = txtMaDonHang.Text;
            string maKhachHang = txtMaKhachHang.Text;
            string maNhanVien = cbBox_Manv_BH.SelectedValue.ToString(); // Lấy giá trị từ ComboBox
            string ngayHD = dateTimePickerDH.Value.ToString("yyyy-MM-dd");

            string query = $"INSERT INTO BANHANG (MAHD, MAKH, MANV, NGAYHD) VALUES ('{maDonHang}', '{maKhachHang}', '{maNhanVien}', '{ngayHD}')";
            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Thêm don hang thành công");
                LoadDHmoi();
                UnableControls(new List<Control> { txtMaDonHang, txtMaKhachHang, cbBox_Manv_BH, txtTongTien, dateTimePickerDH, btnLuu });
                ResetText(new List<Control> { txtMaDonHang, txtMaKhachHang, cbBox_Manv_BH, dateTimePickerDH, txtTongTien });

                
                txt_MADH_CTDH.Text = maDonHang; // Gán mã đơn hàng vào ô txt_MADH_CTDH
            }
            else
            {
                MessageBox.Show("Thêm don hang thất bại");
            }
        }

        private void dtgvDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvDH.SelectedRows.Count > 0)
            {
                var dongDuocChon = dtgvDH.SelectedRows[0];
                txtMaDonHang.Text = dongDuocChon.Cells["MAHD"].Value.ToString();
                txtMaKhachHang.Text = dongDuocChon.Cells["MAKH"].Value.ToString();
                cbBox_Manv_BH.Text = dongDuocChon.Cells["MANV"].Value.ToString();
                txtTongTien.Text = dongDuocChon.Cells["TONGTIEN"].Value.ToString();
                dateTimePickerDH.Value = DateTime.Parse(dongDuocChon.Cells["NGAYHD"].Value.ToString());

                EnableControls(new List<Control> { txtMaKhachHang, cbBox_Manv_BH, txtTongTien, dateTimePickerDH, btnSua, btnXoa });

                txtMaDonHang.Enabled = false; // Không cho phép sửa mã đơn hàng
            }
            string quyen = PhanQuyen.Instance.Quyen;

            switch (quyen)
            {
                case "Chu":
                    {
                        // Toàn quyền, không cần giới hạn gì
                        break;
                    }
                case "BanHang":
                    {
                        UnableControls(new List<Control> { btnXoa, btnSua });
                        break;
                    }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maDonHang = txtMaDonHang.Text;
            string maKhachHang = txtMaKhachHang.Text;
            string maNhanVien = cbBox_Manv_BH.Text;
            string tongTien = txtTongTien.Text;
            string ngayHD = dateTimePickerDH.Value.ToString("yyyy-MM-dd");

            string query = $"UPDATE BANHANG SET MAKH = '{maKhachHang}', MANV = '{maNhanVien}', NGAYHD = '{ngayHD}', TONGTIEN = {tongTien} WHERE MAHD = '{maDonHang}'";
            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Sửa đơn hàng thành công");
                LoadTableDonHang();
                UnableControls(new List<Control> { txtMaDonHang, txtMaKhachHang, cbBox_Manv_BH, txtTongTien, dateTimePickerDH, btnSua, btnXoa });
                ResetText(new List<Control> { txtMaDonHang, txtMaKhachHang, cbBox_Manv_BH, dateTimePickerDH, txtTongTien });
            }
            else
            {
                MessageBox.Show("Sửa đơn hàng thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maDonHang = txtMaDonHang.Text;
            string query = $"DELETE FROM BANHANG WHERE MAHD = '{maDonHang}'";
            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Xóa đơn hàng thành công");
                LoadTableDonHang();
                UnableControls(new List<Control> { txtMaDonHang, txtMaKhachHang, cbBox_Manv_BH, txtTongTien, dateTimePickerDH, btnLuu });
                ResetText(new List<Control> { txtMaDonHang, txtMaKhachHang, cbBox_Manv_BH, dateTimePickerDH, txtTongTien });

            }
            else
            {
                MessageBox.Show("Xóa đơn hàng thất bại");
            }
        }

        private void btnTimDHtheoMa_Click(object sender, EventArgs e)
        {
            string tukhoa = txtMaDHcantim.Text;
            string query = $"SELECT * FROM BANHANG WHERE MAHD LIKE '%{tukhoa}%'";
            dt.Clear();
            dt = DataProvider.LoadCSDL(query);
            dtgvDH.DataSource = dt;
        }

        private void btn_timKH_Click(object sender, EventArgs e)
        {
            frmTimKH frmTimKH = new frmTimKH();
            var result = frmTimKH.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Tìm được KH → lấy mã KH
                txtMaKhachHang.Text = frmTimKH.MaKHChon;
            }
            else if (frmTimKH.KhachHangMoi)
            {
                // Nếu không tìm thấy KH → mở form thêm KH mới
                DialogResult rs = MessageBox.Show("Không tìm thấy khách hàng. Thêm mới?", "Xác nhận", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    frmThemKH frmThemKH = new frmThemKH();
                    if (frmThemKH.ShowDialog() == DialogResult.OK)
                    {
                        txtMaKhachHang.Text = frmThemKH.maKHMoi;
                    }
                }
            }

        }


        private void LoadCbbLoaiHang()
        {
            string query = "SELECT MAHH, TENHH FROM HANGHOA";
            cbBox_MAHH_CTDH.DataSource = DataProvider.LoadCSDL(query);
            cbBox_MAHH_CTDH.DisplayMember = "TENHH";
            cbBox_MAHH_CTDH.ValueMember = "MAHH";
        }

        private void cbBox_MAHH_CTDH_Click(object sender, EventArgs e)
        {
            LoadCbbLoaiHang();
        }

        private void LoadTableChiTietDH()
        {
            string query = "SELECT * FROM BANHANG_CHITIET WHERE MAHD = (SELECT MAX(CAST(MAHD AS INT)) FROM BANHANG_CHITIET)";
            dt.Clear();
            dt = DataProvider.LoadCSDL(query);
            dtgv_CCDH.DataSource = dt;

        }

        private void btn_luu_CTDH_Click(object sender, EventArgs e)
        {
            string madh = txt_MADH_CTDH.Text;
            string mahh = (string)cbBox_MAHH_CTDH.SelectedValue;
            string sl = txt_sl_CTDH.Text;
            string query = $"INSERT INTO BANHANG_CHITIET(MAHD, MAHH, SOLUONG) VALUES ('{madh}', '{mahh}', '{sl}')";

            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Thêm chi tiết đơn hàng thành công");
                LoadTableChiTietDH();
                ResetText(new List<Control> { cbBox_MAHH_CTDH, txt_sl_CTDH });

            }
            else
            {
                MessageBox.Show("Thêm chi tiết đơn hàng thất bại");

            }
        }

        private void btn_dong_CTDH_Click(object sender, EventArgs e)
        {
            ResetText(new List<Control> { cbBox_MAHH_CTDH, txt_sl_CTDH });
        }

        private void btn_finish_CTDH_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            LoadDHmoi();
        }

        private void btn_xem_CTDH_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void cbBox_Manv_BH_Click(object sender, EventArgs e)
        {
            LoadCBmanv();
        }
        private void LoadCBmanv()
        {
            string query = "SELECT MANV, TENNV FROM NHANVIEN";
            cbBox_Manv_BH.DataSource = DataProvider.LoadCSDL(query);
            cbBox_Manv_BH.DisplayMember = "TENNV";
            cbBox_Manv_BH.ValueMember = "MANV";
        }
    }
}
