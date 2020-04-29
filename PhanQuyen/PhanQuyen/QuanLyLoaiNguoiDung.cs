using PhanQuyen.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanQuyen
{
    public partial class QuanLyLoaiNguoiDung : Form
    {
        public QuanLyLoaiNguoiDung()
        {
            InitializeComponent();
        }

        private void QuanLyLoaiNguoiDung_Load(object sender, EventArgs e)
        {
            loadLoaiNguoiDung();
        }
        public void loadLoaiNguoiDung()
        {
            loaiNguoiDung loainguoidung = new loaiNguoiDung();

            dataGridViewLoaiNguoiDung.DataSource = loainguoidung.ShowtableNguoiDung();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == string.Empty)
                textBoxName.Text = null;
            if (textBoxMota.Text == string.Empty)
                textBoxMota.Text = null;
            loaiNguoiDung loainguoidung = new loaiNguoiDung {tenLoaiNguoiDung = textBoxName.Text,moTa = textBoxMota.Text };
            
            if(loainguoidung.Insert())
            {
                loadLoaiNguoiDung();
            }
            else
            {
                MessageBox.Show("fail");
            }

        }

        private void dataGridViewLoaiNguoiDung_DoubleClick(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridViewLoaiNguoiDung.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewLoaiNguoiDung.CurrentRow.Cells[1].Value.ToString();
            textBoxMota.Text = dataGridViewLoaiNguoiDung.CurrentRow.Cells[2].Value.ToString();           
        }
    }
}
