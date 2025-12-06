using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using EcoMotion.BL;



namespace EcoMotion.FORMS
{
    public partial class frmNewSale : Form
    {
        int codeValue;
        DataTable Tsale;
        DataTable TsaleDetailsAid;
        DataTable Tinventory;
        DataTable showRecipt;
        double totalPrice = 0;
        int rowIndex = 1;
        List<int> preUpdateStock = new List<int>();
        int totalCost = 0;

        public frmNewSale(string customer)
        {
            InitializeComponent();
            customerId_txtbox.Text = customer;
            Tsale = DAL.dbEcoMotion.OpenTable("Sale");
            codeValue = Tsale.Rows.Count + 1;
            totalCost_txt.Text = 0.ToString();
            codeSale_txt.Text = codeValue.ToString();

        }

        private void frmNewSale_Load(object sender, EventArgs e)
        {


            Tinventory = DAL.dbEcoMotion.OpenTable("Inventory");
            UTILITIES.DisplayUtilities.FillDataGrid(inventory_dgv, Tinventory);
            //string strSql = "Select * from SaleDetails where codeSale='" + codeValue.ToString() + "'";
            //DAL.dbEcoMotion.GetDataSet(strSql);
            //showRecipt = DAL.dbEcoMotion.ds.Tables[0];
            //UTILITIES.DisplayUtilities.FillDataGrid(saleDetailsAid_dgv, showRecipt);


        }
        private bool CheckDetails(Sale s)
        {
            bool check = true;
            try
            {
                s.TotalCost = totalCost_txt.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(totalCost_txt, "enter total cost in correct format");
                check = false;
            }
            try
            {
                s.DateSale = dateSale_dtp.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(dateSale_dtp, "enter date sale in correct format");
                check = false;
            }
            try
            {
                s.TimeSale = timeSale_dtp.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(timeSale_dtp, "enter time sale in correct format");
                check = false;
            }
            try
            {
                s.PaymentMethod = paymentMethod_cbm.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(paymentMethod_cbm, "enter payment method in correct format");
                check = false;
            }

            return check;


        }

        private void inventory_dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int price;
            bool existed = false;
            int quntitiyInStock = int.Parse(inventory_dgv.Rows[e.RowIndex].Cells[7].Value.ToString());
            string quantityInput = Interaction.InputBox("Enter number of motors for purchase:", "", "please enter integer number", 200, 200);
            int quantity;
            if (int.Parse(quantityInput) < quntitiyInStock && int.Parse(quantityInput) > 0)
            {
                MessageBox.Show(saleDetailsAid_dgv.Rows.Count.ToString());
                for (int i = 0; i < saleDetailsAid_dgv.Rows.Count - 1; i++)
                {
                    if (inventory_dgv.Rows[e.RowIndex].Cells[0].Value.ToString().Equals(saleDetailsAid_dgv.Rows[i].Cells[1].Value.ToString()))
                    {
                        quantity = int.Parse(quantityInput) + int.Parse(saleDetailsAid_dgv.Rows[i].Cells[3].Value.ToString());
                        if (quantity < quntitiyInStock)
                            saleDetailsAid_dgv.Rows[i].Cells[3].Value = quantity.ToString();
                        price = int.Parse(inventory_dgv.Rows[e.RowIndex].Cells[4].Value.ToString()) * quantity;
                        saleDetailsAid_dgv.Rows[i].Cells[2].Value = price.ToString();
                        totalCost = totalCost + (int.Parse(inventory_dgv.Rows[e.RowIndex].Cells[4].Value.ToString()) * int.Parse(quantityInput));
                        totalCost_txt.Text = totalCost.ToString();
                        existed = true;
                    }

                }
                if (!existed)
                {
                    price = int.Parse(inventory_dgv.Rows[e.RowIndex].Cells[4].Value.ToString()) * int.Parse(quantityInput);
                    saleDetailsAid_dgv.Rows.Add(codeValue.ToString(), inventory_dgv.Rows[e.RowIndex].Cells[0].Value.ToString(), price, quantityInput);
                    preUpdateStock.Add(int.Parse(inventory_dgv.Rows[e.RowIndex].Cells[7].Value.ToString()));
                    MessageBox.Show(preUpdateStock[0].ToString());
                    totalCost = totalCost + price;
                    totalCost_txt.Text = totalCost.ToString();
                    rowIndex++;

                }






                frmNewSale_Load(sender, e);


                //string strSql = "Select * from Sale where code='" + codeValue.ToString() + "'";
                //DAL.dbEcoMotion.GetDataSet(strSql);
                //if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count > 0)
                //{
                //string strSql1 = "INSERT INTO SaleDetails(codeSale,motorSerialNumber,price) VALUES ('" + codeValue.ToString() + "','" + inventory_dgv.Rows[e.RowIndex].Cells[0].Value.ToString() + "','" + inventory_dgv.Rows[e.RowIndex].Cells[4].Value.ToString() + "')";
                // totalPrice += double.Parse(inventory_dgv.Rows[e.RowIndex].Cells[4].Value.ToString());
                // totalCost_txt.Text = totalPrice.ToString();
                // string strSql2 = "UPDATE Sale SET totalCost =" + totalPrice.ToString() + " WHERE code ='" + codeValue.ToString() + "'";
                // UTILITIES.GeneralUtilities.UpDateRecd(Tsale, strSql2);
                // MessageBox.Show(UTILITIES.GeneralUtilities.AddRecd(TsaleDetailsAid, strSql1));

                //frmNewSale_Load(sender, e);
                //}
                //else
                // MessageBox.Show("יש צורך ביצירת החשבונית לפני הוספת הפריטים");





            }
            else
                MessageBox.Show("the input is incorrect, try again");
        }

        private void frmNewSale_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void createNewSale_btn_Click(object sender, EventArgs e)
        {
            Sale s = new Sale();
            if (CheckDetails(s))
            {
                //if (!(UTILITIES.DisplayUtilities.ContIsfull(this)))
                //MessageBox.Show("חסרים נתונים בקבלה");
                //else
                //{
                string strSql;
                string strSql1;
                string strSql2;
                int updatedStock;

                int[] preUpdateStockArr = preUpdateStock.ToArray();
                for (int i = 0; i < preUpdateStockArr.Length; i++)
                {
                    MessageBox.Show(preUpdateStockArr[i].ToString());
                }
                showRecipt = DAL.dbEcoMotion.OpenTable("SaleDetails");
                strSql2 = "INSERT INTO Sale(code, customerID, totalCost,dateSale,timeSale,paymentMethod) VALUES('" + codeValue.ToString() + "', '" + customerId_txtbox.Text + "', '" + totalCost.ToString() + "', '" + dateSale_dtp.Text + "', '" + timeSale_dtp.Text + "', '" + paymentMethod_cbm.Text + "')";
                MessageBox.Show(UTILITIES.GeneralUtilities.AddRecd(Tsale, strSql2));
                for (int i = 0; i < rowIndex - 1; i++)
                {
                    updatedStock = preUpdateStockArr[i] - int.Parse(saleDetailsAid_dgv.Rows[i].Cells[3].Value.ToString());
                    MessageBox.Show(updatedStock.ToString());
                    strSql = "UPDATE Inventory SET quntityInstock = " + updatedStock.ToString() + " WHERE inventoryId = '" + saleDetailsAid_dgv.Rows[i].Cells[1].Value.ToString() + "'";
                    UTILITIES.GeneralUtilities.UpDateRecd(Tinventory, strSql);

                    strSql1 = "INSERT INTO SaleDetails(codeSale,inventoryId,price,quantity) VALUES ('" + codeValue.ToString() + "','" + saleDetailsAid_dgv.Rows[i].Cells[1].Value.ToString() + "','" + saleDetailsAid_dgv.Rows[i].Cells[2].Value.ToString() + "','" + saleDetailsAid_dgv.Rows[i].Cells[3].Value.ToString() + "')";
                    MessageBox.Show(UTILITIES.GeneralUtilities.AddRecd(showRecipt, strSql1));
                }


                //}}

            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void refreshDisplay_Click(object sender, EventArgs e)
        {
            frmNewSale_Load(sender, e);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
