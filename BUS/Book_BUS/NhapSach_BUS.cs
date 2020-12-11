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
    public class NhapSach_BUS
    {
        NhapSach_DAO nhapSach_DAO = new NhapSach_DAO();

        public bool ThemNhapSach(NhapSach_DTO nhapSach_DTO)
        {
            return nhapSach_DAO.ThemNhapSach(nhapSach_DTO);
        }

        public bool XoaNhapSach(string strMaNhap)
        {
            return nhapSach_DAO.XoaNhapSach(strMaNhap);
        }

        public bool SuaNhapSach(NhapSach_DTO nhapSach_DTO)
        {
            return nhapSach_DAO.SuaNhapSach(nhapSach_DTO);
        }

        public string PhatSinhMaNhapSach()
        {
            int so = nhapSach_DAO.DemSoLuongNhapSach();
            string Ma = "MN";
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

        public NhapSach_DTO TimNhapSachTheoMaNhap(string MaNhap)
        {
            return nhapSach_DAO.TimNhapSachTheoMaNhap(MaNhap);
        }


    }
}
