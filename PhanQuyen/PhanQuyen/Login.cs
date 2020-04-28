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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }           
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            nguoiDung nguoidung = new nguoiDung { username = textBoxUserName.Text, password_moi = textBoxPassWord.Text };
            if(nguoidung.checkUserAndPass()==true)
            {
                MessageBox.Show("login success");
                string User = textBoxUserName.Text;
                MainForm main = new MainForm(User);
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("fall");
            }
        }
    }
}
