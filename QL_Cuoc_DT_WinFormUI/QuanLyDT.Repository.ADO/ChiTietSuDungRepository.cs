using QuanLyDT.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDT.Model.DTO;
using System.Data;


namespace QuanLyDT.Repository.ADO
{
    public class ChiTietSuDungRepository : IChiTietSuDungRepository
    {
        public List<ChiTietSuDung> DSChiTietSuDung()
        {
            List<ChiTietSuDung> list = new List<ChiTietSuDung>();

            DataTable table = DataProvider.Instane.ExecuteReader("EXECUTE dbo.SP_DSChiTietSuDung");

            foreach (DataRow row in table.Rows)
            {
                list.Add(new ChiTietSuDung(row));
            }
            return list;
        }

        public bool ThemChiTietSuDung(ChiTietSuDung ctsd)
        {
            int row = DataProvider.Instane.ExecuteNonQuery("EXEC dbo.SP_TaoChiTietSuDung @IDSIM , @TGBD , @TGKT , @SoPhut7h23h , @SoPhut23h7h ",
                                        new object[] {  ctsd.IDSIM, ctsd.TGBD, ctsd.TGKT, ctsd.SoPhut7h23h, ctsd.SoPhut23h7h });
            return row > 0;
        }

        public List<ChiTietSuDung> ChiTietSuDungByMaSim(int info)
        {
            List<ChiTietSuDung> list = new List<ChiTietSuDung>();
            DataTable table = DataProvider.Instane.ExecuteReader(" EXEC dbo.SP_ChiTietSuDungByMaSim   @ThongTin ", new object[] { info });

            foreach (DataRow row in table.Rows)
            {
                list.Add(new ChiTietSuDung(row));
            }
            return list;
        }

    }
}
