namespace WindowsFormsApp1
{
    partial class AddManufacturers
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
            this.panel_mn = new System.Windows.Forms.Panel();
            this.txt_mn_telefon = new System.Windows.Forms.TextBox();
            this.txt_mn_email = new System.Windows.Forms.TextBox();
            this.txt_mn_website = new System.Windows.Forms.TextBox();
            this.txt_mn_name = new System.Windows.Forms.TextBox();
            this.lb_mn_website = new System.Windows.Forms.Label();
            this.lb_mn_Telefon = new System.Windows.Forms.Label();
            this.lb_mn_Email = new System.Windows.Forms.Label();
            this.lb_mn_name = new System.Windows.Forms.Label();
            this.lb_mn_addManuf = new System.Windows.Forms.Label();
            this.bt_mn_addManuf = new WindowsFormsApp1.CustomControls.CustomButtons();
            this.panel_mn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_mn
            // 
            this.panel_mn.Controls.Add(this.txt_mn_telefon);
            this.panel_mn.Controls.Add(this.txt_mn_email);
            this.panel_mn.Controls.Add(this.txt_mn_website);
            this.panel_mn.Controls.Add(this.txt_mn_name);
            this.panel_mn.Controls.Add(this.bt_mn_addManuf);
            this.panel_mn.Controls.Add(this.lb_mn_website);
            this.panel_mn.Controls.Add(this.lb_mn_Telefon);
            this.panel_mn.Controls.Add(this.lb_mn_Email);
            this.panel_mn.Controls.Add(this.lb_mn_name);
            this.panel_mn.Controls.Add(this.lb_mn_addManuf);
            this.panel_mn.Location = new System.Drawing.Point(0, 0);
            this.panel_mn.Name = "panel_mn";
            this.panel_mn.Size = new System.Drawing.Size(797, 368);
            this.panel_mn.TabIndex = 3;
            this.panel_mn.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_mn_Paint);
            // 
            // txt_mn_telefon
            // 
            this.txt_mn_telefon.Location = new System.Drawing.Point(211, 191);
            this.txt_mn_telefon.Name = "txt_mn_telefon";
            this.txt_mn_telefon.Size = new System.Drawing.Size(565, 22);
            this.txt_mn_telefon.TabIndex = 15;
            this.txt_mn_telefon.TextChanged += new System.EventHandler(this.txt_mn_telefon_TextChanged);
            // 
            // txt_mn_email
            // 
            this.txt_mn_email.Location = new System.Drawing.Point(211, 151);
            this.txt_mn_email.Name = "txt_mn_email";
            this.txt_mn_email.Size = new System.Drawing.Size(565, 22);
            this.txt_mn_email.TabIndex = 14;
            this.txt_mn_email.TextChanged += new System.EventHandler(this.txt_mn_email_TextChanged);
            // 
            // txt_mn_website
            // 
            this.txt_mn_website.Location = new System.Drawing.Point(211, 231);
            this.txt_mn_website.Name = "txt_mn_website";
            this.txt_mn_website.Size = new System.Drawing.Size(565, 22);
            this.txt_mn_website.TabIndex = 13;
            this.txt_mn_website.TextChanged += new System.EventHandler(this.txt_mn_website_TextChanged);
            // 
            // txt_mn_name
            // 
            this.txt_mn_name.Location = new System.Drawing.Point(211, 111);
            this.txt_mn_name.Name = "txt_mn_name";
            this.txt_mn_name.Size = new System.Drawing.Size(565, 22);
            this.txt_mn_name.TabIndex = 10;
            this.txt_mn_name.TextChanged += new System.EventHandler(this.txt_mn_name_TextChanged);
            // 
            // lb_mn_website
            // 
            this.lb_mn_website.AutoSize = true;
            this.lb_mn_website.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mn_website.Location = new System.Drawing.Point(95, 226);
            this.lb_mn_website.Name = "lb_mn_website";
            this.lb_mn_website.Size = new System.Drawing.Size(108, 31);
            this.lb_mn_website.TabIndex = 4;
            this.lb_mn_website.Text = "Website :";
            // 
            // lb_mn_Telefon
            // 
            this.lb_mn_Telefon.AutoSize = true;
            this.lb_mn_Telefon.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mn_Telefon.Location = new System.Drawing.Point(102, 188);
            this.lb_mn_Telefon.Name = "lb_mn_Telefon";
            this.lb_mn_Telefon.Size = new System.Drawing.Size(100, 31);
            this.lb_mn_Telefon.TabIndex = 3;
            this.lb_mn_Telefon.Text = "Telefon :";
            // 
            // lb_mn_Email
            // 
            this.lb_mn_Email.AutoSize = true;
            this.lb_mn_Email.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mn_Email.Location = new System.Drawing.Point(124, 146);
            this.lb_mn_Email.Name = "lb_mn_Email";
            this.lb_mn_Email.Size = new System.Drawing.Size(81, 31);
            this.lb_mn_Email.TabIndex = 2;
            this.lb_mn_Email.Text = "Email :";
            // 
            // lb_mn_name
            // 
            this.lb_mn_name.AutoSize = true;
            this.lb_mn_name.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mn_name.Location = new System.Drawing.Point(119, 106);
            this.lb_mn_name.Name = "lb_mn_name";
            this.lb_mn_name.Size = new System.Drawing.Size(86, 31);
            this.lb_mn_name.TabIndex = 1;
            this.lb_mn_name.Text = "Name :";
            // 
            // lb_mn_addManuf
            // 
            this.lb_mn_addManuf.AutoSize = true;
            this.lb_mn_addManuf.Font = new System.Drawing.Font("Leelawadee UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mn_addManuf.Location = new System.Drawing.Point(251, 19);
            this.lb_mn_addManuf.Name = "lb_mn_addManuf";
            this.lb_mn_addManuf.Size = new System.Drawing.Size(321, 50);
            this.lb_mn_addManuf.TabIndex = 0;
            this.lb_mn_addManuf.Text = "Add Manufacturer";
            // 
            // bt_mn_addManuf
            // 
            this.bt_mn_addManuf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(184)))), ((int)(((byte)(93)))));
            this.bt_mn_addManuf.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(184)))), ((int)(((byte)(93)))));
            this.bt_mn_addManuf.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(184)))), ((int)(((byte)(93)))));
            this.bt_mn_addManuf.BorderRadius = 25;
            this.bt_mn_addManuf.BorderSize = 1;
            this.bt_mn_addManuf.FlatAppearance.BorderSize = 0;
            this.bt_mn_addManuf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_mn_addManuf.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mn_addManuf.ForeColor = System.Drawing.Color.White;
            this.bt_mn_addManuf.Location = new System.Drawing.Point(283, 308);
            this.bt_mn_addManuf.Name = "bt_mn_addManuf";
            this.bt_mn_addManuf.Size = new System.Drawing.Size(242, 40);
            this.bt_mn_addManuf.TabIndex = 9;
            this.bt_mn_addManuf.Text = "Add Manufacturer";
            this.bt_mn_addManuf.TextColor = System.Drawing.Color.White;
            this.bt_mn_addManuf.UseVisualStyleBackColor = false;
            this.bt_mn_addManuf.Click += new System.EventHandler(this.bt_mn_addManuf_Click);
            // 
            // AddManufacturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 368);
            this.Controls.Add(this.panel_mn);
            this.Name = "AddManufacturers";
            this.Text = "Add Manufacturer";
            this.Load += new System.EventHandler(this.AddManufacturers_Load);
            this.panel_mn.ResumeLayout(false);
            this.panel_mn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_mn;
        private System.Windows.Forms.TextBox txt_mn_telefon;
        private System.Windows.Forms.TextBox txt_mn_email;
        private System.Windows.Forms.TextBox txt_mn_website;
        private System.Windows.Forms.TextBox txt_mn_name;
        private CustomControls.CustomButtons bt_mn_addManuf;
        private System.Windows.Forms.Label lb_mn_website;
        private System.Windows.Forms.Label lb_mn_Telefon;
        private System.Windows.Forms.Label lb_mn_Email;
        private System.Windows.Forms.Label lb_mn_name;
        private System.Windows.Forms.Label lb_mn_addManuf;
    }
}