using System;
using System.Windows.Forms;
using BUS;
using BUS.Librarian_BUS;
using DoAn.MANAGER_Buttons;
using DTO;

namespace DoAn.MANAGER.Librarian.Add_Update_Librarian
{
    public partial class frmLibrarian_Update : Form
    {
        public frmLibrarian_Update()
        {
            InitializeComponent();
            this.AcceptButton = btnLibrarianUpdate_Update;
        }

        private void btnLibrarianUpdate_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        NhanVien_BUS nvBUS = new NhanVien_BUS();

        private void frmLibrarian_Update_Load(object sender, EventArgs e)
        {
            string Ma_NVien = DoAn.MANAGER_Buttons.frmLibrarian.MaNVien;

            NhanVien_DTO nvDTO = nvBUS.TimNhanVienTheoMaNV(Ma_NVien);

            txtLibrarianUpdate_Phone.Text = nvDTO.SDT;
            txtLibrarianUpdate_Name.Text = nvDTO.HoTenNV;
            txtLibrarianUpdate_UserName.Text = nvDTO.TaiKhoan;
            dtpLibrarianUpdate_DayOfBirth.Value = nvDTO.NgSinh;
        }

        private void btnLibrarianUpdate_Update_Click(object sender, EventArgs e)
        {
            NhanVien_DTO nv_DTO = new NhanVien_DTO
            {
                MaNV = DoAn.MANAGER_Buttons.frmLibrarian.MaNVien,
                HoTenNV = txtLibrarianUpdate_Name.Text,
                NgSinh = dtpLibrarianUpdate_DayOfBirth.Value,
                SDT = txtLibrarianUpdate_Phone.Text,
                TaiKhoan = txtLibrarianUpdate_UserName.Text,
                Quyen = 0,
            };

            if (nvBUS.SuaNhanVien(nv_DTO))
            {
                MessageBox.Show("Update Successfully", "Nocie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
                MessageBox.Show("Update Failed", "Nocie", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
