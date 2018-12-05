using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDT.Model.DTO
{
    public class Sim
    {
        public Sim(int idSim, string soDienThoai, string maKH, DateTime ngayDK, bool status)
        {
            IDSIM = idSim;
            SoDienThoai = soDienThoai;
            MaKH = maKH;
            NgayDK = ngayDK;
            TinhTrang = status;
        }

        public Sim(DataRow row)
        {
            IDSIM = (int)row["IDSIM"];
            SoDienThoai = (string)row["SoDienThoai"];
            MaKH = (string)row["MaKH"];
            NgayDK = (DateTime)row["NgayDK"];
            TinhTrang = (bool)row["TinhTrang"];
        }

        public Sim() { }


        public int IDSIM { get; set; }
        public string SoDienThoai { get; set; }
        public string MaKH { get; set; }
        public DateTime? NgayDK { get; set; }
        public bool? TinhTrang { get; set; }
    }
}
