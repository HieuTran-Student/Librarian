using System.Collections.Generic;
using DAO;
using DTO;

namespace BUS.Borrow_BUS
{
    public class CTMuonSach_BUS
    {
        CTMuonSach_DAO ctms_DAO = new CTMuonSach_DAO();

        public bool ThemCTMuonSach(List<CTMuonSach_DTO> ctmsDTO)
        {
            return ctms_DAO.ThemCTMuonSach(ctmsDTO);
        }
        public List<CTMuonSach_DTO> LayCTMuonSach()
        {
            return ctms_DAO.LayDSCTMuonSach();
        }

        public bool UpDateTraSach(string MaMuon, string MaSach)
        {
            return ctms_DAO.UpDateTraSach(MaMuon, MaSach);
        }
    }
}
