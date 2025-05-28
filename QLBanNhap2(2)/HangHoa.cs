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
    public partial class HangHoa : Form
    {
        public HangHoa()
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
        public void LoadTableLoaiHang()
        {
            // query ->  lay data tu csdl -> datatable -> datagridview
            string query = "SELECT * FROM NGANHHANG";
            dt.Clear();
            dt = DataProvider.LoadCSDL(query);
            dtgv_lh.DataSource = dt;
        }
        public void LoadTableHangHoa()
        {
            // query ->  lay data tu csdl -> datatable -> datagridview
            string query = "SELECT * FROM HANGHOA";
            dt.Clear();
            dt = DataProvider.LoadCSDL(query);
            dtgv_hh.DataSource = dt;
        }
        private void btn_capnhat_LH_Click(object sender, EventArgs e)
        {

        }

        private void Cbbox_LH_HH_Click(object sender, EventArgs e)
        {

        }

        private void tabControl_sub_HangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_sub_HangHoa.SelectedTab == tabPage1)
            {
                LoadTableLoaiHang();
                UnableControls(new List<Control> { txtBox_mahang_LH, txtBox_tenloaihang_LH });
            }
            else if (tabControl_sub_HangHoa.SelectedTab == tabPage2)
            {
                LoadTableHangHoa();
                UnableControls(new List<Control> { Cbbox_LH_HH, txtBox_maHH_HH, txtBox_tenHH_HH, txtBox_dvt_HH, txtBox_soluong_HH });
            }
        }

        private void HangHoa_Load(object sender, EventArgs e)
        {
            LoadTableLoaiHang();
        }

        private void btn_them_LH_Click(object sender, EventArgs e)
        {
            EnableControls(new List<Control> { txtBox_mahang_LH, txtBox_tenloaihang_LH, btn_luu_LH });
            ResetText(new List<Control> { txtBox_mahang_LH, txtBox_tenloaihang_LH });
            txtBox_mahang_LH.Focus();

            string connectionString = "Data Source=RINN\\SQLDEV2;Initial Catalog=dbms_nhom2;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Tạo SqlCommand để gọi stored procedure
                    using (SqlCommand command = new SqlCommand("GetNewMang", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số OUTPUT
                        SqlParameter outputParam = new SqlParameter("@New_Mang", SqlDbType.VarChar, 10)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputParam);

                        // Thực thi stored procedure
                        command.ExecuteNonQuery();

                        // Lấy giá trị từ tham số OUTPUT
                        string newMang = outputParam.Value.ToString();

                        // Điền giá trị vào txtBox_mahang_Lh
                        txtBox_mahang_LH.Text = newMang;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_luu_LH_Click(object sender, EventArgs e)
        {
            string maLH = txtBox_mahang_LH.Text;
            string tenLH = txtBox_tenloaihang_LH.Text;
            string query = $"INSERT INTO NGANHHANG (MANG, TENNG) VALUES ('{maLH}', N'{tenLH}')";
            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công");
                LoadTableLoaiHang();
                UnableControls(new List<Control> { txtBox_mahang_LH, txtBox_tenloaihang_LH, btn_luu_LH });
                ResetText(new List<Control> { txtBox_mahang_LH, txtBox_tenloaihang_LH });
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void dtgv_lh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_lh.SelectedRows.Count > 0)
            {
                var dongDuocChon = dtgv_lh.SelectedRows[0];
                txtBox_mahang_LH.Text = dongDuocChon.Cells["MANG"].Value.ToString();
                txtBox_tenloaihang_LH.Text = dongDuocChon.Cells["TENNG"].Value.ToString();
                EnableControls(new List<Control> { txtBox_tenloaihang_LH, btn_luu_LH, btn_xoa_LH });
                txtBox_mahang_LH.Enabled = false;
            }
        }

        private void btn_capnhat_LH_Click_1(object sender, EventArgs e)
        {
            string maLH = txtBox_mahang_LH.Text;
            string tenLH = txtBox_tenloaihang_LH.Text;
            string query = $"UPDATE NGANHHANG SET TENNG = N'{tenLH}' WHERE MANG = '{maLH}'";
            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Cập nhật thành công");
                LoadTableLoaiHang();
                UnableControls(new List<Control> { txtBox_mahang_LH, txtBox_tenloaihang_LH, btn_luu_LH, btn_xoa_LH, btn_capnhat_LH });
                ResetText(new List<Control> { txtBox_mahang_LH, txtBox_tenloaihang_LH });
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công");
            }
        }

        private void btn_xoa_LH_Click(object sender, EventArgs e)
        {
            string maLH = txtBox_mahang_LH.Text;
            string query = $"DELETE FROM NGANHHANG WHERE MANG = '{maLH}'";
            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Xóa thành công");
                LoadTableLoaiHang();
                UnableControls(new List<Control> { txtBox_mahang_LH, txtBox_tenloaihang_LH, btn_luu_LH, btn_xoa_LH });
                ResetText(new List<Control> { txtBox_mahang_LH, txtBox_tenloaihang_LH });
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        /* cac thao tac tren tab hang hoa*///////////////////////////////////

        private void LoadCbbLoaiHang()
        {
            string query = "SELECT MANG, TENNG FROM NGANHHANG";
            Cbbox_LH_HH.DataSource = DataProvider.LoadCSDL(query);
            Cbbox_LH_HH.DisplayMember = "TENNG";
            Cbbox_LH_HH.ValueMember = "MANG";

        }

        private void Cbbox_LH_HH_Click_1(object sender, EventArgs e)
        {
            LoadCbbLoaiHang();
        }

        private void btn_them_hh_Click(object sender, EventArgs e)
        {
            EnableControls(new List<Control> { Cbbox_LH_HH, txtBox_maHH_HH, txtBox_tenHH_HH, txtBox_dvt_HH, txtBox_soluong_HH, btn_luu_HH });
            ResetText(new List<Control> { Cbbox_LH_HH, txtBox_maHH_HH, txtBox_tenHH_HH, txtBox_dvt_HH, txtBox_soluong_HH });
            Cbbox_LH_HH.Focus();

            string connectionString = "Data Source=RINN\\SQLDEV2;Initial Catalog=dbms_nhom2;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Tạo SqlCommand để gọi stored procedure
                    using (SqlCommand command = new SqlCommand("GetNewMaHH", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số OUTPUT
                        SqlParameter outputParam = new SqlParameter("@New_MaHH", SqlDbType.VarChar, 10)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputParam);

                        // Thực thi stored procedure
                        command.ExecuteNonQuery();

                        // Lấy giá trị từ tham số OUTPUT
                        string newMaHH = outputParam.Value.ToString();

                        // Điền giá trị vào txtBox_mahang_Lh
                        txtBox_maHH_HH.Text = newMaHH;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_luu_HH_Click(object sender, EventArgs e)
        {
            string maLh = (string)Cbbox_LH_HH.SelectedValue;
            string maHH = txtBox_maHH_HH.Text;
            string tenHH = txtBox_tenHH_HH.Text;
            string dvt = txtBox_dvt_HH.Text;
            string sl = txtBox_soluong_HH.Text;
            string query = $"INSERT INTO HANGHOA (MANG, MAHH, TENHH, DVT, SLTON) VALUES ('{maLh}', '{maHH}', N'{tenHH}', N'{dvt}', {sl})";
            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công");
                LoadTableHangHoa();
                UnableControls(new List<Control> { Cbbox_LH_HH, txtBox_maHH_HH, txtBox_tenHH_HH, txtBox_dvt_HH, txtBox_soluong_HH, btn_luu_HH });
                ResetText(new List<Control> { Cbbox_LH_HH, txtBox_maHH_HH, txtBox_tenHH_HH, txtBox_dvt_HH, txtBox_soluong_HH });
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btn_capnhap_HH_Click(object sender, EventArgs e)
        {
            string maHH = txtBox_maHH_HH.Text;
            string tenHH = txtBox_tenHH_HH.Text;
            string dvt = txtBox_dvt_HH.Text;
            string sl = txtBox_soluong_HH.Text;
            string query = $"UPDATE HANGHOA SET TENHH = N'{tenHH}', DVT = N'{dvt}', SLTON = {sl} WHERE MAHH = '{maHH}'";
            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Cập nhật hàng hoá thành công");
                LoadTableHangHoa();
                UnableControls(new List<Control> { Cbbox_LH_HH, txtBox_maHH_HH, txtBox_tenHH_HH, txtBox_dvt_HH, txtBox_soluong_HH, btn_luu_HH, btn_xoa_HH });
                ResetText(new List<Control> { Cbbox_LH_HH, txtBox_maHH_HH, txtBox_tenHH_HH, txtBox_dvt_HH, txtBox_soluong_HH });
            }
            else
            {
                MessageBox.Show("Cập nhật hàng hoá không thành công");
            }
        }

        private void dtgv_hh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_hh.SelectedRows.Count > 0)
            {
                var dongDuocChon = dtgv_hh.SelectedRows[0];
                Cbbox_LH_HH.SelectedValue = dongDuocChon.Cells["MANG"].Value.ToString();
                txtBox_maHH_HH.Text = dongDuocChon.Cells["MAHH"].Value.ToString();
                txtBox_tenHH_HH.Text = dongDuocChon.Cells["TENHH"].Value.ToString();
                txtBox_dvt_HH.Text = dongDuocChon.Cells["DVT"].Value.ToString();
                txtBox_soluong_HH.Text = dongDuocChon.Cells["SLTON"].Value.ToString();
                EnableControls(new List<Control> { txtBox_tenHH_HH, txtBox_dvt_HH, txtBox_soluong_HH, btn_luu_HH, btn_xoa_HH });
                txtBox_maHH_HH.Enabled = false;
                Cbbox_LH_HH.Enabled = false;
            }
        }

        private void btn_xoa_HH_Click(object sender, EventArgs e)
        {
            string maHH = txtBox_maHH_HH.Text;
            string query = $"DELETE FROM GIA_BAN WHERE MAGB = '{maHH}'; DELETE FROM HANGHOA WHERE MAHH = '{maHH}';";
            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Xóa hàng hoá thành công");
                LoadTableHangHoa();
                UnableControls(new List<Control> { Cbbox_LH_HH, txtBox_maHH_HH, txtBox_tenHH_HH, txtBox_dvt_HH, txtBox_soluong_HH, btn_luu_HH, btn_xoa_HH });
                ResetText(new List<Control> { Cbbox_LH_HH, txtBox_maHH_HH, txtBox_tenHH_HH, txtBox_dvt_HH, txtBox_soluong_HH });
            }
            else
            {
                MessageBox.Show("Xóa hàng hoá không thành công");
            }
        }
    }
}
