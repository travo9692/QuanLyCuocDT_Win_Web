using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDT.Model.DTO
{
    public class HoaDonThanhToan
    {
        public HoaDonThanhToan(string maHD, int maSim, decimal phiHangThang, decimal tongTien, DateTime tgTaoHD, bool thanhToan, bool stt)
        {
            MaHDTC = maHD;
            IDSIM = maSim;
            PhiHangThang = phiHangThang;
            NgayTao = tgTaoHD;
            ThanhToan = ThanhToan;
            TongTien = tongTien;
            TrangThai = stt;

        }

        public HoaDonThanhToan(DataRow row)
        {
            MaHDTC = (string)row["MaHDTC"];
            IDSIM = (int)row["IDSIM"];
            PhiHangThang = (decimal)row["PhiHangThang"];
            NgayTao = (DateTime)row["NgayTao"];
            ThanhToan = (bool)row["ThanhToan"];
            TongTien = (decimal)row["ThanhTien"];
            TrangThai = (bool)row["Status"];
        }

        public HoaDonThanhToan() { }

        public string MaHDTC { get; set; }
        public int? IDSIM { get; set; }
        public decimal? PhiHangThang { get; set; }
        public decimal? TongTien { get; set; }
        public DateTime? NgayTao { get; set; }
        public bool? ThanhToan { get; set; }
        public bool? TrangThai { get; set; }
    }
}
