namespace QuanLyDT.Repositories.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDonDangKy")]
    public partial class HoaDonDangKy
    {
        [Key]
        [StringLength(20)]
        public string MaHDDK { get; set; }

        public int? IDSIM { get; set; }

        public decimal? ChiPhiDK { get; set; }

        public virtual ThongTinSim ThongTinSim { get; set; }
    }
}
