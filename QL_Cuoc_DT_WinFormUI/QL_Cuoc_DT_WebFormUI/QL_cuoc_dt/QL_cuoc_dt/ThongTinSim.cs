//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QL_cuoc_dt
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThongTinSim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongTinSim()
        {
            this.ChiTietSuDungs = new HashSet<ChiTietSuDung>();
            this.HoaDonDangKies = new HashSet<HoaDonDangKy>();
            this.HoaDonTinhCuocs = new HashSet<HoaDonTinhCuoc>();
        }
    
        public int IDSIM { get; set; }
        public string SoDienThoai { get; set; }
        public string MaKH { get; set; }
        public Nullable<System.DateTime> NgayDK { get; set; }
        public Nullable<bool> TinhTrang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietSuDung> ChiTietSuDungs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonDangKy> HoaDonDangKies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonTinhCuoc> HoaDonTinhCuocs { get; set; }
        public virtual KhachHang KhachHang { get; set; }
    }
}
