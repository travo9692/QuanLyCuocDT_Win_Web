﻿using QuanLyDT.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDT.Model.DTO;
using System.Data;


namespace QuanLyDT.Services
{
    public class LibraryService : IKhachHangRepository, IThanhToanRepository,
        ISimRepository, ILoaiCuocRepository, IHoaDonDangKyRepository, IChiTietSuDungRepository
    {
        #region Repositories

        private IKhachHangRepository khachHangRepository;
        private IThanhToanRepository thanhToanRepository;
        private ISimRepository simRepository;
        private ILoaiCuocRepository loaiCuocRepository;
        private IHoaDonDangKyRepository hoaDonDangKyRepository;
        private IChiTietSuDungRepository chiTietSuDungRepository;

        #endregion Repositories

        #region constructor

        public LibraryService()
        {
        }

        internal LibraryService(IKhachHangRepository khachHangRepository, IThanhToanRepository thanhToanRepository, ISimRepository simRepository, ILoaiCuocRepository loaiCuocRepository, IHoaDonDangKyRepository hoaDonDangKyRepository, IChiTietSuDungRepository chiTietSuDungRepository)
        {
            this.khachHangRepository = khachHangRepository;
            this.thanhToanRepository = thanhToanRepository;
            this.simRepository = simRepository;
            this.loaiCuocRepository = loaiCuocRepository;
            this.hoaDonDangKyRepository = hoaDonDangKyRepository;
            this.chiTietSuDungRepository = chiTietSuDungRepository;
        }

        #endregion constructor

     /*   #region Services cho tài khoản

        public DataTable Login(string userName, string passWord)
        {
            return taiKhoanRepository.Login(userName, passWord);
        }
        public int DoiMatKhau(string userName, string passWord, string newPassWord, int manv)
        {
            return taiKhoanRepository.DoiMatKhau(userName, passWord, newPassWord, manv);
        }

        #endregion Services cho tài khoản
    */


        #region KhachHangServices

        public List<KhachHang> DanhSachKH()
        {
            return khachHangRepository.DanhSachKH();
        }

        public List<KhachHang> TimKiemKH(string col, string info)
        {
            return khachHangRepository.TimKiemKH(col, info);
        }

        public bool ThemKH(KhachHang khachhang)
        {
            return khachHangRepository.ThemKH(khachhang);
        }

        public bool UpdateKH(KhachHang khachhang)
        {
            return khachHangRepository.UpdateKH(khachhang);
        }

        public bool UpdateKHStatus(KhachHang khachhang)
        {
            return khachHangRepository.UpdateKHStatus(khachhang);
        }

        #endregion KhachHangServices


        #region ChiTietSuDungServices

        public List<ChiTietSuDung> DSChiTietSuDung()
        {
            return chiTietSuDungRepository.DSChiTietSuDung();
        }
        public bool ThemChiTietSuDung(ChiTietSuDung ctsd)
        {
            return chiTietSuDungRepository.ThemChiTietSuDung(ctsd);
        }

        public List<ChiTietSuDung> ChiTietSuDungByMaSim(int info)
        {
            return chiTietSuDungRepository.ChiTietSuDungByMaSim(info);
        }

        //public bool ThemHDTT(List<HoaDonThanhToan> listHDTT)
        //{
        //    return chiTietSuDungRepository.ThemHDTT(info);
        //}

        #endregion KhachHangServices

        #region HoaDonThanhToanServices

        public List<HoaDonThanhToanGUI> DanhSachHDTT()
        {
            return thanhToanRepository.DanhSachHDTT();
        }

        public List<HoaDonThanhToanGUI> DanhSachHDTTHH()
        {
            return thanhToanRepository.DanhSachHDTTHH();
        }

        public List<HoaDonThanhToan> DanhSachHDTC()
        {
            return thanhToanRepository.DanhSachHDTC();
        }

        public List<HoaDonThanhToan> TimKiemHDTT(string col, string info)
        {
            return thanhToanRepository.TimKiemHDTT(col, info);
        }

        public List<HoaDonThanhToan> TimKiemByMaKHHDTT(string info)
        {
            return thanhToanRepository.TimKiemByMaKHHDTT(info);
        }

        public bool ThemHDTT(HoaDonThanhToan thanhToan)
        {
            return thanhToanRepository.ThemHDTT(thanhToan);
        }

        public bool UpdateHDTT(HoaDonThanhToan thanhToan)
        {
            return thanhToanRepository.UpdateHDTT(thanhToan);
        }

        #endregion HoaDonThanhToanServices


        #region SimServices

        public List<Sim> DanhSachSim()
        {
            return simRepository.DanhSachSim();
        }
        public List<Sim> TimKiemMaSimMax()
        {
            return simRepository.TimKiemMaSimMax();
        }

        public List<Sim> TimKiemSim(string col, string info)
        {
            return simRepository.TimKiemSim(col, info);
        }

        public List<Sim> TimKiemSimSo(string info)
        {
            return simRepository.TimKiemSimSo(info);
        }

        public bool ThemSim(Sim sim)
        {
            return simRepository.ThemSim(sim);
        }

        public bool UpdateSim(Sim sim)
        {
            return simRepository.UpdateSim(sim);
        }

        public bool UpdateKHSim(Sim sim)
        {
            return simRepository.UpdateKHSim(sim);
        }

        #endregion SimServices

        #region LoaiCuocServices

        public List<LoaiCuoc> DanhSachLoaiCuoc()
        {
            return loaiCuocRepository.DanhSachLoaiCuoc();
        }

        public List<LoaiCuoc> TimKiemLoaiCuoc(string col, string info)
        {
            return loaiCuocRepository.TimKiemLoaiCuoc(col, info);
        }

        public bool ThemLoaiCuoc(LoaiCuoc loaiCuoc)
        {
            return loaiCuocRepository.ThemLoaiCuoc(loaiCuoc);
        }

        public bool UpdateLoaiCuoc(LoaiCuoc loaiCuoc)
        {
            return loaiCuocRepository.UpdateLoaiCuoc(loaiCuoc);
        }

        #endregion LoaiCuocServices

        #region HoaDonDKServices

        public List<HoaDonDK> DanhSachHoaDonDK()
        {
            return hoaDonDangKyRepository.DanhSachHoaDonDK();
        }
        public List<HoaDonDK> GetHoaDonDK(KhachHang kh)
        {
            return hoaDonDangKyRepository.GetHoaDonDK(kh);
        }

        public List<HoaDonDK> TimKiemHoaDonDK(string col, string info)
        {
            return hoaDonDangKyRepository.TimKiemHoaDonDK(col, info);
        }
        public List<HoaDonDK> TimKiemHoaDonDKById(int info)
        {
            return hoaDonDangKyRepository.TimKiemHoaDonDKById(info);
        }

        public bool ThemHoaDonDK(HoaDonDK hoaDonDK)
        {
            return hoaDonDangKyRepository.ThemHoaDonDK(hoaDonDK);
        }

        public bool UpdateHoaDonDK(HoaDonDK hoaDonDK)
        {
            return hoaDonDangKyRepository.UpdateHoaDonDK(hoaDonDK);
        }

        #endregion HoaDonDKServices

    }
}