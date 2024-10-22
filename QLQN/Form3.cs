using QLQN.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQN
{
    public partial class frmCS : Form
    {
        public frmCS()
        {
            InitializeComponent();            
        }

        private void frmCS_Load(object sender, EventArgs e)
        {
            QLQNDB db = new QLQNDB();
            var nuoc = db.Nuocs.ToList();
            dgvDSNC.Rows.Clear();
            foreach ( var n in nuoc)
            {
                int newRow = dgvDSNC.Rows.Add();
                dgvDSNC.Rows[newRow].Cells["manuoc"].Value = n.MaNC;
                dgvDSNC.Rows[newRow].Cells["tennuoc"].Value = n.TenNC;
                dgvDSNC.Rows[newRow].Cells["dg"].Value = n.Gia;
                dgvDSNC.Rows[newRow].Cells["maloai"].Value = n.Loai.MaLoai;
            }
            cmbMaLoai.DataSource = db.Loais.ToList();
            cmbMaLoai.DisplayMember = "MaLoai";
            cmbMaLoai.ValueMember = "TenLoai";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                QLQNDB db = new QLQNDB();
                Nuoc nuoc = new Nuoc();
                nuoc.MaNC = txtMaNC.Text;
                nuoc.TenNC = txtTenNC.Text;
                nuoc.Gia = int.Parse(txtGia.Text);
                var chonLoai = (cmbMaLoai.SelectedItem as Loai);
                nuoc.MaLoai = chonLoai.MaLoai;
                db.Nuocs.Add(nuoc);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công!!!");
                frmCS_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            QLQNDB db = new QLQNDB();
            var tim = db.Nuocs.FirstOrDefault(p => p.MaNC == txtMaNC.Text);
            if(tim != null)
            {
                tim.TenNC = txtTenNC.Text;
                tim.Gia = int.Parse(txtGia.Text);
                var chonLoai = (cmbMaLoai.SelectedItem as Loai);
                tim.MaLoai = chonLoai.MaLoai;
                db.SaveChanges();
                MessageBox.Show("Chỉnh sửa thành công!!!");
                frmCS_Load(sender, e);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            QLQNDB db = new QLQNDB();
            var tim = db.Nuocs.FirstOrDefault(p => p.MaNC == txtMaNC.Text);
            if (tim != null)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa không!!!", "YES/NO", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    db.Nuocs.Remove(tim);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công!!!");
                    frmCS_Load(sender, e);
                }              
            }
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát!!!", "YES/NO", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                frmMNC f1 = new frmMNC();
                f1.ShowDialog();
                this.Close();
            }
        }

        private void dgvDSNC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNC.Text = dgvDSNC.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenNC.Text = dgvDSNC.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtGia.Text = dgvDSNC.Rows[e.RowIndex].Cells[2].Value.ToString(); ;
            cmbMaLoai.Text = dgvDSNC.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
