namespace P1
{
    partial class QuanlyHopDong
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
            this.dgvHopdong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCT_HOPDONG = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.CT_HOPDONG = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DateLap = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMahopdong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopdong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHopdong
            // 
            this.dgvHopdong.AllowUserToAddRows = false;
            this.dgvHopdong.AllowUserToDeleteRows = false;
            this.dgvHopdong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopdong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvHopdong.Location = new System.Drawing.Point(203, 302);
            this.dgvHopdong.Name = "dgvHopdong";
            this.dgvHopdong.ReadOnly = true;
            this.dgvHopdong.RowHeadersWidth = 62;
            this.dgvHopdong.RowTemplate.Height = 28;
            this.dgvHopdong.Size = new System.Drawing.Size(944, 198);
            this.dgvHopdong.TabIndex = 27;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Hợp đồng";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ngày lập hợp đồng";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(366, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 37);
            this.label2.TabIndex = 19;
            this.label2.Text = "QUẢN LÝ HỢP ĐỒNG";
            // 
            // btnCT_HOPDONG
            // 
            this.btnCT_HOPDONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCT_HOPDONG.Location = new System.Drawing.Point(689, 190);
            this.btnCT_HOPDONG.Name = "btnCT_HOPDONG";
            this.btnCT_HOPDONG.Size = new System.Drawing.Size(219, 34);
            this.btnCT_HOPDONG.TabIndex = 21;
            this.btnCT_HOPDONG.Text = "Tạo CT_HỢP ĐỒNG";
            this.btnCT_HOPDONG.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(914, 133);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 34);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // CT_HOPDONG
            // 
            this.CT_HOPDONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CT_HOPDONG.Location = new System.Drawing.Point(914, 189);
            this.CT_HOPDONG.Name = "CT_HOPDONG";
            this.CT_HOPDONG.Size = new System.Drawing.Size(206, 35);
            this.CT_HOPDONG.TabIndex = 23;
            this.CT_HOPDONG.Text = "CT_HỢP ĐỒNG";
            this.CT_HOPDONG.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(960, 270);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(187, 26);
            this.txtTimkiem.TabIndex = 20;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.Location = new System.Drawing.Point(1047, 132);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(100, 35);
            this.btnLammoi.TabIndex = 24;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(788, 133);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 35);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(674, 133);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 35);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DateLap);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMahopdong);
            this.groupBox1.Location = new System.Drawing.Point(212, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 175);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Hợp đồng";
            // 
            // DateLap
            // 
            this.DateLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateLap.Location = new System.Drawing.Point(221, 87);
            this.DateLap.Name = "DateLap";
            this.DateLap.Size = new System.Drawing.Size(200, 30);
            this.DateLap.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày lập hợp đồng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Hợp đồng";
            // 
            // txtMahopdong
            // 
            this.txtMahopdong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMahopdong.Location = new System.Drawing.Point(221, 43);
            this.txtMahopdong.Name = "txtMahopdong";
            this.txtMahopdong.Size = new System.Drawing.Size(170, 30);
            this.txtMahopdong.TabIndex = 4;
            // 
            // QuanlyHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 557);
            this.Controls.Add(this.dgvHopdong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCT_HOPDONG);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.CT_HOPDONG);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanlyHopDong";
            this.Text = "QuanlyHopDong";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopdong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHopdong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCT_HOPDONG;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button CT_HOPDONG;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DateLap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMahopdong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}