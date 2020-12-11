using System.Linq;
using DTO;
using System;

namespace DAO.Reader_DAO
{
    public class TheThuVien_DAO
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();

        public bool ThemTheThuVien(TheThuVien_DTO ttv_DTO)
        {
            try
            {
                TheThuVien ttv = new TheThuVien
                {
                    SoThe = ttv_DTO.SoThe,
                    NgayBatDau = ttv_DTO.NgayBatDau,
                    TrangThai = true
                };

                data.TheThuViens.Add(ttv);
                data.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int DemTheThuVien()
        {
            return data.TheThuViens.Count() + 1;
        }
    }
}
