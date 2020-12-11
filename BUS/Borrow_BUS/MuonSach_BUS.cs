using DAO.Borrow_DAO;
using DTO;

namespace BUS.Borrow_BUS
{
    public class MuonSach_BUS
    {
        public string PhatSinhMa()
        {
            MuonSach_DAO muonSach_DAO = new MuonSach_DAO();

            int so = muonSach_DAO.DemSo();
            string Ma = "MS";
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

        public bool MuonSach(MuonSach_DTO ms_DTO)
        {
            MuonSach_DAO muonSach_DAO = new MuonSach_DAO();
            return muonSach_DAO.ThemMuonSach(ms_DTO);
        }
    }
}
