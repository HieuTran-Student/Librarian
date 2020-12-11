using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Windows.Forms;
using BUS;
using DTO;
using BUS.Reader_BUS;
using DoAn.Success_Failed;

namespace DoAn.MANAGER.Reader.Add_Update_Reader
{
    public partial class frmReader_Add : Form
    {
        public frmReader_Add()
        {
            InitializeComponent();
            this.AcceptButton = btnReaderAdd_Add;
        }

        private void frmReader_Add_Load(object sender, EventArgs e)
        {
            lblReader_ID.Text = dg_BUS.PhatSinhMa();
            lblReader_CardNumberID.Text = ttv_BUS.PhatSinhMa();
        }

        #region Cancel Button
        private void btnReaderAdd_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        TheThuVien_BUS ttv_BUS = new TheThuVien_BUS();
        DocGia_BUS dg_BUS = new DocGia_BUS();

        private void btnReaderAdd_Add_Click(object sender, EventArgs e)
        {
            TheThuVien_DTO ttv_DTO = new TheThuVien_DTO
            {
                SoThe = lblReader_CardNumberID.Text,
                NgayBatDau = DateTime.Now,
                TrangThai = true
            };

            DocGia_DTO dg_DTO = new DocGia_DTO
            {
                MaDocGia =lblReader_ID.Text,
                TenDocGia = txtReaderAdd_Name.Text,
                CMND = txtReaderAdd_IdentityNumber.Text,
                SoThe = lblReader_CardNumberID.Text,
                DiaChi = txtReaderAdd_Address.Text,
                TrangThai = true
            };

            if (ttv_BUS.ThemTheThuVien(ttv_DTO))
            {
                if (dg_BUS.ThemDocGia(dg_DTO))
                {
                    frmSuccess frmSuccess = new frmSuccess(1);
                    frmSuccess.ShowDialog();
                    this.Hide();
                }
                else
                {
                    frmFailed frmFailed = new frmFailed(1);
                    frmFailed.ShowDialog();
                }
            }
            else
            {
                frmFailed frmFailed = new frmFailed(1);
                frmFailed.ShowDialog();
            }
        }
    }
}
