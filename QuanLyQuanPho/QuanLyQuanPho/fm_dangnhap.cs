using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanPho
{
    public partial class fm_dangnhap : Form
    {
        public fm_dangnhap()
        {
            InitializeComponent();
        }

        private void fm_dangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát Chương Trình?","Thông Báo !",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK ) 
                e.Cancel = true;
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            fm_chinh Chinh = new fm_chinh();
            this.Hide();
            Chinh.ShowDialog();
            this.Show();
        }

        private void fm_dangnhap_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Resources\\PhoTai.jpg");
            pictureBox2.Image = new Bitmap(Application.StartupPath + "\\Resources\\PhoGa.jpg");
        }
    }
}
