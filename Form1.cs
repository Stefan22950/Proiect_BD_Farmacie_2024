using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        Pen myPen = new Pen(Color.Black);
        Brush myBrush = new SolidBrush (Color.Black);
        Graphics g1=null;



        public Form1()
        {
            InitializeComponent();
        }


        private void bt_dash_admin_Click(object sender, EventArgs e)
        {
            dropdownMenu1.Show(bt_dash_admin, 0, bt_dash_admin.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dropdownMenu1.IsMainMenu = true;
            dropdownMenu1.PrimaryColor = Color.FromArgb(47,68,87);
            panelDsMenuLeft.BackColor= Color.FromArgb(47, 68, 87);
            panelDsMenuTop.BackColor= Color.FromArgb(47, 68, 87);
            bt_dash_admin.BackColor = Color.FromArgb(47, 68, 87);
            bt_dash_dashboard.BackColor = Color.FromArgb(47, 68, 87);
            Panel_Dashboard.Show();
            panelProducts.Hide();
           


        }

        private void bt_dash_dashboard_Click(object sender, EventArgs e)
        {

            panelProducts.Hide();
            Panel_Dashboard.Show();


        }


        private void Panel_Dashboard_Paint(object sender, PaintEventArgs e)
        {
            g1 = Panel_Dashboard.CreateGraphics();

            // Paint line under text "Dashboard"
            myPen.Width = 2; myPen.Color= Color.LightGray;
            Point[] points = { new Point(20, 60), new Point(Panel_Dashboard.Width-20, 60) };
            g1.DrawLines(myPen, points);


            //Paint "Today's Statistics" box
            Rectangle bounds = new Rectangle(20,80, Panel_Dashboard.Width - 40, 40);
            myPen.Width = 1; myPen.Color = Color.LightBlue; 
            myBrush = new SolidBrush(Color.LightBlue);
            lb_ds_todaySt.BackColor = Color.LightBlue; lb_ds_todaySt.ForeColor = Color.DarkBlue;
            Paint_methods.FillRoundedRectangle(g1, myBrush, bounds, 8);


            //Paint "Customers Rectangle"
            bounds = new Rectangle(20, 140, 250, 180);
            myBrush = new SolidBrush(Color.FromArgb(91,184,93));
            Paint_methods.FillRoundedRectangle(g1, myBrush, bounds, 8);


            //Paint "Sales Rectangle"
            bounds = new Rectangle(290, 140, 250, 180);
            myBrush = new SolidBrush(Color.FromArgb(217, 84, 79));
            Paint_methods.FillRoundedRectangle(g1, myBrush, bounds, 8);

            //Paint "Warnings Rectangle"
            bounds = new Rectangle(560, 140, 250, 180);
            myBrush = new SolidBrush(Color.FromArgb(255, 229,0));
            Paint_methods.FillRoundedRectangle(g1, myBrush, bounds, 8);


        }

        private void lb_ds_custnr_TextChanged(object sender, EventArgs e)
        {
            if(lb_ds_custnr.Text.Length==1)
            {
                lb_ds_custnr.Location = new Point(279, 177);

            }else if(lb_ds_custnr.Text.Length==2)
            {
                lb_ds_custnr.Location = new Point(230, 177);
            }else if( lb_ds_custnr.Text.Length==3)
            {
                lb_ds_custnr.Location = new Point(179, 177);
            }
        }

        private void lb_ds_salesnr_TextChanged(object sender, EventArgs e)
        {
            if (lb_ds_salesnr.Text.Length == 1)
            {
                lb_ds_salesnr.Location = new Point(639, 177);

            }
            else if (lb_ds_salesnr.Text.Length == 2)
            {
                lb_ds_custnr.Location = new Point(590, 177);
            }
            else if (lb_ds_salesnr.Text.Length == 3)
            {
                lb_ds_custnr.Location = new Point(539, 177);
            }
        }

        private void lb_ds_warningsnr_TextChanged(object sender, EventArgs e)
        {
            if (lb_ds_warningsnr.Text.Length == 1)
            {
                lb_ds_warningsnr.Location = new Point(999, 177);

            }
            else if (lb_ds_warningsnr.Text.Length == 2)
            {
                lb_ds_warningsnr.Location = new Point(950, 177);
            }
            else if (lb_ds_warningsnr.Text.Length == 3)
            {
                lb_ds_warningsnr.Location = new Point(899, 177);
            }
        }

        private void bt_ds_mnProducts_Click(object sender, EventArgs e)
        {
            
            panelProducts.Show();
            
        }

        private void bt_ds_mnSuppliers_Click(object sender, EventArgs e)
        {

        }

        private void panelProducts_Paint(object sender, PaintEventArgs e)
        {
            g1 = panelProducts.CreateGraphics();

            // Paint line under text "Products"
            myPen.Width = 2; myPen.Color = Color.LightGray;
            Point[] points = { new Point(20, 60), new Point(panelProducts.Width - 20, 60) };
            g1.DrawLines(myPen, points);

        }
    }
}
