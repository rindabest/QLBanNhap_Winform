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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_timkiem_NvTopds_Click(object sender, EventArgs e)
        {

            string quy = cbBox_quy_Tk.Text; // Change from SelectedValue to Text to get the actual selected value
            string nam = txt_nam_NvTopDS_TK.Text;
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=RINN\\SQLDEV2;Initial Catalog=dbms_nhom2;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("prNVCoDSoMax", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // Add logic to convert quy to int if needed
                        command.Parameters.AddWithValue("@quy", quy);
                        command.Parameters.AddWithValue("@nam", nam);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dtgv_NvTopDS_Tk.DataSource = dataTable;
                        }
                    }
                    if (dtgv_NvTopDS_Tk.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có nhân viên bán trong quý " + quy + " Năm " + nam);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi:" + ex.Message);
            }
        }

        private void dtgv_NvTopDS_Tk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_hienthiDT_TK_Click(object sender, EventArgs e)
        {
            string quy = cBox_QuyDT_TK.Text;
            string nam = txt_namDT_TK.Text;
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=RINN\\SQLDEV2;Initial Catalog=dbms_nhom2;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("prDoanhThu_Quy", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // Add logic to convert quy to int if needed
                        command.Parameters.AddWithValue("@Quy", quy);
                        command.Parameters.AddWithValue("@Nam", nam);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dtgv_dt_tk.DataSource = dataTable;
                        }
                    }
                    if (dtgv_dt_tk.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có doanh thu trong quý " + quy + " Năm " + nam);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi:" + ex.Message);
            }
        }
    }
}
