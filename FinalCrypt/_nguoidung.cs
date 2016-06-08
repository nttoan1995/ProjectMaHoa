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
            string data = email + "\n" + ngaysinh + "\n" + diachi + "\n"
                + sodienthoai + "\n" + dodaikhoa + "\n" + passphrase + "\n"
                + salt;
            fs.WriteLine(data);
        }
        public void docthongtin(StreamReader fs)
        {
            email = fs.ReadLine();
            ngaysinh = fs.ReadLine();
            diachi = fs.ReadLine();
            sodienthoai = fs.ReadLine();
            dodaikhoa = fs.ReadLine();
            passphrase = fs.ReadLine();
            salt = fs.ReadLine();
        }
    }
}
