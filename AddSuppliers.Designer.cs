namespace WindowsFormsApp1
{
    partial class AddSuppliers
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
            this.panel_as = new System.Windows.Forms.Panel();
            this.txt_sp_telefon = new System.Windows.Forms.TextBox();
            this.txt_sp_email = new System.Windows.Forms.TextBox();
            this.txt_sp_website = new System.Windows.Forms.TextBox();
            this.txt_sp_name = new System.Windows.Forms.TextBox();
            this.bt_sp_addSupplier = new WindowsFormsApp1.CustomControls.CustomButtons();
            this.lb_sp_website = new System.Windows.Forms.Label();
            this.lb_sp_Telefon = new System.Windows.Forms.Label();
            this.lb_sp_Email = new System.Windows.Forms.Label();
            this.lb_ap_name = new System.Windows.Forms.Label();
            this.lb_sp_addSupplier = new System.Windows.Forms.Label();
            this.panel_as.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_as
            // 
            this.panel_as.Controls.Add(this.txt_sp_telefon);
            this.panel_as.Controls.Add(this.txt_sp_email);
            this.panel_as.Controls.Add(this.txt_sp_website);
            this.panel_as.Controls.Add(this.txt_sp_name);
            this.panel_as.Controls.Add(this.bt_sp_addSupplier);
            this.panel_as.Controls.Add(this.lb_sp_website);
            this.panel_as.Controls.Add(this.lb_sp_Telefon);
            this.panel_as.Controls.Add(this.lb_sp_Email);
            this.panel_as.Controls.Add(this.lb_ap_name);
            this.panel_as.Controls.Add(this.lb_sp_addSupplier);
            this.panel_as.Location = new System.Drawing.Point(0, 0);
            this.panel_as.Name = "panel_as";
            this.panel_as.Size = new System.Drawing.Size(797, 368);
            this.panel_as.TabIndex = 2;
            this.panel_as.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_as_Paint);
            // 
            // txt_sp_telefon
            // 
            this.txt_sp_telefon.Location = new System.Drawing.Point(211, 191);
            this.txt_sp_telefon.Name = "txt_sp_telefon";
            this.txt_sp_telefon.Size = new System.Drawing.Size(565, 22);
            this.txt_sp_telefon.TabIndex = 15;
            this.txt_sp_telefon.TextChanged += new System.EventHandler(this.txt_sp_telefon_TextChanged);
            // 
            // txt_sp_email
            // 
            this.txt_sp_email.Location = new System.Drawing.Point(211, 151);
            this.txt_sp_email.Name = "txt_sp_email";
            this.txt_sp_email.Size = new System.Drawing.Size(565, 22);
            this.txt_sp_email.TabIndex = 14;
            this.txt_sp_email.TextChanged += new System.EventHandler(this.txt_sp_email_TextChanged);
            // 
            // txt_sp_website
            // 
            this.txt_sp_website.Location = new System.Drawing.Point(211, 231);
            this.txt_sp_website.Name = "txt_sp_website";
            this.txt_sp_website.Size = new System.Drawing.Size(565, 22);
            this.txt_sp_website.TabIndex = 13;
            this.txt_sp_website.TextChanged += new System.EventHandler(this.txt_sp_website_TextChanged);
            // 
            // txt_sp_name
            // 
            this.txt_sp_name.Location = new System.Drawing.Point(211, 111);
            this.txt_sp_name.Name = "txt_sp_name";
            this.txt_sp_name.Size = new System.Drawing.Size(565, 22);
            this.txt_sp_name.TabIndex = 10;
            this.txt_sp_name.TextChanged += new System.EventHandler(this.txt_sp_name_TextChanged);
            // 
            // bt_sp_addSupplier
            // 
            this.bt_sp_addSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(184)))), ((int)(((byte)(93)))));
            this.bt_sp_addSupplier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(184)))), ((int)(((byte)(93)))));
            this.bt_sp_addSupplier.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(184)))), ((int)(((byte)(93)))));
            this.bt_sp_addSupplier.BorderRadius = 25;
            this.bt_sp_addSupplier.BorderSize = 1;
            this.bt_sp_addSupplier.FlatAppearance.BorderSize = 0;
            this.bt_sp_addSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sp_addSupplier.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sp_addSupplier.ForeColor = System.Drawing.Color.White;
            this.bt_sp_addSupplier.Location = new System.Drawing.Point(283, 308);
            this.bt_sp_addSupplier.Name = "bt_sp_addSupplier";
            this.bt_sp_addSupplier.Size = new System.Drawing.Size(210, 40);
            this.bt_sp_addSupplier.TabIndex = 9;
            this.bt_sp_addSupplier.Text = "Add Supplier";
            this.bt_sp_addSupplier.TextColor = System.Drawing.Color.White;
            this.bt_sp_addSupplier.UseVisualStyleBackColor = false;
            this.bt_sp_addSupplier.Click += new System.EventHandler(this.bt_sp_addSupplier_Click);
            // 
            // lb_sp_website
            // 
            this.lb_sp_website.AutoSize = true;
            this.lb_sp_website.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sp_website.Location = new System.Drawing.Point(95, 226);
            this.lb_sp_website.Name = "lb_sp_website";
            this.lb_sp_website.Size = new System.Drawing.Size(108, 31);
            this.lb_sp_website.TabIndex = 4;
            this.lb_sp_website.Text = "Website :";
            // 
            // lb_sp_Telefon
            // 
            this.lb_sp_Telefon.AutoSize = true;
            this.lb_sp_Telefon.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sp_Telefon.Location = new System.Drawing.Point(102, 188);
            this.lb_sp_Telefon.Name = "lb_sp_Telefon";
            this.lb_sp_Telefon.Size = new System.Drawing.Size(100, 31);
            this.lb_sp_Telefon.TabIndex = 3;
            this.lb_sp_Telefon.Text = "Telefon :";
            this.lb_sp_Telefon.Click += new System.EventHandler(this.lb_sp_Telefon_Click);
            // 
            // lb_sp_Email
            // 
            this.lb_sp_Email.AutoSize = true;
            this.lb_sp_Email.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sp_Email.Location = new System.Drawing.Point(124, 146);
            this.lb_sp_Email.Name = "lb_sp_Email";
            this.lb_sp_Email.Size = new System.Drawing.Size(81, 31);
            this.lb_sp_Email.TabIndex = 2;
            this.lb_sp_Email.Text = "Email :";
            // 
            // lb_ap_name
            // 
            this.lb_ap_name.AutoSize = true;
            this.lb_ap_name.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ap_name.Location = new System.Drawing.Point(119, 106);
            this.lb_ap_name.Name = "lb_ap_name";
            this.lb_ap_name.Size = new System.Drawing.Size(86, 31);
            this.lb_ap_name.TabIndex = 1;
            this.lb_ap_name.Text = "Name :";
            // 
            // lb_sp_addSupplier
            // 
            this.lb_sp_addSupplier.AutoSize = true;
            this.lb_sp_addSupplier.Font = new System.Drawing.Font("Leelawadee UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sp_addSupplier.Location = new System.Drawing.Point(274, 19);
            this.lb_sp_addSupplier.Name = "lb_sp_addSupplier";
            this.lb_sp_addSupplier.Size = new System.Drawing.Size(235, 50);
            this.lb_sp_addSupplier.TabIndex = 0;
            this.lb_sp_addSupplier.Text = "Add Supplier";
            // 
            // AddSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.panel_as);
            this.Name = "AddSuppliers";
            this.Text = "Add Supplier";
            this.Load += new System.EventHandler(this.AddSuppliers_Load);
            this.panel_as.ResumeLayout(false);
            this.panel_as.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_as;
        private System.Windows.Forms.TextBox txt_sp_website;
        private System.Windows.Forms.TextBox txt_sp_name;
        private CustomControls.CustomButtons bt_sp_addSupplier;
        private System.Windows.Forms.Label lb_sp_website;
        private System.Windows.Forms.Label lb_sp_Telefon;
        private System.Windows.Forms.Label lb_sp_Email;
        private System.Windows.Forms.Label lb_ap_name;
        private System.Windows.Forms.Label lb_sp_addSupplier;
        private System.Windows.Forms.TextBox txt_sp_telefon;
        private System.Windows.Forms.TextBox txt_sp_email;
    }
}