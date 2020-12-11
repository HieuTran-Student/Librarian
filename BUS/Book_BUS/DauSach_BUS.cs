using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using DAO.Book_DAO;

namespace BUS.Book_BUS
{
    public class DauSach_BUS
    {
        DauSach_DAO dauSach_DAO = new DauSach_DAO();

        #region Phát sinh mã đầu sách

        public string PhatSinhMaDauSach()
        {
            int so = dauSach_DAO.DemSoLuongDauSach();
            string Ma = "DS";
            int dem = 0;

            foreach (char x in so.ToString())
            {
                dem++;
            }

            for (int i = 0; i < 8 - dem; i++)
            {
                Ma += "0";
            }

            Ma += so.ToString();

            return Ma;
        }
        #endregion

        #region Thêm, Xóa, Sửa Đầu Sách
        public bool ThemDauSach(DauSach_DTO dauSach_DTO)
        {
            return dauSach_DAO.ThemDauSach(dauSach_DTO);
        }

        public bool XoaDauSach(string maDauSach)
        {
            return dauSach_DAO.XoaDauSach(maDauSach);
        }

        public bool SuaDauSach(DauSach_DTO dauSach_DTO)
        {
            return dauSach_DAO.SuaDauSach(dauSach_DTO);
        }
        #endregion
    }
}
