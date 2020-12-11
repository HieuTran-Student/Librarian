using System;
using System.Collections.Generic;
using System.Linq;
using DTO;

namespace DAO.Book_DAO
{
    public class TheLoai_DAO
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();
        
        public List<TheLoai_DTO> LayDSTheLoai()
        {
            List<TheLoai_DTO> listTheLoai = new List<TheLoai_DTO>();
            listTheLoai = data.TheLoais.Where(u => u.TrangThai == true).Select(u => new TheLoai_DTO
            {
                MaTheLoai = u.MaTheLoai,
                TenTheLoai = u.TenTheLoai,
                TrangThai = u.TrangThai.Value
            }).ToList();

            return listTheLoai;
        }

        public bool ThemTheLoai(TheLoai_DTO theLoai_DTO)
        {
            try
            {
                TheLoai theLoai = new TheLoai();

                theLoai.MaTheLoai = theLoai_DTO.MaTheLoai;
                theLoai.TenTheLoai = theLoai_DTO.TenTheLoai;
                theLoai.TrangThai = true;

                data.TheLoais.Add(theLoai);
                data.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int DemSoLuongTheLoai()
        {
            return data.TheLoais.Count() + 1;
        }

    }
}
