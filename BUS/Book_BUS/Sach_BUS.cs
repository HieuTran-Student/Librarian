using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO.Book_DAO;
using DTO.Borrow_DTO;

namespace BUS.Book_BUS
{
    public class Sach_BUS
    {
        Sach_DAO sach_DAO = new Sach_DAO();

        #region Lấy DS Sách, Phát sinh mã sách, Tìm Sách Theo Mã Sách
        public List<Sach_DTO> LayDanhSachSach()
        {
            List<Sach_DTO> dsNhanVien = new List<Sach_DTO>();
            return dsNhanVien = sach_DAO.LayDSSach();
        }

        public bool UpdateSL(List<DanhSachMuon_DTO> dsmuon)
        {
            return sach_DAO.UpdateSL(dsmuon);
        }

        public bool UpLoadSLTra(string MaSach, int SoLuong)
        {
            return sach_DAO.UpdateSLTra(MaSach, SoLuong);
        }

        public List<Sach_DTO> LayDanhSachSachDuocMuon()
        {
            List<Sach_DTO> dsNhanVien = new List<Sach_DTO>();
            return dsNhanVien = sach_DAO.LayDSSachDuocMuon();
        }

        public List<Sach_DTO> TimSach(string TieuChi)
        {
            return sach_DAO.TimSach(TieuChi);
        }

        public string PhatSinhMaSach()
        {
            int so = sach_DAO.DemSoLuongSach();
            string Ma = "Sa";
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

        public Sach_DTO TimSachTheoMaSach(string MaSach)
        {
            return sach_DAO.TimSachTheoMaSach(MaSach);
        }
        #endregion

        #region Thêm, Xóa, Sửa sách

        public bool ThemSachMotDongSach(Sach_DTO sachDTO)
        {
            return sach_DAO.ThemSachMotDongSach(sachDTO);
        }

        public bool XoaSach(string masach)
        {
            return sach_DAO.XoaSach(masach);
        }

        public bool SuaSach(Sach_DTO sachDTO)
        {
            return sach_DAO.SuaSach(sachDTO);
        }
        #endregion
    }
}
