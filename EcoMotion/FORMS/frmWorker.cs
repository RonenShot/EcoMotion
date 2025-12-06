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
    public partial class frmWorker : Form
    {
        public frmWorker()
        {
            InitializeComponent();
        }
        int count = 0;
        DataTable Tworker;
        DialogResult dr;
        private void frmWorker_Load(object sender, EventArgs e)
        {
            Location = new Point(200, 200);
            Tworker = DAL.dbEcoMotion.OpenTable("Worker");
            UTILITIES.DisplayUtilities.FillDataGrid(dataGridView1, Tworker);
            DisplayRecord(count);
            UTILITIES.DisplayUtilities.FillDataGrid(dataGridView1, Tworker);
            count = 0;
            errorProvider1.Clear();
        }
        private void DisplayRecord(int numRow)
        {
            idNumber_txtbox.Text = dataGridView1.Rows[numRow].Cells[0].Value.ToString();
            firstName_txtbox.Text = dataGridView1.Rows[numRow].Cells[1].Value.ToString();
            lastName_txtbox.Text = dataGridView1.Rows[numRow].Cells[2].Value.ToString();
            citiy_txtbox.Text = dataGridView1.Rows[numRow].Cells[3].Value.ToString();
            street_txtbox.Text = dataGridView1.Rows[numRow].Cells[4].Value.ToString();
            houseNumber_txtbox.Text = dataGridView1.Rows[numRow].Cells[5].Value.ToString();
            phoneNumber_txtbox.Text = dataGridView1.Rows[numRow].Cells[6].Value.ToString();
            mail_txtbox.Text = dataGridView1.Rows[numRow].Cells[7].Value.ToString();
            startDate_dtp.Text = dataGridView1.Rows[numRow].Cells[8].Value.ToString();
            

        }
        private bool CheckDetails(Worker w)
        {
            bool check = true;
            try
            {
                w.Id = idNumber_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(idNumber_txtbox, "enter ID in correct format");
                check = false;
            }
            try
            {
                w.FirstName = firstName_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(firstName_txtbox, "enter first name in correct format");
                check = false;
            }
            try
            {
                w.LastName = lastName_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(lastName_txtbox, "enter last name in correct format");
                check = false;
            }
            try
            {
                w.Citiy = citiy_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(citiy_txtbox, "enter citiy in correct format");
                check = false;
            }
            try
            {
                w.PhoneNumber = phoneNumber_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(phoneNumber_txtbox, "enter phone number in correct format");
                check = false;
            }
            try
            {
                w.Street = street_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(street_txtbox, "enter street in correct format");
                check = false;
            }
            try
            {
                w.HouseNumber = houseNumber_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(houseNumber_txtbox, "enter house number in correct format");
                check = false;
            }
            try
            {
                w.Mail = mail_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(mail_txtbox, "enter mail in correct format");
                check = false;
            }
            try
            {
                w.StartDate = startDate_dtp.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(startDate_dtp, "enter start date of working in correct format");
                check = false;
            }
            try
            {
                w.Active = active_cmb.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(active_cmb, "enter active in correct format");
                check = false;
            }
            return check;


        }
        private void moveNext_btn_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MoveNext(Tworker, count);
            DisplayRecord(count);
        }

        private void moveLast_btn_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToLast(Tworker, count));
        }

        private void moveFirst_btn_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToFirst(Tworker, count));
        }

        private void movePrev_btn_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MovePrev(Tworker, count);
            DisplayRecord(count);
        }

        private void frmWorker_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            frmWorker_Load(sender, e);
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
                string strSq1 = "UPDATE Worker SET active='לא' WHERE ID ='" + idNumber_txtbox.Text + "'";
                DAL.dbEcoMotion.GetDataSet(strSq1);
                DAL.dbEcoMotion.GetDataSet("Select * from Worker");
                Tworker = DAL.dbEcoMotion.ds.Tables[0];
                DisplayRecord(0);
                DisplayRecord(Tworker.Rows.Count - 1);
            }
        }

        private void addRecord_btn_Click(object sender, EventArgs e)
        {
            string strSql;
            if (!(UTILITIES.DisplayUtilities.ContIsfull(this)))
                MessageBox.Show("חסרים נתונים");
            else
            {

                strSql = "Select * from Worker where id='" + idNumber_txtbox.Text + "'";
                DAL.dbEcoMotion.GetDataSet(strSql);
                if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count > 0)
                    MessageBox.Show("רשומה כבר קיימת");
                else
                {
                    Worker w = new Worker();
                    if(CheckDetails(w))
                    {
                        strSql = "INSERT INTO Worker(ID,firstName,lastName,citiy,street,houseNumber,phoneNumber,mail,startDate,active) VALUES ('" + idNumber_txtbox.Text + "','" + firstName_txtbox.Text + "','" + lastName_txtbox.Text + "','" + citiy_txtbox.Text + "','" + street_txtbox.Text + "','" + houseNumber_txtbox.Text + "','" + phoneNumber_txtbox.Text + "','" + mail_txtbox.Text + "','" + startDate_dtp.Text + "','" + active_cmb.Text + "')";
                        MessageBox.Show(UTILITIES.GeneralUtilities.AddRecd(Tworker, strSql));
                        frmWorker_Load(sender, e);
                        idNumber_txtbox.Clear();
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

        private void updateRecord_btn_Click(object sender, EventArgs e)
        {
            if ((!UTILITIES.DisplayUtilities.ContIsfull(this)))
                MessageBox.Show("חסרים נתונים");
            else
            {
                DAL.dbEcoMotion.GetDataSet("Select * from Worker where id='" + idNumber_txtbox.Text + "'");
                if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("עובד לא קיים");
                else
                {
                    Worker w = new Worker();
                    if(CheckDetails(w))
                    {
                        string strSql = "UPDATE Worker SET firstName='" + firstName_txtbox.Text + "',lastName='" + lastName_txtbox.Text + "',citiy='" + citiy_txtbox.Text + "',street='" + street_txtbox.Text + "',houseNumber='" + houseNumber_txtbox.Text + "',phoneNumber='" + phoneNumber_txtbox.Text + "',mail='" + mail_txtbox.Text + "',startDate='" + startDate_dtp.Text + "',active='" + active_cmb.Text + "' WHERE id='" + idNumber_txtbox.Text + "' ";
                        MessageBox.Show(UTILITIES.GeneralUtilities.UpDateRecd(Tworker, strSql));
                        frmWorker_Load(sender, e);
                    }
                    
                }
            }
        }

        private void searchWorker_btn_Click(object sender, EventArgs e)
        {
            DAL.dbEcoMotion.GetDataSet("Select * from Worker where ID='" + search_txt.Text + "'");// simple search/
            if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("עובד לא קיים");
                frmWorker_Load(sender, e);
            }
            else
            {
                DAL.dbEcoMotion.GetDataSet("Select * from Worker where ID='" + search_txt.Text + "'");
                idNumber_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["ID"].ToString();
                firstName_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["firstName"].ToString();
                lastName_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["lastName"].ToString();
                citiy_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["citiy"].ToString();
                street_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["street"].ToString();
                phoneNumber_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][5].ToString();
                houseNumber_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][6].ToString();
                mail_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][7].ToString();
                active_cmb.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["active"].ToString();
                startDate_dtp.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["startDate"].ToString();

            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idNumber_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            firstName_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            lastName_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            citiy_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            street_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            phoneNumber_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            houseNumber_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            mail_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            startDate_dtp.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            active_cmb.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void search_Click(object sender, EventArgs e)
        {
            DAL.dbEcoMotion.GetDataSet("Select * from Worker where ID='" + search_txt.Text + "'");// simple search/
            if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("עובד לא קיים");
                frmWorker_Load(sender, e);
            }
            else
            {
                DAL.dbEcoMotion.GetDataSet("Select * from Worker where ID='" + search_txt.Text + "'");
                idNumber_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["ID"].ToString();
                firstName_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["firstName"].ToString();
                lastName_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["lastName"].ToString();
                citiy_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["citiy"].ToString();
                street_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["street"].ToString();
                phoneNumber_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][5].ToString();
                houseNumber_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][6].ToString();
                mail_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][7].ToString();
                active_cmb.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["active"].ToString();
                startDate_dtp.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["startDate"].ToString();

            }
        }

        private void moveNext_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MoveNext(Tworker, count);
            DisplayRecord(count);
        }

        private void movePrev_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MovePrev(Tworker, count);
            DisplayRecord(count);
        }

        private void moveLast_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToLast(Tworker, count));
        }

        private void moveFirst_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToFirst(Tworker, count));
        }

        private void refreshDisplay_Click(object sender, EventArgs e)
        {
            frmWorker_Load(sender, e);
        }

        private void clearScreen_Click(object sender, EventArgs e)
        {
            UTILITIES.DisplayUtilities.ClearControls(this);
        }

        private void deleteRecord_Click(object sender, EventArgs e)
        {
            dr = MessageBox.Show("are you sure you want to delete this record?", "delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                string strSq1 = "UPDATE Worker SET active='לא' WHERE ID ='" + idNumber_txtbox.Text + "'";
                DAL.dbEcoMotion.GetDataSet(strSq1);
                DAL.dbEcoMotion.GetDataSet("Select * from Worker");
                Tworker = DAL.dbEcoMotion.ds.Tables[0];
                DisplayRecord(0);
                DisplayRecord(Tworker.Rows.Count - 1);
            }
        }

        private void addRecord_Click(object sender, EventArgs e)
        {
            string strSql;
            if (!(UTILITIES.DisplayUtilities.ContIsfull(this)))
                MessageBox.Show("חסרים נתונים");
            else
            {

                strSql = "Select * from Worker where id='" + idNumber_txtbox.Text + "'";
                DAL.dbEcoMotion.GetDataSet(strSql);
                if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count > 0)
                    MessageBox.Show("רשומה כבר קיימת");
                else
                {
                    Worker w = new Worker();
                    if (CheckDetails(w))
                    {
                        strSql = "INSERT INTO Worker(ID,firstName,lastName,citiy,street,houseNumber,phoneNumber,mail,startDate,active) VALUES ('" + idNumber_txtbox.Text + "','" + firstName_txtbox.Text + "','" + lastName_txtbox.Text + "','" + citiy_txtbox.Text + "','" + street_txtbox.Text + "','" + houseNumber_txtbox.Text + "','" + phoneNumber_txtbox.Text + "','" + mail_txtbox.Text + "','" + startDate_dtp.Text + "','" + active_cmb.Text + "')";
                        MessageBox.Show(UTILITIES.GeneralUtilities.AddRecd(Tworker, strSql));
                        frmWorker_Load(sender, e);
                        idNumber_txtbox.Clear();
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

        private void updateRecord_Click(object sender, EventArgs e)
        {
            if ((!UTILITIES.DisplayUtilities.ContIsfull(this)))
                MessageBox.Show("חסרים נתונים");
            else
            {
                DAL.dbEcoMotion.GetDataSet("Select * from Worker where id='" + idNumber_txtbox.Text + "'");
                if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("עובד לא קיים");
                else
                {
                    Worker w = new Worker();
                    if (CheckDetails(w))
                    {
                        string strSql = "UPDATE Worker SET firstName='" + firstName_txtbox.Text + "',lastName='" + lastName_txtbox.Text + "',citiy='" + citiy_txtbox.Text + "',street='" + street_txtbox.Text + "',houseNumber='" + houseNumber_txtbox.Text + "',phoneNumber='" + phoneNumber_txtbox.Text + "',mail='" + mail_txtbox.Text + "',startDate='" + startDate_dtp.Text + "',active='" + active_cmb.Text + "' WHERE id='" + idNumber_txtbox.Text + "' ";
                        MessageBox.Show(UTILITIES.GeneralUtilities.UpDateRecd(Tworker, strSql));
                        frmWorker_Load(sender, e);
                    }

                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
