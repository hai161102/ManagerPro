using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.model
{
    public class ChucVu
    {
        private string maChucVu;
        private string chucVuName;

        public string MaChucVu { get => maChucVu; set => maChucVu = value; }
        public string ChucVuName { get => chucVuName; set => chucVuName = value; }

        public ChucVu(string maChucVu, string chucVuName)
        {
            this.MaChucVu = maChucVu;
            this.ChucVuName = chucVuName;
        }

        public ChucVu()
        {
        }
    }
}
