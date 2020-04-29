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
            quyen Quyen = new quyen();
            comboBoxLoaiNguoiDung.DataSource = loainguoidung.ShowtableNguoiDung();
            comboBoxLoaiNguoiDung.DisplayMember = "tenLoaiNguoiDung";
            comboBoxLoaiNguoiDung.ValueMember = "id";

            comboBoxNhomQuyen.DataSource = q.ShowtableQuyen();
            comboBoxNhomQuyen.DisplayMember = "tenQuyen";
            comboBoxNhomQuyen.ValueMember = "id";

            comboBoxUser.DataSource = nguoidung.ShowtableNguoiDung();
            comboBoxUser.DisplayMember = "username";
            comboBoxUser.ValueMember = "id";

            comboBoxQuyen.DataSource = Quyen.ShowtableQuyen();
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
            try
            {
                if (IvaildCanhan())
                {
                    nguoiDung_Quyen nguoidung_quyen = new nguoiDung_Quyen { nguoiDung_id = Convert.ToInt32(comboBoxUser.SelectedValue), quyen_id = Convert.ToInt32(comboBoxQuyen.SelectedValue) };
                    if (nguoidung_quyen.insert())
                    {
                        loaddata();
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("ban chua dien du thong tin");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL exception !\n" + ex.Message);
            }
        }

        private void buttonIsertLoai_Click(object sender, EventArgs e)
        {
            try
            {
                if (IvaildNhom())
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
                else
                {
                    MessageBox.Show("ban chua dien du thong tin");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL exception !\n" + ex.Message);
            }
        }

        

        private void buttonDeleteCaNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (IvaildCanhan())
                {
                    nguoiDung_Quyen nguoidung_quyen = new nguoiDung_Quyen { nguoiDung_id = Convert.ToInt32(comboBoxUser.SelectedValue), quyen_id = Convert.ToInt32(comboBoxQuyen.SelectedValue) };
                    if (nguoidung_quyen.delete())
                    {
                        loaddata();
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("ban chua dien du thong tin");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL exception !\n" + ex.Message);
            }
        }

        
        

        private void buttonDeleteLoai_Click(object sender, EventArgs e)
        {
            try
            {
                if (IvaildNhom())
                {
                    loaiNguoiDung_Quyen loainguoidung_quyen = new loaiNguoiDung_Quyen { loaiNguoiDung_id = Convert.ToInt32(comboBoxLoaiNguoiDung.SelectedValue), quyen_id = Convert.ToInt32(comboBoxNhomQuyen.SelectedValue) };
                    if (loainguoidung_quyen.delete())
                    {
                        loaddata();
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("ban chua dien du thong tin");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL exception !\n" + ex.Message);
            }
        }
        public bool IvaildCanhan()
        {
            if( comboBoxUser.Text == string.Empty || comboBoxQuyen.Text == string.Empty)
            {
                return false;
            }
            else return true;
        }
        public bool IvaildNhom()
        {
            if (comboBoxLoaiNguoiDung.Text == string.Empty || comboBoxNhomQuyen.Text == string.Empty)
            {
                return false;
            }
            else return true;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                comboBoxUser.SelectedValue = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                comboBoxQuyen.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();               
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL exception !\n" + ex.Message);
            }
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                comboBoxLoaiNguoiDung.SelectedValue = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                comboBoxNhomQuyen.SelectedValue = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL exception !\n" + ex.Message);
            }
        }
    }
}
