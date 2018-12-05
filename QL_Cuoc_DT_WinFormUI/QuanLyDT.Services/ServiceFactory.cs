using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDT.Services
{
    public class ServiceFactory
    {
        public static LibraryService GetLibraryService(string persistanceStrategry)
        {
            LibraryService libraryService = null;
            if (persistanceStrategry == "ADO")
            {
                libraryService = new LibraryService(
                    new QuanLyDT.Repository.ADO.KhachHangRepository(),
                    new QuanLyDT.Repository.ADO.ThanhToanRepository(),
                    new QuanLyDT.Repository.ADO.SimRepository(),
                    new QuanLyDT.Repository.ADO.LoaiCuocRepository(),
                    new QuanLyDT.Repository.ADO.HoaDonDangKyRepository()
                   );
            }
            //else
            //{
            //    libraryService = new LibraryService(new QuanLyDT.Repository.EF.TaiKhoanRepository());
            //}
            return libraryService;
        }
    }
}
