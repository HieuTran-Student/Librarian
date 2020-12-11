using DoAn.MANAGER.Book;
using DTO;
using System;
using System.Windows.Forms;
using BUS.Book_BUS;

namespace DoAn.Book_Borrow_Reader.Book.Add_Update_Book
{
    public partial class frmBook_Category : Form
    {
        TheLoai_BUS theLoai_BUS = new TheLoai_BUS();

        public frmBook_Category()
        {
            InitializeComponent();
        }

        private void btnBook_CategoryCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBook_Add book_Add = new frmBook_Add();
            book_Add.Show();
        }
 
        private void btnBook_NewCategory_Click(object sender, EventArgs e)
        {
            if (txtBook_CategoryName.Text.Length > 0)
            {
                TheLoai_DTO theLoai_DTO = new TheLoai_DTO();
                theLoai_DTO.MaTheLoai = lblBook_CategoryID.Text;
                theLoai_DTO.TenTheLoai = txtBook_CategoryName.Text;
                theLoai_DTO.TrangThai = true;

                if (theLoai_BUS.ThemTheLoai(theLoai_DTO) == true)
                {
                    MessageBox.Show("Add Successfully", "Nocie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
                else
                    MessageBox.Show("Add Failed", "Nocie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBook_Category_Load(object sender, EventArgs e)
        {
            lblBook_CategoryID.Text = theLoai_BUS.PhatSinhMaTheLoai();
        }
    }
}
