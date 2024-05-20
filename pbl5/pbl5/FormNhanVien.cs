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
    public partial class FormNhanVien : Form
    {
        ServerAccess serverAccess = new ServerAccess();
        
        private User user { get; set; }

        public FormNhanVien(User user)
        {
            this.user = user;
            InitializeComponent();
        }
        
        public FormNhanVien()
        {
            InitializeComponent();
        }
        
        //public event EventHandler Logout;
        private void lbLogOut_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            this.Hide();
            f.Show();

        }

        private void lkAddTK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormNhapThongTin f = new FormNhapThongTin(user);
            f.Show();
            this.Hide();
        }

        private async void FormNhanVien_Load(object sender, EventArgs e)
        {
            if (user == null)
            {
                //user = await serverAccess.GetUserById(ID);
            }
            // lay du lieu user //dt.TaiKhoans.SingleOrDefault(n => n.id == ID);
            lbUser.Text = user.fullname.ToString();
            groupBox2.Hide();
            dataGridView1.Show();

        }

        private void FormNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async void lkInfor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.Hide();
            groupBox2.Show();
            //User user = await serverAccess.GetUserById(ID);//dt.TaiKhoans.SingleOrDefault(n => n.id == ID);
            lbUser.Text = user.fullname;
            lbID.Text = user.UserID.ToString();
            lbTen.Text = user.fullname;
            lbCCCD.Text = user.cccd;
            lbDiaChi.Text = user.Adress;
            lbSDT.Text = user.PHONE;
            lbEmail.Text = user.Email;
            DateTime dat = user.BIRTHDAY.Value;
            lbDate.Text = dat.ToString("dd/MM/yyyy");

            lkInfor.LinkColor = Color.Purple;
        }

        private void linkDoiMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoiMatKhau f = new DoiMatKhau(user);
            f.Show();
            this.Hide();
        }

        private void lkCheck_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckLoiViPham f = new CheckLoiViPham(user);
            f.Show();
            this.Hide();
        }

        private async void llbHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.Show();
            groupBox2.Hide();
            List<History> lstHistory = await serverAccess.GetHistoryFromTable(); 

            dataGridView1.DataSource = lstHistory.Where(n=>n.UserID == user.UserID).ToList();

            llbHistory.LinkColor = Color.Purple;
           
            lkInfor.LinkColor = Color.Blue;
        }
    }
}
