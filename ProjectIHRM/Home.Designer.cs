namespace ProjectIHRM
{
    partial class Home
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
            this.home_login = new System.Windows.Forms.Button();
            this.home_aboutus = new System.Windows.Forms.Button();
            this.home_contactus = new System.Windows.Forms.Button();
            this.home_reset = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.home_txtUsername = new System.Windows.Forms.TextBox();
            this.home_txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.home_forgotpassword = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // home_login
            // 
            this.home_login.Location = new System.Drawing.Point(912, 284);
            this.home_login.Name = "home_login";
            this.home_login.Size = new System.Drawing.Size(108, 31);
            this.home_login.TabIndex = 2;
            this.home_login.Text = "Login";
            this.home_login.UseVisualStyleBackColor = true;
            this.home_login.Click += new System.EventHandler(this.home_login_Click);
            // 
            // home_aboutus
            // 
            this.home_aboutus.Location = new System.Drawing.Point(777, 456);
            this.home_aboutus.Name = "home_aboutus";
            this.home_aboutus.Size = new System.Drawing.Size(243, 31);
            this.home_aboutus.TabIndex = 6;
            this.home_aboutus.Text = "About Us";
            this.home_aboutus.UseVisualStyleBackColor = true;
            // 
            // home_contactus
            // 
            this.home_contactus.Location = new System.Drawing.Point(777, 400);
            this.home_contactus.Name = "home_contactus";
            this.home_contactus.Size = new System.Drawing.Size(243, 31);
            this.home_contactus.TabIndex = 5;
            this.home_contactus.Text = "Contact Us";
            this.home_contactus.UseVisualStyleBackColor = true;
            // 
            // home_reset
            // 
            this.home_reset.Location = new System.Drawing.Point(912, 333);
            this.home_reset.Name = "home_reset";
            this.home_reset.Size = new System.Drawing.Size(108, 31);
            this.home_reset.TabIndex = 3;
            this.home_reset.Text = "Reset";
            this.home_reset.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectIHRM.Properties.Resources.login1;
            this.pictureBox2.Location = new System.Drawing.Point(815, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 136);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::ProjectIHRM.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(761, 499);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // home_txtUsername
            // 
            this.home_txtUsername.Location = new System.Drawing.Point(777, 191);
            this.home_txtUsername.Name = "home_txtUsername";
            this.home_txtUsername.Size = new System.Drawing.Size(243, 20);
            this.home_txtUsername.TabIndex = 0;
            // 
            // home_txtPassword
            // 
            this.home_txtPassword.Location = new System.Drawing.Point(777, 246);
            this.home_txtPassword.Name = "home_txtPassword";
            this.home_txtPassword.PasswordChar = '*';
            this.home_txtPassword.Size = new System.Drawing.Size(243, 20);
            this.home_txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(774, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(774, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // home_forgotpassword
            // 
            this.home_forgotpassword.AutoSize = true;
            this.home_forgotpassword.Location = new System.Drawing.Point(774, 293);
            this.home_forgotpassword.Name = "home_forgotpassword";
            this.home_forgotpassword.Size = new System.Drawing.Size(92, 13);
            this.home_forgotpassword.TabIndex = 4;
            this.home_forgotpassword.TabStop = true;
            this.home_forgotpassword.Text = "Forgot Password?";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1032, 499);
            this.Controls.Add(this.home_forgotpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.home_txtPassword);
            this.Controls.Add(this.home_txtUsername);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.home_reset);
            this.Controls.Add(this.home_contactus);
            this.Controls.Add(this.home_aboutus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.home_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectIHRM";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button home_login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button home_aboutus;
        private System.Windows.Forms.Button home_contactus;
        private System.Windows.Forms.Button home_reset;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox home_txtUsername;
        private System.Windows.Forms.TextBox home_txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel home_forgotpassword;
    }
}

