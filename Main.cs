using Oracle.ManagedDataAccess.Client;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        
        Pen myPen = new Pen(Color.Black);
        Brush myBrush = new SolidBrush (Color.Black);
        Graphics g1=null;

        OracleConnection cnn = new OracleConnection("Data Source=localhost/xe;User Id=system;Password=admin123;");
        OracleCommand command;
        OracleDataAdapter adpt;
        DataSet ds;
        DataTable dt;
        DatabaseFunctions db = new DatabaseFunctions();
        int lastIndex=0;
        List<PanelProduse> list = new List<PanelProduse>();
        float GrandTotal = 0;
        float Change = 0;

        struct PanelProduse
        {
            public Panel panel;
            public CustomControls.CustomButtons cb;
            public Label numeProdus, pret, total;
            public NumericUpDown nm;
        }
        

        public Main()
        {
            InitializeComponent();
            
        }

        private void bt_dash_admin_Click(object sender, EventArgs e)
        {
            dropdownMenu1.Show(bt_dash_admin, 0, bt_dash_admin.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Maximized;
            dropdownMenu1.IsMainMenu = true;
            dropdownMenu1.PrimaryColor = Color.FromArgb(47,68,87);
            panelDsMenuLeft.BackColor= Color.FromArgb(47, 68, 87);
            panelDsMenuTop.BackColor= Color.FromArgb(47, 68, 87);
            bt_dash_admin.BackColor = Color.FromArgb(47, 68, 87);
            bt_dash_dashboard.BackColor = Color.FromArgb(47, 68, 87);

            Panel_Dashboard.Location = new Point(panelDsMenuLeft.Width+1, panelDsMenuTop.Height+1); ;
            panelProducts.Location = new Point(panelDsMenuLeft.Width + 1, panelDsMenuTop.Height + 1);
            panelSuppliers.Location = new Point(panelDsMenuLeft.Width + 1, panelDsMenuTop.Height + 1);
            panel_manufacturers.Location = new Point(panelDsMenuLeft.Width + 1, panelDsMenuTop.Height + 1);

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "Disabled"; checkColumn.HeaderText = "Disabled"; checkColumn.ReadOnly = false;
            dgv_pr.Columns.Add(checkColumn);

            dgv_pr.Size = new Size(panelProducts.Width - 40, panelProducts.Height - 170);
            dgv_sp.Size = new Size(panelProducts.Width - 40, panelProducts.Height - 170);
            dgv_mn.Size = new Size(panelProducts.Width - 40, panelProducts.Height - 170);

            txt_pos2_dis.Text = "0";
            cb_pos2_tax.SelectedIndex = cb_pos2_tax.FindStringExact("19%");
            cb_pos2_payMethod1.SelectedIndex = cb_pos2_payMethod1.FindStringExact("Cash");

            Panel_Dashboard.Show();
            panelProducts.Hide();
            panelSuppliers.Hide();
            panel_pos.Hide();
            panel_manufacturers.Hide();
           
        }

        private void bt_dash_dashboard_Click(object sender, EventArgs e)
        {
            panelProducts.Hide();
            panelSuppliers.Hide();
            panel_manufacturers.Hide(); 
            panel_pos.Hide();
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
            db.AfisareDGV(dgv_pr);

            Panel_Dashboard.Hide();
            panelSuppliers.Hide();
            panel_manufacturers.Hide();
            panel_pos.Hide();
            panelProducts.Show();
            
        }

        private void bt_ds_mnSuppliers_Click(object sender, EventArgs e)
        {
            db.AfisareDGV(dgv_sp);
            
            Panel_Dashboard.Hide();
            panelProducts.Hide();
            panel_manufacturers.Hide();
            panel_pos.Hide();
            panelSuppliers.Show();
        }

        private void panelProducts_Paint(object sender, PaintEventArgs e)
        {
            g1 = panelProducts.CreateGraphics();

            // Paint line under text "Products"
            myPen.Width = 2; myPen.Color = Color.LightGray;
            Point[] points = { new Point(20, 60), new Point(panelProducts.Width - 20, 60) };
            g1.DrawLines(myPen, points);

        }

        private void bt_pr_addProduct_Click(object sender, EventArgs e)
        {
            AddProduct form = new AddProduct(true);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
            db.AfisareDGV(dgv_pr);
        }

        private void panel_mnsuppliers_Paint(object sender, PaintEventArgs e)
        {
            g1 = panelSuppliers.CreateGraphics();

            // Paint line under text "Products"
            myPen.Width = 2; myPen.Color = Color.LightGray;
            Point[] points = { new Point(20, 60), new Point(panelSuppliers.Width - 20, 60) };
            g1.DrawLines(myPen, points);
        }

        private void bt_sp_addSupplier_Click(object sender, EventArgs e)
        {
            AddSuppliers form = new AddSuppliers(true);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
            db.AfisareDGV(dgv_sp);
        }

        

        private void bt_ds_mnManuf_Click(object sender, EventArgs e)
        {
            db.AfisareDGV(dgv_mn);

            Panel_Dashboard.Hide();
            panelProducts.Hide();
            panelSuppliers.Hide();
            panel_pos.Hide();
            panel_manufacturers.Show();
        }

        private void dgv_mn_Paint(object sender, PaintEventArgs e)
        {
            g1 = panel_manufacturers.CreateGraphics();

            // Paint line under text "Products"
            myPen.Width = 2; myPen.Color = Color.LightGray;
            Point[] points = { new Point(20, 60), new Point(panel_manufacturers.Width - 20, 60) };
            g1.DrawLines(myPen, points);
        }

        private void bt_mn_add_Click(object sender, EventArgs e)
        {
            AddManufacturers form = new AddManufacturers(true);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
            db.AfisareDGV(dgv_mn);
        }

        private void dgv_mn_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void bt_mn_edit_Click(object sender, EventArgs e)
        {
            string nume = Convert.ToString(dgv_mn.CurrentRow.Cells[0].Value);
            string email = Convert.ToString(dgv_mn.CurrentRow.Cells[1].Value);
            string telefon = Convert.ToString(dgv_mn.CurrentRow.Cells[2].Value);
            string website = Convert.ToString(dgv_mn.CurrentRow.Cells[3].Value);

            AddManufacturers form = new AddManufacturers(false, nume,email,telefon,website);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
            db.AfisareDGV(dgv_mn);
        }

        private void bt_mn_delete_Click(object sender, EventArgs e)
        {
            string nume = Convert.ToString(dgv_mn.CurrentRow.Cells[0].Value);
            if (dgv_mn.SelectedRows.Count ==1)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete "+ nume +"?", "Delete Manufacturer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    db.DeleteFurnizor_Producator("Producatori", nume);
                    db.AfisareDGV(dgv_mn);
                }
                
            }
        }

        private void bt_sp_editSupplier_Click(object sender, EventArgs e)
        {
            string nume = Convert.ToString(dgv_sp.CurrentRow.Cells[0].Value);
            string email = Convert.ToString(dgv_sp.CurrentRow.Cells[1].Value);
            string telefon = Convert.ToString(dgv_sp.CurrentRow.Cells[2].Value);
            string website = Convert.ToString(dgv_sp.CurrentRow.Cells[3].Value);

            AddSuppliers form = new AddSuppliers(false, nume, email, telefon, website);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
            db.AfisareDGV(dgv_sp);
        }

        private void bt_sp_deleteSupplier_Click(object sender, EventArgs e)
        {
            string nume = Convert.ToString(dgv_sp.CurrentRow.Cells[0].Value);
            if (dgv_sp.SelectedRows.Count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + nume + "?", "Delete Supplier", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    db.DeleteFurnizor_Producator("Furnizori", nume);
                    db.AfisareDGV(dgv_sp);
                }

            }
        }

        private void bt_pr_editProduct_Click(object sender, EventArgs e)
        {
            string nume = Convert.ToString(dgv_pr.CurrentRow.Cells[2].Value);
            string manufacturer = Convert.ToString(dgv_pr.CurrentRow.Cells[3].Value);
            string supplier = Convert.ToString(dgv_pr.CurrentRow.Cells[4].Value);
            string stock = Convert.ToString(dgv_pr.CurrentRow.Cells[5].Value);
            string category = Convert.ToString(dgv_pr.CurrentRow.Cells[6].Value);
            string exp_date = Convert.ToString(dgv_pr.CurrentRow.Cells[7].Value);
            string price = Convert.ToString(dgv_pr.CurrentRow.Cells[8].Value);
            string purch_date = Convert.ToString(dgv_pr.CurrentRow.Cells[9].Value);

            AddProduct form= new AddProduct(false,nume,manufacturer,supplier,stock,category,exp_date,price,purch_date);
            form.StartPosition=FormStartPosition.CenterParent;
            form.ShowDialog();
            db.AfisareDGV(dgv_pr);
        }

        private void bt_pr_deleteProduct_Click(object sender, EventArgs e)
        {
            string nume = Convert.ToString(dgv_pr.CurrentRow.Cells[2].Value);
            if (dgv_pr.SelectedRows.Count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + nume + "?", "Delete Product", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    db.DeleteProduct(nume);
                    db.AfisareDGV(dgv_pr);
                }

            }
        }

        private void pn_pos_2_Paint(object sender, PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics, this.panel_pos_2.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
            g1 = panel_pos_2.CreateGraphics();

            Color col = Color.LightGray; 
            ButtonBorderStyle bbs = ButtonBorderStyle.Solid; 
            int thickness = 2; 
            ControlPaint.DrawBorder(e.Graphics, this.panel_pos_2.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);

            Rectangle bounds = new Rectangle(20, 20, panel_pos_2.Width - 450, 40);
            myPen.Width = 1; myPen.Color = Color.LightGray;
            myBrush = new SolidBrush(Color.LightGray);
            lb_pos2_item.BackColor = Color.LightGray; lb_pos2_item.Location = new Point(110, 30);
            lb_pos2_Qty.BackColor = Color.LightGray; lb_pos2_Qty.Location= new Point(panel_pos_2.Width-950, 30);
            lb_pos2_Price.BackColor = Color.LightGray; lb_pos2_Price.Location = new Point(lb_pos2_Qty.Width + lb_pos2_Qty.Location.X + 150, 30);
            lb_pos2_total.BackColor = Color.LightGray; lb_pos2_total.Location = new Point(lb_pos2_Price.Width + lb_pos2_Price.Location.X + 150, 30);
            Paint_methods.FillRoundedRectangle(g1, myBrush, bounds, 2);

            bounds = new Rectangle(panel_pos_2.Width - 400, 20, 370, panel_pos_2.Height/2);
            myPen.Width = 1; myPen.Color = Color.FromArgb(232,206,132);
            myBrush = new SolidBrush(Color.FromArgb(232, 206, 132));
            Paint_methods.FillRoundedRectangle(g1, myBrush, bounds, 2);
            
            lb_pos2_discount.Location = new Point(panel_pos_2.Width-380,43);
            txt_pos2_dis.Location = new Point(panel_pos_2.Width - 200, 40);

            lb_pos2_tax.Location = new Point(panel_pos_2.Width - 380, 93);
            cb_pos2_tax.Location = new Point(panel_pos_2.Width - 200, 90);

            lb_pos2_gtotal.Location= new Point(panel_pos_2.Width - 380, 143);
            lb_pos2_gtotalval.Location= new Point(panel_pos_2.Width - 200, 143);

            lb_pos2_Payments.Location = new Point(panel_pos_2.Width - 380, 193);
            bt_pos2_addPayment.Location = new Point(panel_pos_2.Width - 100, 185);

            cb_pos2_payMethod1.Location = new Point(panel_pos_2.Width - 380, 243);
            txt_pos2_payValue1.Location = new Point(panel_pos_2.Width - 200, 243);

            lb_pos2_change.Location = new Point(panel_pos_2.Width - 380, 303);
            lb_pos2_changeval.Location = new Point(panel_pos_2.Width - 200, 303);

            bt_pos2_pay.Location = new Point(panel_pos_2.Width - 380, 353);
            bt_pos2_void.Location = new Point(panel_pos_2.Width - 140, 353);



        }

        private void bt_dash_POS_Click(object sender, EventArgs e)
        {
            panelProducts.Hide();
            panelSuppliers.Hide();
            panel_manufacturers.Hide();
            Panel_Dashboard.Hide();
            panel_pos.Show();
            panel_pos2_scrollItems.Location = new Point(20, 65);
            panel_pos2_scrollItems.Size = new Size(panel_pos_2.Width - 450, panel_pos_2.Height - 85);
            db.Bind_Data_POSProducts(cb_pos_find);
            
            
        }

        private void panel_pos_2_SizeChanged(object sender, EventArgs e)
        {

            panel_pos_2.Hide();
            panel_pos_2.Show();
            

        }

        protected void nm_ValueChanged(object sender, EventArgs e)
        {
            string x = (sender as NumericUpDown).Name;
            string val = (sender as NumericUpDown).Value.ToString(); 
            string[] values = x.Split('_');
            int index = int.Parse(values[1]);
            float pretI= float.Parse(list[index].total.Text);
            float prett = float.Parse(val) * float.Parse(list[index].pret.Text);
            string numeP = list[index].numeProdus.Text; string pret = list[index].pret.Text; string pretT= Convert.ToString(prett);
            PanelProduse panelt = list[index];
            panelt.panel.Controls.Clear();
            list.RemoveAt(index);
            this.panel_pos2_scrollItems.Controls.Remove(panelt.panel);

            panelt = new PanelProduse();
            panelt.panel = new Panel();
            panelt.panel.Name = "pn_" + index;
            panelt.panel.BackColor = Color.AliceBlue;
            panelt.panel.Location = new Point(0, (55 * lastIndex - 55));
            panelt.panel.Size = new Size(panel_pos2_scrollItems.Width, 50);
            panelt.panel.Show();

            panelt.cb = new CustomControls.CustomButtons();
            panelt.cb.Name = "bt_" + index;
            panelt.cb.Image = WindowsFormsApp1.Properties.Resources.Delete_1;
            panelt.cb.ImageAlign = ContentAlignment.MiddleCenter;
            panelt.cb.BackColor = Color.FromArgb(201, 48, 43);
            panelt.cb.Size = new Size(35, 35);
            panelt.cb.Location = new Point(20, 6);
            panelt.cb.BorderRadius = 5; panelt.cb.BorderColor = Color.FromArgb(201, 48, 43); panelt.cb.BorderSize = 1;

            panelt.numeProdus = new Label();
            panelt.numeProdus.Location = new Point(90, 15);
            panelt.numeProdus.AutoSize = true;
            if (cb_pos_find.Text.Length > 80) panelt.numeProdus.Font = new Font("Leelawadee UI", 8);
            else panelt.numeProdus.Font = new Font("Leelawadee UI", 10);
            panelt.numeProdus.Text = numeP;


            panelt.nm = new NumericUpDown();
            panelt.nm.Minimum = 1;
            panelt.nm.Location = new Point(panel_pos_2.Width - 965, 13);
            panelt.nm.Name = "nm_" + index;
            panelt.nm.Font = new Font("Leelawadee UI", 10);
            panelt.nm.Size = new Size(53, 17);
            panelt.nm.Value = Decimal.Parse(val); panelt.nm.Increment = 1;
            panelt.nm.ValueChanged += new EventHandler(this.nm_ValueChanged);

            panelt.pret = new Label();
            panelt.pret.Size = new Size(70, 17);
            panelt.pret.Font = new Font("Leelawadee UI", 10);
            panelt.pret.Text = Convert.ToString(db.FindPriceOfProduct(numeP));
            if (Convert.ToString(db.FindPriceOfProduct(numeP)).Length > 4) panelt.pret.Location = new Point(lb_pos2_Qty.Width + lb_pos2_Qty.Location.X + 140, 15);
            else if (Convert.ToString(db.FindPriceOfProduct(numeP)).Length == 2) panelt.pret.Location = new Point(lb_pos2_Qty.Width + lb_pos2_Qty.Location.X + 140, 15);
            else if (Convert.ToString(db.FindPriceOfProduct(numeP)).Length == 4) panelt.pret.Location = new Point(lb_pos2_Qty.Width + lb_pos2_Qty.Location.X + 140, 15);

            panelt.total = new Label();
            panelt.total.Size = new Size(70, 17);
            panelt.total.Font = new Font("Leelawadee UI", 10);
            panelt.total.Text = pretT;
            if (panelt.total.Text.Length > 4) panelt.total.Location = new Point(panelt.pret.Width + panelt.pret.Location.X + 140, 15);
            else if (panelt.total.Text.Length == 2) panelt.total.Location = new Point(panelt.pret.Width + panelt.pret.Location.X + 140, 15);
            else if (panelt.total.Text.Length == 4) panelt.total.Location = new Point(panelt.pret.Width + panelt.pret.Location.X + 140, 15);


            panelt.panel.Controls.Add(panelt.cb);
            panelt.panel.Controls.Add(panelt.numeProdus);
            panelt.panel.Controls.Add(panelt.nm);
            panelt.panel.Controls.Add(panelt.pret);
            panelt.panel.Controls.Add(panelt.total);
            list.Insert(index,panelt);
            GrandTotal = GrandTotal +(prett-pretI);
            GrandTotal = (float)System.Math.Round(GrandTotal, 2);
            lb_pos2_gtotalval.Text = Convert.ToString(GrandTotal)+" RON";
            this.panel_pos2_scrollItems.Controls.Add(panelt.panel);

        }

        private void cb_pos_find_SelectedValueChanged(object sender, EventArgs e)
        {
            if(lastIndex==0)
            {
                PanelProduse panelt = new PanelProduse();
                list.Add(panelt);
            }

            if(cb_pos_find.Text.Length>0)
            {
                string nume = cb_pos_find.Text;
                lastIndex = list.Count;


                PanelProduse panelt = new PanelProduse();
                panelt.panel = new Panel();
                panelt.panel.Name = "pn_" + lastIndex;
                panelt.panel.BackColor = Color.AliceBlue;
                panelt.panel.Location = new Point(0, (55 * lastIndex - 55));
                panelt.panel.Size = new Size(panel_pos2_scrollItems.Width, 50);
                panelt.panel.Show();
                
                panelt.cb = new CustomControls.CustomButtons();
                panelt.cb.Name = "bt_" + lastIndex;
                panelt.cb.Image = WindowsFormsApp1.Properties.Resources.Delete_1;
                panelt.cb.ImageAlign = ContentAlignment.MiddleCenter;
                panelt.cb.BackColor = Color.FromArgb(201, 48, 43);
                panelt.cb.Size = new Size(35, 35);
                panelt.cb.Location = new Point(20, 6);
                panelt.cb.BorderRadius = 5; panelt.cb.BorderColor = Color.FromArgb(201, 48, 43); panelt.cb.BorderSize = 1;
                
                panelt.numeProdus = new Label();
                panelt.numeProdus.Location = new Point(90, 15);
                panelt.numeProdus.AutoSize = true;
                if(cb_pos_find.Text.Length>80) panelt.numeProdus.Font = new Font("Leelawadee UI", 8);
                else panelt.numeProdus.Font = new Font("Leelawadee UI", 10);
                panelt.numeProdus.Text = Convert.ToString(cb_pos_find.SelectedItem);
                

                panelt.nm = new NumericUpDown();
                panelt.nm.Minimum = 1;
                panelt.nm.Location = new Point(panel_pos_2.Width - 965, 13);
                panelt.nm.Name = "nm_" + lastIndex;
                panelt.nm.Font = new Font("Leelawadee UI", 10);
                panelt.nm.Size = new Size(53, 17);
                panelt.nm.Value = 1; panelt.nm.Increment = 1;
                panelt.nm.ValueChanged += new EventHandler(this.nm_ValueChanged);
               
                panelt.pret = new Label();
                panelt.pret.Size = new Size(70, 17);
                panelt.pret.Font = new Font("Leelawadee UI", 10);
                panelt.pret.Text = Convert.ToString(db.FindPriceOfProduct(nume));
                if(Convert.ToString(db.FindPriceOfProduct(nume)).Length>4) panelt.pret.Location = new Point(lb_pos2_Qty.Width + lb_pos2_Qty.Location.X + 140, 15);
                else if (Convert.ToString(db.FindPriceOfProduct(nume)).Length == 2 ) panelt.pret.Location = new Point(lb_pos2_Qty.Width + lb_pos2_Qty.Location.X + 140, 15);
                else if (Convert.ToString(db.FindPriceOfProduct(nume)).Length == 4) panelt.pret.Location = new Point(lb_pos2_Qty.Width + lb_pos2_Qty.Location.X + 140, 15);

                panelt.total = new Label();
                panelt.total.Size = new Size(70, 17);
                panelt.total.Font = new Font("Leelawadee UI", 10);
                string nms= panelt.nm.Value.ToString(); float prett= float.Parse(nms) * float.Parse(panelt.pret.Text) ;
                panelt.total.Text = Convert.ToString(prett);
                if (panelt.total.Text.Length > 4) panelt.total.Location = new Point(panelt.pret.Width + panelt.pret.Location.X + 140, 15);
                else if (panelt.total.Text.Length == 2) panelt.total.Location = new Point(panelt.pret.Width + panelt.pret.Location.X + 140, 15);
                else if (panelt.total.Text.Length == 4) panelt.total.Location = new Point(panelt.pret.Width + panelt.pret.Location.X + 140, 15);


                panelt.panel.Controls.Add(panelt.cb);
                panelt.panel.Controls.Add(panelt.numeProdus);
                panelt.panel.Controls.Add(panelt.nm);
                panelt.panel.Controls.Add(panelt.pret);
                panelt.panel.Controls.Add(panelt.total);
                list.Add(panelt);
                GrandTotal += prett;
                GrandTotal =(float)System.Math.Round(GrandTotal, 2);
                lb_pos2_gtotalval.Text = Convert.ToString(GrandTotal) + " RON";
                this.panel_pos2_scrollItems.Controls.Add(panelt.panel);
                cb_pos_find.Text = null;
            }            
        }

        private void txt_pos2_payValue1_TextChanged(object sender, EventArgs e)
        {
            if(txt_pos2_payValue1.Text.Length>0)
            {
                float payValue = float.Parse(txt_pos2_payValue1.Text);
                if (payValue > GrandTotal)
                {
                    Change = GrandTotal - payValue;
                    Change = (float)System.Math.Round(Change, 2);
                }
                else
                    Change = 0;

                lb_pos2_changeval.Text = Convert.ToString(Change) + " RON";
            }
            
        }

        private void bt_pos2_pay_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Did you receive " + GrandTotal.ToString() + "?", "Final Sell", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                for(int i=1;i<list.Count;i++)
                {
                    db.InsertSell(list[i].numeProdus, list[i].nm, list[i].total);
                }

                panel_pos2_scrollItems.Controls.Clear();
                list.Clear();
                GrandTotal = 0; Change = 0;
                lb_pos2_changeval.Text = ""; lb_pos2_gtotalval.Text = ""; txt_pos2_payValue1.Text = "";
                txt_pos2_dis.Text = "0";
                cb_pos2_tax.SelectedIndex = cb_pos2_tax.FindStringExact("19%");
                cb_pos2_payMethod1.SelectedIndex = cb_pos2_payMethod1.FindStringExact("Cash");

            }

            
        }

        private void bt_pos2_void_Click(object sender, EventArgs e)
        {
            panel_pos2_scrollItems.Controls.Clear();
            list.Clear();
            GrandTotal = 0; Change = 0;
            lb_pos2_changeval.Text = ""; lb_pos2_gtotalval.Text = ""; txt_pos2_payValue1.Text = "";
            txt_pos2_dis.Text = "0";
            cb_pos2_tax.SelectedIndex = cb_pos2_tax.FindStringExact("19%");
            cb_pos2_payMethod1.SelectedIndex = cb_pos2_payMethod1.FindStringExact("Cash");
        }
    }
}
