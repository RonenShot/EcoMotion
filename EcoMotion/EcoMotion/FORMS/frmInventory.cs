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

namespace EcoMotion.FORMS
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        private void moveNext_btn_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MoveNext(Tinventory, count);
            DisplayRecord(count);
        }
        int count = 0;
        DataTable Tinventory;
        DialogResult dr;
        private void frmInventory_Load(object sender, EventArgs e)
        {
            Location = new Point(200, 200);
            Tinventory = DAL.dbEcoMotion.OpenTable("Inventory");
            UTILITIES.DisplayUtilities.FillDataGrid(dataGridView1, Tinventory);
            DisplayRecord(count);
            UTILITIES.DisplayUtilities.FillDataGrid(dataGridView1, Tinventory);
            count = 0;
        }
        private void DisplayRecord(int numRow)
        {
            motorSerialNumber_txtbox.Text = dataGridView1.Rows[numRow].Cells[0].Value.ToString();
            motorID_txtbox.Text = dataGridView1.Rows[numRow].Cells[1].Value.ToString();
            status_txtbox.Text = dataGridView1.Rows[numRow].Cells[2].Value.ToString();
            supplier_txtbox.Text = dataGridView1.Rows[numRow].Cells[3].Value.ToString();
            history_txtbox.Text = dataGridView1.Rows[numRow].Cells[4].Value.ToString();
            receivingDate_txtbox.Text = dataGridView1.Rows[numRow].Cells[5].Value.ToString();
            faultDescription_txtbox.Text = dataGridView1.Rows[numRow].Cells[6].Value.ToString();
            possibleCauses_txtbox.Text = dataGridView1.Rows[numRow].Cells[7].Value.ToString();
            warranty_cmbox.Text = dataGridView1.Rows[numRow].Cells[8].Value.ToString();
            price_txtbox.Text = dataGridView1.Rows[numRow].Cells[9].Value.ToString();
            exist_cmbox.Text = dataGridView1.Rows[numRow].Cells[10].Value.ToString();

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

        private void moveFirst_btn_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToFirst(Tinventory, count));
        }

        private void frmInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addRecord_btn_Click(object sender, EventArgs e)
        {
            string strSql;
            if (!(DisplayUtilities.ContIsfull(this)))
                MessageBox.Show("חסרים נתונים");
            else
            {

                strSql = "Select * from Motor where id='" + motorID_txtbox.Text + "'";
                DAL.dbEcoMotion.GetDataSet(strSql);
                if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count > 0)
                    MessageBox.Show("רשומה כבר קיימת");
                else
                {
                    strSql = "INSERT INTO Customer(motorSerialNumber,motorID,status,supplier,history,receivingDate,faultDescription,possibleCauses,warranty,price,exist) VALUES ('" + motorSerialNumber_txtbox.Text + "','" + motorID_txtbox.Text + "','" + status_txtbox.Text + "','" + supplier_txtbox.Text + "','" + history_txtbox.Text + "','" + receivingDate_txtbox.Text + "','" + faultDescription_txtbox.Text + "','" + possibleCauses_txtbox.Text + "','" + warranty_cmbox.Text + price_txtbox.Text + exist_cmbox.Text + "')";
                    MessageBox.Show(GeneralUtilities.AddRecd(Tinventory, strSql));
                    frmInventory_Load(sender, e);
                    motorSerialNumber_txtbox.Clear();
                    motorID_txtbox.Clear();
                    status_txtbox.Clear();
                    supplier_txtbox.Clear();
                    history_txtbox.Clear();
                    receivingDate_txtbox.Clear();
                    faultDescription_txtbox.Clear();
                    possibleCauses_txtbox.Clear();
                    price_txtbox.Clear();
                }
            }
        }
    }
}
                
       
