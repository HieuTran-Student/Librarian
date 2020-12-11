using System.Collections.Generic;
using DAO.Reader_DAO;
using DTO;

namespace BUS.Reader_BUS
{
    public class DocGia_BUS
    {
        DocGia_DAO dg_DAO = new DocGia_DAO();

        #region Lấy DS Đọc Giả, Tìm Mã Đọc Giả Theo Mã Đọc Giả, Tìm Đọc Giả, Phát Sinh Mã

        public List<DocGia_DTO> LayDSDocGia()
        {
            return dg_DAO.LayDSDocGia();
        }

        public DocGia_DTO TimMaDGTheoMDG(string MaDocGia)
        {
            return dg_DAO.TimDocGiaTheoMaDocGia(MaDocGia);
        }

        public string PhatSinhMa()
        {
            int so = dg_DAO.DemDocGia(); // 6
            string Ma = "DG";
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

        public List<DocGia_DTO> TimDocGia(string TieuChi)
        {
            return dg_DAO.TimDocGia(TieuChi);
        }
        #endregion

        #region Thêm, Xóa, Sửa

        public bool ThemDocGia(DocGia_DTO dg_DTO)
        {
            return dg_DAO.ThemDocGia(dg_DTO);
        }

        public bool XoaDocGia(string MaDocGia)
        {
            return dg_DAO.XoaDocGia(MaDocGia);
        }

        public bool UpDateDoGia(DocGia_DTO dg_DTO)
        {
            return dg_DAO.UpDateDocGia(dg_DTO);
        }
        #endregion

    }
}
