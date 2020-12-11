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
    public partial class frmSuccess : Form
    {
        public frmSuccess(int Choose)
        {
            InitializeComponent();
            #region Changes message
            switch (Choose)
            {
                case 1:
                    lblSuccess_Message.Text = "Add Successfully !";
                    break;
                case 2:
                    lblSuccess_Message.Text = "Update Successfully !";
                    break;
                case 3:
                    lblSuccess_Message.Text = "Remove Successfully !";
                    break;
                case 4:
                    lblSuccess_Message.Text = "Borrow Successfully !";
                    break;
                case 5:
                    lblSuccess_Message.Text = "Return Successfully !";
                    break;
                default:
                    break;
            }
            #endregion
        }

        private void btnSuccess_OK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
