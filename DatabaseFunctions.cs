using Oracle.ManagedDataAccess.Client;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public class DatabaseFunctions
    {

        OracleConnection cnn = new OracleConnection("Data Source=localhost/xe;User Id=system;Password=admin123;");
        OracleCommand command;
        OracleDataAdapter adpt;
        DataSet ds;
        DataTable dt;

        public DatabaseFunctions() {}

        public void Bind_Data_AddProductsForm(ComboBox cb1,ComboBox cb2, ComboBox cb3)
        {

            cnn.Open();
            command = new OracleCommand("SELECT numeProducator From Producatori", cnn);
            command.ExecuteNonQuery();
            adpt = new OracleDataAdapter(command);
            ds = new DataSet();
            adpt.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                cb1.Items.Add(ds.Tables[0].Rows[i][0]);

            }



            command = new OracleCommand("SELECT numeFurnizor From Furnizori", cnn);
            command.ExecuteNonQuery();
            adpt = new OracleDataAdapter(command);
            ds = new DataSet();
            adpt.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                cb2.Items.Add(ds.Tables[0].Rows[i][0]);

            }

            command = new OracleCommand("SELECT DISTINCT(categorie) From Produse", cnn);
            command.ExecuteNonQuery();
            adpt = new OracleDataAdapter(command);
            ds = new DataSet();
            adpt.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                cb3.Items.Add(ds.Tables[0].Rows[i][0]);

            }

            cnn.Close();

        }

        public int GetLastIDValue(string nume_tabel)
        {
            int id=0;
            string option = null;
            if (nume_tabel == "Producatori")
            {
                option = "Idproducator";
            } else if(nume_tabel == "Furnizori")
            {
                option = "Idfurnizor";
            }else if (nume_tabel == "Produse")
            {
                option = "Idprodus";
            }else if (nume_tabel == "Vanzari")
            {
                option = "IdVanzare";
            }

            cnn.Open();
            command = new OracleCommand("SELECT MAX("+ option +") FROM "+ nume_tabel, cnn);
            var dr2 = command.ExecuteReader();
            if (dr2.HasRows)
            {
                dr2.Read();
                id = dr2.GetInt32(0);
                
            }
            else { id = 1; }
            dr2.Close();
            cnn.Close();
            return id;

        }

        public void InsertProduct(TextBox nume_produs,ComboBox nume_producator,ComboBox nume_furnizor,TextBox stoc,ComboBox categorie,DateTimePicker data_expirare,TextBox price, DateTimePicker data_cumparare)
        {
            int id = GetLastIDValue("Produse");
        
            cnn.Open();
            command = new OracleCommand("INSERT INTO Produse VALUES(" +
                + ++id + "," +
                "'" + nume_produs.Text + "'," +
                "(SELECT IdProducator FROM Producatori WHERE numeProducator='" + nume_producator.Text + "')," +
                "(SELECT IdFurnizor FROM Furnizori WHERE numeFurnizor='" + nume_furnizor.Text + "')," +
                "" + stoc.Text + "," +
                "'" + categorie.Text + "'," +
                "TO_DATE('"+ data_expirare.Value.Day +"/"+data_expirare.Value.Month +"/"+data_expirare.Value.Year+"','DD/MM/YYYY')" +"," +
                ""+ price.Text  +"," +
                "TO_DATE('"+ data_cumparare.Value.Day +"/"+data_cumparare.Value.Month +"/"+data_cumparare.Value.Year+"', 'DD/MM/YYYY')" +")", cnn) ;
            command.ExecuteNonQuery();
            cnn.Close();
        }

        public void EditProduct(TextBox nume, ComboBox nume_producator, ComboBox nume_furnizor, TextBox stoc, ComboBox categorie, DateTimePicker data_expirare, TextBox price, DateTimePicker data_cumparare)
        {
            int id = 0,idp=0,idf=0;
            cnn.Open();
            command = new OracleCommand("SELECT IdProdus FROM Produse WHERE numeProdus= '" + nume.Text + "'", cnn);
            var dr2 = command.ExecuteReader();
            if (dr2.HasRows)
            {
                dr2.Read();
                id = dr2.GetInt32(0);

            }
            dr2.Close();

            command = new OracleCommand("SELECT IdProducator,IdFurnizor FROM Produse WHERE IdProducator= (SELECT idProducator FROM Producatori WHERE numeProducator = '"+ nume_producator.Text +"') AND IdFurnizor = (SELECT idFurnizor FROM Furnizori WHERE numeFurnizor= '"+nume_furnizor.Text +"')", cnn);
            var dr3 = command.ExecuteReader();
            if (dr3.HasRows)
            {
                dr3.Read();
                idp = dr3.GetInt32(0);
                idf = dr3.GetInt32(1);

            }
            dr3.Close();

            command = new OracleCommand("UPDATE Produse SET numeProdus ='" + nume.Text + "',IdProducator=" + idp + ",IdFurnizor=" + idf + ",stoc=" + stoc.Text  + ",categorie='"+ categorie.Text + "',data_exp= TO_DATE('"+ data_expirare.Value.Day +"/"+data_expirare.Value.Month +"/"+data_expirare.Value.Year+"','DD/MM/YYYY'), RRP="+ price.Text + ",data_cumpararii= TO_DATE('"+ data_cumparare.Value.Day +"/"+data_cumparare.Value.Month +"/"+data_cumparare.Value.Year+"', 'DD/MM/YYYY') WHERE IdProdus = " + id, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }

        public void DeleteProduct(string nume)
        {
            int id = 0;
            cnn.Open();
            command = new OracleCommand("SELECT idProdus FROM Produse WHERE numeProdus= '" + nume + "'", cnn);
            var dr2 = command.ExecuteReader();
            if (dr2.HasRows)
            {
                dr2.Read();
                id = dr2.GetInt32(0);
            }
            dr2.Close();

            
            command = new OracleCommand("DELETE FROM Produse WHERE idProdus=" + id, cnn);
            command.ExecuteNonQuery();
            cnn.Close();

        }

        public void AfisareDGV(DataGridView dgv)
        {

            if (dgv.Name == "dgv_pr")
            {
                adpt = new OracleDataAdapter("SELECT p.IdProdus AS Product_Id, p.numeProdus AS Product_Name, pr.numeProducator AS Manufacturer, f.numeFurnizor AS Supplier, p.stoc AS Stock, p.categorie AS Category, TO_CHAR(p.data_exp,'DD/MM/YYYY') AS Expiration_Date,p.RRP AS Price,TO_CHAR(p.data_cumpararii,'DD/MM/YYYY') AS Purchase_Date FROM Produse p,Producatori pr,Furnizori f WHERE p.idProducator=pr.IdProducator AND p.idFurnizor=f.IdFurnizor", cnn);
            }
            else if (dgv.Name == "dgv_sp")
            {
                adpt = new OracleDataAdapter("SELECT numeFurnizor AS Supplier_Name, email AS Email, telefon AS Phone_Number, website AS Website FROM Furnizori", cnn);
            }
            else if (dgv.Name == "dgv_mn")
            {
                adpt = new OracleDataAdapter("SELECT numeProducator AS Manufacturer_Name, email AS Email, telefon AS Phone_Number, website AS Website FROM Producatori", cnn);

            }
            dt = new DataTable();
            adpt.Fill(dt);
            dgv.DataSource = dt;

            if (dgv.Name == "dgv_pr")
            {
                dgv.Columns[0].Width = 60; dgv.Columns[0].ReadOnly = false;
            }
            else 
            {
                dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; dgv.Columns[0].ReadOnly = true;
            }

            for (int i = 1; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; dgv.Columns[i].ReadOnly = true;
            }



            // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
            for (int i = 0; i <= dgv.Columns.Count - 1; i++)
            {
                // Store Auto Sized Widths:
                int colw = dgv.Columns[i].Width;
                // Remove AutoSizing:
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                // Set Width to calculated AutoSize value:
                dgv.Columns[i].Width = colw;
            }


            if (dgv.Name == "dgv_pr")
            {
                dgv.Sort(dgv.Columns[2], ListSortDirection.Ascending);
            }
            else if (dgv.Name == "dgv_sp")
            {
                dgv.Sort(dgv.Columns[0], ListSortDirection.Ascending);
            }
            else if (dgv.Name == "dgv_mn")
            {
                dgv.Sort(dgv.Columns[0], ListSortDirection.Ascending);
            }


        }

        public void InsertFurnizor_Producator(string numeTabel,TextBox nume,TextBox email,TextBox telefon,TextBox website)
        {
            int id = GetLastIDValue(numeTabel);

            if(numeTabel == "Furnizori")
            {
                cnn.Open();
                command = new OracleCommand("INSERT INTO Furnizori VALUES(" + ++id + ",'" + nume.Text + "','" + email.Text + "','" + telefon.Text + "','" + website.Text + "')", cnn);
                command.ExecuteNonQuery();
                cnn.Close();
            }else if (numeTabel == "Producatori")
            {
                cnn.Open();
                command = new OracleCommand("INSERT INTO Producatori VALUES(" + ++id + ",'" + nume.Text + "','" + email.Text + "','" + telefon.Text + "','" + website.Text + "')", cnn);
                command.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public void EditFurnizor_Producator(string numeTabel, TextBox nume, TextBox email, TextBox telefon, TextBox website)
        {
            int id=0;
            if (numeTabel == "Furnizori")
            { 
                cnn.Open();
                command = new OracleCommand("SELECT idFurnizor FROM Furnizori WHERE numeFurnizor= '"+ nume.Text +"'", cnn);
                var dr2 = command.ExecuteReader();
                if (dr2.HasRows)
                {
                    dr2.Read();
                    id = dr2.GetInt32(0);

                }
                else { id = 1; }
                dr2.Close();
                
                command = new OracleCommand("UPDATE Furnizori SET numeFurnizor ='" + nume.Text + "',email='" + email.Text + "',telefon='" + telefon.Text + "',website='" + website.Text + "' WHERE IdFurnizor = " + id, cnn);
                command.ExecuteNonQuery();
                cnn.Close();

            }
            else if (numeTabel == "Producatori")
            {
                cnn.Open();
                command = new OracleCommand("SELECT idProducator FROM Producatori WHERE numeProducator= '" + nume.Text + "'", cnn);
                var dr2 = command.ExecuteReader();
                if (dr2.HasRows)
                {
                    dr2.Read();
                    id = dr2.GetInt32(0);

                }
                dr2.Close();
                command = new OracleCommand("UPDATE Producatori SET numeProducator ='" + nume.Text + "',email='" + email.Text + "',telefon='" + telefon.Text + "',website='" + website.Text + "' WHERE IdProducator = " + id, cnn);
                command.ExecuteNonQuery();
                cnn.Close();
            }
        }


        public void DeleteFurnizor_Producator(string numeTabel, string nume)
        {
            int id=0,nr = 0;
            if (numeTabel == "Furnizori")
            {
                cnn.Open();
                command = new OracleCommand("SELECT idFurnizor FROM Furnizori WHERE numeFurnizor= '" + nume + "'", cnn);
                var dr2 = command.ExecuteReader();
                if (dr2.HasRows)
                {
                    dr2.Read();
                    id = dr2.GetInt32(0);
                }
                dr2.Close();

                //Check if there are any products associated
                command = new OracleCommand("SELECT COUNT(numeProdus) FROM Produse WHERE IdFurnizor= "+id, cnn);
                var dr3 = command.ExecuteReader();
                if (dr3.HasRows)
                {
                    dr3.Read();
                    nr = dr3.GetInt32(0);
                }
                dr3.Close();

                if(nr>0)
                {
                    DialogResult dialogResult = MessageBox.Show("There are existing products supplied by " + nume + ". Are you sure that you also want to delete all products supplied by "+ nume+"?", "Delete Supplier", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        command = new OracleCommand("DELETE FROM Produse WHERE idFurnizor=" + id, cnn);
                        command.ExecuteNonQuery();

                        command = new OracleCommand("DELETE FROM Furnizori WHERE idFurnizor=" + id, cnn);
                        command.ExecuteNonQuery();
                        cnn.Close();
                    }
                }else
                {
                    command = new OracleCommand("DELETE FROM Furnizori WHERE idFurnizor=" + id, cnn);
                    command.ExecuteNonQuery();
                    cnn.Close();
                }
                cnn.Close();
            }
            else if (numeTabel == "Producatori")
            {
                cnn.Open();
                command = new OracleCommand("SELECT idProducator FROM Producatori WHERE numeProducator= '" + nume + "'", cnn);
                var dr2 = command.ExecuteReader();
                if (dr2.HasRows)
                {
                    dr2.Read();
                    id = dr2.GetInt32(0);

                }
                dr2.Close();

                //Check if there are any products associated
                command = new OracleCommand("SELECT COUNT(numeProdus) FROM Produse WHERE IdProducator= " + id, cnn);
                var dr3 = command.ExecuteReader();
                if (dr3.HasRows)
                {
                    dr3.Read();
                    nr = dr3.GetInt32(0);
                }
                dr3.Close();

                if (nr > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("There are existing products produced by " + nume + ". Are you sure that you also want to delete all products produced by " + nume + "?", "Delete Manufacturer", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        command = new OracleCommand("DELETE FROM Produse WHERE idProducator=" + id, cnn);
                        command.ExecuteNonQuery();

                        command = new OracleCommand("DELETE FROM Producatori WHERE idProducator=" + id, cnn);
                        command.ExecuteNonQuery();
                        cnn.Close();
                    }
                }
                else
                {
                    command = new OracleCommand("DELETE FROM Producatori WHERE idProducator=" + id, cnn);
                    command.ExecuteNonQuery();
                    cnn.Close();
                }
                cnn.Close();

                
            }
        }

        public void Bind_Data_POSProducts(ComboBox cb1)
        {

            cnn.Open();
            command = new OracleCommand("SELECT DISTINCT(numeProdus) From Produse", cnn);
            command.ExecuteNonQuery();
            adpt = new OracleDataAdapter(command);
            ds = new DataSet();
            adpt.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                cb1.Items.Add(ds.Tables[0].Rows[i][0]);

            }
            cnn.Close();

        }

        public int FindIdOfItem(string nume)
        {
            int id = 0;
            cnn.Open();
            command = new OracleCommand("SELECT idProdus FROM Produse WHERE numeProdus= '" + nume + "'", cnn);
            var dr2 = command.ExecuteReader();
            if (dr2.HasRows)
            {
                dr2.Read();
                id = dr2.GetInt32(0);
            }
            dr2.Close();
            cnn.Close();
            return id;
        }

        public float FindPriceOfProduct(string nume)
        {
            float rrp = 0;
            cnn.Open();
            command = new OracleCommand("SELECT rrp FROM Produse WHERE numeProdus= '" + nume + "'", cnn);
            var dr2 = command.ExecuteReader();
            if (dr2.HasRows)
            {
                dr2.Read();
                rrp = dr2.GetFloat(0);
            }
            dr2.Close();
            cnn.Close();
            return rrp;
        }

        public void InsertSell(Label numeProdus,NumericUpDown nm, Label total)
        {
            int id=GetLastIDValue("Vanzari");

            int idPr = FindIdOfItem(numeProdus.Text);
            DateTime dateTime = DateTime.Now;
            cnn.Open();
            command = new OracleCommand("INSERT INTO Vanzari VALUES(" + ++id + "," + idPr + "," + nm.Value.ToString() + ",TO_DATE('" + dateTime.Day + "/"+ dateTime.Month +"/"+ dateTime.Year +"','DD/MM/YYYY')," + total.Text.Replace(',', '.') + ")", cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }


    }
}
