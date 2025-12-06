using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EcoMotion.FORMS;

namespace EcoMotion
{
    public partial class Form1 : Form
    {
        int x = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCustomer f = new frmCustomer();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMotor f = new frmMotor();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSpareParts f = new frmSpareParts();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmInventory f = new frmInventory();
            f.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmWorker f = new frmWorker();
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmSale f = new frmSale("");
            f.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //frmSaleDetails f = new frmSaleDetails();
            //f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //frmRepairing f = new frmRepairing();
            
            //f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logo.Location = new Point( (Form1.ActiveForm.Width / 2) - (logo.Width / 2),12);
            login.Location = new Point((Form1.ActiveForm.Width / 2) - (login.Width / 2), 700);
            label1.Location = new Point((Form1.ActiveForm.Width / 2)-500 , 200);
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            frmSpareParts f = new frmSpareParts();
            f.ShowDialog();
        }

        private void rpt_Click(object sender, EventArgs e)
        {
            EcoMotion.REPORTS.rptCustomersList f1 = new REPORTS.rptCustomersList();
            f1.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            EcoMotion.REPORTS.rptWorkersList f1 = new REPORTS.rptWorkersList();
            f1.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            EcoMotion.REPORTS.rptSpareParts f1 = new REPORTS.rptSpareParts();
            f1.ShowDialog();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            EcoMotion.REPORTS.rptInventoryList f1 = new REPORTS.rptInventoryList();
            f1.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EcoMotion.REPORTS.rptMotorList f1 = new REPORTS.rptMotorList();
            f1.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmLogin f1 = new frmLogin();
            f1.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            EcoMotion.REPORTS.rptSaleIncome f1 = new REPORTS.rptSaleIncome();
            f1.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            EcoMotion.REPORTS.rptSpareParts f1 = new REPORTS.rptSpareParts();
            f1.ShowDialog();
        }

        private void login_Click(object sender, EventArgs e)
        {
            frmLogin f1 = new frmLogin();
            f1.ShowDialog();
        }

        private void about_Click(object sender, EventArgs e)
        {
            x = x * (-1);
            if(x==1)
               label1.Visible = true;
            else
                label1.Visible = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
