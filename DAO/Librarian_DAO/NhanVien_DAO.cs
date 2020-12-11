using System;
using System.Collections.Generic;
using System.Linq;
using DTO;


namespace DAO.Librarian_DAO
{
    public class NhanVien_DAO
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();
        

        public List<NhanVien_DTO> LayDSNhanVien()
        {
            List<NhanVien_DTO> result = new List<NhanVien_DTO>();
            result = data.NhanViens.Where(u => u.TrangThai.Value == true).Select(u => new NhanVien_DTO
            {
                MaNV = u.MaNV,
                HoTenNV = u.HoTenNV,
                NgSinh = u.NgSinh.Value,
                SDT = u.SDT,
                TaiKhoan = u.TaiKhoan,
                MatKhau = u.MatKhau,
                Quyen = (int)u.Quyen,
            }).ToList();

            return result;
        }

        public NhanVien_DTO TimNVTheoMANV(string MaNV)
        {
            NhanVien_DTO nv_DTO = new NhanVien_DTO();
            //tim 1 nhan vien theo ma nhan vien 
            NhanVien nv = data.NhanViens.SingleOrDefault(u => u.MaNV == MaNV && u.TrangThai.Value == true);

            // đỗ dữ liệu từ nhân viên trong database sang nhân viên dto de chuyen di
            nv_DTO.MaNV = MaNV;
            nv_DTO.HoTenNV = nv.HoTenNV;
            nv_DTO.NgSinh = nv.NgSinh.Value;
            nv_DTO.SDT = nv.SDT;
            nv_DTO.TaiKhoan = nv.TaiKhoan;
            nv_DTO.Quyen = nv.Quyen.Value;
            nv_DTO.MatKhau = nv.MatKhau;
            nv_DTO.TrangThai = nv.TrangThai.Value;

            return nv_DTO;
        }

        public bool SuaNhanVien(NhanVien_DTO nv_DTO)
        {
            try
            {
                NhanVien nv = data.NhanViens.SingleOrDefault(u => u.MaNV == nv_DTO.MaNV);

                nv.MaNV = nv_DTO.MaNV;
                nv.HoTenNV = nv_DTO.HoTenNV;
                nv.NgSinh = nv_DTO.NgSinh;
                nv.SDT = nv_DTO.SDT;
                nv.TaiKhoan = nv_DTO.TaiKhoan;
                nv.Quyen = nv_DTO.Quyen;

                data.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ThemNhanVien(NhanVien_DTO nv_DTO)
        {
            try
            {
                NhanVien nv = new NhanVien();

                nv.MaNV = nv_DTO.MaNV;
                nv.HoTenNV = nv_DTO.HoTenNV;
                nv.NgSinh = nv_DTO.NgSinh;
                nv.SDT = nv_DTO.SDT;
                nv.TaiKhoan = nv_DTO.TaiKhoan;
                nv.Quyen = nv_DTO.Quyen;
                nv.MatKhau = nv_DTO.MatKhau;
                nv.TrangThai = true;

                data.NhanViens.Add(nv);

                data.SaveChanges(); 
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int DemSoNhanVien()
        {
            return data.NhanViens.Count() + 1;
        }

        public bool XoaNhanVien(string MaNV)
        {

            try
            {
                NhanVien nv = data.NhanViens.SingleOrDefault(u => u.MaNV == MaNV && u.TrangThai == true);

                nv.TrangThai = false;

                data.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<NhanVien_DTO> TimNhanVien(string TieuChi)
        {
            List<NhanVien_DTO> result = new List<NhanVien_DTO>();
            result = data.NhanViens.Where(
                u => (u.MaNV.Contains(TieuChi) || u.HoTenNV.Contains(TieuChi)
                    || u.SDT.Contains(TieuChi) || u.TaiKhoan.Contains(TieuChi)
                    ) && u.TrangThai == true

                ).Select(u => new NhanVien_DTO
                {
                    MaNV = u.MaNV,
                    HoTenNV = u.HoTenNV,
                    SDT = u.SDT,
                    TaiKhoan = u.TaiKhoan,
                    NgSinh = u.NgSinh.Value,
                    MatKhau = u.MatKhau,
                    Quyen = 0,

                }).ToList();
            return result;
        }

    }

}
