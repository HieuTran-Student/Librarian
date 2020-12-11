using System;
using System.Windows.Forms;
using BUS;
using BUS.Book_BUS;
using DoAn.Book_Borrow_Reader.Book.Add_Update_Book;
using DoAn.Success_Failed;
using DTO;

namespace DoAn.MANAGER.Book
{
    public partial class frmBook_Add : Form
    {
        Sach_BUS sach_BUS = new Sach_BUS();
        DauSach_BUS dauSach_BUS = new DauSach_BUS();
        NhapSach_BUS nhapSach_BUS = new NhapSach_BUS();
        CTNhapSach_BUS cTNhapSach_BUS = new CTNhapSach_BUS();

        public frmBook_Add()
        {
            InitializeComponent();
            this.AcceptButton = btnBookAdd_Add;
        }

        private void frmBook_Add_Load(object sender, EventArgs e)
        {
            lblBook_ID.Text = sach_BUS.PhatSinhMaSach();
            lblBook_SeriesOfBook.Text = dauSach_BUS.PhatSinhMaDauSach();

            TheLoai_BUS theLoai_BUS = new TheLoai_BUS();

            comBook_Category.DataSource = theLoai_BUS.LayDSTheLoai();
            comBook_Category.DisplayMember = "TenTheLoai";
            comBook_Category.ValueMember = "MaTheLoai";
        }

        private void btnBookAdd_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBook_NewCategory_Click(object sender, EventArgs e)
        {
            frmBook_Category frmCategory = new frmBook_Category();
            frmCategory.ShowDialog();
        }

        private void btnBookAdd_Add_Click(object sender, EventArgs e)
        {
            Sach_DTO sachDTO = new Sach_DTO();
            sachDTO.MaSach = lblBook_ID.Text;
            sachDTO.TenSach = txtBookAdd_TitleOfBook.Text;
            sachDTO.MaDauSach = lblBook_SeriesOfBook.Text;
            sachDTO.TenTacGia = txtBookAdd_Author.Text;
            sachDTO.TenNhaXuatBan = txtBookAdd_Publisher.Text;
            sachDTO.SoLuong = int.Parse(numBookAdd_NumberOfBooks.Value.ToString());
            sachDTO.NamXuatBan = int.Parse(txtBookAdd_PublicDate.Text);
            sachDTO.DonGia = decimal.Parse(txtBookAdd_Prices.Text);
            sachDTO.TrangThai = true;

            DauSach_DTO dauSachDTO = new DauSach_DTO();
            dauSachDTO.MaDauSach = lblBook_SeriesOfBook.Text;
            dauSachDTO.TenDauSach = txtBookAdd_TitleOfBook.Text;
            dauSachDTO.MaTheLoai = comBook_Category.SelectedValue.ToString();
            dauSachDTO.TrangThai = true;

            CTNhapSach_DTO cTNhapSach_DTO = new CTNhapSach_DTO();
            cTNhapSach_DTO.MaNhap = nhapSach_BUS.PhatSinhMaNhapSach();
            cTNhapSach_DTO.MaSach = lblBook_ID.Text;
            cTNhapSach_DTO.SoLuong = int.Parse(numBookAdd_NumberOfBooks.Value.ToString());
            cTNhapSach_DTO.DonGia = double.Parse(txtBookAdd_Prices.Text);
            cTNhapSach_DTO.TrangThai = true;

            NhapSach_DTO nhapSach_DTO = new NhapSach_DTO();
            nhapSach_DTO.MaNhap = nhapSach_BUS.PhatSinhMaNhapSach();
            nhapSach_DTO.MaNV = DoAn.frmLOGIN.MaNV;
            nhapSach_DTO.NgayNhap = DateTime.Now;
            nhapSach_DTO.ThanhTien = int.Parse(numBookAdd_NumberOfBooks.Value.ToString()) *
                                        double.Parse(txtBookAdd_Prices.Text);
            nhapSach_DTO.TrangThai = true;

            if (dauSach_BUS.ThemDauSach(dauSachDTO) == true)
            {
                if (sach_BUS.ThemSachMotDongSach(sachDTO) == true)
                {
                    if (nhapSach_BUS.ThemNhapSach(nhapSach_DTO) == true)
                    {
                        if (cTNhapSach_BUS.ThemCTNhapSach(cTNhapSach_DTO) == true)
                        {
                            frmSuccess frmSuccess = new frmSuccess(1);
                            frmSuccess.ShowDialog();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    frmFailed frmFailed = new frmFailed(1);
                    frmFailed.ShowDialog();
                }
            }
        }

        private void txtBookAdd_PublicDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtBookAdd_Prices_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
