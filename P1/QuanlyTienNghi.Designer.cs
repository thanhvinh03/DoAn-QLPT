namespace P1
{
    partial class QuanlyTienNghi
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
            this.dgvTiennghi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbLoaiTienNghi = new System.Windows.Forms.ComboBox();
            this.txtGiathue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTonKho = new System.Windows.Forms.TextBox();
            this.txtGiatiennghi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txxTentnghi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatiennghi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLammoiti = new System.Windows.Forms.Button();
            this.btnxoati = new System.Windows.Forms.Button();
            this.btnSuaTN = new System.Windows.Forms.Button();
            this.btnThemTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiemTN = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiennghi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTiennghi
            // 
            this.dgvTiennghi.AllowUserToAddRows = false;
            this.dgvTiennghi.AllowUserToDeleteRows = false;
            this.dgvTiennghi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiennghi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column6,
            this.Column4,
            this.Column5});
            this.dgvTiennghi.Location = new System.Drawing.Point(24, 192);
            this.dgvTiennghi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTiennghi.Name = "dgvTiennghi";
            this.dgvTiennghi.ReadOnly = true;
            this.dgvTiennghi.RowHeadersWidth = 62;
            this.dgvTiennghi.Size = new System.Drawing.Size(842, 170);
            this.dgvTiennghi.TabIndex = 12;
            this.dgvTiennghi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTiennghi_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbLoaiTienNghi);
            this.groupBox1.Controls.Add(this.txtGiathue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTonKho);
            this.groupBox1.Controls.Add(this.txtGiatiennghi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txxTentnghi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMatiennghi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(60, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(488, 138);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Tiện ích";
            // 
            // cmbLoaiTienNghi
            // 
            this.cmbLoaiTienNghi.FormattingEnabled = true;
            this.cmbLoaiTienNghi.Location = new System.Drawing.Point(361, 29);
            this.cmbLoaiTienNghi.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLoaiTienNghi.Name = "cmbLoaiTienNghi";
            this.cmbLoaiTienNghi.Size = new System.Drawing.Size(106, 21);
            this.cmbLoaiTienNghi.TabIndex = 2;
            // 
            // txtGiathue
            // 
            this.txtGiathue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiathue.Location = new System.Drawing.Point(134, 89);
            this.txtGiathue.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiathue.Name = "txtGiathue";
            this.txtGiathue.Size = new System.Drawing.Size(103, 23);
            this.txtGiathue.TabIndex = 1;
            this.txtGiathue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiathue_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá Thuê";
            // 
            // txtTonKho
            // 
            this.txtTonKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTonKho.Location = new System.Drawing.Point(361, 88);
            this.txtTonKho.Margin = new System.Windows.Forms.Padding(2);
            this.txtTonKho.Name = "txtTonKho";
            this.txtTonKho.Size = new System.Drawing.Size(103, 23);
            this.txtTonKho.TabIndex = 1;
            this.txtTonKho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTonKho_KeyPress);
            // 
            // txtGiatiennghi
            // 
            this.txtGiatiennghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiatiennghi.Location = new System.Drawing.Point(361, 59);
            this.txtGiatiennghi.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiatiennghi.Name = "txtGiatiennghi";
            this.txtGiatiennghi.Size = new System.Drawing.Size(103, 23);
            this.txtGiatiennghi.TabIndex = 1;
            this.txtGiatiennghi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiatiennghi_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(261, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tồn Kho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá Mua";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(261, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Loại Tiện nghi";
            // 
            // txxTentnghi
            // 
            this.txxTentnghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txxTentnghi.Location = new System.Drawing.Point(134, 60);
            this.txxTentnghi.Margin = new System.Windows.Forms.Padding(2);
            this.txxTentnghi.Name = "txxTentnghi";
            this.txxTentnghi.Size = new System.Drawing.Size(103, 23);
            this.txxTentnghi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Tiện nghi";
            // 
            // txtMatiennghi
            // 
            this.txtMatiennghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatiennghi.Location = new System.Drawing.Point(134, 28);
            this.txtMatiennghi.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatiennghi.Name = "txtMatiennghi";
            this.txtMatiennghi.Size = new System.Drawing.Size(103, 23);
            this.txtMatiennghi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Tiện nghi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 119);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 10;
            // 
            // btnLammoiti
            // 
            this.btnLammoiti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoiti.Location = new System.Drawing.Point(633, 112);
            this.btnLammoiti.Margin = new System.Windows.Forms.Padding(2);
            this.btnLammoiti.Name = "btnLammoiti";
            this.btnLammoiti.Size = new System.Drawing.Size(68, 25);
            this.btnLammoiti.TabIndex = 6;
            this.btnLammoiti.Text = "Làm mới";
            this.btnLammoiti.UseVisualStyleBackColor = true;
            this.btnLammoiti.Click += new System.EventHandler(this.btnLammoiti_Click);
            // 
            // btnxoati
            // 
            this.btnxoati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoati.Location = new System.Drawing.Point(555, 113);
            this.btnxoati.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoati.Name = "btnxoati";
            this.btnxoati.Size = new System.Drawing.Size(70, 24);
            this.btnxoati.TabIndex = 7;
            this.btnxoati.Text = "Xóa";
            this.btnxoati.UseVisualStyleBackColor = true;
            this.btnxoati.Click += new System.EventHandler(this.btnxoati_Click);
            // 
            // btnSuaTN
            // 
            this.btnSuaTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTN.Location = new System.Drawing.Point(634, 81);
            this.btnSuaTN.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaTN.Name = "btnSuaTN";
            this.btnSuaTN.Size = new System.Drawing.Size(67, 24);
            this.btnSuaTN.TabIndex = 8;
            this.btnSuaTN.Text = "Sửa";
            this.btnSuaTN.UseVisualStyleBackColor = true;
            this.btnSuaTN.Click += new System.EventHandler(this.btnSuaTN_Click);
            // 
            // btnThemTN
            // 
            this.btnThemTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTN.Location = new System.Drawing.Point(552, 81);
            this.btnThemTN.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemTN.Name = "btnThemTN";
            this.btnThemTN.Size = new System.Drawing.Size(73, 24);
            this.btnThemTN.TabIndex = 9;
            this.btnThemTN.Text = "Thêm";
            this.btnThemTN.UseVisualStyleBackColor = true;
            this.btnThemTN.Click += new System.EventHandler(this.btnThemTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(237, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "QUẢN LÝ DANH SÁCH TIỆN NGHI";
            // 
            // txtTimKiemTN
            // 
            this.txtTimKiemTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemTN.Location = new System.Drawing.Point(678, 165);
            this.txtTimKiemTN.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiemTN.Name = "txtTimKiemTN";
            this.txtTimKiemTN.Size = new System.Drawing.Size(178, 23);
            this.txtTimKiemTN.TabIndex = 13;
            this.txtTimKiemTN.TextChanged += new System.EventHandler(this.txtTimKiemTN_TextChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Tiện nghi";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên Tiện Nghi";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Loại Tiện Nghi";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tồn Kho";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giá Mua";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Giá Thuê";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // QuanlyTienNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 391);
            this.Controls.Add(this.txtTimKiemTN);
            this.Controls.Add(this.dgvTiennghi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLammoiti);
            this.Controls.Add(this.btnxoati);
            this.Controls.Add(this.btnSuaTN);
            this.Controls.Add(this.btnThemTN);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanlyTienNghi";
            this.Text = "QuanlyTienIch";
            this.Load += new System.EventHandler(this.QuanlyTienNghi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiennghi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTiennghi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGiatiennghi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txxTentnghi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatiennghi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLammoiti;
        private System.Windows.Forms.Button btnxoati;
        private System.Windows.Forms.Button btnSuaTN;
        private System.Windows.Forms.Button btnThemTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiathue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimKiemTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbLoaiTienNghi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTonKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}