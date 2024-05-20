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
    public partial class FormDangNhap : Form
    {
        ServerAccess serverAccess = new ServerAccess();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btHide_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '\0')
            {
                btEye.BringToFront();
                txtPass.PasswordChar = '*';
            }
        }

        private void btEye_Click_1(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                btHide.BringToFront();
                txtPass.PasswordChar = '\0';
            }
        }

        private async void btLogin_Click(object sender, EventArgs e)
        {
            string taikhoan = txtUser.Text;
            string matkhau = txtPass.Text;
            
            User user = await serverAccess.GetUserByUsername(taikhoan);//new User();//////// lay du lieu dang nhap
            if(user.Password != matkhau)
            {
                user = null;
            }
            if (user != null)
            {

                bool quyen = user.Loai.Value;
                if (quyen )
                {
                    QuanLy f = new QuanLy();
                    f.Show();
                    this.Hide();
                    
                }
                else
                {
                    if (user.fullname != null && user.cccd != null)
                    {
                        
           
                        FormNhanVien f = new FormNhanVien(user);
                        f.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        
                        //dt.SaveChanges();
                        FormNhapThongTin f = new FormNhapThongTin(user);
                        f.Show();
                        this.Hide();

                    }
                }

            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
            }
                
            
        }

  

        private void F_Logout(object sender, EventArgs e)
        {
            
            this.Show();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            
        }

       
        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

