using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDT.Model.DTO
{
    public class HoaDonDK
    {
        public HoaDonDK(string maHDDK, int maSim, decimal chiPhi)
        {
            MaHDDK = maHDDK;
            IDSIM = maSim;
            ChiPhiDK = chiPhi;
        }

        public HoaDonDK(DataRow row)
        {
            MaHDDK = (string)row["MaHDDK"];
            IDSIM = (int)row["IDSIM"];
            ChiPhiDK = (decimal)row["ChiPhiDK"];
        }

            public HoaDonDK() { }

        public string MaHDDK { get; set; }
        public int IDSIM { get; set; }
        public decimal ChiPhiDK { get; set; }
    }
}
