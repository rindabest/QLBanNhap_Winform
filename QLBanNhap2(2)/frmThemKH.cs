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
    public partial class frmThemKH : Form
    {
        public frmThemKH()
        {
            InitializeComponent();
        }
        string sConnect = "Data Source=RINN\\SQLDEV2;Initial Catalog=dbms_nhom2;Integrated Security=True;TrustServerCertificate=True";
        public string maKHMoi { get; private set; }
        public string newMaKH { get { return mtb_MaKh_timKH.Text; } }
        public string newTenKH { get { return txtBox_TenKh_ThemKh.Text; } }
        public string newDiaChi { get { return txtBox_diachi_ThemKH.Text; } }
        public string newSoDT { get { return txtBox_Sodt_ThemKH.Text; } }

        private string TaoMaKH()
        {
            SqlConnection conn = new SqlConnection(sConnect);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối bị lỗi!");
            }

            string newMaKH = "";
            string sQuery = "SELECT MAX(MaKH) FROM KhachHang"; // Lấy mã lớn nhất
            SqlCommand cmd = new SqlCommand(sQuery, conn);
            object result = cmd.ExecuteScalar(); // Lấy giá trị từ DB

            if (result != DBNull.Value)
            {
                long maxMaKH = Convert.ToInt64(result);
                return (maxMaKH + 1).ToString("D10"); // Chuyển về chuỗi 10 chữ số
            }
            else
            {
                return newMaKH = "0000000001"; // Nếu DB chưa có khách hàng, bắt đầu từ 0000000001
            }
        }

        private void frmThemKH_Load(object sender, EventArgs e)
        {
            mtb_MaKh_timKH.Mask = "0000000000"; // Định dạng mã KH là 10 chữ số
            mtb_MaKh_timKH.PromptChar = ' '; // Hiển thị ký tự '0' nếu chưa nhập
            mtb_MaKh_timKH.Text = TaoMaKH(); // Tạo mã KH mới
        }

        private void btn_themKh_ThemKH_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(sConnect);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối bị lỗi!");
            }

            string sMaKH = mtb_MaKh_timKH.Text;
            string sTenKH = txtBox_TenKh_ThemKh.Text;
            string sDiaChi = txtBox_diachi_ThemKH.Text;
            string sSoDT = txtBox_Sodt_ThemKH.Text;

            string sQuery = "INSERT INTO KHACHHANG(MaKH, TenKH, SoDT, DiaChi) VALUES(@MaKH, @TenKH, @SoDT, @DiaChi)";
            SqlCommand cmd = new SqlCommand(sQuery, conn);
            cmd.Parameters.AddWithValue("@MaKH", sMaKH);
            cmd.Parameters.AddWithValue("@TenKH", sTenKH);
            cmd.Parameters.AddWithValue("@SoDT", sSoDT);
            cmd.Parameters.AddWithValue("@DiaChi", sDiaChi);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");

                this.maKHMoi = sMaKH;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm mới thất bại!");
            }
            finally
            {
                conn.Close();
            }

        }

        private void btn_Huy_ThemKH_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Đóng form nếu chọn "Yes"

            }
        }
    }
}
