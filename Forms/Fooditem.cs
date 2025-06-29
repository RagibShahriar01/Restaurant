using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.Forms
{
    public partial class Fooditem : Form
    {
        private int newUserId;
        public Fooditem(int userId)
        {
            InitializeComponent();
            this.newUserId = userId;
        }
        
        private void Fooditem_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyUserProfile myprofile = new MyUserProfile(newUserId);
            myprofile.Show();
        }

        private void parathapictureBox_Click(object sender, EventArgs e)
        {

            this.Hide();
            Kacchics c1 = new Kacchics(newUserId);
            c1.Show();
        }

        private void RuipictureBox_Click(object sender, EventArgs e)
        {

            this.Hide();
            Roast c2 = new Roast(newUserId);
            c2.Show();
        }

        private void BeefkpictureBox_Click(object sender, EventArgs e)
        {

            this.Hide();
            khichuri c3 = new khichuri(newUserId);
            c3.Show();
        }

        private void BeefRpictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tehari c4 = new Tehari(newUserId);
            c4.Show();
        }

        private void checkenKpictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chap c5 = new Chap(newUserId);
            c5.Show();
        }

        private void EggKpictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nihari c6 = new Nihari(newUserId);
            c6.Show();
        }
    }
}
