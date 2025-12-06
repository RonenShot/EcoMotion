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
    public partial class frmSaleDetails : Form
    {
        public frmSaleDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int count = 0;
        DataTable TsaleDetails;
        DialogResult dr;
        private void frmSaleDetails_Load(object sender, EventArgs e)
        {
            Location = new Point(200, 200);
            TsaleDetails = DAL.dbEcoMotion.OpenTable("SaleDetails");
            UTILITIES.DisplayUtilities.FillDataGrid(dataGridView1, TsaleDetails);
            DisplayRecord(count);
            UTILITIES.DisplayUtilities.FillDataGrid(dataGridView1, TsaleDetails);
            count = 0;
        }
        private void DisplayRecord(int numRow)
        {
            motorSerialNumber_txtbox.Text = dataGridView1.Rows[numRow].Cells[1].Value.ToString();
            codeSale_txtbox.Text = dataGridView1.Rows[numRow].Cells[0].Value.ToString();
            

        }

        private void frmSaleDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void moveFirst_btn_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToFirst(TsaleDetails, count));
        }

        private void movePrev_btn_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MovePrev(TsaleDetails, count);
            DisplayRecord(count);
        }

        private void moveLast_btn_Click(object sender, EventArgs e)
        {
            DisplayRecord(UTILITIES.GeneralUtilities.GoToLast(TsaleDetails, count));
        }

        private void moveNext_btn_Click(object sender, EventArgs e)
        {
            count = UTILITIES.GeneralUtilities.MoveNext(TsaleDetails, count);
            DisplayRecord(count);
        }
    }
}
