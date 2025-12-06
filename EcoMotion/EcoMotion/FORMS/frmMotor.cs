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

                strSql = "Select * from Motor where id='" + motorID_txtbox.Text + "'";
                DAL.dbEcoMotion.GetDataSet(strSql);
                //MessageBox.Show(dbEcoMotion.ds.Tables[0].Rows.Count.ToString());
               // if (DAL.dbEcoMotion.ds.Tables[0].Rows.Count > 0)
               //     MessageBox.Show("רשומה כבר קיימת");
               // else
                //{
                    strSql = "INSERT INTO Motor(motorID,electricalConnectionType,voltageType,rpm,hp,productionLand,numberOfSlots,efficiency,structreType,manufacturer) VALUES ('" + motorID_txtbox.Text + "','" + electricalConnectionType_txtbox.Text + "','" + voltageType_txtbox.Text + "','" + rpm_txtbox.Text + "','" + hp_txtbox.Text + "','" + productionLand_txtbox.Text + "','" + numberOfSlots_txtbox.Text + "','" + efficiency_txtbox.Text + "','" + structreType_txtbox.Text + "','" +manufacturer_txtbox.Text +  "')";
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
               // }
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
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
