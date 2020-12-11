using System;

using System.Windows.Forms;
using DTO;
using BUS;
using BUS.Librarian_BUS;
using System.Globalization;
using DoAn.Success_Failed;

namespace DoAn.MANAGER.Librarian.Add_Update_Librarian
{
    public partial class frmLibrarian_Add : Form
    {
        public frmLibrarian_Add()
        {
            InitializeComponent();
            DateTime.Now.ToString("dd/MM/YYYY");
            this.AcceptButton = btnLibrarianAdd_Add;
        }

        #region Cancel Button
        private void btnBookAdd_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        NhanVien_BUS nv_BUS = new NhanVien_BUS();

        private void frmLibrarian_Add_Load(object sender, EventArgs e)
        {
            lblLibrarian_ID.Text = nv_BUS.PhatSinhMaNhanVien();
        }

        private void btnLibrarianAdd_Add_Click(object sender, EventArgs e)
        {
            NhanVien_DTO nv_DTO = new NhanVien_DTO();
            nv_DTO.MaNV = lblLibrarian_ID.Text;
            nv_DTO.HoTenNV = txtLibrarianAdd_Name.Text;
            nv_DTO.NgSinh = dtpLibrarianAdd_DayOfBirth.Value.Date;
            nv_DTO.SDT = txtLibrarianAdd_Phone.Text;
            nv_DTO.TaiKhoan = txtLibrarianAdd_UserName.Text;
            nv_DTO.Quyen = 0;
            nv_DTO.MatKhau = nv_BUS.GetMD5(txtLibrarianAdd_Password.Text);
            nv_DTO.TrangThai = true;

            if (nv_BUS.ThemNhanVien(nv_DTO))
            {
                frmSuccess frmSuccess = new frmSuccess(1);
                frmSuccess.ShowDialog();
                this.Close();
            }
            else
            {
                frmFailed frmFailed = new frmFailed(1);
                frmFailed.ShowDialog();
            }
        }
    }
}
