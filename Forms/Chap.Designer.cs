namespace Restaurant.Forms
{
    partial class Chap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblPlus = new System.Windows.Forms.Label();
            this.LblMinus = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backlabel3 = new System.Windows.Forms.Label();
            this.BtnAddToCart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblPlus);
            this.panel1.Controls.Add(this.LblMinus);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(450, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 188);
            this.panel1.TabIndex = 10;
            // 
            // LblPlus
            // 
            this.LblPlus.AutoSize = true;
            this.LblPlus.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlus.Location = new System.Drawing.Point(132, 132);
            this.LblPlus.Name = "LblPlus";
            this.LblPlus.Size = new System.Drawing.Size(34, 41);
            this.LblPlus.TabIndex = 7;
            this.LblPlus.Text = "+";
            this.LblPlus.Click += new System.EventHandler(this.LblPlus_Click);
            // 
            // LblMinus
            // 
            this.LblMinus.AutoSize = true;
            this.LblMinus.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMinus.Location = new System.Drawing.Point(54, 128);
            this.LblMinus.Name = "LblMinus";
            this.LblMinus.Size = new System.Drawing.Size(33, 50);
            this.LblMinus.TabIndex = 6;
            this.LblMinus.Text = "-";
            this.LblMinus.Click += new System.EventHandler(this.LblMinus_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(93, 135);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(73, 36);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "label3";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(51, 74);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(53, 30);
            this.price.TabIndex = 4;
            this.price.Text = "price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chicken Chap Luchi";
            // 
            // backlabel3
            // 
            this.backlabel3.AutoSize = true;
            this.backlabel3.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlabel3.Location = new System.Drawing.Point(21, 21);
            this.backlabel3.Name = "backlabel3";
            this.backlabel3.Size = new System.Drawing.Size(51, 30);
            this.backlabel3.TabIndex = 13;
            this.backlabel3.Text = "Back";
            this.backlabel3.Click += new System.EventHandler(this.backlabel3_Click);
            // 
            // BtnAddToCart
            // 
            this.BtnAddToCart.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddToCart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnAddToCart.Location = new System.Drawing.Point(492, 347);
            this.BtnAddToCart.Name = "BtnAddToCart";
            this.BtnAddToCart.Size = new System.Drawing.Size(161, 33);
            this.BtnAddToCart.TabIndex = 12;
            this.BtnAddToCart.Text = "Add to Cart";
            this.BtnAddToCart.UseVisualStyleBackColor = true;
            this.BtnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant.Properties.Resources.chapluchi;
            this.pictureBox1.Location = new System.Drawing.Point(112, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Chap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backlabel3);
            this.Controls.Add(this.BtnAddToCart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Chap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chap";
            this.Load += new System.EventHandler(this.Chap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblPlus;
        private System.Windows.Forms.Label LblMinus;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label backlabel3;
        private System.Windows.Forms.Button BtnAddToCart;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}