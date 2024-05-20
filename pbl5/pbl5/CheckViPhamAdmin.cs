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
    public partial class CheckViPhamAdmin : Form
    {
        ServerAccess serverAccess = new ServerAccess();
        
        private User user { get; set; }

        public CheckViPhamAdmin(User user)
        {
            this.user = user;
            InitializeComponent();
        }
        public CheckViPhamAdmin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            QuanLy f = new QuanLy();
            f.Show();
            this.Hide();
        }

        private void CheckViPhamAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CheckViPhamAdmin_Load(object sender, EventArgs e)
        {
            
            if (user == null)
            {
                //lbUser.Hide();
                //label3.Hide();
                //label2.Hide();
                //label4.Hide();
                //lbSoViPham.Hide();
                //cbMonth.Hide();
                //cbYear.Hide();
                lbID.Hide();

                groupBox1.Hide();

                lbErr.Hide();

                llbXemChiTiet.Hide();

                llbHide.Hide();
                dataGridView1.Hide();

                

            }
            else
            {                
                    label6.Hide();
                    txtSearch.Hide();
                    btnSearch.Hide();
                    llbHide.Hide();
                    lbErr.Hide();
                    llbXemChiTiet.Hide();
                    dataGridView1.Hide();
                    lbID.Text = user.UserID.ToString();
                    lbUser.Text = user.fullname;
                    cbMonth.SelectedIndex = 0;
                    cbYear.SelectedIndex = 0;

                    
                
            }

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(txtSearch.Text);
            user = await serverAccess.GetUserById(ID);// dt.TaiKhoans.SingleOrDefault(n => n.id == ID);
            if (user != null)
            {
                
                groupBox1.Show();
                label6.Hide();

                lbUser.Text = user.fullname;

                cbMonth.SelectedIndex = 0;
                cbYear.SelectedIndex = 0;
            }

        }

        private void llbHide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llbXemChiTiet.Show();

            llbHide.Hide();
            dataGridView1.Hide();
        }

        private void llbXemChiTiet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.Show();
           
            dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].HeaderText = "ID người dùng";
            //dataGridView1.Columns[2].HeaderText = "Ngày vi phạm";
            //dataGridView1.Columns[3].HeaderText = "Lỗi vi phạm";

            llbXemChiTiet.Hide();
            llbHide.Show();
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
                    List<Action> data = allActions.Where(n => n.UserID == user.UserID && n.StartTime.Year == year && n.StartTime.Month == month).ToList();
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
            //    int month = 0;
            //    long year = 0;
            //    if (cbMonth.SelectedIndex != 0) 
            //    {
            //        string m = cbMonth.SelectedItem.ToString();
            //        month = Int32.Parse(m);
            //    }
            //    if (cbYear.SelectedIndex != 0)
            //    {
            //        string y = cbYear.SelectedItem.ToString();
            //        year = Int32.Parse(y);
            //    }
            //    if(year != 0)
            //    {
            //        if (month == 0)
            //        {
            //            var data = dt.ViPhams.Where(n => n.idUser == ID && n.ngayGio.Value.Year == year).ToList();
            //            int sum = data.Count();
            //            lbSoViPham.Text = sum.ToString();
            //            if (sum > 0)
            //            {
            //                dataGridView1.DataSource = data;
            //                llbXemChiTiet.Show();
            //                lbErr.Hide();
            //            }
            //            else
            //            {
            //                lbErr.Show();
            //                llbXemChiTiet.Hide();
            //                dataGridView1.Hide();
            //                llbHide.Hide();
            //            }

            //        }
            //        else
            //        {
            //            var data = dt.ViPhams.Where(n => n.idUser == ID && n.ngayGio.Value.Year == year && n.ngayGio.Value.Month == month).ToList();
            //            int sum = data.Count();
            //            lbSoViPham.Text = sum.ToString();
            //            if (sum > 0)
            //            {
            //                dataGridView1.DataSource = data;
            //                llbXemChiTiet.Show();
            //                lbErr.Hide();
            //            }
            //            else
            //            {
            //                lbErr.Show();
            //                llbXemChiTiet.Hide();
            //                dataGridView1.Hide();
            //                llbHide.Hide();
            //            }
            //        }
            //    }
            //}

        }

    }   
}
