using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.IO;

namespace FinalCrypt
{
    public partial class _dangki : Form
    {
        private static Random random = new Random((int)DateTime.Now.Ticks);
        private string salt = "";
        private string hashpassphrase = "";
        public _dangki()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Hàm kiểm tra định dạng email
        /// </summary>
        /// <returns></returns>
        
        string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
        private bool ktemail()
        {
            Regex reg = new Regex(match);
            if (reg.IsMatch(email.Text))
                return true;
            return false;
        }
        /// <summary>
        /// Hàm kiểm tra họ tên do người dùng nhập vào
        /// KIỂM TRA EMAIL ĐÃ ĐƯỢC ĐĂNG KÍ CHƯA
        /// Họ tên khác null
        /// </summary>
        /// <returns></returns>
        private bool kthoten()
        {
            if (hoten.Text == "")
                return false;
            return true;
        }
        /// <summary>
        /// Kiểm tra địa chỉ hợp lệ
        /// Địa chỉ khác null
        /// </summary>
        /// <returns></returns>
        private bool ktdiachi()
        {
            if (diachi.Text == "")
                return false;
            return true;
        }
        /// <summary>
        /// Kiểm tra sdt nhập vào
        /// Phải là chuỗi số
        /// </summary>
        /// <returns></returns>

        private bool ktsodienthoai()
        {
            string dt = dienthoai.Text;
            if (dienthoai.Text == "")
                return false;
            for (int i = 0; i < dienthoai.Text.Length; i++)
                if (dt[i] < '0' || dt[i] > '9')
                    return false;
            return true;
        }
        /// <summary>
        /// Kiểm tra độ dài khóa, phải là chuỗi số và là bội của 64
        /// </summary>
        /// <returns></returns>
        private bool ktdodaikhoa()
        {
            if (dodaikhoa.Text == "")
                return false;
            string slenkey = dodaikhoa.Text;
            for (int i = 0; i < slenkey.Length; i++)
                if (slenkey[i] < '0' || slenkey[i] > '9')
                    return false;
            int lenkey = Convert.ToInt32(slenkey);
            if (lenkey % 64 != 0)
                return false;
            if (lenkey < 512 || lenkey > 1024)
                return false;
            return true;

        }
        /// <summary>
        /// Hàm phát sinh ngẫu nhiên giá trị salt
        /// </summary>
        /// <param name="len">Độ dài của salt</param>
        /// <returns></returns>
        private string randomsalt(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 256)));
                builder.Append(ch);
            }
            return builder.ToString();
        }
        /// <summary>
        /// Hàm hash một chuỗi bất kì
        /// </summary>
        /// <param name="data">Chuỗi cần hash</param>
        /// <param name="salt"></param>
        /// <param name="algorithm">Thuật toán hash</param>
        /// <returns></returns>
        private string StringToHash(string data, string salt, HashAlgorithm algorithm)
        {
            byte[] saltedBytes = Encoding.UTF8.GetBytes(data + salt);     // Combine the data with the salt
            byte[] hashedBytes = algorithm.ComputeHash(saltedBytes);      // Compute the hash value of our input
            return BitConverter.ToString(hashedBytes);
        }
        /// <summary>
        /// Kiểm tra người dùng có nhập đúng pass không
        /// </summary>
        /// <returns></returns>
        private bool ktpassphrase()
        {
            salt = randomsalt(1000);
            string strpassphrase = StringToHash(passpharase.Text, salt, new MD5CryptoServiceProvider());
            string strrepassphrase = StringToHash(repassphrase.Text, salt, new MD5CryptoServiceProvider());
            hashpassphrase = strpassphrase;
            if (strpassphrase == strrepassphrase)
                return true;
            return false;
        }
        /// <summary>
        /// Hàm kiểm tra thông tin người dùng nhập vào
        /// </summary>
        /// <returns></returns>
        private bool ktthongtin()
        {
            if (ktemail() == false)
            {
                MessageBox.Show("Địa chỉ Email không hợp lệ", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (kthoten() == false)
            {
                MessageBox.Show("Họ tên người dùng không hợp lệ", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ktsodienthoai() == false)
            {
                MessageBox.Show("Số điện thoại người dùng không hợp lệ", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ktdiachi() == false)
            {
                MessageBox.Show("Địa chỉ người dùng không hợp lệ", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ktdodaikhoa() == false)
            {
                MessageBox.Show("Độ dài khóa không hợp lệ\nĐộ dài khóa trong khoảng 512 - 1024 và là bộ của 64",
                    "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ktpassphrase() == false)
            {
                MessageBox.Show("Passphrase không hợp lệ\nPhải đảm bảo nhập chính xác password",
                    "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ktthongtin())
            {
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 100;
                progressBar1.Value = 0;
                progressBar1.Step = 1;
                for (int i = 0; i <= 2000; i++)
                {
                    // do something
                    //.....
                    //thi hành tăng ProgressBar
                    progressBar1.PerformStep();
                }
                //Lưu thông tin
                StreamWriter fs = new StreamWriter("data.txt");
                _nguoidung nguoidungmoi = new _nguoidung(email.Text, hoten.Text, ngaysinh.Text, diachi.Text, dienthoai.Text, dodaikhoa.Text, hashpassphrase, salt);
                nguoidungmoi.ghithongtin(fs);
                fs.Close();
                //------------------------------
                MessageBox.Show("Hoàn tất đăng kí và phát sinh khóa", "Info", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
