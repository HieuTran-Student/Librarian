using DAO;
using DAO.Reader_DAO;
using DTO;

namespace BUS.Reader_BUS
{
    public class TheThuVien_BUS
    {
        TheThuVien_DAO ttv_DAO = new TheThuVien_DAO();

        public string PhatSinhMa()
        {
            int so = ttv_DAO.DemTheThuVien(); // 6
            string Ma = "Th";
            int idem = 0;

            foreach (char x in so.ToString())  // co 1 ki tu
            {
                idem++;    // idem = 1
            }

            for (int i = 0; i < 8 - idem; i++)  // 7 so 0
            {
                Ma += "0";
            }

            Ma += so.ToString();  // 6

            return Ma;
        }

        public bool ThemTheThuVien(TheThuVien_DTO ttv_DTO)
        {
            return ttv_DAO.ThemTheThuVien(ttv_DTO);
        }
    }
}
