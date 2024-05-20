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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = txtUsername.Text;
            user.Password = txtPass.Text;
            user.fullname = txtTen.Text;
            user.PHONE = txtSDT.Text;
            user.Loai = false;
            //dt.TaiKhoans.Add(user);
            //dt.SaveChanges();
            MessageBox.Show("Thêm tài khoản mới thành công");
            QuanLy f = new QuanLy();
            this.Hide();
            f.Show();
        }

        private void AddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            QuanLy f = new QuanLy();
            this.Hide();
            f.Show();
        }
    }
}
