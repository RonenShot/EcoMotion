using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EcoMotion.DAL;

namespace EcoMotion.FORMS
{
    public partial class frmSale : Form
    {
        public frmSale(string customer)
        {
            InitializeComponent();
            customerID_txtbox.Text = customer;
         

        }
        int count = 0;
        DataTable Tsale;
        DataTable TsaleDetails;
        DialogResult dr;
        int valueCode = 1;
        string strSql;
        DataTable showRecipt; 

        

        private void frmSale_Load(object sender, EventArgs e)
        {
            Location = new Point(200, 200);
            string strSql = "Select * from Sale where customerID='" + customerID_txtbox.Text + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            showRecipt = DAL.dbEcoMotion.ds.Tables[0];
            UTILITIES.DisplayUtilities.FillDataGrid(sales_dgv, showRecipt);



        }
        private void DisplayRecord(int numRow)
        {
            string strSql = "Select * from SaleDetails where codeSale='" + sales_dgv.Rows[numRow].Cells[0].Value.ToString() + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            showRecipt = DAL.dbEcoMotion.ds.Tables[0];
            UTILITIES.DisplayUtilities.FillDataGrid(saleDetails_dgv, showRecipt);
            
            code_txtbox.Text = sales_dgv.Rows[numRow].Cells[0].Value.ToString();
            totalCost_txtbox.Text = sales_dgv.Rows[numRow].Cells[2].Value.ToString();
            paymentMethod_txtbox.Text = sales_dgv.Rows[numRow].Cells[5].Value.ToString();
            date_txtbox.Text = sales_dgv.Rows[numRow].Cells[3].Value.ToString();
            time_txtbox.Text = sales_dgv.Rows[numRow].Cells[4].Value.ToString();

            
        }

        private void moveFirst_btn_Click(object sender, EventArgs e)
        {
            string strSql = "Select * from Sale where customerID='" + customerID_txtbox.Text + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            showRecipt = DAL.dbEcoMotion.ds.Tables[0];

            DisplayRecord(UTILITIES.GeneralUtilities.GoToFirst(showRecipt, count));
        }

        private void moveLast_btn_Click(object sender, EventArgs e)
        {
            string strSql = "Select * from Sale where customerID='" + customerID_txtbox.Text + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            showRecipt = DAL.dbEcoMotion.ds.Tables[0];
            DisplayRecord(UTILITIES.GeneralUtilities.GoToLast(showRecipt, count));
        }

        private void MovePrev_btn_Click(object sender, EventArgs e)
        {
            string strSql = "Select * from Sale where customerID='" + customerID_txtbox.Text + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            showRecipt = DAL.dbEcoMotion.ds.Tables[0];
            count = UTILITIES.GeneralUtilities.MovePrev(showRecipt, count);

            string strSql1 = "Select * from SaleDetails where codeSale='" + count.ToString() + "'";
            DAL.dbEcoMotion.GetDataSet(strSql1);
            showRecipt = DAL.dbEcoMotion.ds.Tables[0];
            UTILITIES.DisplayUtilities.FillDataGrid(saleDetails_dgv, showRecipt);


            code_txtbox.Text = sales_dgv.Rows[count].Cells[0].Value.ToString();
            totalCost_txtbox.Text = sales_dgv.Rows[count].Cells[2].Value.ToString();
            paymentMethod_txtbox.Text = sales_dgv.Rows[count].Cells[5].Value.ToString();
            date_txtbox.Text = sales_dgv.Rows[count].Cells[3].Value.ToString();
            time_txtbox.Text = sales_dgv.Rows[count].Cells[4].Value.ToString();
        }

        private void moveNext_btn_Click(object sender, EventArgs e)
        {
            string strSql = "Select * from Sale where customerID='" + customerID_txtbox.Text + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            showRecipt = DAL.dbEcoMotion.ds.Tables[0];
            count = UTILITIES.GeneralUtilities.MoveNext(showRecipt, count);
            string strSql1 = "Select * from SaleDetails where codeSale='" + count.ToString() + "'";
            DAL.dbEcoMotion.GetDataSet(strSql1);
            showRecipt = DAL.dbEcoMotion.ds.Tables[0];
            UTILITIES.DisplayUtilities.FillDataGrid(saleDetails_dgv, showRecipt);


            code_txtbox.Text = sales_dgv.Rows[count].Cells[0].Value.ToString();
            totalCost_txtbox.Text = sales_dgv.Rows[count].Cells[2].Value.ToString();
            paymentMethod_txtbox.Text = sales_dgv.Rows[count].Cells[5].Value.ToString();
            date_txtbox.Text = sales_dgv.Rows[count].Cells[3].Value.ToString();
            time_txtbox.Text = sales_dgv.Rows[count].Cells[4].Value.ToString();
        }

        private void frmSale_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void inventory_dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void inventory_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void code_txtbox_TextChanged(object sender, EventArgs e)
        { 
            if(code_txtbox.Text!="")
            {
                valueCode = int.Parse(code_txtbox.Text);
                frmSale_Load(sender, e);
              //  string stSql="select price from Inventory where motorSerialNumber = "
            } 
            

        }

        private void addSale_Click(object sender, EventArgs e)
        {
            frmNewSale f = new frmNewSale(customerID_txtbox.Text);
            f.ShowDialog();
        }

        private void sales_dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string strSql = "Select * from SaleDetails where codeSale='" + sales_dgv.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            showRecipt = DAL.dbEcoMotion.ds.Tables[0];
            UTILITIES.DisplayUtilities.FillDataGrid(saleDetails_dgv, showRecipt);
            code_txtbox.Text = sales_dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            count = int.Parse(sales_dgv.Rows[e.RowIndex].Cells[0].Value.ToString())+2;
            totalCost_txtbox.Text = sales_dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            paymentMethod_txtbox.Text = sales_dgv.Rows[e.RowIndex].Cells[5].Value.ToString();
            date_txtbox.Text = sales_dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            time_txtbox.Text = sales_dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void searchPurchase_Click(object sender, EventArgs e)
        {
            int numSale = Int32.Parse(searchCode_txtbox.Text);
            
            string strSql = "Select * from Sale where code='" + numSale.ToString() + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            showRecipt = DAL.dbEcoMotion.ds.Tables[0];
            MessageBox.Show(numSale.ToString());
            if (showRecipt.Rows.Count == 0)
                MessageBox.Show("לא קיימת חשבונית כזאת");
            else
            {
                

                string strSql1 = "Select * from SaleDetails where codeSale='" + numSale.ToString() + "'";
                DAL.dbEcoMotion.GetDataSet(strSql1);
                showRecipt = DAL.dbEcoMotion.ds.Tables[0];
                UTILITIES.DisplayUtilities.FillDataGrid(saleDetails_dgv, showRecipt);
                
                
            }
                
            
        }

        private void refreshDisplay_Click(object sender, EventArgs e)
        {
            frmSale_Load(sender, e);
        }

        private void clearScreen_Click(object sender, EventArgs e)
        {
            searchCode_txtbox.Text = "";
        }

        private void moveNext_Click(object sender, EventArgs e)
        {
            string strSql = "Select * from Sale where customerID='" + customerID_txtbox.Text + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            showRecipt = DAL.dbEcoMotion.ds.Tables[0];
            count = UTILITIES.GeneralUtilities.MoveNext(showRecipt, count);
            code_txtbox.Text = sales_dgv.Rows[count].Cells[0].Value.ToString();
            totalCost_txtbox.Text = sales_dgv.Rows[count].Cells[2].Value.ToString();
            paymentMethod_txtbox.Text = sales_dgv.Rows[count].Cells[5].Value.ToString();
            date_txtbox.Text = sales_dgv.Rows[count].Cells[3].Value.ToString();
            time_txtbox.Text = sales_dgv.Rows[count].Cells[4].Value.ToString();
            string strSql1 = "Select * from SaleDetails where codeSale='" + sales_dgv.Rows[count].Cells[0].Value.ToString() + "'";
            DAL.dbEcoMotion.GetDataSet(strSql1);
            showRecipt = DAL.dbEcoMotion.ds.Tables[0];
            UTILITIES.DisplayUtilities.FillDataGrid(saleDetails_dgv, showRecipt);
        }

        private void movePrev_Click(object sender, EventArgs e)
        {
            string strSql = "Select * from Sale where customerID='" + customerID_txtbox.Text + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            showRecipt = DAL.dbEcoMotion.ds.Tables[0];
            count = UTILITIES.GeneralUtilities.MovePrev(showRecipt, count);
            code_txtbox.Text = sales_dgv.Rows[count].Cells[0].Value.ToString();
            totalCost_txtbox.Text = sales_dgv.Rows[count].Cells[2].Value.ToString();
            paymentMethod_txtbox.Text = sales_dgv.Rows[count].Cells[5].Value.ToString();
            date_txtbox.Text = sales_dgv.Rows[count].Cells[3].Value.ToString();
            time_txtbox.Text = sales_dgv.Rows[count].Cells[4].Value.ToString();
            string strSql1 = "Select * from SaleDetails where codeSale='" + sales_dgv.Rows[count].Cells[0].Value.ToString() + "'";
            DAL.dbEcoMotion.GetDataSet(strSql1);
            showRecipt = DAL.dbEcoMotion.ds.Tables[0];
            UTILITIES.DisplayUtilities.FillDataGrid(saleDetails_dgv, showRecipt);
        }

        private void moveLast_Click(object sender, EventArgs e)
        {
            string strSql = "Select * from Sale where customerID='" + customerID_txtbox.Text + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            showRecipt = DAL.dbEcoMotion.ds.Tables[0];
            DisplayRecord(UTILITIES.GeneralUtilities.GoToLast(showRecipt, count));
        }

        private void moveFirst_Click(object sender, EventArgs e)
        {
            string strSql = "Select * from Sale where customerID='" + customerID_txtbox.Text + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            showRecipt = DAL.dbEcoMotion.ds.Tables[0];

            DisplayRecord(UTILITIES.GeneralUtilities.GoToFirst(showRecipt, count));
        }

        private void search_Click(object sender, EventArgs e)
        {
            int numSale = Int32.Parse(searchCode_txtbox.Text);

            string strSql = "Select * from Sale where code='" + numSale.ToString() + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            showRecipt = DAL.dbEcoMotion.ds.Tables[0];
            MessageBox.Show(numSale.ToString());
            if (showRecipt.Rows.Count == 0)
                MessageBox.Show("לא קיימת חשבונית כזאת");
            else
            {


                string strSql1 = "Select * from SaleDetails where codeSale='" + numSale.ToString() + "'";
                DAL.dbEcoMotion.GetDataSet(strSql1);
                showRecipt = DAL.dbEcoMotion.ds.Tables[0];
                UTILITIES.DisplayUtilities.FillDataGrid(saleDetails_dgv, showRecipt);


            }

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
