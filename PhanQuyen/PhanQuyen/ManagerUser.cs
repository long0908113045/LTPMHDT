using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanQuyen.Model;

namespace PhanQuyen
{
    public partial class ManagerUser : Form
    {

        public ManagerUser()
        {
            InitializeComponent();
            loadNguoiDung();
        }
        public void loadNguoiDung()
        {
            nguoiDung nguoidung = new nguoiDung();
            loaiNguoiDung loainguoidung = new loaiNguoiDung();
            dataGridViewNguoiDung.DataSource = nguoidung.ShowtableNguoiDung();
            comboBoxLoaiNguoiDung.DataSource = loainguoidung.ShowtableNguoiDung();
            comboBoxLoaiNguoiDung.ValueMember = "id";
            comboBoxLoaiNguoiDung.DisplayMember = "tenLoaiNguoiDung";
        }

        private void dataGridViewNguoiDung_DoubleClick(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridViewNguoiDung.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewNguoiDung.CurrentRow.Cells[1].Value.ToString();
            textBoxUser.Text = dataGridViewNguoiDung.CurrentRow.Cells[2].Value.ToString();
            textBoxPass .Text= dataGridViewNguoiDung.CurrentRow.Cells[3].Value.ToString();
            comboBoxLoaiNguoiDung.Text = dataGridViewNguoiDung.CurrentRow.Cells[5].Value.ToString();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == string.Empty)
                textBoxName.Text = null;
            if (textBoxUser.Text == string.Empty)
                textBoxUser.Text = null;
            if (textBoxPass.Text == string.Empty)
                textBoxPass.Text = null;
            if (comboBoxLoaiNguoiDung.Text == string.Empty)
                comboBoxLoaiNguoiDung.Text = null;

            nguoiDung nguoidung = new nguoiDung { ho_va_ten = textBoxName.Text,username = textBoxUser.Text,password_moi = textBoxPass.Text,loaiNguoiDung_id = Convert.ToInt32(comboBoxLoaiNguoiDung.SelectedValue)};

            
            if (nguoidung.Insert())
                {
                    loadNguoiDung();
                }
                else
                {
                    MessageBox.Show("Fail");
                }        
        }
    }
}
