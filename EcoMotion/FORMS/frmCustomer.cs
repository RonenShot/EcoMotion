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
    public partial class frmCustomer : Form
    {
        int currentRow = 0;
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        int count;
        DataTable Tcustomer;
        DialogResult dr;
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            Location = new Point(200, 200);

            Tcustomer = DAL.dbEcoMotion.OpenTable("Customer");
            UTILITIES.DisplayUtilities.FillDataGrid(dataGridView1, Tcustomer);

            
            count = 0;
            DisplayRecord(count);
            errorProvider1.Clear();

        } 
        private bool CheckDetails(Customer c)
        {
            bool check = true;
            try
            {
                c.Id = id_txtbox.Text;
            } 
            catch(Exception e)
            {
                errorProvider1.SetError(id_txtbox, "enter ID in correct format");
                check = false;
            }
            try
            {
                c.CFirstName = firstName_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(firstName_txtbox, "enter first name in correct format");
                check = false;
            }
            try
            {
                c.CLastName = lastName_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(lastName_txtbox, "enter last name in correct format");
                check = false;
            }
            try
            {
                c.Citiy = citiy_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(citiy_txtbox, "enter citiy in correct format");
                check = false;
            }
            try
            {
                c.PhoneNumber = phoneNumber_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(phoneNumber_txtbox, "enter phone number in correct format");
                check = false;
            }
            try
            {
                c.Street = street_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(street_txtbox, "enter street in correct format");
                check = false;
            }
            try
            {
                c.HouseNumber = houseNumber_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(houseNumber_txtbox, "enter house number in correct format");
                check = false;
            }
            try
            {
                c.Mail = mail_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(mail_txtbox, "enter mail in correct format");
                check = false;
            }
            try
            {
                c.Company = company_cmb.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(company_cmb, "enter company in correct format");
                check = false;
            }
            try
            {
                c.Active = active_cmbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(active_cmbox, "enter active in correct format");
                check = false;
            }
            return check;

            
    }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            firstName_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            lastName_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            citiy_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            street_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            phoneNumber_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            houseNumber_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            mail_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();           
            company_cmb.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            active_cmbox.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

        }
        private void DisplayRecord(int numRow)
        {
            id_txtbox.Text = dataGridView1.Rows[numRow].Cells[0].Value.ToString();
            firstName_txtbox.Text = dataGridView1.Rows[numRow].Cells[1].Value.ToString();
            lastName_txtbox.Text = dataGridView1.Rows[numRow].Cells[2].Value.ToString();
            citiy_txtbox.Text = dataGridView1.Rows[numRow].Cells[3].Value.ToString();
            street_txtbox.Text = dataGridView1.Rows[numRow].Cells[4].Value.ToString();
            phoneNumber_txtbox.Text = dataGridView1.Rows[numRow].Cells[5].Value.ToString();
            houseNumber_txtbox.Text = dataGridView1.Rows[numRow].Cells[6].Value.ToString();
            mail_txtbox.Text = dataGridView1.Rows[numRow].Cells[7].Value.ToString();
            company_cmb.Text = dataGridView1.Rows[numRow].Cells[8].Value.ToString();
            active_cmbox.Text = dataGridView1.Rows[numRow].Cells[9].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToFirst(Tcustomer, currentRow));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToLast(Tcustomer, currentRow));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MoveNext(Tcustomer, count);
            DisplayRecord(count);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MovePrev(Tcustomer, count);
            DisplayRecord(count);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addRecord_btn_Click(object sender, EventArgs e)
        {
            string strSql;
            if (!(UTILITIES.DisplayUtilities.ContIsfull(this)))
                MessageBox.Show("חסרים נתונים");
            else
            {

                strSql = "Select * from Customer where id='" + id_txtbox.Text + "'";
                DAL.dbEcoMotion.GetDataSet(strSql);
                if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count > 0)
                    MessageBox.Show("רשומה כבר קיימת");
                else
                {
                    Customer c = new Customer();
                    if (CheckDetails(c))
                    {
                        strSql = "INSERT INTO Customer(ID,firstName,lastName,citiy,street,phoneNumber,houseNumber,mail,company,active) VALUES ('" + id_txtbox.Text + "','" + firstName_txtbox.Text + "','" + lastName_txtbox.Text + "','" + citiy_txtbox.Text + "','" + street_txtbox.Text + "','" + phoneNumber_txtbox.Text + "','" + houseNumber_txtbox.Text + "','" + mail_txtbox.Text + "','" + company_cmb.Text + "','" + active_cmbox.Text + "')";
                        MessageBox.Show(UTILITIES.GeneralUtilities.AddRecd(Tcustomer, strSql));
                        frmCustomer_Load(sender, e);
                        id_txtbox.Clear();
                        firstName_txtbox.Clear();
                        lastName_txtbox.Clear();
                        citiy_txtbox.Clear();
                        street_txtbox.Clear();
                        houseNumber_txtbox.Clear();
                        mail_txtbox.Clear();
                        phoneNumber_txtbox.Clear();

                    }
                }
                  
            }
        }

        private void clearScr_btn_Click(object sender, EventArgs e)
        {
            UTILITIES.DisplayUtilities.ClearControls(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCustomer_Load(sender, e);
        }

        private void upDateRecord_btn_Click(object sender, EventArgs e)
        {

            /*string strSql;
            if (!(UTILITIES.DisplayUtilities.ContIsfull(this)))
                MessageBox.Show("חסרים נתונים");
            else
            {
                strSql = "Select * from Customer where id='" + id_txtbox.Text + "'";
                DAL.dbEcoMotion.GetDataSet(strSql);
                if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("רשומה לא קיימת"); 
                else
                {
                    strSql = "UPDATE Customer SET (firstName,lastName,citiy,street,phoneNumber,houseNumber,mail,active) = (["+firstName_txtbox.Text+"],[" + lastName_txtbox.Text + "],[" + citiy_txtbox.Text + "],["+citiy_txtbox.Text + "],["+street_txtbox.Text + "],[" + phoneNumber_txtbox.Text + "],[" + houseNumber_txtbox.Text + "],[" + mail_txtbox.Text + "],[" + active_cmbox.Text + "]) WHERE ";
                }
            */
            if ((!UTILITIES.DisplayUtilities.ContIsfull(this)))
                MessageBox.Show("חסרים נתונים");
            else
            {
                DAL.dbEcoMotion.GetDataSet("Select * from Customer where id='" + id_txtbox.Text + "'");
                if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("לקוח לא קיים");
                else
                {
                    Customer c = new Customer();
                    if(CheckDetails(c))
                    {
                        string strSql = "UPDATE Customer SET firstName='" + firstName_txtbox.Text + "',lastName='" + lastName_txtbox.Text + "',citiy='" + citiy_txtbox.Text + "',street='" + street_txtbox.Text + "',phoneNumber='" + phoneNumber_txtbox.Text + "',houseNumber='" + houseNumber_txtbox.Text + "',mail='" + mail_txtbox.Text + "',company='" + company_cmb.Text + "',active='" + active_cmbox.Text + "' WHERE id='" + id_txtbox.Text + "' ";
                        MessageBox.Show(UTILITIES.GeneralUtilities.UpDateRecd(Tcustomer, strSql));
                        frmCustomer_Load(sender, e);
                    }
                    
                }
            }
        }

        private void deleteRecord_btn_Click(object sender, EventArgs e)
        {
            dr = MessageBox.Show("are you sure you want to delete this record?", "delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                string strSq1 = "UPDATE Customer SET active='לא' WHERE id ='" + id_txtbox.Text + "'";
                DAL.dbEcoMotion.GetDataSet(strSq1);
                DAL.dbEcoMotion.GetDataSet("Select * from Customer");
                Tcustomer = DAL.dbEcoMotion.ds.Tables[0];
                DisplayRecord(0);
                DisplayRecord(Tcustomer.Rows.Count - 1);
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            DAL.dbEcoMotion.GetDataSet("Select * from Customer where id='" + idSearch_txtbox.Text + "'");// simple search/
            if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("לקוח לא קיים");
                frmCustomer_Load(sender, e);
            }
            else
            {
                DAL.dbEcoMotion.GetDataSet("Select * from Customer where id='" + idSearch_txtbox.Text + "'");
                id_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["id"].ToString();
                firstName_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["firstName"].ToString();
                lastName_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["lastName"].ToString();
                citiy_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["citiy"].ToString();
                street_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["street"].ToString();
                phoneNumber_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][5].ToString();
                houseNumber_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][6].ToString();
                mail_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][7].ToString();
                active_cmbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["active"].ToString(); 
                company_cmb.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["company"].ToString();

            }
        }

        private void purchase_btn_Click(object sender, EventArgs e)
        {
            frmSale fs = new frmSale(id_txtbox.Text);
            //this.Hide();
            //fs.Show(); 
            fs.ShowDialog();
        }

        private void fixing_btn_Click(object sender, EventArgs e)
        {
            frmRepairing f1 = new frmRepairing(id_txtbox.Text);
            f1.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void clearScreen_Click(object sender, EventArgs e)
        {
            UTILITIES.DisplayUtilities.ClearControls(this);

        }

        private void refreshDisplay_Click(object sender, EventArgs e)
        {
            frmCustomer_Load(sender, e);

        }

        private void moveFirst_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToFirst(Tcustomer, currentRow));

        }

        private void moveNext_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MoveNext(Tcustomer, count);
            DisplayRecord(count);
        }

        private void moveLast_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToLast(Tcustomer, currentRow));

        }

        private void movePrev_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MovePrev(Tcustomer, count);
            DisplayRecord(count);
        }

        private void updateRecord_Click(object sender, EventArgs e)
        {
            /*string strSql;
            if (!(UTILITIES.DisplayUtilities.ContIsfull(this)))
                MessageBox.Show("חסרים נתונים");
            else
            {
                strSql = "Select * from Customer where id='" + id_txtbox.Text + "'";
                DAL.dbEcoMotion.GetDataSet(strSql);
                if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("רשומה לא קיימת"); 
                else
                {
                    strSql = "UPDATE Customer SET (firstName,lastName,citiy,street,phoneNumber,houseNumber,mail,active) = (["+firstName_txtbox.Text+"],[" + lastName_txtbox.Text + "],[" + citiy_txtbox.Text + "],["+citiy_txtbox.Text + "],["+street_txtbox.Text + "],[" + phoneNumber_txtbox.Text + "],[" + houseNumber_txtbox.Text + "],[" + mail_txtbox.Text + "],[" + active_cmbox.Text + "]) WHERE ";
                }
            */
            if ((!UTILITIES.DisplayUtilities.ContIsfull(this)))
                MessageBox.Show("חסרים נתונים");
            else
            {
                DAL.dbEcoMotion.GetDataSet("Select * from Customer where id='" + id_txtbox.Text + "'");
                if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("לקוח לא קיים");
                else
                {
                    Customer c = new Customer();
                    if (CheckDetails(c))
                    {
                        string strSql = "UPDATE Customer SET firstName='" + firstName_txtbox.Text + "',lastName='" + lastName_txtbox.Text + "',citiy='" + citiy_txtbox.Text + "',street='" + street_txtbox.Text + "',phoneNumber='" + phoneNumber_txtbox.Text + "',houseNumber='" + houseNumber_txtbox.Text + "',mail='" + mail_txtbox.Text + "',company='" + company_cmb.Text + "',active='" + active_cmbox.Text + "' WHERE id='" + id_txtbox.Text + "' ";
                        MessageBox.Show(UTILITIES.GeneralUtilities.UpDateRecd(Tcustomer, strSql));
                        frmCustomer_Load(sender, e);
                    }

                }
            }
        }

        private void addRecord_Click(object sender, EventArgs e)
        {
            string strSql;
            if (!(UTILITIES.DisplayUtilities.ContIsfull(this)))
                MessageBox.Show("חסרים נתונים");
            else
            {

                strSql = "Select * from Customer where id='" + id_txtbox.Text + "'";
                DAL.dbEcoMotion.GetDataSet(strSql);
                if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count > 0)
                    MessageBox.Show("רשומה כבר קיימת");
                else
                {
                    Customer c = new Customer();
                    if (CheckDetails(c))
                    {
                        strSql = "INSERT INTO Customer(ID,firstName,lastName,citiy,street,phoneNumber,houseNumber,mail,company,active) VALUES ('" + id_txtbox.Text + "','" + firstName_txtbox.Text + "','" + lastName_txtbox.Text + "','" + citiy_txtbox.Text + "','" + street_txtbox.Text + "','" + phoneNumber_txtbox.Text + "','" + houseNumber_txtbox.Text + "','" + mail_txtbox.Text + "','" + company_cmb.Text + "','" + active_cmbox.Text + "')";
                        MessageBox.Show(UTILITIES.GeneralUtilities.AddRecd(Tcustomer, strSql));
                        frmCustomer_Load(sender, e);
                        id_txtbox.Clear();
                        firstName_txtbox.Clear();
                        lastName_txtbox.Clear();
                        citiy_txtbox.Clear();
                        street_txtbox.Clear();
                        houseNumber_txtbox.Clear();
                        mail_txtbox.Clear();
                        phoneNumber_txtbox.Clear();

                    }
                }

            }
        }

        private void deleteRecord_Click(object sender, EventArgs e)
        {
            dr = MessageBox.Show("are you sure you want to delete this record?", "delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                string strSq1 = "UPDATE Customer SET active='לא' WHERE id ='" + id_txtbox.Text + "'";
                DAL.dbEcoMotion.GetDataSet(strSq1);
                DAL.dbEcoMotion.GetDataSet("Select * from Customer");
                Tcustomer = DAL.dbEcoMotion.ds.Tables[0];
                DisplayRecord(0);
                DisplayRecord(Tcustomer.Rows.Count - 1);
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            DAL.dbEcoMotion.GetDataSet("Select * from Customer where id='" + idSearch_txtbox.Text + "'");// simple search/
            if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("לקוח לא קיים");
                frmCustomer_Load(sender, e);
            }
            else
            {
                DAL.dbEcoMotion.GetDataSet("Select * from Customer where id='" + idSearch_txtbox.Text + "'");
                id_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["id"].ToString();
                firstName_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["firstName"].ToString();
                lastName_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["lastName"].ToString();
                citiy_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["citiy"].ToString();
                street_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["street"].ToString();
                phoneNumber_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][5].ToString();
                houseNumber_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][6].ToString();
                mail_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][7].ToString();
                active_cmbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["active"].ToString();
                company_cmb.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["company"].ToString();

            }
        }
    }
    
}
