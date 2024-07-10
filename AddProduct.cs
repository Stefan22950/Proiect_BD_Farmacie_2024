using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddProduct : Form
    {

        Pen myPen = new Pen(Color.Black);
        Graphics g1 = null;
        DatabaseFunctions db = new DatabaseFunctions();
        bool add = false;
        string nume, manufacturer,supplier,stock,category,exp_date,price,purch_date = null;

        public AddProduct(bool add)
        {
            InitializeComponent();
            bt_ap_add.Enabled = false;
            this.add = add;
        }
        public AddProduct(bool add,string nume, string manufacturer, string supplier, string stock, string category, string exp_date, string price, string purch_date)
        {
            InitializeComponent();
            bt_ap_add.Enabled = false;
            this.add = add;
            this.nume = nume;
            this.manufacturer = manufacturer;
            this.supplier = supplier;
            this.stock = stock;
            this.category = category;
            this.exp_date = exp_date;
            this.price = price;
            this.purch_date= purch_date;
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            if (add == true)
            {
                lb_ap_addProduct.Location = new Point((panel_ap.Width / 2) - (lb_ap_addProduct.Width / 2), 10);
                bt_ap_add.Location = new Point((panel_ap.Width / 2) - (bt_ap_add.Width / 2), panel_ap.Height - 55);
                dtp_ap_expDate.MinDate = DateTime.Today;
                db.Bind_Data_AddProductsForm(cb_ap_manuf, cb_ap_supplier, cb_ap_category);
                bt_ap_add.BackColor = Color.FromArgb(91, 184, 93);
                bt_ap_add.BorderColor = Color.FromArgb(91, 184, 93);

            }
            else if (add == false)
            {
                this.Text = "Edit Product";
                lb_ap_addProduct.Text = "Edit Product";
                bt_ap_add.Text = "Edit Product";
                lb_ap_addProduct.Location = new Point((panel_ap.Width / 2) - (lb_ap_addProduct.Width / 2), 10);
                bt_ap_add.Location = new Point((panel_ap.Width / 2) - (bt_ap_add.Width / 2), panel_ap.Height - 55);
                db.Bind_Data_AddProductsForm(cb_ap_manuf, cb_ap_supplier, cb_ap_category);
                bt_ap_add.BackColor = Color.FromArgb(255, 216, 0);
                bt_ap_add.BorderColor = Color.FromArgb(255, 216, 0);
                txt_ap_name.Text = nume;
                cb_ap_manuf.Text = manufacturer;
                cb_ap_supplier.Text = supplier;
                txt_ap_stock.Text = stock;
                cb_ap_category.Text = category;
                dtp_ap_expDate.Value = DateTime.Parse(exp_date);
                txt_ap_price.Text = price.Replace(',','.');
                dtp_ap_purchaseDate.Value = DateTime.Parse(purch_date);
                
            }


        }

        private void panel_ap_Paint(object sender, PaintEventArgs e)
        {
            g1 = panel_ap.CreateGraphics();

            // Paint line under text "Dashboard"
            myPen.Width = 2; myPen.Color = Color.LightGray;
            Point[] points = { new Point(20, 60), new Point(panel_ap.Width - 20, 60) };
            g1.DrawLines(myPen, points);
        }

        private void ValidateTextBoxes()
        {
            if (txt_ap_name.Text.Length != 0 && txt_ap_stock.Text.Length != 0 && txt_ap_price.Text.Length !=0 && cb_ap_manuf.Text.Length !=0 && cb_ap_supplier.Text.Length !=0 && cb_ap_category.Text.Length!=0 && dtp_ap_expDate.Text.Length!=0 && dtp_ap_purchaseDate.Text.Length !=0 )
            {
                bt_ap_add.Enabled = true;
            }
            else
            {
                bt_ap_add.Enabled = false;
            }
        }

        private void txt_ap_name_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void cb_ap_manuf_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void cb_ap_supplier_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txt_ap_stock_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void cb_ap_category_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txt_ap_price_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void bt_ap_add_Click(object sender, EventArgs e)
        {

            if (add == true) db.InsertProduct(txt_ap_name, cb_ap_manuf, cb_ap_supplier, txt_ap_stock, cb_ap_category, dtp_ap_expDate, txt_ap_price, dtp_ap_purchaseDate);
            else if (add == false) db.EditProduct(txt_ap_name, cb_ap_manuf, cb_ap_supplier, txt_ap_stock, cb_ap_category, dtp_ap_expDate, txt_ap_price, dtp_ap_purchaseDate);

            this.Close();

        }
    }
}
