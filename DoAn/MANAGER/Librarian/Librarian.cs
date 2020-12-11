using DoAn.MANAGER.Librarian.Add_Update_Librarian;
using System;
using System.Windows.Forms;
using BUS;
using BUS.Librarian_BUS;
using DoAn.Success_Failed;

namespace DoAn.MANAGER_Buttons
{
    public partial class frmLibrarian : Form
    {
        public frmLibrarian()
        {
            InitializeComponent();
        }

        #region Add, Update Buttons
        private void btnLibrarian_Add_Click(object sender, EventArgs e)
        {
            frmLibrarian_Add frmLibrarianAdd = new frmLibrarian_Add();
            frmLibrarianAdd.ShowDialog();
            frmLibrarian_Load(sender, e);
        }

        private void btnLibrarian_Update_Click(object sender, EventArgs e)
        { 
            if (MaNVien != "")
            {
                frmLibrarian_Update frmLibrarianUpdate = new frmLibrarian_Update();
                frmLibrarianUpdate.ShowDialog();
                frmLibrarian_Load(sender, e);
            }
            else
                MessageBox.Show("Please Select A Librarian", "Nocie", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        NhanVien_BUS nv_BUS = new NhanVien_BUS();

        private void frmLibrarian_Load(object sender, EventArgs e)
        {
            NhanVien_BUS nv = new NhanVien_BUS();
            dtgLibrarian.AutoGenerateColumns = false;
            dtgLibrarian.DataSource = nv.LayDanhSachNhanVien();
        }

        public static string MaNVien = string.Empty;

        private void dtgLibrarian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            else
            {
                MaNVien = dtgLibrarian.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void btnLibrarian_Remove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to remove this Librarian ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (nv_BUS.XoaNhanVien(MaNVien))
                {
                    frmSuccess frmSuccess = new frmSuccess(3);
                    frmSuccess.ShowDialog();
                }
                else
                {
                    frmFailed frmFailed = new frmFailed(3);
                    frmFailed.ShowDialog();
                }
                frmLibrarian_Load(sender, e);
            }
        }
                
        private void btnLibrarian_Search_Click(object sender, EventArgs e)
        {
            if (txtLibrarian_Search.Text != "")
            {
                dtgLibrarian.AutoGenerateColumns = false;
                dtgLibrarian.DataSource = nv_BUS.TimNhanVien(txtLibrarian_Search.Text);
            }
            else
            {
                frmLibrarian_Load(sender, e);
            }
        }
    }
}
