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


        private void customButtons2_Click(object sender, EventArgs e)
        {
            dropdownMenu1.Show(customButtons2, 0, customButtons2.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dropdownMenu1.IsMainMenu = true;
            dropdownMenu1.PrimaryColor = Color.FromArgb(47,68,87);
            panel1.BackColor= Color.FromArgb(47, 68, 87);
            panelMenu1.BackColor= Color.FromArgb(47, 68, 87);
            customButtons2.BackColor = Color.FromArgb(47, 68, 87);
            customButtons3.BackColor = Color.FromArgb(47, 68, 87);
           


        }

        private void customButtons3_Click(object sender, EventArgs e)
        {
            Panel_Dashboard.Hide();
            Thread.Sleep(2000);
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
            label2.BackColor = Color.LightBlue; label2.ForeColor = Color.DarkBlue;
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

        private void label4_TextChanged(object sender, EventArgs e)
        {
            if(label4.Text.Length==1)
            {
                label4.Location = new Point(279, 177);

            }else if(label4.Text.Length==2)
            {
                label4.Location = new Point(230, 177);
            }else if( label4.Text.Length==3)
            {
                label4.Location = new Point(179, 177);
            }
        }

        private void label5_TextChanged(object sender, EventArgs e)
        {
            if (label5.Text.Length == 1)
            {
                label5.Location = new Point(639, 177);

            }
            else if (label5.Text.Length == 2)
            {
                label4.Location = new Point(590, 177);
            }
            else if (label5.Text.Length == 3)
            {
                label4.Location = new Point(539, 177);
            }
        }

        private void customButtons9_Click(object sender, EventArgs e)
        {

        }
    }
}
