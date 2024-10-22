using QLQN.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQN
{
    public partial class frmMNC : Form
    {
        public frmMNC()
        {
            InitializeComponent();
            QLQNDB context = new QLQNDB();
            List<Nuoc> ListNuoc = context.Nuocs.ToList();
            FillCMB(ListNuoc);
            AddBinding();
        }

        private void FillCMB(List<Nuoc> listNuoc)
        {
            this.cmbMNC.DataSource = listNuoc;
            this.cmbMNC.DisplayMember = "MaNC";
            this.cmbMNC.ValueMember = "TenNC";
            this.cmbTenNuoc.DataSource = listNuoc;
            this.cmbTenNuoc.DisplayMember = "TenNC";
            this.cmbTenNuoc.ValueMember = "MaNC";
        }

        private void txtCS_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDN f2 = new frmDN();
            f2.ShowDialog();
            this.Close();
        }
        private int GetSelectedRow(string maNC)
        {
            
            for (int i = 0; i < dgvQLNC.Rows.Count; i++)
            {
                if (dgvQLNC.Rows[i].Cells[0].Value != null)
                    if (dgvQLNC.Rows[i].Cells[0].Value.ToString() == maNC)
                    {
                        return i;
                    }
            }
            return -1;
        }
        private void InsertUpdate(int selectedRow)
        {
            dgvQLNC.Rows[selectedRow].Cells[0].Value = cmbMNC.Text;
            dgvQLNC.Rows[selectedRow].Cells[1].Value = cmbTenNuoc.Text;
            dgvQLNC.Rows[selectedRow].Cells[2].Value = txtDG.Text;
            dgvQLNC.Rows[selectedRow].Cells[3].Value = txtSL.Text;
            dgvQLNC.Rows[selectedRow].Cells[4].Value = txtTT.Text;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(cmbMNC.Text);
                selectedRow = dgvQLNC.Rows.Add();
                InsertUpdate(selectedRow);
                MessageBox.Show("Thêm thành công!!!");
                tongTien(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(cmbMNC.Text);
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa!!!", "YES/NO", MessageBoxButtons.YesNo);
                dgvQLNC.Rows.RemoveAt(selectedRow);
                MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK);
                tongTien(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(cmbMNC.Text);
                InsertUpdate(selectedRow);
                MessageBox.Show("Sửa thành công!!!");
                tongTien(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void AddBinding()
        {
            txtDG.DataBindings.Add(new Binding("Text", cmbMNC.DataSource, "Gia"));
        }

        private void frmMNC_Load(object sender, EventArgs e)
        {
            
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int Number1 = int.Parse(txtDG.Text);
                int Number2 = int.Parse(txtSL.Text);
                int Number3 = Number1 * Number2;
                txtTT.Text = Number3.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Số lượng là số và không được để trống!!");
            }
        }

        private void dgvQLNC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbMNC.Text = dgvQLNC.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbTenNuoc.Text = dgvQLNC.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDG.Text = dgvQLNC.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSL.Text = dgvQLNC.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTT.Text = dgvQLNC.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void txtTong_TextChanged(object sender, EventArgs e)
        {

        }
        public void tongTien(object sender, EventArgs e)
        {
            int sc = dgvQLNC.Rows.Count;
            double tongTien = 0;
            for (int i = 0; i < sc - 1; i++)
            {
                tongTien += double.Parse(dgvQLNC.Rows[i].Cells["tt"].Value.ToString());
            }
            txtTong.Text = tongTien.ToString();
        }

        private void btnCTHD_Click(object sender, EventArgs e)
        {
            var context = new QLQNDB();
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    QLQNDB db = new QLQNDB();
                    ChiTietHoaDon ct = new ChiTietHoaDon();
                    ct.MaNC = cmbMNC.Text;
                    ct.Gia = int.Parse(txtDG.Text);
                    ct.SoLuong = int.Parse(txtSL.Text);
                    ct.TongTien = int.Parse(txtTong.Text);
                    db.ChiTietHoaDons.Add(ct);
                    db.SaveChanges();
                    transaction.Commit();
                }
                catch 
                {
                    MessageBox.Show("Lỗi");
                    transaction.Rollback();
                }
            }
        }

        private void btnXoaDL_Click(object sender, EventArgs e)
        {
            dgvQLNC.Rows.Clear();
            txtTong.Text = "0";
        }
    }
}
