using Restaurant.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant.Forms;
using Restaurant.Models;

namespace Restaurant.Forms
{
    public partial class AdminDashboard : Form
    {
        private int _adminId;
        private readonly DatabaseHelper db = new DatabaseHelper();
        public AdminDashboard(int adminId)
        {
            InitializeComponent();
            _adminId = adminId;

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            dgv.DataSource = db.SearchByUsername(null);

            Loadbuy();
            LoadUsers();
        }





        private void LoadUsers()
        {
            DataTable dt = db.GetAllUsers();
            dgv2.DataSource = dt;

            // Optional: hide columns / rename headers
            dgv2.Columns["UserID"].HeaderText = "ID";
            dgv2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }






        private void Loadbuy()
        {
            DataTable dt = db.GetBuy(/* all: no filter*/0);
            dgv.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            dgv.DataSource = db.SearchByUsername(TxtSearch.Text.Trim());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv2.CurrentRow == null)
            {
                MessageBox.Show("Please select a user to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = Convert.ToInt32(dgv2.CurrentRow.Cells["UserID"].Value);
            string username = dgv2.CurrentRow.Cells["Username"].Value.ToString();

            var result = MessageBox.Show(
                $"Are you sure you want to delete user '{username}' (ID={userId})? This cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = db.DeleteUser(userId);
                    if (success)
                    {
                        MessageBox.Show("User deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsers();
                    }
                    else
                    {
                        MessageBox.Show("No rows were deleted. Please try again.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
