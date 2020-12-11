using System;

namespace DTO
{
    public class CTTraSach_DTO
    {
        public string MaTra { get; set; }
        public string MaSach { get; set; }
        public DateTime NgayTra { get; set; }
        public int SoLuong { get; set; }
        public decimal TienThue { get; set; }
        public decimal TienPhat { get; set; }
        public bool TrangThai { get; set; }

    }
}
