using PhanQuyen.Model;
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
            try
            {


                loaiNguoiDung loainguoidung = new loaiNguoiDung();

                dataGridViewLoaiNguoiDung.DataSource = loainguoidung.ShowtableNguoiDung();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL exception !\n" + ex.Message);
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {try
            {
                if (Ivaild())
                {
                    loaiNguoiDung loainguoidung = new loaiNguoiDung { tenLoaiNguoiDung = textBoxName.Text, moTa = textBoxMota.Text };
                    if (loainguoidung.Insert())
                    {
                        loadLoaiNguoiDung();
                    }
                    else
                    {
                        MessageBox.Show("fail");
                    }
                }
                else
                {
                    MessageBox.Show("Dien Du Thong Tin");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL exception !\n" + ex.Message);
            }

        }

        private void dataGridViewLoaiNguoiDung_DoubleClick(object sender, EventArgs e)
        {   try
            {


                textBoxID.Text = dataGridViewLoaiNguoiDung.CurrentRow.Cells[0].Value.ToString();
                textBoxName.Text = dataGridViewLoaiNguoiDung.CurrentRow.Cells[1].Value.ToString();
                textBoxMota.Text = dataGridViewLoaiNguoiDung.CurrentRow.Cells[2].Value.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL exception !\n" + ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Ivaild())
                {
                    loaiNguoiDung loainguoidung = new loaiNguoiDung { id = Convert.ToInt32(textBoxID.Text), tenLoaiNguoiDung = textBoxName.Text, moTa = textBoxMota.Text };
                    if (loainguoidung.update())
                    {
                        loadLoaiNguoiDung();
                    }
                    else
                    {
                        MessageBox.Show("fail");
                    }
                }
                else
                {
                    MessageBox.Show("Dien Du Thong Tin");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL exception !\n" + ex.Message);
            }
        }
        public bool Ivaild()
        {
            if (textBoxName.Text == string.Empty || textBoxMota.Text == string.Empty || textBoxID.Text == string.Empty)
            {
                return false;
            }
            else return true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxID.Text != string.Empty)
                {
                    loaiNguoiDung loainguoidung = new loaiNguoiDung { id = Convert.ToInt32(textBoxID.Text) };
                    if (loainguoidung.delete())
                    {
                        loadLoaiNguoiDung();
                    }
                    else
                    {
                        MessageBox.Show("fail");
                    }
                }
                else
                {
                    MessageBox.Show("Dien Du Thong Tin");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL exception !\n" + ex.Message);
            }
        }
    }
}
