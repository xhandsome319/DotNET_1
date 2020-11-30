using QuanLyQuanPho.DAO;
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
            string userName = tb_taikhoan.Text;
            string passWord = tb_matkhau.Text;
            if (Login(userName,passWord)) 
            {
                fm_chinh f = new fm_chinh();
                this.Hide();
                f.ShowDialog();
                this.Show(); 
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }
        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void fm_dangnhap_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Resources\\PhoTai.jpg");
            pictureBox2.Image = new Bitmap(Application.StartupPath + "\\Resources\\PhoGa.jpg");
        }
    }
}
