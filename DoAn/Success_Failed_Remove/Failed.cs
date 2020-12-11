using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.Success_Failed
{
    public partial class frmFailed : Form
    {
        public frmFailed(int Choose)
        {
            InitializeComponent();
            #region changes message
            switch (Choose)
            {
                case 1:
                    lblFailed_Message.Text = "Add Failed !";
                    break;
                case 2:
                    lblFailed_Message.Text = "Update Failed !";
                    break;
                case 3:
                    lblFailed_Message.Text = "Remove Failed !";
                    break;
                case 4:
                    lblFailed_Message.Text = "Borrow Failed !";
                    break;
                case 5:
                    lblFailed_Message.Text = "Return Failed !";
                    break;
                default:
                    break;
            }
            #endregion 
        }

        private void btnFailed_OK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
