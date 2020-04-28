using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanQuyen.Model;

namespace PhanQuyen
{
    public partial class PhanQuyenNguoiDung : Form
    {
        public PhanQuyenNguoiDung()
        {
            InitializeComponent();
        }

        private void PhanQuyenNguoiDung_Load(object sender, EventArgs e)
        {
            loadcombox();
            loaddata();
        }
        public void loadcombox()
        {
            loaiNguoiDung loainguoidung = new loaiNguoiDung();
            nguoiDung nguoidung = new nguoiDung();
            quyen q = new quyen(); 
            comboBoxLoaiNguoiDung.DataSource = loainguoidung.ShowtableNguoiDung();
            comboBoxLoaiNguoiDung.DisplayMember = "tenLoaiNguoiDung";
            comboBoxLoaiNguoiDung.ValueMember = "id";

            comboBoxNhomQuyen.DataSource = q.ShowtableQuyen();
            comboBoxNhomQuyen.DisplayMember = "tenQuyen";
            comboBoxNhomQuyen.ValueMember = "id";

            comboBoxUser.DataSource = nguoidung.ShowtableNguoiDung();
            comboBoxUser.DisplayMember = "username";
            comboBoxUser.ValueMember = "id";

            comboBoxQuyen.DataSource = q.ShowtableQuyen();
            comboBoxQuyen.DisplayMember = "tenQuyen";
            comboBoxQuyen.ValueMember = "id";

        }
        public void loaddata()
        {
            nguoiDung_Quyen n = new nguoiDung_Quyen();
            loaiNguoiDung_Quyen l = new loaiNguoiDung_Quyen();
            dataGridView1.DataSource = n.ShowtableNguoiDung_Quyen();
            dataGridView2.DataSource = l.ShowtableLoaiNguoiDung_Quyen();
        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            nguoiDung_Quyen nguoidung_quyen = new nguoiDung_Quyen { nguoiDung_id = Convert.ToInt32(comboBoxUser.SelectedValue),quyen_id = Convert.ToInt32(comboBoxQuyen.SelectedValue) };
            if(nguoidung_quyen.insert())
            {
                loaddata();
            }
            else
            {

            }
        }

        private void buttonIsertLoai_Click(object sender, EventArgs e)
        {
            loaiNguoiDung_Quyen loainguoidung_quyen = new loaiNguoiDung_Quyen { loaiNguoiDung_id = Convert.ToInt32(comboBoxLoaiNguoiDung.SelectedValue), quyen_id = Convert.ToInt32(comboBoxNhomQuyen.SelectedValue) };
            if (loainguoidung_quyen.insert())
            {
                loaddata();
            }
            else
            {

            }
        }
    }
}
