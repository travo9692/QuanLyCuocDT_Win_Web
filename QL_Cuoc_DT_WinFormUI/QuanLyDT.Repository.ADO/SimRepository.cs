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
    public class SimRepository : ISimRepository
    {
        /// <summary>
        /// lấy danh sách sim trong database
        /// </summary>
        /// <returns></returns>
        public List<Sim> DanhSachSim()
        {
            List<Sim> list = new List<Sim>();

            DataTable table = DataProvider.Instane.ExecuteReader("EXECUTE dbo.SP_DanhSachSim");

            foreach (DataRow row in table.Rows)
            {
                list.Add(new Sim(row));
            }
            return list;
        }

        public List<Sim> TimKiemMaSimMax()
        {
            List<Sim> list = new List<Sim>();

            //DataTable table = DataProvider.Instane.ExecuteReader("EXECUTE dbo.SP_TimKiemMaSimMax");

            //foreach (DataRow row in table.Rows)
            //{
            //    list.Add(new Sim(row));
            //}
            return list;
        }

        /// <summary>
        /// thêm Sim vào database
        /// </summary>
        /// <param name="Sim"></param>
        /// <returns></returns>
        public bool ThemSim(Sim sim)
        {
            int row = DataProvider.Instane.ExecuteNonQuery("EXEC dbo.SP_InsertSim @SoSIm , @MaKH , @NgayDK , @Status ",
                                        new object[] { sim.SoDienThoai, sim.MaKH, sim.NgayDK, sim.TinhTrang});
            return row > 0;
        }

        /// <summary>
        /// tìm kiếm Sim, sử dụng SP_TimKiemSim
        /// </summary>
        /// <param name="col">cột trong database</param>
        /// <param name="info">thông tin cần tìm</param>
        /// <returns></returns>
        public List<Sim> TimKiemSim(string col, string info)
        {
            List<Sim> list = new List<Sim>();
            DataTable table = null;
            if (col == "MaSim")
            {
                int text = int.Parse(info);
                table = DataProvider.Instane.ExecuteReader(" EXEC  dbo.SP_TimKiemSimByMaSim @text ", new object[] { text });
            }
            else if (col == "SoSim")
            {
                info = "%" + info + "%";
                table = DataProvider.Instane.ExecuteReader(" EXEC  dbo.SP_TimKiemSimBySoSim @text ", new object[] { info });
            }
            else
            {
                table = DataProvider.Instane.ExecuteReader(" EXEC  dbo.SP_DanhSachSim", new object[] {});
            }

            foreach (DataRow row in table.Rows)
            {
                list.Add(new Sim(row));
            }
            return list;
        }

        public List<Sim> TimKiemSimSo(string info)
        {
            List<Sim> list = new List<Sim>();
            //DataTable table = DataProvider.Instane.ExecuteReader(" EXEC  dbo.SP_TimKiemSimSo @ThongTin ", new object[] { info });

            //foreach (DataRow row in table.Rows)
            //{
            //    list.Add(new Sim(row));
            //}
            return list;
        }
        /// <summary>
        /// Cập nhật thông tin cho Sim
        /// </summary>
        /// <param name="Sim"></param>
        /// <returns></returns>
        public bool UpdateSim(Sim sim)
        {
            int row = DataProvider.Instane.ExecuteNonQuery("EXEC dbo.SP_UpdateSim @MaSim , @SoSim , @MaKH , @NgayDK , @Status ",
                          new object[] {sim.IDSIM, sim.SoDienThoai, sim.MaKH, sim.NgayDK, sim.TinhTrang });
            return row > 0;
        }

        public bool UpdateKHSim(Sim sim)
        {
            int row = DataProvider.Instane.ExecuteNonQuery("EXEC dbo.SP_UpdateKHSim @MaSim , @MaKH , @Status ",
                          new object[] { sim.IDSIM, sim.MaKH, sim.TinhTrang });
            return row > 0;
        }
    }
}
