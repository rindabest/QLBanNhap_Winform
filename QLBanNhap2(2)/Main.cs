using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanNhap2_2_
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_thoat_AD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dispose();
            }
        }
        // xử lí mở form con
        private Form activeform = null;
        private void openChildForm(Form childForm)
        {
            // Xóa các control cũ trong panel_Body (nếu cần)
            panel_Body.Controls.Clear();
            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            // Thêm form con vào panel_Body
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_hanghoa_AD_Click(object sender, EventArgs e)
        {
            openChildForm(new HangHoa());
            label1.Text = "Hàng hóa";
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongKe());
            label1.Text = "Thống kê";
        }

        private void btn_donhang_AD_Click(object sender, EventArgs e)
        {
            openChildForm(new MainBhFrm());
            label1.Text = "Đơn hàng";
        }

        private void btn_khachhang_AD_Click(object sender, EventArgs e)
        {
            openChildForm(new KhachHang());
            label1.Text = "Khách hàng";
        }

        private void btn_nhanvien_AD_Click(object sender, EventArgs e)
        {
            openChildForm(new NhanVien());
            label1.Text = "Nhân viên";
        }

        private void btn_ncc_main_Click(object sender, EventArgs e)
        {
            openChildForm(new NhaCungCap());
            label1.Text = "Nhà cung cấp";
        }

        private void btn_nhaphang_Click(object sender, EventArgs e)
        {
            openChildForm(new NhapHang());
            label1.Text = "Nhập hàng";
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dispose();
            }
        }
    }
}
