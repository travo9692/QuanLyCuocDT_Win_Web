using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDT.Model.DTO;

namespace QuanLyDT.Model.Interfaces
{
    public interface IChiTietSuDungRepository
    {
        List<ChiTietSuDung> DSChiTietSuDung();
        bool ThemChiTietSuDung(ChiTietSuDung ctsd);
        List<ChiTietSuDung> ChiTietSuDungByMaSim(int info);
    }
}
