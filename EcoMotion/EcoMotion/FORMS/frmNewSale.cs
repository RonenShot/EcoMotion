using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 


namespace EcoMotion.FORMS
{
    public partial class frmNewSale : Form
    {
        int codeValue;
        DataTable Tsale;
        DataTable TsaleDetails;
        DataTable Tinventory;
        DataTable showRecipt;
        double totalPrice = 0;
        public frmNewSale(string customer)
        {
            InitializeComponent();
            customerId_txtbox.Text = customer;
            Tsale = DAL.dbEcoMotion.OpenTable("Sale");
            codeValue = Tsale.Rows.Count + 1;
            totalCost_txt.Text = 0.ToString();
        }
        
        private void frmNewSale_Load(object sender, EventArgs e)
        {
            codeSale_txt.Text = codeValue.ToString(); 
            
            Tinventory = DAL.dbEcoMotion.OpenTable("Inventory");
            UTILITIES.DisplayUtilities.FillDataGrid(inventory_dgv, Tinventory);
            string strSql = "Select * from SaleDetails where codeSale='" + codeValue.ToString() + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            showRecipt = DAL.dbEcoMotion.ds.Tables[0];
            UTILITIES.DisplayUtilities.FillDataGrid(saleDetails_dgv, showRecipt);
            

        }

        private void inventory_dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string strSql = "Select * from Sale where code='" + codeValue.ToString() + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count > 0)
            {
                string strSql1 = "INSERT INTO SaleDetails(codeSale,motorSerialNumber,price) VALUES ('" + codeValue.ToString() + "','" + inventory_dgv.Rows[e.RowIndex].Cells[0].Value.ToString() + "','" + inventory_dgv.Rows[e.RowIndex].Cells[9].Value.ToString() + "')";
                totalPrice += double.Parse(inventory_dgv.Rows[e.RowIndex].Cells[9].Value.ToString());
                totalCost_txt.Text = totalPrice.ToString();
                string strSql2 = "UPDATE Sale SET totalCost =" + totalPrice.ToString()+ " WHERE code ='"+codeValue.ToString()+ "'";
                UTILITIES.GeneralUtilities.UpDateRecd(Tsale, strSql2);
                MessageBox.Show(UTILITIES.GeneralUtilities.AddRecd(TsaleDetails, strSql1)); 
                
                frmNewSale_Load(sender, e);
            } 
            else
                MessageBox.Show("יש צורך ביצירת החשבונית לפני הוספת הפריטים");





        }

        private void frmNewSale_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void createNewSale_btn_Click(object sender, EventArgs e)
        {
            if (!(UTILITIES.DisplayUtilities.ContIsfull(this)))
                MessageBox.Show("חסרים נתונים בקבלה"); 
            else
            {
                string strSql1 = "INSERT INTO Sale(code,customerID,totalCost,dateSale,timeSale,paymentMethod) VALUES('" + codeValue.ToString() + "','" + customerId_txtbox.Text + "','" + totalCost_txt.Text + "','" + dateTimePicker.Text + "','" + timeSale_txt.Text + "','" + paymentMethod_cbm.Text + "')";
                MessageBox.Show(UTILITIES.GeneralUtilities.AddRecd(TsaleDetails, strSql1));
            }
        }
    }
}
