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
    public partial class frmFactory : Form
    {
        public frmFactory()
        {
            InitializeComponent();
        }
        int count = 0;
        DataTable Tfactory;
        DialogResult dr;
        private void frmFactory_Load(object sender, EventArgs e)
        {
            Location = new Point(200, 200);
            Tfactory = DAL.dbEcoMotion.OpenTable("Factory");
            UTILITIES.DisplayUtilities.FillDataGrid(dataGridView1, Tfactory);
            DisplayRecord(count);
            UTILITIES.DisplayUtilities.FillDataGrid(dataGridView1, Tfactory);
            count = 0;
        }
        private void DisplayRecord(int numRow)
        {
            companyNumber_txtbox.Text = dataGridView1.Rows[numRow].Cells[0].Value.ToString();
            factoryName_txtbox.Text = dataGridView1.Rows[numRow].Cells[1].Value.ToString();
            daysForPayments_txtbox.Text = dataGridView1.Rows[numRow].Cells[2].Value.ToString();
            phoneNumber_txtbox.Text = dataGridView1.Rows[numRow].Cells[3].Value.ToString();
            representativeName_txtbox.Text = dataGridView1.Rows[numRow].Cells[4].Value.ToString();
            representativePhoneNumber_txtbox.Text = dataGridView1.Rows[numRow].Cells[5].Value.ToString();
            mail_txtbox.Text = dataGridView1.Rows[numRow].Cells[6].Value.ToString();
            maintainManegerName_txtbox.Text = dataGridView1.Rows[numRow].Cells[7].Value.ToString();
            maintainManegerPhoneNumber_txtbox.Text = dataGridView1.Rows[numRow].Cells[8].Value.ToString();
            
        }

        private void moveNext_btn_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MoveNext(Tfactory, count);
            DisplayRecord(count);
        }

        private void movePrev_btn_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MoveNext(Tfactory, count);
            DisplayRecord(count);
        }

        private void moveLast_btn_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToLast(Tfactory, count));
        }

        private void moveFirst_btn_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToFirst(Tfactory, count));
        }

        private void frmFactory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
