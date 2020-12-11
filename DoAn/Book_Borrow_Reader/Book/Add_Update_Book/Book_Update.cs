using DoAn.Book_Borrow_Reader.Book.Add_Update_Book;
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
using BUS.Book_BUS;
using DoAn.Success_Failed;
using BUS;

namespace DoAn.MANAGER.Book.New_Update_Item
{
    public partial class frmBook_Update : Form
    {

        public frmBook_Update()
        {
            InitializeComponent();
            this.AcceptButton = btnBookUpdate_Update;
        }

      

        private void btnBookUpdate_NewCategory_Click(object sender, EventArgs e)
        {
            frmBook_Category frmBook_Category = new frmBook_Category();
            frmBook_Category.ShowDialog();
        }

        private void btnBookUpdate_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public string TrimDouble(string temp)
        {
            int strvalue = temp.IndexOf('.');
            temp = temp.Substring(strvalue, temp.Length - 1);
            return temp;
        }

        private void btnBookUpdate_Update_Click(object sender, EventArgs e)
        {

            Sach_DTO sach_DTO = new Sach_DTO
            {
                MaSach = lblBookUpdate_ID.Text,
                TenSach = txtBookUpdate_TitleOfBook.Text,
                MaDauSach = lblBookUpdate_TitleID.Text,
                TenTacGia = txtBookUpdate_Author.Text,
                TenNhaXuatBan = txtBookUpdate_Publisher.Text,
                SoLuong = int.Parse(numBookUpdate_NumberOfBooks.Value.ToString()),
                NamXuatBan = int.Parse(txtBookUpdate_PublicDate.Text),
                DonGia = decimal.Parse(txtBookUpdate_Prices.Text),
                TrangThai = true
            };

            DauSach_DTO dauSach_DTO = new DauSach_DTO
            {
                MaDauSach = lblBookUpdate_TitleID.Text,
                TenDauSach = txtBookUpdate_TitleOfBook.Text,
                MaTheLoai = comBookUpdate_Category.SelectedValue.ToString(),
                TrangThai = true
            };
            
            DauSach_BUS dauSach_BUS = new DauSach_BUS();
            if (dauSach_BUS.SuaDauSach(dauSach_DTO) == true)
            {
                Sach_BUS sach_BUS = new Sach_BUS();
                if (sach_BUS.SuaSach(sach_DTO) == true)
                {
                    CTNhapSach_BUS cTNhapSach_BUS = new CTNhapSach_BUS();

                    CTNhapSach_DTO cTNhapSach_DTO = cTNhapSach_BUS.TimCTNhapSachTheoMaSach(lblBookUpdate_ID.Text);

                    cTNhapSach_DTO.SoLuong = int.Parse(numBookUpdate_NumberOfBooks.Value.ToString());
                    cTNhapSach_DTO.DonGia = double.Parse(txtBookUpdate_Prices.Text);

                    if (cTNhapSach_BUS.SuaCTNhapSach(cTNhapSach_DTO) == true)
                    {
                        NhapSach_BUS nhapSach_BUS = new NhapSach_BUS();
                        NhapSach_DTO nhapSach_DTO = nhapSach_BUS.TimNhapSachTheoMaNhap(cTNhapSach_DTO.MaNhap);

                        nhapSach_DTO.ThanhTien = double.Parse(txtBookUpdate_Prices.Text) *
                            int.Parse(numBookUpdate_NumberOfBooks.Value.ToString());

                        if (nhapSach_BUS.SuaNhapSach(nhapSach_DTO) == true)
                        {
                            frmSuccess frm_Success = new frmSuccess(2);
                            frm_Success.ShowDialog();
                            this.Hide();
                        }
                    }
                }
            }
            else
            {
                frmFailed frm_Failed = new frmFailed(2);
                frm_Failed.Show();
            }
        }

        private void frmBook_Update_Load(object sender, EventArgs e)
        {
            string Ma_Sach = DoAn.MANAGER.Book.frmBook.strMaSach;
            Sach_BUS sach_BUS = new Sach_BUS();
            Sach_DTO sach_DTO = sach_BUS.TimSachTheoMaSach(Ma_Sach);

            txtBookUpdate_TitleOfBook.Text = sach_DTO.TenSach;
            txtBookUpdate_Publisher.Text = sach_DTO.TenNhaXuatBan;
            txtBookUpdate_Author.Text = sach_DTO.TenTacGia;
            txtBookUpdate_PublicDate.Text = sach_DTO.NamXuatBan.ToString();
            lblBookUpdate_ID.Text = sach_DTO.MaSach;
            txtBookUpdate_Prices.Text = sach_DTO.DonGia.ToString();

            TheLoai_BUS theLoai_BUS = new TheLoai_BUS();

            comBookUpdate_Category.DataSource = theLoai_BUS.LayDSTheLoai();
            comBookUpdate_Category.DisplayMember = "TenTheLoai";
            comBookUpdate_Category.ValueMember = "MaTheLoai";
        }
    }
}
