namespace QuanLyDT.Repositories.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinSim")]
    public partial class ThongTinSim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongTinSim()
        {
            ChiTietSuDungs = new HashSet<ChiTietSuDung>();
            HoaDonDangKies = new HashSet<HoaDonDangKy>();
            HoaDonTinhCuocs = new HashSet<HoaDonTinhCuoc>();
        }

        [Key]
        public int IDSIM { get; set; }

        [StringLength(12)]
        public string SoDienThoai { get; set; }

        [StringLength(20)]
        public string MaKH { get; set; }

        public DateTime? NgayDK { get; set; }

        public bool? TinhTrang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietSuDung> ChiTietSuDungs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonDangKy> HoaDonDangKies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonTinhCuoc> HoaDonTinhCuocs { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
