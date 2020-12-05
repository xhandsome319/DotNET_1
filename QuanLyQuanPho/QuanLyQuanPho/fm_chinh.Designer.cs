
namespace QuanLyQuanPho
{
    partial class fm_chinh
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mns_quanly = new System.Windows.Forms.MenuStrip();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chủQuánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsv_hoadon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_thanhtien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.neud_giamgia = new System.Windows.Forms.NumericUpDown();
            this.bt_thanhtoan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.neud_soluong = new System.Windows.Forms.NumericUpDown();
            this.bt_themmon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_tenthucan = new System.Windows.Forms.ComboBox();
            this.cb_loaithucan = new System.Windows.Forms.ComboBox();
            this.flp_banan = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bt_chuyenban = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_chuyenban = new System.Windows.Forms.ComboBox();
            this.mns_quanly.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neud_giamgia)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neud_soluong)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mns_quanly
            // 
            this.mns_quanly.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mns_quanly.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem,
            this.thôngToolStripMenuItem,
            this.chủQuánToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.mns_quanly.Location = new System.Drawing.Point(0, 0);
            this.mns_quanly.Name = "mns_quanly";
            this.mns_quanly.Size = new System.Drawing.Size(1168, 30);
            this.mns_quanly.TabIndex = 1;
            this.mns_quanly.Text = "menuStrip2";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.nhânViênToolStripMenuItem.Text = "Chức Năng";
            // 
            // thôngToolStripMenuItem
            // 
            this.thôngToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thôngToolStripMenuItem.Name = "thôngToolStripMenuItem";
            this.thôngToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.thôngToolStripMenuItem.Text = "Nhân Viên";
            this.thôngToolStripMenuItem.Click += new System.EventHandler(this.thôngToolStripMenuItem_Click);
            // 
            // chủQuánToolStripMenuItem
            // 
            this.chủQuánToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chủQuánToolStripMenuItem.Name = "chủQuánToolStripMenuItem";
            this.chủQuánToolStripMenuItem.Size = new System.Drawing.Size(101, 26);
            this.chủQuánToolStripMenuItem.Text = "Chủ Quán";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(107, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsv_hoadon);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(579, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 703);
            this.panel1.TabIndex = 2;
            // 
            // lsv_hoadon
            // 
            this.lsv_hoadon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsv_hoadon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_hoadon.GridLines = true;
            this.lsv_hoadon.HideSelection = false;
            this.lsv_hoadon.Location = new System.Drawing.Point(0, 188);
            this.lsv_hoadon.Name = "lsv_hoadon";
            this.lsv_hoadon.Size = new System.Drawing.Size(564, 333);
            this.lsv_hoadon.TabIndex = 2;
            this.lsv_hoadon.UseCompatibleStateImageBehavior = false;
            this.lsv_hoadon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 192;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 76;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 73;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 81;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tb_thanhtien);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.neud_giamgia);
            this.panel3.Controls.Add(this.bt_thanhtoan);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 521);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(567, 182);
            this.panel3.TabIndex = 1;
            // 
            // tb_thanhtien
            // 
            this.tb_thanhtien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_thanhtien.Location = new System.Drawing.Point(184, 96);
            this.tb_thanhtien.Name = "tb_thanhtien";
            this.tb_thanhtien.ReadOnly = true;
            this.tb_thanhtien.Size = new System.Drawing.Size(164, 30);
            this.tb_thanhtien.TabIndex = 6;
            this.tb_thanhtien.Text = "0";
            this.tb_thanhtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thành Tiền:";
            // 
            // neud_giamgia
            // 
            this.neud_giamgia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neud_giamgia.Location = new System.Drawing.Point(16, 97);
            this.neud_giamgia.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.neud_giamgia.Name = "neud_giamgia";
            this.neud_giamgia.Size = new System.Drawing.Size(142, 30);
            this.neud_giamgia.TabIndex = 4;
            // 
            // bt_thanhtoan
            // 
            this.bt_thanhtoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thanhtoan.Location = new System.Drawing.Point(371, 66);
            this.bt_thanhtoan.Name = "bt_thanhtoan";
            this.bt_thanhtoan.Size = new System.Drawing.Size(164, 75);
            this.bt_thanhtoan.TabIndex = 3;
            this.bt_thanhtoan.Text = "Thanh Toán";
            this.bt_thanhtoan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giảm Giá:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.neud_soluong);
            this.panel2.Controls.Add(this.bt_themmon);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cb_tenthucan);
            this.panel2.Controls.Add(this.cb_loaithucan);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 182);
            this.panel2.TabIndex = 0;
            // 
            // neud_soluong
            // 
            this.neud_soluong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neud_soluong.Location = new System.Drawing.Point(111, 126);
            this.neud_soluong.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.neud_soluong.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.neud_soluong.Name = "neud_soluong";
            this.neud_soluong.Size = new System.Drawing.Size(142, 30);
            this.neud_soluong.TabIndex = 4;
            this.neud_soluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bt_themmon
            // 
            this.bt_themmon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_themmon.Location = new System.Drawing.Point(371, 92);
            this.bt_themmon.Name = "bt_themmon";
            this.bt_themmon.Size = new System.Drawing.Size(164, 75);
            this.bt_themmon.TabIndex = 3;
            this.bt_themmon.Text = "Thêm Món";
            this.bt_themmon.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số Lượng:";
            // 
            // cb_tenthucan
            // 
            this.cb_tenthucan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tenthucan.FormattingEnabled = true;
            this.cb_tenthucan.Location = new System.Drawing.Point(16, 49);
            this.cb_tenthucan.Name = "cb_tenthucan";
            this.cb_tenthucan.Size = new System.Drawing.Size(519, 30);
            this.cb_tenthucan.TabIndex = 1;
            // 
            // cb_loaithucan
            // 
            this.cb_loaithucan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_loaithucan.FormattingEnabled = true;
            this.cb_loaithucan.Location = new System.Drawing.Point(16, 13);
            this.cb_loaithucan.Name = "cb_loaithucan";
            this.cb_loaithucan.Size = new System.Drawing.Size(519, 30);
            this.cb_loaithucan.TabIndex = 0;
            // 
            // flp_banan
            // 
            this.flp_banan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flp_banan.Location = new System.Drawing.Point(6, 46);
            this.flp_banan.Name = "flp_banan";
            this.flp_banan.Size = new System.Drawing.Size(567, 515);
            this.flp_banan.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bt_chuyenban);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.cb_chuyenban);
            this.panel4.Location = new System.Drawing.Point(6, 567);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(567, 182);
            this.panel4.TabIndex = 4;
            // 
            // bt_chuyenban
            // 
            this.bt_chuyenban.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chuyenban.Location = new System.Drawing.Point(353, 66);
            this.bt_chuyenban.Name = "bt_chuyenban";
            this.bt_chuyenban.Size = new System.Drawing.Size(164, 75);
            this.bt_chuyenban.TabIndex = 3;
            this.bt_chuyenban.Text = "Chuyển Bàn";
            this.bt_chuyenban.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chuyển Bàn:";
            // 
            // cb_chuyenban
            // 
            this.cb_chuyenban.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_chuyenban.FormattingEnabled = true;
            this.cb_chuyenban.Location = new System.Drawing.Point(74, 97);
            this.cb_chuyenban.Name = "cb_chuyenban";
            this.cb_chuyenban.Size = new System.Drawing.Size(194, 30);
            this.cb_chuyenban.TabIndex = 1;
            // 
            // fm_chinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 766);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.flp_banan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mns_quanly);
            this.Name = "fm_chinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quán Phở - Quản Lý";
            this.mns_quanly.ResumeLayout(false);
            this.mns_quanly.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neud_giamgia)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neud_soluong)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mns_quanly;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chủQuánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tb_thanhtien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown neud_giamgia;
        private System.Windows.Forms.Button bt_thanhtoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown neud_soluong;
        private System.Windows.Forms.Button bt_themmon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_tenthucan;
        private System.Windows.Forms.ComboBox cb_loaithucan;
        private System.Windows.Forms.FlowLayoutPanel flp_banan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bt_chuyenban;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_chuyenban;
        private System.Windows.Forms.ListView lsv_hoadon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}