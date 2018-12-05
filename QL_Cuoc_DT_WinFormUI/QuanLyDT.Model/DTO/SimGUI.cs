using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDT.Model.DTO
{
    public class SimGUI
    {
        public SimGUI(int maKH, string hoTenKH, string soSim, string ngheNghiep, string diaChi, string cmnd, bool status)
        {
            MaKH = maKH;
            TenKH = hoTenKH;
            SoSim = soSim;
            NgheNghiep = ngheNghiep;
            DiaChi = diaChi;
            CMND = cmnd;
            Status = status;
        }

        public SimGUI(DataRow row)
        {
            MaKH = (int)row["MaKH"];
            TenKH = (string)row["TenKH"];
            SoSim = (string)row["SoSim"];
            NgheNghiep = (string)row["NgheNghiep"];
            DiaChi = (string)row["DiaChi"];
            CMND = (string)row["CMND"];
            Status = (bool)row["Status"];
        }

        public SimGUI() { }


        public string SoSim { get; set; }
        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public string NgheNghiep { get; set; }
        public string CMND { get; set; }
        public string DiaChi { get; set; }
        public bool Status { get; set; }

    }
}
