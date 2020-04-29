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
            quyen quyen = new quyen();

            dataGridViewQuyen.DataSource = quyen.ShowtableQuyen();
        }

        private void dataGridViewQuyen_DoubleClick(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridViewQuyen.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewQuyen.CurrentRow.Cells[1].Value.ToString();
            textBoxMoTa.Text = dataGridViewQuyen.CurrentRow.Cells[2].Value.ToString();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == string.Empty)
                textBoxName.Text = null;
            if (textBoxMoTa.Text == string.Empty)
                textBoxMoTa.Text = null;
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
    }
}
