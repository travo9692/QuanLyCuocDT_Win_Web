    using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDT.Model.DTO
{
    public class LoaiCuoc
    {
        public LoaiCuoc(string maGiaCuoc, TimeSpan tgBD, TimeSpan tgKT, decimal giaCuoc)
        {
            MaGiaCuoc = maGiaCuoc;
            TGBD = tgBD;
            TGKT = tgKT;
            Giacuoc1 = giaCuoc;
        }

        public LoaiCuoc(DataRow row)
        {
            MaGiaCuoc = (string)row["MaGiaCuoc"];
            TGBD = (TimeSpan)row["TGBD"];
            TGKT = (TimeSpan)row["TGKT"];
            Giacuoc1 = (decimal)row["GiaCuoc"];
        }

        public LoaiCuoc() { }

        public string MaGiaCuoc { get; set; }
        public TimeSpan? TGBD { get; set; }
        public TimeSpan? TGKT { get; set; }
        public decimal? Giacuoc1 { get; set; }
    }
}
