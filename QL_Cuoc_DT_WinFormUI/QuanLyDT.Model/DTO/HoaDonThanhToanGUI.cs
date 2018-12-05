using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDT.Model.DTO
{
    public class HoaDonThanhToanGUI
    {
        public HoaDonThanhToanGUI(int maHD, int maKH, string soSim, decimal cuocTB, DateTime tgTaoHD, bool thanhToan, decimal thanhTien, bool stt)
        {
            MaHD = maHD;
            MaKH = maKH;
            SoSim = soSim;
            CuocThueBao = cuocTB;
            TG_TaoHoaDon = tgTaoHD;
            ThanhToan = ThanhToan;
            ThanhTien = ThanhTien;
            Status = stt;

        }

        public HoaDonThanhToanGUI(DataRow row)
        {
            MaHD = (int)row["MaHD"];
            MaKH = (int)row["MaKH"];
            SoSim = (string)row["SoSim"];
            CuocThueBao = (decimal)row["CuocThueBao"];
            TG_TaoHoaDon = (DateTime)row["TG_TaoHoaDon"];
            ThanhToan = (bool)row["ThanhToan"];
            ThanhTien = (decimal)row["ThanhTien"];
            Status = (bool)row["Status"];
        }

        public HoaDonThanhToanGUI() { }



        public int MaHD { get; set; }
        public int MaKH { get; set; }
        public string SoSim { get; set; }
        public decimal CuocThueBao { get; set; }
        public DateTime TG_TaoHoaDon { get; set; }
        public bool ThanhToan { get; set; }
        public decimal ThanhTien { get; set; }
        public bool Status { get; set; }
    }
}
