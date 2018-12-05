namespace QuanLyDT.Repositories.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDonTinhCuoc")]
    public partial class HoaDonTinhCuoc
    {
        [Key]
        [StringLength(20)]
        public string MaHDTC { get; set; }

        public int? IDSIM { get; set; }

        public decimal? PhiHangThang { get; set; }

        public decimal? TongTien { get; set; }

        public DateTime? NgayTao { get; set; }

        public bool? ThanhToan { get; set; }

        public bool? TrangThai { get; set; }

        public virtual ThongTinSim ThongTinSim { get; set; }
    }
}
