using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDT.Model.DTO
{
    class ChiTietSuDung
    {
        public ChiTietSuDung(int iD, string iDSIM, DateTime? tGBD, DateTime? tGKT, decimal? soPhut7h23h, decimal? soPhut23h7h)
        {
            ID = iD;
            IDSIM = iDSIM;
            TGBD = tGBD;
            TGKT = tGKT;
            SoPhut7h23h = soPhut7h23h;
            SoPhut23h7h = soPhut23h7h;
        }

        public int ID { get; set; }
        public string IDSIM { get; set; }

        public ChiTietSuDung()
        {
        }

        public DateTime? TGBD { get; set; }

        public DateTime? TGKT { get; set; }

        public decimal? SoPhut7h23h { get; set; }

        public decimal? SoPhut23h7h { get; set; }
    }
}
