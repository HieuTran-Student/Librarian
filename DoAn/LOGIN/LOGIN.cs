using System;
using System.Drawing;
using System.Windows.Forms;
using BUS;
using BUS.Librarian_BUS;

namespace DoAn
{
    public partial class frmLOGIN : Form
    {
        NhanVien_BUS nv_BUS = new NhanVien_BUS();
        public static string NameofUser = string.Empty;
        public static int PhanQuyen;
        public static string MaNV = string.Empty;
        public static string TaiKhoan = string.Empty;
        //bool isLogin = false;
        
        public frmLOGIN()
        {
            InitializeComponent();
            txtLOGIN_Password.UseSystemPasswordChar = true; // hide password
            this.AcceptButton = btnLOGIN_Login;
        }

        #region Button Login

        private void btnLOGIN_Login_Click(object sender, EventArgs e)
        {
            if (nv_BUS.ktra_DangNhap(txtLOGIN_UseName.Text, txtLOGIN_Password.Text, ref NameofUser, ref PhanQuyen, ref MaNV, ref TaiKhoan))
            {
                MessageBox.Show(" Login Successfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                if (PhanQuyen == 1)
                {
                    frmMANAGER frmManager = new frmMANAGER();
                    frmManager.Show();
                }
                if (PhanQuyen == 0) 
                {
                    frmLIBRARIAN frmLibrarian = new frmLIBRARIAN();
                    frmLibrarian.Show();
                }   
            }
            else
            {
                MessageBox.Show("Login Failed", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Show - Hide password
        private void btnLOGIN_ShowPassword_Click(object sender, EventArgs e)
        { 
            bool isShowPassword = !txtLOGIN_Password.UseSystemPasswordChar  ? true : false;
            txtLOGIN_Password.UseSystemPasswordChar = isShowPassword;
            txtLOGIN_Password.ForeColor = Color.White;
        }
        #endregion

        #region Button Exit
        private void btnLogin_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
