using DoAn.MANAGER.Book;
using DoAn.MANAGER.Borrow;
using DoAn.MANAGER.Statistics;
using DoAn.MANAGER_Buttons;
using System;
using System.Windows.Forms;
using DTO;
using BUS;
using BUS.Librarian_BUS;

namespace DoAn
{
    public partial class frmMANAGER : Form
    {
        public frmMANAGER()
        {
            InitializeComponent();

        }

        #region FormLoad Event
        // Load Event
        private void frmMANAGER_Load(object sender, EventArgs e)
        {
            timer_Watch.Start();
            btnMANAGER_Librarian.PerformClick();
            NhanVien_DTO nhanVien_DTO = new NhanVien_DTO();
            NhanVien_BUS nhanVien_BUS = new NhanVien_BUS();
            nhanVien_DTO = nhanVien_BUS.TimNhanVienTheoMaNV(DoAn.frmLOGIN.MaNV);
            lblMANAGER_UserName.Text = nhanVien_DTO.HoTenNV;
        }
        
        // Watch Event
        private void timer_Watch_Tick(object sender, EventArgs e)
        {
            lblWatch_Time.Text = DateTime.Now.ToString("HH:mm");
            lblWatch_Second.Text = DateTime.Now.ToString("ss");
            lblWatch_Date.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblWatch_Day.Text = DateTime.Now.ToString("dddd");
        }
        #endregion

        #region Button Logout, Exit
        //Logout
        private void btnMANAGER_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wan to log out ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmLOGIN frmLogin = new frmLOGIN();
                frmLogin.Show();
            }
        }

        //Exit
        private void btnMANAGER_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wan to exit ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Button Librarian, Account, Book Management, Borrow - Return, Report

        private void btnMANAGER_Librarian_Click(object sender, EventArgs e)
        {
            frmLibrarian frm_Librarian = new frmLibrarian();
            frm_Librarian.MdiParent = this;
            frm_Librarian.Show();
        }
       
        private void btnMANAGER_Book_Click(object sender, EventArgs e)
        {
            frmBook frm_Book = new frmBook();
            frm_Book.MdiParent = this;
            frm_Book.Show();
        }

        private void btnMANAGER_Reader_Click(object sender, EventArgs e)
        {
            frmReader frm_Reader = new frmReader();
            frm_Reader.MdiParent = this;
            frm_Reader.Show();
        }

        private void btnMANAGER_Borrow_Click(object sender, EventArgs e)
        {
            frmBorrow frm_Borrow = new frmBorrow();
            frm_Borrow.MdiParent = this;
            frm_Borrow.Show();
        }

        private void btnMANAGER_Statistical_Click(object sender, EventArgs e)
        {
            frmReport frm_Statistics = new frmReport();
            frm_Statistics.MdiParent = this;
            frm_Statistics.Show();
        }
        #endregion

        
    }
}
