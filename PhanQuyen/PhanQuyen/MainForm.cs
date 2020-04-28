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
    public partial class MainForm : Form
    {
        
        private string User;
        public MainForm (string user)
        {
            User = user;
            InitializeComponent();
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword(User);
            change.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            nguoiDung nguoidung = new nguoiDung();

            dataGridViewQuyenLoaiNguoiDung.DataSource = nguoidung.QuyenLoaiNguoiDung(User);
            dataGridViewQuyenNguoiDung.DataSource = nguoidung.QuyenNguoiDung(User);
        }

        private void buttonManageUser_Click(object sender, EventArgs e)
        {
            ManagerUser M = new ManagerUser();
            M.Show();
        }

        private void buttonTypeUser_Click(object sender, EventArgs e)
        {
            QuanLyLoaiNguoiDung Q = new QuanLyLoaiNguoiDung();
            Q.Show();
        }

        private void buttonQuyen_Click(object sender, EventArgs e)
        {
            Quyen Q = new Quyen();
            Q.Show();
        }

        private void buttonPhanQuyen_Click(object sender, EventArgs e)
        {
            PhanQuyenNguoiDung P = new PhanQuyenNguoiDung();
            P.Show();
        }
    }
}
