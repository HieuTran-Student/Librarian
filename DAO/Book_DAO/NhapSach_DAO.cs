using System;
using System.Linq;
using DTO;

namespace DAO.Book_DAO
{
    public class NhapSach_DAO
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();

        public bool ThemNhapSach(NhapSach_DTO nhapSach_DTO)
        {
            try
            {
                NhapSach nhapSach = new NhapSach();
                nhapSach.MaNhap = nhapSach_DTO.MaNhap;
                nhapSach.MaNV = nhapSach_DTO.MaNV;
                nhapSach.NgayNhap = nhapSach_DTO.NgayNhap;
                nhapSach.ThanhTien = (decimal)nhapSach_DTO.ThanhTien;
                nhapSach.TrangThai = true;

                data.NhapSaches.Add(nhapSach);
                data.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool XoaNhapSach(string strMaNhapSach)
        {
            try
            {
                NhapSach nhapSach = data.NhapSaches.SingleOrDefault(
                    u => u.MaNhap == strMaNhapSach && u.TrangThai == true);

                nhapSach.TrangThai = false;
                data.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaNhapSach(NhapSach_DTO nhapSach_DTO)
        {
            try
            {
                NhapSach nhapSach = data.NhapSaches.SingleOrDefault(u => u.MaNhap == nhapSach_DTO.MaNhap);

                nhapSach.MaNhap = nhapSach_DTO.MaNhap;
                nhapSach.MaNV = nhapSach_DTO.MaNV;
                nhapSach.NgayNhap = nhapSach_DTO.NgayNhap;
                nhapSach.ThanhTien = decimal.Parse(nhapSach_DTO.ThanhTien.ToString());

                data.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int DemSoLuongNhapSach()
        {
            return data.NhapSaches.Count() + 1;
        }

        public NhapSach_DTO TimNhapSachTheoMaNhap(string MaNhap)
        {
            NhapSach_DTO nhapSach_DTO = new NhapSach_DTO();
            //tim 1 nhan vien theo ma nhan vien 
            NhapSach nhapSach = data.NhapSaches.SingleOrDefault(
                u => u.MaNhap == MaNhap && u.TrangThai.Value == true);

            // đỗ dữ liệu từ nhân viên trong database sang nhân viên dto de chuyen di
            nhapSach_DTO.MaNhap = nhapSach.MaNhap;
            nhapSach_DTO.MaNV = nhapSach.MaNV;
            nhapSach_DTO.NgayNhap = (DateTime)nhapSach.NgayNhap;
            nhapSach_DTO.ThanhTien = double.Parse(nhapSach.ThanhTien.ToString());

            return nhapSach_DTO;
        }
    }
}
