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
        private _nguoidung[] dsnguoidung;
        private int soluongnguoidung;
        public _danhsachnguoidung(StreamReader fs)
        {
            soluongnguoidung = Convert.ToInt32(fs.ReadLine());
            dsnguoidung = new _nguoidung[soluongnguoidung];
            for (int i = 0; i < soluongnguoidung; i++)
                dsnguoidung[i].docthongtin(fs);
        }

    }
}
