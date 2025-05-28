namespace QLBanNhap2_2_
{
    partial class ThongKe
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
            this.btn_timkiem_NvTopds = new System.Windows.Forms.Button();
            this.dtgv_NvTopDS_Tk = new System.Windows.Forms.DataGridView();
            this.cbBox_quy_Tk = new System.Windows.Forms.ComboBox();
            this.txt_nam_NvTopDS_TK = new System.Windows.Forms.TextBox();
            this.label_tenhang_hangdienthoai = new System.Windows.Forms.Label();
            this.label_mahang_hangdienthoai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_hienthiDT_TK = new System.Windows.Forms.Button();
            this.dtgv_dt_tk = new System.Windows.Forms.DataGridView();
            this.cBox_QuyDT_TK = new System.Windows.Forms.ComboBox();
            this.txt_namDT_TK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_NvTopDS_Tk)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dt_tk)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1300, 817);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_timkiem_NvTopds);
            this.tabPage1.Controls.Add(this.dtgv_NvTopDS_Tk);
            this.tabPage1.Controls.Add(this.cbBox_quy_Tk);
            this.tabPage1.Controls.Add(this.txt_nam_NvTopDS_TK);
            this.tabPage1.Controls.Add(this.label_tenhang_hangdienthoai);
            this.tabPage1.Controls.Add(this.label_mahang_hangdienthoai);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1292, 779);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhân Viên Top DS";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_timkiem_NvTopds
            // 
            this.btn_timkiem_NvTopds.Image = global::QLBanNhap2_2_.Properties.Resources.Start_Menu_Search_icon;
            this.btn_timkiem_NvTopds.Location = new System.Drawing.Point(955, 141);
            this.btn_timkiem_NvTopds.Name = "btn_timkiem_NvTopds";
            this.btn_timkiem_NvTopds.Size = new System.Drawing.Size(52, 48);
            this.btn_timkiem_NvTopds.TabIndex = 27;
            this.btn_timkiem_NvTopds.UseVisualStyleBackColor = true;
            this.btn_timkiem_NvTopds.Click += new System.EventHandler(this.btn_timkiem_NvTopds_Click);
            // 
            // dtgv_NvTopDS_Tk
            // 
            this.dtgv_NvTopDS_Tk.AllowUserToAddRows = false;
            this.dtgv_NvTopDS_Tk.AllowUserToDeleteRows = false;
            this.dtgv_NvTopDS_Tk.AllowUserToOrderColumns = true;
            this.dtgv_NvTopDS_Tk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_NvTopDS_Tk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_NvTopDS_Tk.Location = new System.Drawing.Point(7, 292);
            this.dtgv_NvTopDS_Tk.Name = "dtgv_NvTopDS_Tk";
            this.dtgv_NvTopDS_Tk.ReadOnly = true;
            this.dtgv_NvTopDS_Tk.RowHeadersWidth = 51;
            this.dtgv_NvTopDS_Tk.RowTemplate.Height = 24;
            this.dtgv_NvTopDS_Tk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_NvTopDS_Tk.Size = new System.Drawing.Size(1277, 321);
            this.dtgv_NvTopDS_Tk.TabIndex = 26;
            this.dtgv_NvTopDS_Tk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_NvTopDS_Tk_CellContentClick);
            // 
            // cbBox_quy_Tk
            // 
            this.cbBox_quy_Tk.FormattingEnabled = true;
            this.cbBox_quy_Tk.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbBox_quy_Tk.Location = new System.Drawing.Point(337, 153);
            this.cbBox_quy_Tk.Name = "cbBox_quy_Tk";
            this.cbBox_quy_Tk.Size = new System.Drawing.Size(121, 33);
            this.cbBox_quy_Tk.TabIndex = 23;
            // 
            // txt_nam_NvTopDS_TK
            // 
            this.txt_nam_NvTopDS_TK.Location = new System.Drawing.Point(726, 153);
            this.txt_nam_NvTopDS_TK.Name = "txt_nam_NvTopDS_TK";
            this.txt_nam_NvTopDS_TK.Size = new System.Drawing.Size(199, 33);
            this.txt_nam_NvTopDS_TK.TabIndex = 20;
            // 
            // label_tenhang_hangdienthoai
            // 
            this.label_tenhang_hangdienthoai.AutoSize = true;
            this.label_tenhang_hangdienthoai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_tenhang_hangdienthoai.ForeColor = System.Drawing.Color.Blue;
            this.label_tenhang_hangdienthoai.Location = new System.Drawing.Point(626, 153);
            this.label_tenhang_hangdienthoai.Name = "label_tenhang_hangdienthoai";
            this.label_tenhang_hangdienthoai.Size = new System.Drawing.Size(62, 26);
            this.label_tenhang_hangdienthoai.TabIndex = 22;
            this.label_tenhang_hangdienthoai.Text = "Năm:";
            // 
            // label_mahang_hangdienthoai
            // 
            this.label_mahang_hangdienthoai.AutoSize = true;
            this.label_mahang_hangdienthoai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_mahang_hangdienthoai.ForeColor = System.Drawing.Color.Blue;
            this.label_mahang_hangdienthoai.Location = new System.Drawing.Point(256, 153);
            this.label_mahang_hangdienthoai.Name = "label_mahang_hangdienthoai";
            this.label_mahang_hangdienthoai.Size = new System.Drawing.Size(59, 26);
            this.label_mahang_hangdienthoai.TabIndex = 21;
            this.label_mahang_hangdienthoai.Text = "Quý:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(462, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "NHÂN VIÊN TOP DOANH SỐ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_hienthiDT_TK);
            this.tabPage2.Controls.Add(this.dtgv_dt_tk);
            this.tabPage2.Controls.Add(this.cBox_QuyDT_TK);
            this.tabPage2.Controls.Add(this.txt_namDT_TK);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1292, 779);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Doanh Thu Theo Quý";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_hienthiDT_TK
            // 
            this.btn_hienthiDT_TK.Image = global::QLBanNhap2_2_.Properties.Resources.Start_Menu_Search_icon;
            this.btn_hienthiDT_TK.Location = new System.Drawing.Point(956, 153);
            this.btn_hienthiDT_TK.Name = "btn_hienthiDT_TK";
            this.btn_hienthiDT_TK.Size = new System.Drawing.Size(52, 48);
            this.btn_hienthiDT_TK.TabIndex = 34;
            this.btn_hienthiDT_TK.UseVisualStyleBackColor = true;
            this.btn_hienthiDT_TK.Click += new System.EventHandler(this.btn_hienthiDT_TK_Click);
            // 
            // dtgv_dt_tk
            // 
            this.dtgv_dt_tk.AllowUserToAddRows = false;
            this.dtgv_dt_tk.AllowUserToDeleteRows = false;
            this.dtgv_dt_tk.AllowUserToOrderColumns = true;
            this.dtgv_dt_tk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_dt_tk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_dt_tk.Location = new System.Drawing.Point(7, 292);
            this.dtgv_dt_tk.Name = "dtgv_dt_tk";
            this.dtgv_dt_tk.ReadOnly = true;
            this.dtgv_dt_tk.RowHeadersWidth = 51;
            this.dtgv_dt_tk.RowTemplate.Height = 24;
            this.dtgv_dt_tk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_dt_tk.Size = new System.Drawing.Size(1277, 321);
            this.dtgv_dt_tk.TabIndex = 33;
            // 
            // cBox_QuyDT_TK
            // 
            this.cBox_QuyDT_TK.FormattingEnabled = true;
            this.cBox_QuyDT_TK.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cBox_QuyDT_TK.Location = new System.Drawing.Point(338, 153);
            this.cBox_QuyDT_TK.Name = "cBox_QuyDT_TK";
            this.cBox_QuyDT_TK.Size = new System.Drawing.Size(121, 33);
            this.cBox_QuyDT_TK.TabIndex = 32;
            // 
            // txt_namDT_TK
            // 
            this.txt_namDT_TK.Location = new System.Drawing.Point(727, 153);
            this.txt_namDT_TK.Name = "txt_namDT_TK";
            this.txt_namDT_TK.Size = new System.Drawing.Size(199, 33);
            this.txt_namDT_TK.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(627, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "Năm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(256, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 26);
            this.label3.TabIndex = 30;
            this.label3.Text = "Quý:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(488, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 33);
            this.label4.TabIndex = 28;
            this.label4.Text = "DOANH THU THEO QUÝ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1292, 779);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mặt Hàng Bán Nhiều";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 817);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_NvTopDS_Tk)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dt_tk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_timkiem_NvTopds;
        private System.Windows.Forms.DataGridView dtgv_NvTopDS_Tk;
        private System.Windows.Forms.ComboBox cbBox_quy_Tk;
        private System.Windows.Forms.TextBox txt_nam_NvTopDS_TK;
        private System.Windows.Forms.Label label_tenhang_hangdienthoai;
        private System.Windows.Forms.Label label_mahang_hangdienthoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_hienthiDT_TK;
        private System.Windows.Forms.DataGridView dtgv_dt_tk;
        private System.Windows.Forms.ComboBox cBox_QuyDT_TK;
        private System.Windows.Forms.TextBox txt_namDT_TK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}