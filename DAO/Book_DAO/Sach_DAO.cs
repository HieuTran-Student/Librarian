using System;
using System.Collections.Generic;
using System.Linq;
using DTO;
using DTO.Borrow_DTO;

namespace DAO.Book_DAO
{
    public class Sach_DAO
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();

        #region Lấy DS Sách, Lấy DS Được Mượn, Tìm Sách, Đếm Số Lượng

        public List<Sach_DTO> LayDSSach()
        {
            List<Sach_DTO> result = new List<Sach_DTO>();

            result = data.Saches.Where(u => u.TrangThai == true).Select(u => new Sach_DTO
            {
                MaSach = u.MaSach,
                TenSach = u.TenSach,
                MaDauSach = u.MaDauSach,
                TenTacGia = u.TenTacGia,
                TenNhaXuatBan = u.TenNhaXuatBan,
                SoLuong = u.SoLuong.Value,
                NamXuatBan = u.NamXuatBan.Value,
                DonGia = (decimal)u.DonGia
            }).ToList();

            return result;
        }

        public bool UpdateSL(List<DanhSachMuon_DTO> sachMuon)
        {
            foreach (DanhSachMuon_DTO sachMuon_DTO in sachMuon)
            {
                Sach s = data.Saches.SingleOrDefault(u => u.MaSach == sachMuon_DTO.MaSach && u.TrangThai.Value == true);
                s.SoLuong -= sachMuon_DTO.SoLuong;
            }
            data.SaveChanges();
            return true;
        }

        public bool UpdateSLTra(string MaSach, int SoLuong)
        {

            Sach s = data.Saches.SingleOrDefault(u => u.MaSach == MaSach && u.TrangThai.Value == true);
            s.SoLuong += SoLuong;

            data.SaveChanges();
            return true;
        }

        public List<Sach_DTO> LayDSSachDuocMuon()
        {
            List<Sach_DTO> result = new List<Sach_DTO>();

            result = data.Saches.Where(u => u.TrangThai == true && u.SoLuong.Value >= 1).Select(u => new Sach_DTO
            {
                MaSach = u.MaSach,
                TenSach = u.TenSach,
                MaDauSach = u.MaDauSach,
                TenTacGia = u.TenTacGia,
                TenNhaXuatBan = u.TenNhaXuatBan,
                NamXuatBan = u.NamXuatBan.Value,
                SoLuong = u.SoLuong.Value,
                DonGia = (decimal)u.DonGia

            }).ToList();

            return result;
        }

        public Sach_DTO TimSachTheoMaSach(string MaSach)
        {
            Sach_DTO sach_DTO = new Sach_DTO();
            //tim 1 nhan vien theo ma nhan vien 
            Sach sach = data.Saches.SingleOrDefault(u => u.MaSach == MaSach && u.TrangThai.Value == true);

            // đỗ dữ liệu từ nhân viên trong database sang nhân viên dto de chuyen di
            sach_DTO.MaSach = MaSach;
            sach_DTO.TenSach = sach.TenSach;
            sach_DTO.MaDauSach = sach.MaDauSach;
            sach_DTO.TenTacGia = sach.TenTacGia;
            sach_DTO.TenNhaXuatBan = sach.TenNhaXuatBan;
            sach_DTO.SoLuong = int.Parse(sach.SoLuong.ToString());
            sach_DTO.NamXuatBan = int.Parse(sach.NamXuatBan.ToString());
            sach_DTO.DonGia = decimal.Parse(sach.DonGia.ToString());

            return sach_DTO;
        }

        public List<Sach_DTO> TimSach(string TieuChi)
        {
            List<Sach_DTO> result = new List<Sach_DTO>();
            result = data.Saches.Where(u => (
                      u.MaSach.Contains(TieuChi) ||
                      u.TenSach.Contains(TieuChi) ||
                      u.MaDauSach.Contains(TieuChi) ||
                      u.TenTacGia.Contains(TieuChi) ||
                      u.TenNhaXuatBan.Contains(TieuChi) ||
                     (u.SoLuong.ToString()).Contains(TieuChi) ||
                     (u.NamXuatBan.ToString()).Contains(TieuChi) ||
                     (u.DonGia.ToString()).Contains(TieuChi)
                    ) && u.TrangThai == true
                ).Select(u => new Sach_DTO
                {
                    MaSach = u.MaSach,
                    TenSach = u.TenSach,
                    MaDauSach = u.MaDauSach,
                    TenTacGia = u.TenTacGia,
                    TenNhaXuatBan = u.TenNhaXuatBan,
                    SoLuong = (int)u.SoLuong,
                    NamXuatBan = (int) u.NamXuatBan,
                    DonGia = (decimal) u.DonGia
                }).ToList();

            return result;
        }

        public int DemSoLuongSach()
        {
            return data.Saches.Count() + 1;
        }


        #endregion

        #region Them, Xoa, Sua SACH

        public bool ThemSachMotDongSach(Sach_DTO sach_DTO)
        {
            try
            {
                Sach sach = new Sach();
                sach.MaSach = sach_DTO.MaSach;
                sach.TenSach = sach_DTO.TenSach;
                sach.MaDauSach = sach_DTO.MaDauSach;
                sach.TenTacGia = sach_DTO.TenTacGia;
                sach.TenNhaXuatBan = sach_DTO.TenNhaXuatBan;
                sach.NamXuatBan = sach_DTO.NamXuatBan;
                sach.SoLuong = sach_DTO.SoLuong;
                sach.DonGia = decimal.Parse(sach_DTO.DonGia.ToString());
                sach.TrangThai = true;

                data.Saches.Add(sach);

                data.SaveChanges(); 
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool XoaSach(string masach)
        {
            try
            {
                Sach sach = data.Saches.SingleOrDefault(u => u.MaSach == masach && u.TrangThai == true);

                sach.TrangThai = false;
                data.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaSach(Sach_DTO sach_DTO)
        {
            try
            {
                Sach sach = data.Saches.SingleOrDefault(u => u.MaSach == sach_DTO.MaSach);

                sach.MaSach = sach_DTO.MaSach;
                sach.TenSach = sach_DTO.TenSach;
                sach.MaDauSach = sach_DTO.MaDauSach;
                sach.TenTacGia = sach_DTO.TenTacGia;
                sach.TenNhaXuatBan = sach_DTO.TenNhaXuatBan;
                sach.NamXuatBan = sach_DTO.NamXuatBan;
                sach.SoLuong = sach_DTO.SoLuong;
                sach.DonGia = decimal.Parse(sach_DTO.DonGia.ToString());

                data.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}
