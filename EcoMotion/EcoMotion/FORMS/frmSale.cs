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
        DataTable Tinventory;

        private void frmSale_Load(object sender, EventArgs e)
        {
            Location = new Point(200, 200);
            Tsale = DAL.dbEcoMotion.OpenTable("Sale");
            TsaleDetails = DAL.dbEcoMotion.OpenTable("SaleDetails");
            TsaleDetails = DAL.dbEcoMotion.OpenTable("Inventory");
            UTILITIES.DisplayUtilities.FillDataGrid(saleDetails_dgv, TsaleDetails);
            //DisplayRecord(count);
            UTILITIES.DisplayUtilities.FillDataGrid(sales_dgv, Tsale);
            count = 0;
            code_txtbox.Text = valueCode.ToString();
            strSql = "Select * from SaleDetails where codeSale='" + code_txtbox.Text + "'";
            dbEcoMotion.GetDataSet(strSql);
            showRecipt = dbEcoMotion.ds.Tables[0];
            UTILITIES.DisplayUtilities.FillDataGrid(saleDetails_dgv,showRecipt ); 
            

            
        }
        private void DisplayRecord(int numRow)
        {
            code_txtbox.Text = saleDetails_dgv.Rows[numRow].Cells[0].Value.ToString();
            customerID_txtbox.Text = saleDetails_dgv.Rows[numRow].Cells[1].Value.ToString();
            companyNumber_txtbox.Text = saleDetails_dgv.Rows[numRow].Cells[2].Value.ToString();
            totalCost_txtbox.Text = saleDetails_dgv.Rows[numRow].Cells[3].Value.ToString();
            dateTimePicker1.Text = saleDetails_dgv.Rows[numRow].Cells[4].Value.ToString();
            paymentMethod_txtbox.Text = saleDetails_dgv.Rows[numRow].Cells[5].Value.ToString();
            
        }

        private void moveFirst_btn_Click(object sender, EventArgs e)
        {

            //DisplayRecord(UTILITIES.GeneralUtilities.GoToFirst(Tsale, count));
        }

        private void moveLast_btn_Click(object sender, EventArgs e)
        {

            //DisplayRecord(UTILITIES.GeneralUtilities.GoToLast(Tsale, count));
        }

        private void MovePrev_btn_Click(object sender, EventArgs e)
        {
            //count = UTILITIES.GeneralUtilities.MovePrev(Tsale, count);
            //DisplayRecord(count);
        }

        private void moveNext_btn_Click(object sender, EventArgs e)
        {
           // count = UTILITIES.GeneralUtilities.MoveNext(Tsale, count);
            //DisplayRecord(count);
        }

        private void frmSale_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void inventory_dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           //string strSql = "INSERT INTO SaleDetails(codeSale,motorSerialNumber) VALUES ('"+code_txtbox.Text+ "','" + sales_dgv.Rows[e.RowIndex].Cells[0].Value.ToString()+ "')";
           //MessageBox.Show(UTILITIES.GeneralUtilities.AddRecd(TsaleDetails, strSql));
           //frmSale_Load(sender, e);
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
    }
}
