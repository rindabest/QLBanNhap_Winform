using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanNhap2_2_
{
    public class PhanQuyen
    {
        // Thuộc tính lưu thông tin đăng nhập và quyền của người dùng
        public string TenDangNhap { get; set; }
        public string Quyen { get; set; }

        //tạo singleton: có thể gọi trên toàn prj
        private static PhanQuyen _instance;
        public static PhanQuyen Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PhanQuyen();
                }
                return _instance;
            }
        }

        //Khởi tạo phương thức kiểm tra quyền của người dùng
        public bool IsQuanLy => Quyen == "Chu";
        public bool IsNhanVienBan => Quyen == "BanHang";
        public bool IsNhanVienKho => Quyen == "KiemKho";

        //Dăng xuất người dùng, xóa thông tin phân quyền
        public void DangXuat()
        {
            _instance = null;
        }

    }
}
