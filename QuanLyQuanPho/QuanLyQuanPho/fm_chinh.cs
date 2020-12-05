using QuanLyQuanPho.DAO;
using QuanLyQuanPho.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanPho
{
    public partial class fm_chinh : Form
    {
        public fm_chinh()
        {
            InitializeComponent();
            LoadTable();
        }

        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;

                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.White;
                        break;
                    default:
                        btn.BackColor = Color.Brown;
                        break;
                }

                flp_banan.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            lsv_hoadon.Items.Clear();
            List<QuanLyQuanPho.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (QuanLyQuanPho.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsv_hoadon.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            tb_thanhtien.Text = totalPrice.ToString("c",culture);
        }

        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            ShowBill(tableID);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm_nhanvien f = new fm_nhanvien();
            f.ShowDialog();
        }

    }
}
