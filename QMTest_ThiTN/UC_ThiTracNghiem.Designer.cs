namespace QMTest_ThiTN
{
    partial class UC_ThiTracNghiem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl_CauHoi = new DevExpress.XtraEditors.GroupControl();
            this.labelControl_HuongDan = new DevExpress.XtraEditors.LabelControl();
            this.panelControl_CauHoi = new DevExpress.XtraEditors.PanelControl();
            this.btnLayCauHoi = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl_CauHoi = new DevExpress.XtraEditors.LabelControl();
            this.richEditBarController1 = new DevExpress.XtraRichEdit.UI.RichEditBarController();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_CauHoi)).BeginInit();
            this.groupControl_CauHoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_CauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl_CauHoi
            // 
            this.groupControl_CauHoi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl_CauHoi.Controls.Add(this.labelControl_HuongDan);
            this.groupControl_CauHoi.Controls.Add(this.panelControl_CauHoi);
            this.groupControl_CauHoi.Controls.Add(this.btnLayCauHoi);
            this.groupControl_CauHoi.Controls.Add(this.labelControl_CauHoi);
            this.groupControl_CauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_CauHoi.Location = new System.Drawing.Point(0, 0);
            this.groupControl_CauHoi.Name = "groupControl_CauHoi";
            this.groupControl_CauHoi.Size = new System.Drawing.Size(849, 549);
            this.groupControl_CauHoi.TabIndex = 2;
            this.groupControl_CauHoi.Text = "Câu hỏi";
            // 
            // labelControl_HuongDan
            // 
            this.labelControl_HuongDan.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_HuongDan.Appearance.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelControl_HuongDan.Location = new System.Drawing.Point(55, 33);
            this.labelControl_HuongDan.Name = "labelControl_HuongDan";
            this.labelControl_HuongDan.Size = new System.Drawing.Size(6, 23);
            this.labelControl_HuongDan.TabIndex = 3;
            this.labelControl_HuongDan.Text = ".";
            // 
            // panelControl_CauHoi
            // 
            this.panelControl_CauHoi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl_CauHoi.Location = new System.Drawing.Point(125, 90);
            this.panelControl_CauHoi.Name = "panelControl_CauHoi";
            this.panelControl_CauHoi.Size = new System.Drawing.Size(10, 51);
            this.panelControl_CauHoi.TabIndex = 2;
            // 
            // btnLayCauHoi
            // 
            this.btnLayCauHoi.Location = new System.Drawing.Point(765, 505);
            this.btnLayCauHoi.Name = "btnLayCauHoi";
            this.btnLayCauHoi.Size = new System.Drawing.Size(79, 39);
            this.btnLayCauHoi.TabIndex = 1;
            this.btnLayCauHoi.Text = "Câu hỏi";
            this.btnLayCauHoi.Click += new System.EventHandler(this.btnLayCauHoi_Click);
            // 
            // labelControl_CauHoi
            // 
            this.labelControl_CauHoi.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_CauHoi.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl_CauHoi.Location = new System.Drawing.Point(125, 59);
            this.labelControl_CauHoi.Name = "labelControl_CauHoi";
            this.labelControl_CauHoi.Size = new System.Drawing.Size(6, 25);
            this.labelControl_CauHoi.TabIndex = 0;
            this.labelControl_CauHoi.Text = ".";
            // 
            // UC_ThiTracNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl_CauHoi);
            this.Name = "UC_ThiTracNghiem";
            this.Size = new System.Drawing.Size(849, 549);
            this.Load += new System.EventHandler(this.UC_ThiTracNghiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_CauHoi)).EndInit();
            this.groupControl_CauHoi.ResumeLayout(false);
            this.groupControl_CauHoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_CauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl_CauHoi;
        private DevExpress.XtraEditors.LabelControl labelControl_CauHoi;
        private DevExpress.XtraEditors.SimpleButton btnLayCauHoi;
        private DevExpress.XtraEditors.LabelControl labelControl_HuongDan;
        private DevExpress.XtraEditors.PanelControl panelControl_CauHoi;
        private DevExpress.XtraRichEdit.UI.RichEditBarController richEditBarController1;
    }
}
