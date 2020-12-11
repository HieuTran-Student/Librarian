using DAO.Borrow_DAO;
using DTO;

namespace BUS.Borrow_BUS
{
    public class TraSach_BUS
    {
        TraSach_DAO traSach_DAO = new TraSach_DAO();
        public string PhatSinhMaTraSach()
        {
            int so = traSach_DAO.Dem(); // 6
            string Ma = "MT";
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

        public bool ThemTraSach(TraSach_DTO ts_DTO)
        {
            return traSach_DAO.ThemTraSach(ts_DTO);
        }
    }
}
