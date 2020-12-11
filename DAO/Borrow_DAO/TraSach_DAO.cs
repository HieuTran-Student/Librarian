using System;
using System.Linq;
using DTO;

namespace DAO.Borrow_DAO
{
    public class TraSach_DAO
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();
        public int Dem()
        {
            return data.TraSaches.Count() + 1;
        }
        public bool ThemTraSach(TraSach_DTO ts_DTO)
        {
            try
            {
                TraSach ts = new TraSach
                {

                    MaTra = ts_DTO.MaTra,
                    NgayLap = ts_DTO.NgayLap,
                    MaMuon = ts_DTO.MaMuon,
                    TrangThai = true,


                };
                data.TraSaches.Add(ts);

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
