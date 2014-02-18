using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using QMTest_ThiTN.BLL;

namespace QMTest_ThiTN
{
    public partial class Frm_DangNhap : XtraForm
    {
        public Frm_DangNhap()
        {
            InitializeComponent();
        }
        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_DangNhap;
        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            var tenDangNhap = txtTenDangNhap.Text.Trim();
            var matkhau = txtMatKhau.Text.Trim();
            var nsd = new TaiKhoanBLL().Validate(tenDangNhap, matkhau);
            if (nsd != null)
            {
                XtraMessageBox.Show("Đăng nhập thành công", "Thông báo");
                Frm_Main frm = new Frm_Main(tenDangNhap,nsd.HoTen);
                frm.Show();
                this.Hide();
            }
        }


    }
}
