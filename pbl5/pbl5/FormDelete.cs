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
    public partial class FormDelete : Form
    {
        ServerAccess serverAccess = new ServerAccess();
        private User user { get; set; }
        
        public FormDelete(User user)
        {
            this.user = user;
            InitializeComponent();
        }
        public FormDelete()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            
                int ID = int.Parse(txtSearch.Text);
                User user = await serverAccess.GetUserById(ID); //dt.TaiKhoans.SingleOrDefault(n => n.id == ID);
                if (user != null)
                {
                    label2.Show();
                    label4.Show();
                    label8.Show();
                    label10.Show();
                    label12.Show();
                    label14.Show();     
                    lbUser.Show();
                    lbSDT.Show();
                    lbDiaChi.Show();
                    lbCCCD.Show();
                    lbDate.Show();
                    lbEmail.Show();

                    label6.Hide();

                    lbUser.Text = user.fullname;
                    lbCCCD.Text = user.cccd;
                    lbEmail.Text = user.Email;
                    lbDiaChi.Text = user.Adress;
                    DateTime dat = user.BIRTHDAY.Value;
                    lbDate.Text = dat.ToString("dd/MM/yyyy");
                    lbSDT.Text = user.PHONE;
                }
            
            
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            QuanLy f = new QuanLy();
            f.Show();
            this.Hide();
        }

        private void FormDelete_Load(object sender, EventArgs e)
        {
            if (user == null)
            {

                label2.Hide();
                label3.Hide();
                label4.Hide();
                label8.Hide();
                label10.Hide();
                label12.Hide();
                label14.Hide();
                lbUser.Hide();
                lbSDT.Hide();
                lbDiaChi.Hide();
                lbCCCD.Hide();
                lbDate.Hide();
                lbEmail.Hide();
            }
            else
            {
                // dt.TaiKhoans.SingleOrDefault(n => n.id == ID);

                label6.Hide();
                txtSearch.Hide();
                btnSearch.Hide();

                label3.Text = user.UserID.ToString();
                lbUser.Text = user.fullname;
                lbCCCD.Text = user.cccd;
                lbEmail.Text = user.Email;
                lbDiaChi.Text = user.Adress;
                DateTime dat = user.BIRTHDAY.Value;
                lbDate.Text = dat.ToString("dd/MM/yyyy");
                lbSDT.Text = user.PHONE;

            }
        }

        private void FormDelete_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            User taiKhoan = new User();// dt.TaiKhoans.SingleOrDefault(n => n.id == ID);
            //dt.TaiKhoans.Remove(taiKhoan);
            //dt.SaveChanges();
            MessageBox.Show("Xóa tài khoản thành công!");
            QuanLy f = new QuanLy();
            this.Hide();
            f.Show();
        }
    }
}
