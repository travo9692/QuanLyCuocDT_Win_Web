using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDT.Model.DTO
{
    public class KhachHang
    {
        public KhachHang(string maKH, string tenKH, string cmnd, string ngheNghiep, string chucVu, string diaChi, bool status)
        {
            MaKH = maKH;
            TenKH = tenKH;
            CMND = cmnd;
            NgheNghiep = ngheNghiep;
            ChucVu = chucVu;
            DiaChi = diaChi;
            TinhTrang = status;
        }

        public KhachHang(DataRow row)
        {
            MaKH = (string)row["MAKH"];
            TenKH = (string)row["TENKH"];
            CMND = (string)row["CMND"];
            NgheNghiep = (string)row["NGHENGHIEP"];
            ChucVu = (string)row["CHUCVU"];
            DiaChi = (string)row["DIACHI"];
            TinhTrang = (bool)row["TinhTrang"];        
        }

        public KhachHang() { }


        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string CMND { get; set; }
        public string NgheNghiep { get; set; }
        public string ChucVu { get; set; }
        public string DiaChi { get; set; }
        public bool? TinhTrang { get; set; }

    }
}
