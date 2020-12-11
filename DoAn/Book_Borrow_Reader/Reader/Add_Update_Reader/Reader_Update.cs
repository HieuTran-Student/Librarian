using System;
using System.Windows.Forms;
using DTO;
using BUS;
using BUS.Reader_BUS;
using DoAn.Success_Failed;

namespace DoAn.MANAGER.Reader.Add_Update_Reader
{
    public partial class frmReader_Update : Form
    {
        DocGia_BUS dg_BUS = new DocGia_BUS();
        public frmReader_Update()
        {
            InitializeComponent();
            this.AcceptButton = btnReaderUpdate_Update;
        }

        #region Cancel Button
        private void btnReaderUpdate_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion
        
        private void frmReader_Update_Load(object sender, EventArgs e)
        {
            string Ma_DG = DoAn.MANAGER_Buttons.frmReader.MaDG;
            
            DocGia_DTO dg_DTO = new DocGia_DTO();
            dg_DTO = dg_BUS.TimMaDGTheoMDG(Ma_DG);

            txtReaderUpdate_Name.Text = dg_DTO.TenDocGia;
            txtReaderUpdate_IdentityNumber.Text = dg_DTO.CMND;
            txtReaderUpdate_Address.Text = dg_DTO.DiaChi;
            txtReaderUpdate_TagNumber.Text = dg_DTO.SoThe;

            lblReader_ID.Text = Ma_DG;
            lblReader_CardNumberID.Text = dg_DTO.SoThe;
        }

        private void btnReaderUpdate_Update_Click(object sender, EventArgs e)
        {
            DocGia_DTO dg_DTO = new DocGia_DTO();
            dg_DTO.MaDocGia = DoAn.MANAGER_Buttons.frmReader.MaDG;
            dg_DTO.TenDocGia = txtReaderUpdate_Name.Text;
            dg_DTO.CMND = txtReaderUpdate_IdentityNumber.Text;
            dg_DTO.DiaChi = txtReaderUpdate_Address.Text;
            dg_DTO.SoThe = txtReaderUpdate_TagNumber.Text;

            if (dg_BUS.UpDateDoGia(dg_DTO))
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
    }
}
