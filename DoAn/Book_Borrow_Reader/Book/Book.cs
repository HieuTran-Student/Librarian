using DoAn.MANAGER.Book.New_Update_Item;
using System;
using System.Windows.Forms;
using BUS.Book_BUS;
using DoAn.Success_Failed;

namespace DoAn.MANAGER.Book
{
    public partial class frmBook : Form
    {
        public static string Ma_Sach = string.Empty;
        public frmBook()
        {
            InitializeComponent();
        }

        private void btnBook_Add_Click(object sender, EventArgs e)
        {

            if (strMaSach != "")
            {
                frmBook_Add frmBookAdd = new frmBook_Add();
                frmBookAdd.ShowDialog();
                frmBook_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please Select A Book", "Notices",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBook_Update_Click(object sender, EventArgs e)
        {
            if (strMaSach != "")
            {
                frmBook_Update frmBookUpdate = new frmBook_Update();
                frmBookUpdate.ShowDialog();
                frmBook_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please Select A Book", "Notices",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            Sach_BUS sachBUS= new Sach_BUS();
            dtgBook.AutoGenerateColumns = false;
            dtgBook.DataSource = sachBUS.LayDanhSachSach();
        }

        Sach_BUS sach_BUS = new Sach_BUS();

        public static string strMaSach = string.Empty;

        private void dtgBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            else
            {
                strMaSach = dtgBook.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void btnBook_Remove_Click(object sender, EventArgs e)
        {
            if (dtgBook.SelectedRows.Count > 0 )
            {
                if (dtgBook.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Do you want to remove this reader", "Confirm",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (sach_BUS.XoaSach(strMaSach))
                        {
                            frmSuccess frm_Success = new frmSuccess(3);
                            frm_Success.ShowDialog();
                        }
                        else
                        {
                            frmFailed frm_failed = new frmFailed(2);
                            frm_failed.ShowDialog();
                        }
                        frmBook_Load(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("You haven't selected a reader !", "Warning !",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBook_Search_Click(object sender, EventArgs e)
        {
            if (txtBook_Search.Text != "")
            {
                dtgBook.AutoGenerateColumns = false;
                dtgBook.DataSource = sach_BUS.TimSach(txtBook_Search.Text);
            }
            else
            {
                frmBook_Load(sender, e);
            }
        }
    }
}
