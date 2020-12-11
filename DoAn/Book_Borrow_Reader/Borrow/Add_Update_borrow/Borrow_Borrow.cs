using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DoAn.Book_Borrow_Reader.Borrow.Add_Update_borrow;
using DTO.Borrow_DTO;
using BUS;
using BUS.Book_BUS;
using DTO;

namespace DoAn.MANAGER.Borrow.Add_Update_borrow
{
    public partial class frmBorrow_Borrow : Form
    {
        Sach_BUS sach_BUS = new Sach_BUS();
        public static List<DanhSachMuon_DTO> dsMuon = new List<DanhSachMuon_DTO>();

        public frmBorrow_Borrow()
        {
            InitializeComponent();
            lstBorrowBook_SachMuon.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lstBorrowBook_SachCoTheMuon.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnBorrowkAdd_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BorrowBook_btnBorrowBook_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstBorrowBook_SachMuon.Items)
            {
                DanhSachMuon_DTO  danhSachMuon_DTO = new DanhSachMuon_DTO();

                danhSachMuon_DTO.MaSach = item.Text;
                danhSachMuon_DTO.TenSach = item.SubItems[1].Text;
                danhSachMuon_DTO.SoLuong = int.Parse(item.SubItems[2].Text);

                dsMuon.Add(danhSachMuon_DTO);
            }

            frmBorow_Bill frm_Bill = new frmBorow_Bill();
            frm_Bill.ShowDialog();
            this.Hide();
        }

        private void BorrowBook_btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmBorrow_Borrow_Load(object sender, EventArgs e)
        {
           
            List<Sach_DTO> list = sach_BUS.LayDanhSachSachDuocMuon();

            foreach (Sach_DTO sach_DTO in list)
            {
                ListViewItem lsvItem = new ListViewItem();
                lsvItem.Text = sach_DTO.MaSach;
                lsvItem.SubItems.Add(sach_DTO.TenSach);

                lstBorrowBook_SachCoTheMuon.Items.Add(lsvItem);
            }
        }

        private void BorrowBook_Right_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = lstBorrowBook_SachCoTheMuon.SelectedItems;
            if (selected.Count < 1) return;
            else

            {
                Sach_DTO sach_DTO = new Sach_DTO();
                sach_DTO = sach_BUS.TimSachTheoMaSach(lstBorrowBook_SachCoTheMuon.SelectedItems[0].Text);
                //    BorrowBook_nudSoLuong.Maximum = sach_DTO.SoLuong;

                ListViewItem item = new ListViewItem();
                item.Text = sach_DTO.MaSach;
                item.SubItems.Add(sach_DTO.TenSach);
                item.SubItems.Add(BorrowBook_nudSoLuong.Value.ToString());

                lstBorrowBook_SachMuon.Items.Add(item);

                lstBorrowBook_SachCoTheMuon.Items.Remove(lstBorrowBook_SachCoTheMuon.SelectedItems[0]);
            }
        }

        private void BorrowBook_Left_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = lstBorrowBook_SachMuon.SelectedItems;
            if (selected.Count < 1) return;
            else
            {
                Sach_DTO sach_DTO = new Sach_DTO();
                sach_DTO = sach_BUS.TimSachTheoMaSach(lstBorrowBook_SachMuon.SelectedItems[0].Text);
                //    BorrowBook_nudSoLuong.Maximum = sach_DTO.SoLuong;

                ListViewItem item = new ListViewItem();
                item.Text = sach_DTO.MaSach;
                item.SubItems.Add(sach_DTO.TenSach);

                lstBorrowBook_SachCoTheMuon.Items.Add(item);

                lstBorrowBook_SachMuon.Items.Remove(lstBorrowBook_SachMuon.SelectedItems[0]);
            }
        }
    }
}
