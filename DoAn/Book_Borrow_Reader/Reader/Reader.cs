using DoAn.MANAGER.Reader.Add_Update_Reader;
using System;
using System.Windows.Forms;
using BUS.Reader_BUS;
using DoAn.Success_Failed;

namespace DoAn.MANAGER_Buttons
{
    public partial class frmReader : Form
    {
        public frmReader()
        {
            InitializeComponent();
            this.AcceptButton = btnReader_Search;
            this.AcceptButton = btnReader_Add;
            this.AcceptButton = btnReader_Update;
            this.AcceptButton = btnReader_Remove;
        }

        private void frmReader_Load(object sender, EventArgs e)
        {
            DocGia_BUS docGia_BUS = new DocGia_BUS();
            dtgReader.AutoGenerateColumns = false;
            dtgReader.DataSource = docGia_BUS.LayDSDocGia();
        }

        public static string MaDG = string.Empty;
        DocGia_BUS docGia_BUS = new DocGia_BUS();

        #region Add, Update Buttons
        private void btnReader_Add_Click(object sender, EventArgs e)
        {
            frmReader_Add frmReaderAdd = new frmReader_Add();
            frmReaderAdd.ShowDialog();
            frmReader_Load(sender, e);
        }

        private void btnReader_Update_Click(object sender, EventArgs e)
        {
            if (MaDG != "")
            {
                frmReader_Update frmReaderUpdate = new frmReader_Update();
                frmReaderUpdate.ShowDialog();
                frmReader_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please Select A Reader", "Notices",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReader_Remove_Click(object sender, EventArgs e)
        {
            if (dtgReader.SelectedRows.Count >0)
            {
                DialogResult result = MessageBox.Show("Do you want to remove this reader", "Confirm",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.Yes == result)
                {
                    if (docGia_BUS.XoaDocGia(MaDG))
                    {
                        frmSuccess frm_Success = new frmSuccess(3);
                        frm_Success.ShowDialog();
                    }
                    else
                    {
                        frmFailed frm_Failed = new frmFailed(3);
                        frm_Failed.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("You haven't selected a reader !", "Warning !", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }                

            frmReader_Load(sender, e);
        }
        #endregion

        private void dtgReader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            else
            {
                MaDG = dtgReader.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void btnReader_Search_Click(object sender, EventArgs e)
        {
            if (txtReader_Search.Text != "")
            {
                dtgReader.AutoGenerateColumns = false;
                dtgReader.DataSource = docGia_BUS.TimDocGia(txtReader_Search.Text);
            }
            else
            {
                frmReader_Load(sender, e);
            }
        }
    }
}
