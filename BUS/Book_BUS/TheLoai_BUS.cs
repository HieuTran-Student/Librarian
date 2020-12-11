using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Book_DAO;
using DTO;
namespace BUS.Book_BUS
{
    public class TheLoai_BUS
    {
        TheLoai_DAO theLoai_DAO = new TheLoai_DAO();
        public List<TheLoai_DTO> LayDSTheLoai()
        {
            return theLoai_DAO.LayDSTheLoai();
        }
        public bool ThemTheLoai(TheLoai_DTO theLoai_DTO)
        {
            return theLoai_DAO.ThemTheLoai(theLoai_DTO);
        }

        public string PhatSinhMaTheLoai()
        {
            int so = theLoai_DAO.DemSoLuongTheLoai();
            string Ma = "TL";
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
    }
}
