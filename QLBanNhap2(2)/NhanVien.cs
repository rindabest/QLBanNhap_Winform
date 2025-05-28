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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadTableNhanVien();
            UnableControls(new List<Control> { txtBox_MaNv_Nv, txtBox_TenNv_Nv, txtBox_Sodt_Nv,txtBox_diachi_Nv, btn_luu_nv, btn_capnhat_nv, btn_xoa_nv });
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
        private void LoadTableNhanVien()
        {
            string query = $"SELECT * FROM NhanVien";
            dt.Clear();
            dt = DataProvider.LoadCSDL(query);
            dtgv_nv.DataSource = dt;
        }

        private void btn_them_nv_Click(object sender, EventArgs e)
        {
            EnableControls(new List<Control> { txtBox_MaNv_Nv, txtBox_TenNv_Nv, txtBox_Sodt_Nv, txtBox_diachi_Nv, btn_luu_nv });
            ResetText(new List<Control> { txtBox_MaNv_Nv, txtBox_TenNv_Nv, txtBox_Sodt_Nv, txtBox_diachi_Nv });
            txtBox_MaNv_Nv.Focus();

            string connectionString = "Data Source=RINN\\SQLDEV2;Initial Catalog=dbms_nhom2;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Tạo SqlCommand để gọi stored procedure
                    using (SqlCommand command = new SqlCommand("GetNewMANV", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số OUTPUT
                        SqlParameter outputParam = new SqlParameter("@New_MANV", SqlDbType.VarChar, 10)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputParam);

                        // Thực thi stored procedure
                        command.ExecuteNonQuery();

                        // Lấy giá trị từ tham số OUTPUT
                        string newMaNv = outputParam.Value.ToString();

                        // Điền giá trị vào txtBox_MaNv_Nv
                        txtBox_MaNv_Nv.Text = newMaNv;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_luu_nv_Click(object sender, EventArgs e)
        {
            string manv = txtBox_MaNv_Nv.Text;
            string tennv = txtBox_TenNv_Nv.Text;
            string sodt = txtBox_Sodt_Nv.Text;
            string diachi = txtBox_diachi_Nv.Text;
            string query = $"INSERT INTO NHANVIEN (MANV, TENNV, SODT, DIACHI) VALUES ('{manv}', N'{tennv}', '{sodt}', N'{diachi}')";
            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Thêm nhân viên thành công");
                LoadTableNhanVien();
                UnableControls(new List<Control> { txtBox_MaNv_Nv, txtBox_TenNv_Nv, txtBox_Sodt_Nv, txtBox_diachi_Nv, btn_luu_nv });
                ResetText(new List<Control> { txtBox_MaNv_Nv, txtBox_TenNv_Nv, txtBox_Sodt_Nv, txtBox_diachi_Nv });
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }
        }

        private void dtgv_nv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_nv.SelectedRows.Count > 0)
            {
                var dongduocchon = dtgv_nv.SelectedRows[0];
                txtBox_MaNv_Nv.Text = dongduocchon.Cells["MANV"].Value.ToString();
                txtBox_TenNv_Nv.Text = dongduocchon.Cells["TENNV"].Value.ToString();
                txtBox_Sodt_Nv.Text = dongduocchon.Cells["SODT"].Value.ToString();
                txtBox_diachi_Nv.Text = dongduocchon.Cells["DIACHI"].Value.ToString();
                EnableControls(new List<Control> { txtBox_TenNv_Nv, txtBox_Sodt_Nv, txtBox_diachi_Nv, btn_luu_nv, btn_capnhat_nv, btn_xoa_nv });
                txtBox_MaNv_Nv.Enabled = false;
            }
        }

        private void btn_capnhat_nv_Click(object sender, EventArgs e)
        {
            string manv = txtBox_MaNv_Nv.Text;
            string tennv = txtBox_TenNv_Nv.Text;
            string sodt = txtBox_Sodt_Nv.Text;
            string diachi = txtBox_diachi_Nv.Text;
            string query = $"UPDATE NHANVIEN SET TENNV = N'{tennv}', SODT = '{sodt}', DIACHI = N'{diachi}' WHERE MANV = '{manv}'";
            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Cập nhật nhân viên thành công");
                LoadTableNhanVien();
                UnableControls(new List<Control> { txtBox_MaNv_Nv, txtBox_TenNv_Nv, txtBox_Sodt_Nv, txtBox_diachi_Nv, btn_luu_nv, btn_capnhat_nv, btn_xoa_nv });
                ResetText(new List<Control> { txtBox_MaNv_Nv, txtBox_TenNv_Nv, txtBox_Sodt_Nv, txtBox_diachi_Nv });
            }
            else
            {
                MessageBox.Show("Cập nhật nhân viên thất bại");
            }
        }

        private void btn_xoa_nv_Click(object sender, EventArgs e)
        {
            string manv = txtBox_MaNv_Nv.Text;
            string query = $"DELETE FROM NHANVIEN WHERE MANV = '{manv}'";
            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Xóa nhân viên thành công");
                LoadTableNhanVien();
                UnableControls(new List<Control> { txtBox_MaNv_Nv, txtBox_TenNv_Nv, txtBox_Sodt_Nv, txtBox_diachi_Nv, btn_luu_nv, btn_capnhat_nv, btn_xoa_nv });
                ResetText(new List<Control> { txtBox_MaNv_Nv, txtBox_TenNv_Nv, txtBox_Sodt_Nv, txtBox_diachi_Nv });
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại");
            }
        }
    }
}
