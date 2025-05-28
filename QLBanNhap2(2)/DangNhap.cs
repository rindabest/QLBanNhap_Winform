using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanNhap2_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private string EncryptMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống");
                return;
            }
            // Regex cho tài khoản chỉ cho phép chữ cái, số và dấu gạch dưới
            Regex regexTaiKhoan = new Regex(@"^[a-zA-Z0-9_]{3,20}$");

            if (!regexTaiKhoan.IsMatch(tenDangNhap))
            {
                MessageBox.Show("Tài khoản không hợp lệ. Chỉ được chứa chữ cái, số, và dấu gạch dưới, độ dài từ 3-20 ký tự.");
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=RINN\\SQLDEV2;Initial Catalog=dbms_nhom2;Integrated Security=True;TrustServerCertificate=True"))
                {
                    connection.Open();
                    string hashedPassword = EncryptMD5(matKhau);
                    using (SqlCommand command = new SqlCommand("sp_DangNhap", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số đầu vào
                        command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                        command.Parameters.AddWithValue("@MatKhau", hashedPassword);

                        // Thực thi Stored Procedure và lấy kết quả
                        object result = command.ExecuteScalar();
                        int isValid = result != null ? Convert.ToInt32(result) : 0;

                        if (isValid == 1)
                        {
                            Main main = new Main();
                            main.Show();
                        }
                        else
                        {
                            MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }

        }
    }
}
