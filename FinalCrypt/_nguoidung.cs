using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FinalCrypt
{
    class _nguoidung
    {
        private string email = "";
        private string hoten = "";
        private string ngaysinh = "";
        private string diachi = "";
        private string sodienthoai = "";
        private string dodaikhoa = "";
        private string passphrase = "";
        private string salt = "";

        public _nguoidung()
        {
            email = "";
            hoten = ""; 
            ngaysinh = "";
            diachi = "";
            sodienthoai = "";
            dodaikhoa = "";
            passphrase = "";
            salt = "";
        }

        public _nguoidung(string _email, 
                            string _hoten,
                            string _ngaysinh,
                            string _diachi,
                            string _sodienthoai,
                            string _dodaikhoa,
                            string _passphrase,
                            string _salt)
        {
            email = _email;
            hoten = _hoten;
            ngaysinh = _ngaysinh;
            diachi = _diachi;
            sodienthoai = _sodienthoai;
            dodaikhoa = _dodaikhoa;
            passphrase = _passphrase;
            salt = _salt;
        }
        /// <summary>
        /// Lưu lại thông tin người dung đã đăng kí hợp lệ
        /// </summary>
        /// <param name="fs">File lưu thông tin người dùng</param>
        public void ghithongtin(StreamWriter fs)
        {
            fs.WriteLine(email);
            fs.WriteLine(hoten);
            fs.WriteLine(ngaysinh);
            fs.WriteLine(diachi);
            fs.WriteLine(sodienthoai);
            fs.WriteLine(dodaikhoa);
            fs.WriteLine(passphrase);
            fs.WriteLine(salt);
        }
        public void docthongtin(StreamReader fs)
        {
            email = fs.ReadLine();
            hoten = fs.ReadLine();
            ngaysinh = fs.ReadLine();
            diachi = fs.ReadLine();
            sodienthoai = fs.ReadLine();
            dodaikhoa = fs.ReadLine();
            passphrase = fs.ReadLine();
            salt = fs.ReadLine();
        }
    }
}
