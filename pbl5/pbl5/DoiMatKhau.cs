using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl5
{
    public partial class DoiMatKhau : Form
    {
        //dataEntities dt = new dataEntities();
        ServerAccess serverAccess = new ServerAccess();

        
        private User user { get; set; }

        public DoiMatKhau(User user)
        {
            this.user = user;
            InitializeComponent();
        }
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btHide1_Click(object sender, EventArgs e)
        {

        }

        private void btnHide2_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                btnEye2.BringToFront();
                textBox2.PasswordChar = '*';
            }
        }
        private void btnHide3_Click(object sender, EventArgs e)
        {
            if (textBox3.PasswordChar == '\0')
            {
                btnEye3.BringToFront();
                textBox3.PasswordChar = '*';
            }
        }
        private void btnEye1_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '*')
            {
                btHide1.BringToFront();
                textBox1.PasswordChar = '\0';
            }
        }

        private void btnEye2_Click_1(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                btnHide2.BringToFront();
                textBox2.PasswordChar = '\0';
            }
        }
        private void btnEye3_Click(object sender, EventArgs e)
        {
            if (textBox3.PasswordChar == '*')
            {
                btnHide3.BringToFront();
                textBox3.PasswordChar = '\0';
            }
        }

        private void DoiMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            if(user != null)
            {
                //User taiKhoan = new User();// dt.TaiKhoans.SingleOrDefault(n => n.id == ID);
                if (user != null)
                {
                    var pass1 = textBox1.Text;
                    var pass2 = textBox2.Text;
                    var pass3 = textBox3.Text;

                    if (pass2 == pass3)
                    {
                        if (user.Password == pass1)
                        {
                            user.Password = pass2;
                            MessageBox.Show("Đổi mật khẩu thành công");
                        }
                        else
                        {
                            MessageBox.Show("Nhập sai mật khẩu cũ!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không trùng khớp!");
                    }
                }
                //dt.SaveChanges();
                FormNhanVien f = new FormNhanVien(user);
                f.Show();
                this.Hide();
            }
            else
            {
                int _id = int.Parse(txtID.Text);
                User _user = await serverAccess.GetUserById(_id);// dt.TaiKhoans.SingleOrDefault(n => n.id == _id);
                string s = txtPass.Text;
                if ( s!= "")
                {
                    _user.Password = s;
                    MessageBox.Show("Đổi mật khẩu thành công");
                    //dt.SaveChanges();
                }
                QuanLy f = new QuanLy();
                f.Show();
                this.Hide();
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(user == null)
            {
                QuanLy f = new QuanLy();
                f.Show();
                this.Hide();
            }
            else
            {
                FormNhanVien f = new FormNhanVien(user);
                f.Show();
                this.Hide();
            }
            
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            if (user == null)
            {
                groupBox2.Hide();
                groupBox1.Show();
                lbTen.Hide();
                lbTens.Hide();
                lbTK.Hide();
                lbTKs.Hide();
                lbPassword.Hide();
                lbPass.Hide();
                lbNewPass.Hide();
                txtPass.Hide();
                lbERR.Hide();
                btnOK.Hide();
            }
            else
            {
                groupBox1.Hide();
                groupBox2.Show();
                
            }

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            int _id = int.Parse(txtID.Text);
            User user = await serverAccess.GetUserById(_id);// dt.TaiKhoans.SingleOrDefault(n => n.id == _id);
            if (user != null)
            {

                lbTen.Show();
                lbTens.Show();
                lbTK.Show();
                lbTKs.Show();
                lbPassword.Show();
                lbPass.Show();
                lbNewPass.Show();
                txtPass.Show();
                btnOK.Show();

                lbTens.Text = user.fullname;
                lbTKs.Text = user.Username;
                lbPassword.Text = user.Password;              
               
            }
            else
            {
                lbERR.Show();
            }
        }
    }
}
