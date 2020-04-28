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
    public partial class ChangePassword : Form
    {
        string User;
        
        public ChangePassword(string user)
        {
            User = user;
            InitializeComponent();
        }
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            nguoiDung nguoidung = new nguoiDung { password_moi = textBoxNewPassword.Text, password_cu = TextBoxOldPassword.Text,username = User};
            if (nguoidung.checkOldPassword(User,TextBoxOldPassword.Text))
            {
                if (textBoxConfirmPassword.Text == textBoxNewPassword.Text)
                {
                    if (nguoidung.checkNewPassword(textBoxNewPassword.Text))
                    {
                        if(nguoidung.changePassword())
                        {
                            MessageBox.Show("Change pasword seccess");
                        }
                        else
                        {
                            MessageBox.Show("Change pasword fail");
                        }
                    }
                    else
                    {
                        MessageBox.Show("same password as last time");
                    }
                }
                else
                {
                    MessageBox.Show("Confirm again password");
                }
            }
            else
            {
                MessageBox.Show("Old password is incorrect");
            }
            
        }
    }
}
