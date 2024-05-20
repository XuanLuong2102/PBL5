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
    public partial class FormNhapThongTin : Form
    {
        ServerAccess serverAccess = new ServerAccess();
        private User user { get; set; }
        private int _ID { get; set; }

        

        public FormNhapThongTin(int id)
        {
            _ID = id;
            InitializeComponent();
            _ID = id;

        }
        public FormNhapThongTin(User user)
        {
            this.user = user;
            InitializeComponent();
        }
        public FormNhapThongTin()
        {
            InitializeComponent();

        }

        private async void FormNhapThongTin_Load(object sender, EventArgs e)
        {
            lbID.Text = user.UserID.ToString();
            //dt.TaiKhoans.SingleOrDefault(n => n.id == _ID);
            if (user.fullname != null) txtName.Text = user.fullname;
            if (user.cccd != null) txtCCCD.Text = user.cccd.ToString();
            if (user.Adress != null) txtDiaChi.Text = user.Adress;
            
            if (user.PHONE != null) txtSDT.Text = user.PHONE;
            if (user.Email != null) txtEmail.Text = user.Email;
            if (user.BIRTHDAY != null) dateTimePicker1.Text = user.BIRTHDAY.ToString();

        }

        private void FormNhapThongTin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            //User user = await serverAccess.GetUserById(_ID);//dt.TaiKhoans.SingleOrDefault(n => n.id == _ID);

                user.fullname = txtName.Text;
                user.cccd = txtCCCD.Text;
                //user.GioiTinh = txtGioiTinh.Text;
                user.PHONE = txtSDT.Text;
                user.Adress = txtDiaChi.Text;
                user.Email = txtEmail.Text;
                user.BIRTHDAY = dateTimePicker1.Value;

                //dt.SaveChanges();

            
            FormNhanVien f = new FormNhanVien(user);
            f.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormNhanVien f = new FormNhanVien(user);
            f.Show();
            this.Hide();
        }
    }
}
