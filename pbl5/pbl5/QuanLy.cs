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
    public partial class QuanLy : Form
    {
        ServerAccess serverAccess = new ServerAccess();

        private User user {  get; set; }
        private int ID {  get; set; }
        public QuanLy()
        {
            InitializeComponent();
        }

        private void lbLogOut_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            this.Hide();
            f.Show();
        }

        private void QuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lkAddTK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUser f = new AddUser();
            this.Hide();
            f.Show();
        }

        private void lkCheck_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckViPhamAdmin f = new CheckViPhamAdmin();
            this.Hide(); f.Show();
        }

        private async void LkDSUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.Show();
            groupBox2.Hide();
            List<User> lstTaiKhoan = await serverAccess.GetUserFromTable(); //dt.TaiKhoans.ToList();
            
            dataGridView1.DataSource = lstTaiKhoan;

            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            //dataGridView1.Columns[11].Visible = false;
            dataGridView1.Rows[4].Visible = false;
            

            dataGridView1.Columns[0].HeaderText = "ID";
            //dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Tên tài khoản";
            dataGridView1.Columns[9].HeaderText = "Họ và tên";
            dataGridView1.Columns[6].HeaderText = "Ngày sinh";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns[5].HeaderText = "SĐT";
            dataGridView1.Columns[7].HeaderText = "Địa chỉ";
            //dataGridView1.Columns[9].HeaderText = "";


            LkDSUser.LinkColor = Color.Purple;
            lkInfor.LinkColor = Color.Blue;
        }

        private void llbDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDelete f = new FormDelete();
            this.Hide(); f.Show();
        }


        private void lkInfor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lkInfor.LinkColor = Color.Purple;
            LkDSUser.LinkColor = Color.Blue;
            dataGridView1.Hide();
            groupBox2.Show();
            lbID.Hide();
            lbTen.Hide();
            lbCCCD.Hide();
            lbDiaChi.Hide();
            lbGioiTinh.Hide();
            lbSDT.Hide();
            lbEmail.Hide();
            lbDate.Hide();
            lbErr.Hide();

            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            llbXoaTK.Hide();
            llbCheckk.Hide();

        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            groupBox2.Hide();
        }



        private async void btnSearch_Click_1(object sender, EventArgs e)
        {
            int ID = int.Parse(txtSearch.Text);
            user = await serverAccess.GetUserById(ID); //dt.TaiKhoans.SingleOrDefault(n => n.id == ID);
            if (user != null)
            {
                
                lbID.Show();
                lbTen.Show();
                lbCCCD.Show();
                lbDiaChi.Show();
                lbGioiTinh.Show();
                lbSDT.Show();
                lbEmail.Show();
                lbDate.Show();
                lbErr.Hide();

                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                label10.Show();

                label11.Show();
                txtSearch.Show();
                btnSearch.Show();

                llbXoaTK.Show();
                llbCheckk.Show();

                txtSearch.Text = user.UserID.ToString();
                lbTen.Text = user.fullname;
                lbID.Text = user.UserID.ToString();
                lbCCCD.Text = user.cccd.ToString();
                lbEmail.Text = user.Email;
                lbDiaChi.Text = user.Adress;
                DateTime dat = user.BIRTHDAY.Value;
                lbDate.Text = dat.ToString("dd/MM/yyyy");
                lbSDT.Text = user.PHONE;
                


            }
            else lbErr.Show();
        }

        private void llbXoaTK_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDelete f = new FormDelete(user);
            f.Show();
            this.Hide();
        }

        private void llbCheckk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckViPhamAdmin f = new CheckViPhamAdmin(user);
            this.Hide();
            f.Show();
        }

        private void llbDoiMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoiMatKhau f = new DoiMatKhau();
            f.Show();
            this.Hide();
        }

        private async void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.Show();
            groupBox2.Hide();
            List<Action> allActions = await serverAccess.GetActionFromTable();
            dataGridView1.DataSource  = allActions;
        }
    }
}
