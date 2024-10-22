namespace QLQN
{
    partial class frmMNC
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
            this.txtCS = new System.Windows.Forms.Button();
            this.dgvQLNC = new System.Windows.Forms.DataGridView();
            this.maNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMNC = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTenNuoc = new System.Windows.Forms.ComboBox();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.btnCTHD = new System.Windows.Forms.Button();
            this.btnXoaDL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCS
            // 
            this.txtCS.Location = new System.Drawing.Point(971, 121);
            this.txtCS.Name = "txtCS";
            this.txtCS.Size = new System.Drawing.Size(121, 32);
            this.txtCS.TabIndex = 1;
            this.txtCS.Text = "Chỉnh sửa";
            this.txtCS.UseVisualStyleBackColor = true;
            this.txtCS.Click += new System.EventHandler(this.txtCS_Click);
            // 
            // dgvQLNC
            // 
            this.dgvQLNC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLNC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNC,
            this.tennc,
            this.dg,
            this.sl,
            this.tt});
            this.dgvQLNC.Location = new System.Drawing.Point(368, 159);
            this.dgvQLNC.Name = "dgvQLNC";
            this.dgvQLNC.RowHeadersWidth = 51;
            this.dgvQLNC.RowTemplate.Height = 24;
            this.dgvQLNC.Size = new System.Drawing.Size(724, 367);
            this.dgvQLNC.TabIndex = 2;
            this.dgvQLNC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLNC_CellContentClick);
            // 
            // maNC
            // 
            this.maNC.HeaderText = "Mã Nước";
            this.maNC.MinimumWidth = 6;
            this.maNC.Name = "maNC";
            this.maNC.Width = 125;
            // 
            // tennc
            // 
            this.tennc.HeaderText = "Tên Nước";
            this.tennc.MinimumWidth = 6;
            this.tennc.Name = "tennc";
            this.tennc.Width = 145;
            // 
            // dg
            // 
            this.dg.HeaderText = "Đơn Giá";
            this.dg.MinimumWidth = 6;
            this.dg.Name = "dg";
            this.dg.Width = 125;
            // 
            // sl
            // 
            this.sl.HeaderText = "SL";
            this.sl.MinimumWidth = 6;
            this.sl.Name = "sl";
            this.sl.Width = 50;
            // 
            // tt
            // 
            this.tt.HeaderText = "Thành Tiền";
            this.tt.MinimumWidth = 6;
            this.tt.Name = "tt";
            this.tt.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMNC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbTenNuoc);
            this.groupBox1.Controls.Add(this.txtTT);
            this.groupBox1.Controls.Add(this.txtSL);
            this.groupBox1.Controls.Add(this.txtDG);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 257);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // cmbMNC
            // 
            this.cmbMNC.FormattingEnabled = true;
            this.cmbMNC.Location = new System.Drawing.Point(123, 34);
            this.cmbMNC.Name = "cmbMNC";
            this.cmbMNC.Size = new System.Drawing.Size(100, 24);
            this.cmbMNC.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mã nước";
            // 
            // cmbTenNuoc
            // 
            this.cmbTenNuoc.FormattingEnabled = true;
            this.cmbTenNuoc.Location = new System.Drawing.Point(123, 82);
            this.cmbTenNuoc.Name = "cmbTenNuoc";
            this.cmbTenNuoc.Size = new System.Drawing.Size(157, 24);
            this.cmbTenNuoc.TabIndex = 2;
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(123, 216);
            this.txtTT.Name = "txtTT";
            this.txtTT.ReadOnly = true;
            this.txtTT.Size = new System.Drawing.Size(100, 22);
            this.txtTT.TabIndex = 1;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(123, 170);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(100, 22);
            this.txtSL.TabIndex = 1;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // txtDG
            // 
            this.txtDG.Location = new System.Drawing.Point(123, 127);
            this.txtDG.Name = "txtDG";
            this.txtDG.ReadOnly = true;
            this.txtDG.Size = new System.Drawing.Size(100, 22);
            this.txtDG.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thành tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên nước";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(422, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "ĐẶT NƯỚC UỐNG";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(178, 422);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 31);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(178, 459);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 31);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(178, 496);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 30);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(861, 543);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tổng Tiền";
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(936, 540);
            this.txtTong.Name = "txtTong";
            this.txtTong.ReadOnly = true;
            this.txtTong.Size = new System.Drawing.Size(156, 22);
            this.txtTong.TabIndex = 8;
            this.txtTong.TextChanged += new System.EventHandler(this.txtTong_TextChanged);
            // 
            // btnCTHD
            // 
            this.btnCTHD.Location = new System.Drawing.Point(950, 568);
            this.btnCTHD.Name = "btnCTHD";
            this.btnCTHD.Size = new System.Drawing.Size(142, 31);
            this.btnCTHD.TabIndex = 9;
            this.btnCTHD.Text = "Hóa đơn";
            this.btnCTHD.UseVisualStyleBackColor = true;
            this.btnCTHD.Click += new System.EventHandler(this.btnCTHD_Click);
            // 
            // btnXoaDL
            // 
            this.btnXoaDL.Location = new System.Drawing.Point(824, 568);
            this.btnXoaDL.Name = "btnXoaDL";
            this.btnXoaDL.Size = new System.Drawing.Size(120, 31);
            this.btnXoaDL.TabIndex = 10;
            this.btnXoaDL.Text = "Xóa dữ liệu";
            this.btnXoaDL.UseVisualStyleBackColor = true;
            this.btnXoaDL.Click += new System.EventHandler(this.btnXoaDL_Click);
            // 
            // frmMNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 604);
            this.Controls.Add(this.btnXoaDL);
            this.Controls.Add(this.btnCTHD);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvQLNC);
            this.Controls.Add(this.txtCS);
            this.Name = "frmMNC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mua nước";
            this.Load += new System.EventHandler(this.frmMNC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtCS;
        private System.Windows.Forms.DataGridView dgvQLNC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTenNuoc;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Button btnCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMNC;
        private System.Windows.Forms.Button btnXoaDL;
    }
}

