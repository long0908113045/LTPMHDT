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
    public partial class Quyen : Form
    {
        public Quyen()
        {
            InitializeComponent();
        }

        private void Quyen_Load(object sender, EventArgs e)
        {
            loadQuyen();
        }
        public void loadQuyen()
        {
            try
            {
                quyen quyen = new quyen();

                dataGridViewQuyen.DataSource = quyen.ShowtableQuyen();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL exception !\n" + ex.Message);
            }
        }

        private void dataGridViewQuyen_DoubleClick(object sender, EventArgs e)
        {   try
            {
                textBoxID.Text = dataGridViewQuyen.CurrentRow.Cells[0].Value.ToString();
                textBoxName.Text = dataGridViewQuyen.CurrentRow.Cells[1].Value.ToString();
                textBoxMoTa.Text = dataGridViewQuyen.CurrentRow.Cells[2].Value.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL exception !\n" + ex.Message);
            }
        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (Ivaild())
                {
                    quyen q = new quyen { tenQuyen = textBoxName.Text, moTa = textBoxMoTa.Text };

                    if (q.Insert())
                    {
                        loadQuyen();
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Ivaild())
                {
                    quyen q = new quyen { id = Convert.ToInt32(textBoxID.Text), tenQuyen = textBoxName.Text, moTa = textBoxMoTa.Text };

                    if (q.update())
                    {
                        loadQuyen();
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
            if (textBoxName.Text == string.Empty || textBoxMoTa.Text == string.Empty||textBoxID.Text==string.Empty)
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
                    quyen q = new quyen { id = Convert.ToInt32(textBoxID.Text) };

                    if (q.delete())
                    {
                        loadQuyen();
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
