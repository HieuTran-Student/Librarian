using System;
using DTO;

namespace DAO.Borrow_DAO
{
    public class CTTraSach_DAO
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();
        public bool ThemCTTS(CTTraSach_DTO ctts_DTO)
        {
            try
            {
                CTTraSach ctts = new CTTraSach
                {
                    MaTra = ctts_DTO.MaTra,
                    MaSach = ctts_DTO.MaSach,
                    NgayTra = ctts_DTO.NgayTra,
                    SoLuong = ctts_DTO.SoLuong,
                    TienThue = 0,
                    TrangThai = true
                };

                data.CTTraSaches.Add(ctts);
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
