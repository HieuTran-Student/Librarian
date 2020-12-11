using DoAn.MANAGER.Book;
using DoAn.MANAGER.Borrow;
using DoAn.MANAGER.Statistics;
using DoAn.MANAGER_Buttons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using BUS.Librarian_BUS;

namespace DoAn
{
    public partial class frmLIBRARIAN : Form
    {
        public frmLIBRARIAN()
        {
            InitializeComponent();
        }

        private void frmLIBRARIAN_Load(object sender, EventArgs e)
        {
            timer_Watch.Start();
            btnLIBRARIAN_Book.PerformClick();
            NhanVien_BUS nhanVien_BUS = new NhanVien_BUS();
            NhanVien_DTO nhanVien_DTO = new NhanVien_DTO();
            nhanVien_DTO = nhanVien_BUS.TimNhanVienTheoMaNV(DoAn.frmLOGIN.MaNV);

            lblLIBRARIAN_UserName.Text = nhanVien_DTO.HoTenNV;
        }

        #region Button Logout, Exit
        private void btnLIBRARIAN_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wan to exit ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnLIBRARIAN_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wan to log out ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmLOGIN frmLogin = new frmLOGIN();
                frmLogin.Show();
            }
        }
        #endregion

        private void timer_Watch_Tick(object sender, EventArgs e)
        {
            lblWatch_Time.Text = DateTime.Now.ToString("HH:mm");
            lblWatch_Second.Text = DateTime.Now.ToString("ss");
            lblWatch_Date.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblWatch_Day.Text = DateTime.Now.ToString("dddd");
        }

        #region Button Librarian, Account, Book Management, Borrow - Return, Report

        private void btnLIBRARIAN_Book_Click(object sender, EventArgs e)
        {
            frmBook frm_Book = new frmBook();
            frm_Book.MdiParent = this;
            frm_Book.Show();
        }

        private void btnLIBRARIAN_Reader_Click(object sender, EventArgs e)
        {
            frmReader frm_Reader = new frmReader();
            frm_Reader.MdiParent = this;
            frm_Reader.Show();
        }

        private void btnLIBRARIAN_Borrow_Click(object sender, EventArgs e)
        {
            frmBorrow frm_Borrow = new frmBorrow();
            frm_Borrow.MdiParent = this;
            frm_Borrow.Show();
        }

        private void btnLIBRARIAN_Report_Click(object sender, EventArgs e)
        {
            frmReport frm_Statistics = new frmReport();
            frm_Statistics.MdiParent = this;
            frm_Statistics.Show();
        }
#endregion
    }
}
