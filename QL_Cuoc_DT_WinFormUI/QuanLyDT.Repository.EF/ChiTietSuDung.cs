namespace QuanLyDT.Repositories.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietSuDung")]
    public partial class ChiTietSuDung
    {
        public int ID { get; set; }

        public int? IDSIM { get; set; }

        public DateTime? TGBD { get; set; }

        public DateTime? TGKT { get; set; }

        public decimal? SoPhut7h23h { get; set; }

        public decimal? SoPhut23h7h { get; set; }

        public virtual ThongTinSim ThongTinSim { get; set; }
    }
}
