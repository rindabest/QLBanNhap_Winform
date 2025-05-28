using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanNhap2_2_
{
    public class DataProvider
    {
        const string connString = "Data Source=RINN\\SQLDEV2;Initial Catalog=dbms_nhom2;Integrated Security=True;TrustServerCertificate=True";
        private static SqlConnection connection;
        public static void OpenConnection()
        {
            connection = new SqlConnection(connString); // khởi tạo db
            connection.Open();
        }
        public static void CloseConnection()
        {
            connection.Close();
        }
        
        public static DataTable LoadCSDL(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter ad = new SqlDataAdapter(command);
                ad.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }
        //sua, xoa, update
        public static int ThaoTacCSDL(string query)
        {
            int kq = 0;
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand(query, connection);
                kq = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return kq;
        }
    }
}
