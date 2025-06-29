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
    public partial class Payment : Form
    {

        private readonly int newUserId;
        private readonly Cart cart;
        private readonly DatabaseHelper db = new DatabaseHelper();
        public Payment(int userId, Cart item)
        {
            InitializeComponent();
            newUserId = userId;
            cart = item;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            lblAmount.Text = (cart.Price * cart.Quantity).ToString("N0") + " TK";
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // determine which radio is checked
            string paymentMethod = radioBkash.Checked ? "Bkash"
                                 : radioNagad.Checked ? "Nagad"
                                 : radiocash.Checked ? "CashOnDelivery"
                                 : null;

            // <-- ADD THIS VALIDATION BLOCK
            if (paymentMethod == null)
            {
                MessageBox.Show(
                    "Please select a payment method before placing your order.",
                    "Missing Payment Method",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            // END ADDITION

            // now we're guaranteed to have a non-null paymentMethod
            db.AddFoodBuy(
                newUserId,
                cart.FoodName,
                cart.Price,
                cart.Quantity,
                paymentMethod
            );

            MessageBox.Show(
                "Your order is confirmed!",
                "Order Placed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Hide();
            var f4 = new Fooditem(newUserId);
            f4.Show();
        }
    }
}
