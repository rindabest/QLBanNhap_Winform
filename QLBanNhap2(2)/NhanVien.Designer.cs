namespace QLBanNhap2_2_
{
    partial class NhanVien
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_capnhat_nv = new System.Windows.Forms.Button();
            this.btn_luu_nv = new System.Windows.Forms.Button();
            this.btn_xoa_nv = new System.Windows.Forms.Button();
            this.btn_them_nv = new System.Windows.Forms.Button();
            this.dtgv_nv = new System.Windows.Forms.DataGridView();
            this.txtBox_Sodt_Nv = new System.Windows.Forms.TextBox();
            this.txtBox_TenNv_Nv = new System.Windows.Forms.TextBox();
            this.txtBox_MaNv_Nv = new System.Windows.Forms.TextBox();
            this.txtBox_diachi_Nv = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_nv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1300, 817);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_capnhat_nv);
            this.tabPage1.Controls.Add(this.btn_luu_nv);
            this.tabPage1.Controls.Add(this.btn_xoa_nv);
            this.tabPage1.Controls.Add(this.btn_them_nv);
            this.tabPage1.Controls.Add(this.dtgv_nv);
            this.tabPage1.Controls.Add(this.txtBox_Sodt_Nv);
            this.tabPage1.Controls.Add(this.txtBox_TenNv_Nv);
            this.tabPage1.Controls.Add(this.txtBox_MaNv_Nv);
            this.tabPage1.Controls.Add(this.txtBox_diachi_Nv);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1292, 776);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhân Viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_capnhat_nv
            // 
            this.btn_capnhat_nv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_capnhat_nv.Location = new System.Drawing.Point(747, 710);
            this.btn_capnhat_nv.Name = "btn_capnhat_nv";
            this.btn_capnhat_nv.Size = new System.Drawing.Size(150, 50);
            this.btn_capnhat_nv.TabIndex = 49;
            this.btn_capnhat_nv.Text = "Cập Nhật";
            this.btn_capnhat_nv.UseVisualStyleBackColor = true;
            this.btn_capnhat_nv.Click += new System.EventHandler(this.btn_capnhat_nv_Click);
            // 
            // btn_luu_nv
            // 
            this.btn_luu_nv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_luu_nv.Location = new System.Drawing.Point(1096, 710);
            this.btn_luu_nv.Name = "btn_luu_nv";
            this.btn_luu_nv.Size = new System.Drawing.Size(150, 50);
            this.btn_luu_nv.TabIndex = 50;
            this.btn_luu_nv.Text = "Lưu";
            this.btn_luu_nv.UseVisualStyleBackColor = true;
            this.btn_luu_nv.Click += new System.EventHandler(this.btn_luu_nv_Click);
            // 
            // btn_xoa_nv
            // 
            this.btn_xoa_nv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa_nv.Location = new System.Drawing.Point(398, 710);
            this.btn_xoa_nv.Name = "btn_xoa_nv";
            this.btn_xoa_nv.Size = new System.Drawing.Size(150, 50);
            this.btn_xoa_nv.TabIndex = 48;
            this.btn_xoa_nv.Text = "Xóa";
            this.btn_xoa_nv.UseVisualStyleBackColor = true;
            this.btn_xoa_nv.Click += new System.EventHandler(this.btn_xoa_nv_Click);
            // 
            // btn_them_nv
            // 
            this.btn_them_nv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_them_nv.Location = new System.Drawing.Point(49, 710);
            this.btn_them_nv.Name = "btn_them_nv";
            this.btn_them_nv.Size = new System.Drawing.Size(150, 50);
            this.btn_them_nv.TabIndex = 47;
            this.btn_them_nv.Text = "Thêm";
            this.btn_them_nv.UseVisualStyleBackColor = true;
            this.btn_them_nv.Click += new System.EventHandler(this.btn_them_nv_Click);
            // 
            // dtgv_nv
            // 
            this.dtgv_nv.AllowUserToAddRows = false;
            this.dtgv_nv.AllowUserToDeleteRows = false;
            this.dtgv_nv.AllowUserToOrderColumns = true;
            this.dtgv_nv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_nv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_nv.Location = new System.Drawing.Point(0, 296);
            this.dtgv_nv.Name = "dtgv_nv";
            this.dtgv_nv.ReadOnly = true;
            this.dtgv_nv.RowHeadersWidth = 51;
            this.dtgv_nv.RowTemplate.Height = 24;
            this.dtgv_nv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_nv.Size = new System.Drawing.Size(1289, 373);
            this.dtgv_nv.TabIndex = 46;
            this.dtgv_nv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_nv_CellContentClick);
            // 
            // txtBox_Sodt_Nv
            // 
            this.txtBox_Sodt_Nv.Location = new System.Drawing.Point(846, 98);
            this.txtBox_Sodt_Nv.Multiline = true;
            this.txtBox_Sodt_Nv.Name = "txtBox_Sodt_Nv";
            this.txtBox_Sodt_Nv.Size = new System.Drawing.Size(229, 30);
            this.txtBox_Sodt_Nv.TabIndex = 45;
            // 
            // txtBox_TenNv_Nv
            // 
            this.txtBox_TenNv_Nv.Location = new System.Drawing.Point(362, 175);
            this.txtBox_TenNv_Nv.Multiline = true;
            this.txtBox_TenNv_Nv.Name = "txtBox_TenNv_Nv";
            this.txtBox_TenNv_Nv.Size = new System.Drawing.Size(229, 30);
            this.txtBox_TenNv_Nv.TabIndex = 44;
            // 
            // txtBox_MaNv_Nv
            // 
            this.txtBox_MaNv_Nv.Location = new System.Drawing.Point(362, 98);
            this.txtBox_MaNv_Nv.Multiline = true;
            this.txtBox_MaNv_Nv.Name = "txtBox_MaNv_Nv";
            this.txtBox_MaNv_Nv.Size = new System.Drawing.Size(229, 30);
            this.txtBox_MaNv_Nv.TabIndex = 43;
            // 
            // txtBox_diachi_Nv
            // 
            this.txtBox_diachi_Nv.Location = new System.Drawing.Point(846, 174);
            this.txtBox_diachi_Nv.Multiline = true;
            this.txtBox_diachi_Nv.Name = "txtBox_diachi_Nv";
            this.txtBox_diachi_Nv.Size = new System.Drawing.Size(229, 77);
            this.txtBox_diachi_Nv.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(204, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 22);
            this.label15.TabIndex = 41;
            this.label15.Text = "Tên Nhân Viên";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(675, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 22);
            this.label14.TabIndex = 40;
            this.label14.Text = "Số Điện Thoại";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(675, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 22);
            this.label13.TabIndex = 39;
            this.label13.Text = "Địa Chỉ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(204, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 22);
            this.label12.TabIndex = 38;
            this.label12.Text = "Mã Nhân Viên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(469, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(331, 33);
            this.label10.TabIndex = 37;
            this.label10.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 817);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_nv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_capnhat_nv;
        private System.Windows.Forms.Button btn_luu_nv;
        private System.Windows.Forms.Button btn_xoa_nv;
        private System.Windows.Forms.Button btn_them_nv;
        private System.Windows.Forms.DataGridView dtgv_nv;
        private System.Windows.Forms.TextBox txtBox_Sodt_Nv;
        private System.Windows.Forms.TextBox txtBox_TenNv_Nv;
        private System.Windows.Forms.TextBox txtBox_MaNv_Nv;
        private System.Windows.Forms.TextBox txtBox_diachi_Nv;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
    }
}