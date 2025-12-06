using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoMotion.DAL;
using System.Windows.Forms;
using EcoMotion.BL;

namespace EcoMotion.FORMS
{
    public partial class frmMotor : Form
    {
        public frmMotor()
        {
            InitializeComponent();
        }
        int count=0;
        DataTable Tmotor;
        DialogResult dr;
        private void frmMotor_Load(object sender, EventArgs e)
        {
            Location = new Point(200, 200);
            Tmotor = dbEcoMotion.OpenTable("Motor");
            UTILITIES.DisplayUtilities.FillDataGrid(dataGridView1, Tmotor);
            DisplayRecord(count);
            count = 0;
            errorProvider1.Clear();

        }
        private void DisplayRecord(int numRow)
        {
            motorID_txtbox.Text = dataGridView1.Rows[numRow].Cells[0].Value.ToString();
            electricalConnectionType_txtbox.Text = dataGridView1.Rows[numRow].Cells[1].Value.ToString();
            voltageType_txtbox.Text = dataGridView1.Rows[numRow].Cells[2].Value.ToString();
            rpm_txtbox.Text = dataGridView1.Rows[numRow].Cells[3].Value.ToString();
            hp_txtbox.Text = dataGridView1.Rows[numRow].Cells[4].Value.ToString();
            productionLand_txtbox.Text = dataGridView1.Rows[numRow].Cells[5].Value.ToString();
            numberOfSlots_txtbox.Text = dataGridView1.Rows[numRow].Cells[6].Value.ToString();
            efficiency_txtbox.Text = dataGridView1.Rows[numRow].Cells[7].Value.ToString();
            structreType_txtbox.Text = dataGridView1.Rows[numRow].Cells[8].Value.ToString();
            manufacturer_txtbox.Text = dataGridView1.Rows[numRow].Cells[9].Value.ToString();
        }
        private bool CheckDetails(Motor m)
        {           
        bool check = true;
            try
            {
                m.MotorID = motorID_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(motorID_txtbox, "enter motor ID in correct format");
                check = false;
            }
            try
            {
                m.ElectricalConnectionType = electricalConnectionType_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(electricalConnectionType_txtbox, "enter electrical Connection type in correct format");
                check = false;
            }
            try
            {
                m.VoltageType = voltageType_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(voltageType_txtbox, "enter voltage type in correct format");
                check = false;
            }
            try
            {
                m.Rpm = rpm_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(rpm_txtbox, "enter RPM in correct format");
                check = false;
            }
            try
            {
                m.Hp = hp_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(hp_txtbox, "enter HP in correct format");
                check = false;
            }
            try
            {
                m.ProductionLand = productionLand_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(productionLand_txtbox, "enter production land in correct format");
                check = false;
            }
            try
            {
                m.NumberOfSlots = numberOfSlots_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(numberOfSlots_txtbox, "enter number Of slots in correct format");
                check = false;
            }
            try
            {
                m.Efficiency = efficiency_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(efficiency_txtbox, "enter efficiency in correct format");
                check = false;
            }
            try
            {
                m.StructreType = structreType_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(structreType_txtbox, "enter structre type in correct format");
                check = false;
            }
            try
            {
                m.Manufacturer = manufacturer_txtbox.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(manufacturer_txtbox, "enter manufacturer type in correct format");
                check = false;
            }
            return check;


        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MoveNext(Tmotor, count);
            DisplayRecord(count);
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MoveNext(Tmotor, count);
            DisplayRecord(count);
        }

        private void movefirst_btn_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToFirst(Tmotor, count));
            
        }

        private void moveLast_btn_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToLast(Tmotor, count));
            
        }

        private void addRecord_btn_Click(object sender, EventArgs e)
        {
            string strSql;
            if (!(UTILITIES.DisplayUtilities.ContIsfull(this)))
                MessageBox.Show("חסרים נתונים");
            else
            {

                strSql = "Select * from Motor where motorID='" + motorID_txtbox.Text + "'";
                DAL.dbEcoMotion.GetDataSet(strSql);
                MessageBox.Show(dbEcoMotion.ds.Tables[0].Rows.Count.ToString());
                if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count > 0)
                    MessageBox.Show("רשומה כבר קיימת");
                else
                {
                    Motor m = new Motor();
                    if(CheckDetails(m))
                    {
                        int code = Tmotor.Rows.Count + 1;
                        motorID_txtbox.Text = code.ToString();
                        strSql = "INSERT INTO Motor(motorID,electricalConnectionType,voltageType,rpm,hp,productionLand,numberOfSlots,efficiency,structreType,manufacturer) VALUES ('" + code.ToString() + "','" + electricalConnectionType_txtbox.Text + "','" + voltageType_txtbox.Text + "','" + rpm_txtbox.Text + "','" + hp_txtbox.Text + "','" + productionLand_txtbox.Text + "','" + numberOfSlots_txtbox.Text + "','" + efficiency_txtbox.Text + "','" + structreType_txtbox.Text + "','" + manufacturer_txtbox.Text + "')";
                        MessageBox.Show(UTILITIES.GeneralUtilities.AddRecd(Tmotor, strSql));
                        frmMotor_Load(sender, e);
                        motorID_txtbox.Clear();
                        electricalConnectionType_txtbox.Clear();
                        voltageType_txtbox.Clear();
                        rpm_txtbox.Clear();
                        hp_txtbox.Clear();
                        productionLand_txtbox.Clear();
                        numberOfSlots_txtbox.Clear();
                        efficiency_txtbox.Clear();
                        structreType_txtbox.Clear();
                        manufacturer_txtbox.Clear();
                    }
                    
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            motorID_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            electricalConnectionType_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            voltageType_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            rpm_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            hp_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            productionLand_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            numberOfSlots_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            efficiency_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            structreType_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            manufacturer_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

        }

        private void frmMotor_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void RefreshDisplay_btn_Click(object sender, EventArgs e)
        {
            frmMotor_Load(sender, e);
        }

        private void clearScr_btn_Click(object sender, EventArgs e)
        {
            UTILITIES.DisplayUtilities.ClearControls(this);
        }

        private void DeleteRecord_btn_Click(object sender, EventArgs e)
        {

        }

        private void UpdateRecord_btn_Click(object sender, EventArgs e)
        {
            if ((!UTILITIES.DisplayUtilities.ContIsfull(this)))
                MessageBox.Show("חסרים נתונים");
            else
            {
                DAL.dbEcoMotion.GetDataSet("Select * from Motor where motorID='" + motorID_txtbox.Text + "'");
                if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("תוכנית מנוע לא קיימת");
                else
                {
                    Motor m = new Motor();
                    if(CheckDetails(m))
                    {
                        string strSql = "UPDATE Motor SET electricalConnectionType='" + electricalConnectionType_txtbox.Text + "',voltageType='" + voltageType_txtbox.Text + "',rpm='" + rpm_txtbox.Text + "',hp='" + hp_txtbox.Text + "',productionLand='" + productionLand_txtbox.Text + "',numberOfSlots='" + numberOfSlots_txtbox.Text + "',efficiency='" + efficiency_txtbox.Text + "',structreType='" + structreType_txtbox.Text + "',manufacturer='" + manufacturer_txtbox.Text + "' WHERE motorID='" + motorID_txtbox.Text + "' ";
                        MessageBox.Show(UTILITIES.GeneralUtilities.UpDateRecd(Tmotor, strSql));
                        frmMotor_Load(sender, e);
                    }
                    
                }
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            DAL.dbEcoMotion.GetDataSet("Select * from Motor where motorID='" + searchMotor_txt.Text + "'");// simple search/
            if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("מנוע לא קיים");
                frmMotor_Load(sender, e);
            }
            else
            {
                DAL.dbEcoMotion.GetDataSet("Select * from Motor where motorID='" + searchMotor_txt.Text + "'");
                motorID_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["motorID"].ToString();
                electricalConnectionType_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["electricalConnectionType"].ToString();
                voltageType_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["voltageType"].ToString();
                rpm_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["rpm"].ToString();
                hp_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["hp"].ToString();
                productionLand_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][5].ToString();
                numberOfSlots_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][6].ToString();
                efficiency_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][7].ToString();
                structreType_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["structreType"].ToString();
                manufacturer_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["manufacturer"].ToString();

            }
        }

        private void moveNext_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MoveNext(Tmotor, count);
            DisplayRecord(count);
        }

        private void moveFirst_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToFirst(Tmotor, count));
        }

        private void moveLast_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToLast(Tmotor, count));
        }

        private void movePrev_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MovePrev(Tmotor, count);
            DisplayRecord(count);
        }

        private void addRecord_Click(object sender, EventArgs e)
        {
            string strSql;
            if (!(UTILITIES.DisplayUtilities.ContIsfull(this)))
                MessageBox.Show("חסרים נתונים");
            else
            {

                strSql = "Select * from Motor where motorID='" + motorID_txtbox.Text + "'";
                DAL.dbEcoMotion.GetDataSet(strSql);
                MessageBox.Show(dbEcoMotion.ds.Tables[0].Rows.Count.ToString());
                if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count > 0)
                    MessageBox.Show("רשומה כבר קיימת");
                else
                {
                    Motor m = new Motor();
                    if (CheckDetails(m))
                    {
                        int code = Tmotor.Rows.Count + 1;
                        motorID_txtbox.Text = code.ToString();
                        strSql = "INSERT INTO Motor(motorID,electricalConnectionType,voltageType,rpm,hp,productionLand,numberOfSlots,efficiency,structreType,manufacturer) VALUES ('" + code.ToString() + "','" + electricalConnectionType_txtbox.Text + "','" + voltageType_txtbox.Text + "','" + rpm_txtbox.Text + "','" + hp_txtbox.Text + "','" + productionLand_txtbox.Text + "','" + numberOfSlots_txtbox.Text + "','" + efficiency_txtbox.Text + "','" + structreType_txtbox.Text + "','" + manufacturer_txtbox.Text + "')";
                        MessageBox.Show(UTILITIES.GeneralUtilities.AddRecd(Tmotor, strSql));
                        frmMotor_Load(sender, e);
                        motorID_txtbox.Clear();
                        electricalConnectionType_txtbox.Clear();
                        voltageType_txtbox.Clear();
                        rpm_txtbox.Clear();
                        hp_txtbox.Clear();
                        productionLand_txtbox.Clear();
                        numberOfSlots_txtbox.Clear();
                        efficiency_txtbox.Clear();
                        structreType_txtbox.Clear();
                        manufacturer_txtbox.Clear();
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
                DAL.dbEcoMotion.GetDataSet("Select * from Motor where motorID='" + motorID_txtbox.Text + "'");
                if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("תוכנית מנוע לא קיימת");
                else
                {
                    Motor m = new Motor();
                    if (CheckDetails(m))
                    {
                        string strSql = "UPDATE Motor SET electricalConnectionType='" + electricalConnectionType_txtbox.Text + "',voltageType='" + voltageType_txtbox.Text + "',rpm='" + rpm_txtbox.Text + "',hp='" + hp_txtbox.Text + "',productionLand='" + productionLand_txtbox.Text + "',numberOfSlots='" + numberOfSlots_txtbox.Text + "',efficiency='" + efficiency_txtbox.Text + "',structreType='" + structreType_txtbox.Text + "',manufacturer='" + manufacturer_txtbox.Text + "' WHERE motorID='" + motorID_txtbox.Text + "' ";
                        MessageBox.Show(UTILITIES.GeneralUtilities.UpDateRecd(Tmotor, strSql));
                        frmMotor_Load(sender, e);
                    }

                }
            }
        }

        private void refreshDisplay_Click(object sender, EventArgs e)
        {
            frmMotor_Load(sender, e);
        }

        private void clearScreen_Click(object sender, EventArgs e)
        {
            UTILITIES.DisplayUtilities.ClearControls(this);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            DAL.dbEcoMotion.GetDataSet("Select * from Motor where motorID='" + searchMotor_txt.Text + "'");// simple search/
            if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("מנוע לא קיים");
                frmMotor_Load(sender, e);
            }
            else
            {
                DAL.dbEcoMotion.GetDataSet("Select * from Motor where motorID='" + searchMotor_txt.Text + "'");
                motorID_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["motorID"].ToString();
                electricalConnectionType_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["electricalConnectionType"].ToString();
                voltageType_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["voltageType"].ToString();
                rpm_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["rpm"].ToString();
                hp_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["hp"].ToString();
                productionLand_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][5].ToString();
                numberOfSlots_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][6].ToString();
                efficiency_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0][7].ToString();
                structreType_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["structreType"].ToString();
                manufacturer_txtbox.Text = DAL.dbEcoMotion.ds.Tables[0].Rows[0]["manufacturer"].ToString();

            }
        }
    }
}
