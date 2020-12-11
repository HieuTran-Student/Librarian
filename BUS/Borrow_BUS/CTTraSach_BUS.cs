using DAO.Borrow_DAO;
using DTO;

namespace BUS.Borrow_BUS
{
    public class CTTraSach_BUS
    {
        CTTraSach_DAO ctts_DAO = new CTTraSach_DAO();
        public bool ThemCTTS(CTTraSach_DTO ctts)
        {
            return ctts_DAO.ThemCTTS(ctts);
        }
    }
}
