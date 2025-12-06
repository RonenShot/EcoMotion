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
            startDate_txtbox.Text = dataGridView1.Rows[numRow].Cells[8].Value.ToString();
            

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
            Application.Exit();
        }
    }
}
