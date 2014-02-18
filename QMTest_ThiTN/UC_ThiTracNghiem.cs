using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using QMTest_ThiTN.BLL;
using QMTest_ThiTN.DAL;

namespace QMTest_ThiTN
{
    public partial class UC_ThiTracNghiem : UserControl
    {
        List<tbl_cauhoichinhthuc> cauhoi;
        RadioGroup rg;
        TextEdit txt;
        int thutucau;
        string dapan;
        string thisinh_luachon;

        public UC_ThiTracNghiem()
        {
            InitializeComponent();
        }

        private void UC_ThiTracNghiem_Load(object sender, EventArgs e)
        {
            cauhoi = new CauHoiBLL().GetList();
        }

        private void btnLayCauHoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (rg != null)
                    LuuLuaChon(thisinh_luachon);
                if (txt != null)
                    LuuLuaChon(txt.Text);
                panelControl_CauHoi.Controls.Clear();
                if (string.Compare(cauhoi[thutucau].IdLoaiCauHoi, "Loai1") == 0)
                {
                    labelControl_HuongDan.Text = "Lựa chọn câu trả lời đúng nhất";
                    labelControl_CauHoi.Text = cauhoi[thutucau].NoiDung;
                    //txt = null;
                    rg = new RadioGroup();
                    rg.Size = new Size(345, 209);
                    rg.BackColor = Color.Transparent;
                    rg.BorderStyle = BorderStyles.NoBorder;
                    rg.Dock = DockStyle.Fill;
                    rg.SelectedIndex = -1;
                    rg.EditValueChanged += new EventHandler(rg_EditValueChanged);

                    //lấy câu trả lời cho từng câu hỏi
                    var list = new CauTraLoiBLL().GetList(cauhoi[thutucau].IdCauHoi);
                    int id = 0;
                    foreach (var ctl in list)
                    {
                        id++;
                        var tmpItem = new RadioGroupItem(id, ctl.NoiDung);
                        rg.Properties.Items.Add(tmpItem);
                        if (ctl.DapAn != null) dapan = ctl.DapAn;
                    }
                    panelControl_CauHoi.Controls.Add(rg);
                }
                else
                    if (string.Compare(cauhoi[thutucau].IdLoaiCauHoi, "Loai2") == 0)
                    {
                        labelControl_HuongDan.Text = "Điền từ thích hợp trong câu sau";
                        labelControl_CauHoi.Text = cauhoi[thutucau].NoiDung;
                        var list = new CauTraLoiBLL().GetList(cauhoi[thutucau].IdCauHoi);
                        foreach (var ctl in list)
                        {
                            if (ctl.DapAn != null) dapan = ctl.DapAn;
                        }
                        panelControl_CauHoi.Controls.Add(GetTextBox());
                    }
                    else
                        if (string.Compare(cauhoi[thutucau].IdLoaiCauHoi, "Loai3") == 0)
                        {
                            labelControl_HuongDan.Text = "";
                            labelControl_CauHoi.Text = "Ghép các mệnh đề sau cho phù hợp - Kéo thả lựa chọn";
                            string[] noidung = cauhoi[thutucau].NoiDung.Split(',');
                            var list = new CauTraLoiBLL().GetList(cauhoi[thutucau].IdCauHoi);

                            int i = 1; int j = 0;
                            TableLayoutPanel tbp = Tao_TableLayoutPanel(list.Count);
                            panelControl_CauHoi.Controls.Add(tbp);
                            //sinh mệnh đề A
                            foreach (string st in noidung)
                            {
                                TextEdit t = new TextEdit();
                                t.Properties.ReadOnly = true;
                                t.Text = st;
                                tbp.Controls.Add(t, j, i);
                                i++;
                            }
                            //sinh vùng thả lựa chọn
                            i = 1; j = 1; int id = 0;
                            foreach (string st in noidung)
                            {
                                id++;
                                TextEdit t1 = new TextEdit() { Name = "txt" + id };
                                t1.AllowDrop = true;
                                t1.DragEnter += new DragEventHandler(t1_DragEnter);
                                t1.DragDrop += new DragEventHandler(t1_DragDrop);
                                tbp.Controls.Add(t1, j, i);
                                i++;
                            }
                            //sinh mệnh đề B
                            i = 1; j = 2; int ma = 0;
                            
                            foreach (var ctl in list)
                            {
                                ma++;
                                TextEdit t2 = new TextEdit() { Name = "textbox" + ma };
                                t2.Properties.ReadOnly = true;
                                t2.AllowDrop = true;
                                t2.Text = ctl.NoiDung;
                                t2.MouseDown += new MouseEventHandler(t2_MouseDown);
                                tbp.Controls.Add(t2, j, i);
                                i++;
                            }
                        }
                thutucau++;
            }
            catch
            {
                DialogResult result = XtraMessageBox.Show("Bạn đã hoàn thành bài thi \nXem kết quả", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //gọi Form xem kết quả
                    //frm.panelControl_CauHoi.Controls.Clear();
                    this.Hide();
                    //UC_XemKetQua uc = new UC_XemKetQua();
                    //uc.Dock = DockStyle.Fill;
                    //frm.panelControl_CauHoi.Controls.Add(uc);
                }
            }
        }
        const byte CtrlMask = 8;
        private void t2_MouseDown(object sender, MouseEventArgs e)
        {
            TextEdit t2 = (TextEdit)sender;
            if (e.Button == MouseButtons.Left)
            {
                t2.SelectAll();
                t2.DoDragDrop(t2.Text, DragDropEffects.Move | DragDropEffects.Copy);
            }
        }

        private void t1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                if ((e.KeyState & CtrlMask) == CtrlMask)
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else e.Effect = DragDropEffects.Move;
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void t1_DragDrop(object sender, DragEventArgs e)
        {
            TextEdit t1 = (TextEdit)sender;
            t1.Text = e.Data.GetData(DataFormats.Text).ToString();
            if ((e.KeyState & CtrlMask) == CtrlMask)
            {
                //t1.Text = "";
            }
        }

        private TextEdit GetTextBox()
        {
            //rg = null;
            txt = new TextEdit() { Size = new Size(170, 20) };
            //txt.TextChanged += new EventHandler(txt_TextChanged);
            return txt;
        }

        protected void LuuLuaChon(string luachon)
        {
            sinhvientraloi sv = new sinhvientraloi();
            sv.IdCauHoi = cauhoi[thutucau - 1].IdCauHoi;
            sv.IdSinhVien = "10K4061086";
            sv.ThoiGian = (string.Format("{0}/{1}/{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year));
            sv.LuaChon = luachon;
            new SinhVienTraLoiBLL().Insert(sv);
            //new SinhVienTraLoi().Update(sv);
        }

        private void rg_EditValueChanged(object sender, EventArgs e)
        {
            RadioGroup rg = (RadioGroup)sender;
            foreach (RadioGroupItem rdi in rg.Properties.Items)
            {
                if (rdi.Value == rg.EditValue)
                {
                    if (rdi.Description == dapan)
                    {
                        thisinh_luachon = rdi.Description;
                        break;
                    }
                    else
                    {
                        thisinh_luachon = rdi.Description;
                        break;
                    }
                }
            }
        }

        //TableLayoutPanel Tao_TableLayoutPanel()
        //{
        //    TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
        //    this.SuspendLayout();
        //    tableLayoutPanel1.ColumnCount = 3;
        //    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
        //    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
        //    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
        //    //tableLayoutPanel1.Location = new Point(14, 15);
        //    tableLayoutPanel1.Name = "tableLayoutPanel1";
        //    tableLayoutPanel1.RowCount = 3;
        //    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
        //    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
        //    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
        //    tableLayoutPanel1.Size = new Size(319, 148);
        //    tableLayoutPanel1.TabIndex = 0;

        //    return tableLayoutPanel1;
        //}

        TableLayoutPanel Tao_TableLayoutPanel(int count)
        {
            TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
            Label label1 = new Label();
            Label label2 = new Label();
            Label label3 = new Label();
            this.SuspendLayout();
            // tableLayoutPanel1
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33332F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Location = new Point(14, 15);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = count + 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            for (int i = 0; i < count; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            }
            //tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(319, 148);
            tableLayoutPanel1.TabIndex = 0;
            // label1
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Mệnh đề A";
            // label2
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new Point(109, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 0;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Text = "Phương án\nchọn";
            // label3
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new Point(215, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 0;
            label3.Text = "Mệnh đề B";

            return tableLayoutPanel1;
        }

        
    }
}
