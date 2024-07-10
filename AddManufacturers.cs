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
    public partial class AddManufacturers : Form
    {
        Pen myPen = new Pen(Color.Black);
        Graphics g1 = null;
        DatabaseFunctions db = new DatabaseFunctions();
        bool add=false;
        string nume, email, telefon, website = null;

        public AddManufacturers(bool add)
        {
            InitializeComponent();
            bt_mn_addManuf.Enabled = false;
            this.add = add;
        }
        public AddManufacturers(bool add,string nume, string email, string telefon, string website)
        {
            InitializeComponent();
            bt_mn_addManuf.Enabled = false;
            this.add = add;
            this.nume = nume;
            this.email = email;
            this.telefon = telefon;
            this.website = website;

        }

        private void AddManufacturers_Load(object sender, EventArgs e)
        {
            if(add==true)
            {
                this.Text = "Add Manufacturer";
                lb_mn_addManuf.Text = "Add Manufacturer";
                bt_mn_addManuf.Text= "Add Manufacturer";
                bt_mn_addManuf.BackColor = Color.FromArgb(91, 184, 93);
                bt_mn_addManuf.BorderColor = Color.FromArgb(91, 184, 93);

            }
            else if(add == false)
            {
                this.Text = "Edit Manufacturer";
                lb_mn_addManuf.Text = "Edit Manufacturer";
                bt_mn_addManuf.Text = "Edit Manufacturer";
                bt_mn_addManuf.BackColor = Color.FromArgb(255, 216, 0);
                bt_mn_addManuf.BorderColor= Color.FromArgb(255, 216, 0);
                txt_mn_name.Text = nume;
                txt_mn_email.Text = email;
                txt_mn_telefon.Text = telefon;
                txt_mn_website.Text = website;
            }
        }

        private void panel_mn_Paint(object sender, PaintEventArgs e)
        {
            g1 = panel_mn.CreateGraphics();

            // Paint line under text "Dashboard"
            myPen.Width = 2; myPen.Color = Color.LightGray;
            Point[] points = { new Point(20, 60), new Point(panel_mn.Width - 20, 60) };
            g1.DrawLines(myPen, points);
        }

        private void ValidateTextBoxes()
        {
            if (txt_mn_name.Text.Length != 0 && txt_mn_email.Text.Length != 0 && txt_mn_telefon.Text.Length != 0 && txt_mn_website.Text.Length != 0)
            {
                bt_mn_addManuf.Enabled = true;
            }
            else
            {
                bt_mn_addManuf.Enabled = false;
            }
        }

        private void txt_mn_name_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txt_mn_email_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txt_mn_telefon_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txt_mn_website_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void bt_mn_addManuf_Click(object sender, EventArgs e)
        {
            if (add == true) db.InsertFurnizor_Producator("Producatori", txt_mn_name, txt_mn_email, txt_mn_telefon, txt_mn_website);
            else if (add == false) db.EditFurnizor_Producator("Producatori", txt_mn_name, txt_mn_email, txt_mn_telefon, txt_mn_website);
            
            this.Close();

        }
    }
}
