﻿
namespace DemoLoi
{
    partial class Form4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.chiNhanhKH = new System.Windows.Forms.ComboBox();
            this.btnLoadKH = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.KHSuaLoi = new System.Windows.Forms.Button();
            this.KHChayLoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chiNhanhNV = new System.Windows.Forms.ComboBox();
            this.btnLoadNV = new System.Windows.Forms.Button();
            this.NVSuaLoi = new System.Windows.Forms.Button();
            this.NVChayLoi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGiaGiam = new System.Windows.Forms.TextBox();
            this.tbMaDT = new System.Windows.Forms.TextBox();
            this.tbMaSoThue = new System.Windows.Forms.TextBox();
            this.tbNguoiDaiDien = new System.Windows.Forms.TextBox();
            this.tbSoChiNhanhDK = new System.Windows.Forms.TextBox();
            this.tbNgayKT = new System.Windows.Forms.TextBox();
            this.tbKichHoat = new System.Windows.Forms.TextBox();
            this.tbPhiHoaHong = new System.Windows.Forms.TextBox();
            this.tbNgayBDTieuChuan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 548);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 70);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(847, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelCustomer
            // 
            this.panelCustomer.Controls.Add(this.chiNhanhKH);
            this.panelCustomer.Controls.Add(this.btnLoadKH);
            this.panelCustomer.Controls.Add(this.label5);
            this.panelCustomer.Controls.Add(this.dataGridView2);
            this.panelCustomer.Controls.Add(this.KHSuaLoi);
            this.panelCustomer.Controls.Add(this.KHChayLoi);
            this.panelCustomer.Controls.Add(this.label2);
            this.panelCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCustomer.Location = new System.Drawing.Point(0, 298);
            this.panelCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(1097, 250);
            this.panelCustomer.TabIndex = 1;
            // 
            // chiNhanhKH
            // 
            this.chiNhanhKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chiNhanhKH.FormattingEnabled = true;
            this.chiNhanhKH.Location = new System.Drawing.Point(808, 33);
            this.chiNhanhKH.Margin = new System.Windows.Forms.Padding(4);
            this.chiNhanhKH.Name = "chiNhanhKH";
            this.chiNhanhKH.Size = new System.Drawing.Size(160, 24);
            this.chiNhanhKH.TabIndex = 10;
            // 
            // btnLoadKH
            // 
            this.btnLoadKH.Location = new System.Drawing.Point(984, 66);
            this.btnLoadKH.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadKH.Name = "btnLoadKH";
            this.btnLoadKH.Size = new System.Drawing.Size(100, 28);
            this.btnLoadKH.TabIndex = 9;
            this.btnLoadKH.Text = "Thêm";
            this.btnLoadKH.UseVisualStyleBackColor = true;
            this.btnLoadKH.Click += new System.EventHandler(this.btnLoadKH_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 11;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(113, 66);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(856, 185);
            this.dataGridView2.TabIndex = 8;
            // 
            // KHSuaLoi
            // 
            this.KHSuaLoi.Location = new System.Drawing.Point(984, 214);
            this.KHSuaLoi.Margin = new System.Windows.Forms.Padding(4);
            this.KHSuaLoi.Name = "KHSuaLoi";
            this.KHSuaLoi.Size = new System.Drawing.Size(100, 28);
            this.KHSuaLoi.TabIndex = 8;
            this.KHSuaLoi.Text = "Sửa Lỗi";
            this.KHSuaLoi.UseVisualStyleBackColor = true;
            this.KHSuaLoi.Click += new System.EventHandler(this.KHSuaLoi_Click);
            // 
            // KHChayLoi
            // 
            this.KHChayLoi.Location = new System.Drawing.Point(984, 148);
            this.KHChayLoi.Margin = new System.Windows.Forms.Padding(4);
            this.KHChayLoi.Name = "KHChayLoi";
            this.KHChayLoi.Size = new System.Drawing.Size(100, 28);
            this.KHChayLoi.TabIndex = 7;
            this.KHChayLoi.Text = "Chạy Lỗi";
            this.KHChayLoi.UseVisualStyleBackColor = true;
            this.KHChayLoi.Click += new System.EventHandler(this.KHChayLoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhân viên thêm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chiNhanhNV);
            this.panel2.Controls.Add(this.btnLoadNV);
            this.panel2.Controls.Add(this.NVSuaLoi);
            this.panel2.Controls.Add(this.NVChayLoi);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbGiaGiam);
            this.panel2.Controls.Add(this.tbMaDT);
            this.panel2.Controls.Add(this.tbMaSoThue);
            this.panel2.Controls.Add(this.tbNguoiDaiDien);
            this.panel2.Controls.Add(this.tbSoChiNhanhDK);
            this.panel2.Controls.Add(this.tbNgayKT);
            this.panel2.Controls.Add(this.tbKichHoat);
            this.panel2.Controls.Add(this.tbPhiHoaHong);
            this.panel2.Controls.Add(this.tbNgayBDTieuChuan);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1097, 298);
            this.panel2.TabIndex = 2;
            // 
            // chiNhanhNV
            // 
            this.chiNhanhNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chiNhanhNV.FormattingEnabled = true;
            this.chiNhanhNV.Location = new System.Drawing.Point(629, 90);
            this.chiNhanhNV.Margin = new System.Windows.Forms.Padding(4);
            this.chiNhanhNV.Name = "chiNhanhNV";
            this.chiNhanhNV.Size = new System.Drawing.Size(160, 24);
            this.chiNhanhNV.TabIndex = 9;
            this.chiNhanhNV.SelectedIndexChanged += new System.EventHandler(this.chiNhanhNV_SelectedIndexChanged);
            // 
            // btnLoadNV
            // 
            this.btnLoadNV.Location = new System.Drawing.Point(984, 123);
            this.btnLoadNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadNV.Name = "btnLoadNV";
            this.btnLoadNV.Size = new System.Drawing.Size(100, 28);
            this.btnLoadNV.TabIndex = 8;
            this.btnLoadNV.Text = "Xem";
            this.btnLoadNV.UseVisualStyleBackColor = true;
            this.btnLoadNV.Click += new System.EventHandler(this.btnLoadNV_Click);
            // 
            // NVSuaLoi
            // 
            this.NVSuaLoi.Location = new System.Drawing.Point(984, 272);
            this.NVSuaLoi.Margin = new System.Windows.Forms.Padding(4);
            this.NVSuaLoi.Name = "NVSuaLoi";
            this.NVSuaLoi.Size = new System.Drawing.Size(100, 28);
            this.NVSuaLoi.TabIndex = 7;
            this.NVSuaLoi.Text = "Sửa Lỗi";
            this.NVSuaLoi.UseVisualStyleBackColor = true;
            this.NVSuaLoi.Click += new System.EventHandler(this.NVSuaLoi_Click);
            // 
            // NVChayLoi
            // 
            this.NVChayLoi.Location = new System.Drawing.Point(984, 198);
            this.NVChayLoi.Margin = new System.Windows.Forms.Padding(4);
            this.NVChayLoi.Name = "NVChayLoi";
            this.NVChayLoi.Size = new System.Drawing.Size(100, 28);
            this.NVChayLoi.TabIndex = 6;
            this.NVChayLoi.Text = "Chạy Lỗi";
            this.NVChayLoi.UseVisualStyleBackColor = true;
            this.NVChayLoi.Click += new System.EventHandler(this.NVChayLoi_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 11;
            // 
            // tbGiaGiam
            // 
            this.tbGiaGiam.Location = new System.Drawing.Point(812, 91);
            this.tbGiaGiam.Margin = new System.Windows.Forms.Padding(4);
            this.tbGiaGiam.Name = "tbGiaGiam";
            this.tbGiaGiam.Size = new System.Drawing.Size(156, 22);
            this.tbGiaGiam.TabIndex = 2;
            this.tbGiaGiam.TextChanged += new System.EventHandler(this.tbGiaGiam_TextChanged);
            // tbMaDT
            // 
            this.tbMaDT.Location = new System.Drawing.Point(960, 40);
            this.tbMaDT.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaDT.Name = "tbMaDT";
            this.tbMaDT.Size = new System.Drawing.Size(156, 22);
            this.tbMaDT.TabIndex = 2;
            this.tbMaDT.TextChanged += new System.EventHandler(this.tbMaDT_TextChanged);
            // tbMaSoThue
            // 
            this.tbMaSoThue.Location = new System.Drawing.Point(840, 40);
            this.tbMaSoThue.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaSoThue.Name = "tbMaSoThue";
            this.tbMaSoThue.Size = new System.Drawing.Size(156, 22);
            this.tbMaSoThue.TabIndex = 2;
            this.tbMaSoThue.TextChanged += new System.EventHandler(this.tbMaSoThue_TextChanged);
            // tbNguoiDaiDien
            // 
            this.tbNguoiDaiDien.Location = new System.Drawing.Point(720, 40);
            this.tbNguoiDaiDien.Margin = new System.Windows.Forms.Padding(4);
            this.tbNguoiDaiDien.Name = "NguoiDaiDien";
            this.tbNguoiDaiDien.Size = new System.Drawing.Size(156, 22);
            this.tbNguoiDaiDien.TabIndex = 2;
            this.tbNguoiDaiDien.TextChanged += new System.EventHandler(this.tbNguoiDaiDien_TextChanged);
            // tbSoChiNhanhDK
            // 
            this.tbSoChiNhanhDK.Location = new System.Drawing.Point(600, 40);
            this.tbSoChiNhanhDK.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoChiNhanhDK.Name = "SoChiNhanhDK";
            this.tbSoChiNhanhDK.Size = new System.Drawing.Size(156, 22);
            this.tbSoChiNhanhDK.TabIndex = 2;
            this.tbSoChiNhanhDK.TextChanged += new System.EventHandler(this.tbSoChiNhanhDK_TextChanged);
            // tbNgayKT
            // 
            this.tbNgayKT.Location = new System.Drawing.Point(480, 40);
            this.tbNgayKT.Margin = new System.Windows.Forms.Padding(4);
            this.tbNgayKT.Name = "tbNgayKT";
            this.tbNgayKT.Size = new System.Drawing.Size(156, 22);
            this.tbNgayKT.TabIndex = 2;
            this.tbNgayKT.TextChanged += new System.EventHandler(this.tbNgayKT_TextChanged);
            // tbKichHoat
            // 
            this.tbKichHoat.Location = new System.Drawing.Point(360, 40);
            this.tbKichHoat.Margin = new System.Windows.Forms.Padding(4);
            this.tbKichHoat.Name = "tbKichHoat";
            this.tbKichHoat.Size = new System.Drawing.Size(156, 22);
            this.tbKichHoat.TabIndex = 2;
            this.tbKichHoat.TextChanged += new System.EventHandler(this.tbKichHoat_TextChanged);
            
            // tbPhiHoaHong
            // 
            this.tbPhiHoaHong.Location = new System.Drawing.Point(240, 40);
            this.tbPhiHoaHong.Margin = new System.Windows.Forms.Padding(4);
            this.tbPhiHoaHong.Name = "tbPhiHoaHong";
            this.tbPhiHoaHong.Size = new System.Drawing.Size(890, 95);
            this.tbPhiHoaHong.TabIndex = 2;
            this.tbPhiHoaHong.TextChanged += new System.EventHandler(this.tbPhiHoaHong_TextChanged);
            // tbNgayBDTieuChuan
            // 
            this.tbNgayBDTieuChuan.Location = new System.Drawing.Point(120, 40);
            this.tbNgayBDTieuChuan.Margin = new System.Windows.Forms.Padding(4);
            this.tbNgayBDTieuChuan.Name = "tbGiaGiamtbNgayBDTieuChuan";
            this.tbNgayBDTieuChuan.Size = new System.Drawing.Size(156, 22);
            this.tbNgayBDTieuChuan.TabIndex = 2;
            this.tbNgayBDTieuChuan.TextChanged += new System.EventHandler(this.tbNgayBDTieuChuan_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhân viên xem";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(113, 123);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(856, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 618);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1115, 665);
            this.MinimumSize = new System.Drawing.Size(1115, 665);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhantomRead";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGiaGiam;
        private System.Windows.Forms.TextBox tbMaDT;
        private System.Windows.Forms.TextBox tbMaSoThue;
        private System.Windows.Forms.TextBox tbNguoiDaiDien;
        private System.Windows.Forms.TextBox tbSoChiNhanhDK;      
        private System.Windows.Forms.TextBox tbNgayKT;
        private System.Windows.Forms.TextBox tbKichHoat;
        private System.Windows.Forms.TextBox tbPhiHoaHong;
        private System.Windows.Forms.TextBox tbNgayBDTieuChuan;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button KHSuaLoi;
        private System.Windows.Forms.Button KHChayLoi;
        private System.Windows.Forms.Button NVSuaLoi;
        private System.Windows.Forms.Button NVChayLoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLoadKH;
        private System.Windows.Forms.Button btnLoadNV;
        private System.Windows.Forms.ComboBox chiNhanhKH;
        private System.Windows.Forms.ComboBox chiNhanhNV;
    }
}