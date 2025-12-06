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
    public partial class frmRapairing : Form
    {
        public frmRapairing()
        {
            InitializeComponent();
        }
        int count = 0;
        DataTable TRepairing;
        DialogResult dr;
        private void frmRapairing_Load(object sender, EventArgs e)
        {
            Location = new Point(200, 200);
            TRepairing = DAL.dbEcoMotion.OpenTable("Repairing");
            UTILITIES.DisplayUtilities.FillDataGrid(dataGridView1, TRepairing);
            DisplayRecord(count);
            UTILITIES.DisplayUtilities.FillDataGrid(dataGridView1, TRepairing);
            count = 0;
        }
        private void DisplayRecord(int numRow)
        {
            workerID_txtbox.Text = dataGridView1.Rows[numRow].Cells[0].Value.ToString();
            motorSerialNumber_txtbox.Text = dataGridView1.Rows[numRow].Cells[1].Value.ToString();
            startDate_txtbox.Text = dataGridView1.Rows[numRow].Cells[2].Value.ToString();
            endDate_txtbox.Text = dataGridView1.Rows[numRow].Cells[3].Value.ToString();
            repairingDescription_txtbox.Text = dataGridView1.Rows[numRow].Cells[4].Value.ToString();
            

        }

        private void moveNext_btn_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MoveNext(TRepairing, count);
            DisplayRecord(count);
        }

        private void movePrev_btn_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MovePrev(TRepairing, count);
            DisplayRecord(count);
        }

        private void moveLast_btn_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToLast(TRepairing, count));
        }

        private void moveFirst_btn_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToFirst(TRepairing, count));
        }

        private void frmRapairing_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
