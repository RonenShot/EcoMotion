using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EcoMotion.UTILITIES;
using EcoMotion.BL;

namespace EcoMotion.FORMS
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        
        int count = 0;
        DataTable Tinventory;
        DialogResult dr;
        private bool CheckDetails(Inventory i)
        {
            bool check = true;
            try
            {
                i.InventoryID = inventoryId_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(inventoryId_txtbox, "enter inventory ID in correct format");
                check = false;
            }
            try
            {
                i.MotorID = motorID_cmb.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(motorID_cmb, "enter motor ID in correct format");
                check = false;
            }
            try
            {
                i.Supplier = supplier_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(supplier_txtbox, "enter supplier in correct format");
                check = false;
            }
            try
            {
                i.ManuDate = manuDate_dtp.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(manuDate_dtp, "enter manufactur date in correct format");
                check = false;
            }
            try
            {
                i.Price = price_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(price_txtbox, "enter price in correct format");
                check = false;
            }
            try
            {
                i.Active = active_cmbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(active_cmbox, "enter active in correct format");
                check = false;
            }
            try
            {
                i.Quntity = quantity_txt.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(quantity_txt, "enter quantity required in correct format");
                check = false;
            }
            try
            {
                i.QuntityInstock = quntityInstock_txt.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(quntityInstock_txt, "enter actual quantity in stock in correct format");
                check = false;
            }
            
            return check;


        }
        private void frmInventory_Load(object sender, EventArgs e)
        {
            Location = new Point(200, 200);
            Tinventory = DAL.dbEcoMotion.OpenTable("Inventory");
            UTILITIES.DisplayUtilities.FillDataGrid(dataGridView1, Tinventory);
            DisplayRecord(count);
            UTILITIES.DisplayUtilities.FillDataGrid(dataGridView1, Tinventory);
            count = 0;
            DataTable TmotorID = DAL.dbEcoMotion.OpenTable("Motor");
            motorID_cmb.Items.Clear();
            for (int i = 0; i < TmotorID.Rows.Count; i++)
            {
                motorID_cmb.Items.Add(TmotorID.Rows[i][0].ToString());
            }
            errorProvider1.Clear();
        }
        private void DisplayRecord(int numRow)
        {
            inventoryId_txtbox.Text = dataGridView1.Rows[numRow].Cells[0].Value.ToString();
            motorID_cmb.Text = dataGridView1.Rows[numRow].Cells[1].Value.ToString();
            supplier_txtbox.Text = dataGridView1.Rows[numRow].Cells[2].Value.ToString();
            manuDate_dtp.Text = dataGridView1.Rows[numRow].Cells[3].Value.ToString();
            price_txtbox.Text = dataGridView1.Rows[numRow].Cells[4].Value.ToString();
            active_cmbox.Text = dataGridView1.Rows[numRow].Cells[5].Value.ToString();
            quantity_txt.Text = dataGridView1.Rows[numRow].Cells[6].Value.ToString();
            quntityInstock_txt.Text = dataGridView1.Rows[numRow].Cells[7].Value.ToString();
            
        }

        private void movePrev_btn_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MoveNext(Tinventory, count);
            DisplayRecord(count);
        }

        private void moveLast_btn_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToLast(Tinventory, count));
        }
        private void moveNext_btn_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MoveNext(Tinventory, count);
            DisplayRecord(count);
        }

        private void moveFirst_btn_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToFirst(Tinventory, count));
        }

        private void frmInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void addRecord_btn_Click(object sender, EventArgs e)
        {
            string strSql;
            if (!(DisplayUtilities.ContIsfull(this)))
                MessageBox.Show("חסרים נתונים");
            else
            {

                strSql = "Select * from Inventory where inventoryId='" + inventoryId_txtbox.Text + "'";
                DAL.dbEcoMotion.GetDataSet(strSql);
                if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count > 0)
                    MessageBox.Show("רשומה כבר קיימת");
                else
                {
                    Inventory i = new Inventory();
                    if(CheckDetails(i))
                    {
                        strSql = "INSERT INTO Inventory(inventoryId,motorID,supplier,manuDate,price,active,quntity,quntityInstock) VALUES ('" + inventoryId_txtbox.Text + "','" + motorID_cmb.Text + "','" + supplier_txtbox.Text + "','" + manuDate_dtp.Text + "','" + price_txtbox.Text + "','" + active_cmbox.Text + "','" + quantity_txt.Text + "','" + quntityInstock_txt.Text + "')";
                        MessageBox.Show(GeneralUtilities.AddRecd(Tinventory, strSql));
                        frmInventory_Load(sender, e);
                        inventoryId_txtbox.Clear();

                        supplier_txtbox.Clear();

                        price_txtbox.Clear();
                        quantity_txt.Clear();
                        quntityInstock_txt.Clear();
                    }
                    
                    
                }
            }
        }

        private void addRepairSession_btn_Click(object sender, EventArgs e)
        {
            frmInventory_Load(sender, e);
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
                string strSq1 = "UPDATE Inventory SET active='לא' WHERE inventoryId ='" + inventoryId_txtbox.Text + "'";
                DAL.dbEcoMotion.GetDataSet(strSq1);
                DAL.dbEcoMotion.GetDataSet("Select * from Inventory");
                Tinventory = DAL.dbEcoMotion.ds.Tables[0];
                DisplayRecord(0);
                DisplayRecord(Tinventory.Rows.Count - 1);
            }
        }

        private void updateRecord_btn_Click(object sender, EventArgs e)
        {
            if ((!UTILITIES.DisplayUtilities.ContIsfull(this)))
                MessageBox.Show("חסרים נתונים");
            else
            {
                DAL.dbEcoMotion.GetDataSet("Select * from Inventory where inventoryId='" + inventoryId_txtbox.Text + "'");
                if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("מלאי לא קיים");
                else
                {
                    Inventory i = new Inventory();
                    if(CheckDetails(i))
                    {
                        string strSql = "UPDATE Inventory SET inventoryId='" + inventoryId_txtbox.Text + "',motorID='" + motorID_cmb.Text + "',supplier='" + supplier_txtbox.Text + "',manuDate='" + manuDate_dtp.Text + "',price='" + price_txtbox.Text + "',active='" + active_cmbox.Text + "',quntity='" + quantity_txt.Text + "',quntityInstock='" + quntityInstock_txt.Text + "' WHERE inventoryId='" + inventoryId_txtbox.Text + "' ";
                        MessageBox.Show(UTILITIES.GeneralUtilities.UpDateRecd(Tinventory, strSql));
                        frmInventory_Load(sender, e);
                    }
                    
                }
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            DAL.dbEcoMotion.GetDataSet("Select * from Inventory where inventoryId='" + search_txt.Text + "'");// simple search/
            if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("מלאי לא קיים");
                frmInventory_Load(sender, e);
            }
            else
            {
                DAL.dbEcoMotion.GetDataSet("Select * from Inventory where inventoryId='" + search_txt.Text + "'");
                inventoryId_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["inventoryId"].ToString();
                motorID_cmb.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["motorID"].ToString();
                supplier_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["supplier"].ToString();
                manuDate_dtp.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["manuDate"].ToString();
                price_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["price"].ToString();
                active_cmbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][5].ToString();
                quantity_txt.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][6].ToString();
                quntityInstock_txt.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][7].ToString();
                

            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            inventoryId_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            motorID_cmb.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            supplier_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            manuDate_dtp.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            price_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            active_cmbox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            quantity_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            quntityInstock_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            
        }

        private void clearScreen_Click(object sender, EventArgs e)
        {
            UTILITIES.DisplayUtilities.ClearControls(this);
        }

        private void refreshDisplay_Click(object sender, EventArgs e)
        {
            frmInventory_Load(sender, e);
        }

        private void moveNext_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MoveNext(Tinventory, count);
            DisplayRecord(count);
        }

        private void movePrev_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MovePrev(Tinventory, count);
            DisplayRecord(count);
        }

        private void moveLast_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToLast(Tinventory, count));
        }

        private void moveFirst_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToFirst(Tinventory, count));
        }

        private void addRecord_Click(object sender, EventArgs e)
        {
            string strSql;
            if (!(DisplayUtilities.ContIsfull(this)))
                MessageBox.Show("חסרים נתונים");
            else
            {

                strSql = "Select * from Inventory where inventoryId='" + inventoryId_txtbox.Text + "'";
                DAL.dbEcoMotion.GetDataSet(strSql);
                if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count > 0)
                    MessageBox.Show("רשומה כבר קיימת");
                else
                {
                    Inventory i = new Inventory();
                    if (CheckDetails(i))
                    {
                        strSql = "INSERT INTO Inventory(inventoryId,motorID,supplier,manuDate,price,active,quntity,quntityInstock) VALUES ('" + inventoryId_txtbox.Text + "','" + motorID_cmb.Text + "','" + supplier_txtbox.Text + "','" + manuDate_dtp.Text + "','" + price_txtbox.Text + "','" + active_cmbox.Text + "','" + quantity_txt.Text + "','" + quntityInstock_txt.Text + "')";
                        MessageBox.Show(GeneralUtilities.AddRecd(Tinventory, strSql));
                        frmInventory_Load(sender, e);
                        inventoryId_txtbox.Clear();

                        supplier_txtbox.Clear();

                        price_txtbox.Clear();
                        quantity_txt.Clear();
                        quntityInstock_txt.Clear();
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
                DAL.dbEcoMotion.GetDataSet("Select * from Inventory where inventoryId='" + inventoryId_txtbox.Text + "'");
                if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("מלאי לא קיים");
                else
                {
                    Inventory i = new Inventory();
                    if (CheckDetails(i))
                    {
                        string strSql = "UPDATE Inventory SET inventoryId='" + inventoryId_txtbox.Text + "',motorID='" + motorID_cmb.Text + "',supplier='" + supplier_txtbox.Text + "',manuDate='" + manuDate_dtp.Text + "',price='" + price_txtbox.Text + "',active='" + active_cmbox.Text + "',quntity='" + quantity_txt.Text + "',quntityInstock='" + quntityInstock_txt.Text + "' WHERE inventoryId='" + inventoryId_txtbox.Text + "' ";
                        MessageBox.Show(UTILITIES.GeneralUtilities.UpDateRecd(Tinventory, strSql));
                        frmInventory_Load(sender, e);
                    }

                }
            }
        }

        private void deleteRecord_Click(object sender, EventArgs e)
        {
            dr = MessageBox.Show("are you sure you want to delete this record?", "delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                string strSq1 = "UPDATE Inventory SET active='לא' WHERE inventoryId ='" + inventoryId_txtbox.Text + "'";
                DAL.dbEcoMotion.GetDataSet(strSq1);
                DAL.dbEcoMotion.GetDataSet("Select * from Inventory");
                Tinventory = DAL.dbEcoMotion.ds.Tables[0];
                DisplayRecord(0);
                DisplayRecord(Tinventory.Rows.Count - 1);
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            DAL.dbEcoMotion.GetDataSet("Select * from Inventory where inventoryId='" + search_txt.Text + "'");// simple search/
            if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("מלאי לא קיים");
                frmInventory_Load(sender, e);
            }
            else
            {
                DAL.dbEcoMotion.GetDataSet("Select * from Inventory where inventoryId='" + search_txt.Text + "'");
                inventoryId_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["inventoryId"].ToString();
                motorID_cmb.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["motorID"].ToString();
                supplier_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["supplier"].ToString();
                manuDate_dtp.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["manuDate"].ToString();
                price_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["price"].ToString();
                active_cmbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][5].ToString();
                quantity_txt.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][6].ToString();
                quntityInstock_txt.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][7].ToString();


            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
                
       
