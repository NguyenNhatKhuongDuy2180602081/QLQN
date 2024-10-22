namespace QLQN
{
    partial class frmCS
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMaLoai = new System.Windows.Forms.ComboBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenNC = new System.Windows.Forms.TextBox();
            this.txtMaNC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDSNC = new System.Windows.Forms.DataGridView();
            this.manuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(385, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHỈNH SỬA DANH SÁCH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMaLoai);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtTenNC);
            this.groupBox1.Controls.Add(this.txtMaNC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(46, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 244);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // cmbMaLoai
            // 
            this.cmbMaLoai.FormattingEnabled = true;
            this.cmbMaLoai.Location = new System.Drawing.Point(119, 184);
            this.cmbMaLoai.Name = "cmbMaLoai";
            this.cmbMaLoai.Size = new System.Drawing.Size(154, 24);
            this.cmbMaLoai.TabIndex = 2;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(119, 137);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(121, 22);
            this.txtGia.TabIndex = 1;
            // 
            // txtTenNC
            // 
            this.txtTenNC.Location = new System.Drawing.Point(119, 93);
            this.txtTenNC.Name = "txtTenNC";
            this.txtTenNC.Size = new System.Drawing.Size(201, 22);
            this.txtTenNC.TabIndex = 1;
            // 
            // txtMaNC
            // 
            this.txtMaNC.Location = new System.Drawing.Point(119, 46);
            this.txtMaNC.Name = "txtMaNC";
            this.txtMaNC.Size = new System.Drawing.Size(130, 22);
            this.txtMaNC.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên nước";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nước";
            // 
            // dgvDSNC
            // 
            this.dgvDSNC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manuoc,
            this.tennuoc,
            this.dg,
            this.maloai});
            this.dgvDSNC.Location = new System.Drawing.Point(417, 121);
            this.dgvDSNC.Name = "dgvDSNC";
            this.dgvDSNC.RowHeadersWidth = 51;
            this.dgvDSNC.RowTemplate.Height = 24;
            this.dgvDSNC.Size = new System.Drawing.Size(709, 379);
            this.dgvDSNC.TabIndex = 2;
            this.dgvDSNC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNC_CellContentClick);
            // 
            // manuoc
            // 
            this.manuoc.HeaderText = "Mã nước";
            this.manuoc.MinimumWidth = 6;
            this.manuoc.Name = "manuoc";
            this.manuoc.Width = 125;
            // 
            // tennuoc
            // 
            this.tennuoc.HeaderText = "Tên nước";
            this.tennuoc.MinimumWidth = 6;
            this.tennuoc.Name = "tennuoc";
            this.tennuoc.Width = 125;
            // 
            // dg
            // 
            this.dg.HeaderText = "Đơn giá";
            this.dg.MinimumWidth = 6;
            this.dg.Name = "dg";
            this.dg.Width = 125;
            // 
            // maloai
            // 
            this.maloai.HeaderText = "Mã loại";
            this.maloai.MinimumWidth = 6;
            this.maloai.Name = "maloai";
            this.maloai.Width = 125;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(278, 407);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 30);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(278, 443);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(103, 29);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(278, 371);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtExit
            // 
            this.txtExit.Location = new System.Drawing.Point(1007, 515);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(119, 23);
            this.txtExit.TabIndex = 4;
            this.txtExit.Text = "Thoát";
            this.txtExit.UseVisualStyleBackColor = true;
            this.txtExit.Click += new System.EventHandler(this.txtExit_Click);
            // 
            // frmCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 595);
            this.Controls.Add(this.txtExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvDSNC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmCS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa";
            this.Load += new System.EventHandler(this.frmCS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenNC;
        private System.Windows.Forms.TextBox txtMaNC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMaLoai;
        private System.Windows.Forms.DataGridView dgvDSNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn manuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloai;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button txtExit;
    }
}