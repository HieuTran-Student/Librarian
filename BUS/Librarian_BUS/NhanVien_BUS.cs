using System;
using System.Security.Cryptography;
using DTO;
using DAO;
using DAO.Librarian_DAO;
using System.Collections.Generic;

namespace BUS.Librarian_BUS
{
    public class NhanVien_BUS
    {
        NhanVien_DAO nv_DAO = new NhanVien_DAO();

        #region Lấy DS nhân viên, Mã hóa, Kiểm tra đăng nhập.

        public List<NhanVien_DTO> LayDanhSachNhanVien()
        {
            List<NhanVien_DTO> dsNhanVien = new List<NhanVien_DTO>();
            return dsNhanVien = nv_DAO.LayDSNhanVien();
        }

        public string GetMD5(string MatKhau)
        {
            string str = string.Empty;
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(MatKhau);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);

            foreach (Byte b in buffer)
            {
                str += b.ToString("x2");
            }

            return str;
        }

        public bool ktra_DangNhap(string username, string pwd, ref string NameofUser, ref int PhanQuyen, ref string MaNV, ref string TaiKhoan)
        {
            List<NhanVien_DTO> dsNhanVien = new List<NhanVien_DTO>();
            dsNhanVien = nv_DAO.LayDSNhanVien();

            foreach (NhanVien_DTO i in dsNhanVien)
            {
                if ((i.TaiKhoan == username) && (i.MatKhau == GetMD5(pwd)))
                {
                    NameofUser = i.HoTenNV;
                    PhanQuyen = i.Quyen;
                    MaNV = i.MaNV;
                    TaiKhoan = i.TaiKhoan;
                    return true;
                }

            }
            return false;
        }
        #endregion


        #region Tìm NV theo mã, Phát sinh mã NV, Tìm NV

        public NhanVien_DTO TimNhanVienTheoMaNV(string MaNV)
        {
            return nv_DAO.TimNVTheoMANV(MaNV);
        }

        public List<NhanVien_DTO> TimNhanVien(string TieuChi)
        {
            return nv_DAO.TimNhanVien(TieuChi);
        }
      
        public string PhatSinhMaNhanVien()
        {
            int so = nv_DAO.DemSoNhanVien(); // 6
            string Ma = "NV";
            int idem = 0;

            foreach (char x in so.ToString())  // co 1 ki tu
            {
                idem++;    // idem = 1
            }

            for (int i = 0; i < 8 - idem; i++)  // 7 so 0
            {
                Ma += "0";
            }

            Ma += so.ToString();  // 6

            return Ma;
        }
        #endregion

        #region Thêm, Xóa, Sửa
        public bool ThemNhanVien(NhanVien_DTO nv_DTO)
        {
            return nv_DAO.ThemNhanVien(nv_DTO);
        }

        public bool XoaNhanVien(string MaNV)
        {
            return nv_DAO.XoaNhanVien(MaNV);
        }

        public bool SuaNhanVien(NhanVien_DTO nv_DTO)
        {
            return nv_DAO.SuaNhanVien(nv_DTO);
        }
        #endregion

    }
}
