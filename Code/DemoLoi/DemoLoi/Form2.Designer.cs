
namespace DemoLoi
{
    partial class Form2
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.suaLoiKH = new System.Windows.Forms.Button();
            this.soLuong = new System.Windows.Forms.NumericUpDown();
            this.SPKH = new System.Windows.Forms.ComboBox();
            this.DHKH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chayLoiKH = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SPTX = new System.Windows.Forms.ComboBox();
            this.DHTX = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.suaLoi = new System.Windows.Forms.Button();
            this.chayLoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soLuong)).BeginInit();
            this.panelCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 548);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 70);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(847, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.suaLoiKH);
            this.panel2.Controls.Add(this.soLuong);
            this.panel2.Controls.Add(this.SPKH);
            this.panel2.Controls.Add(this.DHKH);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.chayLoiKH);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1097, 180);
            this.panel2.TabIndex = 4;
            // 
            // suaLoiKH
            // 
            this.suaLoiKH.Location = new System.Drawing.Point(869, 119);
            this.suaLoiKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.suaLoiKH.Name = "suaLoiKH";
            this.suaLoiKH.Size = new System.Drawing.Size(100, 28);
            this.suaLoiKH.TabIndex = 18;
            this.suaLoiKH.Text = "Sửa Lỗi";
            this.suaLoiKH.UseVisualStyleBackColor = true;
            this.suaLoiKH.Click += new System.EventHandler(this.suaLoiKH_Click);
            // 
            // soLuong
            // 
            this.soLuong.Location = new System.Drawing.Point(795, 87);
            this.soLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.soLuong.Name = "soLuong";
            this.soLuong.Size = new System.Drawing.Size(100, 22);
            this.soLuong.TabIndex = 17;
            this.soLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SPKH
            // 
            this.SPKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SPKH.FormattingEnabled = true;
            this.SPKH.Location = new System.Drawing.Point(581, 87);
            this.SPKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SPKH.Name = "SPKH";
            this.SPKH.Size = new System.Drawing.Size(156, 24);
            this.SPKH.TabIndex = 16;
            this.SPKH.SelectionChangeCommitted += new System.EventHandler(this.SPKH_SelectionChangeCommitted);
            this.SPKH.Click += new System.EventHandler(this.SPKH_Click);
            // 
            // DHKH
            // 
            this.DHKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DHKH.FormattingEnabled = true;
            this.DHKH.Location = new System.Drawing.Point(375, 87);
            this.DHKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DHKH.Name = "DHKH";
            this.DHKH.Size = new System.Drawing.Size(156, 24);
            this.DHKH.TabIndex = 15;
            this.DHKH.SelectionChangeCommitted += new System.EventHandler(this.DHKH_SelectionChangeCommitted);
            this.DHKH.Click += new System.EventHandler(this.DHKH_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(808, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số Lượng";
            // 
            // chayLoiKH
            // 
            this.chayLoiKH.Location = new System.Drawing.Point(761, 119);
            this.chayLoiKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chayLoiKH.Name = "chayLoiKH";
            this.chayLoiKH.Size = new System.Drawing.Size(100, 28);
            this.chayLoiKH.TabIndex = 6;
            this.chayLoiKH.Text = "Chạy Lỗi";
            this.chayLoiKH.UseVisualStyleBackColor = true;
            this.chayLoiKH.Click += new System.EventHandler(this.capNhat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã Sản Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Đơn Hàng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thao Tác \r\nKhách Hàng";
            // 
            // panelCustomer
            // 
            this.panelCustomer.Controls.Add(this.dataGridView1);
            this.panelCustomer.Controls.Add(this.SPTX);
            this.panelCustomer.Controls.Add(this.DHTX);
            this.panelCustomer.Controls.Add(this.label6);
            this.panelCustomer.Controls.Add(this.dataGridView2);
            this.panelCustomer.Controls.Add(this.label7);
            this.panelCustomer.Controls.Add(this.suaLoi);
            this.panelCustomer.Controls.Add(this.chayLoi);
            this.panelCustomer.Controls.Add(this.label2);
            this.panelCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCustomer.Location = new System.Drawing.Point(0, 180);
            this.panelCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(1097, 368);
            this.panelCustomer.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(113, 223);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(856, 146);
            this.dataGridView1.TabIndex = 15;
            // 
            // SPTX
            // 
            this.SPTX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SPTX.FormattingEnabled = true;
            this.SPTX.Location = new System.Drawing.Point(581, 34);
            this.SPTX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SPTX.Name = "SPTX";
            this.SPTX.Size = new System.Drawing.Size(156, 24);
            this.SPTX.TabIndex = 14;
            // 
            // DHTX
            // 
            this.DHTX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DHTX.FormattingEnabled = true;
            this.DHTX.Location = new System.Drawing.Point(375, 34);
            this.DHTX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DHTX.Name = "DHTX";
            this.DHTX.Size = new System.Drawing.Size(156, 24);
            this.DHTX.TabIndex = 10;
            this.DHTX.SelectionChangeCommitted += new System.EventHandler(this.DHTX_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(607, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mã Sản Phẩm";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(115, 69);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(856, 146);
            this.dataGridView2.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã Đơn Hàng";
            // 
            // suaLoi
            // 
            this.suaLoi.Location = new System.Drawing.Point(869, 31);
            this.suaLoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.suaLoi.Name = "suaLoi";
            this.suaLoi.Size = new System.Drawing.Size(100, 28);
            this.suaLoi.TabIndex = 8;
            this.suaLoi.Text = "Sửa Lỗi";
            this.suaLoi.UseVisualStyleBackColor = true;
            this.suaLoi.Click += new System.EventHandler(this.suaLoi_Click);
            // 
            // chayLoi
            // 
            this.chayLoi.Location = new System.Drawing.Point(761, 31);
            this.chayLoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chayLoi.Name = "chayLoi";
            this.chayLoi.Size = new System.Drawing.Size(100, 28);
            this.chayLoi.TabIndex = 7;
            this.chayLoi.Text = "Chạy Lỗi";
            this.chayLoi.UseVisualStyleBackColor = true;
            this.chayLoi.Click += new System.EventHandler(this.chayLoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thao Tác Tài Xế";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 618);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1115, 665);
            this.MinimumSize = new System.Drawing.Size(1115, 665);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unrepeatable Read";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soLuong)).EndInit();
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button chayLoiKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button suaLoi;
        private System.Windows.Forms.Button chayLoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown soLuong;
        private System.Windows.Forms.ComboBox SPKH;
        private System.Windows.Forms.ComboBox DHKH;
        private System.Windows.Forms.ComboBox SPTX;
        private System.Windows.Forms.ComboBox DHTX;
        private System.Windows.Forms.Button suaLoiKH;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}