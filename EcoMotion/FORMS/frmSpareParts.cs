using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EcoMotion.BL;

namespace EcoMotion.FORMS
{
    public partial class frmSpareParts : Form
    {
        public frmSpareParts()
        {
            InitializeComponent();
        }
        int count = 0;
        DataTable TspareParts;
        DialogResult dr;
        private void frmSpareParts_Load(object sender, EventArgs e)
        {
            Location = new Point(200, 200);
            TspareParts = DAL.dbEcoMotion.OpenTable("SpareParts");
            UTILITIES.DisplayUtilities.FillDataGrid(dataGridView1, TspareParts);
            DisplayRecord(count);
            UTILITIES.DisplayUtilities.FillDataGrid(dataGridView1, TspareParts);
            count = 0;
        }
        private void DisplayRecord(int numRow)
        {
            idPart_txt.Text = dataGridView1.Rows[numRow].Cells[0].Value.ToString();
            namePart_txt.Text = dataGridView1.Rows[numRow].Cells[1].Value.ToString();
            price_txt.Text = dataGridView1.Rows[numRow].Cells[2].Value.ToString();
            manufcturCountry_txt.Text = dataGridView1.Rows[numRow].Cells[3].Value.ToString();
            quantity_txt.Text = dataGridView1.Rows[numRow].Cells[4].Value.ToString();
            quantityInStock_txt.Text = dataGridView1.Rows[numRow].Cells[5].Value.ToString();
            active_cmb.Text = dataGridView1.Rows[numRow].Cells[6].Value.ToString();

        }
        private bool CheckDetails(SpareParts sp)
        {
           
        bool check = true;
            try
            {
                sp.IdPart = idPart_txt.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(idPart_txt, "enter ID part in correct format");
                check = false;
            }
            try
            {
                sp.NamePart = namePart_txt.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(namePart_txt, "enter name part part in correct format");
                check = false;
            }
            try
            {
                sp.Price = price_txt.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(price_txt, "enter price part in correct format");
                check = false;
            }
            try
            {
                sp.ManufcturCountry = manufcturCountry_txt.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(manufcturCountry_txt, "enter manufctur country in correct format");
                check = false;
            }
            try
            {
                sp.Quantity = quantity_txt.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(quantity_txt, "enter manufctur country in correct format");
                check = false;
            }
            try
            {
                sp.QuantityInStock = quantityInStock_txt.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(quantityInStock_txt, "enter quantity in stock country in correct format");
                check = false;
            }
            try
            {
                sp.Active = active_cmb.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(active_cmb, "enter active country in correct format");
                check = false;
            }
            
            return check;


        }

        private void moveNext_btn_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MoveNext(TspareParts, count);
            DisplayRecord(count);
        }

        private void movePrev_btn_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MoveNext(TspareParts, count);
            DisplayRecord(count);
        }

        private void moveLast_btn_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToLast(TspareParts, count));
        }

        private void moveFirst_btn_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToFirst(TspareParts, count));
        }

        private void frmSpareParts_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void refreshDisplay_btn_Click(object sender, EventArgs e)
        {
            frmSpareParts_Load(sender, e);
        }

        private void clearScr_btn_Click(object sender, EventArgs e)
        {
            UTILITIES.DisplayUtilities.ClearControls(this);
        }

        private void deleteRecord_btn_Click(object sender, EventArgs e)
        {
            dr = MessageBox.Show("are you sure you want to delete this record?", "delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                string strSq1 = "UPDATE SpareParts SET active='לא' WHERE idPart ='" + idPart_txt.Text + "'";
                DAL.dbEcoMotion.GetDataSet(strSq1);
                DAL.dbEcoMotion.GetDataSet("Select * from SpareParts");
                TspareParts = DAL.dbEcoMotion.ds.Tables[0];
                DisplayRecord(0);
                DisplayRecord(TspareParts.Rows.Count - 1);
            }
        }

        private void addRecord_btn_Click(object sender, EventArgs e)
        {
            string strSql;
            if (!(UTILITIES.DisplayUtilities.ContIsfull(this)))
                MessageBox.Show("חסרים נתונים");
            else
            {

                strSql = "Select * from SpareParts where idPart='" + idPart_txt.Text + "'";
                DAL.dbEcoMotion.GetDataSet(strSql);
                if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count > 0)
                    MessageBox.Show("רשומה כבר קיימת");
                else
                {
                    SpareParts sp = new SpareParts();
                    if(CheckDetails(sp))
                    {
                        int code = TspareParts.Rows.Count + 1;
                        strSql = "INSERT INTO SpareParts(idPart,namePart,price,manufcturCountry,quantity,quantityInStock,active) VALUES ('" + "00" + code.ToString() + "','" + namePart_txt.Text + "','" + price_txt.Text + "','" + manufcturCountry_txt.Text + "','" + quantity_txt.Text + "','" + quantityInStock_txt.Text + "','" + active_cmb.Text + "')";
                        MessageBox.Show(UTILITIES.GeneralUtilities.AddRecd(TspareParts, strSql));
                        frmSpareParts_Load(sender, e);
                        idPart_txt.Clear();
                        namePart_txt.Clear();
                        price_txt.Clear();
                        manufcturCountry_txt.Clear();
                        quantity_txt.Clear();
                        quantityInStock_txt.Clear();
                    }
                    

                }
            }
        }

        private void updateRecord_btn_Click(object sender, EventArgs e)
        {
            if ((!UTILITIES.DisplayUtilities.ContIsfull(this)))
                MessageBox.Show("חסרים נתונים");
            else
            {
                DAL.dbEcoMotion.GetDataSet("Select * from SpareParts where idPart='" + idPart_txt.Text + "'");
                if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("חלק חילוף לא קיים");
                else
                {
                    SpareParts sp = new SpareParts();
                    if(CheckDetails(sp))
                    {
                        string strSql = "UPDATE SpareParts SET idPart='" + idPart_txt.Text + "',namePart='" + namePart_txt.Text + "',price='" + price_txt.Text + "',manufcturCountry='" + manufcturCountry_txt.Text + "',quantity='" + quantity_txt.Text + "',quantityInStock='" + quantityInStock_txt.Text + "',active='" + active_cmb.Text + "' WHERE idPart='" + idPart_txt.Text + "' ";
                        MessageBox.Show(UTILITIES.GeneralUtilities.UpDateRecd(TspareParts, strSql));
                        frmSpareParts_Load(sender, e);
                    }
                    
                }
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            DAL.dbEcoMotion.GetDataSet("Select * from SpareParts where idPart='" + search_txt.Text + "'");// simple search/
            if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("חלק חילוף לא קיים");
                frmSpareParts_Load(sender, e);
            }
            else
            {
                DAL.dbEcoMotion.GetDataSet("Select * from SpareParts where idPart='" + search_txt.Text + "'");
                idPart_txt.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["idPart"].ToString();
                namePart_txt.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["namePart"].ToString();
                price_txt.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["price"].ToString();
                manufcturCountry_txt.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["manufcturCountry"].ToString();
                quantity_txt.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["quantity"].ToString();
                quantityInStock_txt.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][5].ToString();
                active_cmb.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][6].ToString();
                

            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idPart_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            namePart_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            price_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            manufcturCountry_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            quantity_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            quantityInStock_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            active_cmb.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            
        }

        private void moveNext_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MoveNext(TspareParts, count);
            DisplayRecord(count);
        }

        private void movePrev_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MovePrev(TspareParts, count);
            DisplayRecord(count);
        }

        private void moveLast_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToLast(TspareParts, count));
        }

        private void moveFirst_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToFirst(TspareParts, count));
        }

        private void clearScreen_Click(object sender, EventArgs e)
        {
            UTILITIES.DisplayUtilities.ClearControls(this);
        }

        private void refreshDisplay_Click(object sender, EventArgs e)
        {
            frmSpareParts_Load(sender, e);
            errorProvider1.Clear();
        }

        private void addRecord_Click(object sender, EventArgs e)
        {
            string strSql;
            if (!(UTILITIES.DisplayUtilities.ContIsfull(this)))
                MessageBox.Show("חסרים נתונים");
            else
            {

                strSql = "Select * from SpareParts where idPart='" + idPart_txt.Text + "'";
                DAL.dbEcoMotion.GetDataSet(strSql);
                if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count > 0)
                    MessageBox.Show("רשומה כבר קיימת");
                else
                {
                    SpareParts sp = new SpareParts();
                    if (CheckDetails(sp))
                    {
                        int code = TspareParts.Rows.Count + 1;
                        strSql = "INSERT INTO SpareParts(idPart,namePart,price,manufcturCountry,quantity,quantityInStock,active) VALUES ('" + "00" + code.ToString() + "','" + namePart_txt.Text + "','" + price_txt.Text + "','" + manufcturCountry_txt.Text + "','" + quantity_txt.Text + "','" + quantityInStock_txt.Text + "','" + active_cmb.Text + "')";
                        MessageBox.Show(UTILITIES.GeneralUtilities.AddRecd(TspareParts, strSql));
                        frmSpareParts_Load(sender, e);
                        idPart_txt.Clear();
                        namePart_txt.Clear();
                        price_txt.Clear();
                        manufcturCountry_txt.Clear();
                        quantity_txt.Clear();
                        quantityInStock_txt.Clear();
                    }


                }
            }
        }

        private void updateRecord_Click(object sender, EventArgs e)
        {
            if ((!UTILITIES.DisplayUtilities.ContIsfull(this)))
                MessageBox.Show("חסרים נתונים");
            else
            {
                DAL.dbEcoMotion.GetDataSet("Select * from SpareParts where idPart='" + idPart_txt.Text + "'");
                if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("חלק חילוף לא קיים");
                else
                {
                    SpareParts sp = new SpareParts();
                    if (CheckDetails(sp))
                    {
                        string strSql = "UPDATE SpareParts SET idPart='" + idPart_txt.Text + "',namePart='" + namePart_txt.Text + "',price='" + price_txt.Text + "',manufcturCountry='" + manufcturCountry_txt.Text + "',quantity='" + quantity_txt.Text + "',quantityInStock='" + quantityInStock_txt.Text + "',active='" + active_cmb.Text + "' WHERE idPart='" + idPart_txt.Text + "' ";
                        MessageBox.Show(UTILITIES.GeneralUtilities.UpDateRecd(TspareParts, strSql));
                        frmSpareParts_Load(sender, e);
                    }

                }
            }
        }

        private void deleteRecord_Click(object sender, EventArgs e)
        {
            dr = MessageBox.Show("are you sure you want to delete this record?", "delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                string strSq1 = "UPDATE SpareParts SET active='לא' WHERE idPart ='" + idPart_txt.Text + "'";
                DAL.dbEcoMotion.GetDataSet(strSq1);
                DAL.dbEcoMotion.GetDataSet("Select * from SpareParts");
                TspareParts = DAL.dbEcoMotion.ds.Tables[0];
                DisplayRecord(0);
                DisplayRecord(TspareParts.Rows.Count - 1);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            DAL.dbEcoMotion.GetDataSet("Select * from SpareParts where idPart='" + search_txt.Text + "'");// simple search/
            if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("חלק חילוף לא קיים");
                frmSpareParts_Load(sender, e);
            }
            else
            {
                DAL.dbEcoMotion.GetDataSet("Select * from SpareParts where idPart='" + search_txt.Text + "'");
                idPart_txt.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["idPart"].ToString();
                namePart_txt.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["namePart"].ToString();
                price_txt.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["price"].ToString();
                manufcturCountry_txt.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["manufcturCountry"].ToString();
                quantity_txt.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["quantity"].ToString();
                quantityInStock_txt.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][5].ToString();
                active_cmb.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][6].ToString();


            }
        }
    }
}