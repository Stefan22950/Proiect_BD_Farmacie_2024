using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddSuppliers : Form
    {
        Pen myPen = new Pen(Color.Black);
        Graphics g1 = null;
        DatabaseFunctions db = new DatabaseFunctions();
        bool add = false;
        string nume, email, telefon, website = null;

        public AddSuppliers(bool add)
        {
            InitializeComponent();
            bt_sp_addSupplier.Enabled = false;
            this.add = add;
        }

        public AddSuppliers(bool add, string nume, string email, string telefon, string website)
        {
            InitializeComponent();
            bt_sp_addSupplier.Enabled = false;
            this.add = add;
            this.nume = nume;
            this.email = email;
            this.telefon = telefon;
            this.website = website;

        }

        private void lb_sp_Telefon_Click(object sender, EventArgs e)
        {

        }

        private void panel_as_Paint(object sender, PaintEventArgs e)
        {
            g1 = panel_as.CreateGraphics();

            // Paint line under text "Dashboard"
            myPen.Width = 2; myPen.Color = Color.LightGray;
            Point[] points = { new Point(20, 60), new Point(panel_as.Width - 20, 60) };
            g1.DrawLines(myPen, points);
        }

        private void ValidateTextBoxes()
        {
            if (txt_sp_name.Text.Length != 0 && txt_sp_email.Text.Length != 0 && txt_sp_telefon.Text.Length != 0 && txt_sp_website.Text.Length != 0 )
            {
                bt_sp_addSupplier.Enabled = true;
            }
            else
            {
                bt_sp_addSupplier.Enabled = false;
            }
        }

        private void txt_sp_name_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txt_sp_email_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void AddSuppliers_Load(object sender, EventArgs e)
        {
            if (add == true)
            {
                this.Text = "Add Manufacturer";
                lb_sp_addSupplier.Text = "Add Manufacturer";
                bt_sp_addSupplier.Text = "Add Manufacturer";
                bt_sp_addSupplier.BackColor = Color.FromArgb(91, 184, 93);
                bt_sp_addSupplier.BorderColor = Color.FromArgb(91, 184, 93);

            }
            else if (add == false)
            {
                this.Text = "Edit Manufacturer";
                lb_sp_addSupplier.Text = "Edit Manufacturer";
                bt_sp_addSupplier.Text = "Edit Manufacturer";
                bt_sp_addSupplier.BackColor = Color.FromArgb(255, 216, 0);
                bt_sp_addSupplier.BorderColor = Color.FromArgb(255, 216, 0);
                txt_sp_name.Text = nume;
                txt_sp_email.Text = email;
                txt_sp_telefon.Text = telefon;
                txt_sp_website.Text = website;
            }
        }

        private void txt_sp_telefon_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txt_sp_website_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void bt_sp_addSupplier_Click(object sender, EventArgs e)
        {
            if (add == true) db.InsertFurnizor_Producator("Furnizori", txt_sp_name, txt_sp_email, txt_sp_telefon, txt_sp_website);
            else if (add == false) db.EditFurnizor_Producator("Furnizori", txt_sp_name, txt_sp_email, txt_sp_telefon, txt_sp_website);

            this.Close();
        }
    }
}
