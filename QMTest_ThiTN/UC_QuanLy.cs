using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraEditors.Controls;
using QMTest_ThiTN.BLL;
using QMTest_ThiTN.DAL;


namespace QMTest_ThiTN
{
    public partial class UC_QuanLy : UserControl
    {
        public UC_QuanLy()
        {
            InitializeComponent();
        }
        byte[] imageData = { };
        private void UC_QuanLy_Load(object sender, EventArgs e)
        {
            imageData = null;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "JPG Files(*.JPG)|*.JPG|GIF Files(*.GIF)|*.GIF|JPEG Files(*.JPEG)|*.JPEG|PNG Files(*.PNG)|*.PNG";
            if (open.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(open.FileName, FileMode.Open, FileAccess.Read))
                {
                    imageData = new Byte[fs.Length];
                    fs.Read(imageData, 0, (int)fs.Length);
                    //Đưa ảnh lên picturedit1
                    MemoryStream str = new MemoryStream(imageData);
                    pictureEdit1.Image = Image.FromStream(str);
                    pictureEdit1.Properties.SizeMode = PictureSizeMode.Stretch;
                }

            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            tbl_cauhoichinhthuc ch = new tbl_cauhoichinhthuc();
            ch.IdCauHoi = "CH08";
            ch.NoiDung = "Quý Đỗ là ai trong ảnh";
            ch.IdLoaiCauHoi = "Loai4";
            ch.HinhAnh = imageData;
            new CauHoiBLL().Insert(ch);
        }
    }
}
