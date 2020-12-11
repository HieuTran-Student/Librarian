using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using DAO.Book_DAO;

namespace BUS
{
    public class CTNhapSach_BUS
    {
        CTNhapSach_DAO cTNhapSach_DAO = new CTNhapSach_DAO();

        public bool ThemCTNhapSach (CTNhapSach_DTO cTNhapSach_DTO)
        {
            return cTNhapSach_DAO.ThemCTNhapSach(cTNhapSach_DTO);
        }

        public bool XoaCTNhapSach(string strMaCTNhapSach)
        {
            return cTNhapSach_DAO.XoaCTNhapSach(strMaCTNhapSach);
        }

        public bool SuaCTNhapSach(CTNhapSach_DTO cTNhapSachDTO)
        {
            return cTNhapSach_DAO.SuaCTNhapSach(cTNhapSachDTO);
        }

        public CTNhapSach_DTO TimCTNhapSachTheoMaSach(string MaSach)
        {
            return cTNhapSach_DAO.TimCTNhapSachTheoMaSach(MaSach);
        }
    }
}
