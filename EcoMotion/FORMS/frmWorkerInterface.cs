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
    public partial class frmWorkerInterface : Form
    {
        public frmWorkerInterface()
        {
            InitializeComponent();
        }

        private void frmWorkerInterface_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            rptInventoryList f1 = new rptInventoryList();
            f1.ShowDialog();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            rptMotorList f1 = new rptMotorList();
            f1.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCustomer f1 = new frmCustomer();
            f1.ShowDialog();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            rptSpareParts f1 = new rptSpareParts();
            f1.ShowDialog();
           
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
