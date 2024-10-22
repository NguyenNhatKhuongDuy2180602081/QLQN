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
    public partial class frmDN : Form
    {
        public frmDN()
        {
            InitializeComponent();

        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTK.Text;
            string matKhau = txtMK.Text;
            if(taiKhoan == "Mng01" && matKhau == "123456" || taiKhoan == "Mng02" && matKhau == "654321")
            {
                this.Hide();
                frmCS f3 = new frmCS();
                f3.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát!!!", "YES/NO", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                this.Hide();
                frmMNC f1 = new frmMNC();
                f1.ShowDialog();
                this.Close();
            }           
        }
    }
}
