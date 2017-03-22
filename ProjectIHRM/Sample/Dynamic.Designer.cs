namespace ProjectIHRM.Sample
{
    partial class Dynamic
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
            this.list_web = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_web
            // 
            this.list_web.Location = new System.Drawing.Point(259, 102);
            this.list_web.Name = "list_web";
            this.list_web.Size = new System.Drawing.Size(250, 23);
            this.list_web.TabIndex = 5;
            this.list_web.Text = "Website List";
            this.list_web.UseVisualStyleBackColor = true;
            this.list_web.Click += new System.EventHandler(this.list_web_Click);
            // 
            // Dynamic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 474);
            this.Controls.Add(this.list_web);
            this.Name = "Dynamic";
            this.Text = "Dynamic";
            this.Load += new System.EventHandler(this.Dynamic_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button list_web;
    }
}