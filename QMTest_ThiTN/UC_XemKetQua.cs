using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QMTest_ThiTN.BLL;
using System.Net;
using System.Net.Mail;

namespace QMTest_ThiTN
{
    public partial class UC_XemKetQua : UserControl
    {
        string IdSinhVien;
        public UC_XemKetQua()
        {
            InitializeComponent();
        }

        public UC_XemKetQua(string idsinhvien)
        {
            InitializeComponent();
            IdSinhVien = idsinhvien;
        }

        private void UC_XemKetQua_Load(object sender, EventArgs e)
        {
            gridControl_KetQua.DataSource = new LayKetQuaBLL().LayKetQua(IdSinhVien);
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            
        }
    }
}
