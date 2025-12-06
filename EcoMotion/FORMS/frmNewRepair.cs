using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoMotion.DAL;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using EcoMotion.BL;

namespace EcoMotion.FORMS
{
    public partial class frmNewRepair : Form
    {
        DataTable Trepairing;
        DataTable TspareParts;
        DataTable Tworkers;
        DataTable TmotorID;
        DataTable TusageAid;
        DataTable TworkerRpAid;
        int codeValue;
        int rowIndex = 1;
        int rowIndexOperations = 1;
        bool existed1;
        string fullWorkerName;
        string[] oldOperations;
        List<int> preUpdateStock = new List<int>();
        public frmNewRepair(string motorSerialNumber, string customer, bool existed)
        {
            InitializeComponent();
            motorSerialNumber_txt.ReadOnly = existed;
            motorSerialNumber_txt.Text = motorSerialNumber;
            customerID_txt.Text = customer;
            Trepairing = DAL.dbEcoMotion.OpenTable("Repairing");
            codeValue = Trepairing.Rows.Count + 1;
            repairingCode_txt.Text = codeValue.ToString() + "00";
            existed1 = existed;

        }

        private void frmNewRepair_Load(object sender, EventArgs e)
        {
            TspareParts = DAL.dbEcoMotion.OpenTable("SpareParts");
            UTILITIES.DisplayUtilities.FillDataGrid(spareParts_dgv, TspareParts);
            TmotorID = DAL.dbEcoMotion.OpenTable("Motor");
            motorID_cbm.Items.Clear();
            for(int i=0;i<TmotorID.Rows.Count;i++)
            {
                motorID_cbm.Items.Add(TmotorID.Rows[i][0].ToString());
            }
            errorProvider1.Clear();
        }
        private bool CheckDetails(Repairing re)
        {           
        bool check = true;
            try
            {
                re.MotorSerialNumber = motorSerialNumber_txt.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(motorSerialNumber_txt, "enter motor serial number in correct format");
                check = false;
            }
            try
            {
                re.Status = status_cbm.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(status_cbm, "enter status in correct format");
                check = false;
            }
            try
            {
                re.MotorId = motorID_cbm.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(motorID_cbm, "enter motor ID in correct format");
                check = false;
            }
            try
            {
                re.FaultDescription = faultDescription_txt.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(faultDescription_txt, "enter fault Description ID in correct format");
                check = false;
            }
            try
            {
                re.PossibleCauses = possibleCauses_txt.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(possibleCauses_txt, "enter possible causes ID in correct format");
                check = false;
            }
            try
            {
                re.Warranty = warrenty_cbm.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(warrenty_cbm, "enter warrenty ID in correct format");
                check = false;
            }
            try
            {
                re.History = history_txt.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(history_txt, "enter history ID in correct format");
                check = false;
            }
            try
            {
                re.BeginingDate = startDate_dtp.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(startDate_dtp, "enter start date ID in correct format");
                check = false;
            }
            try
            {
                re.EndDate = endDate_dtp.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(endDate_dtp, "enter end date ID in correct format");
                check = false;
            }
            
            return check;


        }

        private void addWorkerOperations_btn_Click(object sender, EventArgs e)
        {
            string s = "";
            if (p_Cbox.Checked)
                s = s + ",פירוק";
            if (h_Cbox.Checked)
                s = s + ",הרכבה";
            if (ye_Cbox.Checked)
                s = s + ",ייבוש";
            if (haMe_Cbox.Checked)
                s = s + ",החלפת מיסבים";
            if (le_Cbox.Checked)
                s = s + ",ליפוף";
            if (i_Cbox.Checked)
                s = s + ",איזון";
            string repairingDescription = s;//לא עובד.Remove(s.Length-1);
            string IDInput = Interaction.InputBox("Enter your ID number please:", "", "", 200, 200);
            MessageBox.Show(IDInput);
            Tworkers = DAL.dbEcoMotion.OpenTable("Worker");
            bool found = false;
            string nameWorker = "";
            for (int i = 0; i < Tworkers.Rows.Count && !found; i++)
                if (IDInput.Equals(Tworkers.Rows[i][0].ToString()))
                {
                    found = true;
                    nameWorker = IDInput;
                    fullWorkerName = Tworkers.Rows[i][1].ToString()+" " + Tworkers.Rows[i][2].ToString();
                }


            string hoursCountInput = "0";
            int index1 = 0;
            bool workerExisted = false;
            if (found)
            {
                for (int i = 0; i < totalOperations_dgv.Rows.Count - 1; i++)
                {
                    if (nameWorker.Equals(totalOperations_dgv.Rows[i].Cells[1].Value.ToString()))
                    {

                        double newHoursCount;
                        while (Convert.ToDouble(hoursCountInput) <= 0)
                            hoursCountInput = Interaction.InputBox("Enter hours of work:", "enter positive number", "", 200, 200);
                        newHoursCount = Convert.ToDouble(totalOperations_dgv.Rows[i].Cells[3].Value.ToString()) + Convert.ToDouble(hoursCountInput);
                        totalOperations_dgv.Rows[i].Cells[3].Value = newHoursCount;
                        workerExisted = true;
                        if (totalOperations_dgv.Rows[i].Cells[4].Value != null)
                            oldOperations = totalOperations_dgv.Rows[i].Cells[4].Value.ToString().Split(',');
                        totalOperations_dgv.Rows[i].Cells[4].Value = CreatingNewDescription(oldOperations);
                    }
                }

                if (!workerExisted)
                {
                    while (Convert.ToDouble(hoursCountInput) <= 0)
                        hoursCountInput = Interaction.InputBox("Enter hours of work:", "enter positive number", "", 200, 200);
                    totalOperations_dgv.Rows.Add(codeValue.ToString(), IDInput, fullWorkerName, hoursCountInput.ToString(), repairingDescription);
                    rowIndexOperations++;
                }

                MessageBox.Show("בבקשה לחץ על החלקים בהם השתמשת במהלך השיפוץ בטבלת החלפים והזן את הכמות שהשתמשת");

            }
            else
                MessageBox.Show("תעודת הזהות אינה במערכת, נסה שוב");
            p_Cbox.Checked = false;
            h_Cbox.Checked = false;
            ye_Cbox.Checked = false;
            haMe_Cbox.Checked = false;
            le_Cbox.Checked = false;
            i_Cbox.Checked = false;

        }
        public string CreatingNewDescription(string[] oldDescription)
        {
            string newDescriptionStr = "";
            string[] newDescription = new string[6];
            for (int i = 0; i < newDescription.Length; i++)
                newDescription[i] = "";
            for (int i = 0; i < oldDescription.Length; i++)
            {
                if (oldDescription[i] == "פירוק")
                    newDescription[0] = "פירוק";
                else if (oldDescription[i] == "הרכבה")
                    newDescription[1] = "הרכבה";
                else if (oldDescription[i] == "ייבוש")
                    newDescription[2] = "ייבוש";
                else if (oldDescription[i] == "החלפת מיסבים")
                    newDescription[3] = "החלפת מיסבים";
                else if (oldDescription[i] == "ליפוף")
                    newDescription[4] = "ליפוף";
                else if (oldDescription[i] == "איזון")
                    newDescription[5] = "איזון";

            }
            if (p_Cbox.Checked)
                newDescription[0] = "פירוק";
            if (h_Cbox.Checked)
                newDescription[1] = "הרכבה";
            if (ye_Cbox.Checked)
                newDescription[2] = "ייבוש";
            if (haMe_Cbox.Checked)
                newDescription[3] = "החלפת מיסבים";
            if (le_Cbox.Checked)
                newDescription[4] = "ליפוף";
            if (i_Cbox.Checked)
                newDescription[5] = "איזון";
            for (int i = 0; i < newDescription.Length; i++)
            {
                if (newDescription[i] != "")
                    newDescriptionStr = newDescriptionStr + newDescription[i] + ",";
            }
            return newDescriptionStr;
        }

        private void spareParts_dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int price;
            bool existed = false;
            int quntitiyInStock = int.Parse(spareParts_dgv.Rows[e.RowIndex].Cells[5].Value.ToString());
            string quantityInput = Interaction.InputBox("Enter number of parts you have been used for this fixing:", "", "please enter integer number", 200, 200);
            int quantity;
            if (int.Parse(quantityInput) < quntitiyInStock && int.Parse(quantityInput) > 0)
            {

                for (int i = 0; i < usage_dgv.Rows.Count - 1; i++)
                {
                    if (spareParts_dgv.Rows[e.RowIndex].Cells[0].Value.ToString().Equals(usage_dgv.Rows[i].Cells[1].Value.ToString()))
                    {
                        quantity = int.Parse(quantityInput) + int.Parse(usage_dgv.Rows[i].Cells[4].Value.ToString());
                        if (quantity < quntitiyInStock)
                            usage_dgv.Rows[i].Cells[4].Value = quantity.ToString();
                        price = int.Parse(spareParts_dgv.Rows[e.RowIndex].Cells[2].Value.ToString()) * quantity;
                        usage_dgv.Rows[i].Cells[3].Value = price.ToString();
                        
                        existed = true;
                    }

                }
                if (!existed)
                {
                    price = int.Parse(spareParts_dgv.Rows[e.RowIndex].Cells[2].Value.ToString()) * int.Parse(quantityInput);
                    usage_dgv.Rows.Add(codeValue.ToString(), spareParts_dgv.Rows[e.RowIndex].Cells[0].Value.ToString(), spareParts_dgv.Rows[e.RowIndex].Cells[1].Value.ToString(), price, quantityInput);
                    preUpdateStock.Add(int.Parse(spareParts_dgv.Rows[e.RowIndex].Cells[5].Value.ToString()));
                    MessageBox.Show(preUpdateStock[0].ToString());
                    
                    rowIndex++;

                }
            }
        } 
        public string AllOperationsOnAMotor()
        {
            string allOperations;
            allOperations = "";
            string[] totalOperation;
            string[] finalTotalOperation = new string[6];
            for (int i = 0; i < finalTotalOperation.Length; i++)
                finalTotalOperation[i] = "";
            for(int i =0;i<totalOperations_dgv.Rows.Count-1;i++)
            {
                totalOperation = totalOperations_dgv.Rows[i].Cells[4].Value.ToString().Split(',');
                totalOperation[0] = "fgh";
                
                for (int y = 0; y < totalOperation.Length; y++)
                {
                    if (totalOperation[y] == "פירוק")
                        finalTotalOperation[0] = "פירוק";
                    else if (totalOperation[y] == "הרכבה")
                        finalTotalOperation[1] = "הרכבה";
                    else if (totalOperation[y] == "ייבוש")
                        finalTotalOperation[2] = "ייבוש";
                    else if (totalOperation[y] == "החלפת מיסבים")
                        finalTotalOperation[3] = "החלפת מיסבים";
                    else if (totalOperation[y] == "ליפוף")
                        finalTotalOperation[4] = "ליפוף";
                    else if (totalOperation[y] == "איזון")
                        finalTotalOperation[5] = "איזון";

                }
            }
            MessageBox.Show(allOperations);
            for (int i = 0; i < finalTotalOperation.Length; i++)
            {
                if (finalTotalOperation[i] != "")
                    allOperations = allOperations + finalTotalOperation[i] + ",";
            }
            return allOperations;
        }

        private void saveFixing_btn_Click(object sender, EventArgs e)
        {
            Repairing re = new Repairing();
            if(CheckDetails(re))
            {
                string strSql;
                string strSql1;
                string strSql2;
                int updatedStock;
                MessageBox.Show(AllOperationsOnAMotor());
                int[] preUpdateStockArr = preUpdateStock.ToArray();
                for (int i = 0; i < preUpdateStockArr.Length; i++)
                {
                    MessageBox.Show(preUpdateStockArr[i].ToString());
                }
                TworkerRpAid = DAL.dbEcoMotion.OpenTable("WorkerRp");
                TspareParts = DAL.dbEcoMotion.OpenTable("SpareParts");
                Trepairing = DAL.dbEcoMotion.OpenTable("Repairing");
                TusageAid = DAL.dbEcoMotion.OpenTable("Usage1");
                strSql2 = "INSERT INTO Repairing(reparingCode, customerID, motorSerialNumber,status,motorId,faultDescription,repairingDescription,possibleCauses,warranty,history,beginingDate,endDate) VALUES('" + repairingCode_txt.Text + "', '" + customerID_txt.Text + "', '" + motorSerialNumber_txt.Text + "', '" + status_cbm.Text + "', '" + motorID_cbm.Text + "', '" + faultDescription_txt.Text + "', '" + AllOperationsOnAMotor() + "', '" + possibleCauses_txt.Text + "', '" + warrenty_cbm.Text + "', '" + history_txt.Text + "', '" + startDate_dtp.Text + "', '" + endDate_dtp.Text + "')";
                MessageBox.Show(UTILITIES.GeneralUtilities.AddRecd(Trepairing, strSql2));
                for (int i = 0; i < rowIndex - 1; i++)
                {
                    updatedStock = preUpdateStockArr[i] - int.Parse(usage_dgv.Rows[i].Cells[4].Value.ToString());
                    MessageBox.Show(updatedStock.ToString());
                    strSql = "UPDATE SpareParts SET quntityInstock = " + updatedStock.ToString() + " WHERE idPart = '" + usage_dgv.Rows[i].Cells[1].Value.ToString() + "'";
                    UTILITIES.GeneralUtilities.UpDateRecd(TspareParts, strSql);

                    strSql1 = "INSERT INTO Usage1(idRepair,idPart,price,quantity) VALUES ('" + repairingCode_txt.Text + "','" + usage_dgv.Rows[i].Cells[1].Value.ToString() + "','" + usage_dgv.Rows[i].Cells[3].Value.ToString() + "','" + usage_dgv.Rows[i].Cells[4].Value.ToString() + "')";
                    MessageBox.Show(UTILITIES.GeneralUtilities.AddRecd(TusageAid, strSql1));
                }
                for (int i = 0; i < rowIndexOperations - 1; i++)
                {
                    strSql1 = "INSERT INTO WorkerRp(idWorker,idRepair,reparingDescription,houersCount) VALUES ('" + totalOperations_dgv.Rows[i].Cells[1].Value.ToString() + "','" + totalOperations_dgv.Rows[i].Cells[0].Value.ToString() + "00" + "','" + totalOperations_dgv.Rows[i].Cells[4].Value.ToString() + "','" + totalOperations_dgv.Rows[i].Cells[3].Value.ToString() + "')";
                    MessageBox.Show(UTILITIES.GeneralUtilities.AddRecd(TworkerRpAid, strSql1));
                }
            }
            
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void refreshDisplay_Click(object sender, EventArgs e)
        {
            frmNewRepair_Load(sender, e);
        }
    }
}
