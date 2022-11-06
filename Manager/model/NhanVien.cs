using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.model
{
    public class NhanVien
    {
        private int id;
        private string maChiNhanh;
        private string hoTen;
        private string soDienThoai;
        private string maChucVu;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string queQuan;
        private float bacLuong;
        public NhanVien()
        {
        }

        public NhanVien(int id, string maChiNhanh, string hoTen, string soDienThoai, string maChucVu, DateTime ngaySinh,string gioiTinh, string queQuan, float bacLuong)
        {
            this.Id = id;
            this.MaChiNhanh = maChiNhanh;
            this.HoTen = hoTen;
            this.SoDienThoai = soDienThoai;
            this.MaChucVu = maChucVu;
            this.NgaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.QueQuan = queQuan;
            this.BacLuong = bacLuong;
        }

        public int Id { get => id; set => id = value; }
        public string MaChiNhanh { get => maChiNhanh; set => maChiNhanh = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string MaChucVu { get => maChucVu; set => maChucVu = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public float BacLuong { get => bacLuong; set => bacLuong = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
    }
}
