using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EcoMotion.REPORTS;

namespace EcoMotion.FORMS
{
    public partial class frmMangerInterface : Form
    {
        public frmMangerInterface()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            rptInventoryList f1 = new rptInventoryList();
            f1.ShowDialog();
            
        }

        private void rpt_Click(object sender, EventArgs e)
        {
            rptCustomersList f1 = new rptCustomersList();
            f1.ShowDialog();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            rptMotorList f1 = new rptMotorList();
            f1.ShowDialog();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            rptSaleIncome f1 = new rptSaleIncome();
            f1.ShowDialog();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            rptSpareParts f1 = new rptSpareParts();
            f1.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rptWorkersList f1 = new rptWorkersList();
            f1.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMotor f1 = new frmMotor();
            f1.ShowDialog();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmSpareParts f1 = new frmSpareParts();
            f1.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCustomer f1 = new frmCustomer();
            f1.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmWorker f1 = new frmWorker();
            f1.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmInventory f1 = new frmInventory();
            f1.ShowDialog();
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
