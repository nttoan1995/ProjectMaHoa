using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FinalCrypt
{
    class _danhsachnguoidung
    {
        private List<_nguoidung> dsnguoidung = new List<_nguoidung>();
        public _danhsachnguoidung(StreamReader fs)
        {
            while( !fs.EndOfStream)
            {
                _nguoidung nguoidunghientai = new _nguoidung();
                nguoidunghientai.docthongtin(fs);
                dsnguoidung.Add(nguoidunghientai);
            }
        }

    }
}
