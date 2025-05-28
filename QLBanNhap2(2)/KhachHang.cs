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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        public void EnableControls(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                control.Enabled = true;
            }
        }
        public void UnableControls(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                control.Enabled = false;
            }
        }
        public void ResetText(List<Control> controls)
        {
            foreach (Control control in controls)
                control.Text = "";
        }

        private void LoadTableKhachHang()
        {
            string query = $"SELECT * FROM KhachHang";
            dt.Clear();
            dt=DataProvider.LoadCSDL(query);
            dtgv_kh.DataSource = dt;
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadTableKhachHang();
            UnableControls(new List<Control> { txtBox_Makh_Kh, txtBox_TenKh_Kh, txtBox_Sodt_Kh, txtBox_diachi_KH, btn_luu_kh, btn_capnhat_kh, btn_xoa_kh });
        }

        private void btn_them_kh_Click(object sender, EventArgs e)
        {
            EnableControls(new List<Control> { txtBox_Makh_Kh, txtBox_TenKh_Kh, txtBox_Sodt_Kh, txtBox_diachi_KH, btn_luu_kh});
            ResetText(new List<Control> { txtBox_Makh_Kh, txtBox_TenKh_Kh, txtBox_Sodt_Kh, txtBox_diachi_KH });
            txtBox_Makh_Kh.Focus();
            string connectionString = "Data Source=RINN\\SQLDEV2;Initial Catalog=dbms_nhom2;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Tạo SqlCommand để gọi stored procedure
                    using (SqlCommand command = new SqlCommand("GetNewMAKH", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số OUTPUT
                        SqlParameter outputParam = new SqlParameter("@New_MAKH", SqlDbType.VarChar, 10)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputParam);

                        // Thực thi stored procedure
                        command.ExecuteNonQuery();

                        // Lấy giá trị từ tham số OUTPUT
                        string newMaKh = outputParam.Value.ToString();

                        // Điền giá trị vào txtBox_Makh_Kh
                        txtBox_Makh_Kh.Text = newMaKh;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btn_luu_kh_Click(object sender, EventArgs e)
        {
            string makh = txtBox_Makh_Kh.Text;
            string tenkh = txtBox_TenKh_Kh.Text;
            string sodt = txtBox_Sodt_Kh.Text;
            string diachi = txtBox_diachi_KH.Text;
            string query = $"INSERT INTO KHACHHANG (MAKH, TENKH, SODT, DIACHI) VALUES ('{makh}', N'{tenkh}', '{sodt}', N'{diachi}')";
            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Thêm khách hàng thành công");
                LoadTableKhachHang();
                UnableControls(new List<Control> { txtBox_Makh_Kh, txtBox_TenKh_Kh, txtBox_Sodt_Kh, txtBox_diachi_KH, btn_luu_kh });
                ResetText(new List<Control> { txtBox_Makh_Kh, txtBox_TenKh_Kh, txtBox_Sodt_Kh, txtBox_diachi_KH });
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại");
            }
        }

        private void dtgv_kh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_kh.SelectedRows.Count > 0)
            {
                var dongduoc = dtgv_kh.SelectedRows[0];
                txtBox_Makh_Kh.Text = dongduoc.Cells["MAKH"].Value.ToString();
                txtBox_TenKh_Kh.Text = dongduoc.Cells["TENKH"].Value.ToString();
                txtBox_Sodt_Kh.Text = dongduoc.Cells["SODT"].Value.ToString();
                txtBox_diachi_KH.Text = dongduoc.Cells["DIACHI"].Value.ToString();
                EnableControls(new List<Control> { txtBox_TenKh_Kh, txtBox_Sodt_Kh, txtBox_diachi_KH, btn_luu_kh, btn_capnhat_kh, btn_xoa_kh });
                txtBox_Makh_Kh.Enabled = false;
            }
        }

        private void btn_capnhat_kh_Click(object sender, EventArgs e)
        {
            string makh = txtBox_Makh_Kh.Text;
            string tenkh = txtBox_TenKh_Kh.Text;
            string sodt = txtBox_Sodt_Kh.Text;
            string diachi = txtBox_diachi_KH.Text;
            string query = $"UPDATE KHACHHANG SET TENKH = N'{tenkh}', SODT = '{sodt}', DIACHI = N'{diachi}' WHERE MAKH = '{makh}'";
            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Cập nhật khách hàng thành công");
                LoadTableKhachHang();
                UnableControls(new List<Control> { txtBox_Makh_Kh, txtBox_TenKh_Kh, txtBox_Sodt_Kh, txtBox_diachi_KH, btn_luu_kh, btn_xoa_kh, btn_capnhat_kh });
                ResetText(new List<Control> { txtBox_Makh_Kh, txtBox_TenKh_Kh, txtBox_Sodt_Kh, txtBox_diachi_KH });
            }
            else
            {
                MessageBox.Show("Cập nhật khách hàng thất bại");
            }

        }

        private void btn_xoa_kh_Click(object sender, EventArgs e)
        {
            string makh = txtBox_Makh_Kh.Text;
            string query = $"DELETE FROM KHACHHANG WHERE MAKH = '{makh}'";
            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Xóa khách hàng thành công");
                LoadTableKhachHang();
                UnableControls(new List<Control> { txtBox_Makh_Kh, txtBox_TenKh_Kh, txtBox_Sodt_Kh, txtBox_diachi_KH, btn_luu_kh, btn_xoa_kh, btn_capnhat_kh });
                ResetText(new List<Control> { txtBox_Makh_Kh, txtBox_TenKh_Kh, txtBox_Sodt_Kh, txtBox_diachi_KH });
            }
            else
            {
                MessageBox.Show("Xóa khách hàng thất bại");
            }
        }
    }
}
