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
            frmFactory f = new frmFactory();
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
            frmSaleDetails f = new frmSaleDetails();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmRapairing f = new frmRapairing();
            
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
