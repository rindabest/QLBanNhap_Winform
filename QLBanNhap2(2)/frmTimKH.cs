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
    public partial class frmTimKH : Form
    {
        public frmTimKH()
        {
            InitializeComponent();
        }
        string sConnect = "Data Source=RINN\\SQLDEV2;Initial Catalog=dbms_nhom2;Integrated Security=True;TrustServerCertificate=True";
        public string MaKHChon { get { return txtBox_Makh_TimKh.Text; } }

        public bool KhachHangMoi = false; // Đánh dấu nếu không tìm thấy KH

        private void LoadData()
        {
            string sQuery = "SELECT * FROM KHACHHANG";
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(sConnect))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sQuery, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }




        private void button1_Click(object sender, EventArgs e)
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

            using (SqlCommand cmd = new SqlCommand("prTimKHTheoSDT", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SoDT", txtBox_Sodt_timKh.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                try
                {
                    adapter.Fill(ds);

                    if (ds.Tables.Count >= 3)
                    {
                        // Bảng 1: Thông tin khách hàng
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            DataRow row = ds.Tables[0].Rows[0];
                            txtBox_Makh_TimKh.Text = row["MaKH"].ToString();
                            txtBox_TenKh_TimKH.Text = row["TenKH"].ToString();
                            txtBox_diachi_TimKH.Text = row["DiaChi"].ToString();
                        }

                        // Bảng 2: Hàng hóa đã mua
                        dtgv_KHdamua_TimKH.DataSource = ds.Tables[1];

                        // Bảng 3: Tổng chi tiêu
                        if (ds.Tables[2].Rows.Count > 0)
                        {
                            object value = ds.Tables[2].Rows[0]["TongTienChiTieu"];
                            decimal tongTien = (value != DBNull.Value) ? Convert.ToDecimal(value) : 0;
                            txt_Tongtien_TimKH.Text = tongTien.ToString();
                        }
                        else
                        {
                            txt_Tongtien_TimKH.Text = "0";
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Không tìm thấy khách hàng. Bạn có muốn thêm mới không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        frmThemKH formThemKH = new frmThemKH();

                        if (formThemKH.ShowDialog() == DialogResult.OK)
                        {
                            // Điền thông tin KH mới
                            txtBox_Makh_TimKh.Text = formThemKH.newMaKH;
                            txtBox_TenKh_TimKH.Text = formThemKH.newTenKH;
                            txtBox_diachi_TimKH.Text = formThemKH.newDiaChi;
                            txtBox_Sodt_timKh.Text = formThemKH.newSoDT;

                            // Đặt tổng chi tiêu mặc định là 0
                            txt_Tongtien_TimKH.Text = "0";

                            // Xoá bảng hàng hoá đã mua (vì KH mới chưa có)
                            dtgv_KHdamua_TimKH.DataSource = null;
                            dtgv_KHdamua_TimKH.Rows.Clear();

                            // Đặt cờ nếu cần biết KH mới được tạo
                            KhachHangMoi = true;

                            // Không đóng form, để người dùng tiếp tục thao tác
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }

                conn.Close();
            }
        }

        private void btn_chonKH_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // Đặt kết quả của hộp thoại là OK
            this.Close(); // Đóng hộp thoại

        }
    }
}
