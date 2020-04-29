namespace PhanQuyen
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.dataGridViewQuyenLoaiNguoiDung = new System.Windows.Forms.DataGridView();
            this.dataGridViewQuyenNguoiDung = new System.Windows.Forms.DataGridView();
            this.buttonTypeUser = new System.Windows.Forms.Button();
            this.buttonManageUser = new System.Windows.Forms.Button();
            this.buttonQuyen = new System.Windows.Forms.Button();
            this.buttonPhanQuyen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuyenLoaiNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuyenNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.BackColor = System.Drawing.Color.Azure;
            this.buttonChangePassword.Location = new System.Drawing.Point(648, 54);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(152, 83);
            this.buttonChangePassword.TabIndex = 0;
            this.buttonChangePassword.Text = "Change Password";
            this.buttonChangePassword.UseVisualStyleBackColor = false;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // dataGridViewQuyenLoaiNguoiDung
            // 
            this.dataGridViewQuyenLoaiNguoiDung.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewQuyenLoaiNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuyenLoaiNguoiDung.Location = new System.Drawing.Point(76, 54);
            this.dataGridViewQuyenLoaiNguoiDung.Name = "dataGridViewQuyenLoaiNguoiDung";
            this.dataGridViewQuyenLoaiNguoiDung.RowHeadersWidth = 51;
            this.dataGridViewQuyenLoaiNguoiDung.RowTemplate.Height = 24;
            this.dataGridViewQuyenLoaiNguoiDung.Size = new System.Drawing.Size(566, 150);
            this.dataGridViewQuyenLoaiNguoiDung.TabIndex = 1;
            // 
            // dataGridViewQuyenNguoiDung
            // 
            this.dataGridViewQuyenNguoiDung.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewQuyenNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuyenNguoiDung.Location = new System.Drawing.Point(76, 248);
            this.dataGridViewQuyenNguoiDung.Name = "dataGridViewQuyenNguoiDung";
            this.dataGridViewQuyenNguoiDung.RowHeadersWidth = 51;
            this.dataGridViewQuyenNguoiDung.RowTemplate.Height = 24;
            this.dataGridViewQuyenNguoiDung.Size = new System.Drawing.Size(394, 153);
            this.dataGridViewQuyenNguoiDung.TabIndex = 2;
            // 
            // buttonTypeUser
            // 
            this.buttonTypeUser.BackColor = System.Drawing.Color.Azure;
            this.buttonTypeUser.Location = new System.Drawing.Point(227, 12);
            this.buttonTypeUser.Name = "buttonTypeUser";
            this.buttonTypeUser.Size = new System.Drawing.Size(151, 23);
            this.buttonTypeUser.TabIndex = 3;
            this.buttonTypeUser.Text = "Manager Type User";
            this.buttonTypeUser.UseVisualStyleBackColor = false;
            this.buttonTypeUser.Click += new System.EventHandler(this.buttonTypeUser_Click);
            // 
            // buttonManageUser
            // 
            this.buttonManageUser.BackColor = System.Drawing.Color.Azure;
            this.buttonManageUser.Location = new System.Drawing.Point(76, 12);
            this.buttonManageUser.Name = "buttonManageUser";
            this.buttonManageUser.Size = new System.Drawing.Size(122, 23);
            this.buttonManageUser.TabIndex = 4;
            this.buttonManageUser.Text = "Manager user";
            this.buttonManageUser.UseVisualStyleBackColor = false;
            this.buttonManageUser.Click += new System.EventHandler(this.buttonManageUser_Click);
            // 
            // buttonQuyen
            // 
            this.buttonQuyen.BackColor = System.Drawing.Color.Azure;
            this.buttonQuyen.Location = new System.Drawing.Point(409, 12);
            this.buttonQuyen.Name = "buttonQuyen";
            this.buttonQuyen.Size = new System.Drawing.Size(141, 23);
            this.buttonQuyen.TabIndex = 5;
            this.buttonQuyen.Text = "Quyen";
            this.buttonQuyen.UseVisualStyleBackColor = false;
            this.buttonQuyen.Click += new System.EventHandler(this.buttonQuyen_Click);
            // 
            // buttonPhanQuyen
            // 
            this.buttonPhanQuyen.BackColor = System.Drawing.Color.Azure;
            this.buttonPhanQuyen.Location = new System.Drawing.Point(567, 12);
            this.buttonPhanQuyen.Name = "buttonPhanQuyen";
            this.buttonPhanQuyen.Size = new System.Drawing.Size(233, 23);
            this.buttonPhanQuyen.TabIndex = 6;
            this.buttonPhanQuyen.Text = "Phan Quyen User";
            this.buttonPhanQuyen.UseVisualStyleBackColor = false;
            this.buttonPhanQuyen.Click += new System.EventHandler(this.buttonPhanQuyen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPhanQuyen);
            this.Controls.Add(this.buttonQuyen);
            this.Controls.Add(this.buttonManageUser);
            this.Controls.Add(this.buttonTypeUser);
            this.Controls.Add(this.dataGridViewQuyenNguoiDung);
            this.Controls.Add(this.dataGridViewQuyenLoaiNguoiDung);
            this.Controls.Add(this.buttonChangePassword);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuyenLoaiNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuyenNguoiDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.DataGridView dataGridViewQuyenLoaiNguoiDung;
        private System.Windows.Forms.DataGridView dataGridViewQuyenNguoiDung;
        private System.Windows.Forms.Button buttonTypeUser;
        private System.Windows.Forms.Button buttonManageUser;
        private System.Windows.Forms.Button buttonQuyen;
        private System.Windows.Forms.Button buttonPhanQuyen;
    }
}