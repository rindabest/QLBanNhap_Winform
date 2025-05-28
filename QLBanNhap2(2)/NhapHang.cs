using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanNhap2_2_
{
    public partial class NhapHang : Form
    {
        public NhapHang()
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
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_sub_NhapHang.SelectedTab == tabPage1)
            {

            }
            else if (tabControl_sub_NhapHang.SelectedTab == tabPage2)
            {

            }
        }

        private void btn_NhapChiTiet_Click(object sender, EventArgs e)
        {
            tabControl_sub_NhapHang.SelectedTab = tabPage2;

        }



        private void cb_ChonNCC_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void LoadCBmaNCC()
        {
            string query = "SELECT MANCC, TENNCC FROM NHACUNGCAP";
            cb_ChonNCC.DataSource = DataProvider.LoadCSDL(query);
            cb_ChonNCC.DisplayMember = "TENNCC";
            cb_ChonNCC.ValueMember = "MANCC";
        }

        private void LoadDhmoi()
        {
            string query = "SELECT TOP 1 * FROM CUNGCAP ORDER BY SODH DESC";
            DataTable dt = DataProvider.LoadCSDL(query);
            dt.Clear();
            dt = DataProvider.LoadCSDL(query);
            dataGridView_CungCap.DataSource = dt;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string maNCC = (string)cb_ChonNCC.SelectedValue;
            string ngayhd = dtp_NgayLap.Value.ToString("yyyy-MM-dd");
            string maHDCC = txt_MaHD_CC.Text;
            string query = $"INSERT INTO CUNGCAP (MANCC, NGAYLAP, SODH) VALUES ('{maNCC}', '{ngayhd}', N'{maHDCC}')";
            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công");
                LoadDhmoi();
                ResetText(new List<Control> { cb_ChonNCC, dtp_NgayLap, txt_MaHD_CC });
                UnableControls(new List<Control> { cb_ChonNCC, dtp_NgayLap, txt_MaHD_CC, btn_Luu });


                txt_MADH.Text = maHDCC;
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }

        }
        private void LoadTableNhapHangCC()
        {
            // query ->  lay data tu csdl -> datatable -> datagridview
            string query = "SELECT TOP 1000 * FROM CUNGCAP ORDER BY NGAYLAP DESC";
            dt.Clear();
            dt = DataProvider.LoadCSDL(query);
            dataGridView_CungCap.DataSource = dt;
        }

        private void cb_ChonNCC_Click(object sender, EventArgs e)
        {
            LoadCBmaNCC();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            ResetText(new List<Control> { cb_ChonNCC, dtp_NgayLap, txt_MaHD_CC });
        }

        private void btn_them_CC_Click(object sender, EventArgs e)
        {
            EnableControls(new List<Control> { cb_ChonNCC, dtp_NgayLap, txt_MaHD_CC, btn_Luu });
            ResetText(new List<Control> { cb_ChonNCC, dtp_NgayLap, txt_MaHD_CC });
            cb_ChonNCC.Focus();

            string connectionString = "Data Source=RINN\\SQLDEV2;Initial Catalog=dbms_nhom2;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Tạo SqlCommand để gọi stored procedure
                    using (SqlCommand command = new SqlCommand("GetNewMADHCC", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số OUTPUT
                        SqlParameter outputParam = new SqlParameter("@New_SODHCC", SqlDbType.VarChar, 10)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputParam);

                        // Thực thi stored procedure
                        command.ExecuteNonQuery();

                        // Lấy giá trị từ tham số OUTPUT
                        string newMaHDCC = outputParam.Value.ToString();

                        // Điền giá trị vào txtBox_mahang_Lh
                        txt_MaHD_CC.Text = newMaHDCC;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_hienthìullCC_Click(object sender, EventArgs e)
        {
            LoadTableNhapHangCC();
        }

        private void LoadCbbLoaiHang()
        {
            string query = "SELECT MAHH, TENHH FROM HANGHOA";
            cbBox_MAHH_CCCT.DataSource = DataProvider.LoadCSDL(query);
            cbBox_MAHH_CCCT.DisplayMember = "TENHH";
            cbBox_MAHH_CCCT.ValueMember = "MAHH";

        }

        private void cbBox_MAHH_CCCT_Click(object sender, EventArgs e)
        {
            LoadCbbLoaiHang();
        }
        private void LoadTableChiTietCungCap()
        {
            string query = "SELECT * FROM CUNGCAP_CHITIET WHERE SODH = (SELECT MAX(CAST(SODH AS INT)) FROM CUNGCAP_CHITIET)";
            dt.Clear();
            dt = DataProvider.LoadCSDL(query);
            dtgv_CCCT.DataSource = dt;

        }

        private void btn_luu_CCCT_Click(object sender, EventArgs e)
        {

            string madh = txt_MADH.Text;
            string maHH = (string)cbBox_MAHH_CCCT.SelectedValue;
            string nsx = dtp_nsx_CCCT.Value.ToString("yyyy-MM-dd");
            string sld = txt_slDat_CCCT.Text;
            string gianhap = txt_GiaNhap_CCCT.Text;
            string chietkhau = txt_CK_CCCT.Text;
            int hsd = GetHSD(maHH);

            string query = $"INSERT INTO CUNGCAP_CHITIET (SODH, MAHH, SLDAT, GIANHAP, CK, NSX, HSD) VALUES ('{madh}', '{maHH}', '{sld}','{gianhap}', '{chietkhau}', N'{nsx}', {hsd})";


            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Thêm chi tiết cung cấp thành công");
                LoadTableChiTietCungCap();
                ResetText(new List<Control> { cbBox_MAHH_CCCT, dtp_nsx_CCCT, txt_slDat_CCCT, txt_GiaNhap_CCCT, txt_CK_CCCT });

            }
            else
            {
                MessageBox.Show("Thêm chi tiết cung cấp thất bại");

            }
        }
            
        private void btn_huy_CCCT_Click(object sender, EventArgs e)
        {
            ResetText(new List<Control> { cbBox_MAHH_CCCT, dtp_nsx_CCCT, txt_slDat_CCCT, txt_GiaNhap_CCCT, txt_CK_CCCT });
        }

        public int GetHSD(string mahh)
        {
            // Chuỗi kết nối đến SQL Server
            string connectionString = "Data Source=RINN\\SQLDEV2;Initial Catalog=dbms_nhom2;Integrated Security=True;TrustServerCertificate=True";

            // Giá trị trả về từ function
            int hsd = 0;

            try
            {
                // Tạo kết nối
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Tạo lệnh SQL để gọi function
                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.fthemHSD(@mahh)", conn))
                    {
                        // Thêm tham số cho function
                        cmd.Parameters.AddWithValue("@mahh", mahh);

                        // Thực thi lệnh và lấy giá trị trả về
                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int parsedHSD))
                        {
                            hsd = parsedHSD;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi (hiển thị thông báo hoặc ghi log)
                MessageBox.Show($"Error: {ex.Message}");
            }

            return hsd;
        }

        private void btn_finish_CCCT_Click(object sender, EventArgs e)
        {
            tabControl_sub_NhapHang.SelectedTab = tabPage1;
            LoadDhmoi();
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            UnableControls(new List<Control> { cb_ChonNCC, dtp_NgayLap, txt_MaHD_CC, btn_Luu });
        }
    }
}
