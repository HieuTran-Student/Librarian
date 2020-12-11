using DTO;
using System;
using System.Linq;

namespace DAO.Book_DAO
{
    public class CTNhapSach_DAO
    {

        QuanLyThuVienEntities data = new QuanLyThuVienEntities();

        public bool ThemCTNhapSach(CTNhapSach_DTO CTNhapSach_DTO)
        {
            try
            {                
                CTNhapSach cTNhapSach = new CTNhapSach();
                cTNhapSach.MaNhap = CTNhapSach_DTO.MaNhap;
                cTNhapSach.MaSach = CTNhapSach_DTO.MaSach;
                cTNhapSach.SoLuong = CTNhapSach_DTO.SoLuong;
                cTNhapSach.DonGia = (int)CTNhapSach_DTO.DonGia;
                cTNhapSach.TrangThai = true;

                data.CTNhapSaches.Add(cTNhapSach);
                data.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool XoaCTNhapSach(string strMaCTNhapSach)
        {
            try
            {
                CTNhapSach cTNhapSach = data.CTNhapSaches.SingleOrDefault(
                    u => u.MaNhap == strMaCTNhapSach && u.TrangThai == true);

                cTNhapSach.TrangThai = false;
                data.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaCTNhapSach(CTNhapSach_DTO cTNhapSach_DTO)
        {
            try
            {
                CTNhapSach cTNhapsach = data.CTNhapSaches.SingleOrDefault(
                    u => u.MaNhap == cTNhapSach_DTO.MaNhap);

                cTNhapsach.MaNhap = cTNhapSach_DTO.MaNhap;
                cTNhapsach.MaSach = cTNhapSach_DTO.MaSach;
                cTNhapsach.SoLuong = cTNhapSach_DTO.SoLuong;
                cTNhapsach.DonGia = (int)cTNhapSach_DTO.DonGia;

                data.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public CTNhapSach_DTO TimCTNhapSachTheoMaSach(string MaSach)
        {
            CTNhapSach_DTO cTNhapSach_DTO = new CTNhapSach_DTO();
            //tim 1 nhan vien theo ma nhan vien 
            CTNhapSach cTNhapSach = data.CTNhapSaches.SingleOrDefault(u => u.MaSach == MaSach && u.TrangThai.Value == true);

            // đỗ dữ liệu từ nhân viên trong database sang nhân viên dto de chuyen di
            cTNhapSach_DTO.MaNhap = cTNhapSach.MaNhap;
            cTNhapSach_DTO.MaSach = MaSach;
            cTNhapSach_DTO.SoLuong = int.Parse(cTNhapSach.SoLuong.ToString());
            cTNhapSach_DTO.DonGia = double.Parse(cTNhapSach.DonGia.ToString());
            cTNhapSach_DTO.TrangThai = true;
            return cTNhapSach_DTO;
        }
    }
}
