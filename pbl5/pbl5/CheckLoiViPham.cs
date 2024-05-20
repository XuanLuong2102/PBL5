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
    public partial class CheckLoiViPham : Form
    {
        //dataEntities dt = new dataEntities();
        ServerAccess serverAccess = new ServerAccess();
        private int ID { get; set; }
        private User user { get; set; }

        public CheckLoiViPham(User user)
        {
            this.user = user;
            InitializeComponent();
        }
        public CheckLoiViPham(int id)
        {
            this.ID = id;
            InitializeComponent();

        }
        public CheckLoiViPham()
        {
            InitializeComponent();
        }

        private void CheckLoiViPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormNhanVien f = new FormNhanVien(user);
            f.Show();
            this.Hide();
        }

        private async void CheckLoiViPham_Load(object sender, EventArgs e)
        {
            

            if (user != null)
            {
                lbUser.Text = user.fullname.ToString();
                cbMonth.SelectedIndex = 0;
                cbYear.SelectedIndex = 0;
                llbXemChiTiet.Hide();
                llbHide.Hide();
                lbErr.Hide();
                dataGridView1.Hide();   
                cbMonth.SelectedIndex = 0;
                cbYear.SelectedIndex = 0;

                
            }
        }

        private void llbXemChiTiet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.Show();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false; 
           
            dataGridView1.Columns[3].HeaderText = "Lỗi vi phạm";
            llbXemChiTiet.Hide();
            llbHide.Show();
        }

        private void llbHide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llbXemChiTiet.Show();

            llbHide.Hide();
            dataGridView1.Hide();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int month = 0;
            long year = 0;
            if (cbMonth.SelectedIndex != 0)
            {
                string m = cbMonth.SelectedItem.ToString();
                month = Int32.Parse(m);
            }
            if (cbYear.SelectedIndex != 0)
            {
                string y = cbYear.SelectedItem.ToString();
                year = Int32.Parse(y);
            }
            List<Action> allActions = await serverAccess.GetActionFromTable();
            
            if (year != 0)
            {
                if (month == 0)
                {
                    List<Action> data = allActions.Where(n => n.UserID == user.UserID && n.StartTime.Year == year).ToList();//dt.ViPhams.Where(n => n.idUser == ID && n.ngayGio.Value.Year == year).ToList();
                    int sum = data.Count();
                    lbSoViPham.Text = sum.ToString();
                    if (sum > 0)
                    {
                        dataGridView1.DataSource = data;
                        llbXemChiTiet.Show();
                        lbErr.Hide();
                    }
                    else
                    {
                        lbErr.Show();
                        llbXemChiTiet.Hide();
                        dataGridView1.Hide();
                        llbHide.Hide();
                    }

                }
                else
                {
                    //var data = dt.ViPhams.Where(n => n.idUser == ID && n.ngayGio.Value.Year == year && n.ngayGio.Value.Month == month).ToList();
                    List<Action> data = allActions.Where(n => n.UserID == user.UserID && n.StartTime.Year == year&& n.StartTime.Month == month).ToList();
                    int sum = data.Count();
                    lbSoViPham.Text = sum.ToString();
                    if (sum > 0)
                    {
                        dataGridView1.DataSource = data;
                        llbXemChiTiet.Show();
                        lbErr.Hide();
                    }
                    else
                    {
                        lbErr.Show();
                        llbXemChiTiet.Hide();
                        dataGridView1.Hide();
                        llbHide.Hide();
                    }
                }
            }
        }

        private void lbLogOut_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            this.Hide();
            f.Show();
        }
    }
}
