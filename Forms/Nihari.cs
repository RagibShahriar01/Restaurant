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

namespace Restaurant.Forms
{
    public partial class Nihari : Form
    {
        private readonly int newUserId;
        private decimal basePrice = 300;
        private int quantity = 1;
        public Nihari(int userId)
        {
            InitializeComponent();
            this.newUserId = userId;

        }

        private void Nihari_Load(object sender, EventArgs e)
        {
            label2.Text = basePrice.ToString("N0") + " TK";
            lblQuantity.Text = quantity.ToString();

            UpdateDisplay();

        }

        private void UpdateDisplay()
        {
            decimal total = basePrice * quantity;
            label2.Text = total.ToString("N0") + " Tk";
        }

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            Cart item = new Cart
            {
                FoodName = "Mutton Nihari",
                Price = basePrice,
                Quantity = quantity
            };

            Hide();
            AddToCart a1 = new AddToCart(newUserId, item);
            a1.Show();
        }

        private void LblMinus_Click(object sender, EventArgs e)
        {
            if (quantity > 1)
            {
                quantity--;
                lblQuantity.Text = quantity.ToString();
                UpdateDisplay();
            }
        }

        private void LblPlus_Click(object sender, EventArgs e)
        {
            quantity++;
            lblQuantity.Text = quantity.ToString();
            UpdateDisplay();
        }

        private void backlabel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fooditem f2 = new Fooditem(newUserId);
            f2.Show();
        }
    }
}
