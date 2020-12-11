using System;
using System.Linq;
using DTO;

namespace DAO.Borrow_DAO
{
    public class MuonSach_DAO
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();

        public int DemSo()
        {
            return data.MuonSaches.Count() + 1;
        }

        public bool ThemMuonSach(MuonSach_DTO muonSach_DTO)
        {
            try
            {
                MuonSach muonSach = new MuonSach
                {
                    MaMuon = muonSach_DTO.MaMuon,
                    SoThe = muonSach_DTO.SoThe,
                    MaNV = muonSach_DTO.MaNV,
                    NgayMuon = muonSach_DTO.NgayMuon,
                    NgayPhaiTra = muonSach_DTO.NgayPhaiTra,
                    TrangThai = true,
                };

                data.MuonSaches.Add(muonSach);
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
