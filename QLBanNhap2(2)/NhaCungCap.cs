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
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
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

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            LoadTableNhaCungCap();
            UnableControls(new List<Control> { txtBox_Mancc_NCC, txtBox_Tenncc_NCC, txtBox_Sodt_NCC, txtBox_diachi_NCC, txtBox_CkNpp_NCC ,btn_luu_NCC, btn_capnhat_NCC, btn_xoa_NCC });
        }
        private void LoadTableNhaCungCap()
        {
            string query = $"SELECT * FROM NhaCungCap";
            dt.Clear();
            dt = DataProvider.LoadCSDL(query);
            dtgv_NCC.DataSource = dt;
        }

        private void btn_them_NCC_Click(object sender, EventArgs e)
        {
            EnableControls(new List<Control> { txtBox_Mancc_NCC, txtBox_Tenncc_NCC, txtBox_Sodt_NCC, txtBox_diachi_NCC, txtBox_CkNpp_NCC, btn_luu_NCC });
            ResetText(new List<Control> { txtBox_Mancc_NCC, txtBox_Tenncc_NCC, txtBox_Sodt_NCC, txtBox_diachi_NCC, txtBox_CkNpp_NCC });
            txtBox_Mancc_NCC.Focus();
            
            string connectionString = "Data Source=RINN\\SQLDEV2;Initial Catalog=dbms_nhom2;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Tạo SqlCommand để gọi stored procedure
                    using (SqlCommand command = new SqlCommand("GetNewMANCC", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số OUTPUT
                        SqlParameter outputParam = new SqlParameter("@New_MANCC", SqlDbType.VarChar, 10)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputParam);

                        // Thực thi stored procedure
                        command.ExecuteNonQuery();

                        // Lấy giá trị từ tham số OUTPUT
                        string newMaNcc = outputParam.Value.ToString();

                        // Điền giá trị vào txtBox_Mancc_NCC
                        txtBox_Mancc_NCC.Text = newMaNcc;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_luu_NCC_Click(object sender, EventArgs e)
        {
            string mancc = txtBox_Mancc_NCC.Text;
            string tenncc = txtBox_Tenncc_NCC.Text;
            string sodt = txtBox_Sodt_NCC.Text;
            string diachi = txtBox_diachi_NCC.Text;
            string cknpp = txtBox_CkNpp_NCC.Text;
            string query = $"INSERT INTO NHACUNGCAP (MANCC, TENNCC, SODT, DIACHI, CKNPP) VALUES ('{mancc}', N'{tenncc}', '{sodt}', N'{diachi}', '{cknpp}')";
            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Thêm nhà cung cấp thành công");
                LoadTableNhaCungCap();
                UnableControls(new List<Control> { txtBox_Mancc_NCC, txtBox_Tenncc_NCC, txtBox_Sodt_NCC, txtBox_diachi_NCC, txtBox_CkNpp_NCC, btn_luu_NCC });
                ResetText(new List<Control> { txtBox_Mancc_NCC, txtBox_Tenncc_NCC, txtBox_Sodt_NCC, txtBox_diachi_NCC, txtBox_CkNpp_NCC });
            }    
            else
            {
                MessageBox.Show("Thêm nhà cung cấp thất bại");
            }    
        }

        private void dtgv_NCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_NCC.SelectedRows.Count > 0)
            {
                var dongduocchon = dtgv_NCC.SelectedRows[0];
                txtBox_Mancc_NCC.Text = dongduocchon.Cells["MANCC"].Value.ToString();
                txtBox_Tenncc_NCC.Text = dongduocchon.Cells["TENNCC"].Value.ToString();
                txtBox_Sodt_NCC.Text = dongduocchon.Cells["SODT"].Value.ToString();
                txtBox_diachi_NCC.Text = dongduocchon.Cells["DIACHI"].Value.ToString();
                txtBox_CkNpp_NCC.Text = dongduocchon.Cells["CKNPP"].Value.ToString();
                EnableControls(new List<Control> { txtBox_Tenncc_NCC, txtBox_Sodt_NCC, txtBox_diachi_NCC, txtBox_CkNpp_NCC, btn_luu_NCC, btn_capnhat_NCC, btn_xoa_NCC });
                txtBox_Mancc_NCC.Enabled = false;
            }
        }

        private void btn_capnhat_NCC_Click(object sender, EventArgs e)
        {
            string mancc = txtBox_Mancc_NCC.Text;
            string tenncc = txtBox_Tenncc_NCC.Text;
            string sodt = txtBox_Sodt_NCC.Text;
            string diachi = txtBox_diachi_NCC.Text;
            string cknpp = txtBox_CkNpp_NCC.Text;
            string query = $"UPDATE NHACUNGCAP SET TENNCC = N'{tenncc}', SODT = '{sodt}', DIACHI = N'{diachi}', CKNPP = '{cknpp}'  WHERE MANCC = '{mancc}'";
            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Cập nhật nhà cung cấp thành công");
                LoadTableNhaCungCap();
                UnableControls(new List<Control> { txtBox_Mancc_NCC, txtBox_Tenncc_NCC, txtBox_Sodt_NCC, txtBox_diachi_NCC, txtBox_CkNpp_NCC, btn_luu_NCC, btn_capnhat_NCC, btn_xoa_NCC });
                ResetText(new List<Control> { txtBox_Mancc_NCC, txtBox_Tenncc_NCC, txtBox_Sodt_NCC, txtBox_diachi_NCC, txtBox_CkNpp_NCC });
            }
            else
            {
                MessageBox.Show("Cập nhật nhà cung cấp thất bại");
            }
        }

        private void btn_xoa_NCC_Click(object sender, EventArgs e)
        {
            string mancc = txtBox_Mancc_NCC.Text;
            string query = $"DELETE FROM NHACUNGCAP WHERE MANCC = '{mancc}'";
            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Xóa nhà cung cấp thành công");
                LoadTableNhaCungCap();
                UnableControls(new List<Control> { txtBox_Mancc_NCC, txtBox_Tenncc_NCC, txtBox_Sodt_NCC, txtBox_diachi_NCC, txtBox_CkNpp_NCC, btn_luu_NCC, btn_capnhat_NCC, btn_xoa_NCC });
                ResetText(new List<Control> { txtBox_Mancc_NCC, txtBox_Tenncc_NCC, txtBox_Sodt_NCC, txtBox_diachi_NCC, txtBox_CkNpp_NCC });

            }
            else
            {
                MessageBox.Show("Xóa nhà cung cấp thất bại");
            }
        }
    }
}
