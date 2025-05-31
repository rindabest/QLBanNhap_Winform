namespace QLBanNhap2_2_
{
    partial class KhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_capnhat_kh = new System.Windows.Forms.Button();
            this.btn_luu_kh = new System.Windows.Forms.Button();
            this.btn_xoa_kh = new System.Windows.Forms.Button();
            this.btn_them_kh = new System.Windows.Forms.Button();
            this.dtgv_kh = new System.Windows.Forms.DataGridView();
            this.txtBox_Sodt_Kh = new System.Windows.Forms.TextBox();
            this.txtBox_TenKh_Kh = new System.Windows.Forms.TextBox();
            this.txtBox_Makh_Kh = new System.Windows.Forms.TextBox();
            this.txtBox_diachi_KH = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_kh)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1300, 817);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_capnhat_kh);
            this.tabPage1.Controls.Add(this.btn_luu_kh);
            this.tabPage1.Controls.Add(this.btn_xoa_kh);
            this.tabPage1.Controls.Add(this.btn_them_kh);
            this.tabPage1.Controls.Add(this.dtgv_kh);
            this.tabPage1.Controls.Add(this.txtBox_Sodt_Kh);
            this.tabPage1.Controls.Add(this.txtBox_TenKh_Kh);
            this.tabPage1.Controls.Add(this.txtBox_Makh_Kh);
            this.tabPage1.Controls.Add(this.txtBox_diachi_KH);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1292, 776);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Khách Hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_capnhat_kh
            // 
            this.btn_capnhat_kh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_capnhat_kh.Location = new System.Drawing.Point(728, 707);
            this.btn_capnhat_kh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_capnhat_kh.Name = "btn_capnhat_kh";
            this.btn_capnhat_kh.Size = new System.Drawing.Size(150, 50);
            this.btn_capnhat_kh.TabIndex = 40;
            this.btn_capnhat_kh.Text = "Cập Nhật";
            this.btn_capnhat_kh.UseVisualStyleBackColor = true;
            this.btn_capnhat_kh.Click += new System.EventHandler(this.btn_capnhat_kh_Click);
            // 
            // btn_luu_kh
            // 
            this.btn_luu_kh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_luu_kh.Location = new System.Drawing.Point(1074, 707);
            this.btn_luu_kh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_luu_kh.Name = "btn_luu_kh";
            this.btn_luu_kh.Size = new System.Drawing.Size(150, 50);
            this.btn_luu_kh.TabIndex = 41;
            this.btn_luu_kh.Text = "Lưu";
            this.btn_luu_kh.UseVisualStyleBackColor = true;
            this.btn_luu_kh.Click += new System.EventHandler(this.btn_luu_kh_Click);
            // 
            // btn_xoa_kh
            // 
            this.btn_xoa_kh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa_kh.Location = new System.Drawing.Point(384, 707);
            this.btn_xoa_kh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xoa_kh.Name = "btn_xoa_kh";
            this.btn_xoa_kh.Size = new System.Drawing.Size(150, 50);
            this.btn_xoa_kh.TabIndex = 39;
            this.btn_xoa_kh.Text = "Xóa";
            this.btn_xoa_kh.UseVisualStyleBackColor = true;
            this.btn_xoa_kh.Click += new System.EventHandler(this.btn_xoa_kh_Click);
            // 
            // btn_them_kh
            // 
            this.btn_them_kh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_them_kh.Location = new System.Drawing.Point(39, 707);
            this.btn_them_kh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_them_kh.Name = "btn_them_kh";
            this.btn_them_kh.Size = new System.Drawing.Size(150, 50);
            this.btn_them_kh.TabIndex = 38;
            this.btn_them_kh.Text = "Thêm";
            this.btn_them_kh.UseVisualStyleBackColor = true;
            this.btn_them_kh.Click += new System.EventHandler(this.btn_them_kh_Click);
            // 
            // dtgv_kh
            // 
            this.dtgv_kh.AllowUserToAddRows = false;
            this.dtgv_kh.AllowUserToDeleteRows = false;
            this.dtgv_kh.AllowUserToOrderColumns = true;
            this.dtgv_kh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_kh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_kh.Location = new System.Drawing.Point(-2, 319);
            this.dtgv_kh.Margin = new System.Windows.Forms.Padding(2);
            this.dtgv_kh.Name = "dtgv_kh";
            this.dtgv_kh.ReadOnly = true;
            this.dtgv_kh.RowHeadersWidth = 51;
            this.dtgv_kh.RowTemplate.Height = 24;
            this.dtgv_kh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_kh.Size = new System.Drawing.Size(1288, 373);
            this.dtgv_kh.TabIndex = 37;
            this.dtgv_kh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_kh_CellContentClick);
            // 
            // txtBox_Sodt_Kh
            // 
            this.txtBox_Sodt_Kh.Location = new System.Drawing.Point(790, 97);
            this.txtBox_Sodt_Kh.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_Sodt_Kh.Multiline = true;
            this.txtBox_Sodt_Kh.Name = "txtBox_Sodt_Kh";
            this.txtBox_Sodt_Kh.Size = new System.Drawing.Size(229, 30);
            this.txtBox_Sodt_Kh.TabIndex = 36;
            // 
            // txtBox_TenKh_Kh
            // 
            this.txtBox_TenKh_Kh.Location = new System.Drawing.Point(346, 175);
            this.txtBox_TenKh_Kh.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_TenKh_Kh.Multiline = true;
            this.txtBox_TenKh_Kh.Name = "txtBox_TenKh_Kh";
            this.txtBox_TenKh_Kh.Size = new System.Drawing.Size(229, 30);
            this.txtBox_TenKh_Kh.TabIndex = 35;
            // 
            // txtBox_Makh_Kh
            // 
            this.txtBox_Makh_Kh.Location = new System.Drawing.Point(346, 97);
            this.txtBox_Makh_Kh.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_Makh_Kh.Multiline = true;
            this.txtBox_Makh_Kh.Name = "txtBox_Makh_Kh";
            this.txtBox_Makh_Kh.Size = new System.Drawing.Size(229, 30);
            this.txtBox_Makh_Kh.TabIndex = 34;
            // 
            // txtBox_diachi_KH
            // 
            this.txtBox_diachi_KH.Location = new System.Drawing.Point(790, 174);
            this.txtBox_diachi_KH.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_diachi_KH.Multiline = true;
            this.txtBox_diachi_KH.Name = "txtBox_diachi_KH";
            this.txtBox_diachi_KH.Size = new System.Drawing.Size(229, 107);
            this.txtBox_diachi_KH.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(188, 174);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 22);
            this.label15.TabIndex = 32;
            this.label15.Text = "Tên Khách Hàng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(618, 106);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 22);
            this.label14.TabIndex = 31;
            this.label14.Text = "Số Điện Thoại";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(618, 174);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 22);
            this.label13.TabIndex = 30;
            this.label13.Text = "Địa Chỉ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(188, 106);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 22);
            this.label12.TabIndex = 29;
            this.label12.Text = "Mã Khách Hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(453, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(362, 33);
            this.label10.TabIndex = 28;
            this.label10.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 817);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_kh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_capnhat_kh;
        private System.Windows.Forms.Button btn_luu_kh;
        private System.Windows.Forms.Button btn_xoa_kh;
        private System.Windows.Forms.Button btn_them_kh;
        private System.Windows.Forms.DataGridView dtgv_kh;
        private System.Windows.Forms.TextBox txtBox_Sodt_Kh;
        private System.Windows.Forms.TextBox txtBox_TenKh_Kh;
        private System.Windows.Forms.TextBox txtBox_Makh_Kh;
        private System.Windows.Forms.TextBox txtBox_diachi_KH;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
    }
}