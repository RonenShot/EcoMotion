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
    public partial class frmRepairing : Form
    {
        DataTable Trepairing;
        DataTable Tgeneral;
        DataTable Tusage;
        int count = 0;

        public frmRepairing(string customer)
        {
            InitializeComponent();
            customerID_txtbox.Text = customer;
        }



        private void frmRapairing_Load(object sender, EventArgs e)
        {

            Location = new Point(200, 200);

            string strSql = "Select * from Repairing where customerID='" + customerID_txtbox.Text + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            Trepairing = DAL.dbEcoMotion.ds.Tables[0];
            if (Trepairing.Rows.Count != 0)
            {
                UTILITIES.DisplayUtilities.FillDataGrid(repairing_dgv, Trepairing);
                DisplayRecord(0);
            }
            else
                MessageBox.Show("לא קיימים שיפוצים במערכת בעבור לקוח זה");
               

        }
        private void DisplayRecord(int numRow)
        {
            p_Cbox.Checked = false;
            h_Cbox.Checked = false;
            ye_Cbox.Checked = false;
            haMe_Cbox.Checked = false;
            le_Cbox.Checked = false;
            i_Cbox.Checked = false;
            string s = repairing_dgv.Rows[numRow].Cells[0].Value.ToString();
            string strSql = "Select * from WorkerRp where idRepair='" + s + "'";
            dbEcoMotion.GetDataSet(strSql);
            Tgeneral = dbEcoMotion.ds.Tables[0];
            
            UTILITIES.DisplayUtilities.FillDataGrid(workerRepair_dgv, Tgeneral);
            strSql = "Select * from Usage1 where idRepair='" + s + "'";
            dbEcoMotion.GetDataSet(strSql);
            Tgeneral = dbEcoMotion.ds.Tables[0];
            
            UTILITIES.DisplayUtilities.FillDataGrid(usage_dgv, Tgeneral);

            repairCode_txtbox.Text = repairing_dgv.Rows[numRow].Cells[0].Value.ToString();

            motorSerialNumber_txtbox.Text = repairing_dgv.Rows[numRow].Cells[2].Value.ToString();
            status_txt.Text = repairing_dgv.Rows[numRow].Cells[3].Value.ToString();
            motorId_txt.Text = repairing_dgv.Rows[numRow].Cells[4].Value.ToString();
            faultDescription_txt.Text = repairing_dgv.Rows[numRow].Cells[5].Value.ToString();

            possibleCauses_txt.Text = repairing_dgv.Rows[numRow].Cells[7].Value.ToString();
            warrenty_txt.Text = repairing_dgv.Rows[numRow].Cells[8].Value.ToString();
            History_txt.Text = repairing_dgv.Rows[numRow].Cells[9].Value.ToString();
            startDate_txt.Text = repairing_dgv.Rows[numRow].Cells[10].Value.ToString();
            endDate_txt.Text = repairing_dgv.Rows[numRow].Cells[11].Value.ToString();
            string repairingDescription = repairing_dgv.Rows[numRow].Cells[6].Value.ToString();
            string[] actions;
            actions = repairingDescription.Split(',');
            
            for (int i = 0; i < actions.Length; i++)
            {
                if (actions[i] == "פירוק")
                    p_Cbox.Checked = true;
                else if (actions[i] == "הרכבה")
                    h_Cbox.Checked = true;
                else if (actions[i] == "ייבוש")
                    ye_Cbox.Checked = true;
                else if (actions[i] == "החלפת מיסבים")
                    haMe_Cbox.Checked = true;
                else if (actions[i] == "ליפוף")
                    le_Cbox.Checked = true;
                else if (actions[i] == "איזון")
                    i_Cbox.Checked = true;
            }

        }

        private void moveNext_btn_Click(object sender, EventArgs e)
        {
            string strSql = "Select * from Repairing where customerID='" + customerID_txtbox.Text + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            Trepairing = DAL.dbEcoMotion.ds.Tables[0];
            count = UTILITIES.GeneralUtilities.MoveNext(Trepairing, count);
            DisplayRecord(count);
        }

        private void movePrev_btn_Click(object sender, EventArgs e)
        {
            string strSql = "Select * from Repairing where customerID='" + customerID_txtbox.Text + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            Trepairing = DAL.dbEcoMotion.ds.Tables[0];
            count = UTILITIES.GeneralUtilities.MovePrev(Trepairing, count);
            DisplayRecord(count);
        }

        private void moveLast_btn_Click(object sender, EventArgs e)
        {
            string strSql = "Select * from Repairing where customerID='" + customerID_txtbox.Text + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            Trepairing = DAL.dbEcoMotion.ds.Tables[0];
            count = UTILITIES.GeneralUtilities.GoToLast(Trepairing, count);
            DisplayRecord(count);
        }

        private void moveFirst_btn_Click(object sender, EventArgs e)
        {
            string strSql = "Select * from Repairing where customerID='" + customerID_txtbox.Text + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            Trepairing = DAL.dbEcoMotion.ds.Tables[0];
            count = UTILITIES.GeneralUtilities.GoToFirst(Trepairing, count);
            DisplayRecord(count);
        }

        private void frmRapairing_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void repairingHistory_dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string s = repairing_dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            string strSql = "Select * from WorkerRp where idRepair='" + s + "'";
            dbEcoMotion.GetDataSet(strSql);
            Tgeneral = dbEcoMotion.ds.Tables[0];
            
            UTILITIES.DisplayUtilities.FillDataGrid(workerRepair_dgv, Tgeneral);
            strSql = "Select * from Usage1 where idRepair='" + s + "'";
            dbEcoMotion.GetDataSet(strSql);
            Tgeneral = dbEcoMotion.ds.Tables[0];
            
            UTILITIES.DisplayUtilities.FillDataGrid(usage_dgv, Tgeneral);
            DisplayRecord(e.RowIndex);
            count = e.RowIndex;
        }

        private void searchPurchase_Click(object sender, EventArgs e)
        {
            string numrepairing = searchCode_txtbox.Text;
            string strSql = "Select * from repairing where reparingCode='" + numrepairing + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            MessageBox.Show(DAL.dbEcoMotion.ds.Tables[0].Rows.Count.ToString());
            Trepairing = DAL.dbEcoMotion.ds.Tables[0];
            MessageBox.Show(numrepairing);
            if (Trepairing.Rows.Count == 0)
                MessageBox.Show("לא קיים שיפוץ כזה");
            else
            {
                p_Cbox.Checked = false;
                h_Cbox.Checked = false;
                ye_Cbox.Checked = false;
                haMe_Cbox.Checked = false;
                le_Cbox.Checked = false;
                i_Cbox.Checked = false;
                strSql = "Select * from WorkerRp where idRepair='" + numrepairing + "'";
                dbEcoMotion.GetDataSet(strSql);
                Tgeneral = dbEcoMotion.ds.Tables[0];
                MessageBox.Show(Tgeneral.Rows.Count.ToString());
                UTILITIES.DisplayUtilities.FillDataGrid(workerRepair_dgv, Tgeneral);
                strSql = "Select * from Usage1 where idRepair='" + numrepairing + "'";
                dbEcoMotion.GetDataSet(strSql);
                Tgeneral = dbEcoMotion.ds.Tables[0];
                MessageBox.Show(Tgeneral.Rows.Count.ToString());
                UTILITIES.DisplayUtilities.FillDataGrid(usage_dgv, Tgeneral);
                repairCode_txtbox.Text = Trepairing.Rows[0][0].ToString();
                motorSerialNumber_txtbox.Text = Trepairing.Rows[0][2].ToString();
                status_txt.Text = Trepairing.Rows[0][3].ToString();
                motorId_txt.Text = Trepairing.Rows[0][4].ToString();
                faultDescription_txt.Text = Trepairing.Rows[0][5].ToString();
                possibleCauses_txt.Text = Trepairing.Rows[0][7].ToString();
                warrenty_txt.Text = Trepairing.Rows[0][8].ToString();
                History_txt.Text = Trepairing.Rows[0][9].ToString();
                startDate_txt.Text = Trepairing.Rows[0][10].ToString();
                endDate_txt.Text = Trepairing.Rows[0][11].ToString();
                string repairingDescription = Trepairing.Rows[0][6].ToString(); ;
                string[] actions;
                actions = repairingDescription.Split(',');
                for (int i = 0; i < actions.Length; i++)
                    MessageBox.Show(actions[i]);
                for (int i = 0; i < actions.Length; i++)
                {
                    if (actions[i] == "פירוק")
                        p_Cbox.Checked = true;
                    else if (actions[i] == "הרכבה")
                        h_Cbox.Checked = true;
                    else if (actions[i] == "ייבוש")
                        ye_Cbox.Checked = true;
                    else if (actions[i] == "החלפת מיסבים")
                        haMe_Cbox.Checked = true;
                    else if (actions[i] == "ליפוף")
                        le_Cbox.Checked = true;
                    else if (actions[i] == "איזון")
                        i_Cbox.Checked = true;
                }



            }


        }

        private void mtSearch_btn_Click(object sender, EventArgs e)
        {
            string numMotor = mtSearch_txt.Text;
            string strSql = "Select * from repairing where motorSerialNumber='" + numMotor + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            MessageBox.Show(DAL.dbEcoMotion.ds.Tables[0].Rows.Count.ToString());
            Trepairing = DAL.dbEcoMotion.ds.Tables[0];
            MessageBox.Show(numMotor);
            if (Trepairing.Rows.Count == 0)
                MessageBox.Show("לא קיים מנוע כזה"); 
            else
                UTILITIES.DisplayUtilities.FillDataGrid(repairing_dgv, Trepairing);


        }

        private void addRepairing_btn_Click(object sender, EventArgs e)
        {
            frmNewRepair f = new frmNewRepair("",customerID_txtbox.Text,false);
            f.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void refreshDisplay_Click(object sender, EventArgs e)
        {
            frmRapairing_Load(sender, e);
        }

        private void clearScreen_Click(object sender, EventArgs e)
        {
            searchCode_txtbox.Text="";
            mtSearch_txt.Text = "";
        }

        private void moveNext_Click(object sender, EventArgs e)
        {
            string strSql = "Select * from Repairing where customerID='" + customerID_txtbox.Text + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            Trepairing = DAL.dbEcoMotion.ds.Tables[0];
            count = UTILITIES.GeneralUtilities.MoveNext(Trepairing, count);
            DisplayRecord(count);
        }

        private void movePrev_Click(object sender, EventArgs e)
        {
            string strSql = "Select * from Repairing where customerID='" + customerID_txtbox.Text + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            Trepairing = DAL.dbEcoMotion.ds.Tables[0];
            count = UTILITIES.GeneralUtilities.MovePrev(Trepairing, count);
            DisplayRecord(count);
        }

        private void moveLast_Click(object sender, EventArgs e)
        {
            string strSql = "Select * from Repairing where customerID='" + customerID_txtbox.Text + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            Trepairing = DAL.dbEcoMotion.ds.Tables[0];
            count = UTILITIES.GeneralUtilities.GoToLast(Trepairing, count);
            DisplayRecord(count);
        }

        private void moveFirst_Click(object sender, EventArgs e)
        {
            string strSql = "Select * from Repairing where customerID='" + customerID_txtbox.Text + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            Trepairing = DAL.dbEcoMotion.ds.Tables[0];
            count = UTILITIES.GeneralUtilities.GoToFirst(Trepairing, count);
            DisplayRecord(count);
        }

        private void search_Click(object sender, EventArgs e)
        {
            string numrepairing = searchCode_txtbox.Text;
            string strSql = "Select * from repairing where reparingCode='" + numrepairing + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            MessageBox.Show(DAL.dbEcoMotion.ds.Tables[0].Rows.Count.ToString());
            Trepairing = DAL.dbEcoMotion.ds.Tables[0];
            MessageBox.Show(numrepairing);
            if (Trepairing.Rows.Count == 0)
                MessageBox.Show("לא קיים שיפוץ כזה");
            else
            {
                p_Cbox.Checked = false;
                h_Cbox.Checked = false;
                ye_Cbox.Checked = false;
                haMe_Cbox.Checked = false;
                le_Cbox.Checked = false;
                i_Cbox.Checked = false;
                strSql = "Select * from WorkerRp where idRepair='" + numrepairing + "'";
                dbEcoMotion.GetDataSet(strSql);
                Tgeneral = dbEcoMotion.ds.Tables[0];
                MessageBox.Show(Tgeneral.Rows.Count.ToString());
                UTILITIES.DisplayUtilities.FillDataGrid(workerRepair_dgv, Tgeneral);
                strSql = "Select * from Usage1 where idRepair='" + numrepairing + "'";
                dbEcoMotion.GetDataSet(strSql);
                Tgeneral = dbEcoMotion.ds.Tables[0];
                MessageBox.Show(Tgeneral.Rows.Count.ToString());
                UTILITIES.DisplayUtilities.FillDataGrid(usage_dgv, Tgeneral);
                repairCode_txtbox.Text = Trepairing.Rows[0][0].ToString();
                motorSerialNumber_txtbox.Text = Trepairing.Rows[0][2].ToString();
                status_txt.Text = Trepairing.Rows[0][3].ToString();
                motorId_txt.Text = Trepairing.Rows[0][4].ToString();
                faultDescription_txt.Text = Trepairing.Rows[0][5].ToString();
                possibleCauses_txt.Text = Trepairing.Rows[0][7].ToString();
                warrenty_txt.Text = Trepairing.Rows[0][8].ToString();
                History_txt.Text = Trepairing.Rows[0][9].ToString();
                startDate_txt.Text = Trepairing.Rows[0][10].ToString();
                endDate_txt.Text = Trepairing.Rows[0][11].ToString();
                string repairingDescription = Trepairing.Rows[0][6].ToString(); ;
                string[] actions;
                actions = repairingDescription.Split(',');
                for (int i = 0; i < actions.Length; i++)
                    MessageBox.Show(actions[i]);
                for (int i = 0; i < actions.Length; i++)
                {
                    if (actions[i] == "פירוק")
                        p_Cbox.Checked = true;
                    else if (actions[i] == "הרכבה")
                        h_Cbox.Checked = true;
                    else if (actions[i] == "ייבוש")
                        ye_Cbox.Checked = true;
                    else if (actions[i] == "החלפת מיסבים")
                        haMe_Cbox.Checked = true;
                    else if (actions[i] == "ליפוף")
                        le_Cbox.Checked = true;
                    else if (actions[i] == "איזון")
                        i_Cbox.Checked = true;
                }



            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string numMotor = mtSearch_txt.Text;
            string strSql = "Select * from repairing where motorSerialNumber='" + numMotor + "'";
            DAL.dbEcoMotion.GetDataSet(strSql);
            MessageBox.Show(DAL.dbEcoMotion.ds.Tables[0].Rows.Count.ToString());
            Trepairing = DAL.dbEcoMotion.ds.Tables[0];
            MessageBox.Show(numMotor);
            if (Trepairing.Rows.Count == 0)
                MessageBox.Show("לא קיים מנוע כזה");
            else
                UTILITIES.DisplayUtilities.FillDataGrid(repairing_dgv, Trepairing);
        }
    }
}
