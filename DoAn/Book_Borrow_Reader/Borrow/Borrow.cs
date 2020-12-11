using DoAn.MANAGER.Borrow.Add_Update_borrow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.MANAGER.Borrow
{
    public partial class frmBorrow : Form
    {
        public frmBorrow()
        {
            InitializeComponent();
        }

        private void btnBorrow_Cancel_Click(object sender, EventArgs e)
        {
          //  frmBorrow
        }

        private void btnBorrow_Add_Click(object sender, EventArgs e)
        {
            frmBorrow_Borrow frmAdd = new frmBorrow_Borrow();
            frmAdd.Show();
        }

        private void btnBorrow_Update_Click(object sender, EventArgs e)
        {
            frmBorrow_Return frmUpdate = new frmBorrow_Return();
            frmUpdate.Show();
        }
    }
}
