using System;
using System.Collections.Generic;
using System.Windows.Forms;

using BUS.Book_BUS;
using BUS.Borrow_BUS;
using DoAn.Success_Failed;
using DTO;
using DTO.Borrow_DTO;

namespace DoAn.Book_Borrow_Reader.Borrow.Add_Update_borrow
{
    public partial class frmBorow_Bill : Form
    {
        public frmBorow_Bill()
        {
            InitializeComponent();
        }

        private void Bill_btnOK_Click(object sender, EventArgs e)
        {
            MuonSach_DTO muonsach_DTO = new MuonSach_DTO
            {
                MaMuon = txtBorrowUpdate_ID.Text,
                SoThe = txtBorrowUpdate_TagNumber.Text,
                MaNV = txtBorrowUpdate_LibrarianID.Text,
                NgayMuon = dtpBorrowUpdate_BorrowDate.Value,
                NgayPhaiTra = dtpBorrowUpdate_PayDate.Value,
                TrangThai = true,
            };

            //ct muon sach

            List<CTMuonSach_DTO> lstCTMuon = new List<CTMuonSach_DTO>();
            List<DanhSachMuon_DTO> lstDSMuon = new List<DanhSachMuon_DTO>();

            foreach (ListViewItem item in lsvBill.Items)
            {
                CTMuonSach_DTO CTMuon = new CTMuonSach_DTO
                {
                    MaMuon = txtBorrowUpdate_ID.Text,
                    MaSach = item.Text,
                    SoLuong = int.Parse(item.SubItems[2].Text),
                    TrangThai = true,
                    GiaSach = 0
                };

                DanhSachMuon_DTO DSMuon = new DanhSachMuon_DTO
                {
                    MaSach = item.Text,
                    TenSach = item.SubItems[1].Text,
                    SoLuong = int.Parse(item.SubItems[2].Text)
                };
                lstCTMuon.Add(CTMuon);
                lstDSMuon.Add(DSMuon);

            }

            MuonSach_BUS muonSach_BUS = new MuonSach_BUS();
            CTMuonSach_BUS cTMuonSach_BUS = new CTMuonSach_BUS();
            Sach_BUS sach_BUS = new Sach_BUS();

            if (muonSach_BUS.MuonSach(muonsach_DTO))
            {
                if (cTMuonSach_BUS.ThemCTMuonSach(lstCTMuon) && sach_BUS.UpdateSL(lstDSMuon))
                {
                    frmSuccess frmSuccess = new frmSuccess(4);
                    frmSuccess.ShowDialog();
                    this.Hide();
                    DoAn.MANAGER.Borrow.Add_Update_borrow.frmBorrow_Borrow.dsMuon.Clear();
                }
                else
                {
                    frmFailed frmFailed = new frmFailed(4);
                    frmFailed.ShowDialog();
                }
            }
            else
            {
                frmFailed frmFailed = new frmFailed(4);
                frmFailed.ShowDialog();
            }
        }

        private void frmBorow_Bill_Load(object sender, EventArgs e)
        {
            MuonSach_BUS muonsach_BUS = new MuonSach_BUS();
            txtBorrowUpdate_ID.Text = muonsach_BUS.PhatSinhMa();
            txtBorrowUpdate_LibrarianID.Text = frmLOGIN.MaNV;


            foreach (DanhSachMuon_DTO ds in DoAn.MANAGER.Borrow.Add_Update_borrow.frmBorrow_Borrow.dsMuon)
            {
                ListViewItem lsvItem = new ListViewItem();

                lsvItem.Text = ds.MaSach;
                lsvItem.SubItems.Add(ds.TenSach);
                lsvItem.SubItems.Add(ds.SoLuong.ToString());

                lsvBill.Items.Add(lsvItem);
            }
        }

        private void Bill_btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
