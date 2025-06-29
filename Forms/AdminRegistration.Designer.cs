namespace Restaurant.Forms
{
    partial class AdminRegistration
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
            this.label8 = new System.Windows.Forms.Label();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.registerbutton = new System.Windows.Forms.Button();
            this.mobiletext = new System.Windows.Forms.TextBox();
            this.Addresstext = new System.Windows.Forms.TextBox();
            this.confirmtext = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.usernametext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(232, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(288, 41);
            this.label8.TabIndex = 78;
            this.label8.Text = "Enter Admin Information";
            // 
            // cancelbutton
            // 
            this.cancelbutton.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cancelbutton.Location = new System.Drawing.Point(461, 382);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(108, 37);
            this.cancelbutton.TabIndex = 77;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // registerbutton
            // 
            this.registerbutton.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.registerbutton.Location = new System.Drawing.Point(206, 382);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(120, 38);
            this.registerbutton.TabIndex = 76;
            this.registerbutton.Text = "Register";
            this.registerbutton.UseVisualStyleBackColor = true;
            this.registerbutton.Click += new System.EventHandler(this.registerbutton_Click);
            // 
            // mobiletext
            // 
            this.mobiletext.Location = new System.Drawing.Point(560, 290);
            this.mobiletext.Name = "mobiletext";
            this.mobiletext.Size = new System.Drawing.Size(134, 22);
            this.mobiletext.TabIndex = 75;
            // 
            // Addresstext
            // 
            this.Addresstext.Location = new System.Drawing.Point(189, 284);
            this.Addresstext.Name = "Addresstext";
            this.Addresstext.Size = new System.Drawing.Size(137, 22);
            this.Addresstext.TabIndex = 74;
            // 
            // confirmtext
            // 
            this.confirmtext.Location = new System.Drawing.Point(560, 207);
            this.confirmtext.Name = "confirmtext";
            this.confirmtext.Size = new System.Drawing.Size(134, 22);
            this.confirmtext.TabIndex = 73;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(190, 207);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(136, 22);
            this.passwordBox.TabIndex = 72;
            // 
            // emailtext
            // 
            this.emailtext.Location = new System.Drawing.Point(560, 126);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(134, 22);
            this.emailtext.TabIndex = 71;
            // 
            // usernametext
            // 
            this.usernametext.Location = new System.Drawing.Point(190, 124);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(136, 22);
            this.usernametext.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(403, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 30);
            this.label6.TabIndex = 69;
            this.label6.Text = "Moblie Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 30);
            this.label5.TabIndex = 68;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 30);
            this.label4.TabIndex = 67;
            this.label4.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 30);
            this.label3.TabIndex = 66;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 30);
            this.label2.TabIndex = 65;
            this.label2.Text = "Email Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 64;
            this.label1.Text = "User Name";
            // 
            // AdminRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.registerbutton);
            this.Controls.Add(this.mobiletext);
            this.Controls.Add(this.Addresstext);
            this.Controls.Add(this.confirmtext);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.usernametext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminRegistration";
            this.Load += new System.EventHandler(this.AdminRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button registerbutton;
        private System.Windows.Forms.TextBox mobiletext;
        private System.Windows.Forms.TextBox Addresstext;
        private System.Windows.Forms.TextBox confirmtext;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.TextBox usernametext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}