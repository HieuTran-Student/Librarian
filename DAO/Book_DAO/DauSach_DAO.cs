using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO.Book_DAO
{
    public class DauSach_DAO
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();

        #region Đếm số lượng

        public int DemSoLuongDauSach()
        {
            return data.DauSaches.Count() + 1;
        }
        #endregion

        #region Thêm, Xóa, Sửa Đầu Sách

        public bool ThemDauSach(DauSach_DTO dauSach_DTO)
        {
            try
            {
                DauSach dauSach = new DauSach();
                dauSach.MaDauSach = dauSach_DTO.MaDauSach;
                dauSach.TenDauSach = dauSach_DTO.TenDauSach;
                dauSach.MaTheLoai = dauSach_DTO.MaTheLoai;
                dauSach.TrangThai = true;
                

                data.DauSaches.Add(dauSach);
                data.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool XoaDauSach(string maDauSach)
        {
            try
            {
                DauSach dauSach = data.DauSaches.SingleOrDefault
                    (u => u.MaDauSach == maDauSach  && u.TrangThai == true);
                dauSach.TrangThai = false;
                data.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaDauSach(DauSach_DTO dauSach_DTO)
        {
            try
            {
                DauSach dauSach = data.DauSaches.SingleOrDefault(u => u.MaDauSach == dauSach_DTO.MaDauSach);

                dauSach.MaDauSach = dauSach_DTO.MaDauSach;
                dauSach.TenDauSach = dauSach_DTO.TenDauSach;
                dauSach.MaTheLoai = dauSach_DTO.MaTheLoai;
                dauSach.TrangThai = true;

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
