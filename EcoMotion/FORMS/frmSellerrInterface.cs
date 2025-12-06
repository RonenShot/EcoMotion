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
    public partial class frmSellerrInterface : Form
    {
        public frmSellerrInterface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCustomer f1 = new frmCustomer();
            f1.ShowDialog();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            rptInventoryList f1 = new rptInventoryList();
            f1.ShowDialog();
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
