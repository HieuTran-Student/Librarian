using System.Collections.Generic;
using System.Linq;
using DTO;
using System;

namespace DAO.Reader_DAO
{
    public class DocGia_DAO
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();
       

        #region Thêm, Xóa, Sửa Đọc Giả

        public bool ThemDocGia(DocGia_DTO dg_DTO)
        {
            try
            {
                DocGia dg = new DocGia();
                dg.MaDocGia = dg_DTO.MaDocGia;
                dg.TenDocGia = dg_DTO.TenDocGia;
                dg.CMND = dg_DTO.CMND;
                dg.DiaChi = dg_DTO.DiaChi;
                dg.SoThe = dg_DTO.SoThe;
                dg.TrangThai = true;

                data.DocGias.Add(dg);

                data.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool XoaDocGia(string MaDocGia)
        {
            try
            {
                DocGia dg = data.DocGias.SingleOrDefault(u => u.MaDocGia == MaDocGia && u.TrangThai == true);

                dg.TrangThai = false;

                data.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpDateDocGia(DocGia_DTO dg_DTO)
        {
            try
            {
                DocGia dg = data.DocGias.SingleOrDefault(u => u.MaDocGia == dg_DTO.MaDocGia);

                dg.MaDocGia = dg_DTO.MaDocGia;
                dg.TenDocGia = dg_DTO.TenDocGia;
                dg.CMND = dg_DTO.CMND;
                dg.SoThe = dg_DTO.SoThe;
                dg.DiaChi = dg_DTO.DiaChi;
                dg.TrangThai = true;

                data.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region Lấy DS Đọc Giả, Tìm Theo Mã Đọc Giả, Tìm Đọc Giả, Đếm Số Lượng Đọc giả 
        public List<DocGia_DTO> LayDSDocGia()
        {
            List<DocGia_DTO> result = new List<DocGia_DTO>();
            result = data.DocGias.Where(u => u.TrangThai.Value == true).Select(u => new DocGia_DTO
            {
                MaDocGia = u.MaDocGia,
                TenDocGia = u.TenDocGia,
                CMND = u.CMND,
                DiaChi = u.DiaChi,
                SoThe = u.SoThe,

            }).ToList();

            return result;
        }

        public DocGia_DTO TimDocGiaTheoMaDocGia(string MaDocGia)
        {
            DocGia_DTO dg_DTO = new DocGia_DTO();
            //tim 1 nhan vien theo ma nhan vien 
            DocGia dg = data.DocGias.SingleOrDefault(u => u.MaDocGia == MaDocGia && u.TrangThai.Value == true);

            // đỗ dữ liệu từ nhân viên trong database sang nhân viên dto de chuyen di
            dg_DTO.MaDocGia = dg.MaDocGia;
            dg_DTO.TenDocGia = dg.TenDocGia;
            dg_DTO.CMND = dg.CMND;
            dg_DTO.DiaChi = dg.DiaChi;
            dg_DTO.SoThe = dg.SoThe;
            dg_DTO.TrangThai = dg.TrangThai.Value;

            return dg_DTO;
        }

        public List<DocGia_DTO> TimDocGia(string TieuChi)
        {
            List<DocGia_DTO> result = new List<DocGia_DTO>();

            result = data.DocGias.Where(
                u => (  u.MaDocGia.Contains(TieuChi) || 
                        u.TenDocGia.Contains(TieuChi) || 
                        u.CMND.Contains(TieuChi) || 
                        u.DiaChi.Contains(TieuChi) || 
                        u.SoThe.Contains(TieuChi)) && 
                        u.TrangThai == true ).Select(u => new DocGia_DTO
                        {
                            MaDocGia = u.MaDocGia,
                            TenDocGia = u.TenDocGia,
                            CMND = u.CMND,
                            DiaChi = u.DiaChi,
                            SoThe = u.SoThe
                        } ).ToList();

            return result;
        }

        public int DemDocGia()
        {
            return data.DocGias.Count() + 1;
        }
        #endregion
    }
}
