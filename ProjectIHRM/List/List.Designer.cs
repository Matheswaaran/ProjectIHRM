namespace ProjectIHRM.Home
{
    partial class List
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.list_web = new System.Windows.Forms.Button();
            this.Seperator1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::ProjectIHRM.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(761, 499);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // list_web
            // 
            this.list_web.Location = new System.Drawing.Point(781, 28);
            this.list_web.Name = "list_web";
            this.list_web.Size = new System.Drawing.Size(250, 23);
            this.list_web.TabIndex = 4;
            this.list_web.Text = "Website List";
            this.list_web.UseVisualStyleBackColor = true;
            this.list_web.Click += new System.EventHandler(this.list_web_Click);
            // 
            // Seperator1
            // 
            this.Seperator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Seperator1.Location = new System.Drawing.Point(760, 64);
            this.Seperator1.Name = "Seperator1";
            this.Seperator1.Size = new System.Drawing.Size(282, 1);
            this.Seperator1.TabIndex = 5;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1043, 502);
            this.Controls.Add(this.Seperator1);
            this.Controls.Add(this.list_web);
            this.Controls.Add(this.pictureBox1);
            this.Name = "List";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button list_web;
        private System.Windows.Forms.Label Seperator1;
    }
}