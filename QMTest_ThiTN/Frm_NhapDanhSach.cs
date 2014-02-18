using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QMTest_ThiTN.BLL;
using QMTest_ThiTN.DAL;

namespace QMTest_ThiTN
{
    public partial class Frm_NhapDanhSach : XtraForm
    {
        public Frm_NhapDanhSach()
        {
            InitializeComponent();
        }

        private void Frm_NhapDanhSach_Load(object sender, EventArgs e)
        {
            gridControl_DanhSachSV.DataSource = new TaiKhoanBLL().GetList_Account();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            tbl_taikhoansinhvien tk = new tbl_taikhoansinhvien();
            tk.IdSinhVien = txtMaSinhVien.Text.Trim();
            tk.HoTen = txtHovaTen.Text.Trim();
            tk.MatKhau = "123";
            tk.MaQuyen = 1;
            new TaiKhoanBLL().Insert(tk);
            gridControl_DanhSachSV.DataSource = new TaiKhoanBLL().GetList_Account();
            txtHovaTen.Text = txtMaSinhVien.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbl_taikhoansinhvien tk = new tbl_taikhoansinhvien();
            tk.IdSinhVien = txtMaSinhVien.Text.Trim();
            new TaiKhoanBLL().Delete(tk);
            gridControl_DanhSachSV.DataSource = new TaiKhoanBLL().GetList_Account();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtMaSinhVien.Text = gridView1.GetFocusedRowCellValue("IdSinhVien").ToString();
            txtHovaTen.Text = gridView1.GetFocusedRowCellValue("HoTen").ToString();
            txtHovaTen.Text = txtMaSinhVien.Text = "";
        }

        private void gridView1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        private void gridControl_DanhSachSV_Click(object sender, EventArgs e)
        {
        }
    }
}
