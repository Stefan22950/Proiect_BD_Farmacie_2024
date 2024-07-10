namespace WindowsFormsApp1
{
    partial class AddProduct
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
            this.lb_ap_addProduct = new System.Windows.Forms.Label();
            this.panel_ap = new System.Windows.Forms.Panel();
            this.cb_ap_category = new System.Windows.Forms.ComboBox();
            this.cb_ap_supplier = new System.Windows.Forms.ComboBox();
            this.cb_ap_manuf = new System.Windows.Forms.ComboBox();
            this.dtp_ap_purchaseDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_ap_expDate = new System.Windows.Forms.DateTimePicker();
            this.txt_ap_price = new System.Windows.Forms.TextBox();
            this.txt_ap_stock = new System.Windows.Forms.TextBox();
            this.txt_ap_name = new System.Windows.Forms.TextBox();
            this.bt_ap_add = new WindowsFormsApp1.CustomControls.CustomButtons();
            this.lb_ap_purchDate = new System.Windows.Forms.Label();
            this.lb_ap_price = new System.Windows.Forms.Label();
            this.lb_ap_dateExp = new System.Windows.Forms.Label();
            this.lb_ap_categorie = new System.Windows.Forms.Label();
            this.lb_ap_stoc = new System.Windows.Forms.Label();
            this.lb_ap_furnizor = new System.Windows.Forms.Label();
            this.lb_ap_producator = new System.Windows.Forms.Label();
            this.lb_ap_name = new System.Windows.Forms.Label();
            this.panel_ap.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_ap_addProduct
            // 
            this.lb_ap_addProduct.AutoSize = true;
            this.lb_ap_addProduct.Font = new System.Drawing.Font("Leelawadee UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ap_addProduct.Location = new System.Drawing.Point(274, 19);
            this.lb_ap_addProduct.Name = "lb_ap_addProduct";
            this.lb_ap_addProduct.Size = new System.Drawing.Size(229, 50);
            this.lb_ap_addProduct.TabIndex = 0;
            this.lb_ap_addProduct.Text = "Add Product";
            // 
            // panel_ap
            // 
            this.panel_ap.Controls.Add(this.cb_ap_category);
            this.panel_ap.Controls.Add(this.cb_ap_supplier);
            this.panel_ap.Controls.Add(this.cb_ap_manuf);
            this.panel_ap.Controls.Add(this.dtp_ap_purchaseDate);
            this.panel_ap.Controls.Add(this.dtp_ap_expDate);
            this.panel_ap.Controls.Add(this.txt_ap_price);
            this.panel_ap.Controls.Add(this.txt_ap_stock);
            this.panel_ap.Controls.Add(this.txt_ap_name);
            this.panel_ap.Controls.Add(this.bt_ap_add);
            this.panel_ap.Controls.Add(this.lb_ap_purchDate);
            this.panel_ap.Controls.Add(this.lb_ap_price);
            this.panel_ap.Controls.Add(this.lb_ap_dateExp);
            this.panel_ap.Controls.Add(this.lb_ap_categorie);
            this.panel_ap.Controls.Add(this.lb_ap_stoc);
            this.panel_ap.Controls.Add(this.lb_ap_furnizor);
            this.panel_ap.Controls.Add(this.lb_ap_producator);
            this.panel_ap.Controls.Add(this.lb_ap_name);
            this.panel_ap.Controls.Add(this.lb_ap_addProduct);
            this.panel_ap.Location = new System.Drawing.Point(3, 1);
            this.panel_ap.Name = "panel_ap";
            this.panel_ap.Size = new System.Drawing.Size(797, 514);
            this.panel_ap.TabIndex = 1;
            this.panel_ap.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_ap_Paint);
            // 
            // cb_ap_category
            // 
            this.cb_ap_category.FormattingEnabled = true;
            this.cb_ap_category.Location = new System.Drawing.Point(225, 275);
            this.cb_ap_category.Name = "cb_ap_category";
            this.cb_ap_category.Size = new System.Drawing.Size(549, 24);
            this.cb_ap_category.TabIndex = 20;
            this.cb_ap_category.TextChanged += new System.EventHandler(this.cb_ap_category_TextChanged);
            // 
            // cb_ap_supplier
            // 
            this.cb_ap_supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ap_supplier.FormattingEnabled = true;
            this.cb_ap_supplier.Location = new System.Drawing.Point(225, 195);
            this.cb_ap_supplier.Name = "cb_ap_supplier";
            this.cb_ap_supplier.Size = new System.Drawing.Size(549, 24);
            this.cb_ap_supplier.TabIndex = 19;
            this.cb_ap_supplier.TextChanged += new System.EventHandler(this.cb_ap_supplier_TextChanged);
            // 
            // cb_ap_manuf
            // 
            this.cb_ap_manuf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ap_manuf.FormattingEnabled = true;
            this.cb_ap_manuf.Location = new System.Drawing.Point(225, 155);
            this.cb_ap_manuf.Name = "cb_ap_manuf";
            this.cb_ap_manuf.Size = new System.Drawing.Size(549, 24);
            this.cb_ap_manuf.TabIndex = 18;
            this.cb_ap_manuf.TextChanged += new System.EventHandler(this.cb_ap_manuf_TextChanged);
            // 
            // dtp_ap_purchaseDate
            // 
            this.dtp_ap_purchaseDate.Location = new System.Drawing.Point(225, 395);
            this.dtp_ap_purchaseDate.Name = "dtp_ap_purchaseDate";
            this.dtp_ap_purchaseDate.Size = new System.Drawing.Size(549, 22);
            this.dtp_ap_purchaseDate.TabIndex = 17;
            // 
            // dtp_ap_expDate
            // 
            this.dtp_ap_expDate.Location = new System.Drawing.Point(225, 315);
            this.dtp_ap_expDate.Name = "dtp_ap_expDate";
            this.dtp_ap_expDate.Size = new System.Drawing.Size(549, 22);
            this.dtp_ap_expDate.TabIndex = 16;
            // 
            // txt_ap_price
            // 
            this.txt_ap_price.Location = new System.Drawing.Point(225, 355);
            this.txt_ap_price.Name = "txt_ap_price";
            this.txt_ap_price.Size = new System.Drawing.Size(549, 22);
            this.txt_ap_price.TabIndex = 15;
            this.txt_ap_price.TextChanged += new System.EventHandler(this.txt_ap_price_TextChanged);
            // 
            // txt_ap_stock
            // 
            this.txt_ap_stock.Location = new System.Drawing.Point(225, 235);
            this.txt_ap_stock.Name = "txt_ap_stock";
            this.txt_ap_stock.Size = new System.Drawing.Size(549, 22);
            this.txt_ap_stock.TabIndex = 13;
            this.txt_ap_stock.TextChanged += new System.EventHandler(this.txt_ap_stock_TextChanged);
            // 
            // txt_ap_name
            // 
            this.txt_ap_name.Location = new System.Drawing.Point(225, 115);
            this.txt_ap_name.Name = "txt_ap_name";
            this.txt_ap_name.Size = new System.Drawing.Size(549, 22);
            this.txt_ap_name.TabIndex = 10;
            this.txt_ap_name.TextChanged += new System.EventHandler(this.txt_ap_name_TextChanged);
            // 
            // bt_ap_add
            // 
            this.bt_ap_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(184)))), ((int)(((byte)(93)))));
            this.bt_ap_add.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(184)))), ((int)(((byte)(93)))));
            this.bt_ap_add.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(184)))), ((int)(((byte)(93)))));
            this.bt_ap_add.BorderRadius = 25;
            this.bt_ap_add.BorderSize = 1;
            this.bt_ap_add.FlatAppearance.BorderSize = 0;
            this.bt_ap_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ap_add.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ap_add.ForeColor = System.Drawing.Color.White;
            this.bt_ap_add.Location = new System.Drawing.Point(283, 450);
            this.bt_ap_add.Name = "bt_ap_add";
            this.bt_ap_add.Size = new System.Drawing.Size(210, 40);
            this.bt_ap_add.TabIndex = 9;
            this.bt_ap_add.Text = "Add Product";
            this.bt_ap_add.TextColor = System.Drawing.Color.White;
            this.bt_ap_add.UseVisualStyleBackColor = false;
            this.bt_ap_add.Click += new System.EventHandler(this.bt_ap_add_Click);
            // 
            // lb_ap_purchDate
            // 
            this.lb_ap_purchDate.AutoSize = true;
            this.lb_ap_purchDate.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ap_purchDate.Location = new System.Drawing.Point(36, 392);
            this.lb_ap_purchDate.Name = "lb_ap_purchDate";
            this.lb_ap_purchDate.Size = new System.Drawing.Size(171, 31);
            this.lb_ap_purchDate.TabIndex = 8;
            this.lb_ap_purchDate.Text = "Purchase Date :";
            // 
            // lb_ap_price
            // 
            this.lb_ap_price.AutoSize = true;
            this.lb_ap_price.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ap_price.Location = new System.Drawing.Point(140, 350);
            this.lb_ap_price.Name = "lb_ap_price";
            this.lb_ap_price.Size = new System.Drawing.Size(81, 31);
            this.lb_ap_price.TabIndex = 7;
            this.lb_ap_price.Text = "Price : ";
            // 
            // lb_ap_dateExp
            // 
            this.lb_ap_dateExp.AutoSize = true;
            this.lb_ap_dateExp.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ap_dateExp.Location = new System.Drawing.Point(23, 310);
            this.lb_ap_dateExp.Name = "lb_ap_dateExp";
            this.lb_ap_dateExp.Size = new System.Drawing.Size(182, 31);
            this.lb_ap_dateExp.TabIndex = 6;
            this.lb_ap_dateExp.Text = "Expiration Date :";
            // 
            // lb_ap_categorie
            // 
            this.lb_ap_categorie.AutoSize = true;
            this.lb_ap_categorie.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ap_categorie.Location = new System.Drawing.Point(94, 270);
            this.lb_ap_categorie.Name = "lb_ap_categorie";
            this.lb_ap_categorie.Size = new System.Drawing.Size(123, 31);
            this.lb_ap_categorie.TabIndex = 5;
            this.lb_ap_categorie.Text = "Category : ";
            // 
            // lb_ap_stoc
            // 
            this.lb_ap_stoc.AutoSize = true;
            this.lb_ap_stoc.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ap_stoc.Location = new System.Drawing.Point(134, 230);
            this.lb_ap_stoc.Name = "lb_ap_stoc";
            this.lb_ap_stoc.Size = new System.Drawing.Size(86, 31);
            this.lb_ap_stoc.TabIndex = 4;
            this.lb_ap_stoc.Text = "Stock : ";
            // 
            // lb_ap_furnizor
            // 
            this.lb_ap_furnizor.AutoSize = true;
            this.lb_ap_furnizor.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ap_furnizor.Location = new System.Drawing.Point(100, 190);
            this.lb_ap_furnizor.Name = "lb_ap_furnizor";
            this.lb_ap_furnizor.Size = new System.Drawing.Size(116, 31);
            this.lb_ap_furnizor.TabIndex = 3;
            this.lb_ap_furnizor.Text = "Supplier : ";
            // 
            // lb_ap_producator
            // 
            this.lb_ap_producator.AutoSize = true;
            this.lb_ap_producator.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ap_producator.Location = new System.Drawing.Point(40, 150);
            this.lb_ap_producator.Name = "lb_ap_producator";
            this.lb_ap_producator.Size = new System.Drawing.Size(169, 31);
            this.lb_ap_producator.TabIndex = 2;
            this.lb_ap_producator.Text = "Manufacturer : ";
            // 
            // lb_ap_name
            // 
            this.lb_ap_name.AutoSize = true;
            this.lb_ap_name.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ap_name.Location = new System.Drawing.Point(127, 110);
            this.lb_ap_name.Name = "lb_ap_name";
            this.lb_ap_name.Size = new System.Drawing.Size(92, 31);
            this.lb_ap_name.TabIndex = 1;
            this.lb_ap_name.Text = "Name : ";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.panel_ap);
            this.MaximumSize = new System.Drawing.Size(818, 550);
            this.MinimumSize = new System.Drawing.Size(818, 550);
            this.Name = "AddProduct";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.panel_ap.ResumeLayout(false);
            this.panel_ap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_ap_addProduct;
        private System.Windows.Forms.Panel panel_ap;
        private System.Windows.Forms.Label lb_ap_name;
        private System.Windows.Forms.Label lb_ap_producator;
        private System.Windows.Forms.Label lb_ap_furnizor;
        private System.Windows.Forms.Label lb_ap_stoc;
        private System.Windows.Forms.Label lb_ap_categorie;
        private System.Windows.Forms.Label lb_ap_dateExp;
        private System.Windows.Forms.Label lb_ap_price;
        private System.Windows.Forms.Label lb_ap_purchDate;
        private CustomControls.CustomButtons bt_ap_add;
        private System.Windows.Forms.TextBox txt_ap_name;
        private System.Windows.Forms.TextBox txt_ap_price;
        private System.Windows.Forms.TextBox txt_ap_stock;
        private System.Windows.Forms.DateTimePicker dtp_ap_purchaseDate;
        private System.Windows.Forms.DateTimePicker dtp_ap_expDate;
        private System.Windows.Forms.ComboBox cb_ap_supplier;
        private System.Windows.Forms.ComboBox cb_ap_manuf;
        private System.Windows.Forms.ComboBox cb_ap_category;
    }
}