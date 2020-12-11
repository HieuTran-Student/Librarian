using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAO
{
    public class CTMuonSach_DAO
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();
        public bool ThemCTMuonSach(List<CTMuonSach_DTO> dsctmuon)
        {
            try
            {
                foreach (CTMuonSach_DTO ctms_DTO in dsctmuon)
                {
                    CTMuonSach ct_ms = new CTMuonSach
                    {
                        MaMuon = ctms_DTO.MaMuon,
                        MaSach = ctms_DTO.MaSach,
                        SoLuong = ctms_DTO.SoLuong,
                        TrangThai = true,
                        GiaSach = 0
                    };

                    data.CTMuonSaches.Add(ct_ms);
                    data.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // lay danh sach ctmuonsach
        public List<CTMuonSach_DTO> LayDSCTMuonSach()
        {
            List<CTMuonSach_DTO> result = new List<CTMuonSach_DTO>();
            result = data.CTMuonSaches.Where(u => u.TrangThai.Value == true).Select(u => new CTMuonSach_DTO
            {
                MaMuon = u.MaMuon,
                MaSach = u.MaSach,
                SoLuong = u.SoLuong.Value,
                TrangThai = u.TrangThai.Value,
                GiaSach = u.GiaSach.Value


            }).ToList();
            return result;
        }

        public bool UpDateTraSach(string MaMuon, string MaSach)
        {
            try
            {
                CTMuonSach ctms = data.CTMuonSaches.SingleOrDefault(u => u.MaMuon == MaMuon && u.MaSach == MaSach && u.TrangThai == true);
                ctms.TrangThai = false;

                data.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
