using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant.Database;
using Restaurant.Forms;

namespace Restaurant.Forms
{
    public partial class AddToCart : Form
    {
        private readonly int newUserId;
        private readonly Cart cart;
        public AddToCart(int userId, Cart item)
        {
            InitializeComponent();
            newUserId = userId;
            cart = item;
        }

        private void AddToCart_Load(object sender, EventArgs e)
        {
            lblFood.Text = cart.FoodName;
            lblQuantity.Text = cart.Quantity.ToString();
            lblTotal.Text = (cart.Price * cart.Quantity).ToString("N0") + " TK";
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment p1 = new Payment(newUserId, cart);
            p1.Show();
        }
    }
}
