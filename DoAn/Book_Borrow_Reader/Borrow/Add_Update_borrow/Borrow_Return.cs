using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using BUS.Book_BUS;
using BUS.Borrow_BUS;
using DoAn.Success_Failed;
using DTO;

namespace DoAn.MANAGER.Borrow.Add_Update_borrow
{
    public partial class frmBorrow_Return : Form
    {
        Sach_BUS sach_BUS = new Sach_BUS();
        CTMuonSach_BUS ctms_BUS = new CTMuonSach_BUS();
        TraSach_BUS trasach_BUS = new TraSach_BUS();
        CTTraSach_BUS ctts_BUS = new CTTraSach_BUS();
        public frmBorrow_Return()
        {
            InitializeComponent();
        }

        private void btnBorrowUpdate_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmBorrow_Return_Load(object sender, EventArgs e)
        {
            dtgBorrow_Return.AutoGenerateColumns = false;
            dtgBorrow_Return.DataSource = ctms_BUS.LayCTMuonSach();


            DataGridViewComboBoxColumn col = (DataGridViewComboBoxColumn)MaSach;
            col.DataSource = sach_BUS.LayDanhSachSach();
            col.DisplayMember = "TenSach";
            col.ValueMember = "MaSach";

            txtBorrowReturn_ReturnID.Text = trasach_BUS.PhatSinhMaTraSach();
        }

        private void btnBorrowReturn_Return_Click(object sender, EventArgs e)
        {
            TraSach_DTO ts_DTO = new TraSach_DTO
            {
                MaTra = txtBorrowReturn_ReturnID.Text,
                NgayLap = (DateTime)dtpReturnReturn_DateFound.Value,
                MaMuon = txtBorrowReturn_BorrowID.Text,
                TrangThai = true

            };


            CTTraSach_DTO ctt_DTO = new CTTraSach_DTO
            {
                MaTra = txtBorrowReturn_ReturnID.Text,
                MaSach = dtgBorrow_Return.Rows[dtgBorrow_Return.SelectedRows[0].Index].Cells[2].Value.ToString(),
                NgayTra = DateTime.Now,
                SoLuong = int.Parse(txtBorrowReturn_Quantity.Text),
                TienThue = 0,
                TrangThai = true
            };

            if (trasach_BUS.ThemTraSach(ts_DTO))
            {
                if (ctts_BUS.ThemCTTS(ctt_DTO) && sach_BUS.UpLoadSLTra(ctt_DTO.MaSach, ctt_DTO.SoLuong) && ctms_BUS.UpDateTraSach(ts_DTO.MaMuon, ctt_DTO.MaSach))

                {
                    frmSuccess frmSuccess = new frmSuccess(5);
                    frmSuccess.ShowDialog();
                    this.Hide();
                    frmBorrow_Return_Load(sender, e);
                }
                else
                {
                    frmFailed frmFailed = new frmFailed(5);
                    frmFailed.ShowDialog();
                }

            }
            else
            {
                frmFailed frmFailed = new frmFailed(5);
                frmFailed.ShowDialog();
            }
        }

        private void dtgBorrow_Return_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            else
            {
                txtBorrowReturn_Quantity.Text = dtgBorrow_Return.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtBorrowReturn_BorrowID.Text = dtgBorrow_Return.Rows[e.RowIndex].Cells[0].Value.ToString();

            }
        }
    }
}
